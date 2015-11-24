Public Class Estudiante : Inherits People

    'Private matricula As Integer

    Public Property matric() As Integer
        Get
            Return matricula

        End Get
        Set(ByVal value As Integer)
            matricula = value
        End Set
    End Property

End Class
