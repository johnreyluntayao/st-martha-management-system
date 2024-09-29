Public Class PlanFrame

    Public Sub addform(frm As Form)
        Try
            contentPanel.Controls.Clear()
            frm.TopMost = True
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            contentPanel.Controls.Add(frm)
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub change_form(menu As String)
        Select Case menu
            Case "AddPlan"
                addform(AddPlanForm)
            Case "AddPlanPayment"
                addform(AddPlanPayment)
            Case "AddPlanRecords"
                addform(PlanRecords)


        End Select
    End Sub

    Private Sub PlanFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub back_bttn_Click(sender As Object, e As EventArgs) Handles back_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
        conn.Close()
        DashboardFrame.Display_data()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub addplann_btn_Click(sender As Object, e As EventArgs) Handles addplann_btn.Click
        change_form("AddPlan")
    End Sub

    Private Sub planpayment_btn_Click(sender As Object, e As EventArgs) Handles planpayment_btn.Click
        change_form("AddPlanPayment")
    End Sub

    Private Sub planrecord_btn_Click(sender As Object, e As EventArgs) Handles planrecord_btn.Click
        change_form("AddPlanRecords")
    End Sub
End Class