Imports System.Data.SqlClient

Public Class Form1

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles emailLable.Click
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate email and password format
        If Not IsValidEmail(TextBox1.Text) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If TextBox2.Text.Trim() = "" Then
            MessageBox.Show("Please enter a password.", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim con As SqlConnection = New SqlConnection("Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM staffTable WHERE email=@Email AND password=@Password", con)

        cmd.Parameters.AddWithValue("@Email", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Password", TextBox2.Text)

        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()

            Dim role As String = reader("role").ToString()
            Dim id As String = reader("staffId").ToString
            If role = "admin" Then
                Try
                    Dim adminForm As New AdminForm()
                    Me.Hide()
                    adminForm.Show()

                    My.Settings.userId = id
                    My.Settings.IsLoggedIn = True
                    My.Settings.UserRole = "admin"

                    My.Settings.Save()
                Catch ex As Exception
                    MessageBox.Show("Error opening AdminForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf role = "staff" Then
                Try
                    Dim staffForm As New StaffForm()
                    Me.Hide()
                    staffForm.Show()

                    My.Settings.userId = id
                    My.Settings.IsLoggedIn = True
                    My.Settings.UserRole = "staff"
                    My.Settings.Save()
                Catch ex As Exception
                    MessageBox.Show("Error opening StaffForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Login failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        reader.Close()
        con.Close()
    End Sub

    ' Function to validate email format
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Eye button click event to toggle password visibility
    Private Sub btnEye_Click(sender As Object, e As EventArgs) Handles btnEye.Click
        If TextBox2.UseSystemPasswordChar Then
            TextBox2.UseSystemPasswordChar = False
            btnEye.Text = "👁️" ' Unicode character for open eye
        Else
            TextBox2.UseSystemPasswordChar = True
            btnEye.Text = "🔒" ' Unicode character for locked
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim signUpForm As New SignUpForm()

        signUpForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
