Imports System.Data.SqlClient

Public Class PresentStaffform
    Dim dataTable As New DataTable() ' Define a DataTable variable at the class level to store fetched data

    Private Sub PresentStaffform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up columns in ListView
        listViewPresentStaff.Columns.Add("Display Name", 150)
        listViewPresentStaff.Columns.Add("Post", 150)
        listViewPresentStaff.Columns.Add("Attendance Time", 120)
        listViewPresentStaff.Columns.Add("Email", 200)
        listViewPresentStaff.Columns.Add("Address", 200)
        listViewPresentStaff.Columns.Add("Number", 100)

        LoadPresentStaffData()
    End Sub

    Private Sub LoadPresentStaffData()
        ' Get today's date and time
        Dim todayDate As Date = DateTime.Now.Date

        ' Assuming you have a connection string and a database setup
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim query As String = "SELECT a.staffId, a.attendanceDate, a.CheckInTime, s.displayName, s.email, s.number, s.address, s.post " &
                              "FROM Attendance a " &
                              "JOIN staffTable s ON a.staffId = s.staffId " &
                              "WHERE a.attendanceDate = @TodayDate AND a.CheckOutTime IS NULL " &
                              "AND a.CheckInTime IS NOT NULL"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@TodayDate", todayDate)

                Dim adapter As New SqlDataAdapter(command)

                connection.Open()
                adapter.Fill(dataTable)

                ' Populate ListView with data
                For Each row As DataRow In dataTable.Rows
                    Dim item As New ListViewItem(row("displayName").ToString())
                    item.SubItems.Add(row("post").ToString())
                    item.SubItems.Add(row("CheckInTime").ToString())
                    item.SubItems.Add(row("email").ToString())
                    item.SubItems.Add(row("address").ToString())
                    item.SubItems.Add(row("number").ToString())
                    listViewPresentStaff.Items.Add(item)
                Next

                ' Adjust column widths after adding items
                listViewPresentStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

                ' Check and enable scrollbars if needed
                If listViewPresentStaff.Columns.Count > 0 AndAlso listViewPresentStaff.Items.Count > 0 Then
                    listViewPresentStaff.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize) ' Resize first column to fit headers
                    If listViewPresentStaff.Items.Count * listViewPresentStaff.Items(0).Bounds.Height > listViewPresentStaff.Height Then
                        listViewPresentStaff.Scrollable = True
                    Else
                        listViewPresentStaff.Scrollable = False
                    End If
                End If
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchName As String = txtSearch.Text.Trim().ToLower()

        ' Clear existing items in the ListView
        listViewPresentStaff.Items.Clear()
        Dim foundMatch As Boolean = False
        ' Filter and add matching items to the ListView
        For Each row As DataRow In dataTable.Rows
            If row("displayName").ToString().ToLower().Contains(searchName) Then
                Dim item As New ListViewItem(row("displayName").ToString())
                item.SubItems.Add(row("post").ToString())
                item.SubItems.Add(row("CheckInTime").ToString())
                item.SubItems.Add(row("email").ToString())
                item.SubItems.Add(row("address").ToString())
                item.SubItems.Add(row("number").ToString())
                listViewPresentStaff.Items.Add(item)
                foundMatch = True
            End If
        Next

        ' Adjust column widths after adding items
        listViewPresentStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        If Not foundMatch Then
            lblNoStaff.Text = "No staff with this name."
        Else
            lblNoStaff.Text = "" ' Clear the label if there are matching staff
        End If
    End Sub

    Private Sub lblNoStaff_TextChanged(sender As Object, e As EventArgs)
        ' You can add any specific logic here if needed when the label text changes
    End Sub

    Private Sub listViewPresentStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewPresentStaff.SelectedIndexChanged
        ' You can add any specific logic here when an item in the ListView is selected
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = "" ' Clear the search text
        listViewPresentStaff.Items.Clear() ' Clear the ListView
        dataTable.Clear() ' Clear the DataTable
        LoadPresentStaffData() ' 
    End Sub
End Class
