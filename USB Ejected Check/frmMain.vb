Public Class frmMain
    Public selectedDrive As String = "C:\"

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If 1 = 1 Then '(Just for testing purposes, because I don't want to shutdown my PC every time.
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
            ElseIf rSilentMode.Enabled = True Then
                ListUSBDevices()
                'Dim IgnoredArray As New ArrayList
                'For Each item In lstIgnoredDevices.Items
                '    IgnoredArray.Add(item.subitems(0).text)
                'Next
                For Each drive In arrayDriveList
                    'Loop through all drives that are currently connected
                    For Each item In lstIgnoredDevices.Items
                        'Loop through all ignored drives, and check if it exist
                        If item.subitems(0).Text = drive Then
                            Exit For
                        Else
                            'When reached the final item, and it still hasn't been found on the "ignored" list, display the message.
                            If item.index = lstIgnoredDevices.Items.Count - 1 Then
                                e.Cancel = True
                                frmAlert.Show()
                            End If
                        End If
                    Next
                Next

            End If
        ElseIf e.CloseReason = CloseReason.UserClosing Then
            If rEnabled.Checked Or rSilentMode.Checked Then
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
        'Then initialize/scan USB devices
        ListUSBDevices()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Let's check whether it has to run silently
        For Each Argument As String In My.Application.CommandLineArgs
            Select Case Trim(LCase(Argument))
                Case "/silent"
                    Me.Visible = False
                Case "/loud"
                    MsgBox("I can hear you!", MsgBoxStyle.Information)

            End Select
        Next
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

    Private Sub btnSilentModeHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnSilentModeHelp.LinkClicked

    End Sub

    Private Sub btnSilentModeHelp_MouseHover(sender As Object, e As EventArgs) Handles btnSilentModeHelp.MouseHover

    End Sub

    Private Sub rSilentMode_CheckedChanged(sender As Object, e As EventArgs) Handles rSilentMode.CheckedChanged
        If rSilentMode.Checked Then
            InitializeSilentMode()
        Else
            DeinitializeSilentMode()
        End If
    End Sub

    Private Sub btnTableRefresh_Click(sender As Object, e As EventArgs) Handles btnTableRenew.Click
        InitializeSilentMode()
    End Sub

    Private Sub btnTableRemove_Click(sender As Object, e As EventArgs)
        Try
            For Each item In lstIgnoredDevices.SelectedItems
                lstIgnoredDevices.Items.Remove(item)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub rPlaySound_CheckedChanged(sender As Object, e As EventArgs) Handles rPlaySound.CheckedChanged
        If rPlaySound.Checked Then
            txtSoundFile.Enabled = True
            btnSoundFile.Enabled = True
            lOpenFile.Enabled = True
        Else
            txtSoundFile.Enabled = False
            btnSoundFile.Enabled = False
            lOpenFile.Enabled = False
        End If
    End Sub
End Class
