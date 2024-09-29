Imports MySql.Data.MySqlClient
Public Class ForgotPass

    Private Sub back_bttn_Click(sender As Object, e As EventArgs) Handles back_bttn.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub ForgotPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("SELECT `Admin_ID`, `Username`, `Password`, `Question`, `Answer` FROM `admin` WHERE `Question` = @question", conn)
        questionBox.Text = My.Settings.Question
    End Sub

    Private Sub showPassBtn_Click(sender As Object, e As EventArgs) Handles showPassBtn.Click

        Dim command As New MySqlCommand("SELECT `Admin_ID`, `Username`, `Password` FROM `admin` WHERE `Answer` = @answer", conn)
        conn.Open()
        command.Parameters.Add("@answer", MySqlDbType.VarChar).Value = answerBox.Text
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader
        If reader.Read() Then
            passwordBox.Text = reader(1)
        Else
            MsgBox("Wrong Answer")
            answerBox.Clear()
            answerBox.Focus()
        End If
        conn.Close()
    End Sub
End Class