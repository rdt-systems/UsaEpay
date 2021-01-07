<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnSigCapture = New System.Windows.Forms.Button()
        Me.btnDisplayMessage = New System.Windows.Forms.Button()
        Me.btnClearScreen = New System.Windows.Forms.Button()
        Me.lblDeviceStatus = New System.Windows.Forms.Label()
        Me.lblDeviceModel = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefund = New System.Windows.Forms.Button()
        Me.btnManuallyKey = New System.Windows.Forms.Button()
        Me.btnClearOrder = New System.Windows.Forms.Button()
        Me.btnTakePayment = New System.Windows.Forms.Button()
        Me.btnAddItem4 = New System.Windows.Forms.Button()
        Me.btnAddItem3 = New System.Windows.Forms.Button()
        Me.btnAddItem2 = New System.Windows.Forms.Button()
        Me.btnAddItem1 = New System.Windows.Forms.Button()
        Me.listItems = New System.Windows.Forms.ListBox()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.btnSettings)
        Me.GroupBox1.Controls.Add(Me.btnSigCapture)
        Me.GroupBox1.Controls.Add(Me.btnDisplayMessage)
        Me.GroupBox1.Controls.Add(Me.btnClearScreen)
        Me.GroupBox1.Controls.Add(Me.lblDeviceStatus)
        Me.GroupBox1.Controls.Add(Me.lblDeviceModel)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 110)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(528, 16)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(99, 23)
        Me.btnConnect.TabIndex = 13
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(528, 72)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(99, 23)
        Me.btnSettings.TabIndex = 12
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnSigCapture
        '
        Me.btnSigCapture.Location = New System.Drawing.Point(9, 72)
        Me.btnSigCapture.Name = "btnSigCapture"
        Me.btnSigCapture.Size = New System.Drawing.Size(103, 23)
        Me.btnSigCapture.TabIndex = 11
        Me.btnSigCapture.Text = "Capture Signature"
        Me.btnSigCapture.UseVisualStyleBackColor = True
        Me.btnSigCapture.Visible = False
        '
        'btnDisplayMessage
        '
        Me.btnDisplayMessage.Location = New System.Drawing.Point(119, 72)
        Me.btnDisplayMessage.Name = "btnDisplayMessage"
        Me.btnDisplayMessage.Size = New System.Drawing.Size(103, 23)
        Me.btnDisplayMessage.TabIndex = 5
        Me.btnDisplayMessage.Text = "Display Message"
        Me.btnDisplayMessage.UseVisualStyleBackColor = True
        Me.btnDisplayMessage.Visible = False
        '
        'btnClearScreen
        '
        Me.btnClearScreen.Location = New System.Drawing.Point(231, 72)
        Me.btnClearScreen.Name = "btnClearScreen"
        Me.btnClearScreen.Size = New System.Drawing.Size(103, 23)
        Me.btnClearScreen.TabIndex = 4
        Me.btnClearScreen.Text = "Clear Screen"
        Me.btnClearScreen.UseVisualStyleBackColor = True
        Me.btnClearScreen.Visible = False
        '
        'lblDeviceStatus
        '
        Me.lblDeviceStatus.AutoSize = True
        Me.lblDeviceStatus.Location = New System.Drawing.Point(6, 31)
        Me.lblDeviceStatus.Name = "lblDeviceStatus"
        Me.lblDeviceStatus.Size = New System.Drawing.Size(74, 13)
        Me.lblDeviceStatus.TabIndex = 2
        Me.lblDeviceStatus.Text = "Device Status"
        '
        'lblDeviceModel
        '
        Me.lblDeviceModel.AutoSize = True
        Me.lblDeviceModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeviceModel.Location = New System.Drawing.Point(6, 16)
        Me.lblDeviceModel.Name = "lblDeviceModel"
        Me.lblDeviceModel.Size = New System.Drawing.Size(182, 13)
        Me.lblDeviceModel.TabIndex = 1
        Me.lblDeviceModel.Text = "Name and model of the Device"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(279, 628)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(98, 37)
        Me.lblTotal.TabIndex = 38
        Me.lblTotal.Text = "$0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 628)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 37)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "$0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 646)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Tax"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 646)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Total"
        '
        'btnRefund
        '
        Me.btnRefund.Location = New System.Drawing.Point(439, 635)
        Me.btnRefund.Name = "btnRefund"
        Me.btnRefund.Size = New System.Drawing.Size(201, 30)
        Me.btnRefund.TabIndex = 34
        Me.btnRefund.Text = "Refund"
        Me.btnRefund.UseVisualStyleBackColor = True
        '
        'btnManuallyKey
        '
        Me.btnManuallyKey.Location = New System.Drawing.Point(439, 592)
        Me.btnManuallyKey.Name = "btnManuallyKey"
        Me.btnManuallyKey.Size = New System.Drawing.Size(201, 30)
        Me.btnManuallyKey.TabIndex = 33
        Me.btnManuallyKey.Text = "Manually Key Card"
        Me.btnManuallyKey.UseVisualStyleBackColor = True
        '
        'btnClearOrder
        '
        Me.btnClearOrder.Location = New System.Drawing.Point(439, 498)
        Me.btnClearOrder.Name = "btnClearOrder"
        Me.btnClearOrder.Size = New System.Drawing.Size(202, 28)
        Me.btnClearOrder.TabIndex = 32
        Me.btnClearOrder.Text = "Clear Order"
        Me.btnClearOrder.UseVisualStyleBackColor = True
        '
        'btnTakePayment
        '
        Me.btnTakePayment.BackColor = System.Drawing.Color.Green
        Me.btnTakePayment.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnTakePayment.Location = New System.Drawing.Point(439, 530)
        Me.btnTakePayment.Name = "btnTakePayment"
        Me.btnTakePayment.Size = New System.Drawing.Size(203, 59)
        Me.btnTakePayment.TabIndex = 31
        Me.btnTakePayment.Text = "Take Payment"
        Me.btnTakePayment.UseVisualStyleBackColor = False
        '
        'btnAddItem4
        '
        Me.btnAddItem4.Location = New System.Drawing.Point(439, 405)
        Me.btnAddItem4.Name = "btnAddItem4"
        Me.btnAddItem4.Size = New System.Drawing.Size(203, 67)
        Me.btnAddItem4.TabIndex = 30
        Me.btnAddItem4.Text = "Oatmeal - $2.00"
        Me.btnAddItem4.UseVisualStyleBackColor = True
        '
        'btnAddItem3
        '
        Me.btnAddItem3.Location = New System.Drawing.Point(439, 332)
        Me.btnAddItem3.Name = "btnAddItem3"
        Me.btnAddItem3.Size = New System.Drawing.Size(203, 67)
        Me.btnAddItem3.TabIndex = 29
        Me.btnAddItem3.Text = "Toast - $1.25"
        Me.btnAddItem3.UseVisualStyleBackColor = True
        '
        'btnAddItem2
        '
        Me.btnAddItem2.Location = New System.Drawing.Point(439, 259)
        Me.btnAddItem2.Name = "btnAddItem2"
        Me.btnAddItem2.Size = New System.Drawing.Size(203, 67)
        Me.btnAddItem2.TabIndex = 28
        Me.btnAddItem2.Text = "Eggs - $2.90"
        Me.btnAddItem2.UseVisualStyleBackColor = True
        '
        'btnAddItem1
        '
        Me.btnAddItem1.Location = New System.Drawing.Point(439, 186)
        Me.btnAddItem1.Name = "btnAddItem1"
        Me.btnAddItem1.Size = New System.Drawing.Size(203, 67)
        Me.btnAddItem1.TabIndex = 27
        Me.btnAddItem1.Text = "Coffee - $1.50"
        Me.btnAddItem1.UseVisualStyleBackColor = True
        '
        'listItems
        '
        Me.listItems.FormattingEnabled = True
        Me.listItems.Location = New System.Drawing.Point(9, 185)
        Me.listItems.MultiColumn = True
        Me.listItems.Name = "listItems"
        Me.listItems.Size = New System.Drawing.Size(423, 433)
        Me.listItems.TabIndex = 26
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2, Me.toolStripStatusLabel3})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 679)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(648, 22)
        Me.statusStrip1.TabIndex = 25
        Me.statusStrip1.Text = "statusBottom"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.AutoSize = False
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(201, 17)
        Me.toolStripStatusLabel1.Text = "Offline"
        Me.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'toolStripStatusLabel2
        '
        Me.toolStripStatusLabel2.AutoSize = False
        Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
        Me.toolStripStatusLabel2.Size = New System.Drawing.Size(201, 17)
        Me.toolStripStatusLabel2.Text = "IP: -"
        '
        'toolStripStatusLabel3
        '
        Me.toolStripStatusLabel3.AutoSize = False
        Me.toolStripStatusLabel3.Name = "toolStripStatusLabel3"
        Me.toolStripStatusLabel3.Size = New System.Drawing.Size(201, 17)
        Me.toolStripStatusLabel3.Text = "Serial #"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 701)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefund)
        Me.Controls.Add(Me.btnManuallyKey)
        Me.Controls.Add(Me.btnClearOrder)
        Me.Controls.Add(Me.btnTakePayment)
        Me.Controls.Add(Me.btnAddItem4)
        Me.Controls.Add(Me.btnAddItem3)
        Me.Controls.Add(Me.btnAddItem2)
        Me.Controls.Add(Me.btnAddItem1)
        Me.Controls.Add(Me.listItems)
        Me.Controls.Add(Me.statusStrip1)
        Me.Name = "TestForm"
        Me.Text = "Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnSigCapture As System.Windows.Forms.Button
    Friend WithEvents btnDisplayMessage As System.Windows.Forms.Button
    Friend WithEvents btnClearScreen As System.Windows.Forms.Button
    Friend WithEvents lblDeviceStatus As System.Windows.Forms.Label
    Friend WithEvents lblDeviceModel As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRefund As System.Windows.Forms.Button
    Friend WithEvents btnManuallyKey As System.Windows.Forms.Button
    Friend WithEvents btnClearOrder As System.Windows.Forms.Button
    Friend WithEvents btnTakePayment As System.Windows.Forms.Button
    Friend WithEvents btnAddItem4 As System.Windows.Forms.Button
    Friend WithEvents btnAddItem3 As System.Windows.Forms.Button
    Friend WithEvents btnAddItem2 As System.Windows.Forms.Button
    Friend WithEvents btnAddItem1 As System.Windows.Forms.Button
    Protected WithEvents listItems As System.Windows.Forms.ListBox
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Public WithEvents toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents toolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel

End Class
