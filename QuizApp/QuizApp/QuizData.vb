<Serializable()> Public Class QuizData

    Private _players(3) As Player


    Public Property Player1 As Player
        Get
            Return _players(0)
        End Get
        Set(value As Player)
            _players(0) = value
        End Set
    End Property

    Public Property Player2 As Player
        Get
            Return _players(1)
        End Get
        Set(value As Player)
            _players(1) = value
        End Set
    End Property

    Public Property Player3 As Player
        Get
            Return _players(2)
        End Get
        Set(value As Player)
            _players(2) = value
        End Set
    End Property

    Public Property Player4 As Player
        Get
            Return _players(3)
        End Get
        Set(value As Player)
            _players(3) = value
        End Set
    End Property

    Public Function getPlayer(ByVal n As Integer) As Player
        Return _players(n)
    End Function

End Class
