Imports MySql.Data.MySqlClient

Public Class Form1
    Friend conexion As MySqlConnection

    Private Sub btn_probarBdD_Click(sender As Object, e As EventArgs) Handles btn_probarBdD.Click
        Dim servidor As String = txt_servidor.Text
        Dim usuario As String = txt_usuario.Text
        Dim contrasenia As String = txt_contrasenia.Text
        conexion = CrearConexion(servidor, usuario, contrasenia)
        ProbarConexion(conexion)
    End Sub
End Class
