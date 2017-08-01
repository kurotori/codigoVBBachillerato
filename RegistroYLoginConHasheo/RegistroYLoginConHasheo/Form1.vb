Imports MySql.Data.MySqlClient

Public Class Form1

    Dim servidorBD As String = "localhost"
    Dim usuarioBD As String = "pruebas"
    Dim contraseñaBD As String = "pruebas"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nomUsuario As String = TextBox1.Text
        Dim contraseña As String = TextBox2.Text
        Dim confContraseña As String = TextBox3.Text

        Dim conexion As MySqlConnection = CrearConexion(servidorBD, usuarioBD, contraseñaBD)

        If chequearDatosNuevoUsuario(conexion, nomUsuario, contraseña, confContraseña) Then
            Dim sal As String = CrearSal()
            Dim hashContraseña = CodificarContraseña(contraseña, sal)

            If NuevoUsuario(conexion, nomUsuario, hashContraseña, sal) Then
                MsgBox("El usuario " & nomUsuario & " se creó exitosamente")
                Form2.Show()
                Me.Close()
            Else
                MsgBox("No se pudo crear un nuevo usuario")
            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form3.Show()
    End Sub
End Class
