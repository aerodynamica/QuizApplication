Public Class MainMenuForm

    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        Dim form As New QuizForm()
        form.Show()
        Me.Close()
    End Sub

    Private Sub btnNames_Click(sender As Object, e As EventArgs) Handles btnNames.Click
        Dim form As New NamesForm()
        form.Show()
    End Sub
End Class
