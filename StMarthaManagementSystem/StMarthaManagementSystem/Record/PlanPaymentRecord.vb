Imports MySql.Data.MySqlClient

Public Class PlanPaymentRecord
    Private Sub PlanPaymentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        disp_data()
    End Sub
    Public Sub disp_data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT plan_payment.Plan_Payment_ID,plan_client.Client_Name,plan_payment.Plan_ID,plan_payment.Month,plan_payment.Date,plan_payment.OR_No,plan_payment.Amount,plan_payment.Balance FROM plan_payment INNER JOIN plan ON plan_payment.Plan_Payment_ID = plan.Plan_ID INNER JOIN plan_client ON plan.Plan_ID = plan_client.Client_ID "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        planPaymentRecDGV.DataSource = dt
    End Sub

End Class