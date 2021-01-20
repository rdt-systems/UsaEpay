Imports System
Imports System.Windows.Forms
Imports PaymentEngine

Public Class Process
    Private Shared statuses As String = ""
    Private Shared headers As String = ""
    Public device As Device
    Public request As PaymentRequest

    Public Sub New(ByVal dev As Device)
        InitializeComponent()
        rtstatus.Text = ""
        btnRetry.Visible = False
        OK_Button.Visible = False
        device = dev
    End Sub

    Public Sub startTransaction(ByVal tran As TransactionRequest)
        request = device.StartTransaction(tran, Sub(status, result)
                                                    Console.WriteLine("Status: " & status)
                                                    setButtonVisible(OK_Button, True)
                                                    setButtonVisible(Cancel_Button, False)
                                                    setStatus(status)
                                                    If result Is Nothing Then
                                                        setHeading("Transaction Failed")
                                                        setStatus(status)
                                                        Return
                                                    End If

                                                    If result IsNot Nothing Then
                                                        setHeading("Transaction " & result.Result)

                                                        If result.ResultCode.Equals("A") Then
                                                            setStatus("RefNum " & result.RefNum & "  AuthCode: " + result.AuthCode)
                                                        Else
                                                            setStatus("Error: " & result.Error)
                                                        End If
                                                    End If
                                                End Sub, Sub(status)
                                                             setStatus(status)
                                                             Console.WriteLine("Status: " & status)
                                                         End Sub)


    End Sub

    Private Sub setHeading(ByVal text As String)
        headers += vbNewLine + text
        If lblHeading.InvokeRequired Then
            lblHeading.Invoke(New MethodInvoker(Sub() lblHeading.Text = text))
        Else
            lblHeading.Text = text
        End If
    End Sub

    Private Sub setStatus(ByVal status As String)
        statuses += vbNewLine + status
        If lblStatus.InvokeRequired Then
            lblStatus.Invoke(New MethodInvoker(Sub() lblStatus.Text = status))
        Else
            lblStatus.Text = status
        End If
    End Sub

    Private Sub setButtonVisible(ByVal btn As Button, ByVal visible As Boolean)
        If btn.InvokeRequired Then
            btn.Invoke(New MethodInvoker(Sub() btn.Visible = visible))
        Else
            btn.Visible = visible
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        ' request not running yet
        If request Is Nothing Then Me.Close()


        ' cancel transaction
        Try
            setStatus("Cancelling transaction...")
            request.CancelTransaction(Sub(x) setStatus("Transaction cancelled"))
        Catch ex As MiddlewareException
            Console.WriteLine("Exception cancelling tran: " & ex.Message)
        Finally
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rtstatus.Text = statuses
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rtHeaders.Text = headers
    End Sub
End Class