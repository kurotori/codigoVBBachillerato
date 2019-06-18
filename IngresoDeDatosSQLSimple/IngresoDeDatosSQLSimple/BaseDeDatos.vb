Imports MySql.Data.MySqlClient

Module BaseDeDatos

    Function CrearConexion(servidor As String,
                           usuario As String,
                           contrasenia As String) As MySqlConnection
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=" & servidor & ";" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"
        Return conexion
    End Function

    Sub GuardarDatos(edad As Integer,
                     localidad As String,
                     conexion As MySqlConnection)
        Dim consulta As String = "insert into pruebas.persona(edad,localidad)" &
                                 "values (" & edad & ",'" & localidad & "')"
        Try
            conexion.Open()
            Dim comando As MySqlCommand =
                New MySqlCommand(consulta, conexion)
            Dim resultado As Integer = comando.ExecuteNonQuery()
            If resultado < 0 Then
                MsgBox("Error al ejecutar la consulta")
            Else
                MsgBox("Datos guardados. Se afectaron " & resultado & " filas")
            End If

        Catch ex As Exception
            MsgBox("Error de conexión a la BdD")
            MsgBox("Detalle del Error: " + ex.Message())
        End Try
        conexion.Close()
    End Sub


End Module
