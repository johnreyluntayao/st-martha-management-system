
Imports MySql.Data.MySqlClient
Public Class UpdateNewContractRecord

    Dim id As String


    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub

    Private Sub Home_bttn_Click(sender As Object, e As EventArgs) Handles Home_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttn.Click

    End Sub

    Private Sub UpdateNewContractRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        id = NewContractRecord.ContractRecord.SelectedCells.Item(0).Value.ToString()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT deceased_information.Deceased_ID,deceased_information.Name_of_Deceased,deceased_information.Date_of_Death,deceased_information.Age,deceased_information.Complete_Address,deceased_information.Birthdate,contract_client.Client_Name,contract_client.Date,contract_client.Age,contract_client.Address,contract_client.Relationship_to_the_Deceased,contract_client.Contact_Number,contract_client.Contractee_Signature,contract.Total_Amount FROM deceased_information INNER JOIN contract_client ON deceased_information.Deceased_ID = contract_client.Client_ID INNER JOIN contract ON contract_client.Client_ID = contract.Contract_ID WHERE deceased_information.Deceased_ID='" & id & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            namedeceased.Text = dr.GetString(1).ToString()
            deceaseddatedeath.Text = dr.GetString(2).ToString()
            deceasedage.Text = dr.GetString(3).ToString()
            deceasedaddress.Text = dr.GetString(4).ToString()
            deceasedbirthdate.Text = dr.GetString(5).ToString()
            ClientNameC.Text = dr.GetString(6).ToString()
            datecontract.Text = dr.GetString(7).ToString()
            age.Text = dr.GetString(8).ToString()
            address.Text = dr.GetString(9).ToString()
            relationship.Text = dr.GetString(10).ToString()
            contactnumber.Text = dr.GetString(11).ToString()
            clientSigPic.Text = dr.GetString(12).ToString()
            totalamountC.Text = dr.GetString(13).ToString()
        End While

    End Sub

    Private Sub UpdateNewContractRecord_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged

        id = NewContractRecord.ContractRecord.SelectedCells.Item(0).Value.ToString()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT deceased_information.Deceased_ID,deceased_information.Name_of_Deceased,deceased_information.Date_of_Death,deceased_information.Age,deceased_information.Complete_Address,deceased_information.Birthdate,contract_client.Client_Name,contract_client.Date,contract_client.Age,contract_client.Address,contract_client.Relationship_to_the_Deceased,contract_client.Contact_Number,contract_client.Contractee_Signature,contract.Total_Amount FROM deceased_information INNER JOIN contract_client ON deceased_information.Deceased_ID = contract_client.Client_ID INNER JOIN contract ON contract_client.Client_ID = contract.Contract_ID WHERE deceased_information.Deceased_ID='" & id & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            namedeceased.Text = dr.GetString(1).ToString()
            deceaseddatedeath.Text = dr.GetString(2).ToString()
            deceasedage.Text = dr.GetString(3).ToString()
            deceasedaddress.Text = dr.GetString(4).ToString()
            deceasedbirthdate.Text = dr.GetString(5).ToString()
            ClientNameC.Text = dr.GetString(6).ToString()
            datecontract.Text = dr.GetString(7).ToString()
            age.Text = dr.GetString(8).ToString()
            address.Text = dr.GetString(9).ToString()
            relationship.Text = dr.GetString(10).ToString()
            contactnumber.Text = dr.GetString(11).ToString()
            clientSigPic.Text = dr.GetString(12).ToString()
            totalamountC.Text = dr.GetString(13).ToString()
        End While

    End Sub



    'Query for update
    'UPDATE `deceased_information` SET `Name_of_Deceased`='" & namedeceased.Text & "',`Date_of_Death`='" & deceaseddatedeath.Text &"',`Age`='" &  deceasedage.Text & "',`Birthdate`='" & deceasedbirthdate.Text & "',`Complete_Address`='" &  deceasedaddress.Text & "' WHERE `Deceased_ID`='" & clientID_TB.Text & "';
    'UPDATE `contract_client` SET `Client_Name`='" & ClientNameC.Text & "',`Relationship_to_the_Deceased`='" & relationship.Text & "',`Age`='" & age.Text & "',`Contact_Number`='" & contactnumber.Text & "',`Address`='" & address.Text & "',`Contractee_Signature`='" & clientSigPic.Text & "',`Date`='" & datecontract.Text & "' WHERE `Client_ID`='" & clientID_TB.Text & "';
    'UPDATE `contract` SET `Total_Amount`= '" & totalamountC.Text & "'
End Class