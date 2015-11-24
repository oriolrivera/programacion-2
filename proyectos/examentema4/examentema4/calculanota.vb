Public Class retornaDatos

    Dim nom As String
    Dim matr As String
    Dim lastnam As String

    Public Property matricul() As String
        Get
            Return matr
        End Get
        Set(ByVal value As String)
            matr = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return nom
        End Get
        Set(ByVal value As String)
            nom = value
        End Set
    End Property

    Public Property lastName() As String
        Get
            Return lastnam
        End Get
        Set(ByVal value As String)
            lastnam = value
        End Set
    End Property

    'Public Function calNota()

    'End Function

End Class
