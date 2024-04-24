Imports System.Data.SqlClient

Public Class HolidaysForm
    Dim dataTable As New DataTable() ' Define a DataTable variable at the class level to store fetched data

    Private Sub HolidaysForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up columns in ListView
        listViewHolidays.Columns.Add("Title", 150)
        listViewHolidays.Columns.Add("Start Date", 120)
        listViewHolidays.Columns.Add("End Date", 120)

        LoadHolidaysData()
    End Sub

    Private Sub LoadHolidaysData()
        ' Clear existing items in the ListView
        listViewHolidays.Items.Clear()

        ' Assuming you have a connection string and a database setup
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim query As String = "SELECT title, CONVERT(date, startDays) AS startDate, CONVERT(date, endDays) AS endDate FROM holidaysTable"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)

                connection.Open()
                adapter.Fill(dataTable)

                ' Populate ListView with data
                For Each row As DataRow In dataTable.Rows
                    Dim startDate As DateTime = DateTime.Parse(row("startDate").ToString())
                    Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd") ' Customize the format as needed

                    Dim endDate As DateTime = DateTime.Parse(row("endDate").ToString())
                    Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd") ' Customize the format as needed

                    Dim item As New ListViewItem(row("title").ToString())
                    item.SubItems.Add(formattedStartDate)
                    item.SubItems.Add(formattedEndDate)
                    listViewHolidays.Items.Add(item)
                Next
            End Using
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        ' Clear existing items in the ListView
        listViewHolidays.Items.Clear()

        ' Filter and add matching items to the ListView
        For Each row As DataRow In dataTable.Rows
            If row("title").ToString().ToLower().Contains(searchText) Then
                Dim startDate As DateTime = DateTime.Parse(row("startDate").ToString())
                Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd") ' Customize the format as needed

                Dim endDate As DateTime = DateTime.Parse(row("endDate").ToString())
                Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd") ' Customize the format as needed

                Dim item As New ListViewItem(row("title").ToString())
                item.SubItems.Add(formattedStartDate)
                item.SubItems.Add(formattedEndDate)
                listViewHolidays.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub addHoliday_Click(sender As Object, e As EventArgs) Handles addHoliday.Click
        Dim holiday As New AddHolidayForm
        holiday.Show()
    End Sub

    Private Sub listViewHolidays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewHolidays.SelectedIndexChanged

    End Sub
End Class
