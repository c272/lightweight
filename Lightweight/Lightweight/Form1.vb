Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "") Then
            WebBrowser1.Navigate(New Uri("http://" + TextBox1.Text))
        End If
    End Sub
End Class
