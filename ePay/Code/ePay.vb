Imports System.Threading.Tasks
Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Threading
Imports ePay.Logs
Imports System.Web.Script.Serialization
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports PaymentEngine

<ComClass("E6B7FC96-1BC3-44FF-AA97-9EC52DC9F446")>
Public Class ePay

#Region "Properties"
    Private StatusProcess As Thread
    Private IsInit As Boolean
    Public ShowFields As Boolean = True
    Public Shared NeedsParmDonload As Boolean = True
    Public Shared IsDownloadingParm As Boolean = False
    Private tran As TransactionRequest
    Private Result As TransactionResult
    Private client As Middleware
    Private device As Device
    Public Shared request As PaymentRequest = Nothing
    Private Shared locker1 As New Locker()
    Private Results As New Result
    Private ApiKey As System.String
    Private ApiPin As System.String
    Private DeviceKey As System.String
    Private GatewayUrl As System.String
    Private CurrentData As New POSData
    Private IsBusy As Boolean = False
    Private SaveSig As Boolean = False
    Private _CmdResponse As New CmdResponse
    Private _TranResponse As New TranResponse
    Private _Amounts As New Amount
    Private Shared _DeviceStatus As Boolean
    Private types As New TransTypes
    Public Seq As String = "0010010010"
    Public Shared WithEvents Front As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(GetType(FrontFace), New DevExpress.XtraSplashScreen.SplashFormProperties With {.UseFadeOutEffect = False, .UseFadeInEffect = False, .AllowGlowEffect = False})
    Public Property GoHomeMode As Boolean = False


    Public Shared Property DeviceConnected As Boolean
        Get
            Return _DeviceStatus
        End Get
        Set(value As Boolean)
            _DeviceStatus = value
        End Set
    End Property

#End Region

#Region "Public Functions"
    Public Function InitDevice(ByVal ApiKey As System.String, ByVal ApiPin As System.String, ByVal DeviceKey As System.String, ByVal GatewayUrl As System.String) As Boolean
        IsInit = False
        Try
            Me.ApiKey = ApiKey
            Me.ApiPin = ApiPin
            Me.DeviceKey = DeviceKey
            Me.GatewayUrl = GatewayUrl.Replace("https:", "").Replace("/", "").Replace("gate", "")
            Try
                If Equals(Me.ApiKey, Nothing) Then Throw New System.Exception("Api Key not set")
                If Me.ApiKey.Length = 0 Then Throw New System.Exception("Api Key not set")
                If Equals(Me.ApiPin, Nothing) Then Throw New System.Exception("Api Pin not set")
                If Me.ApiPin.Length = 0 Then Throw New System.Exception("Api Pin not set")
                If Equals(Me.GatewayUrl, Nothing) Then Throw New System.Exception("Invalid Gateway URL")
                If Me.GatewayUrl.Length = 0 Then Throw New System.Exception("Invalid Gateway URL")
            Catch ex As Exception
                DeviceConnected = False
                '  SetDescription(ex.Message)
                Return False
            End Try
            Try
                Me.client = New Middleware(Me.ApiKey, Me.ApiPin, Me.GatewayUrl)
            Catch ex As MiddlewareException
                DeviceConnected = False
                '  SetDescription(ex.ToString)
                Return False
            End Try
            ' start pairing process
            If Me.DeviceKey.Trim().Length = 0 Then
                ' SetDescription("Pairing device...")
                startRegistration(Sub(dev)
                                      Me.DeviceKey = dev.DeviceKey
                                      Me.device = dev
                                      Me.OnDeviceRefresh()
                                  End Sub)
                IsDownloadingParm = False
                IsInit = True
                Return True
            End If

            Try
                ' SetCaption(Captions.Init.ToString)
                '  SetDescription("Connecting to device...")
                Me.client.LoadDeviceByKey(Me.DeviceKey, Sub(dev)

                                                            ' store device
                                                            Me.device = dev
                                                            ' update device status ui
                                                            ' SetDescription(String.Format("{0}{1}Serial # {2}", dev.Status, vbNewLine, dev.Details.Serial))
                                                            OnDeviceRefresh(Me.device.Status)

                                                            ' register for future status changes
                                                            Me.device.OnStatusChange(AddressOf OnDeviceRefresh)
                                                        End Sub, Sub(emw)
                                                                     IsInit = False
                                                                     '   SetCaption(Captions.CantConnect.ToString)
                                                                     '  SetDescription("Error loading device: " & emw.Message & " [" + emw.ErrorCode & "]")
                                                                 End Sub)
                IsInit = True
            Catch ex As MiddlewareException
                IsInit = False
                '  SetDescription("Error loading device: " & ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Connecting Terminal")
            IsInit = False
            Return False
        End Try
        Return IsInit
    End Function
    Public Function DoCharge(ByVal Requst As ePayRequest) As ePayResponse
        Dim response As ePayResponse
        Me.Result = Nothing
        Me.Results = Nothing
        Me.tran = Nothing
        Try

            If Me.device Is Nothing OrElse Me.client Is Nothing Then
                Dim MsgStr = "Take device online before starting payment"
                response = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = MsgStr}
                '  HandleMessages("", "", response.ResultCode, response.ResultMessage)
                Return response
                CloseMainScreen(response.ResultCode)
            End If
            If Not IsInit Then
                Dim MsgStr = "Device not initiated, Please make sure terminal is on and connected to the network."
                response = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = MsgStr}
                '  HandleMessages("", "", response.ResultCode, response.ResultMessage)
                Return response
                CloseMainScreen(response.ResultCode)
            End If
            Control.CheckForIllegalCrossThreadCalls = False
            FrontFace.BigScreen = False
            If Not Front.IsSplashFormVisible Then Front.ShowWaitForm()
            Me.tran = New TransactionRequest() With {.Command = Requst.TranCode, .ManualKey = False, .Amount = Requst.Amount, .Invoice = Requst.TranNumber}

            Front.SendCommand(FrontFace.WaitFormCommand.SendObject, locker1)
            Dim entry1 As New ThreadStart(Sub()
                                              response = SetResults(Me.tran)
                                          End Sub)

            Dim process1 As New Thread(entry1)
            process1.IsBackground = True
            process1.Start()

            Dim HasBeenCanceled = False

            While process1.IsAlive
                If locker1.IsCanceled = True Then
                    'Customer canceled transaction 
                    If Not HasBeenCanceled AndAlso Not FrontFace.IsProcessingAlready Then
                        request.CancelTransaction(Sub(x) setStatus("Transaction cancelled"))
                        HasBeenCanceled = True
                        Logger.Verbose("Cancled=True")
                    End If
                End If
                If FrontFace.CantCancel AndAlso Not FrontFace.IsProcessingAlready Then
                    Return New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = "No response"}
                    CloseMainScreen("Error")
                End If
            End While


            If response Is Nothing Then
                response = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = "No response"}
                '     HandleMessages("", "", response.ResultCode, response.ResultMessage)
                CloseMainScreen(response.ResultCode)
                Return response
            End If
            CloseMainScreen(response.ResultCode)
            Return response
        Catch ex As Exception
            response = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = ex.Message}
            '  HandleMessages("", "", response.ResultCode, response.ResultMessage)
            CloseMainScreen(response.ResultCode)
            Return response
        Finally
            If Not SaveSig Then
                '      posl.PaymentRequest = Nothing
                IsBusy = False
            End If
            CloseMainScreen("")
        End Try
    End Function

    Public Shared Function CancelTrans()
        Try
            setStatus("Cancelling transaction...")
            request.CancelTransaction(Sub(x) setStatus("Transaction cancelled"))
        Catch ex As Exception
        Finally
            If Front.IsSplashFormVisible Then Front.CloseWaitForm()
        End Try

        locker1.IsCanceled = True
        Return locker1.IsCanceled
    End Function


#End Region

#Region "Private Functions"

    Friend Sub startRegistration(ByVal deviceRegistered As Action(Of Device))
        Console.WriteLine("startRegistration()")

        Try
            '  SetDescription("Sending pairing request to server")
            client.RegisterDevice("Example", Sub(dev)
                                                 '    SetDescription("Got device key " & dev.DeviceKey)
                                                 device = dev
                                                 '  SetCaption(Captions.WaitingForDeviceCode.ToString)
                                                 '   SetDescription("Enter """ & device.PairingCode & """ on device...")
                                                 device.OnRegistrationComplete(Sub()
                                                                                   '     SetCaption(Captions.connected)
                                                                                   deviceRegistered(device)
                                                                               End Sub)
                                             End Sub, Sub(emw) Console.WriteLine("Error: " & emw.Message))
        Catch ex As MiddlewareException
            '      SetDescription("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub OnDeviceRefresh(Optional ByVal stat As System.String = Nothing)
        Console.WriteLine("OnDeviceRefresh triggered: " & stat)
        If Me.device Is Nothing Then
            ' SetCaption(Captions.CantConnect.ToString)
            Return
        End If
        If device.Status = "connected" Or device.Status = "processing transaction" Then
            DeviceConnected = True
        Else
            DeviceConnected = False
        End If
        ' SetCaption(Me.device.Status)
        '    SetDescription(Me.device.Details.Model & "          " & Me.device.Status)
    End Sub

    Private Shared Sub SetCaption(Value As String)
        If Not Front.IsSplashFormVisible Then Front.ShowWaitForm()
        Front.SetWaitFormCaption(Value)
        Application.DoEvents()
    End Sub

    Private Shared Sub SetDescription(Value As String)
        If Value = "Transaction cancelled" Then Exit Sub
        If Not Front.IsSplashFormVisible Then Front.ShowWaitForm()
        Front.SetWaitFormDescription(Value)
        Application.DoEvents()
    End Sub

    Private Sub CloseMainScreen(ByVal Code As String)
        Try
            Dim a As New Stopwatch
            a.Start()
            While a.Elapsed.TotalSeconds < 2 'wait before close
            End While
            locker1.IsCanceled = False
            locker1.IsF2 = False
            IsBusy = False
            If Code.ToLower <> "error" Then If Front.IsSplashFormVisible Then Front.CloseWaitForm()
        Catch ex As Exception
            'swallow that error.
        End Try
    End Sub

    Private Function startTransaction(ByVal tran As TransactionRequest) As TransactionResult
        request = device.StartTransaction(tran, Sub(status, result)
                                                    Console.WriteLine("Status: " & status)
                                                    If result Is Nothing Then
                                                        setHeading("Transaction Failed")
                                                        setStatus(status)
                                                        Return
                                                    End If

                                                    If result IsNot Nothing Then
                                                        If result.ResultCode.Equals("A") Then
                                                            setHeading(result.Result)
                                                            setStatus("RefNum " & result.RefNum & "  AuthCode: " + result.AuthCode)
                                                        Else
                                                            setHeading(result.Result)
                                                            setStatus(result.Error)
                                                        End If
                                                        Me.Result = result
                                                    End If
                                                End Sub, Sub(status)
                                                             setStatus(status)
                                                             Console.WriteLine("Status: " & status)
                                                         End Sub)

        
    End Function

    'Private Sub HandleMessages(responceOrigion As String, cmdStat As String, code As String, Msg As String)
    '    If Not Front.IsSplashFormVisible OrElse GoHomeMode Then Exit Sub
    '    If code.ToLower.Contains("error") Then
    '        SetCaption(Captions.Declined.ToString)
    '        SetDescription(String.Format("{0} {1} {2} - {3}", responceOrigion, cmdStat, code, Msg))
    '    Else
    '        SetCaption(code)
    '        SetDescription(Msg)
    '    End If
    'End Sub

    Private Function GetDeviceString(DeviceName As String, Processor As String) As String
        Dim res As String
        Try
            res = String.Format("{0}_{1}_{2}", ("EMV"), DeviceName.ToUpper, Processor.Replace(" ", "_").ToUpper)
        Catch ex As Exception
            Return "Wrong"
        End Try
        Return res
    End Function


    Private Function GetCardNumber() As String
        Dim r = CardNumber()
        r.Wait()
        Return r.Result
    End Function

    Private Function CardNumber() As Task(Of String)
        'Return Task.Run(Function()
        '                    Dim Result As ManageResponse = DoManageRequest("INPUTACCOUNT", "1")
        '                    If Result IsNot Nothing Then
        '                        If Result.EntryMode = "0" Then
        '                            Return Result.PAN
        '                        Else
        '                            If Result.Track1Data <> "" Then
        '                                Return Result.Track1Data
        '                            End If
        '                            If Result.Track2Data <> "" Then
        '                                Return Result.Track2Data
        '                            End If

        '                        End If
        '                    End If
        '                    Return ""
        '                End Function)
    End Function

    Private Function ChargeCard(ByVal Request As ePayRequest) As ePayResponse
        Dim res As ePayResponse
        Try
            If Request.TranCode.ToLower = "swipe" Then
                Dim number = GetCardNumber()
                res = New ePayResponse With {.ApprovedAmount = 0,
                                                 .InputMethod = "SWIPE",
                                                 .ResultCode = "OK",
                                                 .ResultMessage = "APPROVED",
                                                 .CardNumber = number
                                                }
                Return res
            Else
                res = CreateRequest(Request)
                Return res
            End If
        Catch ex As Exception
            res = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = ex.Message}
            '     HandleMessages("", "", res.ResultCode, res.ResultMessage)
            Return res
        End Try
        Return res
    End Function

    Private Sub ShowInfoMain(msg As String)
        If Not Front.IsSplashFormVisible Then Exit Sub
        SetDescription(msg)
    End Sub



#End Region

#Region "Create XML for Request"

    

    Private Function CreateRequest(ByVal Req As ePayRequest) As ePayResponse
        'Dim s As ePayResponse
        'tran = New TransactionRequest() With {.Command = Req.TranCode, .Invoice = Req.TranNumber}
        'request = device.StartTransaction(tran, Sub(status, result)
        '                                            Console.WriteLine("Status: " & status)
        '                                            If result Is Nothing Then
        '                                                s = SetResults(Nothing)
        '                                                setStatus(status)
        '                                                Return
        '                                            End If

        '                                            If result IsNot Nothing Then
        '                                                s = SetResults(result)
        '                                                If result.ResultCode.Equals("A") Then
        '                                                    setStatus("RefNum " & result.RefNum & "  AuthCode: " + result.AuthCode)
        '                                                Else
        '                                                    setStatus("Error: " & result.Error)
        '                                                End If
        '                                            End If
        '                                        End Sub, Sub(status)
        '                                                     setStatus(status)
        '                                                     Console.WriteLine("Status: " & status)
        '                                                 End Sub)

        'Return s
    End Function

    Private Function SetResults(ByVal Tran As TransactionRequest) As ePayResponse
        startTransaction(Tran)
        Do While Result Is Nothing

        Loop
        Dim Res = Result
        Dim epayres As ePayResponse
        If Res Is Nothing Then
            epayres = New ePayResponse With {.ResultCode = "Error"}
            Return epayres
        End If
        Dim ccDetail = Res.CreditCard
        epayres = New ePayResponse With {.AuthCode = Res.AuthCode, .ApprovedAmount = Res.AuthAmount, .ResultCode = Res.Result, .ResultMessage = IIf(Res.Error Is Nothing, Res.Result, Res.Error), .IsDuplicate = Res.IsDuplicate, .Err = Res.ErrorCode, .ErrorMessage = Res.Error, .NameOnCard = ccDetail.CardHolder, .CardNumber = ccDetail.Number, .CardType = GetCardType(ccDetail.Type)}
        Return epayres
    End Function

    Private Shared Sub setHeading(ByVal text As String)
        Select Case text
            Case "Approved"
                SetCaption(Captions.Approved.ToString)
            Case "Error"
                SetCaption(Captions.Errr.ToString)
            Case "Declined"
                SetCaption(Captions.Declined.ToString)
            Case Else
                SetCaption(Captions.InputCard.ToString)
        End Select
    End Sub

    Private Shared Sub setStatus(ByVal status As String)
        If status = "sending transaction to terminal" Then
            SetDescription("Waiting For Terminal...")
        ElseIf status = "sent to device" Then
            SetDescription("Waiting For Swipe/Insert On Terminal...")
        ElseIf status = "completing payment" Or status = "processing payment" Then
            SetCaption(Captions.Processing.ToString)
            SetDescription("Processing Payment...")
        Else
            SetDescription(status)
        End If

    End Sub

    Private Function GetCardType(type As String) As String
        Select Case type
            Case Is = "A"
                Return "AMEX"
            Case Is = "M"
                Return "Master"
            Case Is = "V"
                Return "Visa"
            Case Is = "D"
                Return "Discover"
            Case Else
                Return ""
        End Select
    End Function





#End Region
    Public Enum Captions
        Init
        InputCard
        WaitingPin
        WaitingSignutare
        connected
        Succsess
        CantConnect
        Approved
        Processing
        Declined
        WaitingForDeviceCode
        offline
        Errr
    End Enum


End Class

