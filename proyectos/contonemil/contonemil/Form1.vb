﻿Public Class Form1
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For init As Integer = 0 To 10 Step TextBox1.Text


            ' MsgBox(init)
            'i = i + init
            'MsgBox(i)
            TextBox2.Text = TextBox2.Text = init



        Next
    End Sub

 
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
