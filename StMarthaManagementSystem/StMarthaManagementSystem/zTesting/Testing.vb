Public Class Testing

    Public random As New Random()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 1 To 3
            TextBox1.Text = random.Next(0, 0)
            TextBox2.Text = random.Next(0, 0)
            TextBox3.Text = random.Next(0, 0)
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = "0"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = "0"
    End Sub

    Private Sub Testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = random.Next(0, 0)
        TextBox2.Text = random.Next(0, 0)
        TextBox3.Text = random.Next(0, 0)
    End Sub
End Class
