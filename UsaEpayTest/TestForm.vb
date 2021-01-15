Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports PaymentEngine

Public Class TestForm

    Private total As System.Double
    Private tran As TransactionRequest
    Private client As Middleware
    Private device As Device
    Private ApiKey As String
    Private ApiPin As String
    Private DeviceKey As String


    Public Sub New()
        InitializeComponent()
        Me.total = 0
        Me.tran = New TransactionRequest()
        lblDeviceModel.Text = "No device connected"
        lblDeviceStatus.Text = ""
        btnTakePayment.Enabled = False


        ' read save values from registry.  DONT DO THIS.  
        ' In a production app you should store these values encrypted.
        Dim key As Microsoft.Win32.RegistryKey
        key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PayEngineDemo")

        Try
            Me.ApiKey = CStr(key.GetValue("ApiKey"))
        Catch __unusedException1__ As System.Exception
            Me.ApiKey = ""
        End Try

        Try
            Me.ApiPin = CStr(key.GetValue("ApiPin"))
        Catch __unusedException1__ As System.Exception
            Me.ApiPin = ""
        End Try

        Try
            Me.DeviceKey = CStr(key.GetValue("DeviceKey"))
        Catch __unusedException1__ As System.Exception
            Me.DeviceKey = ""
        End Try

        'ApiKey = "0hxEwTCy4UPSTp7sL5V69fa2Uu5Gzrfu";
        'ApiPin = "1234";
        'DeviceKey = "sa_54kx8PXr0YDdkgFvaftqEveVT3JME";

    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub toolStripStatusLabel2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btnAddItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddItem1.Click
        Me.addItem("Coffee", 1.55)
    End Sub

    Private Sub btnAddItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddItem2.Click
        Me.addItem("Eggs", 2.95)
    End Sub

    Private Sub btnAddItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddItem3.Click
        Me.addItem("Toast", 1.25)
    End Sub

    Private Sub btnAddItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddItem4.Click
        Me.addItem("Oatmeal", 2.25)
    End Sub

    Private Sub addItem(ByVal Name As String, ByVal Amount As System.Double)
        Me.total += Amount
        listItems.Items.Add("$" & Amount & " " & Name)
        lblTotal.Text = "$" & Me.total
        Dim line As LineItem = New LineItem() With {
            .Name = Name,
            .Cost = Amount.ToString(),
            .Quantity = "1",
            .SKU = "99999"
        }




        'this.request.LineItems[] = line;

        If Me.total > 0 Then
            btnTakePayment.Enabled = True
        End If
    End Sub

    Private Sub btnClearOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearOrder.Click
        Me.total = 0
        lblTotal.Text = "$0.00"
        listItems.Items.Clear()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        Dim settings As Settings = New Settings(Sub(key, pin, devicekey)
                                                    Me.ApiKey = key
                                                    Me.ApiPin = pin
                                                    Me.DeviceKey = devicekey
                                                    Console.WriteLine("Saving ApiKey " & Me.ApiKey)

                                                    Using reg As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PayEngineDemo")
                                                        Try
                                                            reg.SetValue("ApiKey", Me.ApiKey)
                                                            reg.SetValue("ApiPin", Me.ApiPin)
                                                            reg.SetValue("DeviceKey", Me.DeviceKey)
                                                        Catch ex As System.Exception
                                                            Console.WriteLine("Failed to save to registry: " & ex.Message)
                                                        End Try
                                                    End Using

                                                End Sub)
        settings.txtSourceKey.Text = Me.ApiKey
        settings.txtPin.Text = Me.ApiPin
        settings.txtDeviceKey.Text = Me.DeviceKey
        settings.ShowDialog()
    End Sub

    Private Sub ToggleConnectButton(ByVal connect As Boolean)
        If connect Then
            Me.setDeviceModel("Device not connected")
            Me.setDeviceStatus("")
            btnConnect.Text = "Connect"
            btnConnect.Enabled = True
        Else
            btnConnect.Text = "Disconnect"
            btnConnect.Enabled = True
        End If
    End Sub

    Private Sub btnConnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If btnConnect.Text.Equals("Disconnect") Then

            If Me.device IsNot Nothing Then
                Me.device.OnStatusChange(Nothing)
                Me.device = Nothing
            End If

            Me.client = Nothing
            lblDeviceModel.Text = "Device not connected"
            lblDeviceStatus.Text = ""
            btnConnect.Text = "Connect"
            btnConnect.Enabled = True
            Return
        End If

        Try
            If Equals(Me.ApiKey, Nothing) Then Throw New System.Exception("Api Key not set")
            If Me.ApiKey.Length = 0 Then Throw New System.Exception("Api Key not set")
            If Equals(Me.ApiPin, Nothing) Then Throw New System.Exception("Api Pin not set")
            If Me.ApiPin.Length = 0 Then Throw New System.Exception("Api Pin not set")
        Catch ex As System.Exception
            lblDeviceStatus.Text = ex.Message
            Return
        End Try

        Try
            Me.client = New Middleware(Me.ApiKey, Me.ApiPin, "secure.usaepay.com")
            btnConnect.Text = "Disconnect"
        Catch ex As MiddlewareException
            lblDeviceStatus.Text = "Unable to connect to gateway"
            Console.WriteLine("Error instantiating middleware: " & ex.ToString())
        End Try


        ' start pairing process
        If Me.DeviceKey.Trim().Length = 0 Then
            lblDeviceStatus.Text = "Pairing device..."
            Dim pair As PairDevice = New PairDevice(Me.client)
            pair.Show(Me)
            Console.WriteLine("showDialog() done")
            pair.startRegistration(Sub(dev)
                                       Me.DeviceKey = dev.DeviceKey
                                       Me.device = dev
                                       Me.OnDeviceRefresh()
                                   End Sub)
            Return
        End If


        ' load existing device key
        Try
            lblDeviceStatus.Text = "Connecting to device..."
            Me.client.LoadDeviceByKey(Me.DeviceKey, Sub(dev)

                                                        ' store device
                                                        Me.device = dev

                                                        ' update device status ui
                                                        statusStrip1.Items(CInt((2))).Text = "Serial # " & dev.Details.Serial
                                                        statusStrip1.Items(CInt((0))).Text = dev.Status
                                                        OnDeviceRefresh(Me.device.Status)

                                                        ' register for future status changes
                                                        Me.device.OnStatusChange(AddressOf OnDeviceRefresh)
                                                    End Sub, Sub(emw)
                                                                 setDeviceStatus(emw.Message)
                                                                 Console.WriteLine("Error loading device: " & emw.Message & " [" + emw.ErrorCode & "]")
                                                             End Sub)
        Catch ex As MiddlewareException
            Console.WriteLine("Error loading device: " & ex.Message)
        End Try
    End Sub

    Public Sub PairingCancled()
        Me.ToggleConnectButton(True)
    End Sub

    Private Sub OnDeviceRefresh(Optional ByVal stat As String = Nothing)
        Console.WriteLine("OnDeviceRefresh triggered: " & stat)

        If Me.device Is Nothing Then
            Me.setDeviceModel("Device not connected")
            Me.setDeviceStatus(stat)
            Return
        End If

        setDeviceModel(Me.device.Details.Model)
        setDeviceStatus(Me.device.Status)
    End Sub

    Private Sub setDeviceStatus(ByVal status As String)
        If lblDeviceStatus.InvokeRequired Then
            lblDeviceStatus.Invoke(New MethodInvoker(Sub() lblDeviceStatus.Text = status))
        Else
            lblDeviceStatus.Text = status
        End If
    End Sub

    Private Sub setDeviceModel(ByVal status As String)
        If lblDeviceModel.InvokeRequired Then
            lblDeviceModel.Invoke(New MethodInvoker(Sub() lblDeviceModel.Text = status))
        Else
            lblDeviceModel.Text = status
        End If
    End Sub

    Private Sub startTransaction(Optional ByVal manualKey As System.Boolean = False, Optional ByVal command As String = "cc:sale")
        If Me.device Is Nothing OrElse Me.client Is Nothing Then
            Me.setDeviceStatus("Take device online before starting payment")
            Return
        End If

        Me.tran.Command = command
        Me.tran.Amount = "0.01"
        Me.tran.Invoice = "10001"
        Me.tran.ManualKey = manualKey
        Dim proc As Process = New Process(Me.device)
        proc.Show()
        Console.WriteLine("proc show() returned")
        proc.startTransaction(Me.tran)
    End Sub



    ' 
    '* Start a payment request.  This will send the transaction data to
    '* the terminal and prompt the customer to swipe/dip/tap their card.
    '* Once the payment is complete,  transaction results will be returned.
    '* See: Process.cs

    Private Sub btnTakePayment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTakePayment.Click
        Me.startTransaction(False)
    End Sub



    ' 
    '* Trigger the payment request with a flag to prompt the customer
    '* to enter their card number instead of swipe/dip

    Private Sub btnManuallyKey_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnManuallyKey.Click
        Me.startTransaction(True)
    End Sub



    ' 
    '* This demonstrates an unconnected refund.  There is no reference to the original sale.
    '* An amount is provided and the customer is prompted to swipe/dip  their card.

    Private Sub btnRefund_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefund.Click
        Me.startTransaction(False, "cc:credit")
    End Sub

    Private Sub btnSigCapture_Click(sender As Object, e As EventArgs) Handles btnSigCapture.Click

    End Sub

    Private Sub btnDisplayMessage_Click(sender As Object, e As EventArgs) Handles btnDisplayMessage.Click

    End Sub

    Private Sub btnClearScreen_Click(sender As Object, e As EventArgs) Handles btnClearScreen.Click

    End Sub
End Class
