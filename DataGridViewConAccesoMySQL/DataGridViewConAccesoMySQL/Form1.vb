Imports MySql.Data.MySqlClient

Public Class Form1
    Dim servidor As String
    Dim usuario As String
    Dim contrasenia As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        servidor = TextBox1.Text
        usuario = TextBox3.Text
        contrasenia = TextBox4.Text

        ChequearConexion(servidor, usuario, contrasenia)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        servidor = TextBox1.Text
        usuario = TextBox3.Text
        contrasenia = TextBox4.Text

        Dim conexion As MySqlConnection = CrearConexion(servidor, usuario, contrasenia)

        Dim v2 As New Form2(conexion, Me)
        v2.Show()
        Me.Hide()
    End Sub
End Class
