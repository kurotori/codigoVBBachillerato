

Module Module1
    'Declaración de variables
    Dim opcion As Char = ""
    Dim servidor As String = ""
    Dim usuario As String = ""
    Dim contrasenia As String = ""
    Dim base As String = ""
    Dim conectado As Boolean = False

    Sub DibujarLinea()
        Dim ancho As Integer = Console.WindowWidth
        For i As Integer = 1 To ancho
            Console.Write("-")
        Next
    End Sub

    Sub DibujarMediaLinea()
        Dim ancho As Integer = (Console.WindowWidth) / 2
        For i As Integer = 1 To ancho
            Console.Write("-")
        Next
        Console.Write(vbNewLine)
    End Sub

    Sub EsperarEnter()
        Console.WriteLine("Presione Enter para continuar...")
        Console.ReadLine()
    End Sub

    Sub MarcoPantalla(est_conexion As Boolean)

        'Console.SetWindowSize(80, 20)
        Console.Clear()
        Dim nombre_app As String = "Lector Simple de Bases de Datos - v 0.3"
        Dim estado As String = "No Conectado"

        DibujarLinea()
        If conectado Then
            estado = "Conectado:" + servidor
        Else
            estado = "No Conectado"
        End If
        Dim titulo As String = nombre_app + " - " + estado
        Console.WriteLine(titulo)
        DibujarLinea()
    End Sub

    Sub Conectarse()
        MarcoPantalla(conectado)

        Console.WriteLine("Por favor, escriba la IP del Servidor MySQL")
        Console.WriteLine("o 'X' para volver al menu inicial:")
        Console.Write("IP: ")
        servidor = Console.ReadLine
        Select Case servidor
            Case "x"
                Main()
            Case "X"
                Main()
            Case vbNullString
                Conectarse()
            Case Else
                Console.WriteLine("Por favor, escriba su usuario y contraseña:")
                Console.Write("Usuario: ")
                usuario = Console.ReadLine
                Console.Write("Contraseña: ")
                contrasenia = Console.ReadLine

                If servidor.Length = 0 Or usuario.Length = 0 Or contrasenia.Length = 0 Then
                    MarcoPantalla(conectado)
                    Console.WriteLine("ERROR: Para continuar es necesario ingresar todos los datos")
                    EsperarEnter()
                    Conectarse()
                Else
                    conectado = ConectarAServidor(servidor, usuario, contrasenia)
                    MostrarBases()
                End If
        End Select



    End Sub

    Sub MostrarBases()
        Dim opc_base As Char = ""
        MarcoPantalla(conectado)
        'Realizamos una lectura del listado de BdD's en el servidor
        Console.WriteLine("Bases de Datos en " + servidor + " :")
        DibujarMediaLinea()
        VerBases(servidor, usuario, contrasenia)
        DibujarLinea()
        Console.WriteLine("Ingrese 'I' para elegir una Base de datos")
        Console.WriteLine("o 'X' para volver al menú principal:")
        Console.WriteLine("Opcion: ")
        Console.WriteLine("--->" + base)
        opc_base = Console.ReadKey.KeyChar()

        Select Case opc_base
            Case "x"
                Main()
            Case "X"
                Main()
            Case "I"

                MostrarTablas()
            Case Else
                MostrarBases()
        End Select

    End Sub

    Sub MostrarTablas()
        Console.WriteLine("Nombre de la Base de Datos:")
        base = Console.ReadLine()
        Console.WriteLine("Tablas en " + base + " :")
        DibujarMediaLinea()
        VerTablas(servidor, usuario, contrasenia, base)
        DibujarLinea()
        EsperarEnter()
    End Sub

    Function Salir() As Boolean
        Dim opc_salir As Char = ""
        Dim resultado As Boolean = False
        MarcoPantalla(conectado)
        Console.WriteLine("La aplicación va a cerrarse")
        DibujarMediaLinea()
        Console.WriteLine("¿Esta seguro?")
        Console.WriteLine("S - Si")
        Console.WriteLine("N - No")
        opc_salir = Console.ReadKey.KeyChar
        Select Case opc_salir
            Case "s"
                resultado = True
            Case "n"
                resultado = False
            Case Else
                Salir()
        End Select
        Return resultado
    End Function


    Sub Main()
        Console.Title = "Acceso a MySQL/MariaBD"
        'El comando "Console.Title permite establecer el texto del título de la
        ' ventana de comandos en que se verá el resultado del programa.

        While opcion <> "x" Or opcion <> "X"
            MarcoPantalla(conectado)
            Console.WriteLine("Elija Una Opción:")
            DibujarMediaLinea()

            Console.WriteLine(vbTab + "1 - Conectarse al Servidor de Base de Datos")
            Console.WriteLine(vbTab + "X - Salir")
            opcion = Console.ReadKey.KeyChar

            Select Case opcion
                Case "1"
                    Conectarse()
                Case "x"
                    If Salir() Then
                        Exit While
                    End If
                Case Else
                    Main()
            End Select

        End While



    End Sub









End Module

