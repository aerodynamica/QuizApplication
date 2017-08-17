Imports System.ComponentModel
Imports System.Threading

Public Class QuizForm


    Dim CardControl As Card_Controller
    Dim IsActive As Boolean = False


    Dim Player1 As String = ""
    Dim Player2 As String = ""
    Dim Player3 As String = ""
    Dim Player4 As String = ""


    'threads
    Dim Player1Watch As System.Threading.Thread = Nothing
    Dim Player3Watch As System.Threading.Thread = Nothing
    Dim Player4Watch As System.Threading.Thread = Nothing
    Dim RefereeWatch As System.Threading.Thread = Nothing
    Dim Player2Watch As System.Threading.Thread = Nothing

    Public Sub DisplayNameBig(ByVal player As Integer)
        'lblBig.Text = Name

        Select Case player
            Case 1
                lblBig.Text = Player1
            Case 2
                lblBig.Text = Player2
            Case 3
                lblBig.Text = Player3
            Case 4
                lblBig.Text = Player4
            Case 5
                lblBig.Text = " "
        End Select




    End Sub

    Private Sub QuizForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Player1 = MainMenuForm.data.Player1.FirstName
        Player2 = MainMenuForm.data.Player2.FirstName
        Player3 = MainMenuForm.data.Player3.FirstName
        Player4 = MainMenuForm.data.Player4.FirstName

        lblCandidate1.Text = Player1
        lblCandidate2.Text = Player2
        lblCandidate3.Text = Player3
        lblCandidate4.Text = Player4


        CardControl = New Card_Controller()
        IsActive = CardControl.Connect()



        Player1Watch = New System.Threading.Thread(AddressOf CheckInputPlayer1)
        Player2Watch = New System.Threading.Thread(AddressOf CheckInputPlayer2)
        Player3Watch = New System.Threading.Thread(AddressOf CheckInputPlayer3)
        Player4Watch = New System.Threading.Thread(AddressOf CheckInputPlayer4)
        RefereeWatch = New System.Threading.Thread(AddressOf CheckInputReferee)


        Player1Watch.Start()
        Player2Watch.Start()
        Player3Watch.Start()
        Player4Watch.Start()
        RefereeWatch.Start()


        If (IsActive = False) Then
            Me.Close()
        End If

    End Sub








    Dim PlayerPressed As Boolean = False 'For fairness in timing


    Sub CheckInputPlayer1()
        If IsActive Then
            While True
                If (CardControl.IsButtonPressed(1) And PlayerPressed = False) Then
                    PlayerPressed = True
                    'DisplayNameBig(1)



                    Me.Invoke(Sub() DisplayNameBig(1))

                    CardControl.ActivateLed(8, True)
                    Thread.Sleep(1000)
                    CardControl.ActivateLed(8, False)

                End If
            End While
        End If
    End Sub

    Sub CheckInputPlayer2()
        If IsActive Then
            While True
                If (CardControl.IsButtonPressed(2) And PlayerPressed = False) Then
                    PlayerPressed = True
                    'DisplayNameBig(2)



                    Me.Invoke(Sub() DisplayNameBig(2))


                    CardControl.ActivateLed(7, True)
                    Thread.Sleep(1000)
                    CardControl.ActivateLed(7, False)
                End If
            End While
        End If
    End Sub

    Sub CheckInputPlayer3()
        If IsActive Then
            While True
                If (CardControl.IsButtonPressed(3) And PlayerPressed = False) Then
                    PlayerPressed = True
                    'DisplayNameBig(3)



                    Me.Invoke(Sub() DisplayNameBig(3))


                    CardControl.ActivateLed(6, True)
                    Thread.Sleep(1000)
                    CardControl.ActivateLed(6, False)
                End If
            End While
        End If
    End Sub

    Sub CheckInputPlayer4()
        If IsActive Then
            While True
                If (CardControl.IsButtonPressed(4) And PlayerPressed = False) Then
                    PlayerPressed = True
                    'DisplayNameBig(4)
                    CardControl.ActivateLed(5, True)


                    Me.Invoke(Sub() DisplayNameBig(4))

                    CardControl.ActivateLed(5, True)
                    Thread.Sleep(1000)
                    CardControl.ActivateLed(5, False)

                End If
            End While
        End If
    End Sub

    Sub CheckInputReferee()
        If IsActive Then
            While True
                If (CardControl.IsButtonPressed(5)) Then
                    PlayerPressed = False
                    'DisplayNameBig(5)

                    CardControl.ClearCardForUse()
                    Me.Invoke(Sub() DisplayNameBig(5))

                End If
            End While
        End If
    End Sub

    Private Sub QuizForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


        'Abort threads
        Player1Watch.Abort()
        Player2Watch.Abort()
        Player3Watch.Abort()
        Player4Watch.Abort()
        RefereeWatch.Abort()


        If (IsActive) Then
            CardControl.Disconnect()
        End If

    End Sub
End Class