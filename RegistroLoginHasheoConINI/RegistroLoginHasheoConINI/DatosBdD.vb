Public Class DatosBdD

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = VentanaInicio.servidor
        TextBox2.Text = VentanaInicio.usuario
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VentanaInicio.servidor = TextBox1.Text
        GuardarEnIni("BaseDeDatos", "servidor", VentanaInicio.servidor)

        VentanaInicio.usuario = TextBox2.Text
        GuardarEnIni("BaseDeDatos", "usuario", VentanaInicio.usuario)

        VentanaInicio.contraseña = TextBox3.Text
        Me.Close()
    End Sub


End Class