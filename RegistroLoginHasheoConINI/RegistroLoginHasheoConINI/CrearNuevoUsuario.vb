Imports MySql.Data.MySqlClient

Public Class CrearNuevoUsuario

    Dim servidorBD As String = ""
    Dim usuarioBD As String = ""
    Dim contraseñaBD As String = ""


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
                Login.Show()
                Me.Close()
            Else
                MsgBox("No se pudo crear un nuevo usuario")
            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        VentanaInicio.Show()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        VentanaInicio.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        servidorBD = VentanaInicio.servidor
        usuarioBD = VentanaInicio.usuario
        contraseñaBD = VentanaInicio.contraseña
    End Sub
End Class
