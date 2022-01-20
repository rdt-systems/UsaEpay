<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USAePayTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtApikey = New DevExpress.XtraEditors.TextEdit()
        Me.txtPin = New DevExpress.XtraEditors.TextEdit()
        Me.txtUrl = New DevExpress.XtraEditors.TextEdit()
        Me.txtDevice = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.cmbTranType = New System.Windows.Forms.ComboBox()
        Me.btnProcess = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lblRes = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtApikey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtApikey
        '
        Me.txtApikey.EditValue = "D7eXTUv8S9WYuRmm2VR6954nnet1NL7W"
        Me.txtApikey.Location = New System.Drawing.Point(73, 49)
        Me.txtApikey.Name = "txtApikey"
        Me.txtApikey.Size = New System.Drawing.Size(120, 20)
        Me.txtApikey.TabIndex = 0
        '
        'txtPin
        '
        Me.txtPin.EditValue = "rdtPinCode"
        Me.txtPin.Location = New System.Drawing.Point(73, 87)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(120, 20)
        Me.txtPin.TabIndex = 0
        '
        'txtUrl
        '
        Me.txtUrl.EditValue = "https://secure.usaepay.com/gate"
        Me.txtUrl.Location = New System.Drawing.Point(270, 49)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(246, 20)
        Me.txtUrl.TabIndex = 0
        '
        'txtDevice
        '
        Me.txtDevice.EditValue = "sa_HdPcwe0dMAGA05rk7wPNB2b6wRLac"
        Me.txtDevice.Location = New System.Drawing.Point(270, 87)
        Me.txtDevice.Name = "txtDevice"
        Me.txtDevice.Size = New System.Drawing.Size(246, 20)
        Me.txtDevice.TabIndex = 0
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "0.01"
        Me.txtAmount.Location = New System.Drawing.Point(73, 131)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.DisplayFormat.FormatString = "n"
        Me.txtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.EditFormat.FormatString = "n"
        Me.txtAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.ShowPlaceHolders = False
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Size = New System.Drawing.Size(120, 20)
        Me.txtAmount.TabIndex = 0
        '
        'cmbTranType
        '
        Me.cmbTranType.FormattingEnabled = True
        Me.cmbTranType.Items.AddRange(New Object() {"Sale", "Refund", "Adjust"})
        Me.cmbTranType.Location = New System.Drawing.Point(270, 134)
        Me.cmbTranType.Name = "cmbTranType"
        Me.cmbTranType.Size = New System.Drawing.Size(246, 21)
        Me.cmbTranType.TabIndex = 1
        '
        'btnProcess
        '
        Me.btnProcess.Enabled = False
        Me.btnProcess.Location = New System.Drawing.Point(73, 178)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(120, 28)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "Process"
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(265, 178)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(120, 28)
        Me.btnInit.TabIndex = 2
        Me.btnInit.Text = "Initilize"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(432, 178)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 28)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Cancel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(199, 52)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Gateway URL"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(218, 90)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Device ID"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(217, 138)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Sale Type"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(29, 134)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Amount"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(52, 90)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Pin"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 52)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "Source Key"
        '
        'lblRes
        '
        Me.lblRes.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblRes.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.lblRes.Location = New System.Drawing.Point(12, 241)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(208, 97)
        Me.lblRes.TabIndex = 3
        '
        'USAePayTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(585, 370)
        Me.Controls.Add(Me.lblRes)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.cmbTranType)
        Me.Controls.Add(Me.txtDevice)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.txtApikey)
        Me.Name = "USAePayTest"
        Me.Text = "USAePayTest"
        CType(Me.txtApikey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtApikey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDevice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbTranType As System.Windows.Forms.ComboBox
    Friend WithEvents btnProcess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRes As DevExpress.XtraEditors.LabelControl
End Class
