Imports System.Data.SqlClient

Public Class Staff
    ' Define a DataTable to store the original data loaded from the database
    Private dataTable As DataTable

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up ListView columns and load staff data
        SetupListView()
        LoadStaffData()
    End Sub

    Private Sub SetupListView()
        ' Set the ListView to Details view
        listViewStaff.View = View.Details

        ' Add columns with headers and widths

        listViewStaff.Columns.Add("Display Name", 150)
        listViewStaff.Columns.Add("Number", 100)
        listViewStaff.Columns.Add("Email", 200)
        listViewStaff.Columns.Add("Address", 200)
        listViewStaff.Columns.Add("Post", 100)

        listViewStaff.Columns.Add("Join Date", 100)
        listViewStaff.Columns.Add("PAN Number", 100)
        listViewStaff.Columns.Add("Card Number", 100)
        listViewStaff.Columns.Add("Role", 100)

        ' Store the original data in a DataTable
        dataTable = New DataTable()

        dataTable.Columns.Add("Display Name")
        dataTable.Columns.Add("Number")
        dataTable.Columns.Add("Email")
        dataTable.Columns.Add("Address")
        dataTable.Columns.Add("Post")

        dataTable.Columns.Add("Join Date")
        dataTable.Columns.Add("PAN Number")
        dataTable.Columns.Add("Card Number")
        dataTable.Columns.Add("Role")
    End Sub

    Private Sub LoadStaffData()
        ' Clear existing items in the ListView
        listViewStaff.Items.Clear()

        ' Clear the DataTable before loading new data
        dataTable.Clear()

        ' Assuming you have a connection string and a database setup
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim query As String = "SELECT * FROM staffTable WHERE role = 'staff' ORDER BY displayName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        ' Add the data to the DataTable
                        Dim row As DataRow = dataTable.NewRow()

                        row("Display Name") = reader("displayName").ToString()
                        row("Number") = reader("number").ToString()
                        row("Email") = reader("email").ToString()
                        row("Address") = reader("address").ToString()
                        row("Post") = reader("post").ToString()

                        row("Join Date") = reader("joinDate").ToString()
                        row("PAN Number") = reader("panNumber").ToString()
                        row("Card Number") = reader("cardNumber").ToString()
                        row("Role") = reader("role").ToString()
                        dataTable.Rows.Add(row)
                    End While

                    ' Add items to the ListView from the DataTable
                    For Each row As DataRow In dataTable.Rows
                        Dim item As New ListViewItem(row("Display Name").ToString())

                        item.SubItems.Add(row("Number").ToString())
                        item.SubItems.Add(row("Email").ToString())
                        item.SubItems.Add(row("Address").ToString())
                        item.SubItems.Add(row("Post").ToString())

                        item.SubItems.Add(row("Join Date").ToString())
                        item.SubItems.Add(row("PAN Number").ToString())
                        item.SubItems.Add(row("Card Number").ToString())
                        item.SubItems.Add(row("Role").ToString())
                        listViewStaff.Items.Add(item)
                    Next
                Else
                    MessageBox.Show("No staff data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                reader.Close()
            End Using
        End Using

        ' Adjust column widths after adding items
        listViewStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchName As String = txtSearch.Text.Trim().ToLower()


        If Not String.IsNullOrEmpty(searchName) Then
            ' Clear existing items in the ListView
            listViewStaff.Items.Clear()
            Dim foundMatch As Boolean = False
            ' Filter and add matching items to the ListView
            For Each row As DataRow In dataTable.Rows
                If row("Display Name").ToString().ToLower().Contains(searchName) Then
                    Dim item As New ListViewItem(row("Display Name").ToString())

                    item.SubItems.Add(row("Number").ToString())
                    item.SubItems.Add(row("Email").ToString())
                    item.SubItems.Add(row("Address").ToString())
                    item.SubItems.Add(row("Post").ToString())

                    item.SubItems.Add(row("Join Date").ToString())
                    item.SubItems.Add(row("PAN Number").ToString())
                    item.SubItems.Add(row("Card Number").ToString())
                    item.SubItems.Add(row("Role").ToString())
                    listViewStaff.Items.Add(item)
                End If
            Next

            ' Adjust column widths after adding items
            listViewStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            If Not foundMatch Then
                lblNoStaff.Text = "No staff with this name."
            Else
                lblNoStaff.Text = "" ' Clear the label if there are matching staff
            End If

        Else
            ' If search criteria is empty, reload all data
            LoadStaffData()
        End If
    End Sub

    Private Sub lblNoStaff_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub listViewStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewStaff.SelectedIndexChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = "" ' Clear the search text
        listViewStaff.Items.Clear() ' Clear the ListView
        LoadStaffData() ' Reload the original data
    End Sub
End Class
