Imports System.Threading

Public Class CardBridge

    Private thr As Thread

    Private cc As Card_Controller

    Public Event ButtonPressed(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)

    Private WithEvents EuhForm As EuhForm

    Public Sub New(ByRef form As EuhForm)
        cc = New Card_Controller()
        EuhForm = form
    End Sub

    Public Sub Start()
        thr = New Thread(AddressOf ThreadTask)
        thr.Start()
    End Sub

    Public Sub Abort()
        cc.Disconnect()
        thr.Abort()
    End Sub



    Public Sub ThreadTask()
        cc.Connect()
        Do
            Dim input As Boolean() = cc.CheckAllButtons()

            For i As Integer = 0 To input.Length - 1
                If input(i) Then
                    Dim e As New ButtonPressedEventArgs(i)
                    RaiseEvent ButtonPressed(Me, e)
                End If

            Next



        Loop
    End Sub

    Private Sub EuhForm_TimeOut(sender As Object, e As EventArgs) Handles EuhForm.TimeOut
        cc.ActivateLed(1, True)
        Thread.Sleep(3000)
        cc.ActivateLed(1, False)
    End Sub

    Private Sub EuhForm_PlayerInterupt(sender As Object, e As EventArgs) Handles EuhForm.PlayerInterupt
        cc.ActivateLed(1, True)
        Thread.Sleep(1000)
        cc.ActivateLed(1, False)
    End Sub

    Public Class ButtonPressedEventArgs
        Inherits EventArgs

        Private btn As Integer

        Public Property Button As Integer
            Get
                Return btn
            End Get
            Set(value As Integer)
                btn = value
            End Set
        End Property

        Public Sub New(ByVal btn As Integer)
            button = btn
        End Sub
    End Class


End Class
