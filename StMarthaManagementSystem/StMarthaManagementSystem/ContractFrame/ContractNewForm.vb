Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ContractNewForm

    Private Sub Home_bttn_Click(sender As Object, e As EventArgs) Handles Home_bttn.Click
        DashboardFrame.Show()
        Me.Hide()
    End Sub

    Private Sub close_bttn_Click(sender As Object, e As EventArgs) Handles close_bttn.Click
        Application.Exit()
    End Sub


    Dim ms As New System.IO.MemoryStream
    Dim opF As New OpenFileDialog

    Private Sub selectPackages_Click(sender As Object, e As EventArgs) Handles selectPackages.Click
        Packages.Show()
    End Sub


    Private Sub ContractInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        datecontract.Text = DateTime.Now.ToString("MM/dd/yyyy")

    End Sub


    Private Sub uploadClientSig_bttn_Click(sender As Object, e As EventArgs) Handles uploadClientSig_bttn.Click
        opF.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
        If opF.ShowDialog = DialogResult.OK Then
            clientSigPic.Image = Image.FromFile(opF.FileName)
        End If
    End Sub

    Private Sub datecontract_ValueChanged(sender As Object, e As EventArgs) Handles datecontract.ValueChanged
        datecontract.Format = DateTimePickerFormat.Custom
        datecontract.CustomFormat = "yyyy/MM/dd"

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
    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttn.Click

        Dim ClientSigCMD As New MySqlCommand("UPDATE contract_client SET `Contractee_Signature`=@clientSig WHERE `Client_ID`='" & clientID_TB.Text & "'", conn)

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandText = "UPDATE contract_client SET `Client_Name`='" & ClientNameC.Text & "', `Age`='" & age.Text & "',`Contact_Number`='" & contactnumber.Text & "',`Address`='" & address.Text & "',`Relationship_to_the_Deceased`='" & relationship.Text & "',`Date`='" & datecontract.Text & "' WHERE `Client_ID`='" & clientID_TB.Text & "';
            UPDATE `deceased_information` SET `Client_ID`='" & clientID_TB.Text & "',`Name_of_Deceased`='" & namedeceased.Text & "',`Date_of_Death`='" & deceaseddatedeath.Text & "',`Age`='" & deceasedage.Text & "',`Birthdate`='" & deceasedbirthdate.Text & "',`Complete_Address`='" & deceasedaddress.Text & "'WHERE `Deceased_ID`='" & clientID_TB.Text & "';
            UPDATE `contract_payment` SET `Add_Package_ID`='" & clientID_TB.Text & "',`Services_ID`='" & clientID_TB.Text & "',`Client_ID`='" & clientID_TB.Text & "',`Add_Ons_ID`='" & clientID_TB.Text & "',`Contract_ID`='" & clientID_TB.Text & "', `Client_Name`='" & ClientNameC.Text & "' WHERE `Payment_ID`='" & clientID_TB.Text & "';
            UPDATE `contract` SET `Admin_ID`='1',`Client_ID`='" & clientID_TB.Text & "',`Deceased_ID`='" & clientID_TB.Text & "',`Add_Package_ID`='" & clientID_TB.Text & "',`Contractor_ID`='" & clientID_TB.Text & "',`Total_Amount`='" & totalamountC.Text & "' WHERE Contract_ID='" & clientID_TB.Text & "'"



        'Inserting Image
        clientSigPic.Image.Save(ms, clientSigPic.Image.RawFormat)
        '  adminSigPic.Image.Save(ms, adminSigPic.Image.RawFormat)
        ClientSigCMD.Parameters.Add("@clientSig", MySqlDbType.LongBlob).Value = ms.ToArray()
        ' AdminSigCMD.Parameters.Add("@adminSig", MySqlDbType.LongBlob).Value = ms.ToArray()
        ClientSigCMD.ExecuteNonQuery()
        ' AdminSigCMD.ExecuteNonQuery()
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Successully Added!!!")
            '      clientName_CB.Text = ""
            clientID_TB.Clear()
            ClientNameC.Clear()
            age.Clear()
            relationship.Clear()
            contactnumber.Clear()
            address.Clear()
            namedeceased.Clear()
            age.Clear()
            deceasedaddress.Clear()
            namedeceased.Clear()
            deceasedage.Clear()
            totalamountC.Clear()
            clientSigPic.Image = Nothing
            '      adminSigPic.Image = Nothing
            update_PackagesCM.Visible = False
            selectPackages.Visible = True
            AdminInformation.Show()
        Else
            MessageBox.Show("Select Package First!")
        End If



        conn.Close()
    End Sub

    Private Sub clear_bttn_Click(sender As Object, e As EventArgs) Handles clear_bttn.Click
        '   clientName_CB.Text = ""
        clientID_TB.Clear()
        age.Clear()
        contactnumber.Clear()
        address.Clear()
        namedeceased.Clear()
        age.Clear()
        deceasedaddress.Clear()
        namedeceased.Clear()
        deceasedage.Clear()
        totalamountC.Clear()
        '  packageCB.Text = CheckState.Unchecked
        clientSigPic.Image = Nothing
        '  adminSigPic.Image = Nothing

    End Sub

    Private Sub contactnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contactnumber.KeyPress
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

    Private Sub relationship_KeyPress(sender As Object, e As KeyPressEventArgs) Handles relationship.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Letters Only")
        End If

    End Sub

    Private Sub totalamountC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles totalamountC.KeyPress

    End Sub

    Private Sub update_Packages_Click(sender As Object, e As EventArgs) Handles update_PackagesCM.Click
        UpdatePackages.Show()
        selectPackages.Visible = False
    End Sub

    Private Sub clientID_TB_TextChanged(sender As Object, e As EventArgs) Handles clientID_TB.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click
        conn.Close()
        Me.Hide()
        NewContractPayment.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click


        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        If clientID_TB.Text = Nothing Then
            clientID_TB.Clear()
            age.Clear()
            contactnumber.Clear()
            address.Clear()
            namedeceased.Clear()
            age.Clear()
            deceasedaddress.Clear()
            namedeceased.Clear()
            deceasedage.Clear()
            totalamountC.Clear()
            '  packageCB.Text = CheckState.Unchecked
            clientSigPic.Image = Nothing
            '  adminSigPic.Image = Nothing
        Else


            cmd = conn.CreateCommand()

            cmd.CommandText = "DELETE FROM `contract` WHERE `contract`.`Contract_ID`='" & clientID_TB.Text & "';
                                DELETE FROM `services` WHERE `services`.`Services_ID`='" & clientID_TB.Text & "';
                                DELETE FROM `add_ons_price` WHERE `add_ons_price`.`Add_Ons_ID`='" & clientID_TB.Text & "';
                                DELETE FROM `contract_client` WHERE `contract_client`.`Client_ID`='" & clientID_TB.Text & "';
                                DELETE FROM `deceased_information` WHERE `deceased_information`.`Deceased_ID`='" & clientID_TB.Text & "';
                                DELETE FROM `contractor` WHERE `contractor`.`Contractor_ID`='" & clientID_TB.Text & "';
                                DELETE FROM `add_packages` WHERE `add_packages`.`Add_Package_ID`='" & clientID_TB.Text & "'"

            cmd.ExecuteNonQuery()

            clientID_TB.Clear()
            age.Clear()
            contactnumber.Clear()
            address.Clear()
            namedeceased.Clear()
            age.Clear()
            deceasedaddress.Clear()
            namedeceased.Clear()
            deceasedage.Clear()
            totalamountC.Clear()
            '  packageCB.Text = CheckState.Unchecked
            clientSigPic.Image = Nothing
            '  adminSigPic.Image = Nothing

            MessageBox.Show("Successfully Canceled Plan")


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles records_bttn.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        NewContractRecord.Show()
    End Sub
End Class