Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged



        If (IsNumeric(TextBox1.Text)) Then
            TextBox1.ForeColor = Color.Gray

        Else

            TextBox1.ForeColor = Color.Black

        End If


    End Sub
End Class
