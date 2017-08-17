Public Class QuizForm


    Public Sub DisplayNameBig(ByVal name As String)
        lblBig.Text = name
    End Sub

    Private Sub QuizForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCandidate1.Text = MainMenuForm.data.Player1.FirstName
        lblCandidate2.Text = MainMenuForm.data.Player2.FirstName
        lblCandidate3.Text = MainMenuForm.data.Player3.FirstName
        lblCandidate4.Text = MainMenuForm.data.Player4.FirstName

    End Sub
End Class