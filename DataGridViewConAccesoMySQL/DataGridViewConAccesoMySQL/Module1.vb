Imports MySql.Data.MySqlClient

Module Module1

    'Funciones: Las funciones son métodos que, tras ejecutarse, devuelven un objeto o datos tras ejecutarse
    'En general la sintaxis es:
    'Function NombreDeFuncion(dato1 As Tipo, dato2 As Tipo, dato3 As Tipo,...) As TipoDelResultado --> El tipo del objeto o los 
    '                                                                                                   datos devueltos por la 
    '                                                                                                   función
    '   Dim resultado As TipoDelResultado --> Este será el objeto que se devolverá al finalizar la función
    '                                           TIENE QUE ser del MISMO TIPO que el especificado al comienzo
    '   ...
    '   ... --> Pasos del algoritmo de la función.
    '   ...
    '   Return resultado --> La orden Return provoca que el objeto indicado por
    '                            ella debe devolverse tras ejecutar la función
    'End Function



    'CrearConexion() es una función que permite preparar el objeto conexion con las credenciales del
    '   servidor de BdD. Para ejecutarse se le debe proveer las credenciales mediante los parámetros
    '   'servidor', 'usuario' y 'contrasenia'

    Function CrearConexion(servidor As String,
                           usuario As String,
                           contrasenia As String) As MySqlConnection
        'Creamos un objeto de tipo MySqlConnection llamado "conexion", que será el que obtendremos al final
        Dim conexion As New MySqlConnection
        '    --> La orden 'New' indica que el objeto debe inicializarse como un objeto nuevo 

        '   Modificaremos el atributo 'ConnectionString' de nuestro objeto conexion el cual contendrá las 
        '   credenciales necesarias para establecer la conexión al servidor. Para ello tomaremos los datos
        '   provistos al inicio de la función.
        conexion.ConnectionString = "server=" & servidor & ";" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"
        'Finalmente 
        Return conexion
    End Function

    Sub ChequearConexion(servidor As String, usuario As String, contrasenia As String)
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

    Function VerBasesDeDatos(conexion As MySqlConnection) As DataTable
        Dim tablaDatos As New DataTable

        Dim consulta As String = "SHOW DATABASES"
        Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)

        Try
            conexion.Open()
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then
                Dim nombresColumnas As String() = {lector.GetName(0)}

                For item = 1 To nombresColumnas.Length
                    Dim columna As New DataColumn
                    columna.ColumnName = nombresColumnas(item - 1)
                    tablaDatos.Columns.Add(columna)
                Next

                While lector.Read()
                    Dim datos As String() = {lector.GetString(0)}
                    tablaDatos.Rows.Add(datos)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("No se ha podido conectar al servidor")
            MessageBox.Show("Error:" & ex.ToString)
        End Try
        conexion.Close()
        Return tablaDatos
    End Function

    Function VerDatos(conexion As MySqlConnection) As DataTable
        Dim tablaDatos As New DataTable

        Dim consulta As String = "SELECT * FROM mysql.user"
        Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)

        Try
            conexion.Open()
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            If lector.HasRows Then

                Dim nombresColumnas(lector.FieldCount()) As String

                For item As Integer = 0 To item < lector.FieldCount()
                    nombresColumnas(item) = lector.GetString(item)
                Next

                For Each nombre As String In nombresColumnas
                    Dim columna As New DataColumn
                    columna.ColumnName = nombre
                    tablaDatos.Columns.Add(columna)
                Next

                While lector.Read()
                    Dim datos As String() = {lector.GetString(0), lector.GetString(1)}
                    tablaDatos.Rows.Add(datos)
                End While
            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("No se ha podido conectar al servidor")
            MessageBox.Show("Error:" & ex.ToString)
        End Try
        Return tablaDatos
    End Function

End Module
