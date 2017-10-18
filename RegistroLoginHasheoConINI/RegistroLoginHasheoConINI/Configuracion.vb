Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Module Configuracion

    Dim archivo As String = Application.StartupPath & "\configuracion.ini"
    'Declaramos una variable con la ubicación del archivo de configuración
    ' el valor de 'Application.StartupPath' es la carpeta donde se encuentra el
    ' ejecutable principal. '/configuracion.ini' será el nombre del archivo que
    ' generaremos.


    'Estas funciones toman funciones pre-existentes del sistema y las identifican
    ' mediante un nombre más sencillo para facilitar su uso. La clausula
    ' 'Alias' indica el nombre de la función original en las librerías del sistema.

    'Función auxiliar para escribir datos en un INI de forma segura.
    ' Esta función llama a una funcionalidad del sistema (WritePrivateProfileStringW)
    ' para generar o actualizar un valor de configuración en el archivo INI indicado.
    ' Requiere una sección donde guardar esos datos, un nombre de clave o parámetro,
    ' el valor de dicha clave y el archivo donde se guardará.
    Private Declare Unicode Function EscribirDatosINI Lib "kernel32" _
        Alias "WritePrivateProfileStringW" _
        (NombreSeccion As String, NombreClave As String, ValorClave As String, ArchivoINI As String) As Int32

    'Función auxiliar para leer datos de un INI de forma segura.
    ' 
    Private Declare Unicode Function LeerDatosINI Lib "kernel32" _
        Alias "GetPrivateProfileStringW" _
        (NombreSeccion As String, NombreClave As String, ValorPorDescarte As String, _
        StringRetorno As String, TamanioDatos As Int32, NombreArchivo As String) As Int32

    'SubRutina para guardar datos en el INI
    Public Sub GuardarEnIni(Seccion As String, NombreParam As String, ValorParam As String)
        EscribirDatosINI(Seccion, NombreParam, ValorParam, archivo)
        MessageBox.Show("Configuración Guardada")
    End Sub

    'Función para leer los datos del INI
    Public Function LeerDeIni(Seccion As String, NombreParam As String, ValorPorDescarte As String) As String
        Dim resultado As String
        Dim ValorParam As String = Space(1024)

        Dim CaracteresValorParam As Integer = 0
        CaracteresValorParam = LeerDatosINI(Seccion, NombreParam, ValorPorDescarte, ValorParam, Len(ValorParam), archivo)

        resultado = Left(ValorParam, CaracteresValorParam)
        Return resultado
    End Function


End Module
