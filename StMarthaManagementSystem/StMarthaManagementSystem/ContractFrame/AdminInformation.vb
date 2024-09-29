Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AdminInformation
    Dim ids As String

    Dim ms As New System.IO.MemoryStream
    Dim opF As New OpenFileDialog

    Private Sub AdminInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub uploadAuthorizedSig_bttn_Click(sender As Object, e As EventArgs) Handles uploadAuthorizedSig_bttn.Click
        opF.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
        If opF.ShowDialog = DialogResult.OK Then
            adminSigPic.Image = Image.FromFile(opF.FileName)
        End If
    End Sub

    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttn.Click

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        Dim AdminSigCMD As New MySqlCommand("UPDATE contractor SET `Contractor_Name`='" & adminName.Text & "',`Authorized_Signature`=@adminSig WHERE Contractor_ID='" & clientID_TB.Text & "'", conn)
        AdminSigCMD.Parameters.Add("@adminSig", MySqlDbType.LongBlob).Value = MS.ToArray()
        AdminSigCMD.ExecuteNonQuery()

        Me.Hide()
        NewContractPayment.Show()

    End Sub
End Class