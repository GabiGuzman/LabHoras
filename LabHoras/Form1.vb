Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        a = TextBox1.Text

        If (a <= 12) Then
            TextBox2.Text = "AM"
        End If
        If (a >= 13) Then
            TextBox2.Text = "PM"
        End If
    End Sub
End Class
