Imports System.Data.SqlClient

Public Class StaffForm

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if the user is logged in and has a saved Staff ID
        If My.Settings.IsLoggedIn AndAlso Not String.IsNullOrEmpty(My.Settings.userId) Then
            ' Load the staff member based on the saved Staff ID
            LoadStaffMember(My.Settings.userId)
            ' Update check-in status label
            UpdateCheckInStatusLabel(My.Settings.userId)
        Else
            MessageBox.Show("No staff member found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoadStaffMember(staffId As String)
        ' Connect to your SQL Server database
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        ' Query to fetch the staff member based on the saved Staff ID
        Dim query As String = "SELECT staffId, displayName FROM staffTable WHERE staffId = @StaffId AND role = 'staff'"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Set the parameter for the query using the saved Staff ID
                command.Parameters.AddWithValue("@StaffId", staffId)

                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Check if a staff member was found with the saved ID
                If reader.Read() Then
                    Dim staffIdFromDB As String = reader("staffId").ToString()
                    Dim displayName As String = reader("displayName").ToString()

                    ' Check if the staff ID from the database matches the saved Staff ID
                    If staffIdFromDB = staffId Then
                        lblDisplayName.Text = displayName
                    Else
                        ' If there is a mismatch, display an error message
                        MessageBox.Show("No staff member found with the saved ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    ' If no staff member was found with the saved ID, display an error message
                    MessageBox.Show("No staff member found with the saved ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub UpdateCheckInStatusLabel(staffId As String)
        ' Connect to your SQL Server database
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        ' Query to check if the staff member has checked in and/or checked out today
        Dim checkStatusQuery As String = "SELECT CheckInTime, CheckOutTime FROM Attendance WHERE StaffId = @StaffId AND AttendanceDate = @AttendanceDate"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(checkStatusQuery, connection)
                ' Set parameters for the query
                command.Parameters.AddWithValue("@StaffId", staffId)
                command.Parameters.AddWithValue("@AttendanceDate", DateTime.Now.Date)

                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Check if the reader has rows (staff member has attendance records for today)
                If reader.HasRows Then
                    reader.Read() ' Move to the first row

                    ' Check if both CheckInTime and CheckOutTime are not null
                    If Not reader.IsDBNull(0) AndAlso Not reader.IsDBNull(1) Then
                        ' Both check-in and check-out times are recorded
                        lblCheckInStatus.Text = "Shift Complete"
                    ElseIf Not reader.IsDBNull(0) Then
                        ' Only check-in time is recorded
                        lblCheckInStatus.Text = "Checked In"
                    Else
                        ' No check-in time recorded
                        lblCheckInStatus.Text = "No Check In"
                    End If
                Else
                    ' No attendance records for today
                    lblCheckInStatus.Text = "No Check In"
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub checkInbtn_Click(sender As Object, e As EventArgs) Handles checkInbtn.Click
        ' Get the saved Staff ID from settings
        Dim staffId As String = My.Settings.userId

        ' Connect to your SQL Server database
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        ' Query to check if the staff member has already checked in today
        Dim checkInStatusQuery As String = "SELECT COUNT(*) FROM Attendance WHERE StaffId = @StaffId AND AttendanceDate = @AttendanceDate AND CheckInTime IS NOT NULL"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(checkInStatusQuery, connection)
                ' Set parameters for the query
                command.Parameters.AddWithValue("@StaffId", staffId)
                command.Parameters.AddWithValue("@AttendanceDate", DateTime.Now.Date)

                connection.Open()
                Dim checkInCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If the staff member has already checked in, show a message
                If checkInCount > 0 Then
                    MessageBox.Show("You have already checked in today.", "Already Checked In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' If not, update the check-in time
                    Dim checkInQuery As String = "UPDATE Attendance SET CheckInTime = @CheckInTime WHERE StaffId = @StaffId AND AttendanceDate = @AttendanceDate"

                    Using checkInCommand As New SqlCommand(checkInQuery, connection)
                        ' Set parameters for the check-in update query
                        checkInCommand.Parameters.AddWithValue("@CheckInTime", DateTime.Now.TimeOfDay)
                        checkInCommand.Parameters.AddWithValue("@StaffId", staffId)
                        checkInCommand.Parameters.AddWithValue("@AttendanceDate", DateTime.Now.Date)

                        Dim rowsAffected As Integer = checkInCommand.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Check-in recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Update check-in status label
                            UpdateCheckInStatusLabel(staffId)
                        Else
                            MessageBox.Show("Failed to record check-in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            End Using
        End Using
    End Sub

    Private Sub checkOutbtn_Click(sender As Object, e As EventArgs) Handles checkOutbtn.Click
        ' Get the saved Staff ID from settings
        Dim staffId As String = My.Settings.userId

        ' Connect to your SQL Server database
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"

        ' Query to check if the staff member has already checked out today
        Dim checkOutStatusQuery As String = "SELECT COUNT(*) FROM Attendance WHERE StaffId = @StaffId AND AttendanceDate = @AttendanceDate AND CheckOutTime IS NOT NULL"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(checkOutStatusQuery, connection)
                ' Set parameters for the query
                command.Parameters.AddWithValue("@StaffId", staffId)
                command.Parameters.AddWithValue("@AttendanceDate", DateTime.Now.Date)

                connection.Open()
                Dim checkOutCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If the staff member has already checked out, show a message
                If checkOutCount > 0 Then
                    MessageBox.Show("You have already checked out today.", "Already Checked Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' If not, update the check-out time
                    Dim checkOutQuery As String = "UPDATE Attendance SET CheckOutTime = @CheckOutTime WHERE StaffId = @StaffId AND AttendanceDate = @AttendanceDate"

                    Using checkOutCommand As New SqlCommand(checkOutQuery, connection)
                        ' Set parameters for the check-out update query
                        checkOutCommand.Parameters.AddWithValue("@CheckOutTime", DateTime.Now.TimeOfDay)
                        checkOutCommand.Parameters.AddWithValue("@StaffId", staffId)
                        checkOutCommand.Parameters.AddWithValue("@AttendanceDate", DateTime.Now.Date)

                        Dim rowsAffected As Integer = checkOutCommand.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Check-out recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Update check-in status label
                            UpdateCheckInStatusLabel(staffId)
                        Else
                            MessageBox.Show("Failed to record check-out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.IsLoggedIn = False
        My.Settings.UserRole = ""
        My.Settings.userId = ""
        My.Settings.Save()

        Dim splashForm As New SplashScreen()
        Me.Hide()
        splashForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim leave As New userLeaveForm
        leave.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim holidays As New staffHolidays
        holidays.Show()
    End Sub
End Class
