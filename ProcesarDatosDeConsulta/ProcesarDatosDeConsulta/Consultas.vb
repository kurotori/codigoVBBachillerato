Imports MySql.Data.MySqlClient

Module Consultas
    Dim servidor As String = "localhost"
    Dim usuario As String = "alumno"
    Dim contrasenia As String = "infoutu"


    

    Function VerDatosAutores() As DataTable
        Dim resultado As New DataTable

        Dim conexion As New MySqlConnection
        conexion = CrearConexion(servidor, usuario, contrasenia)

        Dim consulta As String =
        "select " &
        "doc as 'Doc', concat_ws(',',apellido,nombre) as 'Nombre'," &
        "nacionalidad as 'Nacionalidad', fecha_nac as 'Nacimiento'," &
        "fecha_dec as 'Fallecimiento' " &
        "from libreria.autor order by apellido"

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.HasRows Then
                Dim nombresColumnas() As String =
                {lector.GetName(0), lector.GetName(1), lector.GetName(2),
                lector.GetName(3), lector.GetName(4)}

                For item As Integer = 0 To 4
                    Dim columna As New DataColumn
                    'columna.ColumnName = nombresColumnas(item - 1)
                    resultado.Columns.Add(columna)
                Next

                While lector.Read()
                    Dim fecha_dec As String = ""
                    If lector.IsDBNull(4) Then
                        fecha_dec = ""
                    Else
                        fecha_dec = lector.GetString(4)
                    End If
                    Dim datos As String() = {lector.GetString(0), lector.GetString(1),
                        lector.GetString(2), lector.GetString(3), fecha_dec}


                    resultado.Rows.Add(datos)
                End While
            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()
        Return resultado
    End Function

End Module
