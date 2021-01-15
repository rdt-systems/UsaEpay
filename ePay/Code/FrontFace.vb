Imports System.Windows.Forms
Imports System.Drawing

Friend Class FrontFace
    Private locker As Object
    Public Shared CantCancel As Boolean = False
    Public Shared IsProcessingAlready As Boolean = False
    Private WithEvents sw As Stopwatch
    Dim tspn As New TimeSpan()

    Private ShowingResult As Boolean = False
    Public Shared WithEvents ParmWtach As Stopwatch
    Public Shared WithEvents ParmTimer As New Timer With {.Interval = 1000}
    Private sm As ePay
    Public Shared BigScreen As Boolean = False


    Public Sub New()
        InitializeComponent()
        sw = New Stopwatch
    End Sub


#Region "Overrides"


    Public Overrides Sub SetCaption(ByVal caption As String)
        MyBase.SetCaption(caption)
        SettingCaption(caption)
    End Sub
    Public Overrides Sub SetDescription(ByVal description As String)
        MyBase.SetDescription(description)
        SettingDescription(description)
    End Sub
    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
        Dim command As WaitFormCommand = CType(cmd, WaitFormCommand)
        If command = WaitFormCommand.SendObject Then
            locker = arg
        End If
    End Sub

    Private Sub ParmTimer_Tick(sender As Object, e As EventArgs)
        tspn = tspn.Subtract(New TimeSpan(0, 0, 1))
        lblStatus.Text = String.Format("Acquiring Parameters...{0}{0}Rebooting Terminal...  {1}", vbNewLine, String.Format("{0}:{1}", tspn.Minutes, tspn.Seconds.ToString))
        If tspn.Minutes = 0 AndAlso tspn.Seconds = 0 Then ParmTimer.Stop()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            If btnCancel.Enabled Then btnCancel.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

#End Region
    Public Enum WaitFormCommand
        SendObject
    End Enum
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If locker IsNot Nothing Then
            EscapePressed()
            While (sw.Elapsed.TotalSeconds < 2) 'make sure the program was running for 4 sec before trying to cancel.
            End While
            sw.Stop()
            CType(locker, ILocker).IsCanceled = True
            sw.Restart()
            While (sw.Elapsed.TotalSeconds < 2) 'Give  chance fr Program to cancel.
            End While
            EscapePressed()
            CType(locker, ILocker).IsCanceled = True
            CantCancel = True
        End If
    End Sub

    Protected Sub ReallyCenterToScreen()
        Dim screen__1 As Screen = Screen.FromControl(Me)
        Dim workingArea As Rectangle = screen__1.WorkingArea
        Me.Location = New Point() With {.X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - Me.Width) / 2), .Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - Me.Height) / 2)}
    End Sub


    Private Sub txCCNo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxZip.KeyDown, TxNameOnCard.KeyDown, txExpDate.KeyDown, txCvv2.KeyDown, txCCNo.KeyDown, txStreet.KeyDown
        If e.KeyCode = Keys.F2 Then
            If locker IsNot Nothing Then
                If CType(locker, ILocker).HasCardOnFile Then CType(locker, ILocker).IsF2 = True
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            btnCancel.PerformClick()
        ElseIf e.KeyCode = Keys.Enter Then
            If btnProcess.Enabled Then btnProcess.PerformClick()
        End If
    End Sub
    Private Sub EscapePressed()
        'SetDescription("Please press the red cancel button on the terminal")
        btnCancel.Enabled = False
        Try
            ePay.CancelTrans()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ShowMessagePanel(Caption As String, lblCaptr As Boolean, lblstat As Boolean, lbldeclin As Boolean)
        pnlCard.Dock = DockStyle.None
        pnlCard.Visible = False
        pnlParm.Visible = True
        pnlParm.BringToFront()
        pnlParm.Dock = DockStyle.Fill
        lblDeclined.Visible = lbldeclin
        lblCaptured.Visible = lblCaptr
        lblStatus.Visible = lblstat
        peStatus.Visible = True
        If lbldeclin Then
            lblDeclined.Text = Caption
            peStatus.Image = Global.ePay.My.Resources.Resources.Declined
            lblResultMsg.ForeColor = lblDeclined.ForeColor
        End If
        If lblCaptr Then
            lblCaptured.Text = Caption
            peStatus.Image = Global.ePay.My.Resources.Resources.Approved
            lblResultMsg.ForeColor = lblCaptured.ForeColor
        End If
        If lblstat Then
            lblStatus.Text = Caption
            lblResultMsg.ForeColor = lblStatus.ForeColor
        End If
        MyBase.Refresh()
        Application.DoEvents()
    End Sub
    Private Sub ShowCardpnl(Caption As String)
        pnlParm.Dock = DockStyle.None
        pnlParm.Visible = False
        pnlCard.Visible = True
        pnlCard.BringToFront()
        pnlCard.Dock = DockStyle.Fill
        lblResultMsg.ForeColor = lblStatus.ForeColor
        If locker IsNot Nothing Then
            If CType(locker, ILocker).HasCardOnFile Then Me.lbCardOnFile.Text = "Press F2 to Process Card on File" Else Me.lbCardOnFile.Text = ""
        Else
            Me.lbCardOnFile.Text = ""
        End If
        txCCNo.Focus()
        MyBase.Refresh()
        Application.DoEvents()
    End Sub

    Private Function ConvertTimer(Timer As Integer) As String
        Dim Min, Sec As Integer
        Min = CInt(Math.Floor(Timer / 60))
        Sec = Timer Mod 60
        Return String.Format("{0}:{1}", Min, Sec)
    End Function

    Private Sub SettingCaption(Value As String)
        Select Case Value
            Case ePay.Captions.Init.ToString
                ShowMessagePanel("Initilizing Device...", False, True, False)
                peStatus.Image = Global.ePay.My.Resources.Resources.Ellips
            Case ePay.Captions.Connected.ToString
                ' SetDeviceStatus()
                ShowCardpnl("")
            Case ePay.Captions.CantConnect.ToString
                ' SetDeviceStatus()
                ShowCardpnl("")
            Case ePay.Captions.offline.ToString
                ' SetDeviceStatus()
                ShowCardpnl("")
            Case ePay.Captions.Succsess.ToString
                'SetDeviceStatus()
                ShowCardpnl("")
            Case ePay.Captions.InputCard.ToString
                ShowCardpnl("")
            Case ePay.Captions.WaitingPin.ToString
                ShowMessagePanel("Waiting For Pin", False, True, False)
                peStatus.Image = Global.ePay.My.Resources.Resources.calculator
            Case ePay.Captions.WaitingSignutare.ToString
                ShowMessagePanel("Waiting For Signutare", False, True, False)
                peStatus.Image = Global.ePay.My.Resources.Resources.Signutare
            Case ePay.Captions.Approved.ToString
                ShowMessagePanel("Approved!", True, False, False)
            Case ePay.Captions.Processing.ToString
                ShowMessagePanel("Processing...", False, True, False)
                peStatus.Image = Global.ePay.My.Resources.Resources.Ellips
            Case ePay.Captions.Declined.ToString
                ShowMessagePanel("Payment Declined", False, False, True)
            Case ePay.Captions.Errr.ToString
                ShowMessagePanel("Payment Error", False, False, True)
            Case ePay.Captions.WaitingForDeviceCode.ToString
                ShowMessagePanel("Waiting For Code Entry on Terminal", False, True, False)
                peStatus.Image = Global.ePay.My.Resources.Resources.calculator
        End Select
        MyBase.Refresh()
        Application.DoEvents()
    End Sub

    Private Sub SetDeviceStatus()
        If ePay.DeviceConnected Then
            peDevice.Image = Global.ePay.My.Resources.PinPadConnected
            lblDeviceInfo.ForeColor = lblCaptured.ForeColor
            lblDeviceInfo.Text = "Connected! ~" & ePay.DeviceInfo
        Else
            peDevice.Image = Global.ePay.My.Resources.PinPadDisconnected
            lblDeviceInfo.ForeColor = lblDeclined.ForeColor
            lblDeviceInfo.Text = "Disconnected"
        End If
    End Sub

    Private Sub SettingDescription(Value As String)
        SetDeviceStatus()
        lblResultMsg.Text = Value
        MyBase.Refresh()
        Application.DoEvents()
    End Sub
    Public Enum Captions
        Init
        InputCard
        WaitingPin
        WaitingSignutare
        Connected
        Succsess
        CantConnect
        Approved
        Processing
        Declined
        WaitingForDeviceCode
        offline
    End Enum

    Private Sub FrontFace_Load(sender As Object, e As EventArgs) Handles Me.Shown
        sw.Start()
        CantCancel = False
        ReallyCenterToScreen()
        SetDeviceStatus()
        ShowCardpnl("")
    End Sub

    Private Sub pnlCard_VisibleChanged(sender As Object, e As EventArgs) Handles pnlCard.VisibleChanged
        pnlParm.Visible = (Not pnlCard.Visible)
        If pnlParm.Visible Then
            lblCaptured.Visible = False
            lblDeclined.Visible = False
            lblStatus.Visible = False
            peStatus.Visible = False
        End If
    End Sub

    Private Sub txCCNo_Properties_KeyUp(sender As Object, e As KeyEventArgs) Handles txCCNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SetCaption(ePay.Captions.Processing.ToString)
            CheckCardLenth()
        End If
    End Sub

    Private Sub CheckCardLenth()
        ePay.MagString = txCCNo.Text
        If ePay.MagString.Where(Function(c) c = "?").Count = 2 Then
            ParseCard()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub ParseCard()
        Dim ParsedData = ePay.MagString
        Dim tracks = ParsedData.Split("?")
        Try
            ePay.Req.MagStrip = ParsedData
            ePay.ProcessOnlline = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ePay.Req.CreditCardNo = txCCNo.EditValue
        ePay.Req.ExpDate = txExpDate.EditValue
        ePay.Req.ccv2 = txCvv2.EditValue
        ePay.Req.ZipCode = TxZip.EditValue
        ePay.Req.NameOnCard = TxNameOnCard.EditValue
        SetCaption(ePay.Captions.Processing.ToString)
        ePay.ProcessOnlline = True
    End Sub

    Private Sub txCCNo_EditValueChanged(sender As Object, e As EventArgs) Handles txExpDate.EditValueChanged, txCCNo.EditValueChanged
        btnProcess.Enabled = (txCCNo.Text.ToString.Length >= 15 AndAlso txExpDate.Text.ToString.Length >= 4)
    End Sub
End Class

