Imports System.Data.SqlClient

Public Class SignUpForm
    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        ' Check if all required fields are filled
        If nameBox.Text.Trim() = "" OrElse emailbox.Text.Trim() = "" OrElse addressbox.Text.Trim() = "" OrElse passwordbox.Text.Trim() = "" OrElse panNumberBox.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Assuming you have a connection string and a database setup
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim query As String = "INSERT INTO staffTable (displayName,number, email, address,post,password, role, joinDate, panNumber, cardNumber, staffId) VALUES (@Name,@number, @Email, @Address,@post,@password ,@Role, @JoinDate, @PanNumber, '1234', @staffId)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Set parameter values
                command.Parameters.AddWithValue("@Name", nameBox.Text)
                command.Parameters.AddWithValue("@Email", emailbox.Text)
                command.Parameters.AddWithValue("@Address", addressbox.Text)
                command.Parameters.AddWithValue("@post", "administrator")
                command.Parameters.AddWithValue("@password", passwordbox.Text)
                command.Parameters.AddWithValue("@Role", "admin") ' Default role is admin
                command.Parameters.AddWithValue("@JoinDate", DateTime.Now) ' Account created date
                command.Parameters.AddWithValue("@PanNumber", panNumberBox.Text)
                command.Parameters.AddWithValue("@number", numberBox.Text)
                command.Parameters.AddWithValue("@staffId", GenerateRoleId()) ' Generate role ID

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Company registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        Dim splashScreen As New SplashScreen
                        Me.Hide()
                        splashScreen.Show()


                        ClearFormFields()
                    Else
                        MessageBox.Show("Failed to register company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error registering company: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Function to generate a unique role ID (e.g., using GUID)
    Private Function GenerateRoleId() As String
        Return Guid.NewGuid().ToString()
    End Function

    ' Function to clear form fields after successful registration
    Private Sub ClearFormFields()
        nameBox.Text = ""
        emailbox.Text = ""
        addressbox.Text = ""
        passwordbox.Text = ""
        panNumberBox.Text = ""
        numberBox.Text = ""
    End Sub
End Class
