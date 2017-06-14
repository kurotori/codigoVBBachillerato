Module Module1

    Function calcularPorcentaje(valorTotal As Integer, porcentaje As Integer) As Integer
        Dim resultado As Integer

        resultado = (porcentaje * valorTotal) / 100

        Return resultado
    End Function

End Module
