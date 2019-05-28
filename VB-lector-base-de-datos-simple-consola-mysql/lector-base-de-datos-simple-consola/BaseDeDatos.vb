Imports MySql.Data.MySqlClient
'La sentencia "Imports" permite incluir una librería determinada en el código.
' Esto permite incluir funcionalidad extra que de otra manera tendríamos que
' programar desde cero.
' Para poder realizar la importación, se debe haber creado una referencia a la
' librería previamente, de lo contrario no funcionará.

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

    ''' <summary>
    ''' Subrutina para obtener el listado de BdD's en el servidor MySQL
    ''' </summary>
    ''' <param name="servidor"></param>
    ''' <param name="usuario"></param>
    ''' <param name="contrasenia"></param>
    Sub VerBases(servidor As String, usuario As String, contrasenia As String)
        'Esta subrutina es, en gran medida, igual a la anterior, con algunos agregados para
        ' permitir la obtención de datos del servidor mediante una consulta.

        'Creamos una variable donde almacenamos nuestra consulta
        Dim consulta As String = "SHOW DATABASES"

        'Inicializamos el objeto "conexion" y le asignamos los datos de acceso al
        ' servidor de MySQL
        Try
            conexion = New MySqlConnection()
            conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

            'Ejecución de la conexión al servidor de MySQL

            conexion.Open()
            'Creamos un objeto "comando", que se encargará de realizar la consulta al
            ' servidor, y le asignamos la variable con la consulta y el objeto "conexion"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            'Los objetos de tipo "MySqlCommand" permiten realizar consultas de todo tipo al
            ' servidor. Para ello debemos indicarles el texto de la consulta y el objeto
            ' de conexión con las credenciales de acceso necesarias.

            'Creamos un objeto "lector", que se encargará de "leer" y almacenar los datos
            ' que obtengamos del servidor
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            'Los objetos de tipo "MySqlDataReader" permiten manejar los datos obtenidos
            ' mediante la ejecución de una consulta. Son objetos instanciados por un
            ' objeto de tipo "MySqlCommand" (como nuestro objeto "comando") mediante 
            ' la función "ExecuteReader", tras lo cual recibe automáticamente los datos
            ' obtenidos por la consulta

            'Parseo de los datos de la consulta
            'Chequeamos que haya datos en el "lector"
            If lector.HasRows Then
                'Parseo es el nombre que se le dá a la acción de un algoritmo que analiza
                ' texto en bruto buscando ciertos datos específicos.
                ' En este caso nuestro parseo tiene tres etapas:
                ' 1- El "If" chequea que el lector tenga datos mediante la función "HasRows".

                'Iniciamos la lectura de cada fila de datos del "lector" y mostramos el
                ' resultado en pantalla
                While lector.Read()
                    '2- Si hay datos, mediante un bucle "While" obtenemos la primera fila 
                    ' de datos no leída del "lector" con la función "Read". Este bucle seguirá
                    ' hasta que hayamos accedido a todas las filas de datos del "lector".

                    Console.WriteLine(lector.GetString(0))
                    '3- Por cada fila de datos seleccionamos las columnas que queremos mostrar
                    ' en pantalla y cómo. Esto se logra con la función "GetString", el "(0)"
                    ' indica el número de columna que queremos acceder. En este caso la consulta
                    ' va a contener sólo una fila, las cuales se numeran a partir de 0.
                End While

                'Si el lector no tiene datos, mostramos un mensaje en pantalla
            Else
                Console.WriteLine("ATENCIÓN:No se obtuvo ningún dato del servidor.")
            End If

            'Manejo de errores de conexión
        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar al servidor.")
            Console.WriteLine("Error: " & ex.ToString)
        End Try

        'Cerramos la conexión
        conexion.Close()

    End Sub


    'El Sub "VerTablas" es muy semejante en estructura al anterior, pero requiere un dato mas
    ' para su ejecución: "base", donde indicaremos al Sub qué base de datos abriremos para ver 
    ' un listado de sus tablas.

    ''' <summary>
    ''' Permite obtener información sobre las tablas de una base de datos
    ''' </summary>
    ''' <param name="servidor"></param>
    ''' <param name="usuario"></param>
    ''' <param name="contrasenia"></param>
    ''' <param name="base"></param>
    Sub VerTablas(servidor As String, usuario As String, contrasenia As String, base As String)

        'Inicializamos el objeto de conexión y le pasamos las credenciales de acceso
        conexion = New MySqlConnection()
        conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        Try
            'Abrimos la conexión
            conexion.Open()



            'Definimos la consulta, creamos el comando y lo ejecutamos con un lector
            ' para obtener los datos
            Dim consulta As String = "SHOW TABLES FROM " & base
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            'Analizamos los resultados del lector y los mostramos en pantalla
            If lector.HasRows Then
                While lector.Read()
                    Console.WriteLine(lector.GetString(0))
                End While
            End If

            'Manejo de errores de conexión
        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar al servidor.")
            Console.WriteLine("-----------------------------------------------------")
            Console.WriteLine("Error: " & ex.ToString)

        End Try

        'Cerramos la conexión
        conexion.Close()

    End Sub


    Sub CrearBase(servidor As String, usuario As String, contrasenia As String, base As String)

        'Inicializamos el objeto de conexión y le pasamos las credenciales de acceso
        conexion = New MySqlConnection()
        conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        Try
            'Abrimos la conexión
            conexion.Open()
            Console.WriteLine("Servidor: " & servidor)
            Console.WriteLine("Creando la Base de Datos: " & base)
            Console.WriteLine("-----------------------------------------------------")

            'Definimos la consulta, creamos el comando y lo ejecutamos
            Dim consulta As String = "CREATE database " & base & ";"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)

            comando.ExecuteNonQuery()
            'En este caso la consulta que realizamos es de modificación de estructuras
            ' por lo que debemos ejecutar el comando con la función "ExecuteNonQuery"
            ' que permite ejecutar consultas que no involucran el manejo de datos sino
            ' la modificación de la estructura de la BdD.

            'Manejo de errores de conexión
        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar al servidor.")
            Console.WriteLine("No se pudo crear la Base de Datos " & base)
            Console.WriteLine("-----------------------------------------------------")
            Console.WriteLine("Error: " & ex.ToString)
        End Try

        'Cerramos la conexión
        conexion.Close()


        Console.WriteLine("-----------------------------------------------------")
        Console.WriteLine("Presione ENTER para continuar")
        Console.ReadLine()


    End Sub

End Module
