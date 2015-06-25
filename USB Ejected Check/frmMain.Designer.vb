<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cUSBDevices = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.rEnabled = New System.Windows.Forms.CheckBox()
        Me.btnShowExample = New System.Windows.Forms.LinkLabel()
        Me.lDevice = New System.Windows.Forms.Label()
        Me.groupDetection = New System.Windows.Forms.GroupBox()
        Me.groupSettings = New System.Windows.Forms.GroupBox()
        Me.lOpenFile = New System.Windows.Forms.Label()
        Me.btnSoundFile = New System.Windows.Forms.Button()
        Me.txtSoundFile = New System.Windows.Forms.TextBox()
        Me.rPlaySound = New System.Windows.Forms.CheckBox()
        Me.notifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextNotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjectUSBDriveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEject = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.dlgSoundFile = New System.Windows.Forms.OpenFileDialog()
        Me.groupSilent = New System.Windows.Forms.GroupBox()
        Me.btnSilentModeHelp = New System.Windows.Forms.LinkLabel()
        Me.lIgnoredDevices = New System.Windows.Forms.Label()
        Me.lstIgnoredDevices = New System.Windows.Forms.ListView()
        Me.driveLetter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.driveName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rSilentMode = New System.Windows.Forms.CheckBox()
        Me.tooltipSilentMode = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTableRenew = New System.Windows.Forms.Button()
        Me.btnDetectionHelp = New System.Windows.Forms.LinkLabel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.groupDetection.SuspendLayout()
        Me.groupSettings.SuspendLayout()
        Me.contextNotify.SuspendLayout()
        Me.groupSilent.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cUSBDevices
        '
        Me.cUSBDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cUSBDevices.FormattingEnabled = True
        Me.cUSBDevices.Location = New System.Drawing.Point(10, 32)
        Me.cUSBDevices.Name = "cUSBDevices"
        Me.cUSBDevices.Size = New System.Drawing.Size(215, 21)
        Me.cUSBDevices.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(231, 31)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'rEnabled
        '
        Me.rEnabled.Location = New System.Drawing.Point(122, 60)
        Me.rEnabled.Name = "rEnabled"
        Me.rEnabled.Size = New System.Drawing.Size(103, 39)
        Me.rEnabled.TabIndex = 3
        Me.rEnabled.Text = "Enable"
        Me.rEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rEnabled.UseVisualStyleBackColor = True
        '
        'btnShowExample
        '
        Me.btnShowExample.AutoSize = True
        Me.btnShowExample.Location = New System.Drawing.Point(250, 9)
        Me.btnShowExample.Name = "btnShowExample"
        Me.btnShowExample.Size = New System.Drawing.Size(76, 13)
        Me.btnShowExample.TabIndex = 4
        Me.btnShowExample.TabStop = True
        Me.btnShowExample.Text = "Show example"
        '
        'lDevice
        '
        Me.lDevice.AutoSize = True
        Me.lDevice.Location = New System.Drawing.Point(6, 16)
        Me.lDevice.Name = "lDevice"
        Me.lDevice.Size = New System.Drawing.Size(44, 13)
        Me.lDevice.TabIndex = 5
        Me.lDevice.Text = "Device:"
        '
        'groupDetection
        '
        Me.groupDetection.Controls.Add(Me.btnDetectionHelp)
        Me.groupDetection.Controls.Add(Me.lDevice)
        Me.groupDetection.Controls.Add(Me.cUSBDevices)
        Me.groupDetection.Controls.Add(Me.btnRefresh)
        Me.groupDetection.Controls.Add(Me.rEnabled)
        Me.groupDetection.Location = New System.Drawing.Point(12, 12)
        Me.groupDetection.Name = "groupDetection"
        Me.groupDetection.Size = New System.Drawing.Size(314, 104)
        Me.groupDetection.TabIndex = 7
        Me.groupDetection.TabStop = False
        Me.groupDetection.Text = "Detection"
        '
        'groupSettings
        '
        Me.groupSettings.Controls.Add(Me.lOpenFile)
        Me.groupSettings.Controls.Add(Me.btnSoundFile)
        Me.groupSettings.Controls.Add(Me.txtSoundFile)
        Me.groupSettings.Controls.Add(Me.rPlaySound)
        Me.groupSettings.Location = New System.Drawing.Point(12, 122)
        Me.groupSettings.Name = "groupSettings"
        Me.groupSettings.Size = New System.Drawing.Size(314, 92)
        Me.groupSettings.TabIndex = 8
        Me.groupSettings.TabStop = False
        Me.groupSettings.Text = "Sound"
        '
        'lOpenFile
        '
        Me.lOpenFile.AutoSize = True
        Me.lOpenFile.Enabled = False
        Me.lOpenFile.Location = New System.Drawing.Point(6, 43)
        Me.lOpenFile.Name = "lOpenFile"
        Me.lOpenFile.Size = New System.Drawing.Size(203, 13)
        Me.lOpenFile.TabIndex = 3
        Me.lOpenFile.Text = "Sound file to use (leave blank for default):"
        '
        'btnSoundFile
        '
        Me.btnSoundFile.Enabled = False
        Me.btnSoundFile.Location = New System.Drawing.Point(231, 57)
        Me.btnSoundFile.Name = "btnSoundFile"
        Me.btnSoundFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSoundFile.TabIndex = 2
        Me.btnSoundFile.Text = "Choose file"
        Me.btnSoundFile.UseVisualStyleBackColor = True
        '
        'txtSoundFile
        '
        Me.txtSoundFile.Enabled = False
        Me.txtSoundFile.Location = New System.Drawing.Point(9, 59)
        Me.txtSoundFile.Name = "txtSoundFile"
        Me.txtSoundFile.Size = New System.Drawing.Size(218, 20)
        Me.txtSoundFile.TabIndex = 1
        '
        'rPlaySound
        '
        Me.rPlaySound.AutoSize = True
        Me.rPlaySound.Location = New System.Drawing.Point(10, 20)
        Me.rPlaySound.Name = "rPlaySound"
        Me.rPlaySound.Size = New System.Drawing.Size(238, 17)
        Me.rPlaySound.TabIndex = 0
        Me.rPlaySound.Text = "Play sound when showing the eject message"
        Me.rPlaySound.UseVisualStyleBackColor = True
        '
        'notifyIcon
        '
        Me.notifyIcon.ContextMenuStrip = Me.contextNotify
        Me.notifyIcon.Icon = CType(resources.GetObject("notifyIcon.Icon"), System.Drawing.Icon)
        Me.notifyIcon.Text = "USB Ejected Check"
        Me.notifyIcon.Visible = True
        '
        'contextNotify
        '
        Me.contextNotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.EjectUSBDriveToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitProgramToolStripMenuItem})
        Me.contextNotify.Name = "contextNotify"
        Me.contextNotify.Size = New System.Drawing.Size(153, 76)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'EjectUSBDriveToolStripMenuItem
        '
        Me.EjectUSBDriveToolStripMenuItem.Name = "EjectUSBDriveToolStripMenuItem"
        Me.EjectUSBDriveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EjectUSBDriveToolStripMenuItem.Text = "Eject USB drive"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitProgramToolStripMenuItem
        '
        Me.ExitProgramToolStripMenuItem.Name = "ExitProgramToolStripMenuItem"
        Me.ExitProgramToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitProgramToolStripMenuItem.Text = "Exit program"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(12, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEject
        '
        Me.btnEject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEject.Location = New System.Drawing.Point(93, 394)
        Me.btnEject.Name = "btnEject"
        Me.btnEject.Size = New System.Drawing.Size(108, 23)
        Me.btnEject.TabIndex = 10
        Me.btnEject.Text = "Eject USB device"
        Me.btnEject.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Location = New System.Drawing.Point(207, 394)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 11
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'dlgSoundFile
        '
        Me.dlgSoundFile.Filter = "WAVE (*.wav)|*.wav"
        '
        'groupSilent
        '
        Me.groupSilent.Controls.Add(Me.btnTableRenew)
        Me.groupSilent.Controls.Add(Me.btnSilentModeHelp)
        Me.groupSilent.Controls.Add(Me.lIgnoredDevices)
        Me.groupSilent.Controls.Add(Me.lstIgnoredDevices)
        Me.groupSilent.Controls.Add(Me.rSilentMode)
        Me.groupSilent.Location = New System.Drawing.Point(12, 220)
        Me.groupSilent.Name = "groupSilent"
        Me.groupSilent.Size = New System.Drawing.Size(314, 151)
        Me.groupSilent.TabIndex = 12
        Me.groupSilent.TabStop = False
        Me.groupSilent.Text = "Silent mode"
        '
        'btnSilentModeHelp
        '
        Me.btnSilentModeHelp.AutoSize = True
        Me.btnSilentModeHelp.Location = New System.Drawing.Point(130, 19)
        Me.btnSilentModeHelp.Name = "btnSilentModeHelp"
        Me.btnSilentModeHelp.Size = New System.Drawing.Size(13, 13)
        Me.btnSilentModeHelp.TabIndex = 3
        Me.btnSilentModeHelp.TabStop = True
        Me.btnSilentModeHelp.Text = "?"
        Me.tooltipSilentMode.SetToolTip(Me.btnSilentModeHelp, resources.GetString("btnSilentModeHelp.ToolTip"))
        '
        'lIgnoredDevices
        '
        Me.lIgnoredDevices.AutoSize = True
        Me.lIgnoredDevices.Enabled = False
        Me.lIgnoredDevices.Location = New System.Drawing.Point(7, 38)
        Me.lIgnoredDevices.Name = "lIgnoredDevices"
        Me.lIgnoredDevices.Size = New System.Drawing.Size(140, 13)
        Me.lIgnoredDevices.TabIndex = 2
        Me.lIgnoredDevices.Text = "Devices that will be ignored:"
        '
        'lstIgnoredDevices
        '
        Me.lstIgnoredDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.driveLetter, Me.driveName})
        Me.lstIgnoredDevices.Enabled = False
        Me.lstIgnoredDevices.FullRowSelect = True
        Me.lstIgnoredDevices.GridLines = True
        Me.lstIgnoredDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstIgnoredDevices.Location = New System.Drawing.Point(9, 54)
        Me.lstIgnoredDevices.Name = "lstIgnoredDevices"
        Me.lstIgnoredDevices.ShowItemToolTips = True
        Me.lstIgnoredDevices.Size = New System.Drawing.Size(273, 91)
        Me.lstIgnoredDevices.TabIndex = 0
        Me.lstIgnoredDevices.UseCompatibleStateImageBehavior = False
        Me.lstIgnoredDevices.View = System.Windows.Forms.View.Details
        '
        'driveLetter
        '
        Me.driveLetter.Text = "Drive letter"
        Me.driveLetter.Width = 76
        '
        'driveName
        '
        Me.driveName.Text = "Drive name"
        Me.driveName.Width = 164
        '
        'rSilentMode
        '
        Me.rSilentMode.AutoSize = True
        Me.rSilentMode.Location = New System.Drawing.Point(10, 18)
        Me.rSilentMode.Name = "rSilentMode"
        Me.rSilentMode.Size = New System.Drawing.Size(121, 17)
        Me.rSilentMode.TabIndex = 1
        Me.rSilentMode.Text = "Activate silent mode"
        Me.rSilentMode.UseVisualStyleBackColor = True
        '
        'tooltipSilentMode
        '
        Me.tooltipSilentMode.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipSilentMode.ToolTipTitle = "Info"
        '
        'btnTableRenew
        '
        Me.btnTableRenew.Enabled = False
        Me.btnTableRenew.Location = New System.Drawing.Point(207, 28)
        Me.btnTableRenew.Name = "btnTableRenew"
        Me.btnTableRenew.Size = New System.Drawing.Size(75, 23)
        Me.btnTableRenew.TabIndex = 5
        Me.btnTableRenew.Text = "Renew"
        Me.btnTableRenew.UseVisualStyleBackColor = True
        '
        'btnDetectionHelp
        '
        Me.btnDetectionHelp.AutoSize = True
        Me.btnDetectionHelp.Location = New System.Drawing.Point(56, 16)
        Me.btnDetectionHelp.Name = "btnDetectionHelp"
        Me.btnDetectionHelp.Size = New System.Drawing.Size(13, 13)
        Me.btnDetectionHelp.TabIndex = 6
        Me.btnDetectionHelp.TabStop = True
        Me.btnDetectionHelp.Text = "?"
        Me.tooltipSilentMode.SetToolTip(Me.btnDetectionHelp, resources.GetString("btnDetectionHelp.ToolTip"))
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLogo.Image = Global.USB_Ejected_Check.My.Resources.Resources.iconKoenvh
        Me.picLogo.Location = New System.Drawing.Point(289, 377)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(50, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLogo.TabIndex = 6
        Me.picLogo.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 426)
        Me.Controls.Add(Me.groupSilent)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnEject)
        Me.Controls.Add(Me.btnShowExample)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.groupSettings)
        Me.Controls.Add(Me.groupDetection)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "USB Ejected Check"
        Me.groupDetection.ResumeLayout(False)
        Me.groupDetection.PerformLayout()
        Me.groupSettings.ResumeLayout(False)
        Me.groupSettings.PerformLayout()
        Me.contextNotify.ResumeLayout(False)
        Me.groupSilent.ResumeLayout(False)
        Me.groupSilent.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cUSBDevices As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents rEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents btnShowExample As System.Windows.Forms.LinkLabel
    Friend WithEvents lDevice As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents groupDetection As System.Windows.Forms.GroupBox
    Friend WithEvents groupSettings As System.Windows.Forms.GroupBox
    Friend WithEvents notifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents contextNotify As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EjectUSBDriveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rPlaySound As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEject As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lOpenFile As System.Windows.Forms.Label
    Friend WithEvents btnSoundFile As System.Windows.Forms.Button
    Friend WithEvents txtSoundFile As System.Windows.Forms.TextBox
    Friend WithEvents dlgSoundFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents groupSilent As System.Windows.Forms.GroupBox
    Friend WithEvents lstIgnoredDevices As System.Windows.Forms.ListView
    Friend WithEvents driveLetter As System.Windows.Forms.ColumnHeader
    Friend WithEvents driveName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lIgnoredDevices As System.Windows.Forms.Label
    Friend WithEvents rSilentMode As System.Windows.Forms.CheckBox
    Friend WithEvents btnSilentModeHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents tooltipSilentMode As System.Windows.Forms.ToolTip
    Friend WithEvents btnTableRenew As System.Windows.Forms.Button
    Friend WithEvents btnDetectionHelp As System.Windows.Forms.LinkLabel

End Class
