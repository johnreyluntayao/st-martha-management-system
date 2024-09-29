Imports MySql.Data.MySqlClient

Public Class ContractRecordM

    Dim ids As String
    Private Sub ContractRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        disp_data()
    End Sub

    Public Sub disp_data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        'client packages and other attributes
        cmd.CommandText = "SELECT contract_client.Client_Name,contract_client.Age,contract_client.Contact_Number,contract_client.Address,contract_client.Relationship_to_the_Deceased,contract_client.Date,contract_client.Contractee_Signature,deceased_information.Name_of_Deceased,deceased_information.Date_of_Death,deceased_information.Age,deceased_information.Birthdate,deceased_information.Complete_Address,add_packages.Package_Name,add_packages.Package_Inclusions FROM contract_client INNER JOIN deceased_information ON contract_client.Client_ID = deceased_information.Deceased_ID INNER JOIN add_packages ON deceased_information.Deceased_ID = add_packages.add_package_ID;"

        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        contractRecDGV.DataSource = dt
    End Sub

    Private Sub contractRecDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles contractRecDGV.CellClick

        Me.Hide()
        UpdateContractInformation.Show()




    End Sub

    Private Sub contractRecDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles contractRecDGV.CellContentClick

    End Sub
End Class