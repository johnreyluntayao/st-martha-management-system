Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub LoginBttn_Click(sender As Object, e As EventArgs) Handles LoginBttn.Click
        Dim command As New MySqlCommand("SELECT `Admin_ID`, `Username`, `Password` FROM `admin` WHERE `Username` = @username AND `Password` = @password", conn)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username_tb.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password_tb.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        If table.Rows.Count = 0 Then
            MessageBox.Show("Invalid Username or Password")
        Else
            MessageBox.Show("Logging In...")
            DashboardFrame.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If showPassword.Checked = True Then
            password_tb.UseSystemPasswordChar = False
        Else
            password_tb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub password_tb_TextChanged(sender As Object, e As EventArgs) Handles password_tb.TextChanged
        If showPassword.Checked = True Then
            password_tb.UseSystemPasswordChar = False
        Else
            password_tb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Application.Exit()
    End Sub

    Private Sub forgotPass_Click(sender As Object, e As EventArgs) Handles forgotPassword_label.Click
        forgotPassword_label.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class