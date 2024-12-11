Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click

        'Output each item in a separate message box one after another

        Dim aiData(4) As Integer
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            MsgBox(aiData(i))
        Next


    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click

    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click

    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click

    End Sub
End Class
