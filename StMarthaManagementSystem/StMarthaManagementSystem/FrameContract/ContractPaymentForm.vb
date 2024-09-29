Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ContractPaymentForm

    Dim ids As String

    Private Sub ContractPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        auto_suggest("Client_Name", "contract_client", clientnamepaymentM)
        'autofill in tb
        dtadapter = New MySqlDataAdapter("SELECT * FROM contract_client", conn)
        dataSet = New DataSet
        dtadapter.Fill(dataSet, "contract_client")
        Dim count As Integer = dataSet.Tables("contract_client").Rows.Count
        Dim x As Integer
        For x = 0 To count - 1
            clientnamepaymentM.Items.Add(dataSet.Tables("contract_client").Rows(x).Item("Client_Name"))
        Next

        disp_data()
    End Sub
    Private Sub paymentdate_ValueChanged(sender As Object, e As EventArgs)
        paymentdateM.Format = DateTimePickerFormat.Custom
        paymentdateM.CustomFormat = "yyyy/MM/dd"
        paymentdateM.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub clientnamepayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clientnamepaymentM.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text

        'autofill
        cmd.CommandText = "SELECT Balance FROM contract_payment WHERE Client_Name='" & clientnamepaymentM.Text & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            contractbalanceM.Text = dr.GetString(0).ToString()
        End While


        conn.Close()
        conn.Open()
        Dim getID As New MySqlCommand("SELECT Client_ID FROM contract_client WHERE Client_Name = '" & clientnamepaymentM.Text & "'", conn)
        Dim gets = Convert.ToString(getID.ExecuteScalar)
        contractidM.Text = gets
        clientIDM.Text = gets
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
        ContractPaymentDGVM.DataSource = dt
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles searchM.TextChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        Dim searchCMD As New MySqlCommand
        searchCMD = conn.CreateCommand()
        searchCMD.CommandType = CommandType.Text
        searchCMD.CommandText = "SELECT Client_Name,Deposit,Balance,Date FROM contract_payment WHERE Client_Name  LIKE '%" & searchM.Text & "%'"


        searchCMD.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(searchCMD)
        da.Fill(dt)
        ContractPaymentDGVM.DataSource = dt
    End Sub

    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttnM.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        'Lagyan mo na dito ng automation na auto bawas sa balance kapag nag huhulog 
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO `contract_payment`(`Services_ID`, `Add_Package_ID`, `Add_Ons_ID`, `Contract_ID`, `Client_ID`, `Client_Name`, `Deposit`, `Balance`, `Date`) VALUES ('" + contractidM.Text + "','" + contractidM.Text + "','" + contractidM.Text + "','" + contractidM.Text + "','" + contractidM.Text + "','" + clientnamepaymentM.Text + "','" + contractdepositM.Text + "','" + newbalanceM.Text + "','" & paymentdateM.Text & "')"
        cmd.ExecuteNonQuery()

        clientnamepaymentM.Text = ""
        contractdepositM.Text = ""
        contractbalanceM.Text = ""
        paymentdateM.Text = ""
        newbalanceM.Text = ""



        MessageBox.Show("Successfully inserted!")

        conn.Close()
        disp_data()

    End Sub

    Private Sub ContractPaymentDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ContractPaymentDGVM.CellClick
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        ids = ContractPaymentDGVM.SelectedCells.Item(0).Value.ToString()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT contract_payment.Client_Name,contract_payment.Deposit,contract_payment.Balance,contract.Total_Amount,contract_payment.Payment_ID,contract_payment.Date FROM contract_payment INNER JOIN contract ON contract_payment.Client_ID = contract.Client_ID WHERE Client_Name = '" & ids & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)


        clientnamepaymentM.Text = ContractPaymentDGVM.Item("Client_Name", ContractPaymentDGVM.CurrentRow.Index).Value
        ' contractdeposit.Text = ContractPaymentDGV.Item("Deposit", ContractPaymentDGV.CurrentRow.Index).Value
        contractbalanceM.Text = ContractPaymentDGVM.Item("Balance", ContractPaymentDGVM.CurrentRow.Index).Value
        paymentdateM.Text = ContractPaymentDGVM.Item("Date", ContractPaymentDGVM.CurrentRow.Index).Value
        paymentIDM.Text = ContractPaymentDGVM.Item("Payment_ID", ContractPaymentDGVM.CurrentRow.Index).Value
        ' paymentID.Text = ContractPaymentDGV.Item("Client_Name", ContractPaymentDGV.CurrentRow.Index).Value

        ' Dim dr As MySqlDataReader
        ' dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        'Dim index As Integer
        ' Index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        ' selectedRow = ContractPaymentDGV.Rows(index)

        'clientnamepayment.Text = selectedRow.Cells(1).Value.ToString()
        'contractdeposit.Text = selectedRow.Cells(2).Value.ToString()
        ' contractbalance.Text = selectedRow.Cells(3).Value.ToString()
        ' paymentdate.Text = selectedRow.Cells(4).Value.ToString()
        'paymentID.Text = selectedRow.Cells(5).Value.ToString()

        ' While dr.Read
        '  paymentID.Text = dr.GetString(4).ToString()
        '  contractdeposit.Text = dr.GetString(1).ToString()
        '  contractbalance.Text = dr.GetString(2).ToString()
        'paymentdate.Text = dr.GetString(3).ToString()
        '  clientnamepayment.Text = dr.GetString(0).ToString()




        ' End While
    End Sub

    Private Sub contractdeposit_TextChanged(sender As Object, e As EventArgs) Handles contractdepositM.TextChanged
        If contractdepositM.Text = "" Or contractbalanceM.Text = "" Then
        Else
            Dim depositVal As Integer = contractdepositM.Text
            Dim balanceVal As Integer = contractbalanceM.Text
            Dim TOTAL As Integer = balanceVal - depositVal
            newbalanceM.Text = (FormatNumber(TOTAL))

        End If
    End Sub

    Private Sub contractbalance_TextChanged(sender As Object, e As EventArgs) Handles contractbalanceM.TextChanged
        If contractdepositM.Text = "" Or contractbalanceM.Text = "" Then
        Else
            Dim depositVal As Integer = contractdepositM.Text
            Dim balanceVal As Integer = contractbalanceM.Text
            Dim TOTAL As Integer = balanceVal - depositVal
            newbalanceM.Text = (FormatNumber(TOTAL))
        End If
    End Sub


    Private Sub paymentdate_ValueChanged_1(sender As Object, e As EventArgs) Handles paymentdateM.ValueChanged
        paymentdateM.Format = DateTimePickerFormat.Custom
        paymentdateM.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub update_bttn_Click(sender As Object, e As EventArgs) Handles update_bttnM.Click

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Try
            ids = ContractPaymentDGVM.SelectedCells.Item(0).Value.ToString()
            cmd.Connection = conn
            cmd.CommandText = "UPDATE `contract_payment` SET `Client_Name`='" & clientnamepaymentM.Text & "',`Deposit`='" & contractdepositM.Text & "',`Balance`='" & newbalanceM.Text & "',`Date`='" & paymentdateM.Text & "' WHERE Payment_ID = '" & paymentIDM.Text & "' "

            ' "SELECT contract_payment.Payment_ID,contract_payment.Client_Name,contract_payment.Deposit,contract_payment.Balance,contract.Total_Amount,contract_payment.Date FROM contract_payment INNER JOIN contract ON contract_payment.Client_ID = contract.Client_ID"

            cmd.ExecuteNonQuery()

            MsgBox("Successfully Updated")
            disp_data()
            clientnamepaymentM.Text = ""
            contractdepositM.Text = ""
            newbalanceM.Text = ""
            paymentdateM.Text = ""


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
End Class