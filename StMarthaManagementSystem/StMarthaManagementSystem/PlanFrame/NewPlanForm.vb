
Imports MySql.Data.MySqlClient

Public Class NewPlanForm
    Private Sub Home_bttn_Click(sender As Object, e As EventArgs) Handles Home_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub

    Private Sub Age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Age.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub


    Dim gender As String


    Private Sub radmale_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub plansave_bttn_Click(sender As Object, e As EventArgs) Handles plansave_bttn.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO plan_client (Client_Name,Age,Gender,Address,Name_of_Trustee,Date) VALUES('" + planclientname.Text + "','" + Age.Text + "','" + gender + "','" + planaddress.Text + "','" + plannamekintrustee.Text + "','" + plandate.Text + "');
                           INSERT INTO plan (Plan_Name,Installment_Payment,Gross_Price,Term,Mode,Due_Date) VALUES('" + planname.Text + "','" + planinstallment.Text + "','" + plangrossprice.Text + "','" + planterm.Text + "','Monthly','" + planduedate.Text + "')"
        cmd.ExecuteNonQuery()
        NewPaymentPlan.CNPlanP_CB.Text = planclientname.Text
        NewPaymentPlan.pbalance.Text = plangrossprice.Text
        NewPaymentPlan.plandate.Text = plandate.Text
        planclientname.Text = ""
        planaddress.Text = ""
        plannamekintrustee.Text = ""
        planname.Text = ""
        planinstallment.Text = ""
        plangrossprice.Text = ""
        planterm.Text = ""
        planduedate.Text = ""
        radmale.Checked = False
        radfemale.Checked = False


        MessageBox.Show("Successfully inserted!")
        NewPaymentPlan.Show()
    End Sub

    Private Sub planinstallment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles planinstallment.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub plangrossprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles plangrossprice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        NewPlanRecord.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click
        NewPaymentPlan.Show()
        Me.Hide()
    End Sub
End Class
