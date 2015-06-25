Imports System.Xml
Imports System.Text

Public Module mListUSBDevices
    'Listing the drive letters, e.g. C:\, B:\ etc.
    Public arrayDriveList As New ArrayList
    'Listing the drive names, e.g. OS, Data, Peter's Drive etc.
    Public arrayDriveNames As New ArrayList

    Public Function ListUSBDevices()
        frmMain.cUSBDevices.Items.Clear()
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
            While (document.Read())

                Dim type = document.NodeType

                If (type = XmlNodeType.Element) Then
                    If (document.Name = "playSound") Then
                        playSound = CBool(document.ReadInnerXml.ToString)
                    End If
                    If (document.Name = "fileLocation") Then
                        soundFile = document.ReadInnerXml.ToString
                    End If
                End If

            End While
            frmMain.rPlaySound.Checked = playSound
            frmMain.txtSoundFile.Text = soundFile
            frmMain.dlgSoundFile.FileName = soundFile
            document.Close()

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return vbNull
    End Function
End Module
