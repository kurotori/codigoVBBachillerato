Imports MySql.Data.MySqlClient

Public Class Form1
    Friend conexion As MySqlConnection

    Sub GenerarConexion()
        Dim servidor As String = txt_servidor.Text
        Dim usuario As String = txt_usuario.Text
        Dim contrasenia As String = txt_contrasenia.Text
        conexion = CrearConexion(servidor, usuario, contrasenia)
    End Sub

    Private Sub btn_probarBdD_Click(sender As Object, e As EventArgs) Handles btn_probarBdD.Click
        GenerarConexion()
        ProbarConexion(conexion)
    End Sub

    Function CheqTxtNulo(campo As TextBox) As Boolean
        If campo.Text Then
    End Function

    Private Sub btn_guardarEnBdD_Click(sender As Object, e As EventArgs) Handles btn_guardarEnBdD.Click
        Dim nombre As String = txt_nombre.Text
        Dim apellido As String = txt_apellido.Text
        Dim edad As Integer = txt_edad.Text
        GenerarConexion()
        GuardarDatos(conexion, nombre, apellido, edad)
        VerDatos(conexion, txt_datos)
    End Sub
End Class
