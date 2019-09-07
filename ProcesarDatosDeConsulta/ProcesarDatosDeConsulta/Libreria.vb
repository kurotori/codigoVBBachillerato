Public Class Libreria
    Dim datosAutores As New DataTable


    Private Sub Libreria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datosAutores = VerDatosAutores()

        For Each fila As DataRow In datosAutores.Rows
            combo_nombre_autor.Items.Add(fila.Item(1))
        Next

    End Sub

    Private Sub combo_nombre_autor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_nombre_autor.SelectedIndexChanged
        Dim seleccionado As Integer = combo_nombre_autor.SelectedIndex
        lbl_doc.Text = datosAutores.Rows.Item(seleccionado).Item(0)
        lbl_nacionalidad.Text = datosAutores.Rows.Item(seleccionado).Item(2)
        lbl_fecha_nac.Text = datosAutores.Rows.Item(seleccionado).Item(3)
        lbl_fecha_dec.Text = datosAutores.Rows.Item(seleccionado).Item(4)
    End Sub
End Class
