Imports System.Data.SqlClient

Public Class AddLeavesForm
    Private Sub AddLeavesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can add initialization code here if needed
    End Sub

    Private Sub btnAddLeave_Click(sender As Object, e As EventArgs) Handles btnAddLeave.Click
        ' Validate input fields before adding leave

        ' Example validation: check if any field is empty
        If String.IsNullOrWhiteSpace(My.Settings.userId) OrElse String.IsNullOrWhiteSpace(txtTotalDays.Text) OrElse
            String.IsNullOrWhiteSpace(txtDescription.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the date is selected in the DateTimePicker
        If datePickerApplyDate.Value.Date < DateTime.Today Then
            MessageBox.Show("Invalid apply date. Please select a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Assuming you have a database connection and a leavesTable in your database
        ' Define your connection string
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        ' Define your SQL query to insert leave data into the database
        Dim query As String = "INSERT INTO leavesTable (staffId, applyDate, totalDays, description, status) " &
                              "VALUES (@StaffID, @ApplyDate, @TotalDays, @Description, @Status)"

        ' Create a SqlConnection object
        Using connection As New SqlConnection(connectionString)
            ' Create a SqlCommand object with your query and connection
            Using command As New SqlCommand(query, connection)
                ' Add parameters for the input fields
                command.Parameters.AddWithValue("@StaffID", My.Settings.userId)
                command.Parameters.AddWithValue("@ApplyDate", datePickerApplyDate.Value.Date)
                command.Parameters.AddWithValue("@TotalDays", txtTotalDays.Text)
                command.Parameters.AddWithValue("@Description", txtDescription.Text)
                command.Parameters.AddWithValue("@Status", 0) ' Default status (Pending)

                ' Open the connection
                connection.Open()

                ' Execute the insert query
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Leave added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear input fields after successful addition
                    ClearInputFields()
                Else
                    MessageBox.Show("Failed to add leave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub ClearInputFields()
        ' Clear all input fields

        txtTotalDays.Clear()
        txtDescription.Clear()
        datePickerApplyDate.Value = DateTime.Today ' Reset date picker to today's date
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
