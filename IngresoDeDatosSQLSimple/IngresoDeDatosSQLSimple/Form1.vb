Imports MySql.Data.MySqlClient



Public Class Form1
    Dim conexion As MySqlConnection = CrearConexion("192.168.4.200", "alumno", "infoemt")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim edad As Integer = TextBox1.Text
        Dim localidad As String = TextBox2.Text
        GuardarDatos(edad, localidad, conexion)
    End Sub
End Class
