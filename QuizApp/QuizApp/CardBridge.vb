Imports System.Threading

Public Class CardBridge

    Private thr As Thread

    Private cc As Card_Controller

    Public Event ButtonPressed(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)


    Public Sub New()
        cc = New Card_Controller()
    End Sub

    Public Sub Start()
        thr = New Thread(AddressOf ThreadTask)
        thr.Start()
    End Sub

    Public Sub Abort()
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





    Public Class ButtonPressedEventArgs
        Inherits EventArgs

        Private btn As Integer

        Public Property button As Integer
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
