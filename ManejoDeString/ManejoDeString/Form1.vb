Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjemploDeLista()

        Dim datos() As String
        Dim texto As String = "Esto es, un texto, que se quiere, separar por partes"

        datos = SepararTexto(texto, ",")
        TextBox1.Text = datos(0)
        TextBox2.Text = datos(1)
        TextBox3.Text = datos(2)
        TextBox4.Text = datos(3)
    End Sub
End Class
