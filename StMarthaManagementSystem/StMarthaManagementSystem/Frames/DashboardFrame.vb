Imports MySql.Data.MySqlClient
Public Class DashboardFrame
    Private Sub DashboardFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Display_data()
        conn.Open()
        Dim getClient As New MySqlCommand("SELECT COUNT(*) FROM contract_client", conn)
        Dim counts = Convert.ToString(getClient.ExecuteScalar)
        numbercontract.Text = counts
        If conn.State = ConnectionState.Open Then
        Else
            conn.Close()
        End If

    End Sub
    Public Sub Display_data()
        conn.Open()
        Dim getClient As New MySqlCommand("SELECT COUNT(*) FROM contract_client", conn)
        Dim counts = Convert.ToString(getClient.ExecuteScalar)
        numbercontract.Text = counts

        Dim getPlan As New MySqlCommand("SELECT COUNT(*) FROM plan_client", conn)
        Dim countss = Convert.ToString(getPlan.ExecuteScalar)
        numberplan.Text = countss
        conn.Close()

    End Sub
    Private Sub rregnewclient_Click(sender As Object, e As EventArgs) Handles rregnewclient.Click
        ContractNewForm.Show()
        Me.Hide()
    End Sub

    Private Sub regplanclient_Click(sender As Object, e As EventArgs) Handles regplanclient.Click
        NewPlanForm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub salesreportss_Click_1(sender As Object, e As EventArgs) 
        SalesReportFrame.Show()
        Me.Hide()
    End Sub
    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub

    Private Sub dashboardcalendar_ValueChanged(sender As Object, e As EventArgs) Handles dashboardcalendarM.ValueChanged
        dashboardcalendarM.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Clocktime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub DashboardFrame_BindingContextChanged(sender As Object, e As EventArgs) Handles Me.BindingContextChanged
        conn.Open()
        Dim getClient As New MySqlCommand("SELECT COUNT(*) FROM contract_client", conn)
        Dim counts = Convert.ToString(getClient.ExecuteScalar)
        numbercontract.Text = counts

        Dim getPlan As New MySqlCommand("SELECT COUNT(*) FROM plan_client", conn)
        Dim countss = Convert.ToString(getPlan.ExecuteScalar)
        numberplan.Text = countss
        conn.Close()
    End Sub

    Private Sub numbercontract_Click(sender As Object, e As EventArgs) Handles numbercontract.Click

    End Sub

End Class
