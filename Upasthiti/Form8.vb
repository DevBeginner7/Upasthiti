Imports System.Data.SqlClient

Public Class LeaveStatusForm
    Dim dataTable As New DataTable()

    Private Sub LeaveStatusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up ListView columns

        listViewLeaves.Columns.Add("Staff Name", 150)
        listViewLeaves.Columns.Add("Email", 200)
        listViewLeaves.Columns.Add("Apply Date", 150)
        listViewLeaves.Columns.Add("Total Days", 100)
        listViewLeaves.Columns.Add("Description", 200)
        listViewLeaves.Columns.Add("Status", 100)


        ' Load leaves data from the database
        LoadLeavesData()
    End Sub

    Private Sub LoadLeavesData()
        listViewLeaves.Items.Clear()
        listViewLeaves.FullRowSelect = True
        dataTable.Clear()

        txtSearch.Clear()
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        Dim query As String = "SELECT lt.staffId, st.displayName, st.email, lt.applyDate, lt.totalDays, lt.description, lt.status " &
                              "FROM leavesTable lt " &
                              "INNER JOIN staffTable st ON lt.staffId = st.staffId " &
                              "ORDER BY lt.applyDate DESC"


        Using connection As New SqlConnection(connectionString)
            ' Create a SqlCommand object with your query and connection
            Using command As New SqlCommand(query, connection)
                ' Create a SqlDataAdapter to fill the data into a DataTable
                Dim adapter As New SqlDataAdapter(command)

                ' Open the connection
                connection.Open()

                ' Fill the DataTable with data from the database
                adapter.Fill(dataTable)

                ' Loop through each row in the DataTable and add it to the ListView
                For Each row As DataRow In dataTable.Rows
                    Dim item As New ListViewItem(row("displayName").ToString())

                    item.SubItems.Add(row("email").ToString())
                    item.SubItems.Add(row("applyDate").ToString())
                    item.SubItems.Add(row("totalDays").ToString())
                    item.SubItems.Add(row("description").ToString())
                    Dim statusText As String = GetStatusText(CInt(row("status")))
                    item.SubItems.Add(statusText)

                    ' Create buttons for each row
                    Dim approveButton As New Button()
                    approveButton.Text = "Approve"
                    AddHandler approveButton.Click, AddressOf ApproveButton_Click
                    approveButton.Tag = row

                    Dim declineButton As New Button()
                    declineButton.Text = "Decline"
                    AddHandler declineButton.Click, AddressOf DeclineButton_Click
                    declineButton.Tag = row

                    Dim actionPanel As New FlowLayoutPanel()
                    actionPanel.Controls.Add(approveButton)
                    actionPanel.Controls.Add(declineButton)

                    Dim actionItem As New ListViewItem.ListViewSubItem(item, "")
                    actionItem.Tag = actionPanel
                    item.SubItems.Add(actionItem)

                    listViewLeaves.Items.Add(item)
                Next

                ' Auto resize columns after adding items
                listViewLeaves.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            End Using
        End Using
    End Sub

    Private Function GetStatusText(statusCode As Integer) As String
        Select Case statusCode
            Case 0
                Return "Pending"
            Case 1
                Return "Approved"
            Case 2
                Return "Declined"
            Case Else
                Return "Unknown"
        End Select
    End Function
    Private Sub ApproveButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim row As DataRow = DirectCast(button.Tag, DataRow)
        Dim staffId As String = row("staffId").ToString()
        Dim applyDate As Date = Date.Parse(row("applyDate").ToString())

        ' Check if there are pending leaves for this staff member with future apply dates
        Dim pendingLeaves() As DataRow = dataTable.Select($"staffId = '{staffId}' AND status = 0 AND applyDate > GETDATE()")

        If pendingLeaves.Length = 0 Then
            MessageBox.Show("There are no pending leaves with future apply dates for this staff member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Find the pending leave with the earliest apply date
        Dim earliestLeave As DataRow = pendingLeaves(0)
        Dim earliestApplyDate As Date = Date.Parse(earliestLeave("applyDate").ToString())

        For Each pendingLeave As DataRow In pendingLeaves
            Dim leaveApplyDate As Date = Date.Parse(pendingLeave("applyDate").ToString())
            If leaveApplyDate < earliestApplyDate Then
                earliestLeave = pendingLeave
                earliestApplyDate = leaveApplyDate
            End If
        Next

        Dim leaveIdToApprove As Integer = Integer.Parse(earliestLeave("leaveId").ToString())
        UpdateLeaveStatus(leaveIdToApprove, "1") ' Update status to Approved (1)
        LoadLeavesData() ' Reload data after update
    End Sub


    Private Sub DeclineButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim row As DataRow = DirectCast(button.Tag, DataRow)

        UpdateLeaveStatus(row("staffId").ToString(), "2")
        LoadLeavesData() ' Reload data after update
    End Sub

    Private Sub UpdateLeaveStatus(leaveId As Integer, newStatus As String)
        ' Define your connection string
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        ' Define your SQL query to update leave status
        Dim query As String = "UPDATE leavesTable SET status = @newStatus WHERE leaveId = @leaveId"

        Try
            ' Create a SqlConnection object
            Using connection As New SqlConnection(connectionString)
                ' Create a SqlCommand object with your query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@newStatus", newStatus)
                    command.Parameters.AddWithValue("@leaveId", leaveId)

                    ' Open the connection
                    connection.Open()

                    ' Execute the update query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Leave status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No rows were updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating leave status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub listViewLeaves_MouseClick(sender As Object, e As MouseEventArgs) Handles listViewLeaves.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim item As ListViewItem = listViewLeaves.GetItemAt(e.X, e.Y)

            If item IsNot Nothing Then
                Dim statusText As String = item.SubItems(item.SubItems.Count - 2).Text ' Get status text
                Dim staffId As String = item.SubItems(0).Text ' Assuming staffId is first column

                Select Case statusText.Trim().ToLowerInvariant()
                    Case "pending"
                        Dim result As DialogResult = MessageBox.Show("Approve this leave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            UpdateLeaveStatus(staffId, "1") ' Update status to Approved (1)
                            LoadLeavesData() ' Reload data after update
                        End If
                    Case "declined"
                        Dim result As DialogResult = MessageBox.Show("Decline this leave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            UpdateLeaveStatus(staffId, "2") ' Update status to Declined (2)
                            LoadLeavesData() ' Reload data after update
                        End If
                    Case Else

                End Select
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Filter the DataTable based on the search term
        Dim filteredRows() As DataRow = dataTable.Select("displayName LIKE '%" & searchTerm & "%'")

        ' Clear the ListView before adding filtered items
        listViewLeaves.Items.Clear()

        ' Add filtered rows to the ListView
        For Each row As DataRow In filteredRows
            Dim item As New ListViewItem(row("displayName").ToString())

            item.SubItems.Add(row("email").ToString())
            item.SubItems.Add(row("applyDate").ToString())
            item.SubItems.Add(row("totalDays").ToString())
            item.SubItems.Add(row("description").ToString())
            Dim statusText As String = GetStatusText(CInt(row("status")))
            item.SubItems.Add(statusText)

            ' Create buttons for each row (same as in LoadLeavesData method)

            listViewLeaves.Items.Add(item)
        Next

        ' Auto resize columns after adding items
        listViewLeaves.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ReloadAllLeavesData()

        listViewLeaves.Items.Clear()
        ' Reload leaves data from the database
        LoadLeavesData()

        ' Auto resize columns after adding items
        listViewLeaves.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        ReloadAllLeavesData()
    End Sub

    Private Sub listViewLeaves_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewLeaves.SelectedIndexChanged

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
