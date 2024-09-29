Imports MySql.Data.MySqlClient
Public Class CheckBoxTest

    Dim con As String = "server=localhost;username=root;password=;database=aa"
    Dim mcon As New MySqlConnection
    Dim com As New MySqlCommand

    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttn.Click
        Dim reader As MySqlDataReader
        mcon.ConnectionString = con
        Try
            Dim checks = {tarpulin_CB, flower_CB, pictureframe_CB, tribute_CB, balloons_CB, roses_CB, gardenviewing_CB, coffee_CB, karwahe_CB}
            Dim selectedpackage As New List(Of String)
            For Each packageInclusion In checks
                If packageInclusion.Checked Then
                    selectedpackage.Add(packageInclusion.Text)
                End If
            Next
            Dim value = String.Join(",", selectedpackage.ToArray)
            mcon.Open()
            Dim save = "INSERT INTO add_packages(Package_Inclusions) VALUES('" & value & "')"
            com = New MySqlCommand(save, mcon)
            reader = com.ExecuteReader
            mcon.Close()
            reader.Close()
            MsgBox("Successully Added", vbInformation)
            tarpulin_CB.Checked = False
            flower_CB.Checked = False
            pictureframe_CB.Checked = False
            tribute_CB.Checked = False
            balloons_CB.Checked = False
            roses_CB.Checked = False
            gardenviewing_CB.Checked = False
            coffee_CB.Checked = False
            karwahe_CB.Checked = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mcon.Dispose()
        End Try

    End Sub

End Class