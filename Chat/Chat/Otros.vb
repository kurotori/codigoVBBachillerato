Module Otros
    Function ExtraerUsuarios(datos As DataTable) As DataTable
        Dim resultado As New DataTable

        resultado = datos.Clone()

        For Each fila As DataRow In datos.Rows
            resultado.ImportRow(fila)
        Next

        resultado.Columns.Remove("ci")

        Return resultado
    End Function

End Module
