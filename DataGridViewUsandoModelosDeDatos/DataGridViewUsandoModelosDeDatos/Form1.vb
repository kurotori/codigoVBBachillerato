Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creamos dos listas de tipo String, una para los datos, otra para los nombres
        ' de las columnas
        Dim datos As String()
        Dim nombresColumnas As String()
        'Agregamos datos a las listas en el orden que nos parezca mejor
        datos = {TextBox1.Text, TextBox2.Text, TextBox3.Text}
        nombresColumnas = {"Nombre", "Apellido", "CI"}

        'Y ejecutamos el método para agregar esos datos al DGV
        llenarTabla(DataGridView1, datos, nombresColumnas)

        'Para terminar, reseteamos el texto de los TextBox
        TextBox1.Text = vbNullString
        TextBox2.Text = vbNullString
        TextBox3.Text = vbNullString
    End Sub

End Class
