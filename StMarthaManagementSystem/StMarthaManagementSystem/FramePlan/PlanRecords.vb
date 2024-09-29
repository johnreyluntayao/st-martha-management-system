
Imports MySql.Data.MySqlClient
Public Class PlanRecords


    Private Sub PlanRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        disp_data()
    End Sub
    Public Sub disp_data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT plan_client.Client_ID,plan_client.Client_Name,plan_client.Address,plan_client.Gender,plan_client.Name_of_Trustee,plan_client.Date,plan.Plan_Name,plan.Installment_Payment,plan.Gross_Price,plan.Term,plan.Mode,plan.Due_Date FROM plan_client INNER JOIN plan ON plan_client.Client_ID = plan.Plan_ID"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        planRecDGVM.DataSource = dt
    End Sub

    Private Sub planRecDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles planRecDGVM.CellClick

    End Sub

    Private Sub planRecDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles planRecDGVM.CellContentClick

    End Sub

    Private Sub search_btnM_TextChanged(sender As Object, e As EventArgs) Handles search_btnM.TextChanged

    End Sub
End Class