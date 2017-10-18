Imports MySql.Data.MySqlClient

Public Class Login

    Dim servidorBD As String = ""
    Dim usuarioBD As String = ""
    Dim contraseñaBD As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Proceso de logueo de un usuario
        ' 1 - Obtenemos los datos ingresados por el usuario en la ventana
        Dim usuario As String = TextBox1.Text
        Dim contraseña As String = TextBox2.Text
        ' 2 - Creamos una conexión
        Dim conexion As MySqlConnection = CrearConexion(servidorBD, usuarioBD, contraseñaBD)
        ' 3 - Comenzamos el proceso de logueo
        If LoguearUsuario(conexion, usuario, contraseña) Then
            'En esta zona deberían estar las acciones relacionadas con el inicio de sesión
            ' como ser un acceso al registro de actividades para la auditoría
            MsgBox("Inicio de Sesión Exitoso")
            ' MsgBox(CrearClaveSesion(conexion, usuario))

        Else
            MsgBox("No se pudo iniciar sesión")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        VentanaInicio.Show()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        VentanaInicio.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        servidorBD = VentanaInicio.servidor
        usuarioBD = VentanaInicio.usuario
        contraseñaBD = VentanaInicio.contraseña
    End Sub
End Class