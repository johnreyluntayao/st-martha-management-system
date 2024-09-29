Imports MySql.Data.MySqlClient
Public Class UpdateNewPlanForm
    Private Sub Home_bttn_Click(sender As Object, e As EventArgs) Handles Home_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub


    Dim gender As String



    Private Sub radmale_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub plansaveupdate_bttn_Click(sender As Object, e As EventArgs) Handles plansaveupdate_bttn.Click
        Try
            update_data("UPDATE `plan_client` SET Client_Name='" + planclientname.Text + "',Age='" + Age.Text + "',Gender='" + gender + "',Address='" + planaddress.Text + "',Name_of_Trustee='" + plannamekintrustee.Text + "',Date='" + plandate.Text + "' WHERE Client_ID='" + plantclient_ID.Text + "';
            UPDATE `plan` Set Plan_Name='" + planname.Text + "',Client_ID='" + plantclient_ID.Text + "',Installment_Payment='" + planinstallment.Text + "',Gross_Price='" + plangrossprice.Text + "',Term='" + planterm.Text + "',Due_Date='" + planduedate.Text + "' WHERE Plan_ID= '" + plantclient_ID.Text + "'")
            Me.Hide()
            NewPlanRecord.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UpdateNewPlanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        plantclient_ID.Text = NewPlanRecord.selectedrow.Cells(0).Value.ToString
        planclientname.Text = NewPlanRecord.selectedrow.Cells(1).Value.ToString
        Age.Text = NewPlanRecord.selectedrow.Cells(2).Value.ToString
        planaddress.Text = NewPlanRecord.selectedrow.Cells(3).Value.ToString
        If NewPlanRecord.selectedrow.Cells(4).Value.ToString() = "Male" Then
            radmale.Checked = True
            radfemale.Checked = False
        ElseIf NewPlanRecord.selectedrow.Cells(4).Value.ToString() = "Female" Then
            radfemale.Checked = True
            radmale.Checked = False
        End If
        plannamekintrustee.Text = NewPlanRecord.selectedrow.Cells(5).Value.ToString
        plandate.Text = NewPlanRecord.selectedrow.Cells(6).Value.ToString
        planname.Text = NewPlanRecord.selectedrow.Cells(7).Value.ToString
        planinstallment.Text = NewPlanRecord.selectedrow.Cells(8).Value.ToString
        plangrossprice.Text = NewPlanRecord.selectedrow.Cells(9).Value.ToString
        planterm.Text = NewPlanRecord.selectedrow.Cells(10).Value.ToString
        planduedate.Text = NewPlanRecord.selectedrow.Cells(12).Value.ToString

    End Sub


End Class