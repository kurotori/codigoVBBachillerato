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
        Dim exito As Boolean = False

        Dim comando As New MySqlCommand

        Dim sentencia As String = "INSERT INTO login.usuarios(nombre,sal,hash) values" &
                                  "(@nombre,@sal,@hash)"
        Try
            'Abrimos la conexión
            conexion.Open()
            'Añadimos al objeto de comando la conexión a la BdD
            'y la sentencia que hicimos antes
            comando.Connection = conexion
            comando.CommandText = sentencia
            'Añadimos los valores a los parámetros de la sentencia
            comando.Parameters.AddWithValue("@nombre", nomUsuario)
            comando.Parameters.AddWithValue("@sal", hashContraseña)
            comando.Parameters.AddWithValue("@hash", codigoSal)
            'Finalmente, ejecutamos el comando
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

    Function chequearDatosNuevoUsuario(nomUsuario As String, contra1 As String, contra2 As String) As Boolean
        Dim exito As Boolean = False

        If nomUsuario.Length > 7 Then
            If contra1.Length > 7 Then
                If String.Compare(contra1, contra2) = 0 Then
                    exito = True
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

End Module
