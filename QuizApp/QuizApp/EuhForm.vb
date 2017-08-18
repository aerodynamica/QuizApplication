Imports System.ComponentModel
Imports System.Threading
Imports QuizApp

Public Class EuhForm

    Private _CurrentPlayer As Player

    Public Property CurrentPlayer As Player
        Get
            Return _CurrentPlayer
        End Get
        Set(value As Player)
            _CurrentPlayer = value
        End Set
    End Property


    Private _TimeLeft As Integer

    Public Property TimeLeft As Integer
        Get
            Return _TimeLeft
        End Get
        Set(value As Integer)
            _TimeLeft = value
        End Set
    End Property

    Private WithEvents Bridge As CardBridge

    Public Event PlayerInterupt(ByVal sender As Object, ByVal e As EventArgs)

    Public Event TimeOut(ByVal sender As Object, ByVal e As EventArgs)

    Dim IsActive As Boolean = False

    Private TimeOutThread As Thread

    Private Sub EuhForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        If TimeLeft > 0 Then
            CountdownTimer.Start()
        End If

    End Sub

    Private Sub StopTimer()
        CountdownTimer.Stop()
    End Sub

    Public Sub UpdateCurrentPlayer(ByRef player As Player)
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

    Private Sub NewGame()
        StopTimer()
        Dim newForm As New NewEuhForm(Me)
        newForm.Show()


    End Sub

    Private Sub btnStartNew_Click(sender As Object, e As EventArgs) Handles btnStartNew.Click
        NewGame()
    End Sub

End Class