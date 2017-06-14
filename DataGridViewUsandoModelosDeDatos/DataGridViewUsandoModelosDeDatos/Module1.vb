Module Module1


    Sub llenarTabla(tabla As DataGridView, datos As String(), nombresColumnas As String())
        'Creamos dos objetos DataTable, estos serán nuestros modelos
        ' El primero por si hay que crear un modelo nuevo
        ' El segundo por si el modelo ya existe.
        Dim tablaDatos As DataTable
        Dim tablaOrigen As DataTable

        'Obtenemos el modelo actual usado por el DataGridView (DGV)
        tablaOrigen = tabla.DataSource

        'Chequeamos si ese modelo esta vacío o tiene datos
        ' el método IsNothing() permite confirmar si un objeto es nulo
        If IsNothing(tablaOrigen) Then
            'Si el DGV no tiene datos, entonces inicializamos el modelo nuevo
            tablaDatos = New DataTable
            'Y le añadimos columnas de acuerdo a la cantidad que necesitamos
            For item = 1 To nombresColumnas.Length
                'Creamos la columna
                Dim columna As New DataColumn
                'Les añadimos nombres
                columna.ColumnName = nombresColumnas(item - 1)
                'Y la añadimos al modelo
                tablaDatos.Columns.Add(columna)
            Next
        Else
            'Si el DGV ya tiene datos, pasamos los datos existentes
            ' en el modelo viejo al modelo nuevo
            tablaDatos = tablaOrigen
        End If

        'Ahora que el modelo esta pronto, podemos agregar los datos de a fila
        tablaDatos.Rows.Add(datos)
        'Finalmente agregamos el modelo al DGV
        tabla.DataSource = tablaDatos
    End Sub

End Module
