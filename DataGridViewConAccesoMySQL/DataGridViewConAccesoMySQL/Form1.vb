Public Class Form1
    Public servidor As String
    Public usuario As String
    Public contrasenia As String
   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        servidor = TextBox1.Text
        usuario = TextBox3.Text
        contrasenia = TextBox4.Text

        ConectarBdD(servidor, usuario, contrasenia)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
