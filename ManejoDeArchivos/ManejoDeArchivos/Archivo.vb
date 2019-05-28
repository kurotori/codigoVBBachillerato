Imports System
Imports System.IO
Imports System.Text

''' <summary>
''' Este módulo permite manejar de forma sencilla archivos de texto plano
''' Autor: Sebastián de los Ángeles
''' </summary>
Module Archivo

    ''' <summary>
    ''' Permite crear o modificar un archivo de texto existente
    ''' </summary>
    ''' <param name="datos">Los datos que deben agregarse al archivo</param>
    ''' <param name="ruta">La ruta de acceso al archivo</param>
    ''' 
    Sub AgregarDatosArchivo(datos As String, ruta As String)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(datos)
        Dim flujoDatos As FileStream = File.OpenWrite(ruta)
        flujoDatos.Write(info, 0, info.Length)
        flujoDatos.Close()
    End Sub


    ''' <summary>
    ''' Permite leer los datos de un archivo de texto existente y guardarlos en una
    ''' variable de tipo String
    ''' </summary>
    ''' <param name="ruta">La ruta de acceso al archivo</param>
    ''' <returns></returns>
    ''' 
    Function LeerDatosArchivo(ruta As String) As String
        Dim datos As String = ""
        datos = My.Computer.FileSystem.ReadAllText(ruta)
        Return datos
    End Function

End Module
