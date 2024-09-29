Imports MySql.Data.MySqlClient

Public Class ContractPaymentRecord
    Private Sub ContractPaymentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        disp_data()
    End Sub
    Public Sub disp_data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT payment.Payment_ID,plan_client.Client_Name,payment.Contract_ID,payment.Deposit,payment.Date,payment.Balance FROM payment INNER JOIN plan_client ON plan_client.Client_ID = payment.Payment_ID"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        contractPaymentRecDGV.DataSource = dt
    End Sub

End Class