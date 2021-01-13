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
        Dim SaleType As String = "cc:sale"
        Select Case cmbTranType.Text
            Case "Sale"
                SaleType = "cc:sale"
            Case "Refund"
                SaleType = "cc:credit"
            Case "Adjust"
                SaleType = "cc:refund:adjust"
        End Select

        Dim charge As New ePay.ePayRequest With {.TranCode = SaleType, .Amount = txtAmount.EditValue, .APIKey = txtApikey.EditValue, .ApiPIN = txtPin.EditValue, .GatewayUrl = txtUrl.EditValue, .TranNumber = "01-85695"}
        Dim res = gate.DoCharge(charge)
        Dim reply = res

        If reply Is Nothing Then Return
        lblRes.Text = reply.ResultCode + _
        vbNewLine + reply.ResultMessage + _
        vbNewLine + reply.ApprovedAmount + _
         vbNewLine + reply.AuthCode + _
         vbNewLine + reply.CardNumber + _
        vbNewLine + reply.NameOnCard



        btnProcess.Enabled = True
        btnProcess.Text = "Process"

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class