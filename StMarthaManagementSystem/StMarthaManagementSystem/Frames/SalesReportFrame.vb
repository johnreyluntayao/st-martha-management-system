Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class SalesReportFrame

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub

    Private Sub regnewclient_Click(sender As Object, e As EventArgs) Handles regnewclient.Click
        ManageDocFrame.Show()
        Me.Hide()

    End Sub

    Private Sub records_Click(sender As Object, e As EventArgs) Handles records.Click
        RecordFrame.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalesReportFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=stmartha_database")
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT contract_client.Client_Name, add_packages.Package_Name, add_packages.Package_Inclusions, contract.Total_Amount, contract_client.Date
                                    FROM contract_client
                                    INNER JOIN add_packages ON contract_client.Client_ID=add_packages.Add_Package_ID
                                    INNER JOIN contract ON add_packages.Add_Package_ID=contract.Contract_ID", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()

        DataGridView1.Columns(0).HeaderText = "Client Name"
        DataGridView1.Columns(1).HeaderText = "Package Name"
        DataGridView1.Columns(2).HeaderText = "Package Inclusions"
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).HeaderText = "Total Amount"
        DataGridView1.Columns(4).HeaderText = "Date"

    End Sub

    Private Sub ContractPrintBtn_Click(sender As Object, e As EventArgs) Handles ContractPrintBtn.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class