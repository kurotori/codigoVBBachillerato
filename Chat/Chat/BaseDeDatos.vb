Imports MySql.Data.MySqlClient

Module BaseDeDatos

    Dim archivoConfig As String = Application.StartupPath & "\configuracion.ini"
    Private servidor As String = ""
    Private usuario As String = ""
    Private contrasenia As String = ""

    Sub LeerDatosServidorDeIni(archivoConfig As String)
        servidor = LeerDeIni(archivoConfig, "BaseDeDatos", "servidor", "localhost")
        usuario = LeerDeIni(archivoConfig, "BaseDeDatos", "usuario", "root")
        contrasenia = LeerDeIni(archivoConfig, "BaseDeDatos", "contrasenia", "soloyoeh")
    End Sub

    Function CrearConexion(servidor, usuario, contrasenia) As MySqlConnection
        Dim conexion As New MySqlConnection

        conexion.ConnectionString = "server=" & servidor & ";" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        Return conexion
    End Function

    Function CrearConexion() As MySqlConnection
        LeerDatosServidorDeIni(archivoConfig)

        Dim conexion As New MySqlConnection

        conexion.ConnectionString = "server=" & servidor & ";" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        Return conexion
    End Function

    Sub ProbarConexion(servidor As String, usuario As String, contrasenia As String)
        Dim conexion As New MySqlConnection
        conexion = CrearConexion(servidor, usuario, contrasenia)

        Try
            conexion.Open()
            MessageBox.Show("Conexión Exitosa")
        Catch ex As Exception
            MessageBox.Show("No se ha podido conectar al servidor")
            MessageBox.Show("Error: " & ex.ToString)
        End Try
        conexion.Close()
    End Sub


    Function UsuarioExiste(ci As String) As Boolean
        Dim resultado As Boolean = False

        Dim conexion As MySqlConnection = CrearConexion()

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
        Dim conexion As MySqlConnection = CrearConexion()

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
        Dim conexion As MySqlConnection = CrearConexion()

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
        Dim conexion As MySqlConnection = CrearConexion()

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
        Dim conexion As MySqlConnection = CrearConexion()

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
                MsgBox("Hubo un problema para cambiar tu estado")
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

        Dim conexion As MySqlConnection = CrearConexion()

        Dim consulta As String = "SELECT ci, nombre, estado, " &
                                 " (SELECT " &
                                 "   COUNT(*) FROM chat.chatea_con " &
                                 "   WHERE chatea_con.usuario_ci_rec = @ci AND " &
                                 "   chatea_con.usuario_ci_emi = ci AND " &
                                 "   chatea_con.visto ='no') AS 'mensajes' " &
                                 "FROM chat.usuario " &
                                 "WHERE ci!= @ci " &
                                 "ORDER BY 4 DESC,estado, nombre ASC"

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
                                            lector.GetString(2), lector.GetString(3)}
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

        Dim conexion As MySqlConnection = CrearConexion()

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

    Function VerEstado(ci As String) As String
        Dim resultado As String = ""

        Dim conexion As MySqlConnection = CrearConexion()

        Dim consulta As String = "select estado from chat.usuario where ci=@ci"

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

    Function RecibirMensajesDeUsuario(ci_usuario_1 As String,
                                      ci_usuario_2 As String,
                                      nombre_usuario_2 As String) As String
        Dim resultado As String = ""

        Dim conexion As MySqlConnection = CrearConexion()

        Dim consulta As String = "select usuario_ci_emi,mensaje,enviado" &
                                 " from chat.chatea_con where" &
                                 " usuario_ci_emi=@ci_usuario_1 AND usuario_ci_rec=@ci_usuario_2" &
                                 " OR usuario_ci_rec=@ci_usuario_1 AND usuario_ci_emi=@ci_usuario_2" &
                                 " limit 100"
        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci_usuario_1", ci_usuario_1)
            comando.Parameters.AddWithValue("@ci_usuario_2", ci_usuario_2)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.HasRows() Then
                While lector.Read()
                    Dim emisor As String = lector.GetString(0)
                    Dim mensaje As String = vbTab & lector.GetString(1) & vbNewLine
                    Dim tiempo As String = vbTab & "--" & lector.GetDateTime(2)

                    If emisor.Equals(ci_usuario_1) Then
                        emisor = "Yo:" & vbNewLine
                    Else
                        emisor = nombre_usuario_2 & ":" & vbNewLine
                    End If

                    resultado = resultado & emisor & mensaje & tiempo & vbNewLine

                End While
            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()

        Return resultado
    End Function

    Function EnviarMensajeAUsuario(ci_usuario_1 As String,
                              ci_usuario_2 As String,
                              mensaje As String) As Boolean

        Dim resultado As Boolean = False
        Dim conexion As MySqlConnection = CrearConexion()

        Dim consulta As String = "insert into" &
                                 " chat.chatea_con(usuario_ci_emi,usuario_ci_rec,mensaje)" &
                                 " values(@ci_usuario_1,@ci_usuario_2,@mensaje)"
        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci_usuario_1", ci_usuario_1)
            comando.Parameters.AddWithValue("@ci_usuario_2", ci_usuario_2)
            comando.Parameters.AddWithValue("@mensaje", mensaje)
            Dim filas As Integer = comando.ExecuteNonQuery()

            If filas > 0 Then
                resultado = True
            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()

        Return resultado
    End Function

    Function MarcarMensajesDeUsuario(ci_usuario_1 As String,
                                    ci_usuario_2 As String) As Boolean

        Dim resultado As Boolean = False
        Dim conexion As MySqlConnection = CrearConexion()

        Dim consulta As String = "UPDATE chat.chatea_con " &
                                 "SET chat.chatea_con.visto='si' WHERE " &
                                 "usuario_ci_rec=@ci_usuario_1 AND " &
                                 "usuario_ci_emi=@ci_usuario_2"
        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@ci_usuario_1", ci_usuario_1)
            comando.Parameters.AddWithValue("@ci_usuario_2", ci_usuario_2)
            Dim filas As Integer = comando.ExecuteNonQuery()

            If filas > 0 Then
                resultado = True
            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try

        conexion.Close()

        Return resultado
    End Function

End Module
