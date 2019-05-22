'La sentencia "Imports" permite incluir una librería determinada en el código.
' Esto permite incluir funcionalidad extra que de otra manera tendríamos que
' programar desde cero.
' Para poder realizar la importación, se debe haber creado una referencia a la
' librería previamente, de lo contrario no funcionará.

Imports MySql.Data.MySqlClient

Module BaseDeDatos

    Friend conexion As New MySqlConnection
    'La variable "conexion" es un objeto que se encargará de las tareas de
    ' interacción con la BdD úsando la funcionalidad del conector ODBC que
    ' agregamos al incluir la librería.

    'La palabra clave "Friend" es un modificador de acceso implica que el objeto 
    ' solo se puede acceder desde código dentro de este proyecto.
    ' Para ver información sobre modificadores de acceso, visitar https://goo.gl/W0mP56


    ''' <summary>
    ''' Subrutina para establecer la conexión al servidor de bases de datos
    ''' </summary>
    ''' <param name="servidor">La URL o el IP del servidor</param>
    ''' <param name="usuario">El nombre de usuario para conectarse a la BdD</param>
    ''' <param name="contrasenia">La contrasenia para conectarse a la BdD</param>
    Function ConectarAServidor(servidor As String, usuario As String, contrasenia As String) As Boolean
        Dim resultado As Boolean = False

        'Inicializamos el objeto "conexion" y le asignamos los datos de acceso al
        ' servidor de MySQL

        conexion = New MySqlConnection()
        Try
            conexion.ConnectionString = "server='" & servidor & "';" &
                                        "user=" & usuario & ";" &
                                        "password=" & contrasenia & ";"

            'El atributo "ConnectionString" del objeto de conexión
            ' permite agregarle los datos de autenticación necesarios

            'Ejecución de la conexión al servidor de MySQL

            'La estructura "Try/Catch" es utilizada en casos en que necesitamos llevar
            ' a cabo una tarea que puede fallar por causas externas al código, como ser
            ' acceso a servidores remotos, uso de recursos de red, lectura/escritura de
            ' archivos, etc.
            ' La primer parte (el "Try") ejecuta el proceso, y la segunda (el "Catch")
            ' permite obtener detalles de un error que impida la ejecución del "Try"

            'Abrimos la conexión al servidor

            conexion.Open()

            'La función "Open" establece la conexión con el servidor de MySQL utilizando
            ' los parametros proporcionados más arriba en "ConnectionString"

            'Mostramos un mensaje en pantalla para confirmar una conexión exitosa.

            Console.WriteLine("Conexión Exitosa")
            resultado = True

            'Manejo de errores de conexión

        Catch ex As Exception

            'El objeto "ex" que se menciona en la línea es donde se almacenarán los datos
            ' del error para poder procesarlos.

            'Mostramos un mensaje de error en pantalla
            MsgBox("ERROR: No se ha podido conectar al servidor.")
            Console.WriteLine("No se ha podido conectar al servidor.")
            Console.WriteLine("-----------------------------------------------------")

            'Mostramos el detalle del error en pantalla
            Console.WriteLine("Error: " & ex.Message)
            'Para mostrar el detalle del error debemos pasar el contenido del objeto "ex"
            ' a String, por lo que usamos la función "ToString". El objeto "ex" posée más
            ' funciones importantes para el manejo de mensajes de error.
        End Try

        'Cerramos la conexión
        conexion.Close()
        'Es importante que toda conexión que abramos al servidor se cierre inmediatamente
        ' terminado el proceso para evitar desborde del uso de recursos y posibles problemas
        ' de seguridad.
        Return resultado
    End Function

    Function VerBasesDeServidor(servidor As String,
                                usuario As String,
                                contrasenia As String
                                ) As String()
        Dim resultado As String()
        Dim consulta As String = "SHOW DATABASES"

        conexion = New MySqlConnection()
        Try
            conexion.ConnectionString = "server='" & servidor & "';" &
                                        "user=" & usuario & ";" &
                                        "password=" & contrasenia & ";"
            conexion.Open()

            'Creamos un objeto "comando", que se encargará de realizar la consulta al
            ' servidor, y le asignamos la variable con la consulta y el objeto "conexion"

            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)

            'Creamos un objeto "lector", que se encargará de "leer" y almacenar los datos
            ' que obtengamos del servidor

            Dim lector As MySqlDataReader = comando.ExecuteReader()

            'Chequeamos que haya datos en el "lector"
            If lector.HasRows Then
                While lector.Read()
                    resultado(resultado.Length) = lector.GetString(0)
                    Console.WriteLine(lector.GetString(0))
                End While
            End If

        Catch ex As Exception

        End Try

        Return resultado
    End Function


End Module
