Imports System.Data.SqlClient

Public Class EmptyAttendanceReportForm
    Inherits System.Windows.Forms.Form

    Private WithEvents btnGenerateReport As New Button()
    Private WithEvents dataGridViewReport As New DataGridView()




    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        ' Call method to generate and bind the report data
        BindEmptyAttendanceReport()
    End Sub

    Private Sub BindEmptyAttendanceReport()
        ' Your database connection and query logic here
        Dim connectionString As String = "Data Source=KABITA\SQLEXPRESS;Initial Catalog=upasthitidb;Integrated Security=True"
        Dim query As String = "SELECT s.EmployeeName, a.AttendanceDate FROM Attendance a JOIN staffTable s ON a.staffId = s.staffId WHERE a.CheckInTime IS NULL OR a.CheckOutTime IS NULL"

        ' Use SqlDataAdapter to fill DataTable and bind it to DataGridView
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)
            dataGridViewReport.DataSource = dataTable
        End Using
    End Sub

    Private Sub EmptyAttendanceReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Empty Attendance Report"
        Me.Size = New Size(600, 400)

        ' Add DataGridView
        Me.dataGridViewReport.Dock = DockStyle.Fill
        Me.Controls.Add(Me.dataGridViewReport)

        ' Add Generate Report button
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.Location = New Point(10, 10)
        Me.Controls.Add(Me.btnGenerateReport)
    End Sub
End Class
