Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the timer when the form loads
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Stop the timer
        Timer1.Stop()

        ' Check login state
        If My.Settings.IsLoggedIn Then
            Dim role As String = My.Settings.UserRole

            If role = "admin" Then
                Dim adminForm As New AdminForm()
                adminForm.Show()
            ElseIf role = "staff" Then
                Dim staffForm As New StaffForm()
                staffForm.Show()
            End If
        Else
            Dim loginForm As New Form1()
            loginForm.Show()

        End If
        Me.Hide()
        ' Close the splash screen

    End Sub
End Class
