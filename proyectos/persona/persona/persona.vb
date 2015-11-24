Public Class People

    Private nombre1 As String
    Protected matricula As Integer




    Public Property nombre() As String
        Get
            Return nombre1
        End Get
        Set(ByVal value As String)
            nombre1 = value
        End Set
    End Property


End Class
