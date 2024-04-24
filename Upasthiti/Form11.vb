Imports System.Data.SqlClient

Public Class AddStaffForm
    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        ' Generate a random staffId
        Dim random As New Random()
        Dim staffId As String = "STF" & random.Next(1000, 9999).ToString()

        ' Get the current date and format it
        Dim joinDate As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' Define your connection string
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        ' Define your SQL query to insert a new staff member
        Dim query As String = "INSERT INTO staffTable (displayName, number, email, address, post, password, joinDate, panNumber, cardNumber, role, staffId) " &
                              "VALUES (@displayName, @number, @email, @address, @post, @password, @joinDate, @panNumber, @cardNumber, @role, @staffId)"

        Try
            ' Create a SqlConnection object
            Using connection As New SqlConnection(connectionString)
                ' Create a SqlCommand object with your query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@displayName", displaynamebox.Text)
                    command.Parameters.AddWithValue("@number", numberBox.Text)
                    command.Parameters.AddWithValue("@email", emailbox.Text)
                    command.Parameters.AddWithValue("@address", addressbox.Text)
                    command.Parameters.AddWithValue("@post", postbox.Text)
                    command.Parameters.AddWithValue("@password", passwordbox.Text)
                    command.Parameters.AddWithValue("@joinDate", joinDate)
                    command.Parameters.AddWithValue("@panNumber", panNumberBox.Text)
                    command.Parameters.AddWithValue("@cardNumber", cardnumberbox.Text)
                    command.Parameters.AddWithValue("@role", "staff")
                    command.Parameters.AddWithValue("@staffId", staffId)

                    ' Open the connection
                    connection.Open()

                    ' Execute the insert query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("New staff member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Clear the text boxes after successful insertion
                        displaynamebox.Clear()
                        numberBox.Clear()
                        emailbox.Clear()
                        addressbox.Clear()
                        postbox.Clear()
                        passwordbox.Clear()
                        panNumberBox.Clear()
                        cardnumberbox.Clear()
                    Else
                        MessageBox.Show("No rows were inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding a new staff member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AddStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
