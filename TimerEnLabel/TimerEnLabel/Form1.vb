Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub


End Class
