Public Class Configuracion

    Dim archivoConfig As String = Application.StartupPath & "\configuracion.ini"
    Dim servidor As String = ""
    Dim usuario As String = ""
    Dim contrasenia As String = ""

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        servidor = LeerDeIni(archivoConfig, "BaseDeDatos", "servidor", "localhost")
        usuario = LeerDeIni(archivoConfig, "BaseDeDatos", "usuario", "root")
        contrasenia = LeerDeIni(archivoConfig, "BaseDeDatos", "contrasenia", "soloyoeh")

        txt_servidor.Text = servidor
        txt_usuario.Text = usuario
        txt_contrasenia.Text = contrasenia
    End Sub

    Private Sub btn_guardar_config_Click(sender As Object, e As EventArgs) Handles btn_guardar_config.Click
        servidor = txt_servidor.Text
        usuario = txt_usuario.Text
        contrasenia = txt_contrasenia.Text

        GuardarEnIni(archivoConfig, "BaseDeDatos", "servidor", servidor)
        GuardarEnIni(archivoConfig, "BaseDeDatos", "usuario", usuario)
        GuardarEnIni(archivoConfig, "BaseDeDatos", "contrasenia", contrasenia)
        MsgBox("Se guardaron los datos de configuración")
    End Sub

    Private Sub btn_probar_config_Click(sender As Object, e As EventArgs) Handles btn_probar_config.Click
        servidor = txt_servidor.Text
        usuario = txt_usuario.Text
        contrasenia = txt_contrasenia.Text

        ProbarConexion(servidor, usuario, contrasenia)
    End Sub
End Class