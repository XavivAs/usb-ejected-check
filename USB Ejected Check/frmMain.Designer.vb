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
        Me.btnDetectionHelp = New System.Windows.Forms.LinkLabel()
        Me.notifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextNotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupSilent = New System.Windows.Forms.GroupBox()
        Me.btnTableRenew = New System.Windows.Forms.Button()
        Me.btnSilentModeHelp = New System.Windows.Forms.LinkLabel()
        Me.lIgnoredDevices = New System.Windows.Forms.Label()
        Me.lstIgnoredDevices = New System.Windows.Forms.ListView()
        Me.driveLetter = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.driveName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.rSilentMode = New System.Windows.Forms.CheckBox()
        Me.tooltipSilentMode = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnCreateShortcut = New System.Windows.Forms.Button()
        Me.btnRemoveShortcut = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.groupStartup = New System.Windows.Forms.GroupBox()
        Me.groupDetection.SuspendLayout
        Me.contextNotify.SuspendLayout
        Me.groupSilent.SuspendLayout
        CType(Me.picLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupStartup.SuspendLayout
        Me.SuspendLayout
        '
        'cUSBDevices
        '
        Me.cUSBDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cUSBDevices.FormattingEnabled = true
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
        Me.btnRefresh.UseVisualStyleBackColor = true
        '
        'rEnabled
        '
        Me.rEnabled.Location = New System.Drawing.Point(122, 60)
        Me.rEnabled.Name = "rEnabled"
        Me.rEnabled.Size = New System.Drawing.Size(103, 39)
        Me.rEnabled.TabIndex = 3
        Me.rEnabled.Text = "Enable"
        Me.rEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rEnabled.UseVisualStyleBackColor = true
        '
        'btnShowExample
        '
        Me.btnShowExample.AutoSize = true
        Me.btnShowExample.Location = New System.Drawing.Point(250, 9)
        Me.btnShowExample.Name = "btnShowExample"
        Me.btnShowExample.Size = New System.Drawing.Size(76, 13)
        Me.btnShowExample.TabIndex = 4
        Me.btnShowExample.TabStop = true
        Me.btnShowExample.Text = "Show example"
        Me.tooltipSilentMode.SetToolTip(Me.btnShowExample, "Show an example of what happens when you leave your USB device in the computer.")
        '
        'lDevice
        '
        Me.lDevice.AutoSize = true
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
        Me.groupDetection.TabStop = false
        Me.groupDetection.Text = "Detection"
        '
        'btnDetectionHelp
        '
        Me.btnDetectionHelp.AutoSize = true
        Me.btnDetectionHelp.Location = New System.Drawing.Point(56, 16)
        Me.btnDetectionHelp.Name = "btnDetectionHelp"
        Me.btnDetectionHelp.Size = New System.Drawing.Size(13, 13)
        Me.btnDetectionHelp.TabIndex = 6
        Me.btnDetectionHelp.TabStop = true
        Me.btnDetectionHelp.Text = "?"
        Me.tooltipSilentMode.SetToolTip(Me.btnDetectionHelp, resources.GetString("btnDetectionHelp.ToolTip"))
        '
        'notifyIcon
        '
        Me.notifyIcon.ContextMenuStrip = Me.contextNotify
        Me.notifyIcon.Icon = CType(resources.GetObject("notifyIcon.Icon"),System.Drawing.Icon)
        Me.notifyIcon.Text = "USB Ejected Check"
        Me.notifyIcon.Visible = true
        '
        'contextNotify
        '
        Me.contextNotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitProgramToolStripMenuItem})
        Me.contextNotify.Name = "contextNotify"
        Me.contextNotify.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.contextNotify.Size = New System.Drawing.Size(142, 54)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(138, 6)
        '
        'ExitProgramToolStripMenuItem
        '
        Me.ExitProgramToolStripMenuItem.Name = "ExitProgramToolStripMenuItem"
        Me.ExitProgramToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ExitProgramToolStripMenuItem.Text = "Exit program"
        '
        'groupSilent
        '
        Me.groupSilent.Controls.Add(Me.btnTableRenew)
        Me.groupSilent.Controls.Add(Me.btnSilentModeHelp)
        Me.groupSilent.Controls.Add(Me.lIgnoredDevices)
        Me.groupSilent.Controls.Add(Me.lstIgnoredDevices)
        Me.groupSilent.Controls.Add(Me.rSilentMode)
        Me.groupSilent.Location = New System.Drawing.Point(12, 122)
        Me.groupSilent.Name = "groupSilent"
        Me.groupSilent.Size = New System.Drawing.Size(314, 151)
        Me.groupSilent.TabIndex = 12
        Me.groupSilent.TabStop = false
        Me.groupSilent.Text = "Silent mode"
        '
        'btnTableRenew
        '
        Me.btnTableRenew.Enabled = false
        Me.btnTableRenew.Location = New System.Drawing.Point(230, 28)
        Me.btnTableRenew.Name = "btnTableRenew"
        Me.btnTableRenew.Size = New System.Drawing.Size(75, 23)
        Me.btnTableRenew.TabIndex = 5
        Me.btnTableRenew.Text = "Renew"
        Me.btnTableRenew.UseVisualStyleBackColor = true
        '
        'btnSilentModeHelp
        '
        Me.btnSilentModeHelp.AutoSize = true
        Me.btnSilentModeHelp.Location = New System.Drawing.Point(130, 19)
        Me.btnSilentModeHelp.Name = "btnSilentModeHelp"
        Me.btnSilentModeHelp.Size = New System.Drawing.Size(13, 13)
        Me.btnSilentModeHelp.TabIndex = 3
        Me.btnSilentModeHelp.TabStop = true
        Me.btnSilentModeHelp.Text = "?"
        Me.tooltipSilentMode.SetToolTip(Me.btnSilentModeHelp, resources.GetString("btnSilentModeHelp.ToolTip"))
        '
        'lIgnoredDevices
        '
        Me.lIgnoredDevices.AutoSize = true
        Me.lIgnoredDevices.Enabled = false
        Me.lIgnoredDevices.Location = New System.Drawing.Point(7, 38)
        Me.lIgnoredDevices.Name = "lIgnoredDevices"
        Me.lIgnoredDevices.Size = New System.Drawing.Size(140, 13)
        Me.lIgnoredDevices.TabIndex = 2
        Me.lIgnoredDevices.Text = "Devices that will be ignored:"
        '
        'lstIgnoredDevices
        '
        Me.lstIgnoredDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.driveLetter, Me.driveName})
        Me.lstIgnoredDevices.Enabled = false
        Me.lstIgnoredDevices.FullRowSelect = true
        Me.lstIgnoredDevices.GridLines = true
        Me.lstIgnoredDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstIgnoredDevices.Location = New System.Drawing.Point(9, 54)
        Me.lstIgnoredDevices.Name = "lstIgnoredDevices"
        Me.lstIgnoredDevices.ShowItemToolTips = true
        Me.lstIgnoredDevices.Size = New System.Drawing.Size(297, 91)
        Me.lstIgnoredDevices.TabIndex = 0
        Me.lstIgnoredDevices.UseCompatibleStateImageBehavior = false
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
        Me.rSilentMode.AutoSize = true
        Me.rSilentMode.Location = New System.Drawing.Point(10, 18)
        Me.rSilentMode.Name = "rSilentMode"
        Me.rSilentMode.Size = New System.Drawing.Size(121, 17)
        Me.rSilentMode.TabIndex = 1
        Me.rSilentMode.Text = "Activate silent mode"
        Me.rSilentMode.UseVisualStyleBackColor = true
        '
        'tooltipSilentMode
        '
        Me.tooltipSilentMode.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tooltipSilentMode.ToolTipTitle = "Info"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.Location = New System.Drawing.Point(76, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(13, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "?"
        Me.tooltipSilentMode.SetToolTip(Me.LinkLabel1, "If you create a startup entry, USB Ejected Check will be run at startup and autom"& _ 
        "atically go into silent mode.")
        '
        'btnCreateShortcut
        '
        Me.btnCreateShortcut.Location = New System.Drawing.Point(9, 19)
        Me.btnCreateShortcut.Name = "btnCreateShortcut"
        Me.btnCreateShortcut.Size = New System.Drawing.Size(145, 23)
        Me.btnCreateShortcut.TabIndex = 13
        Me.btnCreateShortcut.Text = "Create startup entry"
        Me.btnCreateShortcut.UseVisualStyleBackColor = true
        '
        'btnRemoveShortcut
        '
        Me.btnRemoveShortcut.Location = New System.Drawing.Point(160, 19)
        Me.btnRemoveShortcut.Name = "btnRemoveShortcut"
        Me.btnRemoveShortcut.Size = New System.Drawing.Size(145, 23)
        Me.btnRemoveShortcut.TabIndex = 14
        Me.btnRemoveShortcut.Text = "Remove startup entry"
        Me.btnRemoveShortcut.UseVisualStyleBackColor = true
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.picLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLogo.Image = Global.USB_Ejected_Check.My.Resources.Resources.Koenvh_text
        Me.picLogo.Location = New System.Drawing.Point(102, 338)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(135, 41)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 6
        Me.picLogo.TabStop = false
        '
        'groupStartup
        '
        Me.groupStartup.Controls.Add(Me.LinkLabel1)
        Me.groupStartup.Controls.Add(Me.btnRemoveShortcut)
        Me.groupStartup.Controls.Add(Me.btnCreateShortcut)
        Me.groupStartup.Location = New System.Drawing.Point(12, 280)
        Me.groupStartup.Name = "groupStartup"
        Me.groupStartup.Size = New System.Drawing.Size(314, 51)
        Me.groupStartup.TabIndex = 15
        Me.groupStartup.TabStop = false
        Me.groupStartup.Text = "Startup entry"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 386)
        Me.Controls.Add(Me.groupSilent)
        Me.Controls.Add(Me.btnShowExample)
        Me.Controls.Add(Me.groupDetection)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.groupStartup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "frmMain"
        Me.Text = "USB Ejected Check"
        Me.groupDetection.ResumeLayout(false)
        Me.groupDetection.PerformLayout
        Me.contextNotify.ResumeLayout(false)
        Me.groupSilent.ResumeLayout(false)
        Me.groupSilent.PerformLayout
        CType(Me.picLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupStartup.ResumeLayout(false)
        Me.groupStartup.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cUSBDevices As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents rEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents btnShowExample As System.Windows.Forms.LinkLabel
    Friend WithEvents lDevice As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents groupDetection As System.Windows.Forms.GroupBox
    Friend WithEvents notifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents contextNotify As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents btnCreateShortcut As System.Windows.Forms.Button
    Friend WithEvents btnRemoveShortcut As System.Windows.Forms.Button
    Friend WithEvents groupStartup As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
