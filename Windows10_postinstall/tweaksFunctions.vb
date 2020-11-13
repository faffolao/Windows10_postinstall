' This class contains all functions and all codes for each trick.
Public Class tweaksFunctions
    Function Hide3dObjectsFromThisPC()
        My.Computer.Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}")
    End Function

    Function Show3dObjectsFromThisPC()
        Dim key As Object
        key = My.Computer.Registry.LocalMachine.OpenSubKey("HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}")

        If key Is Nothing Then
            My.Computer.Registry.LocalMachine.CreateSubKey("HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}")
        End If
    End Function
End Class
