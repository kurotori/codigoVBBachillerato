Imports MySql.Data.MySqlClient

Public Class Form1

    Dim servidorBD As String = "192.168.2.250"
    Dim usuarioBD As String = "alumno"
    Dim contraseñaBD As String = "infoemt"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nomUsuario As String = TextBox1.Text
        Dim contraseña As String = TextBox2.Text
        Dim confContraseña As String = TextBox3.Text

        If chequearDatosNuevoUsuario(nomUsuario, contraseña, confContraseña) Then
            Dim sal As String = CrearSal()
            Dim hashContraseña = CodificarContraseña(contraseña, sal)

            Dim conexion As MySqlConnection = CrearConexion(servidorBD, usuarioBD, contraseñaBD)

            If NuevoUsuario(conexion, nomUsuario, hashContraseña, sal) Then
                MsgBox("El usuario " & nomUsuario & " se creó exitosamente")
            Else
                MsgBox("No se pudo crear un nuevo usuario")
            End If
        End If


    End Sub
End Class
