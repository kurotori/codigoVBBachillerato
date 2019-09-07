Module Otros
    Function ExtraerUsuarios(datos As DataTable) As DataTable
        Dim resultado As New DataTable

        If datos.Rows.Count > 0 Then
            resultado = datos.Clone()

            For Each fila As DataRow In datos.Rows
                resultado.ImportRow(fila)
            Next

            resultado.Columns.Remove("ci")
        End If

        Return resultado
    End Function

End Module
