<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffForm))
        Me.checkOutbtn = New System.Windows.Forms.Button()
        Me.checkInbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblCheckInStatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkOutbtn
        '
        Me.checkOutbtn.Location = New System.Drawing.Point(333, 117)
        Me.checkOutbtn.Name = "checkOutbtn"
        Me.checkOutbtn.Size = New System.Drawing.Size(177, 93)
        Me.checkOutbtn.TabIndex = 21
        Me.checkOutbtn.Text = "Check Out"
        Me.checkOutbtn.UseVisualStyleBackColor = True
        '
        'checkInbtn
        '
        Me.checkInbtn.Location = New System.Drawing.Point(61, 117)
        Me.checkInbtn.Name = "checkInbtn"
        Me.checkInbtn.Size = New System.Drawing.Size(185, 93)
        Me.checkInbtn.TabIndex = 18
        Me.checkInbtn.Text = "Check In"
        Me.checkInbtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblDisplayName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-5, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 65)
        Me.Panel1.TabIndex = 28
        '
        'lblDisplayName
        '
        Me.lblDisplayName.AutoSize = True
        Me.lblDisplayName.ForeColor = System.Drawing.Color.White
        Me.lblDisplayName.Location = New System.Drawing.Point(273, 23)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(49, 20)
        Me.lblDisplayName.TabIndex = 1
        Me.lblDisplayName.Text = "name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(-5, 252)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(655, 290)
        Me.Panel2.TabIndex = 29
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(477, 190)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 36)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(356, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 78)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Holidays"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(92, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 78)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Leaves"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblCheckInStatus
        '
        Me.lblCheckInStatus.AutoSize = True
        Me.lblCheckInStatus.Location = New System.Drawing.Point(272, 83)
        Me.lblCheckInStatus.Name = "lblCheckInStatus"
        Me.lblCheckInStatus.Size = New System.Drawing.Size(130, 20)
        Me.lblCheckInStatus.TabIndex = 30
        Me.lblCheckInStatus.Text = "lblCheckInStatus"
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 490)
        Me.Controls.Add(Me.lblCheckInStatus)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.checkOutbtn)
        Me.Controls.Add(Me.checkInbtn)
        Me.Name = "StaffForm"
        Me.Text = "Staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checkOutbtn As Button
    Friend WithEvents checkInbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblDisplayName As Label
    Friend WithEvents lblCheckInStatus As Label
End Class
