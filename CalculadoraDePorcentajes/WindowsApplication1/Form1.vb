Public Class Form1

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer = 0
        numero = Convert.ToInt16(TextBox1.Text)

        resultado90.Text = Module1.calcularPorcentaje(numero, 90)
        resultado80.Text = calcularPorcentaje(numero, 80)
        resultado75.Text = calcularPorcentaje(numero, 75)
        resultado50.Text = calcularPorcentaje(numero, 50)
        resultado30.Text = calcularPorcentaje(numero, 30)
        resultado25.Text = calcularPorcentaje(numero, 25)
        resultado10.Text = calcularPorcentaje(numero, 10)
        resultado1.Text = calcularPorcentaje(numero, 1)

    End Sub
End Class
