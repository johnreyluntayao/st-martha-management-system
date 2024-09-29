Imports MySql.Data.MySqlClient
Module DBConnection
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;username=root;password=;database=stmartha_database;Convert Zero Datetime=True")
    End Function
    Public conn As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public dtadapter As New MySqlDataAdapter
    Public dt As New DataTable
    Public dataSet As New DataSet

    'INSERT/ADDING DATA
    Public Sub create_data(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                conn.Close()
                If result = 0 Then
                    MessageBox.Show("FAILED TO ADD DATA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA ADDED SUCCESSFULLY IN THE DATABASE!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dtadapter.Dispose()
        End Try
    End Sub
    'FOR UPDATE FUNCTION
    Public Sub update_data(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql

                cmd.ExecuteNonQuery()
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("DATA FAILED TO UPDATE!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN UPDATED!", "SUCESS",
                     MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub auto_suggest(ByVal attributes As String, ByVal table As String, ByVal txt As Object)
        Try
            dt = New DataTable
            'open the connection
            conn.Open()
            'holds the data in the database
            With cmd
                .Connection = conn
                .CommandText = " select " & attributes & " from " & table
            End With
            '''''''''''''''fill data in the table
            dtadapter.SelectCommand = cmd
            dtadapter.Fill(dt)

            ''function of autocomplete
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            ''''''''''''''''''''''''
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''''close the connection
        conn.Close()
        dtadapter.Dispose()

    End Sub

    'FOR REFRESH FUNCTION
    Public Sub refresh_data(ByVal sql As String, ByVal DGVList As Object)
        Try
            dt = New DataTable
            With cmd
                .Connection = conn
                .CommandText = sql

            End With
            dtadapter.SelectCommand = cmd
            dtadapter.Fill(dt)
            DGVList.datasource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
            dtadapter.Dispose()

        End Try
    End Sub

    Public Sub search_data(ByVal sql As String, ByVal DGVList As Object)
        Try
            dt = New DataTable
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql
            End With
            dtadapter.SelectCommand = cmd
            dtadapter.Fill(dt)
            DGVList.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
End Module
