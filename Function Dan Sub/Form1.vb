Public Class Form1
    Private Sub b1()
        Label1.Text = "Hello"
    End Sub
    Private Sub b2()
        Dim text1 As String
        text1 = TextBox1.Text
        Label2.Text = Text1 & "LEE"
    End Sub
    Private Function f1()
        Return "DDT4A"
    End Function

    Private Function f2()
        Return "Virtual programming"
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b1()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b2()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = f1()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label4.Text = TextBox2.Text & f2()
    End Sub
End Class
