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

