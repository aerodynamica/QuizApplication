Imports System.ComponentModel
Imports System.Threading
Imports QuizApp

Public Class EuhForm

    Private CurrentPlayer As Player
    Private TimeLeft As Integer
    Private WithEvents Bridge As CardBridge




    Private Sub EuhForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateCurrentPlayer(MainMenuForm.data.getPlayer(0))

        TimeLeft = 60
        lblTimer.Text = TimeLeft.ToString

        Bridge = New CardBridge()
        Bridge.Start()



    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartTimer()
    End Sub

    Private Sub StartTimer()
        CountdownTimer.Start()
    End Sub

    Private Sub StopTimer()
        CountdownTimer.Stop()
    End Sub

    Private Sub updateCurrentPlayer(ByRef player As Player)
        CurrentPlayer = player
        lblCurrentPlayerName.Text = player.FirstName
    End Sub




    Private Sub CountdownTimer_Tick(sender As Object, e As EventArgs) Handles CountdownTimer.Tick
        TimeLeft -= 1
        lblTimer.Text = TimeLeft.ToString

        If TimeLeft = 0 Then
            ' raise event
        End If
    End Sub

    Private Sub Bridge_ButtonPressed(sender As Object, e As CardBridge.ButtonPressedEventArgs) Handles Bridge.ButtonPressed
        If e.button = 5 Then
            If Not CountdownTimer.Enabled Then
                StartTimer()

            End If
        Else
            If CountdownTimer.Enabled Then
                StopTimer()
                CurrentPlayer = MainMenuForm.data.getPlayer(e.button)
                Invoke(New MethodInvoker(Sub() updateCurrentPlayer(CurrentPlayer)))

            End If

        End If
    End Sub

    Private Sub EuhForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Bridge.Abort()

    End Sub
End Class