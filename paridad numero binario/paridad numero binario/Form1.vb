Public Class Form1
    Dim cabeza = 0
    Dim resultado As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += " "
        q0()
    End Sub

    Sub q0()
        If TextBox1.Text(cabeza) = "0" Then
            resultado += "0"
            Label1.Text = resultado
            cabeza += 1
            MsgBox("stap")
            q0()
        ElseIf TextBox1.Text(cabeza) = "1" Then
            resultado += "1"
            Label1.Text = resultado
            cabeza += 1
            MsgBox("stap")
            q1()
        ElseIf TextBox1.Text(cabeza) = " " Then
            resultado += "0"
            Label1.Text = resultado
            MsgBox("Es par")

        End If

    End Sub
    Sub q1()
        If TextBox1.Text(cabeza) = "0" Then
            resultado += "0"
            Label1.Text = resultado
            cabeza += 1
            MsgBox("stap")
            q1()
        ElseIf TextBox1.Text(cabeza) = "1" Then
            resultado += "1"
            Label1.Text = resultado
            cabeza += 1
            MsgBox("stap")
            q0()
        ElseIf TextBox1.Text(cabeza) = " " Then
            resultado += "1"
            Label1.Text = resultado
            MsgBox("no es par")

        End If
    End Sub
End Class
