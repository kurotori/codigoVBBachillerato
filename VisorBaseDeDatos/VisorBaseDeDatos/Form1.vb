Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conexion As New MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion = CrearConexion(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        VerBases(conexion, ComboBox1)
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim base As String = ComboBox1.SelectedItem
        conexion = CrearConexion(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        VerTablas(conexion, base, ComboBox2)
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Dim base As String = ComboBox1.SelectedItem
        Dim tabla As String = ComboBox2.SelectedItem
        conexion = CrearConexion(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        VerCampos(conexion, base, tabla, ListBox1)
    End Sub
End Class
