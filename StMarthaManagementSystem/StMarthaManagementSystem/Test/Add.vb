Public Class Add





    Private Sub tarpulin_TB_TextChanged_1(sender As Object, e As EventArgs) Handles tarpulin_TB.TextChanged
        If tarpulin_TB.Text = "" Or flower_TB.Text = "" Then
        Else
            Dim tarpulinVal As Double = tarpulin_TB.Text
            Dim flowerVal As Double = flower_TB.Text
            Dim total As Double = tarpulinVal + flowerVal
            text1.Text = (FormatNumber(total))
        End If
    End Sub

    Private Sub flower_TB_TextChanged_1(sender As Object, e As EventArgs) Handles flower_TB.TextChanged
        If tarpulin_TB.Text = "" Or flower_TB.Text = "" Then
        Else
            Dim flowerVal As Double = flower_TB.Text
            Dim tarpulinVal As Double = tarpulin_TB.Text
            Dim total As Double = tarpulinVal + flowerVal
            text1.Text = (FormatNumber(total))
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Static clickcount As Integer = 0

        clickcount += 1
        If clickcount = "20" Then
            clickcount = 1
        End If
        Guna2TextBox1.Text = clickcount.ToString("0")
        ' If qq.Text = "" Then

        '  End If
    End Sub


End Class