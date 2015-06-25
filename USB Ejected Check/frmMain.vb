Public Class frmMain
    Public selectedDrive As String = "C:\"

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.WindowsShutDown Then
            'Disable shutdown of program when the CloseReason is a shutdown, allow all other cases.
            If rEnabled.Checked Then
                If My.Computer.FileSystem.DirectoryExists(selectedDrive) = True Then
                    'Only execute when drive is still present
                    'Try cancelling the shutdown 
                    e.Cancel = True
                    'Load the form, displaying a message (in case of no sound)
                    frmAlert.Show()
                End If
            End If
        ElseIf e.CloseReason = CloseReason.UserClosing Then
            If rEnabled.Checked Then
                'Disable closing the application, and thus disabling the check, when the check is enabled.
                e.Cancel = True
                Hide()
                notifyIcon.ShowBalloonTip(6000, "USB Ejected Check still running in the background", "If you want to close it, right-click and press ""Exit""", ToolTipIcon.Info)
            End If
        End If
        WriteSettings()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rEnabled.Appearance = System.Windows.Forms.Appearance.Button
        'Create first list 
        ReadSettings()
        ListUSBDevices()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ListUSBDevices()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles rEnabled.CheckedChanged
        If rEnabled.Checked Then
            If cUSBDevices.Text = "" Then
                'Check for a valid USB device string
                MsgBox("Please select a device first.", MsgBoxStyle.Exclamation)
                rEnabled.Checked = False
                Exit Sub
            End If
            rEnabled.Text = "Disable"
            btnRefresh.Enabled = False
            cUSBDevices.Enabled = False
            selectedDrive = arrayDriveList.Item(cUSBDevices.SelectedIndex)

        Else
            rEnabled.Text = "Enable"
            btnRefresh.Enabled = True
            cUSBDevices.Enabled = True
        End If
    End Sub

    Private Sub btnShowExample_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnShowExample.LinkClicked
        frmAlert.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        Process.Start("http://koenvh.nl")
    End Sub

    Private Sub ExitProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitProgramToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub EjectUSB()
        Try
            Shell("RunDll32.exe shell32.dll,Control_RunDLL HotPlug.dll")
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub EjectUSBDriveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjectUSBDriveToolStripMenuItem.Click
        EjectUSB()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Show()
        Activate()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnEject_Click(sender As Object, e As EventArgs) Handles btnEject.Click
        EjectUSB()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MsgBox("USB Ejected Check was created by Koenvh. Click on the logo to go to my website.", MsgBoxStyle.Information)
    End Sub

    Private Sub btnSoundFile_Click(sender As Object, e As EventArgs) Handles btnSoundFile.Click
        If dlgSoundFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSoundFile.Text = dlgSoundFile.FileName
        End If
    End Sub

    Private Sub notifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notifyIcon.MouseDoubleClick
        Show()
        Activate()
    End Sub
End Class
