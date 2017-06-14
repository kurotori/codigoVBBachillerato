Module Module1

    Sub agregarDatoLista(dato As String, listaD As ComboBox)
        listaD.Items.Add(dato)
    End Sub

    Function obtenerDatoLista(ListaD As ComboBox) As String
        Dim resultado As String = ""

        resultado = ListaD.SelectedItem

        Return resultado
    End Function

    Sub agregarDatoTabla(dato As String, columna As Integer, tabla As DataGridView)
        Dim fila As Integer = (tabla.RowCount - 1)
        tabla.CurrentCell = tabla(columna, fila)
        tabla.CurrentCell.Value = dato

    End Sub




End Module
