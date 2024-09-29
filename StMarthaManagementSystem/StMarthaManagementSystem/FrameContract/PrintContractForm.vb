Public Class PrintContractForm
    Private Sub PrintContractForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UpdatedContractForm.Guna2CheckBox1.Checked = True Then
            Guna2CheckBox1.Checked = True
        End If
        If UpdatedContractForm.Guna2CheckBox12.Checked = True Then
            Guna2CheckBox2.Checked = True
        End If
        If UpdatedContractForm.Guna2CheckBox4.Checked = True Then
            Guna2CheckBox3.Checked = True
        End If
        If UpdatedContractForm.Guna2CheckBox2.Checked = True Then
            Guna2CheckBox6.Checked = True
        End If
        If UpdatedContractForm.Guna2CheckBox8.Checked = True Then
            Guna2CheckBox12.Checked = True
        End If
        If UpdatedContractForm.Guna2CheckBox6.Checked = True Then
            Guna2CheckBox4.Checked = True
        End If
        If UpdatedContractForm.Guna2CheckBox9.Checked = True Then
            Guna2CheckBox7.Checked = True
        End If
        If UpdatedContractForm.Guna2CheckBox11.Checked = True Then
            Guna2CheckBox8.Checked = True
        End If
        If UpdatedContractForm.Guna2CheckBox5.Checked = True Then
            Guna2CheckBox9.Checked = True
        End If
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        PrintBtn.Visible = False
        cancelBtn.Visible = False
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        PrintBtn.Visible = True
        cancelBtn.Visible = True
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Guna2TextBox1.Text = UpdatedContractForm.Guna2DateTimePicker2.Text
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        Guna2TextBox2.Text = UpdatedContractForm.Guna2DateTimePicker3.Text
    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox3.TextChanged
        Guna2TextBox3.Text = UpdatedContractForm.Guna2DateTimePicker4.Text
    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox5.TextChanged
        Guna2TextBox5.Text = UpdatedContractForm.Guna2TextBox6.Text
    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged
        Guna2TextBox4.Text = UpdatedContractForm.Guna2TextBox7.Text
    End Sub

    Private Sub Guna2TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox6.TextChanged
        Guna2TextBox6.Text = UpdatedContractForm.Guna2TextBox8.Text
    End Sub

    Private Sub Guna2TextBox7_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox7.TextChanged
        Guna2TextBox7.Text = UpdatedContractForm.Guna2TextBox9.Text
    End Sub

    Private Sub Guna2TextBox9_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox9.TextChanged
        Guna2TextBox9.Text = UpdatedContractForm.Guna2TextBox11.Text
    End Sub

    Private Sub Guna2TextBox10_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox10.TextChanged
        Guna2TextBox10.Text = UpdatedContractForm.Guna2TextBox10.Text
    End Sub

    Private Sub Guna2TextBox11_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox11.TextChanged
        Guna2TextBox11.Text = UpdatedContractForm.Guna2TextBox12.Text
    End Sub

    Private Sub Guna2TextBox12_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox12.TextChanged
        Guna2TextBox12.Text = UpdatedContractForm.Guna2TextBox1.Text
    End Sub

    Private Sub Guna2TextBox13_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox13.TextChanged
        Guna2TextBox13.Text = UpdatedContractForm.Guna2TextBox3.Text
    End Sub

    Private Sub Guna2TextBox14_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox14.TextChanged
        Guna2TextBox14.Text = UpdatedContractForm.Guna2TextBox5.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = UpdatedContractForm.clientSigPic.Image
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Image = UpdatedContractForm.adminSigPic.Image
    End Sub
End Class