Imports MySql.Data.MySqlClient
'La sentencia "Imports" permite incluir una librería determinada en el código.
' Esto permite incluir funcionalidad extra que de otra manera tendríamos que
' programar desde cero.
' Para poder realizar la importación, se debe haber creado una referencia a la
' librería previamente, de lo contrario no funcionará.

Module Module1
    'Declaración de variables
    Friend conexion As MySqlConnection
    'La variable "conexion" es un objeto que se encargará de las tareas de
    ' interacción con la BdD úsando la funcionalidad del conector ODBC que
    ' agregamos al incluir la librería.

    'La palabra clave "Friend" es un modificador de acceso implica que el objeto 
    ' solo se puede acceder desde código dentro de este proyecto.
    ' Para ver información sobre modificadores de acceso, visitar 
    Dim servidor As String
    Dim usuario As String
    Dim contrasenia As String
    Dim base As String

    Sub Main()
        Console.Title = "Acceso a MySQL"
        'El comando "Console.Title permite establecer el texto del título de la
        ' ventana de comandos en que se verá el resultado del programa.

        'Comienzo del proceso de obtención de datos para la ejecución del módulo
        Console.WriteLine("Por favor, escriba la IP del Servidor MySQL:")
        Console.WriteLine("-----------------------------------------------------")
        'Elementos separadores como estos guiones ayudan a que el programa se visualice
        ' mejor.
        Console.Write("IP: ")
        'El uso de "Console.Write" en vez de "Console.WriteLine permite que el cursor
        ' de la consola se mantenga en la línea al terminar de mostrar el texto en la
        ' pantalla. Eso es visualmente práctico para solicitudes de datos.

        servidor = Console.ReadLine
        Console.WriteLine("Por favor, escriba su usuario y contraseña:")
        Console.Write("Usuario: ")
        usuario = Console.ReadLine
        Console.Write("Contraseña: ")
        contrasenia = Console.ReadLine
        'Este método de obtener la contraseña es MUY INSEGURO. No debe utilizarse
        ' por fuera de ejemplos como este.

        Console.Clear()
        'El comando "Console.Clear" permite limpiar el contenido de la ventana de
        ' comandos que estamos usando.

        'Abrimos una conexión de prueba hacia el servidor MySQL
        ConectarABase(servidor, usuario, contrasenia)

        'Ejecutamos las subrutinas que declaramos más abajo en el Main. De lo contrario
        ' no sucederá nada. Todo proceso del módulo se debe iniciar dentro del Main.

        'Realizamos una lectura del listado de BdD's en el servidor
        VerBases(servidor, usuario, contrasenia)

        'Obtenemos el listado de tablas de la BdD que el usuario solicite
        Console.WriteLine("Escriba la Base de Datos en la que quiere entrar:")
        Console.Write("Base de Datos: ")
        base = Console.ReadLine
        Console.Clear()
        VerTablas(servidor, usuario, contrasenia, base)

        Console.WriteLine("-----------------------------------------------------")
        Console.WriteLine("Presione Enter para salir...")
        Console.ReadLine()
        'Si ejecutamos un comando "Console.ReadLine" sin asociarlo a ninguna variable
        ' podemos generar una pausa controlada por el usuario. De lo contrario la
        ' ventana se cerraría y no se podría ver el resultado.
    End Sub

    'Subrutina para probar la conexión a la BdD
    Sub ConectarABase(servidor As String, usuario As String, contrasenia As String)


        'Inicializamos el objeto "conexion" y le asignamos los datos de acceso al
        ' servidor de MySQL
        conexion = New MySqlConnection()
        conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"
        'La función "ConnectionString" permite agregarle al objeto de conexión
        ' los datos de autenticación necesarios

        'Ejecución de la conexión al servidor de MySQL
        Try
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

            'Manejo de errores de conexión
        Catch ex As Exception
            'El objeto "ex" que se menciona en la línea es donde se almacenarán los datos
            ' del error para poder procesarlos.

            'Mostramos un mensaje de error en pantalla
            Console.WriteLine("No se ha podido conectar al servidor.")
            Console.WriteLine("-----------------------------------------------------")

            'Mostramos el detalle del error en pantalla
            Console.WriteLine("Error: " & ex.ToString)
            'Para mostrar el detalle del error debemos pasar el contenido del objeto "ex"
            ' a String, por lo que usamos la función "ToString". El objeto "ex" posée más
            ' funciones importantes para el manejo de mensajes de error.
        End Try

        'Cerramos la conexión
        conexion.Close()
        'Es importante que toda conexión que abramos al servidor se cierre inmediatamente
        ' terminado el proceso para evitar desborde del uso de recursos y posibles problemas
        ' de seguridad.

    End Sub

    'Subrutina para obtener el listado de BdD's en el servidor MySQL
    Sub VerBases(servidor As String, usuario As String, contrasenia As String)
        'Esta subrutina es, en gran medida, igual a la anterior, con algunos agregados para
        ' permitir la obtención de datos del servidor mediante una consulta.

        'Creamos una variable donde almacenamos nuestra consulta
        Dim consulta As String = "SHOW DATABASES"

        'Inicializamos el objeto "conexion" y le asignamos los datos de acceso al
        ' servidor de MySQL
        conexion = New MySqlConnection()
        conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        'Ejecución de la conexión al servidor de MySQL
        Try
            conexion.Open()
            Console.WriteLine("Mostrando Bases de Datos Disponibles en " & servidor & ":")
            Console.WriteLine("-----------------------------------------------------")

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

            Console.WriteLine("-----------------------------------------------------")

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
    Sub VerTablas(servidor As String, usuario As String, contrasenia As String, base As String)

        'Inicializamos el objeto de conexión y le pasamos las credenciales de acceso
        conexion = New MySqlConnection()
        conexion.ConnectionString = "server='" & servidor & "';" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"

        Try
            'Abrimos la conexión
            conexion.Open()
            Console.WriteLine("Servidor: " & servidor)
            Console.WriteLine("Mostrando Tablas Disponibles en la Base de Datos" & base & ":")
            Console.WriteLine("-----------------------------------------------------")

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
End Module

