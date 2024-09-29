Imports MySql.Data.MySqlClient
Public Class AddPlanPayment
    Dim da As MySqlDataAdapter
    Dim dset As New DataSet
    Dim ids As String

    Private Sub AddPlanPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        auto_suggest("Client_Name", "plan_client", CNPlanP_CBMA)


        dtadapter = New MySqlDataAdapter("SELECT * FROM plan_client", conn)
        dataSet = New DataSet
        dtadapter.Fill(dataSet, "plan_client")
        Dim count As Integer = dataSet.Tables("plan_client").Rows.Count
        Dim x As Integer
        For x = 0 To count - 1
            CNPlanP_CBMA.Items.Add(dataSet.Tables("plan_client").Rows(x).Item("Client_Name"))
        Next

        auto_suggest("Client_Name", "plan_client", CNPlanP_CBMA)


        dtadapter = New MySqlDataAdapter("SELECT * FROM month", conn)
        dataSet = New DataSet
        dtadapter.Fill(dataSet, "month")
        Dim counts As Integer = dataSet.Tables("month").Rows.Count
        Dim y As Integer
        For y = 0 To counts - 1
            month_CBM.Items.Add(dataSet.Tables("month").Rows(y).Item("Months"))
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
        DataGridView1M.DataSource = dt
    End Sub

    Private Sub clientnamePlanpayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CNPlanP_CBMA.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text

        'autofill
        cmd.CommandText = "SELECT * FROM plan_client WHERE Client_Name='" & CNPlanP_CBMA.Text & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)


        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            pbalanceM.Text = dr.GetString(6).ToString()
        End While

        'Kailangang baguhin ang IN kase kung nakatutuk sya sa ID ay mag iinremet sya kahit ibang customer na ang iinput
        Dim getID As New MySqlCommand("SELECT Client_ID FROM plan_client WHERE Client_Name = '" & CNPlanP_CBMA.Text & "'", conn)
        Dim gets = Convert.ToString(getID.ExecuteScalar)
        IDMM.Text = gets
        planidMM.Text = gets

        Dim getClient As New MySqlCommand("SELECT COUNT(Client_Name) FROM plan_payment WHERE Client_Name = '" & CNPlanP_CBMA.Text & "'", conn)
        Dim countx = Convert.ToString(getClient.ExecuteScalar)
        andreiMM.Text = countx + 1
        conn.Close()

    End Sub

    Private Sub month_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles month_CBM.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim monthCommand As New MySqlCommand
        monthCommand = conn.CreateCommand()
        monthCommand.CommandType = CommandType.Text
        monthCommand.CommandText = "SELECT * FROM month WHERE Months='" & month_CBM.Text & "'"
        monthCommand.ExecuteNonQuery()

        Dim getIDs As New MySqlCommand("SELECT Month_ID FROM month WHERE Months = '" & month_CBM.Text & "'", conn)
        Dim getss = Convert.ToString(getIDs.ExecuteScalar)
        monthidMM.Text = getss

        conn.Close()


    End Sub

    Private Sub plandate_ValueChanged(sender As Object, e As EventArgs)
        plandateM.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub pdeposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pdepositM.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub pbalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pbalanceM.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub planPayment_saveBttn_Click(sender As Object, e As EventArgs) Handles planPayment_saveBttnM.Click

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        'Lagyan mo na dito ng automation na auto bawas sa balance kapag nag huhulog 
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO `plan_payment`(`Client_ID`, `Plan_ID`, `Month_ID`, `Client_Name`, `Month`, `Date`, `I_N`, `OR_No`, `Amount`, `Balance`) VALUES ('" + IDMM.Text + "','" + planidMM.Text + "','" + monthidMM.Text + "','" + CNPlanP_CBMA.Text + "','" + month_CBM.Text + "','" + plandateM.Text + "','" + andreiMM.Text + "','" + Guna2TextBox2M.Text + "','" + pdepositM.Text + "','" + newbalA.Text + "');
                                "
        cmd.ExecuteNonQuery()

        CNPlanP_CBMA.Text = ""
        month_CBM.Text = ""
        Guna2TextBox2M.Text = ""
        pdepositM.Text = ""
        pbalanceM.Text = ""
        newbalA.Text = ""

        MessageBox.Show("Successfully inserted!")
        conn.Close()
        disp_data()



    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles SearchM.TextChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Client_Name,Month,Date,Plan_Payment_ID,OR_No,Amount,Balance FROM plan_payment WHERE Client_Name = '" + SearchM.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1M.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1M.CellClick
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        ids = DataGridView1M.SelectedCells.Item(0).Value.ToString()
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
            plandateM.Text = dr.GetString(2).ToString()
            Guna2TextBox2M.Text = dr.GetString(3).ToString()
            pdepositM.Text = dr.GetString(4).ToString()
            pbalanceM.Text = dr.GetString(5).ToString()

            month_CBM.Text = dr.GetString(1).ToString()

            CNPlanP_CBMA.Text = dr.GetString(0).ToString()
            'Eto ung problema sa month invalid column ordinal


        End While
    End Sub


    Private Sub plandate_ValueChanged_1(sender As Object, e As EventArgs) Handles plandateM.ValueChanged
        plandateM.Format = DateTimePickerFormat.Custom
        plandateM.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub pdeposit_TextChanged(sender As Object, e As EventArgs) Handles pdepositM.TextChanged
        If pdepositM.Text = "" Or pbalanceM.Text = "" Then
        Else
            Dim depositVal As Integer = pdepositM.Text
            Dim balanceVal As Integer = pbalanceM.Text
            Dim TOTAL As Integer = balanceVal - depositVal
            newbalA.Text = (FormatNumber(TOTAL))

        End If
    End Sub

    Private Sub DataGridView1M_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1M.CellContentClick

    End Sub
End Class