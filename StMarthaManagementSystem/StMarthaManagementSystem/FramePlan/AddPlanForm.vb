Imports MySql.Data.MySqlClient
Public Class AddPlanForm

    Dim gender As String
    Dim genderBind As String
    Private Sub proceed2Contract_bttn_Click(sender As Object, e As EventArgs) Handles proceed2Contract_bttn.Click
        Plan2ContractForm.Show()
    End Sub

    Private Sub planduedate_ValueChanged(sender As Object, e As EventArgs) Handles planduedate.ValueChanged
        planduedate.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub
    Private Sub plandate_ValueChanged(sender As Object, e As EventArgs) Handles plandate.ValueChanged
        plandate.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub
    Private Sub AddPlanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
        cmd.CommandText = "INSERT INTO plan_client (Client_Name,Gender,Address,Name_of_Trustee,Date) VALUES('" + planclientname1.Text + "','" + gender + "','" + planaddress1.Text + "','" + plannamekintrustee1.Text + "','" + plandate.Text + "');
                           INSERT INTO plan (Plan_Name,Installment_Payment,Gross_Price,Term,Mode,Due_Date) VALUES('" + planname1.Text + "','" + planinstallment1.Text + "','" + plangrossprice1.Text + "','" + planterm1.Text + "','Monthly','" + planduedate.Text + "')"
        cmd.ExecuteNonQuery()
        planclientname1.Text = ""
        planaddress1.Text = ""
        plannamekintrustee1.Text = ""
        planname1.Text = ""
        planinstallment1.Text = ""
        plangrossprice1.Text = ""
        planterm1.Text = ""
        planduedate.Text = ""
        radmale.Checked = False
        radfemale.Checked = False
        MessageBox.Show("Successfully inserted!")
    End Sub

    Private Sub planinstallment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles planinstallment1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub plangrossprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles plangrossprice1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub
End Class