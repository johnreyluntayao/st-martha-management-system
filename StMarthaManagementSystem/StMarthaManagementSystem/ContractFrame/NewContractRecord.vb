
Imports MySql.Data.MySqlClient
Public Class NewContractRecord

    Private Sub NewContractRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        disp_data()
    End Sub
    Private Sub Home_bttn_Click(sender As Object, e As EventArgs) Handles Home_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Public Sub disp_data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        'client packages and other attributes
        cmd.CommandText = "SELECT deceased_information.Name_of_Deceased,deceased_information.Date_of_Death,contract_client.Client_Name As Conform_Name,contract_client.Date FROM deceased_information INNER JOIN contract_client ON deceased_information.Deceased_ID = contract_client.Client_ID"


        '"SELECT contract_client.Client_Name,contract_client.Age,contract_client.Contact_Number,contract_client.Address,contract_client.Relationship_to_the_Deceased,contract_client.Date,contract_client.Contractee_Signature,deceased_information.Name_of_Deceased,deceased_information.Date_of_Death,deceased_information.Age,deceased_information.Birthdate,deceased_information.Complete_Address,add_packages.Package_Name,add_packages.Package_Inclusions FROM contract_client INNER JOIN deceased_information ON contract_client.Client_ID = deceased_information.Deceased_ID INNER JOIN add_packages ON deceased_information.Deceased_ID = add_packages.add_package_ID;"

        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        ContractRecord.DataSource = dt


    End Sub

    Private Sub ContractRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ContractRecord.CellClick
        Me.Hide()
        UpdateNewContractRecord.Show()

    End Sub

    Private Sub ContractRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ContractRecord.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub
End Class