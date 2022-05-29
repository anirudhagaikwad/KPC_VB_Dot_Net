Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim SQL As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'user the table name as per yours
        conn = New MySqlConnection()
        conn.ConnectionString = ("server=localhost;user id=root;password=;database=employee")
        Try
                conn.Open()
                SQL = "Select * from emp;"

                myCommand.Connection = conn
                myCommand.CommandText = SQL

                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)

                DataGridView1.DataSource = myData

                conn.Close()

            Catch myerror As MySqlException

                MessageBox.Show("Cannot connect to database: " & myerror.Message)

            Finally

            conn.Dispose()

        End Try
    End Sub
End Class
