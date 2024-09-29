Public Class testframe
    Sub switchpanel(ByVal panel As Form)
        '  Panel1.Controls.Add(testframe1)
        Panel1.Controls.Clear()
        panel.TopLevel = False

        Panel1.Controls.Add(panel)

        panel.Show()
    End Sub
    Private Sub testframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        testframe1.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        switchpanel(testframe1)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        switchpanel(testframe2)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        switchpanel(tesframe3)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class