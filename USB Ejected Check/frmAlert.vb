Public Class frmAlert

    Private Sub frmAlert_Click(sender As Object, e As EventArgs) Handles Me.Click
        Close()
    End Sub

    Private Sub frmAlert_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub frmAlert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmCloseMessage.Start()
        If frmMain.rPlaySound.Checked Then
            If frmMain.txtSoundFile.Text = "" Then
                My.Computer.Audio.Play(My.Resources.ejectNotification, AudioPlayMode.BackgroundLoop)
            Else
                My.Computer.Audio.Play(frmMain.txtSoundFile.Text, AudioPlayMode.BackgroundLoop)
            End If

        End If
    End Sub

    Private Sub tmCloseMessage_Tick(sender As Object, e As EventArgs) Handles tmCloseMessage.Tick
        If My.Computer.FileSystem.DirectoryExists(frmMain.selectedDrive) = False Then
            Close()
            frmMain.rEnabled.Checked = False
            ListUSBDevices()
        End If
    End Sub

    Private Sub lMessage_Click(sender As Object, e As EventArgs) Handles lMessage.Click
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lCloseMessage.Click
        Close()
    End Sub
End Class