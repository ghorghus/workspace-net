Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)

        Dim iWindSpeed As Integer
        iWindSpeed = 30

        If iTemperature <= 0 And iWindSpeed > 20 Then
            MsgBox("that will feel really cold")
        End If

        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
                MsgBox("Water will freeze")
                MsgBox("and you can go skating")
            Case Is < 0
                MsgBox("Sub zero")
                If iWindSpeed > 20 Then
                    MsgBox("that will fel really cold")
                End If
            Case 1, 2, 5, 7, 9, 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select

        '   Switch stCountry
        '       Case "France"
        '           Print("Bonjour")
        '       Case "Japan"
        '           Print("Konichiwa")
        '       Default
        '           Print("Hello")
        '   endswitch





    End Sub
End Class
