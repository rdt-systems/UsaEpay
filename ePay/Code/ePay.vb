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
Imports USAePayAPI.USAePay

<ComClass("E6B7FC96-1BC3-44FF-AA97-9EC52DC9F446")>
Public Class ePay

#Region "Properties"
    Private IsInit As Boolean
    Public ShowFields As Boolean = True
    Public Shared NeedsParmDonload As Boolean = True
    Public Shared IsDownloadingParm As Boolean = False
    Public Shared Req As ePayRequest = Nothing
    Private tran As TransactionRequest
    Private Result As TransactionResult
    Private client As Middleware
    Private device As Device
    Private usapay As USAePayAPI.USAePay = Nothing
    Public Shared request As PaymentRequest = Nothing
    Private Shared locker1 As New Locker()
    Private ApiKey As System.String
    Private ApiPin As System.String
    Private DeviceKey As System.String
    Private GatewayUrl As System.String
    Private IsBusy As Boolean = False
    Private SaveSig As Boolean = False
    Private Shared _DeviceStatus As Boolean
    Public Shared DeviceInfo As System.String = ""
    Public Shared IsSwiped As Boolean = False
    Public Shared MagString As System.String = ""
    Public Shared ProcessOnlline As Boolean = False
    Public Shared WithEvents Front As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(GetType(FrontFace), New DevExpress.XtraSplashScreen.SplashFormProperties With {.UseFadeOutEffect = False, .UseFadeInEffect = False, .AllowGlowEffect = False})

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
                'SetDescription(ex.Message)
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
                                                            dev.Config.EnableContactless = True
                                                            dev.Config.EnableDebitMSR = False
                                                            dev.Config.EnableEMV = True
                                                            dev.Config.TipAdjustAfterAuth = True
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
        Dim response As ePayResponse = Nothing
        Me.Result = Nothing
        Me.tran = Nothing
        ePay.request = Nothing
        ePay.Req = Nothing
        usapay = Nothing

        Try
            ePay.Req = Requst
            If Requst.CreditCardNo IsNot Nothing Then locker1.HasCardOnFile = True


            If Me.device Is Nothing OrElse Me.client Is Nothing Then
                'If Requst.CreditCardNo <> "" Then
                '    response = ChargeCardOnline(Requst)
                'Else
                '    Dim MsgStr = "Take device online before starting payment"
                '    response = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = MsgStr}
                '    ''  HandleMessages("", "", response.ResultCode, response.ResultMessage)
                'End If
                'Return response
                'CloseMainScreen(response.ResultCode)
            End If
            If Not IsInit Then
                'Dim MsgStr = "Device not initiated, Please make sure terminal is on and connected to the network."
                'response = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = MsgStr}
                ''  HandleMessages("", "", response.ResultCode, response.ResultMessage)
                'Return response
                'CloseMainScreen(response.ResultCode)
            End If
            Control.CheckForIllegalCrossThreadCalls = False
            FrontFace.BigScreen = False
            If Not Front.IsSplashFormVisible Then Front.ShowWaitForm()
            Me.tran = New TransactionRequest() With {.Command = Requst.TranCode, .ManualKey = False, .PromptSignature = False, .Amount = Requst.Amount, .Invoice = Requst.TranNumber}

            Front.SendCommand(FrontFace.WaitFormCommand.SendObject, locker1)
            Dim entry1 As New ThreadStart(Sub()
                                              response = SetResults(Me.tran)
                                          End Sub)

            Dim process1 As New Thread(entry1)
            process1.IsBackground = True
            process1.Start()

            Dim HasBeenCanceled = False

            While process1.IsAlive
                If locker1.IsF2 Then
                    setStatus("processing payment")
                    response = ChargeCardOnline(ePay.Req)
                    request.CancelTransaction(Sub(x) CloseMainScreen(""))
                    process1.Abort()
                ElseIf ePay.ProcessOnlline Then
                    setStatus("processing payment")
                    response = ChargeCardOnline(ePay.Req)
                    request.CancelTransaction(Sub(x) CloseMainScreen(""))
                    process1.Abort()
                End If
                If locker1.IsCanceled = True Then
                    'Customer canceled transaction 
                    If Not HasBeenCanceled AndAlso Not FrontFace.IsProcessingAlready Then
                        request.CancelTransaction(Sub(x) setStatus("Transaction cancelled"))
                        HasBeenCanceled = True
                        Logger.Verbose("Cancled=True")
                    End If
                    Return New ePayResponse With {.ResultCode = "Canceled", .ResultMessage = "Transaction Canceled By User"}
                    CloseMainScreen("Canceled")
                End If

                If FrontFace.CantCancel AndAlso Not FrontFace.IsProcessingAlready Then
                    Return New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = "No response"}
                    CloseMainScreen("Error")
                End If
            End While


            If response Is Nothing Then
                response = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = "No response"}
                '     HandleMessages("", "", response.ResultCode, response.ResultMessage)
                Return response
                CloseMainScreen(response.ResultCode)
            End If
            Return response
            CloseMainScreen(response.ResultCode)
        Catch ex As Exception
            response = New ePayResponse With {.ResultCode = "ERROR", .ResultMessage = ex.Message}
            '  HandleMessages("", "", response.ResultCode, response.ResultMessage)
            Return response
            CloseMainScreen(response.ResultCode)
        Finally
            If Not SaveSig Then
                '      posl.PaymentRequest = Nothing
                IsBusy = False
            End If
            ePay.Req = Nothing
            CloseMainScreen("")

        End Try
    End Function

    Public Shared Function CancelTrans()
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
                                                 device.Config.EnableContactless = True
                                                 device.Config.EnableDebitMSR = False
                                                 device.Config.EnableEMV = True
                                                 device.Config.TipAdjustAfterAuth = True
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
        If device.Status = "processing transaction" Then
            ' SetCaption(Captions.Processing.ToString)
        ElseIf device.Status = "connected" Then
            DeviceInfo = String.Format("Model No. {0} ~ Serial:{1}", Me.device.Details.Model, Me.device.Details.Serial)
            DeviceConnected = True
        Else
            DeviceInfo = ""
            DeviceConnected = False
        End If
        ' SetCaption(Me.device.Status)
        '    
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
        If Not Front.IsSplashFormVisible Then Exit Sub
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
        device.Config.EnableContactless = True
        device.Config.EnableDebitMSR = False
        device.Config.EnableEMV = True
        device.Config.TipAdjustAfterAuth = True
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

    Private Function SetResults(ByVal Tran As TransactionRequest) As ePayResponse
        startTransaction(Tran)
        Do While Result Is Nothing
            If Not usapay Is Nothing Then
                Exit Do
                Exit Function
            End If
        Loop
        Dim Res = Result
        Dim epayres As ePayResponse
        If Res Is Nothing Then
            epayres = New ePayResponse With {.ResultCode = "Error"}
            Return epayres
        End If
        Dim ccDetail = Res.CreditCard
        If Res.ErrorCode = "99999" Then
            Return New ePayResponse With {.ResultMessage = Res.Error, .ResultCode = "Canceled By User!"}
        End If
        epayres = New ePayResponse With {.AuthCode = Res.AuthCode,
                                         .RefNum = Res.RefNum,
                                         .ApprovedAmount = Res.AuthAmount,
                                         .ResultCode = Res.Result,
                                         .ResultMessage = IIf(Res.Error Is Nothing, Res.Result, Res.Error),
                                         .IsDuplicate = Res.IsDuplicate,
                                         .Err = IIf(Res.Error Is Nothing, "", Res.Result),
                                         .ErrorMessage = Res.Error,
                                         .NameOnCard = ccDetail.CardHolder,
                                         .CardNumber = ccDetail.Number,
                                         .CardType = GetCardType(IIf(ccDetail.Type Is Nothing, "", ccDetail.Type))}
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
            Case "3"
                Return "AMEX"
            Case "4"
                Return "Visa"
            Case "5"
                Return "Master"
            Case "6"
                Return "Discover"
            Case Else
                Return ""
        End Select
    End Function

#End Region


    Private Function ChargeCardOnline(req As ePayRequest) As ePayResponse
        Dim charg As Boolean = False
        Dim cardType As String = ""
        If Not req.CreditCardNo Is Nothing Then GetCardType(IIf(req.CreditCardNo Is Nothing, "", req.CreditCardNo.Substring(0, 1)))
        usapay = New USAePayAPI.USAePay With {.SourceKey = req.APIKey,
                                                      .Pin = req.ApiPIN,
                                                       .GatewayURL = req.GatewayUrl,
                                                       .Amount = req.Amount,
                                                       .CardNumber = req.CreditCardNo,
                                                       .CardExp = req.ExpDate,
                                                       .RefNum = req.RefNum,
                                                       .Command = req.TranCode,
                                                       .Invoice = req.TranNumber,
                                                       .Cvv2 = req.ccv2,
                                                       .AvsZip = req.ZipCode,
                                                       .CardHolder = req.NameOnCard,
                                                       .MagStripe = req.MagStrip}
        If Not usapay.MagStripe Is Nothing Then usapay.CardPresent = True
        If req.TranCode = "cc:sale" Then
            charg = usapay.Process()
        ElseIf req.TranCode = "cc:credit" Then
            charg = usapay.Credit()
        End If
        Do While charg = False

        Loop
        Dim epayres As ePayResponse
        If usapay.AuthCode Is Nothing Or usapay.AuthCode = "" Then
            SetCaption(Captions.Errr.ToString)
            epayres = New ePayResponse With {.ResultCode = "Error"}
            Return epayres
        End If
        setHeading(usapay.Result)
        setStatus(usapay.Result & " ~ Auth#:" & usapay.AuthCode)
        epayres = New ePayResponse With {.AuthCode = usapay.AuthCode,
                                         .RefNum = usapay.ResultRefNum,
                                         .ApprovedAmount = usapay.AuthAmount,
                                         .ResultCode = usapay.Result,
                                         .ResultMessage = IIf(usapay.ErrorMesg Is Nothing, usapay.Result, usapay.ErrorMesg),
                                         .IsDuplicate = usapay.IsDuplicate,
                                         .Err = IIf(usapay.ErrorMesg Is Nothing, "", usapay.Result),
                                         .ErrorMessage = usapay.ErrorMesg,
                                         .NameOnCard = usapay.BillingLastName,
                                         .InputMethod = "",
                                         .RemainingBalance = usapay.RemainingBalance,
                                         .CardNumber = usapay.MaskedCardNum,
                                         .CardType = cardType}
        Return epayres
        

    End Function

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

