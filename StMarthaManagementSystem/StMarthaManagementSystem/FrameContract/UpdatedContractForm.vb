Public Class UpdatedContractForm
    Private Sub ContractPrintBtn_Click(sender As Object, e As EventArgs) Handles ContractPrintBtn.Click
        PrintContractForm.Show()
        Me.Hide()
    End Sub
End Class