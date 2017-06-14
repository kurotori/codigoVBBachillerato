Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.FormClosing
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Label1.Text = TextBox1.Text
        Form3.Show()
        Me.Hide()
    End Sub
End Class