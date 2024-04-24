Imports System.Data.SqlClient

Public Class AddHolidayForm
    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        Dim title As String = titleBox.Text.Trim()
        Dim startDate As Date = DateTimePicker1.Value
        Dim endDays As Integer = Convert.ToInt32(DateTimePicker2.Value.Subtract(startDate).Days)

        ' Validate inputs
        If String.IsNullOrEmpty(title) Then
            MessageBox.Show("Please enter a title for the holiday.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim query As String = "INSERT INTO holidaysTable (title, startDays, endDays) VALUES (@Title, @StartDate, @EndDays)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Title", title)
                command.Parameters.AddWithValue("@StartDate", startDate)
                command.Parameters.AddWithValue("@EndDays", endDays)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Holiday added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear input fields after successful submission
                    titleBox.Text = ""
                    DateTimePicker1.Value = DateTime.Now
                    DateTimePicker2.Value = DateTime.Now
                Catch ex As Exception
                    MessageBox.Show("An error occurred while adding the holiday. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub titleBox_TextChanged(sender As Object, e As EventArgs) Handles titleBox.TextChanged
        ' You can add any specific validation or formatting logic here if needed
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' You can add any specific logic related to start date changes here
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        ' You can add any specific logic related to end date changes here
    End Sub
End Class
