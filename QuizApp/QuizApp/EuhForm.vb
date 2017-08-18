Imports System.ComponentModel
Imports System.Threading
Imports QuizApp

Public Class EuhForm

    Private CurrentPlayer As Player
    Private TimeLeft As Integer
    Private WithEvents Bridge As CardBridge

    Public Event PlayerInterupt(ByVal sender As Object, ByVal e As EventArgs)

    Public Event TimeOut(ByVal sender As Object, ByVal e As EventArgs)

    Dim IsActive As Boolean = False

    Private TimeOutThread As Thread

    Private Sub EuhForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCurrentPlayer(MainMenuForm.data.GetPlayer(0))

        TimeLeft = 2
        lblTimer.Text = TimeLeft.ToString

        Bridge = New CardBridge(Me)
        Bridge.Start()

        IsActive = Bridge.IsActive()


        If (IsActive = False) Then
            Me.Close()
        End If

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartTimer()
    End Sub

    Private Sub StartTimer()
        CountdownTimer.Start()
    End Sub

    Private Sub StopTimer()
        CountdownTimer.Stop()
    End Sub

    Private Sub UpdateCurrentPlayer(ByRef player As Player)
        CurrentPlayer = player
        lblCurrentPlayerName.Text = player.FirstName
    End Sub




    Private Sub CountdownTimer_Tick(sender As Object, e As EventArgs) Handles CountdownTimer.Tick
        TimeLeft -= 1
        lblTimer.Text = TimeLeft.ToString

        If TimeLeft = 0 Then
            StopTimer()

            Dim TimeOutThread As New Threading.Thread(Sub() RaiseEvent TimeOut(Me, EventArgs.Empty))
            TimeOutThread.Name = "TimeOutThread"
            TimeOutThread.IsBackground = True
            TimeOutThread.Start()
        End If
    End Sub

    Private Sub Bridge_ButtonPressed(sender As Object, e As CardBridge.ButtonPressedEventArgs) Handles Bridge.ButtonPressed
        If e.Button = 4 Then
            If Not CountdownTimer.Enabled Then
                Invoke(New MethodInvoker(AddressOf StartTimer))

            End If
        Else
            If CountdownTimer.Enabled Then
                StopTimer()
                CurrentPlayer = MainMenuForm.data.GetPlayer(e.Button)
                Invoke(New MethodInvoker(Sub() UpdateCurrentPlayer(CurrentPlayer)))
                RaiseEvent PlayerInterupt(Me, EventArgs.Empty)
            End If

        End If
    End Sub

End Class