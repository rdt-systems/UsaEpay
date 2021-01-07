Imports System
Imports System.Windows.Forms
Imports PaymentEngine


Public Class PairDevice
    Private client As Middleware
    Private device As Device


    Public Sub New(ByVal mw As Middleware)
        InitializeComponent()
        client = mw
    End Sub

    Friend Sub startRegistration(ByVal deviceRegistered As Action(Of Device))
        Console.WriteLine("startRegistration()")

        Try
            setStatus("Sending pairing request to server")
            client.RegisterDevice("Example", Sub(dev)
                                                 Console.WriteLine("Got device key " & dev.DeviceKey)
                                                 device = dev
                                                 lblMain.Text = "Enter """ & device.PairingCode & """ on device..."
                                                 setStatus("Waiting for pairing code to be entered on device")
                                                 device.OnRegistrationComplete(Sub()
                                                                                   Console.WriteLine("Device registered")
                                                                                   deviceRegistered(device)

                                                                                   If Me.InvokeRequired Then
                                                                                       Me.Invoke(New MethodInvoker(Sub() Me.Close()))
                                                                                   Else
                                                                                       Me.Close()
                                                                                   End If
                                                                               End Sub)
                                             End Sub, Sub(emw) lblStatus.Text = "Error: " & emw.Message)
        Catch ex As MiddlewareException
            lblStatus.Text = "Error: " & ex.Message
        End Try
    End Sub

    Private Sub setStatus(ByVal status As String)
        If lblStatus.InvokeRequired Then
            lblStatus.Invoke(New MethodInvoker(Sub() lblStatus.Text = status))
        Else
            lblStatus.Text = status
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        If device IsNot Nothing Then
            device.OnRegistrationComplete(Nothing)
        End If

        Dim owner As TestForm = CType(owner, TestForm)
        owner.PairingCancled()
        Me.Close()
    End Sub

End Class