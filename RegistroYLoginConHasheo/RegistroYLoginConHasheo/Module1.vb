Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Module Module1

    Public Function CrearSal() As String
        'String con caracteres para la base de la sal
        Dim baseSal As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"

        'String que llevará la sal generada
        Dim sal As String = ""

        'Objeto generador de secuencias al azar
        Dim azar As New Random

        'Objeto constructor del String de la sal
        Dim constructor As New StringBuilder

        'Comenzamos a construir la sal
        For i As Integer = 1 To 100
            '100 es la cantidad de caracteres que tendrá nuestra sal

            'Elegimos un caracter al azar de los caracteres de la base...
            Dim numCaracter As Integer = azar.Next(0, baseSal.Length - 1)
            Dim caracter = (baseSal.Substring(numCaracter, 1))

            '...y los añadimos a la sal
            sal = sal & caracter
        Next

        'Y obtenemos la sal al salir de la función
        Return sal
    End Function

    Public Function CodificarContraseña(contraseña As String, sal As String) As String
        'Pasamos los datos a bytes puros
        Dim convertirABytes As Byte() = Encoding.UTF8.GetBytes(contraseña & sal)

        'Creamos el objeto codificador
        Dim tipoDeHash As HashAlgorithm = New SHA512Managed()

        'Codificamos los bytes originales
        Dim bytesCodificados As Byte() = tipoDeHash.ComputeHash(convertirABytes)

        'Pasamos el código a una secuencia en BASE64 
        Dim Resultado As String = Convert.ToBase64String(bytesCodificados)

        'Y obtenemos la contraseña al salir de la función
        Return Resultado
    End Function

    Function CrearConexion(servidor As String, usuario As String, contrasenia As String) As MySqlConnection
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=" & servidor & ";" &
                                    "user=" & usuario & ";" &
                                    "password=" & contrasenia & ";"
        Return conexion
    End Function

    Public Function NuevoUsuario(conexion As MySqlConnection,
                                 nomUsuario As String, hashContraseña As String, codigoSal As String) As Boolean
        'Esta función permite crear un nuevo usuario, pero puede considerarse un modelo a seguir para
        ' cualquier función pensada para guardar datos en una tabla de BdD.
        ' Esta pensada para devolver un valor lógico y aprovechar eso para disparar eventos o mensajes
        ' según si la conexión tuvo éxito o no.

        'La variable 'exito' es la que contiene el valor que devuelve la función. Si no hay errores, pasa
        ' a 'True', de lo contrario, ante un error, se mantiene en 'False'
        Dim exito As Boolean = False

        Dim comando As New MySqlCommand

        'Nuestra sentencia se rellena con elementos '@'.  Estos elementos son 
        ' parámetros y más adelante (durante el Try) los rellenaremos con el método
        ' 'Parameters.AddWithValue()' del objeto MySqlCommand.
        ' El uso de parámetros en la consulta permite evitar la mayor parte de los 
        ' ataques por inyección SQL, aumentando la seguridad de nuestro sistema.
        Dim sentencia As String = "INSERT INTO prueba_login.usuarios(nombre,sal,hash) values" &
                                  "(@nombre,@sal,@hash)"
        comando.Parameters.AddWithValue("@nombre", nomUsuario)
        comando.Parameters.AddWithValue("@hash", hashContraseña)
        comando.Parameters.AddWithValue("@sal", codigoSal)
        Try
            'Abrimos la conexión
            conexion.Open()
            'Añadimos al objeto de comando la conexión a la BdD
            'y la sentencia que hicimos antes
            comando.Connection = conexion
            comando.CommandText = sentencia
            'Añadimos los valores a los parámetros de la sentencia
            'comando.Parameters.AddWithValue("@nombre", nomUsuario)
            'comando.Parameters.AddWithValue("@hash", hashContraseña)
            'comando.Parameters.AddWithValue("@sal", codigoSal)
            'Finalmente, ejecutamos el comando mediante un 'ExecuteNonQuery'
            ' este método de los objetos MySqlCommand permite ejecutar una sentencia SQL
            ' que realice modificaciones en los datos o estructura de la BdD
            comando.ExecuteNonQuery()
            exito = True
        Catch ex As Exception
            'En caso de errores, mostramos un aviso y el error en pantalla"
            MessageBox.Show("No se pudieron guardar los datos")
            MessageBox.Show("Error: " & ex.ToString)
        End Try

        'Al final de todo, cerramos la conexión
        conexion.Close()
        Return exito
    End Function


    Function chequearDatosNuevoUsuario(conexion As MySqlConnection, nomUsuario As String,
                                       contra1 As String, contra2 As String) As Boolean
        'Semejante a la función para crear usuarios, esta función devuelve un valor Booleano para
        ' aprovecharlo en el control de eventos y mensajes de acuerdo con el resultado de la misma
        Dim exito As Boolean = False

        'El método .Length devuelve la cantidad de caracteres de un String y lo aprovechamos para
        ' comprobar si el nombre de usuario tiene el largo adecuado.
        If nomUsuario.Length > 7 Then
            'Si el nombre de usuario es correcto comprobamos lo mismo con la contraseña
            If contra1.Length > 7 Then
                'Si la longitud de la contraseña es la correcta, chequeamos que sea igual a la
                ' confirmación. Para eso utilizamos el método '.Compare()' que compara dos
                ' variables de tipo String.
                If String.Compare(contra1, contra2) = 0 Then

                    'Finalmente, si se aprueban todos los chequeos locales, pasamos al chequeo con el
                    ' servidor de BdD. Para hacerlo realizamos una consulta de nombres a la tabla.
                    Dim consulta As String = "SELECT nombre FROM prueba_login.usuarios WHERE nombre=@nombre"
                    Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@nombre", nomUsuario)

                    Try
                        conexion.Open()
                        Dim lector As MySqlDataReader = comando.ExecuteReader()
                        If lector.HasRows Then
                            'Si el lector tiene algún resultado, entonces el usuario ya existe y
                            ' por lo tanto la función debe devolver False
                            exito = False
                            MsgBox("Este nombre de usuario ya fue registrado")
                        Else
                            'Si no hay resultados, entonces los datos de usuario han superado todas
                            ' las pruebas y se puede registrar al usuario
                            exito = True
                        End If
                    Catch ex As Exception
                        MessageBox.Show("No se ha podido conectar al servidor")
                        MessageBox.Show("Error:" & ex.ToString)
                    End Try
                    conexion.Close()
                Else
                    MsgBox("Las contraseñas NO son iguales")
                End If
            Else
                MsgBox("La contraseña debe tener al menos 8 caracteres")
            End If
        Else
            MsgBox("El nombre de usuario debe tener al menos 8 caracteres")
        End If
        Return exito
    End Function

    Public Function LoguearUsuario(conexion As MySqlConnection, nomUsuario As String,
                                   contrasenia As String) As Boolean
        Dim exito As Boolean = False
        Dim sal As String = ""
        Dim hashContrasenia As String = ""
        Dim clave As String = ""

        Try
            'Abrimos la conexion
            conexion.Open()

            'Creamos la consulta
            Dim consulta As String = "SELECT sal,hash FROM prueba_login.usuarios WHERE nombre = @nombre"
            'Creamos el comando que ejecutará el lector y le agregamos la consulta
            ' y los datos de conexión
            Dim comando As MySqlCommand = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@nombre", nomUsuario)

            'Creamos el objeto lector que contendrá los datos de la consulta
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            'Si se obtuvieron datos, se reparten los datos a las variables
            If lector.HasRows Then
                'NO DEBERÍA HABER MÁS QUE UN REGISTRO POR NOMBRE DE USUARIO, por eso
                ' el While solo debería realizar un bucle, de lo contrario tendríamos errores
                While lector.Read()
                    'Obtenemos los datos de cada campo en el tipo que los queremos
                    sal = lector.GetString(0)
                    hashContrasenia = lector.GetString(1)
                End While
                'Regeneramos el hash de la contraseña con la sal obtenida
                clave = CodificarContraseña(contrasenia, sal)
                'Y comparamos los dos hasheos. Si la contraseña es la misma, el hash tambien
                If clave.Equals(hashContrasenia) Then
                    exito = True
                    MessageBox.Show("Bienvenido, " & nomUsuario)
                Else
                    MessageBox.Show("La contraseña es incorrecta. Intente de nuevo")
                End If
            Else
                MessageBox.Show("Este usuario no existe. ¿Escribió bien el nombre de usuario?")
            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("No se ha podido conectar al servidor")
            MessageBox.Show("Error:" & ex.ToString)
        End Try

        Return exito
    End Function

    Function CrearClaveSesion(conexion, nomUsuario) As String
        Dim clave As String = vbNullString
        Dim claveTemp As String = ""
        Dim sal As String = CrearSal()

        Dim marcatiempo As String = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).
                                    TotalMilliseconds)

        claveTemp = CodificarContraseña(marcatiempo, sal)

        Dim comando As New MySqlCommand

        Dim sentencia As String = "INSERT INTO prueba_login.sesion(nombre,clave) values" &
                                  "(@nombre,@clave)"
        comando.Parameters.AddWithValue("@nombre", nomUsuario)
        comando.Parameters.AddWithValue("@clave", claveTemp)
        Try
            'Abrimos la conexión
            conexion.Open()
            'Añadimos al objeto de comando la conexión a la BdD
            'y la sentencia que hicimos antes
            comando.Connection = conexion
            comando.CommandText = sentencia
            'Añadimos los valores a los parámetros de la sentencia
            'Finalmente, ejecutamos el comando mediante un 'ExecuteNonQuery'
            ' este método de los objetos MySqlCommand permite ejecutar una sentencia SQL
            ' que realice modificaciones en los datos o estructura de la BdD
            comando.ExecuteNonQuery()
            clave = claveTemp
        Catch ex As Exception
            'En caso de errores, mostramos un aviso y el error en pantalla"
            MessageBox.Show("No se pudo crear la sesión")
            MessageBox.Show("Error: " & ex.ToString)
        End Try

        'Al final de todo, cerramos la conexión
        conexion.Close()

        Return clave
    End Function

End Module
