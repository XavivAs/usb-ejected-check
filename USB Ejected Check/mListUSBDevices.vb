Imports System.Xml
Imports System.Text

Public Module mListUSBDevices
    'Listing the drive letters, e.g. C:\, B:\ etc.
    Public arrayDriveList As New ArrayList
    'Listing the drive names, e.g. OS, Data, Peter's Drive etc.
    Public arrayDriveNames As New ArrayList

    Public Function ListUSBDevices()
        frmMain.cUSBDevices.Items.Clear()
        arrayDriveList.Clear()
        arrayDriveNames.Clear()

        Dim USBDevices() As String
        USBDevices = System.IO.Directory.GetLogicalDrives()
        For Each item In USBDevices
            arrayDriveList.Add(item)
            arrayDriveNames.Add(Dir(item, FileAttribute.Volume))
            'Adding the last item of both arrayDriveList and arrayDriveNames
            frmMain.cUSBDevices.Items.Add(arrayDriveList.Item(arrayDriveList.Count - 1) & " - " & arrayDriveNames.Item(arrayDriveNames.Count - 1))
        Next
        Return vbNull
    End Function

    Public Function InitializeSilentMode()
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
        For i = 0 To arrayDriveList.Count - 1
            Dim newItem As New ListViewItem(arrayDriveList.Item(i).ToString)
            newItem.SubItems.Add(arrayDriveNames.Item(i).ToString)
            frmMain.lstIgnoredDevices.Items.Add(newItem)
            newItem = Nothing
        Next
    End Function

    Public Function DeinitializeSilentMode()
        frmMain.lstIgnoredDevices.Enabled = False
        frmMain.lIgnoredDevices.Enabled = False
        frmMain.groupDetection.Enabled = True
        frmMain.btnTableRenew.Enabled = False
    End Function

    Public Function WriteSettings()
        Try
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            settings.Encoding = Encoding.Default

            Dim XmlWrt As XmlWriter = XmlWriter.Create(CurDir() & "\USB Ejected Check.ini", settings)

            With XmlWrt

                ' Write the Xml declaration.
                .WriteStartDocument()

                ' Write a comment.
                .WriteComment("USB Ejected Check, created by Koenvh (http://koenvh.nl)")
                .WriteStartElement("Settings")
                .WriteStartElement("playSound")
                .WriteString(frmMain.rPlaySound.Checked.ToString)
                .WriteEndElement()
                .WriteStartElement("fileLocation")
                .WriteString(frmMain.txtSoundFile.Text)
                .WriteEndElement()
                .WriteStartElement("silentMode")
                .WriteString(frmMain.rSilentMode.Checked.ToString)
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndDocument()
                .Close()

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return vbNull
    End Function

    Public Function ReadSettings()
        Try
            Dim document As XmlReader
            document = New XmlTextReader(CurDir() & "\USB Ejected Check.ini")
            Dim playSound As Boolean = False
            Dim soundFile As String = ""
            Dim silentMode As Boolean = False
            While (document.Read())

                Dim type = document.NodeType

                If (type = XmlNodeType.Element) Then
                    If (document.Name = "playSound") Then
                        playSound = CBool(document.ReadInnerXml.ToString)
                    End If
                    If (document.Name = "fileLocation") Then
                        soundFile = document.ReadInnerXml.ToString
                    End If
                    If (document.Name = "silentMode") Then
                        silentMode = document.ReadInnerXml.ToString
                    End If
                End If

            End While

            'Apply settings
            frmMain.rPlaySound.Checked = playSound
            frmMain.txtSoundFile.Text = soundFile
            frmMain.dlgSoundFile.FileName = soundFile
            frmMain.rSilentMode.Checked = silentMode
            document.Close()

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return vbNull
    End Function
End Module
