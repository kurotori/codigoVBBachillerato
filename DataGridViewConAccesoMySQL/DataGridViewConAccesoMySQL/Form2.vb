Public Class Form2
    Dim servidor As String
    Dim usuario As String
    Dim contrasenia As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        servidor = Form1.servidor
        usuario = Form1.usuario
        contrasenia = Form1.contrasenia

        DataGridView1.DataSource = VerDatos(servidor, usuario, contrasenia)
    End Sub
End Class