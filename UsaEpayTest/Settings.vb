Imports System
Imports System.Windows.Forms


Public Class Settings
    Protected saveCallBack As Action(Of String, String, String)

    Public Sub New(ByVal callback As Action(Of String, String, String))
        InitializeComponent()
        saveCallBack = callback
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        saveCallBack(txtSourceKey.Text, txtPin.Text, txtDeviceKey.Text)
        Me.Close()
    End Sub

End Class