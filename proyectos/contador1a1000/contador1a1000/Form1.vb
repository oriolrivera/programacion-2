Public Class Form1


    Public Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim objBucle As New Bucle
        'Dim x As Integer

        'MsgBox(objBucle.count(TextBox1.Text))
        TextBox2.Text = objBucle.count(TextBox1.Text)
        'TextBox2.Text = objBucle.count(TextBox1.Text)


        'MsgBox(TextBox2.Tnext)

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim objBucle As New Bucle
        'objBucle.count(TextBox1.Text)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
