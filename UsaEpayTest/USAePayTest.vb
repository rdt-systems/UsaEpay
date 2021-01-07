Imports ePay
Public Class USAePayTest
    Private gate As New ePay.ePay
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        btnProcess.Enabled = gate.InitDevice(txtApikey.EditValue, txtPin.EditValue, txtDevice.EditValue, txtUrl.EditValue)
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        btnProcess.Enabled = False
        btnProcess.Text = "Please Wait..."
        Application.DoEvents()

        Dim charge As New ePay.ePayRequest With {.TranCode = "cc:sale", .Amount = txtAmount.EditValue}
        Dim res = gate.DoCharge(charge)
        Dim reply = res

        If reply Is Nothing Then Return
        lblRes.Text = reply.CaptureStatus + _
        vbNewLine + reply.ApprovedAmount + _
        vbNewLine + reply.ResultCode + _
        vbNewLine + reply.ResultMessage



        btnProcess.Enabled = True
        btnProcess.Text = "Process"

    End Sub
End Class