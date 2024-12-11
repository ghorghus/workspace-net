Public Class Form1



    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("dupa i cyce")
        MsgBox("wodka")
        MsgBox("papierosy")
        MsgBox("popita")
        MsgBox("whisky")
        MsgBox("rum")

        MessageBox.Show("this is another message")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Kevin"
        stLastName = "Drumm"

        MsgBox(stFirstName)

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")


        stFirstName = "Murvin"
        stLastName = "Drake"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click


        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date


        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColour = "red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/2/2020#

        MsgBox("the car is " & stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & stColour & vbNewLine & bTaxed & vbNewLine &
               iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)

    End Sub
End Class
