Imports MySql.Data.MySqlClient
Imports System.Data
' Its Practical 25,26,27
Public Class Form1
    Dim conn As MySqlConnection
    Dim SQL As String

    Sub Data_Load()
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;password=;database=employee"
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = "Select * From emp;"

            myCommand.Connection = conn
            myCommand.CommandText = SQL

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With DataGridView1
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True

                .Columns(0).HeaderText = "Name"
                .Columns(1).HeaderText = "Address"
                .Columns(0).Width = 100
                .Columns(1).Width = 250
            End With

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data_Load()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;password=;database=employee"
        Try
            conn.Open()
            If ToolStripLabel2.Enabled = True Then
                SQL = "INSERT INTO emp (name, address) VALUES " & "('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
            Else
                SQL = "UPDATE emp SET address = '" & TextBox2.Text & "' " & "WHERE name = '" & TextBox1.Text & "'"
            End If

            'SQL = "INSERT INTO emp (name, address) VALUES " & "('" & TextBox1.Text & "', '" & TextBox2.Text & "')"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            If ToolStripLabel2.Enabled = True Then
                MsgBox("Data Inserted...")
            Else
                MsgBox("Data Updated...")
            End If

            ToolStripLabel4_Click(Nothing, Nothing)

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub grdData_CellMouseDoubleClick(ByVal sender As Object,
    ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) _
    Handles DataGridView1.CellMouseDoubleClick

        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        ToolStripLabel2.Enabled = False
        TextBox1.ReadOnly = True

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        grdData_CellMouseDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        ToolStripLabel2.Enabled = True
        TextBox1.ReadOnly = False
        Data_Load()
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        If MsgBox("Did You want to Delete data?", MsgBoxStyle.YesNo,
              "confirmed") = MsgBoxResult.No Then Exit Sub

        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;password=;database=employee"
        Try
            conn.Open()
            SQL = "DELETE FROM emp WHERE name = " & "'" & DataGridView1.CurrentRow.Cells(0).Value & "'"

            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            MsgBox("Data Deleted")

            ToolStripLabel4_Click(Nothing, Nothing)

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        Me.Close()
    End Sub
End Class
