Public Class Form1
    Dim datoTabla As String
    Dim numeroColumna As Integer
    Dim datoLista As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        datoLista = TextBox2.Text
        agregarDatoLista(datoLista, ComboBox1)
        TextBox2.Text = ""
        MsgBox("Se agregó " + datoLista + " a la lista desplegable")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datoTabla = TextBox1.Text
        agregarDatoTabla(datoTabla, numeroColumna, DataGridView1)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click
        numeroColumna = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click

        numeroColumna = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Form2.ShowDialog()





        Dim seleccion As String = obtenerDatoLista(ComboBox1)
        MsgBox(seleccion)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = ObtenerTabla()
    End Sub

    Private Function ObtenerTabla() As DataTable
        '
        ' This Function needs to build the data table.
        '
        Return New DataTable()
    End Function

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged_2(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
