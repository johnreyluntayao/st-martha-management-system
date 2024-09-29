Public Class PlanForm
    Private Sub planduedate_ValueChanged(sender As Object, e As EventArgs) Handles planduedate.ValueChanged
        planduedate.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub plan_bttn_Click(sender As Object, e As EventArgs) Handles plan_bttn.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO plan_client (Client_Name,Address,Name_of_Trustee,Date) VALUES('" + planclientname.Text + "','" + planaddress.Text + "','" + plannamekintrustee.Text + "','" + planDate.Text + "');
                           INSERT INTO plan (Plan_Name,Installment_Payment,Gross_Price,Term,Mode,Due_Date) VALUES('" + planname.Text + "','" + planinstallment.Text + "','" + plangrossprice.Text + "','" + planterm.Text + "','Monthly','" + planduedate.Text + "')"
        cmd.ExecuteNonQuery()
        planclientname.Text = ""
        planaddress.Text = ""
        plannamekintrustee.Text = ""
        planDate.Text = ""
        planname.Text = ""
        planinstallment.Text = ""
        plangrossprice.Text = ""
        planterm.Text = ""

        planduedate.Text = ""

        MessageBox.Show("Successfully inserted!")
    End Sub


End Class