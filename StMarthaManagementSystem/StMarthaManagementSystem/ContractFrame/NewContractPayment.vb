Imports MySql.Data.MySqlClient
Imports System.IO
Public Class NewContractPayment

    Dim ids As String

    Private Sub NewContractPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        auto_suggest("Client_Name", "contract_client", clientnamepayment)
        'autofill in tb
        dtadapter = New MySqlDataAdapter("SELECT * FROM contract_client", conn)
        dataSet = New DataSet
        dtadapter.Fill(dataSet, "contract_client")
        Dim count As Integer = dataSet.Tables("contract_client").Rows.Count
        Dim x As Integer
        For x = 0 To count - 1
            clientnamepayment.Items.Add(dataSet.Tables("contract_client").Rows(x).Item("Client_Name"))
        Next

        disp_data()
    End Sub
    Private Sub paymentdate_ValueChanged(sender As Object, e As EventArgs)
        paymentdate.Format = DateTimePickerFormat.Custom
        paymentdate.CustomFormat = "yyyy/MM/dd"
        paymentdate.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub clientnamepayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clientnamepayment.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text

        'autofill
        cmd.CommandText = "SELECT Balance FROM contract_payment WHERE Client_Name='" & clientnamepayment.Text & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            contractbalance.Text = dr.GetString(0).ToString()
        End While


        conn.Close()
        conn.Open()
        Dim getID As New MySqlCommand("SELECT Client_ID FROM contract_client WHERE Client_Name = '" & clientnamepayment.Text & "'", conn)
        Dim gets = Convert.ToString(getID.ExecuteScalar)
        contractid.Text = gets
        clientID.Text = gets
        conn.Close()



    End Sub

    Public Sub disp_data()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT contract_payment.Payment_ID,contract_payment.Client_Name,contract_payment.Deposit,contract_payment.Balance,contract.Total_Amount,contract_payment.Date FROM contract_payment INNER JOIN contract ON contract_payment.Client_ID = contract.Client_ID"

        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        ContractPaymentDGV.DataSource = dt
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        Dim searchCMD As New MySqlCommand
        searchCMD = conn.CreateCommand()
        searchCMD.CommandType = CommandType.Text
        searchCMD.CommandText = "SELECT Client_Name,Deposit,Balance,Date FROM contract_payment WHERE Client_Name  LIKE '%" & search.Text & "%'"


        searchCMD.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(searchCMD)
        da.Fill(dt)
        ContractPaymentDGV.DataSource = dt
    End Sub

    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttn.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        'Lagyan mo na dito ng automation na auto bawas sa balance kapag nag huhulog 
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO `contract_payment`(`Services_ID`, `Add_Package_ID`, `Add_Ons_ID`, `Contract_ID`, `Client_ID`, `Client_Name`, `Deposit`, `Balance`, `Date`) VALUES ('" + contractid.Text + "','" + contractid.Text + "','" + contractid.Text + "','" + contractid.Text + "','" + contractid.Text + "','" + clientnamepayment.Text + "','" + contractdeposit.Text + "','" + newbalance.Text + "','" & paymentdate.Text & "')"
        cmd.ExecuteNonQuery()

        clientnamepayment.Text = ""
        contractdeposit.Text = ""
        contractbalance.Text = ""
        paymentdate.Text = ""
        newbalance.Text = ""



        MessageBox.Show("Successfully inserted!")

        conn.Close()
        disp_data()

    End Sub

    Private Sub ContractPaymentDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ContractPaymentDGV.CellClick
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        ids = ContractPaymentDGV.SelectedCells.Item(0).Value.ToString()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT contract_payment.Client_Name,contract_payment.Deposit,contract_payment.Balance,contract.Total_Amount,contract_payment.Payment_ID,contract_payment.Date FROM contract_payment INNER JOIN contract ON contract_payment.Client_ID = contract.Client_ID WHERE Client_Name = '" & ids & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)


        clientnamepayment.Text = ContractPaymentDGV.Item("Client_Name", ContractPaymentDGV.CurrentRow.Index).Value
        ' contractdeposit.Text = ContractPaymentDGV.Item("Deposit", ContractPaymentDGV.CurrentRow.Index).Value
        contractbalance.Text = ContractPaymentDGV.Item("Balance", ContractPaymentDGV.CurrentRow.Index).Value
        paymentdate.Text = ContractPaymentDGV.Item("Date", ContractPaymentDGV.CurrentRow.Index).Value
        paymentID.Text = ContractPaymentDGV.Item("Payment_ID", ContractPaymentDGV.CurrentRow.Index).Value
        ' paymentID.Text = ContractPaymentDGV.Item("Client_Name", ContractPaymentDGV.CurrentRow.Index).Value



    End Sub

    Private Sub contractdeposit_TextChanged(sender As Object, e As EventArgs) Handles contractdeposit.TextChanged
        If contractdeposit.Text = "" Or contractbalance.Text = "" Then
        Else
            Dim depositVal As Integer = contractdeposit.Text
            Dim balanceVal As Integer = contractbalance.Text
            Dim TOTAL As Integer = balanceVal - depositVal
            newbalance.Text = (TOTAL)

        End If
    End Sub

    Private Sub contractbalance_TextChanged(sender As Object, e As EventArgs) Handles contractbalance.TextChanged
        If contractdeposit.Text = "" Or contractbalance.Text = "" Then
        Else
            Dim depositVal As Integer = contractdeposit.Text
            Dim balanceVal As Integer = contractbalance.Text
            Dim TOTAL As Integer = balanceVal - depositVal
            newbalance.Text = (TOTAL)
        End If
    End Sub


    Private Sub paymentdate_ValueChanged_1(sender As Object, e As EventArgs) Handles paymentdate.ValueChanged
        paymentdate.Format = DateTimePickerFormat.Custom
        paymentdate.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub update_bttn_Click(sender As Object, e As EventArgs) Handles update_bttn.Click

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Try
            ids = ContractPaymentDGV.SelectedCells.Item(0).Value.ToString()
            cmd.Connection = conn
            cmd.CommandText = "UPDATE `contract_payment` SET `Client_Name`='" & clientnamepayment.Text & "',`Deposit`='" & contractdeposit.Text & "',`Balance`='" & newbalance.Text & "',`Date`='" & paymentdate.Text & "' WHERE Payment_ID = '" & paymentID.Text & "' "

            ' "SELECT contract_payment.Payment_ID,contract_payment.Client_Name,contract_payment.Deposit,contract_payment.Balance,contract.Total_Amount,contract_payment.Date FROM contract_payment INNER JOIN contract ON contract_payment.Client_ID = contract.Client_ID"

            cmd.ExecuteNonQuery()

            MsgBox("Successfully Updated")
            disp_data()
            clientnamepayment.Text = ""
            contractdeposit.Text = ""
            newbalance.Text = ""
            paymentdate.Text = ""


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub Home_bttn_Click(sender As Object, e As EventArgs) Handles Home_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click
        Me.Hide()
        ContractNewForm.Show()
    End Sub

    Private Sub ContractPaymentDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ContractPaymentDGV.CellContentClick

    End Sub

    Private Sub newcon_Click(sender As Object, e As EventArgs) Handles newcon.Click
        conn.Close()
        NewContractForm.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class