''' <summary>
''' Este módulo contiene Métodos para explicar el uso de listas de tipo String y 
''' algunas funciones de manejo de variables de tipo String
''' 
''' </summary>
Module ManejoDeString

    '''Listas en VB .net
    '''  Las listas en VB .net se declaran usando paréntesis "()" en lugar de 
    '''  corchetes "[]", como en otros lenguajes. Por lo demás el manejo es muy
    '''  similar al de otras variables.

    Sub EjemploDeLista()
        'Formas de declarar listas:
        '1 - Lista Vacía. El número indica el identificador de la última posición
        ' por lo que esta lista tendrá 6 posiciones
        Dim Lista1(5) As String
        '2 - Lista con elementos declarados
        Dim Lista2() As String = {"uno", "dos", "tres"}

        'Para establecer el valor de una posición de la lista, simplemente
        'igualamos dicha posición al a valor deseado
        Lista1(0) = "alga"
        Lista1(1) = "alge"
        Lista1(2) = "algi"
        Lista1(3) = "algo"
        Lista1(4) = "algu"
        Lista1(5) = "alg0"

        'Para obtener la longitud de la lista podemos usar el método Length
        Dim LongitudLista As Integer = Lista1.Length
        Console.WriteLine("La lista tiene " & LongitudLista & " elementos.")

        'Una forma efectiva de recorrer una lista es mediante el bucle For Each
        For Each posicion As String In Lista1
            Console.WriteLine(posicion)
        Next

    End Sub

    ''' <summary>
    ''' Esta función tiene el propósito de simplificar el manejo de la función Split
    ''' la cual permite separar un texto en partes según un separador y almacenar
    ''' esas partes en una lista de tipo String
    ''' </summary>
    ''' <param name="texto">El texto a separar en partes</param>
    ''' <param name="separador">El caracter separador</param>
    ''' <returns></returns>
    Function SepararTexto(texto As String, separador As Char) As String()
        Dim resultado() As String

        'La función Split requiere un texto a separar y un cara
        resultado = Split(texto, separador)

        Return resultado
    End Function







End Module
