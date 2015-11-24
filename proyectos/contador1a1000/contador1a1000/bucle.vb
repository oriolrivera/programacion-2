Public Class Bucle

    Private init As Integer
    ' Private y As Integer

    Public Property count(ByVal i) As Integer
        Get
            For init As Integer = 0 To 10 Step i
                ' For init As Integer = 0 To 5
                'TextBox2.Text = TextBox2.Text & init & " "

                MsgBox(init)
                'TextBox2.Text = TextBox2.Text & " " & init
                'MsgBox(TextBox2.Text)

            Next
            Return init

        End Get
        Set(ByVal value As Integer)
            init = value
        End Set
    End Property

    'Public Function test(ByVal init As Integer)
    'Return init
    'End Function


End Class
