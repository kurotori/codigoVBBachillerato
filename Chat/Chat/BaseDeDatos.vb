Imports MySql.Data.MySqlClient

Module BaseDeDatos

    Private servidor As String = "localhost"
    Private usuario As String = "root"
    Private contrasenia As String = "soloyoeh"


    Function CrearConexion(servidor As String,
                           usuario As String,
                           contrasenia As String) As MySqlConnection

        Dim conexion As New MySqlConnection

        conexion.ConnectionString = "server=" & servidor & ";" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        Return conexion
    End Function

    Function UsuarioExiste(ci As String) As Boolean
        Dim resultado As Boolean = False

        Dim conexion As MySqlConnection = CrearConexion(servidor, usuario, contrasenia)

        Dim consulta As String = "Select count(*) from chat.usuario where ci = @ci"

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci", ci)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.HasRows() Then
                lector.Read()
                If lector.GetInt16(0) = 1 Then
                    resultado = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha surgido un error")
            MsgBox("Error: " & ex.ToString)
        End Try
        conexion.Close()

        Return resultado
    End Function

    Function CrearUsuario(ci As String, nombre As String) As Boolean
        Dim final As Boolean = False
        Dim conexion As MySqlConnection = CrearConexion(servidor, usuario, contrasenia)

        Dim consulta As String = "Insert into chat.usuario(ci,nombre) values (@ci,@nombre)"

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci", ci)
            comando.Parameters.AddWithValue("@nombre", nombre)

            Dim resultado As Integer = comando.ExecuteNonQuery()
            If resultado > 0 Then
                MsgBox("Gracias por registrarte, " & nombre)
                final = True
            Else
                MsgBox("Hubo un problema para generar tu usuario de chat")
                MsgBox("Por favor intenta nuevamente más tarde")
            End If

        Catch ex As Exception
            MsgBox("Ha surgido un error")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()
        Return final
    End Function

    Function IngresarUsuario(ci As String, nombre As String) As Boolean
        Dim final As Boolean = False
        Dim conexion As MySqlConnection = CrearConexion(servidor, usuario, contrasenia)

        Dim consulta As String = "update chat.usuario set nombre=@nombre where ci=@ci"

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci", ci)
            comando.Parameters.AddWithValue("@nombre", nombre)

            Dim resultado As Integer = comando.ExecuteNonQuery()
            If resultado > 0 Then
                MsgBox("Hola de nuevo, " & nombre)
                final = True
            Else
                MsgBox("Hubo un problema para ingresar al chat")
                MsgBox("Por favor intenta nuevamente más tarde")
            End If

        Catch ex As Exception
            MsgBox("Ha surgido un error")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()
        Return final
    End Function

    Function IniciarSesionUsuario(ci As String, nombre As String) As Boolean
        Dim resultado As Boolean = False

        If UsuarioExiste(ci) Then
            resultado = IngresarUsuario(ci, nombre)
        Else
            resultado = CrearUsuario(ci, nombre)
        End If

        Return resultado
    End Function

    Sub CambiarNombre(ci As String, nombre As String)
        Dim conexion As MySqlConnection = CrearConexion(servidor, usuario, contrasenia)

        Dim consulta As String = "update chat.usuario set nombre=@nombre where ci=@ci"

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci", ci)
            comando.Parameters.AddWithValue("@nombre", nombre)

            Dim resultado As Integer = comando.ExecuteNonQuery()
            If resultado > 0 Then
                MsgBox("Ahora tu nombre en el chat es: " & nombre)
            Else
                MsgBox("Hubo un problema para cambiar tu nombre")
                MsgBox("Por favor intenta nuevamente más tarde")
            End If

        Catch ex As Exception
            MsgBox("Ha surgido un error")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()
    End Sub

    Sub CambiarEstado(ci As String, estado As String)
        Dim conexion As MySqlConnection = CrearConexion(servidor, usuario, contrasenia)

        Dim consulta As String = "update chat.usuario set estado=@estado where ci=@ci"

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci", ci)
            comando.Parameters.AddWithValue("@estado", estado)

            Dim resultado As Integer = comando.ExecuteNonQuery()
            If resultado > 0 Then
                MsgBox("Ahora tu estado en el chat es: " & estado.ToUpper)
            Else
                MsgBox("Hubo un problema para cambiar tu nombre")
                MsgBox("Por favor intenta nuevamente más tarde")
            End If

        Catch ex As Exception
            MsgBox("Ha surgido un error")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()
    End Sub

    Function VerUsuariosConectados(ci_usuario As String) As DataTable
        Dim resultado As New DataTable

        Dim conexion As MySqlConnection = CrearConexion(servidor, usuario, contrasenia)

        Dim consulta As String = "select ci, nombre, estado from chat.usuario " &
                                 "where ci != @ci " &
                                 "order by estado, nombre"
        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci", ci_usuario)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.HasRows() Then
                Dim numCol As Integer = lector.FieldCount

                For fila As Integer = 0 To numCol - 1
                    Dim columna As New DataColumn
                    columna.ColumnName = lector.GetName(fila)
                    resultado.Columns.Add(columna)
                Next

                While lector.Read()
                    Dim fila As String() = {lector.GetString(0), lector.GetString(1),
                                            lector.GetString(2)}
                    resultado.Rows.Add(fila)
                End While

            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()

        Return resultado
    End Function

    Function VerNombre(ci As String) As String
        Dim resultado As String = ""

        Dim conexion As MySqlConnection = CrearConexion(servidor, usuario, contrasenia)

        Dim consulta As String = "select nombre from chat.usuario where ci=@ci"

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci", ci)
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            If lector.HasRows() Then
                lector.Read()
                resultado = lector.GetString(0)
            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()

        Return resultado
    End Function

End Module
