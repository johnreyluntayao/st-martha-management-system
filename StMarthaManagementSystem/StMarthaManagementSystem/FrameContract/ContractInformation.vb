Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ContractInformation

    Dim ms As New System.IO.MemoryStream
    Dim opF As New OpenFileDialog

    Private Sub selectPackages_Click(sender As Object, e As EventArgs) Handles selectPackagesM.Click
        Packages.Show()
    End Sub


    Private Sub ContractInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' auto_suggest("Client_Name", "contract_client", clientName_CB)
        'autofill in tb
        '   dtadapter = New MySqlDataAdapter("SELECT * FROM contract_client", conn)
        '    dataSet = New DataSet
        '    dtadapter.Fill(dataSet, "contract_client")
        '    Dim count As Integer = dataSet.Tables("contract_client").Rows.Count
        '     Dim x As Integer
        '     For x = 0 To count - 1
        '     clientName_CB.Items.Add(dataSet.Tables("contract_client").Rows(x).Item("Client_Name"))
        '      Next

        datecontractM.Text = DateTime.Now.ToString("MM/dd/yyyy")

    End Sub


    'combobox clientname autosuggest
    '  Private Sub clientName_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clientName_CB.SelectedIndexChanged

    '      If conn.State = ConnectionState.Open Then
    '          conn.Close()
    '       End If
    '      conn.Open()
    '    cmd = conn.CreateCommand()
    '     cmd.CommandType = CommandType.Text

    'autofill
    '     cmd.CommandText = "SELECT * FROM contract_client WHERE Client_Name='" & clientName_CB.Text & "'"
    '    cmd.ExecuteNonQuery()
    '     Dim dt As New DataTable()
    '    Dim da As New MySqlDataAdapter(cmd)
    '    da.Fill(dt)

    '    Dim dr As MySqlDataReader
    '     dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    '     While dr.Read
    '        clientID_TB.Text = dr.GetString(0).ToString()
    '        age.Text = dr.GetString(3).ToString()
    '        contactnumber.Text = dr.GetString(4).ToString()
    '         address.Text = dr.GetString(5).ToString()
    '      End While
    '      conn.Close()
    '   End Sub

    Private Sub uploadClientSig_bttn_Click(sender As Object, e As EventArgs) Handles uploadClientSig_bttnM.Click
        opF.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
        If opF.ShowDialog = DialogResult.OK Then
            clientSigPicM.Image = Image.FromFile(opF.FileName)
        End If
    End Sub

    Private Sub uploadAuthorizedSig_bttn_Click(sender As Object, e As EventArgs) Handles uploadAuthorizedSig_bttn.Click
        opF.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
        If opF.ShowDialog = DialogResult.OK Then
            adminSigPic.Image = Image.FromFile(opF.FileName)
        End If
    End Sub
    Private Sub datecontract_ValueChanged(sender As Object, e As EventArgs) Handles datecontractM.ValueChanged
        datecontractM.Format = DateTimePickerFormat.Custom
        datecontractM.CustomFormat = "yyyy/MM/dd"

    End Sub
    Private Sub deceasedbirthdate_ValueChanged(sender As Object, e As EventArgs) Handles deceasedbirthdate.ValueChanged
        deceasedbirthdate.Format = DateTimePickerFormat.Custom
        deceasedbirthdate.CustomFormat = "yyyy/MM/dd"
        deceasedbirthdate.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub
    Private Sub deceaseddatedeath_ValueChanged(sender As Object, e As EventArgs) Handles deceaseddatedeath.ValueChanged
        deceaseddatedeath.Format = DateTimePickerFormat.Custom
        deceaseddatedeath.CustomFormat = "yyyy/MM/dd"
        deceaseddatedeath.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub
    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttnM.Click

        'orig query
        ' Dim ClientSigCMD As New MySqlCommand("UPDATE contract_client SET `Contractee_Signature`=@clientSig WHERE `Client_Name`='" & clientName_CB.Text & "'", conn)
        ' Dim AdminSigCMD As New MySqlCommand("UPDATE admin SET `Authorized_Signature`=@adminSig WHERE `Admin_ID`=1", conn)


        'test query
        Dim ClientSigCMD As New MySqlCommand("UPDATE contract_client SET `Contractee_Signature`=@clientSig WHERE `Client_ID`='" & clientID_TB.Text & "'", conn)
        Dim AdminSigCMD As New MySqlCommand("UPDATE admin SET `Authorized_Signature`=@adminSig WHERE `Admin_ID`=1", conn)


        'dupli admin 
        '  Dim AdminSigCMD As New MySqlCommand("INSERT INTO admin (`Authorized_Signature`) VALUES (@adminSig)", conn)


        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        'Updating Client Info
        'Ayo ko na



        'orig query
        ' cmd.CommandText = "UPDATE contract_client SET `Client_Name`='" & clientName_CB.Text & "', `Age`='" & age.Text & "',`Contact_Number`='" & contactnumber.Text & "',`Address`='" & address.Text & "',`Relationship_to_the_Deceased`='" & relationship.Text & "',`Date`='" & datecontract.Text & "' WHERE `Client_Name`='" & clientName_CB.Text & "';
        '  INSERT INTO deceased_information (`Client_ID`,`Name_of_Deceased`,`Date_of_Death`,`Age`,`Birthdate`,`Complete_Address`) VALUES ('" & clientID_TB.Text & "','" & namedeceased.Text & "','" & deceaseddatedeath.Text & "','" & deceasedage.Text & "','" & deceasedbirthdate.Text & "','" & deceasedaddress.Text & "');
        '  Update contract_payment SET `Total_Amount`='" & totalamountC.Text & "' WHERE `Client_ID`='" & clientID_TB.Text & "';
        '  INSERT INTO contract (Admin_ID,Client_ID,Deceased_ID,Add_Package_ID,Payment_ID)
        '  Select Case admin.Admin_ID,contract_client.Client_ID,deceased_information.Deceased_ID,add_packages.Add_Package_ID,contract_payment.Payment_ID FROM contract_client,deceased_information,add_packages,contract_payment,admin WHERE (SELECT MAX(Client_ID) FROM contract_client AND  = deceased_information.Deceased_ID AND contract_client.Client_ID = add_packages.Add_Package_ID AND contract_payment.Payment_ID = contract_client.Client_ID AND admin.Admin_ID = '1';"

        'testquery
        cmd.CommandText = "UPDATE contract_client SET `Client_Name`='" & ClientNameCM.Text & "', `Age`='" & age.Text & "',`Contact_Number`='" & contactnumberM.Text & "',`Address`='" & addressM.Text & "',`Relationship_to_the_Deceased`='" & relationshipM.Text & "',`Date`='" & datecontractM.Text & "' WHERE `Client_ID`='" & clientID_TB.Text & "';
            UPDATE `deceased_information` SET `Client_ID`='" & clientID_TB.Text & "',`Name_of_Deceased`='" & namedeceased.Text & "',`Date_of_Death`='" & deceaseddatedeath.Text & "',`Age`='" & deceasedage.Text & "',`Birthdate`='" & deceasedbirthdate.Text & "',`Complete_Address`='" & deceasedaddress.Text & "'WHERE `Deceased_ID`='" & clientID_TB.Text & "';
            UPDATE `contract_payment` SET `Add_Package_ID`='" & clientID_TB.Text & "',`Services_ID`='" & clientID_TB.Text & "',`Client_ID`='" & clientID_TB.Text & "',`Add_Ons_ID`='" & clientID_TB.Text & "',`Contract_ID`='" & clientID_TB.Text & "', `Client_Name`='" & ClientNameCM.Text & "' WHERE `Payment_ID`='" & clientID_TB.Text & "';
            UPDATE `contract` SET `Admin_ID`='1',`Client_ID`='" & clientID_TB.Text & "',`Deceased_ID`='" & clientID_TB.Text & "',`Add_Package_ID`='" & clientID_TB.Text & "',`Plan_ID`=NULL,`Total_Amount`='" & totalamountC.Text & "' WHERE Contract_ID='" & clientID_TB.Text & "'"



        'INSERT INTO contract (Admin_ID,Client_ID,Deceased_ID,Add_Package_ID,Payment_ID)
        'SELECT admin.Admin_ID,contract_client.Client_ID,deceased_information.Deceased_ID,add_packages.Add_Package_ID,contract_payment.Payment_ID FROM contract_client,deceased_information,add_packages,contract_payment,admin WHERE Contract_ID = contract_client.Client_ID AND Contract_ID = deceased_information.Deceased_ID AND Contract_ID = add_packages.Add_Package_ID AND Contract_ID = contract_payment.Payment_ID AND admin.Admin_ID = '1';"


        'SELECT admin.Admin_ID,contract_client.Client_ID,deceased_information.Deceased_ID,add_packages.Add_Package_ID,contract_payment.Payment_ID FROM contract_client,deceased_information,add_packages,contract_payment,admin WHERE contract.Contract_ID = contract_client.Client_ID AND contract.Contract_ID = deceased_information AND contract.Contract_ID = deceased_information.Deceased_ID AND contract.Contract_ID = add_packages.Add_Package_ID AND contract.Contract_ID = contract_payment.Payment_ID AND admin.Admin_ID = '1'"

        'INSERT INTO `contract`(`Admin_ID`, `Client_ID`, `Deceased_ID`, `Add_Package_ID`, `Payment_ID`, `Plan_ID`) VALUES ('1','" & clientID_TB.Text & "','" & clientID_TB.Text & "','" & clientID_TB.Text & "','" & clientID_TB.Text & "','NULL')

        '   UPDATE contract_payment SET `Contract_ID`='" & clientID_TB.Text & "'
        'UPDATE contract_client SET `Relationship_to_the_Deceased`='" & relationship.Text & "', `Date`='" & datecontract.Text & "' WHERE `Client_Name`='" & clientName_CB.Text & "';
        'INSERT INTO deceased_information (`Name_of_Deceased`,`Date_of_Death`,`Age`,`Birthdate`,`Complete_Address` VALUES '" & namedeceased.Text & "','" & deceaseddatedeath.Text & "','" & age.Text & "','" & deceasedbirthdate.Text & "','" & deceasedaddress.Text & "' WHERE `Client_Name`='" & clientName_CB.Text & "' FROM contract_client";

        'Inserting Image
        clientSigPicM.Image.Save(ms, clientSigPicM.Image.RawFormat)
        adminSigPic.Image.Save(ms, adminSigPic.Image.RawFormat)
        ClientSigCMD.Parameters.Add("@clientSig", MySqlDbType.LongBlob).Value = ms.ToArray()
        AdminSigCMD.Parameters.Add("@adminSig", MySqlDbType.LongBlob).Value = ms.ToArray()
        ClientSigCMD.ExecuteNonQuery()
        AdminSigCMD.ExecuteNonQuery()
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Successully Added!!!")
            '      clientName_CB.Text = ""
            clientID_TB.Clear()
            ClientNameCM.Clear()
            age.Clear()
            relationshipM.Clear()
            contactnumberM.Clear()
            addressM.Clear()
            namedeceased.Clear()
            age.Clear()
            deceasedaddress.Clear()
            namedeceased.Clear()
            deceasedage.Clear()
            totalamountC.Clear()
            clientSigPicM.Image = Nothing
            adminSigPic.Image = Nothing
            update_PackagesCM.Visible = False
            selectPackagesM.Visible = True

        Else
            MessageBox.Show("Select Package First!")
        End If

        conn.Close()
    End Sub

    Private Sub clear_bttn_Click(sender As Object, e As EventArgs) Handles clear_bttnM.Click
        '   clientName_CB.Text = ""
        clientID_TB.Clear()
        age.Clear()
        contactnumberM.Clear()
        addressM.Clear()
        namedeceased.Clear()
        age.Clear()
        deceasedaddress.Clear()
        namedeceased.Clear()
        deceasedage.Clear()
        totalamountC.Clear()
        '  packageCB.Text = CheckState.Unchecked
        clientSigPicM.Image = Nothing
        adminSigPic.Image = Nothing

    End Sub

    Private Sub contactnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contactnumberM.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If

    End Sub

    Private Sub age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles age.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If

    End Sub
    Private Sub deceasedage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles deceasedage.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If

    End Sub

    Private Sub relationship_KeyPress(sender As Object, e As KeyPressEventArgs) Handles relationshipM.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Letters Only")
        End If

    End Sub

    Private Sub totalamountC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles totalamountC.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If

    End Sub

    Private Sub update_Packages_Click(sender As Object, e As EventArgs) Handles update_PackagesCM.Click
        UpdatePackages.Show()
        selectPackagesM.Visible = False
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class