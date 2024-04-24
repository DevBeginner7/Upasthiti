Imports System.Data.SqlClient

Public Class userLeaveForm
    Private Sub userLeaveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define columns for the ListView
        listViewLeaves.Columns.Add("Description", 200)
        listViewLeaves.Columns.Add("Apply Date", 150)
        listViewLeaves.Columns.Add("Total Days", 100)

        ' Load user leaves on form load with an empty search term
        LoadUserLeaves("")
    End Sub

    Private Sub LoadUserLeaves(searchTerm As String)
        Try
            ' Clear existing items in the ListView
            listViewLeaves.Items.Clear()

            ' Define your connection string
            Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

            ' Define your SQL query to fetch leave data for the current user's staff ID and search term in description
            Dim query As String = "SELECT lt.applyDate, lt.totalDays, lt.description " &
                                  "FROM leavesTable lt " &
                                  "WHERE lt.staffId = @StaffID AND lt.description LIKE @SearchTerm " &
                                  "ORDER BY lt.applyDate DESC"

            ' Create a SqlConnection object
            Using connection As New SqlConnection(connectionString)
                ' Create a SqlCommand object with your query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add parameters for the current user's staff ID and search term
                    command.Parameters.AddWithValue("@StaffID", My.Settings.userId)
                    command.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

                    ' Create a SqlDataAdapter to fill the data into a DataTable
                    Dim adapter As New SqlDataAdapter(command)

                    ' Create a DataTable to store the fetched data
                    Dim dataTable As New DataTable()

                    ' Open the connection
                    connection.Open()

                    ' Fill the DataTable with data from the database
                    adapter.Fill(dataTable)

                    ' Loop through each row in the DataTable and add it to the ListView
                    For Each row As DataRow In dataTable.Rows
                        Dim item As New ListViewItem(row("description").ToString())
                        item.SubItems.Add(row("applyDate").ToString())
                        item.SubItems.Add(row("totalDays").ToString())

                        listViewLeaves.Items.Add(item)
                    Next

                    ' Auto resize columns after adding items
                    listViewLeaves.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user leaves: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchTerm As String = txtSearch.Text.Trim()
            LoadUserLeaves(searchTerm)
        Catch ex As Exception
            MessageBox.Show("Error searching leaves: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            txtSearch.Clear()
            LoadUserLeaves("") ' Load leaves without any search term (show all user's leaves)
        Catch ex As Exception
            MessageBox.Show("Error clearing search: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim leave As New AddLeavesForm
            leave.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening leave form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub listViewLeaves_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewLeaves.SelectedIndexChanged
        ' Handle ListView selection changes here if needed
    End Sub
End Class
