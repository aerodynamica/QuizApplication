<Serializable()> Public Class Player

    Public Sub New(ByVal firstName As String)
        Me.FirstName = firstName
    End Sub

    Public Sub New()

    End Sub

    Private _firstName As String

    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property




End Class
