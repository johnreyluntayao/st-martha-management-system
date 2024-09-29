Public Class ManageDocFrame
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True

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

            Case "AddContractForm"
                addform(ContractInformation)
            Case "AddContractPaymentForm"
                addform(ContractPaymentForm)
            Case "ContractRecords"
                ' addform(ContractRecord)


        End Select
    End Sub


    Private Sub addcontract_btn_Click(sender As Object, e As EventArgs) Handles addcontract_btn.Click
        change_form("AddContractForm")
        conn.Close()
    End Sub
    Private Sub contractPayment_btn_Click(sender As Object, e As EventArgs) Handles contractPayment_btn.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        change_form("AddContractPaymentForm")

    End Sub

    Private Sub contractRecords_bttn_Click(sender As Object, e As EventArgs) Handles contractRecords_bttn.Click
        change_form("ContractRecords")
        conn.Close()
    End Sub

    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        Login.Show()
        Me.Hide()
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

    Private Sub ManageDocFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    ' Private Sub payment_Click(sender As Object, e As EventArgs)
    '       isCollapsed2 = False
    '       Timer1.Start()
    '   End Sub

    '  Private Sub contentPanel_Paint(sender As Object, e As PaintEventArgs) Handles contentPanel.Paint
    '      PaymentPanel.Size = PaymentPanel.MinimumSize
    '  End Sub

    '  Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
    'If isCollapsed Then
    '        PaymentPanel.Height += 10
    'If PaymentPanel.Size = PaymentPanel.MaximumSize Then
    '            Timer1.Stop()
    '            isCollapsed = False
    'End If
    'Else
    '       PaymentPanel.Height -= 10
    'If PaymentPanel.Size = PaymentPanel.MinimumSize Then
    '            Timer1.Stop()
    ' '           isCollapsed = True
    ' End If
    ' End If
    '  End Sub


End Class