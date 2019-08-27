Imports MySql.Data.MySqlClient

Module BaseDeDatos

    Function CrearConexion(servidor As String, usuario As String, contrasenia As String) _
    As MySqlConnection
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=" & servidor & ";" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"
        Return conexion
    End Function

    Sub ProbarConexion(conexion As MySqlConnection)
        Try
            conexion.Open()
            MsgBox("Conectado al servidor")
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try
        conexion.Close()
    End Sub

    Sub GuardarDatos(conexion As MySqlConnection,
                     nombre As String,
                     apellido As String,
                     edad As Integer)

        Dim consulta As String =
            "INSERT INTO pruebas.usuario(nombre,apellido,edad) values (@nombre,@apellido,@edad)"
        Dim resultado As Integer = 0

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@apellido", apellido)
            comando.Parameters.AddWithValue("@edad", edad)
            resultado = comando.ExecuteNonQuery()
            If resultado > 0 Then
                MsgBox(resultado & " registro(s) añadidos")
            Else
                MsgBox("No se pudo añadir registros")
            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try
    End Sub

    Sub VerDatos(conexion As MySqlConnection, areaTexto As TextBox)
        Dim consulta As String =
            "SELECT concat_ws(' ',nombre,apellido) as 'Usuario'," &
            "concat_ws(' ',edad,'años') as 'Edad' from pruebas.usuario"

        Try
            conexion.Open()

        Catch ex As Exception
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                areaTexto.Text =
                    lector.GetName(0) & vbTab & vbTab & lector.GetName(1) & vbNewLine & vbNewLine
                While lector.Read()
                    areaTexto.Text = areaTexto.Text &
                        lector.GetString(0) & vbTab & lector.GetString(1) & vbNewLine
                End While
            End If



        End Try
    End Sub

    Sub ProbarConexion_(conexion As MySqlConnection)
        Dim consulta As String = "SHOW DATABASES"

        Try
            conexion.Open()
            MsgBox("Conectado al servidor")
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                While lector.Read()
                    'ComboBox.Items.Add(lector.GetString(0))
                End While

            Else
                MsgBox("ATENCIÓN:No se obtuvo ningún dato del servidor.")
            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try
        conexion.Close()
    End Sub

    Sub VerTablas(conexion As MySqlConnection, base As String, comboBox As ComboBox)
        Dim consulta As String = "SHOW TABLES FROM " + base
        comboBox.Items.Clear()

        Try
            conexion.Open()
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                While lector.Read()
                    comboBox.Items.Add(lector.GetString(0))
                End While

            Else
                MsgBox("ATENCIÓN:No se obtuvo ningún dato del servidor.")
            End If
        Catch ex As Exception
            MsgBox("No se ha podido conectar al servidor.")
            MsgBox("Error: " & ex.ToString)
        End Try
        conexion.Close()
        comboBox.SelectedIndex = 0
    End Sub

End Module

