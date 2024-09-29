Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities.Collections
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class ClientRecord

    Private Sub ClientRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        disp_data()
    End Sub

    Public Sub disp_data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Client_ID,Client_Name,Age,Contact_Number,Address,Gender FROM contract_client"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        clientRecDGV.DataSource = dt
    End Sub
End Class