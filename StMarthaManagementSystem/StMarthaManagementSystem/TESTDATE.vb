Imports MySql.Data.MySqlClient
Imports System.IO
Public Class TESTDATE
    Private Sub TESTDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
    End Sub

    Private Sub birthdateee_ValueChanged(sender As Object, e As EventArgs) Handles birthdateee.ValueChanged
        birthdateee.Format = DateTimePickerFormat.Custom
        birthdateee.CustomFormat = "yyyy/MM/dd"
    End Sub


    Private Sub birthdate_ValueChanged(sender As Object, e As EventArgs) Handles birthdate.ValueChanged
        birthdate.Format = DateTimePickerFormat.Custom
        birthdate.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()

        cmd.CommandText = "INSERT INTO deceased_information (`Birthdate`) VALUES ('" & kyut.Text & "')"
        If cmd.ExecuteNonQuery Then
            MessageBox.Show("You Good")
        Else
            MessageBox.Show("Failed!")
        End If
    End Sub

    Private Sub kyut_ValueChanged(sender As Object, e As EventArgs) Handles kyut.ValueChanged
        kyut.Format = DateTimePickerFormat.Custom
        kyut.CustomFormat = "yyyy/MM/dd"
    End Sub
End Class