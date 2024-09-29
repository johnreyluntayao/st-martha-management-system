Imports MySql.Data.MySqlClient

Public Class UpdatePackages
    Dim con As String = "server=localhost;username=root;password=;database=stmartha_database"
    Dim mcon As New MySqlConnection
    Dim id As String
    Dim com As New MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub UpdatePackages_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        ' embalming_TB.Text = Int(0)
        ' wakeviewing_TB.Text = Int(0)
        ' Internment_TB.Text = Int(0)
        '  freechapel_TB.Text = Int(0)
        ' tarpulin_TB.Text = Int(0)
        '  flower_TB.Text = Int(0)
        '  picture_TB.Text = Int(0)
        '  tribute_TB.Text = Int(0)
        '   balloons_TB.Text = Int(0)
        '  roses_TB.Text = Int(0)
        '  gardenviewing_TB.Text = Int(0)
        '   coffee_TB.Text = Int(0)
        '   karwahe_TB.Text = Int(0)



        '1:05am
        'Johnrey Code that Aljonard marked as comment 
        ' id = ContractInformation.clientID_TB.Text  'Item(0).Value.ToString()
        '    cmd = conn.CreateCommand()
        '    cmd.CommandType = CommandType.Text
        '  cmd.CommandText = "SELECT add_packages.Package_Name,services.Embalming,services.Internment,services.Wake_Viewing,services.Free_Chapel,services.Total_Amount,add_ons_price.Tarpaulin,add_ons_price.Flower_Arrangement,add_ons_price.Picture_Frame,add_ons_price.Tribute,add_ons_price.Free_Balloons,add_ons_price.Roses,add_ons_price.Garden_Viewing,add_ons_price.Coffee_Bar,add_ons_price.Karwahe,add_ons_price.Total_Amount,contract.Total_Amount FROM add_packages INNER JOIN services ON add_packages.Add_Package_ID = services.Services_ID INNER JOIN add_ons_price ON services.Services_ID = add_ons_price.Add_Ons_ID INNER JOIN contract ON add_ons_price.Add_Ons_ID = contract.Total_Amount WHERE services.Services_ID = MAX(add_packages.Add_Package_ID)"

        '  cmd.ExecuteNonQuery()
        ' '  Dim dt As New DataTable()
        '   Dim da As New MySqlDataAdapter(cmd)
        '   da.Fill(dt)
        '   Dim dr As MySqlDataReader
        '   dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        '   While dr.Read

        ' typeOfPackage.Text = dr.GetString(1).ToString()
        ' embalming_TB.Text = dr.GetString(2).ToString()
        '    Internment_TB.Text = dr.GetString(3).ToString()
        ' wakeviewing_TB.Text = dr.GetString(4).ToString()
        ' freechapel_TB.Text = dr.GetString(5).ToString()
        ' totalamount_services.Text = dr.GetString(6).ToString()
        'tarpulin_TB.Text = dr.GetString(7).ToString()
        'flower_TB.Text = dr.GetString(8).ToString()
        'picture_TB.Text = dr.GetString(9).ToString()
        'tribute_TB.Text = dr.GetString(10).ToString()
        ' balloons_TB.Text = dr.GetString(11).ToString()
        ' roses_TB.Text = dr.GetString(12).ToString()
        'gardenviewing_TB.Text = dr.GetString(13).ToString()
        ' coffee_TB.Text = dr.GetString(14).ToString()
        'karwahe_TB.Text = dr.GetString(15).ToString()
        'totalamount_addson_TB.Text = dr.GetString(16).ToString()
        'totalamount.Text = dr.GetString(17).ToString()
        '  End While
    End Sub

    Private Sub update_bttn_Click(sender As Object, e As EventArgs) Handles update_bttn.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()


        Dim updateCMD As New MySqlCommand
        updateCMD = conn.CreateCommand()
        updateCMD.CommandType = CommandType.Text
        updateCMD.CommandText = "UPDATE services SET `Embalming`='" & embalming_TB.Text & "',`Internment`='" & Internment_TB.Text & "',`Wake_Viewing`='" & wakeviewing_TB.Text & "',`Free_Chapel`='" & freechapel_TB.Text & "',`Total_Amount`='" & totalamount_services.Text & "' WHERE `Services_ID`='" & clientID_TB.Text & "';
                                   UPDATE add_ons_price SET `Tarpaulin`='" & tarpulin_TB.Text & "',`Flower_Arrangement`='" & flower_TB.Text & "',`Picture_Frame`='" & picture_TB.Text & "',`Tribute`='" & tribute_TB.Text & "',`Free_Balloons`='" & balloons_TB.Text & "',`Roses`='" & roses_TB.Text & "',`Garden_Viewing`='" & gardenviewing_TB.Text & "',`Coffee_Bar`='" & coffee_TB.Text & "',`Karwahe`='" & karwahe_TB.Text & "',`Total_Amount`='" & totalamount_addson_TB.Text & "' WHERE Add_Ons_ID='" & clientID_TB.Text & "';
                                    UPDATE contract SET `Total_Amount`= '" & totalamount.Text & "' WHERE Contract_ID='" & clientID_TB.Text & "'"
        updateCMD.ExecuteNonQuery()


        ContractNewForm.update_PackagesCM.Visible = True
        NewContractForm.update_PackagesC.Visible = True
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
            Dim update = "UPDATE `add_packages` SET `Package_Name`='" & typeOfPackage.Text & "',`Package_Inclusions`='" & value & "' WHERE Add_Package_ID='" & ContractInformation.clientID_TB.Text & "'"
            com = New MySqlCommand(update, mcon)
            reader = com.ExecuteReader
            mcon.Close()
            reader.Close()
            MsgBox("Successully Updated", vbInformation)
            '  tarpulin_CB.Checked = False
            '  flower_CB.Checked = False
            '  pictureframe_CB.Checked = False
            '   tribute_CB.Checked = False
            '   balloons_CB.Checked = False
            '   roses_CB.Checked = False
            '   gardenviewing_CB.Checked = False
            '   coffee_CB.Checked = False
            '   karwahe_CB.Checked = False
            '   typeOfPackage.Text = ""
            '  embalming_TB.PlaceholderText = Int(0)
            '    embalming_TB.PlaceholderText = Int(0)
            '   wakeviewing_TB.PlaceholderText = Int(0)
            '  Internment_TB.PlaceholderText = Int(0)
            ' freechapel_TB.PlaceholderText = Int(0)
            '   tarpulin_TB.PlaceholderText = Int(0)
            '   flower_TB.PlaceholderText = Int(0)
            '   picture_TB.PlaceholderText = Int(0)
            '   tribute_TB.PlaceholderText = Int(0)
            '  balloons_TB.PlaceholderText = Int(0)
            '  roses_TB.PlaceholderText = Int(0)
            '  gardenviewing_TB.PlaceholderText = Int(0)
            '   coffee_TB.PlaceholderText = Int(0)
            '   karwahe_TB.PlaceholderText = Int(0)
            '   totalamount.PlaceholderText = Int(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mcon.Dispose()
            Me.Close()
        End Try

        conn.Close()
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
    'Private Sub back_bttn_Click(sender As Object, e As EventArgs) Handles back_bttn.Click
    ' Me.Hide()
    '    PlanRecord.Show()
    ' End Sub


End Class