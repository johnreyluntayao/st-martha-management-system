Imports MySql.Data.MySqlClient
Public Class PlanPaymentForm
    Dim da As MySqlDataAdapter
    Dim dset As New DataSet


    Private Sub plandate_ValueChanged(sender As Object, e As EventArgs) Handles plandate.ValueChanged
        plandate.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        da = New MySqlDataAdapter("SELECT * FROM month WHERE months='" & ComboBox1.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "month")
        Dim month As String = dset.Tables("month").Rows(0).Item("months")



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        da = New MySqlDataAdapter("SELECT * FROM month", conn)
        dset = New DataSet
        da.Fill(dset, "month")
        Dim count As Integer = dset.Tables("month").Rows.Count
        Dim x As Integer
        For x = 0 To count - 1
            ComboBox1.Items.Add(dset.Tables("month").Rows(x).Item("months"))
        Next
    End Sub
End Class