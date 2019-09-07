Public Class Form1
    Dim datosLibros As DataTable = VerDatosLibros()
    Dim ISBN As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each fila As DataRow In datosLibros.Rows
            combo_libros.Items.Add(fila.Item(0))
        Next
    End Sub

    Private Sub combo_libros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_libros.SelectedIndexChanged
        Dim seleccion As Integer = combo_libros.SelectedIndex
        lbl_autor.Text = datosLibros.Rows.Item(seleccion).Item(1)
        lbl_isbn.Text = datosLibros.Rows.Item(seleccion).Item(2)

        ISBN = datosLibros.Rows.Item(seleccion).Item(2)

        lbl_genero.Text = datosLibros.Rows.Item(seleccion).Item(3)
        lbl_fecha_pub.Text = datosLibros.Rows.Item(seleccion).Item(4)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BorrarLibro(ISBN)

        combo_libros.Items.Clear()
        combo_libros.SelectedText = ""
        datosLibros = VerDatosLibros()
        For Each fila As DataRow In datosLibros.Rows
            combo_libros.Items.Add(fila.Item(0))
        Next

    End Sub
End Class
