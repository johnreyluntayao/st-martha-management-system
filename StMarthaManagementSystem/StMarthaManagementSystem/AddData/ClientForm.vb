Public Class ClientForm

    Dim gender As String
    Dim genderBind As String

    Private Sub save_bttn_Click(sender As Object, e As EventArgs) Handles save_bttn.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandText = "INSERT INTO contract_client (`Client_Name`,`Age`,`Address`,`Contact_Number`,`Gender`) VALUES('" & clientName.Text & "','" & age.Text & "','" & address.Text & "','" & contactNum.Text & "','" & gender & "')"
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("DATA ADDED SUCCESSFULLY IN THE DATABASE!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' ContractInformation.clientName_CB.Text = clientName.Text
            ' ContractInformation.age.Text = age.Text
            ' ContractInformation.contactnumber.Text = contactNum.Text
            'ContractInformation.address.Text = address.Text
        Else

            MessageBox.Show("FAILED TO ADD DATA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clientName.Text = ""
        address.Text = ""
        age.Text = ""
        contactNum.Text = ""
        radmale.Checked = False
        radfemale.Checked = False
        conn.Close()



    End Sub
    Private Sub radmale_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub clear_bttn_Click(sender As Object, e As EventArgs) Handles clear_bttn.Click
        clientName.Clear()
        age.Clear()
        address.Clear()
        contactNum.Clear()
        radmale.Checked = False
        radfemale.Checked = False
    End Sub

    'Numbers Only
    Private Sub age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles age.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub

    Private Sub contactNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contactNum.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Input Numbers Only")
        End If
    End Sub
    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If clientName.Text = "" Or age.Text = "" Or address.Text = "" Or contactNum.Text = "" Then
        '  MessageBox.Show("Text cannot be empty, fill in before proceeding",
        '                     "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '  clientName.Focus()
        '  age.Focus()
        '  address.Focus()
        ' contactNum.Focus()
        '  End If

        ' If clientName.Text = "" Then

        '     End If
        '    ErrorProvider0.SetError(clientName, "Embalming is Empty")
    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs) Handles age.TextChanged

    End Sub

    Private Sub clientName_TextChanged(sender As Object, e As EventArgs) Handles clientName.TextChanged
        If clientName.Text = "" Then
            MessageBox.Show("Text cannot be empty, fill in before proceeding", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class