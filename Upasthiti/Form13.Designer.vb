<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddLeavesForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddLeavesForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalDays = New System.Windows.Forms.TextBox()
        Me.datePickerApplyDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAddLeave = New System.Windows.Forms.Button()
        Me.StartLb = New System.Windows.Forms.Label()
        Me.EndLb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(398, 457)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDescription)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTotalDays)
        Me.Panel1.Controls.Add(Me.datePickerApplyDate)
        Me.Panel1.Controls.Add(Me.btnAddLeave)
        Me.Panel1.Controls.Add(Me.StartLb)
        Me.Panel1.Controls.Add(Me.EndLb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(257, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 457)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(299, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apply Leave"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(282, 211)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(232, 80)
        Me.txtDescription.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Description"
        '
        'txtTotalDays
        '
        Me.txtTotalDays.Location = New System.Drawing.Point(282, 143)
        Me.txtTotalDays.Name = "txtTotalDays"
        Me.txtTotalDays.Size = New System.Drawing.Size(232, 26)
        Me.txtTotalDays.TabIndex = 7
        '
        'datePickerApplyDate
        '
        Me.datePickerApplyDate.Location = New System.Drawing.Point(282, 74)
        Me.datePickerApplyDate.Name = "datePickerApplyDate"
        Me.datePickerApplyDate.Size = New System.Drawing.Size(232, 26)
        Me.datePickerApplyDate.TabIndex = 6
        '
        'btnAddLeave
        '
        Me.btnAddLeave.Location = New System.Drawing.Point(325, 332)
        Me.btnAddLeave.Name = "btnAddLeave"
        Me.btnAddLeave.Size = New System.Drawing.Size(110, 39)
        Me.btnAddLeave.TabIndex = 4
        Me.btnAddLeave.Text = "Submit"
        Me.btnAddLeave.UseVisualStyleBackColor = True
        '
        'StartLb
        '
        Me.StartLb.AutoSize = True
        Me.StartLb.Location = New System.Drawing.Point(181, 80)
        Me.StartLb.Name = "StartLb"
        Me.StartLb.Size = New System.Drawing.Size(83, 20)
        Me.StartLb.TabIndex = 3
        Me.StartLb.Text = "Start Date"
        '
        'EndLb
        '
        Me.EndLb.AutoSize = True
        Me.EndLb.Location = New System.Drawing.Point(181, 146)
        Me.EndLb.Name = "EndLb"
        Me.EndLb.Size = New System.Drawing.Size(83, 20)
        Me.EndLb.TabIndex = 2
        Me.EndLb.Text = "Total Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'AddLeavesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddLeavesForm"
        Me.Text = "Add Leave"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datePickerApplyDate As DateTimePicker
    Friend WithEvents btnAddLeave As Button
    Friend WithEvents StartLb As Label
    Friend WithEvents EndLb As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalDays As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
