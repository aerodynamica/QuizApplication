Imports System.Threading

Public Class EuhForm

    Private CurrentPlayer As Player
    Private TimeLeft As Integer

    Private CountdownThread As Thread


    Private Sub EuhForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentPlayer = MainMenuForm.data.Player1

        TimeLeft = 60


        lblCurrentPlayerName.Text = CurrentPlayer.FirstName
        lblTimer.Text = TimeLeft.ToString



    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartTimer()
    End Sub

    Private Sub StartTimer()
        CountdownTimer.Start()
    End Sub

    Private Sub stopTimer()
        CountdownTimer.Stop()
    End Sub



    Private Sub CountdownTimer_Tick(sender As Object, e As EventArgs) Handles CountdownTimer.Tick
        TimeLeft -= 1
        lblTimer.Text = TimeLeft.ToString
    End Sub
End Class