<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlert))
        Me.lMessage = New System.Windows.Forms.Label()
        Me.tmCloseMessage = New System.Windows.Forms.Timer(Me.components)
        Me.lCloseMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'lMessage
        '
        Me.lMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lMessage.Font = New System.Drawing.Font("Segoe UI", 48!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lMessage.ForeColor = System.Drawing.Color.White
        Me.lMessage.Location = New System.Drawing.Point(-1, 239)
        Me.lMessage.Name = "lMessage"
        Me.lMessage.Size = New System.Drawing.Size(803, 86)
        Me.lMessage.TabIndex = 0
        Me.lMessage.Text = "Please eject your USB drive"
        Me.lMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmCloseMessage
        '
        Me.tmCloseMessage.Interval = 1000
        '
        'lCloseMessage
        '
        Me.lCloseMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lCloseMessage.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lCloseMessage.ForeColor = System.Drawing.Color.White
        Me.lCloseMessage.Location = New System.Drawing.Point(262, 340)
        Me.lCloseMessage.Name = "lCloseMessage"
        Me.lCloseMessage.Size = New System.Drawing.Size(276, 21)
        Me.lCloseMessage.TabIndex = 1
        Me.lCloseMessage.Text = "(Click anywhere to close this message)"
        Me.lCloseMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lCloseMessage)
        Me.Controls.Add(Me.lMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmAlert"
        Me.Opacity = 0.7R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please eject your USB drive"
        Me.TopMost = true
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lMessage As System.Windows.Forms.Label
    Friend WithEvents tmCloseMessage As System.Windows.Forms.Timer
    Friend WithEvents lCloseMessage As System.Windows.Forms.Label
End Class
