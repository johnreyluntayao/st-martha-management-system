Imports MySql.Data.MySqlClient
Public Class Packages
    Dim con As String = "server=localhost;username=root;password=;database=stmartha_database"
    Dim mcon As New MySqlConnection
    Dim com As New MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub Packages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auto_suggest("Package_Name", "packages", typeOfPackage)


        dtadapter = New MySqlDataAdapter("SELECT * FROM packages", conn)
        dataSet = New DataSet
        dtadapter.Fill(dataSet, "packages")
        Dim count As Integer = dataSet.Tables("packages").Rows.Count
        Dim x As Integer
        For x = 0 To count - 1
            typeOfPackage.Items.Add(dataSet.Tables("packages").Rows(x).Item("Package_Name"))
        Next

        'AutoZero

        embalming_TB.Text = Int(0)
        wakeviewing_TB.Text = Int(0)
        Internment_TB.Text = Int(0)
        freechapel_TB.Text = Int(0)
        tarpulin_TB.Text = Int(0)
        flower_TB.Text = Int(0)
        picture_TB.Text = Int(0)
        tribute_TB.Text = Int(0)
        balloons_TB.Text = Int(0)
        roses_TB.Text = Int(0)
        gardenviewing_TB.Text = Int(0)
        coffee_TB.Text = Int(0)
        karwahe_TB.Text = Int(0)

    End Sub
    Private Sub typeOfPackage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeOfPackage.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM packages WHERE Package_Name='" & typeOfPackage.Text & "'"
        cmd.ExecuteNonQuery()

        Select Case typeOfPackage.Text
            Case "Ordinary Casket"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Unchecked
                balloons_CB.Checked = CheckState.Unchecked
                roses_CB.Checked = CheckState.Unchecked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "Round Top Casket"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Unchecked
                balloons_CB.Checked = CheckState.Unchecked
                roses_CB.Checked = CheckState.Unchecked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "Ordinary Special"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Unchecked
                balloons_CB.Checked = CheckState.Unchecked
                roses_CB.Checked = CheckState.Unchecked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "Ordinary Special Metal"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "OMB Half Glass Metal"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "OMB Full Glass Metal"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "Ordinary Metal"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "Full Cap"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "Junior Flexy Metal"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Checked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
            Case "Senior Flexy Metal"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Checked
                coffee_CB.Checked = CheckState.Checked
                karwahe_CB.Checked = CheckState.Checked
            Case "Jango Metal"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Checked
                coffee_CB.Checked = CheckState.Checked
                karwahe_CB.Checked = CheckState.Checked
            Case "Imported Metal Casket"
                tarpulin_CB.Checked = CheckState.Checked
                flower_CB.Checked = CheckState.Checked
                pictureframe_CB.Checked = CheckState.Checked
                tribute_CB.Checked = CheckState.Checked
                balloons_CB.Checked = CheckState.Checked
                roses_CB.Checked = CheckState.Checked
                gardenviewing_CB.Checked = CheckState.Checked
                coffee_CB.Checked = CheckState.Checked
                karwahe_CB.Checked = CheckState.Checked
            Case Else
                tarpulin_CB.Checked = CheckState.Unchecked
                flower_CB.Checked = CheckState.Unchecked
                pictureframe_CB.Checked = CheckState.Unchecked
                tribute_CB.Checked = CheckState.Unchecked
                balloons_CB.Checked = CheckState.Unchecked
                roses_CB.Checked = CheckState.Unchecked
                gardenviewing_CB.Checked = CheckState.Unchecked
                coffee_CB.Checked = CheckState.Unchecked
                karwahe_CB.Checked = CheckState.Unchecked
        End Select

        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    End Sub


    Private Sub embalming_TB_TextChanged(sender As Object, e As EventArgs) Handles embalming_TB.TextChanged
        If embalming_TB.Text = "" Or wakeviewing_TB.Text = "" Or Internment_TB.Text = "" Or freechapel_TB.Text = "" Then

        Else
            Dim embalmingVal As Double = embalming_TB.Text
            Dim wakeviewingVal As Double = wakeviewing_TB.Text
            Dim internmentVal As Double = Internment_TB.Text
            '   Dim freechapelVal As Double = freechapel_TB.Text

            Dim servicestotal As Double = embalmingVal + wakeviewingVal + internmentVal
            totalamount_services.Text = (FormatNumber(servicestotal))
        End If
    End Sub

    Private Sub wakeviewing_TB_TextChanged(sender As Object, e As EventArgs) Handles wakeviewing_TB.TextChanged
        If embalming_TB.Text = "" Or wakeviewing_TB.Text = "" Or Internment_TB.Text = "" Or freechapel_TB.Text = "" Then

        Else
            Dim embalmingVal As Double = embalming_TB.Text
            Dim wakeviewingVal As Double = wakeviewing_TB.Text
            Dim internmentVal As Double = Internment_TB.Text
            '     Dim freechapelVal As Double = freechapel_TB.Text

            Dim servicestotal As Double = embalmingVal + wakeviewingVal + internmentVal
            totalamount_services.Text = (FormatNumber(servicestotal))
        End If
    End Sub

    Private Sub Internment_TB_TextChanged(sender As Object, e As EventArgs) Handles Internment_TB.TextChanged
        If embalming_TB.Text = "" Or wakeviewing_TB.Text = "" Or Internment_TB.Text = "" Or freechapel_TB.Text = "" Then

        Else
            Dim embalmingVal As Double = embalming_TB.Text
            Dim wakeviewingVal As Double = wakeviewing_TB.Text
            Dim internmentVal As Double = Internment_TB.Text
            ' Dim freechapelVal As Double = freechapel_TB.Text

            Dim servicestotal As Double = embalmingVal + wakeviewingVal + internmentVal
            totalamount_services.Text = (FormatNumber(servicestotal))
        End If
    End Sub

    Private Sub freechapel_TB_TextChanged(sender As Object, e As EventArgs) Handles freechapel_TB.TextChanged

    End Sub

    Private Sub tarpulin_TB_TextChanged(sender As Object, e As EventArgs) Handles tarpulin_TB.TextChanged

        If tarpulin_TB.Text = "" Or flower_TB.Text = "" Or picture_TB.Text = "" Or tribute_TB.Text = "" Or balloons_TB.Text = "" Or roses_TB.Text = "" Or gardenviewing_TB.Text = "" Or coffee_TB.Text = "" Or karwahe_TB.Text = "" Then
        Else
            Dim tarpulinVal As Double = tarpulin_TB.Text
            ' Dim flowerVal As Double = flower_TB.Text
            '  Dim pictureVal As Double = picture_TB.Text
            Dim tributeVal As Double = tribute_TB.Text
            '   Dim ballonVal As Double = balloons_TB.Text
            '    Dim roseVal As Double = roses_TB.Text
            Dim gardenVal As Double = gardenviewing_TB.Text
            Dim coffeVal As Double = coffee_TB.Text
            Dim karwaheVal As Double = karwahe_TB.Text
            Dim addOnsTotal As Double = tarpulinVal + tributeVal + gardenVal + coffeVal + karwaheVal
            totalamount_addson_TB.Text = (FormatNumber(addOnsTotal))
        End If

    End Sub

    Private Sub flower_TB_TextChanged(sender As Object, e As EventArgs) Handles flower_TB.TextChanged

    End Sub

    Private Sub picture_TB_TextChanged(sender As Object, e As EventArgs) Handles picture_TB.TextChanged

    End Sub

    Private Sub tribute_TB_TextChanged(sender As Object, e As EventArgs) Handles tribute_TB.TextChanged
        If tarpulin_TB.Text = "" Or flower_TB.Text = "" Or picture_TB.Text = "" Or tribute_TB.Text = "" Or balloons_TB.Text = "" Or roses_TB.Text = "" Or gardenviewing_TB.Text = "" Or coffee_TB.Text = "" Or karwahe_TB.Text = "" Then
        Else
            Dim tarpulinVal As Double = tarpulin_TB.Text
            ' Dim flowerVal As Double = flower_TB.Text
            '  Dim pictureVal As Double = picture_TB.Text
            Dim tributeVal As Double = tribute_TB.Text
            '   Dim ballonVal As Double = balloons_TB.Text
            '    Dim roseVal As Double = roses_TB.Text
            Dim gardenVal As Double = gardenviewing_TB.Text
            Dim coffeVal As Double = coffee_TB.Text
            Dim karwaheVal As Double = karwahe_TB.Text
            Dim addOnsTotal As Double = tarpulinVal + tributeVal + gardenVal + coffeVal + karwaheVal
            totalamount_addson_TB.Text = (FormatNumber(addOnsTotal))
        End If

    End Sub

    Private Sub balloons_TB_TextChanged(sender As Object, e As EventArgs) Handles balloons_TB.TextChanged

    End Sub

    Private Sub roses_TB_TextChanged(sender As Object, e As EventArgs) Handles roses_TB.TextChanged

    End Sub

    Private Sub gardenviewing_TB_TextChanged(sender As Object, e As EventArgs) Handles gardenviewing_TB.TextChanged
        If tarpulin_TB.Text = "" Or flower_TB.Text = "" Or picture_TB.Text = "" Or tribute_TB.Text = "" Or balloons_TB.Text = "" Or roses_TB.Text = "" Or gardenviewing_TB.Text = "" Or coffee_TB.Text = "" Or karwahe_TB.Text = "" Then
        Else
            Dim tarpulinVal As Double = tarpulin_TB.Text
            ' Dim flowerVal As Double = flower_TB.Text
            '  Dim pictureVal As Double = picture_TB.Text
            Dim tributeVal As Double = tribute_TB.Text
            '   Dim ballonVal As Double = balloons_TB.Text
            '    Dim roseVal As Double = roses_TB.Text
            Dim gardenVal As Double = gardenviewing_TB.Text
            Dim coffeVal As Double = coffee_TB.Text
            Dim karwaheVal As Double = karwahe_TB.Text
            Dim addOnsTotal As Double = tarpulinVal + tributeVal + gardenVal + coffeVal + karwaheVal
            totalamount_addson_TB.Text = (FormatNumber(addOnsTotal))
        End If

    End Sub

    Private Sub coffee_TB_TextChanged(sender As Object, e As EventArgs) Handles coffee_TB.TextChanged
        If tarpulin_TB.Text = "" Or flower_TB.Text = "" Or picture_TB.Text = "" Or tribute_TB.Text = "" Or balloons_TB.Text = "" Or roses_TB.Text = "" Or gardenviewing_TB.Text = "" Or coffee_TB.Text = "" Or karwahe_TB.Text = "" Then
        Else
            Dim tarpulinVal As Double = tarpulin_TB.Text
            ' Dim flowerVal As Double = flower_TB.Text
            '  Dim pictureVal As Double = picture_TB.Text
            Dim tributeVal As Double = tribute_TB.Text
            '   Dim ballonVal As Double = balloons_TB.Text
            '    Dim roseVal As Double = roses_TB.Text
            Dim gardenVal As Double = gardenviewing_TB.Text
            Dim coffeVal As Double = coffee_TB.Text
            Dim karwaheVal As Double = karwahe_TB.Text
            Dim addOnsTotal As Double = tarpulinVal + tributeVal + gardenVal + coffeVal + karwaheVal
            totalamount_addson_TB.Text = (FormatNumber(addOnsTotal))
        End If

    End Sub

    Private Sub karwahe_TB_TextChanged(sender As Object, e As EventArgs) Handles karwahe_TB.TextChanged
        If tarpulin_TB.Text = "" Or flower_TB.Text = "" Or picture_TB.Text = "" Or tribute_TB.Text = "" Or balloons_TB.Text = "" Or roses_TB.Text = "" Or gardenviewing_TB.Text = "" Or coffee_TB.Text = "" Or karwahe_TB.Text = "" Then
        Else
            Dim tarpulinVal As Double = tarpulin_TB.Text
            ' Dim flowerVal As Double = flower_TB.Text
            '  Dim pictureVal As Double = picture_TB.Text
            Dim tributeVal As Double = tribute_TB.Text
            '   Dim ballonVal As Double = balloons_TB.Text
            '    Dim roseVal As Double = roses_TB.Text
            Dim gardenVal As Double = gardenviewing_TB.Text
            Dim coffeVal As Double = coffee_TB.Text
            Dim karwaheVal As Double = karwahe_TB.Text
            Dim addOnsTotal As Double = tarpulinVal + tributeVal + gardenVal + coffeVal + karwaheVal
            totalamount_addson_TB.Text = (FormatNumber(addOnsTotal))
        End If

    End Sub

    Private Sub totalamount_services_TextChanged(sender As Object, e As EventArgs) Handles totalamount_services.TextChanged
        If totalamount_services.Text = "" Or totalamount_addson_TB.Text = "" Then
        Else
            Dim totalservicesVal As Double = totalamount_services.Text
            Dim totaladdsonVal As Double = totalamount_addson_TB.Text
            Dim TOTAL As Integer = totalservicesVal + totaladdsonVal
            totalamount.Text = (FormatNumber(TOTAL))
            NewContractForm.totalamountC.Text = (FormatNumber(TOTAL))
            ContractNewForm.totalamountC.Text = (FormatNumber(TOTAL))
        End If
    End Sub

    Private Sub totalamount_addson_TB_TextChanged(sender As Object, e As EventArgs) Handles totalamount_addson_TB.TextChanged
        If totalamount_services.Text = "" Or totalamount_addson_TB.Text = "" Then
        Else
            Dim totalservicesVal As Double = totalamount_services.Text
            Dim totaladdsonVal As Double = totalamount_addson_TB.Text
            Dim TOTAL As Integer = totalservicesVal + totaladdsonVal
            totalamount.Text = (FormatNumber(TOTAL))
            NewContractForm.totalamountC.Text = (FormatNumber(TOTAL))
            ContractNewForm.totalamountC.Text = (FormatNumber(TOTAL))
        End If
    End Sub


    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttn.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()


        'Static clickcount As Integer = 0

        ' clickcount += 1
        'If cLickcount = "20" Then
        'clickcount = 1
        'End If

        'ContractInformation.clientID_TB.Text = clickcount.ToString("0")






        Dim insertCom As New MySqlCommand
        insertCom = conn.CreateCommand()
        insertCom.CommandType = CommandType.Text



        'Orig query
        ' cmd.CommandText = "INSERT INTO services (`Embalming`,`Internment`,`Wake_Viewing`,`Free_Chapel`,`Total_Amount`) VALUES('" & embalming_TB.Text & "','" & Internment_TB.Text & "','" & wakeviewing_TB.Text & "','" & freechapel_TB.Text & "','" & totalamount_services.Text & "');
        'INSERT INTO add_ons_price (`Tarpaulin`,`Flower_Arrangement`,`Picture_Frame`,`Tribute`,`Free_Balloons`,`Roses`,`Garden_Viewing`,`Coffee_Bar`,`Karwahe`,`Total_Amount`) VALUES('" & tarpulin_TB.Text & "','" & flower_TB.Text & "','" & picture_TB.Text & "','" & tribute_TB.Text & "','" & balloons_TB.Text & "','" & roses_TB.Text & "','" & gardenviewing_TB.Text & "','" & coffee_TB.Text & "','" & karwahe_TB.Text & "','" & totalamount_addson_TB.Text & "');
        ' INSERT INTO `contract_payment`(`Total_Amount`) VALUES ('" & totalamount.Text & "')"
        'cmd.ExecuteNonQuery()



        'origquery
        'insertCom.CommandText = "INSERT INTO services (`Embalming`,`Internment`,`Wake_Viewing`,`Free_Chapel`,`Total_Amount`) VALUES('" & embalming_TB.Text & "','" & Internment_TB.Text & "','" & wakeviewing_TB.Text & "','" & freechapel_TB.Text & "','" & totalamount_services.Text & "');
        ' INSERT INTO add_ons_price (`Tarpaulin`,`Flower_Arrangement`,`Picture_Frame`,`Tribute`,`Free_Balloons`,`Roses`,`Garden_Viewing`,`Coffee_Bar`,`Karwahe`,`Total_Amount`) VALUES('" & tarpulin_TB.Text & "','" & flower_TB.Text & "','" & picture_TB.Text & "','" & tribute_TB.Text & "','" & balloons_TB.Text & "','" & roses_TB.Text & "','" & gardenviewing_TB.Text & "','" & coffee_TB.Text & "','" & karwahe_TB.Text & "','" & totalamount_addson_TB.Text & "');
        ' INSERT INTO `contract_client`(`Client_Name`, `Relationship_to_the_Deceased`, `Age`, `Contact_Number`, `Address`, `Contractee_Signature`, `Date`) VALUES (NULL,NULL,NULL,NULL,NULL,NULL,NULL);
        ''  INSERT INTO `deceased_information`(`Client_ID`, `Name_of_Deceased`, `Date_of_Death`, `Age`, `Birthdate`, `Complete_Address`) VALUES (NULL,NULL,NULL,NULL,NULL,NULL);
        ' INSERT INTO `contract_payment`(`Total_Amount`) VALUES ('" & totalamount.Text & "');
        '  INSERT INTO `contract`(`Admin_ID`, `Client_ID`, `Deceased_ID`, `Add_Package_ID`, `Payment_ID`, `Plan_ID`, `Total_Amount`) VALUES (NULL,NULL,NULL,NULL,NULL,NULL,'" & totalamount.Text & "');"

        'origquery
        insertCom.CommandText = "INSERT INTO `contract`(`Admin_ID`, `Client_ID`, `Deceased_ID`, `Add_Package_ID`,`Contractor_ID`,`Total_Amount`) VALUES (NULL,NULL,NULL,NULL,NULL,'" & totalamount.Text & "');
        INSERT INTO services (`Embalming`,`Internment`,`Wake_Viewing`,`Free_Chapel`,`Total_Amount`) VALUES('" & embalming_TB.Text & "','" & Internment_TB.Text & "','" & wakeviewing_TB.Text & "','" & freechapel_TB.Text & "','" & totalamount_services.Text & "');
        INSERT INTO add_ons_price (`Tarpaulin`,`Flower_Arrangement`,`Picture_Frame`,`Tribute`,`Free_Balloons`,`Roses`,`Garden_Viewing`,`Coffee_Bar`,`Karwahe`,`Total_Amount`) VALUES('" & tarpulin_TB.Text & "','" & flower_TB.Text & "','" & picture_TB.Text & "','" & tribute_TB.Text & "','" & balloons_TB.Text & "','" & roses_TB.Text & "','" & gardenviewing_TB.Text & "','" & coffee_TB.Text & "','" & karwahe_TB.Text & "','" & totalamount_addson_TB.Text & "');
        INSERT INTO `contract_client`(`Client_Name`, `Relationship_to_the_Deceased`, `Age`, `Contact_Number`, `Address`, `Contractee_Signature`, `Date`) VALUES (NULL,NULL,NULL,NULL,NULL,NULL,NULL);
        INSERT INTO `deceased_information`(`Client_ID`, `Name_of_Deceased`, `Date_of_Death`, `Age`, `Birthdate`, `Complete_Address`) VALUES (NULL,NULL,NULL,NULL,NULL,NULL);
         INSERT INTO `contractor`(`Contractor_Name`,`Authorized_Signature`) VALUES(NULL,NULL)"


        insertCom.ExecuteNonQuery()

        'INSERT INTO `contract_payment`(`Services_ID`, `Add_Package_ID`, `Add_Ons_ID`, `Contract_ID`, `Client_ID`,`Client_Name`) VALUES (NULL,NULL,NULL,NULL,NULL,NULL)"


        Dim getID As New MySqlCommand("SELECT MAX(Client_ID) FROM contract_client", conn)
        Dim gets = Convert.ToString(getID.ExecuteScalar)
        ContractNewForm.clientID_TB.Text = gets
        NewContractForm.clientID_TB.Text = gets
        UpdatePackages.clientID_TB.Text = gets
        AdminInformation.clientID_TB.Text = gets

        ContractNewForm.selectPackages.Hide()
        ContractNewForm.update_PackagesCM.Visible = True
        NewContractForm.selectPackages.Hide()
        NewContractForm.update_PackagesC.Visible = True
        'test autofill
        ' Dim commnd As New MySqlCommand

        ' commnd = conn.CreateCommand()
        'commnd.CommandType = CommandType.Text
        'autofill
        ' commnd.CommandText = "SELECT `Client_ID` FROM contract_client"
        'commnd.ExecuteNonQuery()
        'Dim dt As New DataTable()
        'Dim da As New MySqlDataAdapter(commnd)
        'da.Fill(dt)

        'Dim dr As MySqlDataReader
        ' dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        'hile dr.Read
        'ContractInformation.clientID_TB.Text = dr.GetInt32("Client_ID")
        '  End While
        conn.Close()


        mcon.ConnectionString = con
        Try
            Dim checks = {tarpulin_CB, flower_CB, pictureframe_CB, tribute_CB, balloons_CB, roses_CB, gardenviewing_CB, coffee_CB, karwahe_CB}
            Dim selectedpackage As New List(Of String)
            For Each packageInclusion In checks
                If packageInclusion.Checked Then
                    selectedpackage.Add(packageInclusion.Text)
                End If
            Next
            Dim value = String.Join(",", selectedpackage.ToArray)
            mcon.Open()
            Dim save = "INSERT INTO add_packages(`Package_Name`,`Package_Inclusions`) VALUES('" & typeOfPackage.Text & "','" & value & "')"
            com = New MySqlCommand(save, mcon)
            reader = com.ExecuteReader
            mcon.Close()
            reader.Close()
            MsgBox("Successully Added", vbInformation)
            '   tarpulin_CB.Checked = False
            '    flower_CB.Checked = False
            '    pictureframe_CB.Checked = False
            '  tribute_CB.Checked = False
            '  balloons_CB.Checked = False
            '  roses_CB.Checked = False
            '   gardenviewing_CB.Checked = False
            '  coffee_CB.Checked = False
            '   karwahe_CB.Checked = False
            '   typeOfPackage.Text = ""
            '  embalming_TB.PlaceholderText = Int(0)
            '  embalming_TB.PlaceholderText = Int(0)
            ' wakeviewing_TB.PlaceholderText = Int(0)
            ' Internment_TB.PlaceholderText = Int(0)
            '  freechapel_TB.PlaceholderText = Int(0)
            '  tarpulin_TB.PlaceholderText = Int(0)
            '  flower_TB.PlaceholderText = Int(0)
            '  picture_TB.PlaceholderText = Int(0)
            '   tribute_TB.PlaceholderText = Int(0)
            '   balloons_TB.PlaceholderText = Int(0)
            '  roses_TB.PlaceholderText = Int(0)
            '  gardenviewing_TB.PlaceholderText = Int(0)
            ' coffee_TB.PlaceholderText = Int(0)
            '  karwahe_TB.PlaceholderText = Int(0)
            '  totalamount.PlaceholderText = Int(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mcon.Dispose()
            Me.Close()
        End Try






        ' If conn.State = ConnectionState.Open Then
        'conn.Close()
        ' End If
        'Dim addonsCMD As New MySqlCommand
        ' Dim servicesCMD As New MySqlCommand
        'addonsCMD = conn.CreateCommand()
        'addonsCMD.CommandType = CommandType.Text
        ' servicesCMD = conn.CreateCommand()
        ' servicesCMD.CommandText = "INSERT INTO `services`(`Embalming`, `Internment`, `Wake_Viewing`, `Free_Chapel`, `Total_Amount`) VALUES ('" & embalming_TB.Text & "','" & Internment_TB.Text & "','" & wakeviewing_TB.Text & "','" & freechapel_TB.Text & "','" & totalamount_services.Text & "')"
        '  addonsCMD.CommandText = "INSERT INTO add_ons_price (`Tarpaulin`, `Flower_Arrangement`, `Picture_Frame`, `Tribute`, `Free_Balloons`, `Roses`, `Garden_Viewing`, `Coffee_Bar`, `Karwahe`, `Total_Amount`) VALUES ('" & tarpulin_TB.Text & "','" & flower_TB.Text & "','" & picture_TB.Text & "','" & tribute_TB.Text & "','" & balloons_TB.Text & "','" & roses_TB.Text & "','" & gardenviewing_TB.Text & "','" & coffee_TB.Text & "','" & karwahe_TB.Text & "','" & totalamount_TB.Text & "')"
        '  addonsCMD.ExecuteNonQuery()
        '  servicesCMD.ExecuteNonQuery()

        conn.Close()

    End Sub


    Private Sub clear_bttn_Click(sender As Object, e As EventArgs) Handles clear_bttn.Click
        typeOfPackage.Text = ""
        embalming_TB.Text = Int(0)
        wakeviewing_TB.Text = Int(0)
        Internment_TB.Text = Int(0)
        freechapel_TB.Text = Int(0)
        tarpulin_TB.Text = Int(0)
        flower_TB.Text = Int(0)
        picture_TB.Text = Int(0)
        tribute_TB.Text = Int(0)
        balloons_TB.Text = Int(0)
        roses_TB.Text = Int(0)
        gardenviewing_TB.Text = Int(0)
        coffee_TB.Text = Int(0)
        karwahe_TB.Text = Int(0)
        tarpulin_CB.Checked = CheckState.Unchecked
        flower_CB.Checked = CheckState.Unchecked
        pictureframe_CB.Checked = CheckState.Unchecked
        tribute_CB.Checked = CheckState.Unchecked
        balloons_CB.Checked = CheckState.Unchecked
        roses_CB.Checked = CheckState.Unchecked
        gardenviewing_CB.Checked = CheckState.Unchecked
        coffee_CB.Checked = CheckState.Unchecked
        karwahe_CB.Checked = CheckState.Unchecked
    End Sub

    Private Sub embalming_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles embalming_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub wakeviewing_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles wakeviewing_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub Internment_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Internment_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub freechapel_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles freechapel_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub tarpulin_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tarpulin_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub flower_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles flower_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub picture_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles picture_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub tribute_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tribute_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub balloons_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles balloons_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub roses_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles roses_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub gardenviewing_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gardenviewing_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub coffee_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles coffee_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub karwahe_TB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles karwahe_TB.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub totalamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles totalamount.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub
End Class