Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles matricula.TextChanged

    End Sub

    Private Sub nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nombre.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apellido.TextChanged

    End Sub

    Private Sub nota1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nota1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim procesNot As New retornaDatos
        Dim notaFinal As Integer

        Dim not1 As Integer
        Dim not2 As Integer
        Dim not3 As Integer
        Dim not4 As Integer
        Dim not5 As Integer

        not1 = nota1.Text
        not2 = nota2.Text
        not3 = nota3.Text
        not4 = nota4.Text
        not5 = nota5.Text

        procesNot.matricul = matricula.Text
        procesNot.name = nombre.Text
        procesNot.lastName = apellido.Text()

        MsgBox("Nombre = " & procesNot.name & " Apellido = " & procesNot.lastName & " " & " Matricula = " & procesNot.matricul)
        notaFinal = not1 + not2 + not3 + not4 + not5

        MsgBox(notaFinal)


        If notaFinal >= 90 And notaFinal <= 100 Then
            MsgBox("A")
        ElseIf notaFinal >= 80 And notaFinal <= 89 Then
            MsgBox("B")
        ElseIf notaFinal >= 70 And notaFinal <= 79 Then
            MsgBox("C")
        ElseIf notaFinal >= 60 And notaFinal <= 69 Then
            MsgBox("D")
        End If


    End Sub

    
End Class
