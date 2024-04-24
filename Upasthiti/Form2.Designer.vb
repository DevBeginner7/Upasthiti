<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Totalstaff = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.companyName = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.present = New System.Windows.Forms.TextBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.checkInButton = New System.Windows.Forms.Button()
        Me.staffDropdown = New System.Windows.Forms.ComboBox()
        Me.viewStaffBtn = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.leavesbtn = New System.Windows.Forms.Button()
        Me.holidaysButton = New System.Windows.Forms.Button()
        Me.AddStafbtn = New System.Windows.Forms.Button()
        Me.checkoutDateTime = New System.Windows.Forms.DateTimePicker()
        Me.checkOutDropdown = New System.Windows.Forms.ComboBox()
        Me.checkOutButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 248)
        Me.Panel1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Totalstaff)
        Me.Panel7.Controls.Add(Me.TextBox3)
        Me.Panel7.Location = New System.Drawing.Point(632, 108)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(141, 105)
        Me.Panel7.TabIndex = 13
        '
        'Totalstaff
        '
        Me.Totalstaff.AutoSize = True
        Me.Totalstaff.BackColor = System.Drawing.Color.White
        Me.Totalstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totalstaff.Location = New System.Drawing.Point(16, 73)
        Me.Totalstaff.Name = "Totalstaff"
        Me.Totalstaff.Size = New System.Drawing.Size(93, 22)
        Me.Totalstaff.TabIndex = 5
        Me.Totalstaff.Text = "Total Staff"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(51, 21)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(33, 37)
        Me.TextBox3.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Me.companyName)
        Me.Panel6.Location = New System.Drawing.Point(-33, -23)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(929, 96)
        Me.Panel6.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'companyName
        '
        Me.companyName.AutoSize = True
        Me.companyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyName.Location = New System.Drawing.Point(379, 48)
        Me.companyName.Name = "companyName"
        Me.companyName.Size = New System.Drawing.Size(149, 26)
        Me.companyName.TabIndex = 8
        Me.companyName.Text = "Display Name"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Location = New System.Drawing.Point(436, 108)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(149, 105)
        Me.Panel4.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Today In Leaves"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(55, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(37, 37)
        Me.TextBox2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(239, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 105)
        Me.Panel3.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Today Absent"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(43, 20)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(37, 36)
        Me.TextBox1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.present)
        Me.Panel2.Location = New System.Drawing.Point(47, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(144, 105)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Today Present"
        '
        'present
        '
        Me.present.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.present.Location = New System.Drawing.Point(57, 21)
        Me.present.Multiline = True
        Me.present.Name = "present"
        Me.present.Size = New System.Drawing.Size(29, 36)
        Me.present.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(813, 92)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(120, 34)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'checkInButton
        '
        Me.checkInButton.Location = New System.Drawing.Point(651, 288)
        Me.checkInButton.Name = "checkInButton"
        Me.checkInButton.Size = New System.Drawing.Size(120, 32)
        Me.checkInButton.TabIndex = 1
        Me.checkInButton.Text = "Check In"
        Me.checkInButton.UseVisualStyleBackColor = True
        '
        'staffDropdown
        '
        Me.staffDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.staffDropdown.FormattingEnabled = True
        Me.staffDropdown.Location = New System.Drawing.Point(21, 292)
        Me.staffDropdown.Name = "staffDropdown"
        Me.staffDropdown.Size = New System.Drawing.Size(276, 28)
        Me.staffDropdown.TabIndex = 2
        '
        'viewStaffBtn
        '
        Me.viewStaffBtn.Location = New System.Drawing.Point(43, 453)
        Me.viewStaffBtn.Name = "viewStaffBtn"
        Me.viewStaffBtn.Size = New System.Drawing.Size(148, 76)
        Me.viewStaffBtn.TabIndex = 3
        Me.viewStaffBtn.Text = "View Staff"
        Me.viewStaffBtn.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(333, 292)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(279, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(393, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 69)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Present Staff"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'leavesbtn
        '
        Me.leavesbtn.Location = New System.Drawing.Point(393, 19)
        Me.leavesbtn.Name = "leavesbtn"
        Me.leavesbtn.Size = New System.Drawing.Size(146, 76)
        Me.leavesbtn.TabIndex = 7
        Me.leavesbtn.Text = "Leaves Staff"
        Me.leavesbtn.UseVisualStyleBackColor = True
        '
        'holidaysButton
        '
        Me.holidaysButton.Location = New System.Drawing.Point(579, 23)
        Me.holidaysButton.Name = "holidaysButton"
        Me.holidaysButton.Size = New System.Drawing.Size(146, 72)
        Me.holidaysButton.TabIndex = 8
        Me.holidaysButton.Text = "Holidays"
        Me.holidaysButton.UseVisualStyleBackColor = True
        '
        'AddStafbtn
        '
        Me.AddStafbtn.Location = New System.Drawing.Point(205, 120)
        Me.AddStafbtn.Name = "AddStafbtn"
        Me.AddStafbtn.Size = New System.Drawing.Size(146, 69)
        Me.AddStafbtn.TabIndex = 9
        Me.AddStafbtn.Text = "Add Staff"
        Me.AddStafbtn.UseVisualStyleBackColor = True
        '
        'checkoutDateTime
        '
        Me.checkoutDateTime.Location = New System.Drawing.Point(333, 365)
        Me.checkoutDateTime.Name = "checkoutDateTime"
        Me.checkoutDateTime.Size = New System.Drawing.Size(279, 26)
        Me.checkoutDateTime.TabIndex = 12
        '
        'checkOutDropdown
        '
        Me.checkOutDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.checkOutDropdown.FormattingEnabled = True
        Me.checkOutDropdown.Location = New System.Drawing.Point(23, 362)
        Me.checkOutDropdown.Name = "checkOutDropdown"
        Me.checkOutDropdown.Size = New System.Drawing.Size(276, 28)
        Me.checkOutDropdown.TabIndex = 11
        '
        'checkOutButton
        '
        Me.checkOutButton.Location = New System.Drawing.Point(651, 359)
        Me.checkOutButton.Name = "checkOutButton"
        Me.checkOutButton.Size = New System.Drawing.Size(120, 32)
        Me.checkOutButton.TabIndex = 10
        Me.checkOutButton.Text = "Check Out"
        Me.checkOutButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select Staff Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Select Date And Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Select Date And Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Select Staff Name"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.holidaysButton)
        Me.Panel5.Controls.Add(Me.leavesbtn)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.btnLogout)
        Me.Panel5.Controls.Add(Me.AddStafbtn)
        Me.Panel5.Location = New System.Drawing.Point(-162, 434)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1056, 287)
        Me.Panel5.TabIndex = 18
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(819, 649)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.checkoutDateTime)
        Me.Controls.Add(Me.checkOutDropdown)
        Me.Controls.Add(Me.checkOutButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.viewStaffBtn)
        Me.Controls.Add(Me.staffDropdown)
        Me.Controls.Add(Me.checkInButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminForm"
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents present As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents checkInButton As Button
    Friend WithEvents staffDropdown As ComboBox
    Friend WithEvents viewStaffBtn As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents leavesbtn As Button
    Friend WithEvents companyName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents holidaysButton As Button
    Friend WithEvents AddStafbtn As Button
    Friend WithEvents checkoutDateTime As DateTimePicker
    Friend WithEvents checkOutDropdown As ComboBox
    Friend WithEvents checkOutButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Totalstaff As Label
    Friend WithEvents TextBox3 As TextBox
End Class
