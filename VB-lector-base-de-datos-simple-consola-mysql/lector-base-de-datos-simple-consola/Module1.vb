Imports MySql.Data.MySqlClient
'La sentencia "Imports" permite incluir una librería determinada en el código
' Esto permite incluir funcionalidad extra que de otra manera tendríamos que
' programar desde cero.

Module Module1

    Friend conexion As MySqlConnection
    'La palabra clave "Friend" implica un determinado nivel de acceso
    ' VB utiliza los siguientes niveles de acceso para sus objetos
    ' Public - el objeto es accesible desde cualquier otro objeto
    ' Protected - el objeto es accesible solo en la misma clase o por objetos herederos de la clase
    ' 
    Dim servidor As String
    Dim usuario As String
    Dim contrasenia As String
    Dim base As String

    Sub Main()
        Console.Title = "Acceso a MySQL"

        Console.WriteLine("Por favor, escriba la IP del Servidor MySQL:")
        Console.WriteLine("-----------------------------------------------------")
        Console.Write("IP: ")
        servidor = Console.ReadLine
        Console.WriteLine("Por favor, escriba su usuario y contraseña:")
        Console.Write("Usuario: ")
        usuario = Console.ReadLine
        Console.Write("Contraseña: ")
        contrasenia = Console.ReadLine
        Console.Clear()
        ConectarABase(servidor, usuario, contrasenia)
        VerBases(servidor, usuario, contrasenia)
        Console.WriteLine("Escriba la Base de Datos en la que quiere entrar:")
        Console.Write("Base de Datos: ")
        base = Console.ReadLine
        Console.Clear()
        VerTablas(servidor, usuario, contrasenia, base)
        Console.ReadLine()
    End Sub

    Sub ConectarABase(servidor As String, usuario As String, contrasenia As String)
        conexion = New MySqlConnection()
        conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"
        Try
            conexion.Open()
            Console.WriteLine("Conexión Exitosa")
        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar al servidor.")
            Console.WriteLine("-----------------------------------------------------")
            Console.WriteLine("Error: " & ex.ToString)
        End Try

        conexion.Close()

    End Sub

    Sub VerBases(servidor As String, usuario As String, contrasenia As String)

        conexion = New MySqlConnection()
        conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        Try
            conexion.Open()
            Console.WriteLine("Mostrando Bases de Datos Disponibles en " & servidor & ":")
            Console.WriteLine("-----------------------------------------------------")

            Dim consulta As String = "SHOW DATABASES"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.HasRows Then
                While lector.Read()
                    Console.WriteLine(lector.GetString(0))
                End While
            End If
            Console.WriteLine("-----------------------------------------------------")

        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar al servidor.")
            Console.WriteLine("Error: " & ex.ToString)
        End Try

        conexion.Close()

    End Sub

    Sub VerTablas(servidor As String, usuario As String, contrasenia As String, base As String)

        conexion = New MySqlConnection()
        conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        Try
            conexion.Open()
            Console.WriteLine("Servidor: " & servidor)
            Console.WriteLine("Mostrando Tablas Disponibles en la Base de Datos" & base & ":")
            Console.WriteLine("-----------------------------------------------------")

            Dim consulta As String = "SHOW TABLES FROM " & base
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.HasRows Then
                While lector.Read()
                    Console.WriteLine(lector.GetString(0))
                End While
            End If

        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar al servidor.")
            Console.WriteLine("-----------------------------------------------------")
            Console.WriteLine("Error: " & ex.ToString)
        End Try

        conexion.Close()

    End Sub
End Module

