
Imports System.Data.SqlClient

Public Class AdminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DateTimePicker for check-in
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt"
        DateTimePicker1.ShowUpDown = False

        ' Set up DateTimePicker for check-out
        checkoutDateTime.Format = DateTimePickerFormat.Custom
        checkoutDateTime.CustomFormat = "dd/MM/yyyy hh:mm tt"
        checkoutDateTime.ShowUpDown = False

        ' Load statistics and populate staff dropdown for check-in
        LoadStatistics()
        PopulateCheckInDropdown()
        PopulateCheckOutDropdown()
    End Sub
    Private Sub PopulateCheckInDropdown()
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim todayDate As Date = DateTime.Now.Date
        Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay

        ' Query to fetch staff members who have not checked in today and have a checkout time less than current time
        Dim query As String = "SELECT DISTINCT s.staffId, s.displayName " &
                          "FROM staffTable s " &
                          "LEFT JOIN Attendance a ON s.staffId = a.staffId AND a.AttendanceDate = @TodayDate " &
                          "LEFT JOIN checkOutTable c ON s.staffId = c.staffId AND CAST(c.CheckOutTime AS TIME) < @CurrentTime " &
                          "WHERE a.staffId IS NULL AND s.role = 'staff' " &
                          "ORDER BY s.displayName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@TodayDate", todayDate)
                command.Parameters.AddWithValue("@CurrentTime", currentTime.ToString("hh\:mm\:ss")) ' Convert TimeSpan to string in HH:mm:ss format

                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim staffId As String = reader("staffId").ToString()
                    Dim displayName As String = reader("displayName").ToString()
                    Dim item As New KeyValuePair(Of String, String)(staffId, displayName)
                    staffDropdown.Items.Add(item)

                    ' Add debug logging to check the retrieved data
                    Console.WriteLine("Staff ID: " & staffId & ", Display Name: " & displayName)
                End While

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub PopulateCheckOutDropdown()
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        ' Query to fetch staff members who have checked in today
        Dim query As String = "SELECT DISTINCT s.staffId, s.displayName " &
                          "FROM staffTable s " &
                          "JOIN Attendance a ON s.staffId = a.staffId AND a.AttendanceDate = @TodayDate " &
                          "WHERE a.CheckOutTime IS NULL " &
                          "ORDER BY s.displayName"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@TodayDate", DateTime.Now.Date)

                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim staffId As String = reader("staffId").ToString()
                    Dim displayName As String = reader("displayName").ToString()
                    Dim item As New KeyValuePair(Of String, String)(staffId, displayName)
                    checkOutDropdown.Items.Add(item)

                    ' Add debug logging to check the retrieved data
                    Console.WriteLine("Staff ID: " & staffId & ", Display Name: " & displayName)
                End While

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub checkInButton_Click(sender As Object, e As EventArgs) Handles checkInButton.Click
        If staffDropdown.SelectedItem IsNot Nothing Then
            Dim selectedStaffItem As KeyValuePair(Of String, String) = DirectCast(staffDropdown.SelectedItem, KeyValuePair(Of String, String))
            Dim selectedStaffId As String = selectedStaffItem.Key

            If Not String.IsNullOrEmpty(selectedStaffId) Then
                Dim checkInTime As DateTime = DateTime.Now ' Get current date and time

                Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
                Dim checkInQuery As String = "INSERT INTO Attendance (StaffId, AttendanceDate, CheckInTime) VALUES (@StaffId, @AttendanceDate, @CheckInTime)"

                Try
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(checkInQuery, connection)
                            command.Parameters.AddWithValue("@StaffId", selectedStaffId)
                            command.Parameters.AddWithValue("@AttendanceDate", DateTime.Now.Date)
                            command.Parameters.AddWithValue("@CheckInTime", checkInTime)

                            connection.Open()
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                ' Reload dropdowns
                                PopulateCheckInDropdown()
                                PopulateCheckOutDropdown()
                                LoadStatistics()
                                MessageBox.Show("Check-in recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Failed to record check-in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Selected staff ID is empty or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a staff member to check in.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub checkOutButton_Click(sender As Object, e As EventArgs) Handles checkOutButton.Click
        If checkOutDropdown.SelectedItem IsNot Nothing Then
            Dim selectedStaffItem As KeyValuePair(Of String, String) = DirectCast(checkOutDropdown.SelectedItem, KeyValuePair(Of String, String))
            Dim selectedStaffId As String = selectedStaffItem.Key

            If Not String.IsNullOrEmpty(selectedStaffId) Then
                Dim checkOutTime As DateTime = DateTime.Now ' Get current date and time

                Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
                Dim checkOutQuery As String = "UPDATE Attendance SET CheckOutTime = @CheckOutTime WHERE StaffId = @StaffId AND AttendanceDate = @AttendanceDate AND CheckOutTime IS NULL"

                Try
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(checkOutQuery, connection)
                            command.Parameters.AddWithValue("@StaffId", selectedStaffId)
                            command.Parameters.AddWithValue("@AttendanceDate", DateTime.Now.Date)
                            command.Parameters.AddWithValue("@CheckOutTime", checkOutTime)

                            connection.Open()
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                ' Reload dropdowns
                                PopulateCheckInDropdown()
                                PopulateCheckOutDropdown()
                                LoadStatistics()
                                MessageBox.Show("Check-out recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("Failed to record check-out. Maybe the check-out was already recorded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Selected staff ID is empty or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a staff member to check out.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub




    Private Function GetStaffDisplayName(ByVal staffId As String) As String
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim query As String = "SELECT displayName FROM staffTable WHERE staffId = @StaffId"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@StaffId", staffId)

                connection.Open()
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return result.ToString()
                End If
            End Using
        End Using

        Return ""
    End Function

    Private Sub LoadStatistics()
        Dim todayDate As Date = DateTime.Now.Date
        Dim presentCount As Integer = 0
        Dim absentCount As Integer = 0
        Dim leavesCount As Integer = 0
        Dim totalStaffCount As Integer = 0

        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        Dim presentQuery As String = "SELECT COUNT(*) FROM Attendance a JOIN staffTable s ON a.staffId = s.staffId WHERE a.AttendanceDate = @TodayDate AND (a.CheckInTime IS NULL OR a.CheckOutTime IS NULL) AND s.role = 'staff'"

        Dim leavesQuery As String = "SELECT COUNT(*) FROM leavesTable WHERE applyDate = @TodayDate"
        Dim totalStaffQuery As String = "SELECT COUNT(*) FROM staffTable WHERE role = 'staff'"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(presentQuery, connection)
                command.Parameters.AddWithValue("@TodayDate", todayDate)
                connection.Open()
                Dim presentResult As Object = command.ExecuteScalar()

                If presentResult IsNot Nothing AndAlso Not IsDBNull(presentResult) Then
                    presentCount = Convert.ToInt32(presentResult)
                End If
            End Using

            Using command As New SqlCommand(leavesQuery, connection)
                command.Parameters.AddWithValue("@TodayDate", todayDate)
                Dim leavesResult As Object = command.ExecuteScalar()

                If leavesResult IsNot Nothing AndAlso Not IsDBNull(leavesResult) Then
                    leavesCount = Convert.ToInt32(leavesResult)
                End If
            End Using

            Using command As New SqlCommand(totalStaffQuery, connection)
                Dim totalStaffResult As Object = command.ExecuteScalar()

                If totalStaffResult IsNot Nothing AndAlso Not IsDBNull(totalStaffResult) Then
                    totalStaffCount = Convert.ToInt32(totalStaffResult)
                End If
            End Using
        End Using

        absentCount = totalStaffCount - presentCount

        present.Text = presentCount.ToString()
        TextBox1.Text = absentCount.ToString()
        TextBox2.Text = leavesCount.ToString()
        TextBox3.Text = totalStaffCount.ToString()
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Settings.IsLoggedIn = False
        My.Settings.UserRole = ""
        My.Settings.userId = ""
        My.Settings.Save()

        Dim splashForm As New SplashScreen()
        Me.Hide()
        splashForm.Show()
    End Sub

    Private Sub viewStaffBtn_Click(sender As Object, e As EventArgs) Handles viewStaffBtn.Click
        Dim staffScreen As New Staff()
        staffScreen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim presetnStaffScreen As New PresentStaffform()
        presetnStaffScreen.Show()
    End Sub







    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles leavesbtn.Click
        Dim leavestaf As New LeaveStatusForm()
        leavestaf.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim loggedInStaffId As String = My.Settings.userId

        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim query As String = "SELECT displayName FROM staffTable WHERE staffId = @StaffId"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@StaffId", loggedInStaffId)

                connection.Open()
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing Then
                    companyName.Text = result.ToString()
                Else
                    companyName.Text = "Unknown"
                End If
            End Using
        End Using
    End Sub

    Private Sub holidaysButton_Click(sender As Object, e As EventArgs) Handles holidaysButton.Click
        Dim holiday As New HolidaysForm()
        holiday.Show()
    End Sub

    Private Sub AddStafbtn_Click(sender As Object, e As EventArgs) Handles AddStafbtn.Click
        Dim addstaff As New AddStaffForm()
        addstaff.Show()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
