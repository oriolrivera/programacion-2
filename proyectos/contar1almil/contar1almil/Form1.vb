Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer

        i = TextBox1.Text

        For init As Integer = 0 To 10 Step i
            'MsgBox(init)
            ' TextBox2.Text = init
            TextBox2.Text = TextBox2.Text & init & " "

        Next
    End Sub

   
End Class
