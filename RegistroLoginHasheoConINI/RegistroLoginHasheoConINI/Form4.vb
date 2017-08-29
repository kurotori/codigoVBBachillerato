Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form3.servidor
        TextBox2.Text = Form3.usuario
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.servidor = TextBox1.Text
        GuardarEnIni("BaseDeDatos", "servidor", Form3.servidor)

        Form3.usuario = TextBox2.Text
        GuardarEnIni("BaseDeDatos", "usuario", Form3.usuario)

        Form3.contraseña = TextBox3.Text
        Me.Close()
    End Sub


End Class