Public Class frmMain
    Public selectedDrive As String = "C:\"
    Public detectionEnabled As Boolean = False

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If 1 = 1 Then '(Just for testing purposes, because I don't want to shutdown my PC every time).
        If e.CloseReason = CloseReason.WindowsShutDown Then
            'Disable shutdown of program when the CloseReason is a shutdown, allow all other cases.
            If detectionEnabled Then
                If My.Computer.FileSystem.DirectoryExists(selectedDrive) = True Then
                    'Only execute when drive is still present
                    'Try cancelling the shutdown 
                    e.Cancel = True
                    'Load the form, displaying a message (in case of no sound)
                    frmAlert.Show()
                End If
            ElseIf rSilentMode.Enabled = True Then
                ListUSBDevices()
                For Each drive In arrayDrives
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
            If detectionEnabled Or rSilentMode.Checked Then
                'Disable closing the application, and thus disabling the check, when the check is enabled.
                e.Cancel = True
                Hide()
                'notifyIcon.ShowBalloonTip(6000, "USB Ejected Check is still running in the background", "If you want to close it, right-click and press ""Exit""", ToolTipIcon.Info)
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckRunFromUSB()

        rEnabled.Appearance = System.Windows.Forms.Appearance.Button
        'Then initialize/scan USB devices
        ListUSBDevices()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Let's check what arguments it got
        For Each Argument As String In My.Application.CommandLineArgs
            Dim trimArgument As String = Trim(LCase(Argument))
            'Silent, enable silent mode and hide it...
            If trimArgument = "/silent" Then
                InitializeSilentMode()
                Hide()
            End If
            'Automatic mode, basically immediately engage with the given letter
            If trimArgument.StartsWith("/auto=") Then
                Dim letter As String = trimArgument.Replace("/auto=", "").ToUpper()
                ToggleDetection(letter)
                For i = 0 To arrayDrives.Count
                    If arrayDrives(i)(0) = letter Then
                        cUSBDevices.SelectedIndex = i
                        Exit For
                    End If
                Next
                Hide()
                notifyIcon.ShowBalloonTip(4000, "Drive " & letter & " is now protected", "You will be notified when you shut off the computer without ejecting it", ToolTipIcon.Info)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ListUSBDevices()
    End Sub

    Private Sub rEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles rEnabled.CheckedChanged

    End Sub

    Sub ToggleDetection(ByVal selected As String)
        If detectionEnabled = False Then
            rEnabled.Text = "Disable"
            rEnabled.Checked = True
            btnRefresh.Enabled = False
            cUSBDevices.Enabled = False
            selectedDrive = selected
            detectionEnabled = True
        Else
            rEnabled.Text = "Enable"
            rEnabled.Checked = False
            btnRefresh.Enabled = True
            cUSBDevices.Enabled = True
            detectionEnabled = False
        End If
    End Sub

    Private Sub btnShowExample_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnShowExample.LinkClicked
        frmAlert.Show()
    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        Process.Start("http://koenvh.nl")
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Show()
        Activate()
    End Sub

    Private Sub notifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notifyIcon.MouseDoubleClick
        Show()
        Activate()
    End Sub

    Private Sub rSilentMode_CheckedChanged(sender As Object, e As EventArgs) Handles rSilentMode.CheckedChanged
        
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

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnCreateShortcut.Click
        If CreateShortcut() = True Then
            MsgBox("Startup entry created succesfully", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnRemoveShortcut_Click(sender As Object, e As EventArgs) Handles btnRemoveShortcut.Click
        If RemoveShortcut() = True Then
            MsgBox("Startup entry removed succesfully", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cUSBDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cUSBDevices.SelectedIndexChanged

    End Sub

    Private Sub rEnabled_Click(sender As Object, e As EventArgs) Handles rEnabled.Click
        If cUSBDevices.Text = "" Then
            'Check for a valid USB device string
            MsgBox("Please select a device first.", MsgBoxStyle.Exclamation)
        Else
            ToggleDetection(arrayDrives.Item(cUSBDevices.SelectedIndex)(0))
        End If
    End Sub

    Private Sub rSilentMode_Click(sender As Object, e As EventArgs) Handles rSilentMode.Click
        If rSilentMode.Checked Then
            InitializeSilentMode()
        Else
            DeinitializeSilentMode()
        End If
    End Sub

    Private Sub ExitProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitProgramToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
