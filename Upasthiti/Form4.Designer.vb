<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.numberBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Submitbtn = New System.Windows.Forms.Button()
        Me.panNumberBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addressbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.emailbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameLable = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.numberBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Submitbtn)
        Me.Panel1.Controls.Add(Me.panNumberBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.passwordbox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.addressbox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.emailbox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.nameBox)
        Me.Panel1.Controls.Add(Me.CompanyNameLable)
        Me.Panel1.Location = New System.Drawing.Point(241, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 511)
        Me.Panel1.TabIndex = 0
        '
        'numberBox
        '
        Me.numberBox.Location = New System.Drawing.Point(240, 410)
        Me.numberBox.Name = "numberBox"
        Me.numberBox.Size = New System.Drawing.Size(256, 26)
        Me.numberBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(240, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Number"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Submitbtn
        '
        Me.Submitbtn.Location = New System.Drawing.Point(293, 460)
        Me.Submitbtn.Name = "Submitbtn"
        Me.Submitbtn.Size = New System.Drawing.Size(180, 35)
        Me.Submitbtn.TabIndex = 11
        Me.Submitbtn.Text = "Submit"
        Me.Submitbtn.UseVisualStyleBackColor = True
        '
        'panNumberBox
        '
        Me.panNumberBox.Location = New System.Drawing.Point(240, 340)
        Me.panNumberBox.Name = "panNumberBox"
        Me.panNumberBox.Size = New System.Drawing.Size(256, 26)
        Me.panNumberBox.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(240, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PAN Number"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'passwordbox
        '
        Me.passwordbox.Location = New System.Drawing.Point(240, 266)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.Size = New System.Drawing.Size(256, 26)
        Me.passwordbox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(240, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'addressbox
        '
        Me.addressbox.Location = New System.Drawing.Point(240, 191)
        Me.addressbox.Name = "addressbox"
        Me.addressbox.Size = New System.Drawing.Size(256, 26)
        Me.addressbox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'emailbox
        '
        Me.emailbox.Location = New System.Drawing.Point(240, 120)
        Me.emailbox.Name = "emailbox"
        Me.emailbox.Size = New System.Drawing.Size(256, 26)
        Me.emailbox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(240, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Email"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(240, 50)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(256, 26)
        Me.nameBox.TabIndex = 2
        '
        'CompanyNameLable
        '
        Me.CompanyNameLable.AutoSize = True
        Me.CompanyNameLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CompanyNameLable.ForeColor = System.Drawing.Color.White
        Me.CompanyNameLable.Location = New System.Drawing.Point(240, 21)
        Me.CompanyNameLable.Name = "CompanyNameLable"
        Me.CompanyNameLable.Size = New System.Drawing.Size(140, 26)
        Me.CompanyNameLable.TabIndex = 0
        Me.CompanyNameLable.Text = "Company Name"
        Me.CompanyNameLable.UseCompatibleTextRendering = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-20, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 567)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox5.Location = New System.Drawing.Point(52, 12)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(289, 28)
        Me.TextBox5.TabIndex = 11
        Me.TextBox5.Text = "Register a New Company"
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 510)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SignUpForm"
        Me.Text = "Signup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CompanyNameLable As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents passwordbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents addressbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents emailbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Submitbtn As Button
    Friend WithEvents panNumberBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents numberBox As TextBox
    Friend WithEvents Label5 As Label
End Class
