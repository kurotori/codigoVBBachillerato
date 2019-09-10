Public Class IniciarSesion

    Dim archivoConfig As String = Application.StartupPath & "\configuracion.ini"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim ci As String = txtbx_ci.Text
        Dim nombre As String = txtbx_usuario.Text

        If ci.Length < 8 Then
            MsgBox("Por favor ingrese una CI válida")
        Else
            If nombre.Length < 1 Then
                MsgBox("Por favor ingrese un nombre de usuario válido")
            Else
                If IniciarSesionUsuario(ci, nombre) Then
                    Dim lista As New ListaConectados(nombre, ci, "activo", Me)
                    lista.Show()
                    Me.Hide()
                End If
            End If
        End If

    End Sub

    Private Sub IniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeerDatosServidorDeIni(archivoConfig)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_configuracion.Click
        Dim ventana_config As New Configuracion
        ventana_config.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("ChatBasico v 1.0" & vbNewLine _
            & "por Sebastián de los Ángeles" & vbNewLine _
            & "Íconos tomados de https://www.flaticon.com/authors/freepik")
    End Sub
End Class