Imports MySql.Data.MySqlClient

Public Class PlanRecord
    Private Sub PlanRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        disp_data()
    End Sub

    Public Sub disp_data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT plan_client.Client_ID,plan_client.Client_Name,plan_client.Address,plan_client.Contact_Number,plan_client.Gender,plan_client.Name_of_Trustee,plan_client.Date,plan.Plan_Name,plan.Installment_Payment,plan.Gross_Price,plan.Term,plan.Mode,plan.Due_Date FROM plan_client INNER JOIN plan ON plan_client.Client_ID = plan.Plan_ID"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        planRecDGV.DataSource = dt
    End Sub


End Class