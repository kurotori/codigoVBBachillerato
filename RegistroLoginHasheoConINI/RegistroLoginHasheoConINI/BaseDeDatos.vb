Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Module BaseDeDatos

    Function CrearConexion(servidor As String, usuario As String, contrasenia As String) As MySqlConnection
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=" & servidor & ";" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"
        Return conexion
    End Function

End Module
