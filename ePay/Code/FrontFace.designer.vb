<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontFace
    Inherits DevExpress.XtraWaitForm.WaitForm

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
        Me.txCvv2 = New Global.ePay.AddWatermark.CueTextBox()
        Me.TxZip = New Global.ePay.AddWatermark.CueTextBox()
        Me.TxNameOnCard = New Global.ePay.AddWatermark.CueTextBox()
        Me.txExpDate = New Global.ePay.AddWatermark.CueTextBox()
        Me.txCCNo = New Global.ePay.AddWatermark.CueTextBox()
        Me.lbAmount = New System.Windows.Forms.Label()
        Me.lbCardType = New System.Windows.Forms.Label()
        Me.pnlParm = New DevExpress.XtraEditors.PanelControl()
        Me.peStatus = New DevExpress.XtraEditors.PictureEdit()
        Me.lblDeclined = New System.Windows.Forms.Label()
        Me.lblCaptured = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pnlCard = New DevExpress.XtraEditors.PanelControl()
        Me.txStreet = New Global.ePay.AddWatermark.CueTextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.pnlResult = New DevExpress.XtraEditors.PanelControl()
        Me.lblResultMsg = New System.Windows.Forms.Label()
        Me.lblDeviceInfo = New System.Windows.Forms.Label()
        Me.lbCardOnFile = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.peDevice = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlBack = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnProcess = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txCvv2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxZip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxNameOnCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txExpDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txCCNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlParm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParm.SuspendLayout()
        CType(Me.peStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCard.SuspendLayout()
        CType(Me.txStreet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResult.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.peDevice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.pnlBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBack.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txCvv2
        '
        Me.txCvv2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txCvv2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txCvv2.EditValue = ""
        Me.txCvv2.Location = New System.Drawing.Point(367, 45)
        Me.txCvv2.Name = "txCvv2"
        Me.txCvv2.Properties.AllowMouseWheel = False
        Me.txCvv2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txCvv2.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txCvv2.Properties.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txCvv2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txCvv2.Properties.Appearance.Options.UseBackColor = True
        Me.txCvv2.Properties.Appearance.Options.UseBorderColor = True
        Me.txCvv2.Properties.Appearance.Options.UseFont = True
        Me.txCvv2.Properties.Appearance.Options.UseForeColor = True
        Me.txCvv2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txCvv2.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightGray
        Me.txCvv2.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txCvv2.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txCvv2.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txCvv2.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txCvv2.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txCvv2.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txCvv2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent
        Me.txCvv2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.LightGray
        Me.txCvv2.Properties.AppearanceFocused.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txCvv2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txCvv2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txCvv2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txCvv2.Properties.AppearanceFocused.Options.UseFont = True
        Me.txCvv2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txCvv2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txCvv2.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.LightGray
        Me.txCvv2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txCvv2.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txCvv2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txCvv2.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txCvv2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txCvv2.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txCvv2.Properties.AutoHeight = False
        Me.txCvv2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txCvv2.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.txCvv2.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txCvv2.Properties.Mask.EditMask = "\d?\d?\d?\d?\d?"
        Me.txCvv2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.txCvv2.Properties.MaxLength = 4
        Me.txCvv2.Size = New System.Drawing.Size(62, 48)
        Me.txCvv2.TabIndex = 12
        Me.txCvv2.Watermark = "  CVC"
        '
        'TxZip
        '
        Me.TxZip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxZip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxZip.EditValue = ""
        Me.TxZip.Location = New System.Drawing.Point(319, 173)
        Me.TxZip.Name = "TxZip"
        Me.TxZip.Properties.AllowMouseWheel = False
        Me.TxZip.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxZip.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxZip.Properties.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.TxZip.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxZip.Properties.Appearance.Options.UseBackColor = True
        Me.TxZip.Properties.Appearance.Options.UseBorderColor = True
        Me.TxZip.Properties.Appearance.Options.UseFont = True
        Me.TxZip.Properties.Appearance.Options.UseForeColor = True
        Me.TxZip.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.TxZip.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightGray
        Me.TxZip.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.TxZip.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxZip.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.TxZip.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.TxZip.Properties.AppearanceDisabled.Options.UseFont = True
        Me.TxZip.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TxZip.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent
        Me.TxZip.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.LightGray
        Me.TxZip.Properties.AppearanceFocused.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.TxZip.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxZip.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TxZip.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TxZip.Properties.AppearanceFocused.Options.UseFont = True
        Me.TxZip.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TxZip.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxZip.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.LightGray
        Me.TxZip.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.TxZip.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxZip.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxZip.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.TxZip.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.TxZip.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.TxZip.Properties.AutoHeight = False
        Me.TxZip.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxZip.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.TxZip.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TxZip.Properties.Mask.EditMask = "\d\d\d\d\d"
        Me.TxZip.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.TxZip.Properties.MaxLength = 5
        Me.TxZip.Size = New System.Drawing.Size(110, 48)
        Me.TxZip.TabIndex = 13
        Me.TxZip.Watermark = "  Zip Code"
        '
        'TxNameOnCard
        '
        Me.TxNameOnCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxNameOnCard.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxNameOnCard.EditValue = ""
        Me.TxNameOnCard.Location = New System.Drawing.Point(22, 109)
        Me.TxNameOnCard.Name = "TxNameOnCard"
        Me.TxNameOnCard.Properties.AllowMouseWheel = False
        Me.TxNameOnCard.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxNameOnCard.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxNameOnCard.Properties.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.TxNameOnCard.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxNameOnCard.Properties.Appearance.Options.UseBackColor = True
        Me.TxNameOnCard.Properties.Appearance.Options.UseBorderColor = True
        Me.TxNameOnCard.Properties.Appearance.Options.UseFont = True
        Me.TxNameOnCard.Properties.Appearance.Options.UseForeColor = True
        Me.TxNameOnCard.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.TxNameOnCard.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightGray
        Me.TxNameOnCard.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.TxNameOnCard.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxNameOnCard.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.TxNameOnCard.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.TxNameOnCard.Properties.AppearanceDisabled.Options.UseFont = True
        Me.TxNameOnCard.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.TxNameOnCard.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent
        Me.TxNameOnCard.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.LightGray
        Me.TxNameOnCard.Properties.AppearanceFocused.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.TxNameOnCard.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxNameOnCard.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TxNameOnCard.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TxNameOnCard.Properties.AppearanceFocused.Options.UseFont = True
        Me.TxNameOnCard.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TxNameOnCard.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxNameOnCard.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.LightGray
        Me.TxNameOnCard.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.TxNameOnCard.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxNameOnCard.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxNameOnCard.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.TxNameOnCard.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.TxNameOnCard.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.TxNameOnCard.Properties.AutoHeight = False
        Me.TxNameOnCard.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxNameOnCard.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.TxNameOnCard.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TxNameOnCard.Properties.MaxLength = 50
        Me.TxNameOnCard.Size = New System.Drawing.Size(407, 48)
        Me.TxNameOnCard.TabIndex = 14
        Me.TxNameOnCard.Watermark = "  Full Name"
        '
        'txExpDate
        '
        Me.txExpDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txExpDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txExpDate.EditValue = ""
        Me.txExpDate.Location = New System.Drawing.Point(274, 45)
        Me.txExpDate.Name = "txExpDate"
        Me.txExpDate.Properties.AllowMouseWheel = False
        Me.txExpDate.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txExpDate.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txExpDate.Properties.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txExpDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txExpDate.Properties.Appearance.Options.UseBackColor = True
        Me.txExpDate.Properties.Appearance.Options.UseBorderColor = True
        Me.txExpDate.Properties.Appearance.Options.UseFont = True
        Me.txExpDate.Properties.Appearance.Options.UseForeColor = True
        Me.txExpDate.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txExpDate.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightGray
        Me.txExpDate.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txExpDate.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txExpDate.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txExpDate.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txExpDate.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txExpDate.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txExpDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent
        Me.txExpDate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.LightGray
        Me.txExpDate.Properties.AppearanceFocused.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txExpDate.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txExpDate.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txExpDate.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txExpDate.Properties.AppearanceFocused.Options.UseFont = True
        Me.txExpDate.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txExpDate.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txExpDate.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.LightGray
        Me.txExpDate.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txExpDate.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txExpDate.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txExpDate.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txExpDate.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txExpDate.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txExpDate.Properties.AutoHeight = False
        Me.txExpDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txExpDate.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.txExpDate.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txExpDate.Properties.Mask.EditMask = "\d?\d?/\d\d"
        Me.txExpDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.txExpDate.Properties.MaxLength = 16
        Me.txExpDate.Size = New System.Drawing.Size(62, 48)
        Me.txExpDate.TabIndex = 16
        Me.txExpDate.Watermark = "  Exp"
        '
        'txCCNo
        '
        Me.txCCNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txCCNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txCCNo.EditValue = "Card number"
        Me.txCCNo.Location = New System.Drawing.Point(22, 45)
        Me.txCCNo.Name = "txCCNo"
        Me.txCCNo.Properties.AllowMouseWheel = False
        Me.txCCNo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txCCNo.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txCCNo.Properties.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txCCNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txCCNo.Properties.Appearance.Options.UseBackColor = True
        Me.txCCNo.Properties.Appearance.Options.UseBorderColor = True
        Me.txCCNo.Properties.Appearance.Options.UseFont = True
        Me.txCCNo.Properties.Appearance.Options.UseForeColor = True
        Me.txCCNo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txCCNo.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightGray
        Me.txCCNo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txCCNo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txCCNo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txCCNo.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txCCNo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txCCNo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txCCNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent
        Me.txCCNo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.LightGray
        Me.txCCNo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txCCNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txCCNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txCCNo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txCCNo.Properties.AppearanceFocused.Options.UseFont = True
        Me.txCCNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txCCNo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txCCNo.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.LightGray
        Me.txCCNo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txCCNo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txCCNo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txCCNo.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txCCNo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txCCNo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txCCNo.Properties.AutoHeight = False
        Me.txCCNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txCCNo.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.txCCNo.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txCCNo.Properties.Mask.EditMask = "\d\d\d\d-\d\d\d\d-\d\d\d\d-\d\d\d\d"
        Me.txCCNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txCCNo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txCCNo.Properties.MaxLength = 16
        Me.txCCNo.Size = New System.Drawing.Size(221, 48)
        Me.txCCNo.TabIndex = 17
        Me.txCCNo.Watermark = "  Card Number"
        '
        'lbAmount
        '
        Me.lbAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbAmount.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbAmount.Location = New System.Drawing.Point(259, 9)
        Me.lbAmount.Name = "lbAmount"
        Me.lbAmount.Size = New System.Drawing.Size(170, 31)
        Me.lbAmount.TabIndex = 10
        Me.lbAmount.Text = "$1.00"
        Me.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCardType
        '
        Me.lbCardType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbCardType.BackColor = System.Drawing.Color.Transparent
        Me.lbCardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbCardType.Font = New System.Drawing.Font("Open Sans", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lbCardType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbCardType.Location = New System.Drawing.Point(22, 9)
        Me.lbCardType.Name = "lbCardType"
        Me.lbCardType.Size = New System.Drawing.Size(221, 31)
        Me.lbCardType.TabIndex = 11
        Me.lbCardType.Text = "Credit Card"
        Me.lbCardType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlParm
        '
        Me.pnlParm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlParm.Appearance.BackColor = System.Drawing.Color.White
        Me.pnlParm.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnlParm.Appearance.Options.UseBackColor = True
        Me.pnlParm.Appearance.Options.UseBorderColor = True
        Me.pnlParm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnlParm.Controls.Add(Me.peStatus)
        Me.pnlParm.Controls.Add(Me.lblDeclined)
        Me.pnlParm.Controls.Add(Me.lblCaptured)
        Me.pnlParm.Controls.Add(Me.lblStatus)
        Me.pnlParm.Location = New System.Drawing.Point(81, 0)
        Me.pnlParm.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlParm.LookAndFeel.UseWindowsXPTheme = True
        Me.pnlParm.Name = "pnlParm"
        Me.pnlParm.Size = New System.Drawing.Size(446, 236)
        Me.pnlParm.TabIndex = 18
        Me.pnlParm.Visible = False
        '
        'peStatus
        '
        Me.peStatus.EditValue = Global.ePay.My.Resources.Resources.Ellips
        Me.peStatus.Location = New System.Drawing.Point(165, 75)
        Me.peStatus.Name = "peStatus"
        Me.peStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peStatus.Size = New System.Drawing.Size(118, 123)
        Me.peStatus.TabIndex = 0
        '
        'lblDeclined
        '
        Me.lblDeclined.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDeclined.BackColor = System.Drawing.Color.Transparent
        Me.lblDeclined.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDeclined.Font = New System.Drawing.Font("Open Sans Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblDeclined.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lblDeclined.Location = New System.Drawing.Point(12, 3)
        Me.lblDeclined.Name = "lblDeclined"
        Me.lblDeclined.Size = New System.Drawing.Size(434, 32)
        Me.lblDeclined.TabIndex = 11
        Me.lblDeclined.Text = "Insert or swipe credit card"
        Me.lblDeclined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaptured
        '
        Me.lblCaptured.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCaptured.BackColor = System.Drawing.Color.Transparent
        Me.lblCaptured.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCaptured.Font = New System.Drawing.Font("Open Sans Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblCaptured.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblCaptured.Location = New System.Drawing.Point(12, 3)
        Me.lblCaptured.Name = "lblCaptured"
        Me.lblCaptured.Size = New System.Drawing.Size(434, 32)
        Me.lblCaptured.TabIndex = 11
        Me.lblCaptured.Text = "Insert or swipe credit card"
        Me.lblCaptured.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus.Font = New System.Drawing.Font("Open Sans Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(6, 3)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(434, 32)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Insert or swipe credit card"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCard
        '
        Me.pnlCard.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlCard.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnlCard.Appearance.Options.UseBackColor = True
        Me.pnlCard.Appearance.Options.UseBorderColor = True
        Me.pnlCard.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnlCard.Controls.Add(Me.lbAmount)
        Me.pnlCard.Controls.Add(Me.lbCardType)
        Me.pnlCard.Controls.Add(Me.TxZip)
        Me.pnlCard.Controls.Add(Me.txCvv2)
        Me.pnlCard.Controls.Add(Me.txStreet)
        Me.pnlCard.Controls.Add(Me.TxNameOnCard)
        Me.pnlCard.Controls.Add(Me.txExpDate)
        Me.pnlCard.Controls.Add(Me.txCCNo)
        Me.pnlCard.Location = New System.Drawing.Point(15, 35)
        Me.pnlCard.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pnlCard.LookAndFeel.UseWindowsXPTheme = True
        Me.pnlCard.Margin = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(446, 236)
        Me.pnlCard.TabIndex = 18
        Me.pnlCard.Visible = False
        '
        'txStreet
        '
        Me.txStreet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txStreet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txStreet.EditValue = ""
        Me.txStreet.Location = New System.Drawing.Point(22, 173)
        Me.txStreet.Name = "txStreet"
        Me.txStreet.Properties.AllowMouseWheel = False
        Me.txStreet.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txStreet.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txStreet.Properties.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.txStreet.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txStreet.Properties.Appearance.Options.UseBackColor = True
        Me.txStreet.Properties.Appearance.Options.UseBorderColor = True
        Me.txStreet.Properties.Appearance.Options.UseFont = True
        Me.txStreet.Properties.Appearance.Options.UseForeColor = True
        Me.txStreet.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txStreet.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.LightGray
        Me.txStreet.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txStreet.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txStreet.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txStreet.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txStreet.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txStreet.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txStreet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent
        Me.txStreet.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.LightGray
        Me.txStreet.Properties.AppearanceFocused.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txStreet.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txStreet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txStreet.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txStreet.Properties.AppearanceFocused.Options.UseFont = True
        Me.txStreet.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txStreet.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txStreet.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.LightGray
        Me.txStreet.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Myanmar Text", 13.0!)
        Me.txStreet.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txStreet.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txStreet.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txStreet.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txStreet.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txStreet.Properties.AutoHeight = False
        Me.txStreet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txStreet.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.txStreet.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txStreet.Properties.MaxLength = 50
        Me.txStreet.Size = New System.Drawing.Size(273, 48)
        Me.txStreet.TabIndex = 14
        Me.txStreet.Watermark = "  Address"
        '
        'lblInput
        '
        Me.lblInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInput.BackColor = System.Drawing.Color.Transparent
        Me.lblInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInput.Font = New System.Drawing.Font("Open Sans Light", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblInput.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblInput.Location = New System.Drawing.Point(25, 26)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(314, 32)
        Me.lblInput.TabIndex = 11
        Me.lblInput.Text = "Insert or swipe credit card"
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlResult
        '
        Me.pnlResult.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlResult.Appearance.Options.UseBackColor = True
        Me.pnlResult.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlResult.Controls.Add(Me.lblResultMsg)
        Me.pnlResult.Controls.Add(Me.lblDeviceInfo)
        Me.pnlResult.Controls.Add(Me.lbCardOnFile)
        Me.pnlResult.Controls.Add(Me.Panel1)
        Me.pnlResult.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlResult.Location = New System.Drawing.Point(0, 397)
        Me.pnlResult.Name = "pnlResult"
        Me.pnlResult.Size = New System.Drawing.Size(506, 83)
        Me.pnlResult.TabIndex = 19
        '
        'lblResultMsg
        '
        Me.lblResultMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResultMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResultMsg.Font = New System.Drawing.Font("Open Sans", 8.0!)
        Me.lblResultMsg.ForeColor = System.Drawing.Color.Red
        Me.lblResultMsg.Location = New System.Drawing.Point(77, 23)
        Me.lblResultMsg.Name = "lblResultMsg"
        Me.lblResultMsg.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lblResultMsg.Size = New System.Drawing.Size(429, 39)
        Me.lblResultMsg.TabIndex = 2
        Me.lblResultMsg.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblDeviceInfo
        '
        Me.lblDeviceInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDeviceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDeviceInfo.Font = New System.Drawing.Font("Open Sans", 8.0!)
        Me.lblDeviceInfo.ForeColor = System.Drawing.Color.Red
        Me.lblDeviceInfo.Location = New System.Drawing.Point(77, 62)
        Me.lblDeviceInfo.Name = "lblDeviceInfo"
        Me.lblDeviceInfo.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.lblDeviceInfo.Size = New System.Drawing.Size(429, 21)
        Me.lblDeviceInfo.TabIndex = 2
        Me.lblDeviceInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbCardOnFile
        '
        Me.lbCardOnFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbCardOnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbCardOnFile.Font = New System.Drawing.Font("Open Sans", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCardOnFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lbCardOnFile.Location = New System.Drawing.Point(77, 0)
        Me.lbCardOnFile.Name = "lbCardOnFile"
        Me.lbCardOnFile.Size = New System.Drawing.Size(429, 23)
        Me.lbCardOnFile.TabIndex = 1
        Me.lbCardOnFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.peDevice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(77, 83)
        Me.Panel1.TabIndex = 8
        '
        'peDevice
        '
        Me.peDevice.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.peDevice.EditValue = Global.ePay.My.Resources.Resources.PinPadConnected
        Me.peDevice.Location = New System.Drawing.Point(0, 34)
        Me.peDevice.Name = "peDevice"
        Me.peDevice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.peDevice.Properties.Appearance.Options.UseBackColor = True
        Me.peDevice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peDevice.Properties.ErrorImage = Nothing
        Me.peDevice.Properties.InitialImage = Nothing
        Me.peDevice.Properties.ShowMenu = False
        Me.peDevice.Size = New System.Drawing.Size(77, 49)
        Me.peDevice.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.lblInput)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(506, 75)
        Me.PanelControl1.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.btnCancel.Appearance.Options.UseBackColor = True
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Appearance.Options.UseForeColor = True
        Me.btnCancel.Appearance.Options.UseTextOptions = True
        Me.btnCancel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.ePay.My.Resources.Resources.Close
        Me.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(449, 27)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(27, 32)
        Me.btnCancel.TabIndex = 3
        '
        'pnlBack
        '
        Me.pnlBack.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlBack.Appearance.Options.UseBackColor = True
        Me.pnlBack.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlBack.Controls.Add(Me.pnlCard)
        Me.pnlBack.Controls.Add(Me.PanelControl2)
        Me.pnlBack.Controls.Add(Me.pnlParm)
        Me.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBack.Location = New System.Drawing.Point(0, 75)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.pnlBack.Size = New System.Drawing.Size(506, 322)
        Me.pnlBack.TabIndex = 18
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.PanelControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseBorderColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btnProcess)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(30, 246)
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.LookAndFeel.UseWindowsXPTheme = True
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(15, 12, 15, 12)
        Me.PanelControl2.Size = New System.Drawing.Size(446, 66)
        Me.PanelControl2.TabIndex = 18
        '
        'btnProcess
        '
        Me.btnProcess.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnProcess.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnProcess.Appearance.Font = New System.Drawing.Font("Open Sans Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnProcess.Appearance.Options.UseBackColor = True
        Me.btnProcess.Appearance.Options.UseBorderColor = True
        Me.btnProcess.Appearance.Options.UseFont = True
        Me.btnProcess.Appearance.Options.UseForeColor = True
        Me.btnProcess.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProcess.Enabled = False
        Me.btnProcess.Location = New System.Drawing.Point(15, 12)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(416, 42)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Process Payment"
        '
        'FrontFace
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(506, 480)
        Me.Controls.Add(Me.pnlBack)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.pnlResult)
        Me.DoubleBuffered = true
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51,Byte),Integer), CType(CType(51,Byte),Integer), CType(CType(51,Byte),Integer))
        Me.InactiveGlowColor = System.Drawing.Color.FromArgb(CType(CType(247,Byte),Integer), CType(CType(249,Byte),Integer), CType(CType(252,Byte),Integer))
        Me.Name = "FrontFace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.txCvv2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxZip.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxNameOnCard.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txExpDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txCCNo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pnlParm,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlParm.ResumeLayout(false)
        CType(Me.peStatus.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pnlCard,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlCard.ResumeLayout(false)
        CType(Me.txStreet.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pnlResult,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlResult.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        CType(Me.peDevice.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        CType(Me.pnlBack,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlBack.ResumeLayout(false)
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txCvv2 As Global.ePay.AddWatermark.CueTextBox
    Friend WithEvents TxZip As Global.ePay.AddWatermark.CueTextBox
    Friend WithEvents TxNameOnCard As Global.ePay.AddWatermark.CueTextBox
    Friend WithEvents txExpDate As Global.ePay.AddWatermark.CueTextBox
    Friend WithEvents txCCNo As Global.ePay.AddWatermark.CueTextBox
    Public WithEvents lbAmount As System.Windows.Forms.Label
    Public WithEvents lbCardType As System.Windows.Forms.Label
    Public WithEvents pnlParm As DevExpress.XtraEditors.PanelControl
    Public WithEvents pnlCard As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlResult As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents lbCardOnFile As System.Windows.Forms.Label
    Public WithEvents lblResultMsg As System.Windows.Forms.Label
    Friend WithEvents txStreet As Global.ePay.AddWatermark.CueTextBox
    Public WithEvents lblInput As System.Windows.Forms.Label
    Public WithEvents pnlBack As DevExpress.XtraEditors.PanelControl
    Public WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents peDevice As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnProcess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents peStatus As DevExpress.XtraEditors.PictureEdit
    Public WithEvents lblStatus As System.Windows.Forms.Label
    Public WithEvents lblDeclined As System.Windows.Forms.Label
    Public WithEvents lblCaptured As System.Windows.Forms.Label
    Public WithEvents lblDeviceInfo As System.Windows.Forms.Label
End Class
