Imports MySql.Data.MySqlClient

Public Class NewPlanRecord
    Private Sub Home_bttn_Click(sender As Object, e As EventArgs) Handles Home_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub

    Private Sub search_btn_TextChanged(sender As Object, e As EventArgs) Handles search_btn.TextChanged
        search_data("SELECT plan_client.Client_ID, plan_client.Client_Name, plan_client.Age, plan_client.Address, plan_client.Gender, plan_client.Name_of_Trustee, plan_client.Date, plan.Plan_Name, plan.Installment_Payment, plan.Gross_Price, plan.Term, plan.Mode, plan.Due_Date FROM plan_client INNER JOIN plan ON plan_client.Client_ID = plan.Plan_ID WHERE Client_Name Like '%" & search_btn.Text & "%'", PlanRecordDGV)
    End Sub

    Private Sub NewPlanRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        disp_data()
    End Sub


    Public Sub disp_data()
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT plan_client.Client_ID,plan_client.Client_Name,plan_client.Age,plan_client.Address,plan_client.Gender,plan_client.Name_of_Trustee,plan_client.Date,plan.Plan_Name,plan.Installment_Payment,plan.Gross_Price,plan.Term,plan.Mode,plan.Due_Date FROM plan_client INNER JOIN plan ON plan_client.Client_ID = plan.Plan_ID"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        dt.Clear()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        PlanRecordDGV.DataSource = dt
        conn.Close()
    End Sub

    ' Private Sub PlanRecordDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PlanRecordDGV.CellClick

    'UpdatePlanForm.Show()
    '   UpdateNewPlanForm.planclientname.Text = PlanRecordDGV("Client_Name", PlanRecordDGV.CurrentRow.Index).Value
    '  UpdateNewPlanForm.planaddress.Text = PlanRecordDGV("Address", PlanRecordDGV.CurrentRow.Index).Value
    '  UpdateNewPlanForm.plannamekintrustee.Text = PlanRecordDGV("Name_of_trustee", PlanRecordDGV.CurrentRow.Index).Value
    '  UpdateNewPlanForm.planname.Text = PlanRecordDGV("Plan_Name", PlanRecordDGV.CurrentRow.Index).Value
    '   UpdateNewPlanForm.plangrossprice.Text = PlanRecordDGV("Gross_Price", PlanRecordDGV.CurrentRow.Index).Value
    '  UpdateNewPlanForm.planinstallment.Text = PlanRecordDGV("Installment_Payment	", PlanRecordDGV.CurrentRow.Index).Value
    '  UpdateNewPlanForm.planterm.Text = PlanRecordDGV("Term", PlanRecordDGV.CurrentRow.Index).Value
    '  UpdateNewPlanForm.plandate.Text = PlanRecordDGV("Date", PlanRecordDGV.CurrentRow.Index).Value
    ' End Sub





    ' Private Sub PlanRecordDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PlanRecordDGV.CellMouseClick

    ' End Sub
    Public Shared Property selectedrow As DataGridViewRow
    Private Sub PlanRecordDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PlanRecordDGV.CellContentClick
        If e.RowIndex >= 0 Then
            selectedrow = PlanRecordDGV.Rows(e.RowIndex)
            UpdateNewPlanForm.ShowDialog()
        End If
    End Sub

    Private Sub refresh_bttn_Click(sender As Object, e As EventArgs) Handles refresh_bttn.Click
        Try
            refresh_data("SELECT plan_client.Client_ID,plan_client.Client_Name,plan_client.Age,plan_client.Address,plan_client.Gender,plan_client.Name_of_Trustee,plan_client.Date,plan.Plan_Name,plan.Installment_Payment,plan.Gross_Price,plan.Term,plan.Mode,plan.Due_Date FROM plan_client INNER JOIN plan ON plan_client.Client_ID = plan.Plan_ID", PlanRecordDGV)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class