Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Module LoginLogout

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
        'Esta función no requiere la contraseña del usuario porque asume que solo se usará una vez
        ' que se ejecutó con éxito la función LoguearUsuario, por lo que la autenticación ya fue
        ' realizada.
        Dim clave As String = vbNullString
        Dim claveTemp As String = vbNullString
        'vbNullString es un valor predefinido en el lenguaje que equivale a un String
        ' de longitud cero, sin caracteres.
        Dim sal As String = CrearSal()
        'Creamos una sal especialmente para esta sesión
        'Dim marcatiempo As String = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).
        '                           TotalMilliseconds)
        Dim tiempo As DateTime = DateTime.Now
        Dim formatoTiempo As String = "yyyy-MM-dd HH:mm:ss"
        Dim marcatiempo As String = tiempo.ToString(formatoTiempo)


        MsgBox(marcatiempo)
        claveTemp = CodificarContraseña(marcatiempo, sal)

        Dim comando As New MySqlCommand

        Dim sentencia As String = "INSERT INTO prueba_login.sesiones(nombre,clave) values" &
                                  "(@nombre,@clave)"

        'Añadimos los valores a los parámetros de la sentencia
        comando.CommandText = sentencia
        comando.Parameters.AddWithValue("@nombre", nomUsuario)
        comando.Parameters.AddWithValue("@clave", claveTemp)

        Try
            'Abrimos la conexión
            conexion.Open()
            'Añadimos al objeto de comando la conexión a la BdD
            'y la sentencia que hicimos antes
            comando.Connection = conexion
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
