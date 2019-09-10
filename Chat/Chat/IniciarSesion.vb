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
End Class