Imports MySql.Data.MySqlClient

Public Class Form2
    Dim servidor As String
    Dim usuario As String
    Dim contrasenia As String
    Dim conexion As MySqlConnection
    Dim ventanaInicio As Form1

    Public Sub New(conexion As MySqlConnection, ventanaInicio As Form1)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.conexion = conexion
        Me.ventanaInicio = ventanaInicio
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = VerDatos(conexion)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ventanaInicio.Show()
        Me.Dispose()
    End Sub
End Class