Imports MySql.Data.MySqlClient
Public Class NewPaymentPlan
    Private Sub Home_bttn_Click(sender As Object, e As EventArgs) Handles Home_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub


    Dim da As MySqlDataAdapter
    Dim dset As New DataSet
    Dim ids As String

    Private Sub AddPlanPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        auto_suggest("Client_Name", "plan_client", CNPlanP_CB)


        dtadapter = New MySqlDataAdapter("SELECT * FROM plan_client", conn)
        dataSet = New DataSet
        dtadapter.Fill(dataSet, "plan_client")
        Dim count As Integer = dataSet.Tables("plan_client").Rows.Count
        Dim x As Integer
        For x = 0 To count - 1
            CNPlanP_CB.Items.Add(dataSet.Tables("plan_client").Rows(x).Item("Client_Name"))
        Next

        auto_suggest("Client_Name", "plan_client", CNPlanP_CB)


        dtadapter = New MySqlDataAdapter("SELECT * FROM month", conn)
        dataSet = New DataSet
        dtadapter.Fill(dataSet, "month")
        Dim counts As Integer = dataSet.Tables("month").Rows.Count
        Dim y As Integer
        For y = 0 To counts - 1
            month_CB.Items.Add(dataSet.Tables("month").Rows(y).Item("Months"))
        Next

        disp_data()



    End Sub

    Public Sub disp_data()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Client_Name,Month,Date,Plan_Payment_ID,I_N,OR_No,Amount,Balance FROM plan_payment"

        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        PlanPaymenDGV.DataSource = dt
    End Sub

    Private Sub clientnamePlanpayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CNPlanP_CB.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text

        'autofill
        cmd.CommandText = "SELECT * FROM plan WHERE Plan_ID='" & planidM.Text & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        dt.Clear()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            pbalance.Text = dr.GetString(10).ToString()
        End While


        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        'Kailangang baguhin ang IN kase kung nakatutuk sya sa ID ay mag iinremet sya kahit ibang customer na ang iinput
        Dim getID As New MySqlCommand("SELECT Client_ID FROM plan_client WHERE Client_Name='" & CNPlanP_CB.Text & "'", conn)
        Dim gets = Convert.ToString(getID.ExecuteScalar)
        IDM.Text = gets
        planidM.Text = gets

        Dim getClient As New MySqlCommand("SELECT COUNT(Client_Name) FROM plan_payment WHERE Client_Name = '" & CNPlanP_CB.Text & "'", conn)
        Dim countx = Convert.ToString(getClient.ExecuteScalar)
        IN_ID.Text = countx + 1
        conn.Close()

    End Sub

    Private Sub month_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles month_CB.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim monthCommand As New MySqlCommand
        monthCommand = conn.CreateCommand()
        monthCommand.CommandType = CommandType.Text
        monthCommand.CommandText = "SELECT * FROM month WHERE Months='" & month_CB.Text & "'"
        monthCommand.ExecuteNonQuery()

        Dim getIDs As New MySqlCommand("SELECT Month_ID FROM month WHERE Months = '" & month_CB.Text & "'", conn)
        Dim getss = Convert.ToString(getIDs.ExecuteScalar)
        monthidM.Text = getss

        conn.Close()


    End Sub

    Private Sub plandate_ValueChanged(sender As Object, e As EventArgs)
        plandate.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub pdeposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pdeposit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub pbalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pbalance.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub planPayment_saveBttn_Click(sender As Object, e As EventArgs) Handles planPayment_saveBttn.Click

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        'Lagyan mo na dito ng automation na auto bawas sa balance kapag nag huhulog 
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO `plan_payment`(`Client_ID`, `Plan_ID`, `Month_ID`, `Client_Name`, `Month`, `Date`, `I_N`, `OR_No`, `Amount`, `Balance`,`New_Balance`) VALUES ('" + IDM.Text + "','" + planidM.Text + "','" + monthidM.Text + "','" + CNPlanP_CB.Text + "','" + month_CB.Text + "','" + plandate.Text + "','" + IN_ID.Text + "','" + OrNum.Text + "','" + pdeposit.Text + "','" + pbalance.Text + "','" + newbal.Text + "')"
        cmd.ExecuteNonQuery()

        CNPlanP_CB.Text = ""
        month_CB.Text = ""
        OrNum.Text = ""
        pdeposit.Text = ""
        pbalance.Text = ""
        newbal.Text = ""

        MessageBox.Show("Successfully inserted!")
        conn.Close()
        disp_data()



    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        Try
            search_data("SELECT * FROM `plan_payment` WHERE Client_Name  LIKE '%" & search_box.Text & "%'", PlanPaymenDGV)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PlanPaymenDGV.CellClick
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        ids = PlanPaymenDGV.SelectedCells.Item(0).Value.ToString()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Client_Name,Month,Date,Plan_Payment_ID,OR_No,Amount,Balance FROM plan_payment WHERE Client_Name ='" & ids & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            plandate.Text = dr.GetString(2).ToString()
            OrNum.Text = dr.GetString(3).ToString()
            pdeposit.Text = dr.GetString(4).ToString()
            pbalance.Text = dr.GetString(5).ToString()

            month_CB.Text = dr.GetString(1).ToString()

            CNPlanP_CB.Text = dr.GetString(0).ToString()
            'Eto ung problema sa month invalid column ordinal


        End While
    End Sub


    Private Sub plandate_ValueChanged_1(sender As Object, e As EventArgs) Handles plandate.ValueChanged
        plandate.Format = DateTimePickerFormat.Custom
        plandate.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub pdeposit_TextChanged(sender As Object, e As EventArgs) Handles pdeposit.TextChanged
        If pdeposit.Text = "" Or pbalance.Text = "" Then
        Else
            Dim depositVal As Integer = pdeposit.Text
            Dim balanceVal As Integer = pbalance.Text
            Dim TOTAL As Integer = balanceVal - depositVal
            newbal.Text = (FormatNumber(TOTAL))

        End If
    End Sub

    Private Sub refresh_bttn_Click(sender As Object, e As EventArgs) Handles refresh_bttn.Click
        Try
            refresh_data("SELECT Client_Name,Month,Date,Plan_Payment_ID,I_N,OR_No,Amount,Balance FROM plan_payment", PlanPaymenDGV)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class