Public Class RecordFrame
    Private Sub back_bttn_Click(sender As Object, e As EventArgs) Handles back_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub


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
            Case "ClientRec"
                addform(ClientRecord)
           ' Case "ContractRec"
             '   addform(ContractRecord)
            Case "ContractPaymentRec"
                addform(ContractPaymentRecord)
            Case "PlanRec"
                addform(PlanRecord)
            Case "PlanPaymentRec"
                addform(PlanPaymentRecord)

        End Select
    End Sub
    Private Sub clientrec_btn_Click(sender As Object, e As EventArgs) Handles clientrec_btn.Click
        change_form("ClientRec")
        conn.Close()
    End Sub

    Private Sub contractrec_btn_Click(sender As Object, e As EventArgs) Handles contractrec_btn.Click
        change_form("ContractRec")
        conn.Close()
    End Sub

    Private Sub contractprec_btn_Click(sender As Object, e As EventArgs) Handles contractprec_btn.Click
        change_form("ContractPaymentRec")
        conn.Close()
    End Sub

    Private Sub planrec_btn_Click(sender As Object, e As EventArgs) Handles planrec_btn.Click
        change_form("PlanRec")
        conn.Close()
    End Sub

    Private Sub planprec_btn_Click(sender As Object, e As EventArgs) Handles planPprec_btn.Click
        change_form("PlanPaymentRec")
        conn.Close()
    End Sub


End Class