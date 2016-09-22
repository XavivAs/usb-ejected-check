Imports System.IO
Imports System.Xml
Imports System.Text

Public Module mListUSBDevices
    'Listing the drive letters, e.g. C:\, B:\ etc.
    Public arrayDrives As New ArrayList

    Public Function ListUSBDevices()
        frmMain.cUSBDevices.Items.Clear()
        arrayDrives.Clear()

        Dim USBDevices() As String = System.IO.Directory.GetLogicalDrives()
        For Each item In USBDevices
            Dim letter As String = item
            Dim name As String = Dir(item, FileAttribute.Volume)
            arrayDrives.Add({letter, name})
            'Adding it to cUSBDevices
            frmMain.cUSBDevices.Items.Add(letter & " - " & name)
        Next
        Return vbNull
    End Function

    Public Function InitializeSilentMode()
        'Switch checkbox
        frmMain.rSilentMode.Checked = True

        'Enable controls
        frmMain.lstIgnoredDevices.Enabled = True
        frmMain.lIgnoredDevices.Enabled = True
        frmMain.groupDetection.Enabled = False
        frmMain.btnTableRenew.Enabled = True

        'Disable default enabler
        frmMain.rEnabled.Checked = False

        'Check for changes
        ListUSBDevices()

        'Clear previous list
        frmMain.lstIgnoredDevices.Items.Clear()

        'Add drives to list
        For i = 0 To arrayDrives.Count - 1
            Dim newItem As New ListViewItem(arrayDrives(i)(0).ToString())
            newItem.SubItems.Add(arrayDrives(i)(1).ToString())
            frmMain.lstIgnoredDevices.Items.Add(newItem)
            newItem = Nothing
        Next
        Return vbNull
    End Function

    Public Function DeinitializeSilentMode()
        frmMain.rSilentMode.Checked = false
        frmMain.lstIgnoredDevices.Enabled = False
        frmMain.lIgnoredDevices.Enabled = False
        frmMain.groupDetection.Enabled = True
        frmMain.btnTableRenew.Enabled = False
        Return vbNull
    End Function

    Public Sub CheckRunFromUSB()
        'Get current file path:
        Dim file As String = Application.ExecutablePath().ToString()
        'Loop through all drives
        Dim drives As System.IO.DriveInfo() = System.IO.DriveInfo.GetDrives()
        For Each drive In drives
            ' C:\, E:\, etc:\
            'Console.WriteLine(drive.Name & " <> " & file.Substring(0, 3))
            'If drive letter is file path drive letter
            If drive.Name = file.Substring(0, 3) Then
                If drive.DriveType = IO.DriveType.Removable Then
                    'Start process from temp folder to prevent Windows remove safely from saying the drive is busy.
                    Try
                    My.Computer.FileSystem.CopyFile(file, System.IO.Path.GetTempPath() & "\USB Ejected Check.exe", True)
                    Process.Start(System.IO.Path.GetTempPath() & "\USB Ejected Check.exe", "/auto=" & drive.Name)
                    Application.Exit()
                    Catch ex As IOException
                        MsgBox("Could not copy file to temporary directory. Switching to manual mode. Is it already running?", MsgBoxStyle.Critical)
                    End Try
                 End If
                Exit For
            End If
        Next
    End Sub

    Public Function CreateShortcut()
        Try
            'Source: https://social.msdn.microsoft.com/Forums/en-US/333add2a-95e7-4fd8-8874-bf21b653cdac/create-shortcut-using-net
            Dim wsh As Object = CreateObject("WScript.Shell")
            wsh = CreateObject("WScript.Shell")
            Dim MyShortcut, DesktopPath
            ' Read desktop path using WshSpecialFolders object
            DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
            ' Create a shortcut object on the desktop
            MyShortcut = wsh.CreateShortcut(DesktopPath & "\USB Ejected Check.lnk")
            ' Set shortcut object properties and save it
            MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(CurDir() & "\" & My.Application.Info.AssemblyName & ".exe")
            MyShortcut.Arguments = "/silent"
            MyShortcut.WorkingDirectory = wsh.ExpandEnvironmentStrings(CurDir())
            MyShortcut.WindowStyle = 4
            'Save the shortcut
            MyShortcut.Save()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try

    End Function

    Public Function RemoveShortcut()
        Try
            My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\USB Ejected Check.lnk", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
End Module
