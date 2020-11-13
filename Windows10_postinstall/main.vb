Imports System.Xml
Imports System.IO
Public Class main
    Private Sub linkGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkGithub.LinkClicked
        ' open github repository page in the default browser
        Process.Start("https://github.com/faffolao/Windows10_postinstall")
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' when i load the program i go to read the tweak list and i display them in the list.
        ' variables that raffigures xml fields
        Dim strName, strCallFunction, strRevertFunction As String
        ' variables needed for reading xml
        Dim xmldoc As XmlDocument
        Dim nodelist As XmlNodeList
        Dim node As XmlNode

        xmldoc = New XmlDocument
        xmldoc.Load("tweakList.xml")

        nodelist = xmldoc.GetElementsByTagName("tweak")
        For Each node In nodelist
            strName = node.Item("name").InnerText
            strCallFunction = node.Item("callFunction").InnerText
            strRevertFunction = node.Item("revertFunction").InnerText

            listTweaks.Items.Add(strName)
        Next
    End Sub
End Class
