Public Class EuhForm

    Private CurrentPlayer As Player
    Private TimeLeft As Integer


    Private Sub EuhForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentPlayer = MainMenuForm.data.Player1

        TimeLeft = 60


        lblCurrentPlayerName.Text = CurrentPlayer.FirstName
        lblTimer.Text = TimeLeft.ToString



    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub
End Class