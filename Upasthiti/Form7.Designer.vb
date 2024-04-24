<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresentStaffform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PresentStaffform))
        Me.listViewPresentStaff = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblNoStaff = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listViewPresentStaff
        '
        Me.listViewPresentStaff.HideSelection = False
        Me.listViewPresentStaff.Location = New System.Drawing.Point(12, 70)
        Me.listViewPresentStaff.Name = "listViewPresentStaff"
        Me.listViewPresentStaff.Size = New System.Drawing.Size(1070, 483)
        Me.listViewPresentStaff.TabIndex = 0
        Me.listViewPresentStaff.UseCompatibleStateImageBehavior = False
        Me.listViewPresentStaff.View = System.Windows.Forms.View.Details
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(375, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(50, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(253, 26)
        Me.txtSearch.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(544, 23)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 33)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblNoStaff
        '
        Me.lblNoStaff.AutoSize = True
        Me.lblNoStaff.Location = New System.Drawing.Point(440, 244)
        Me.lblNoStaff.Name = "lblNoStaff"
        Me.lblNoStaff.Size = New System.Drawing.Size(0, 20)
        Me.lblNoStaff.TabIndex = 5
        '
        'PresentStaffform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 554)
        Me.Controls.Add(Me.lblNoStaff)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.listViewPresentStaff)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PresentStaffform"
        Me.Text = "Present Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listViewPresentStaff As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblNoStaff As Label
End Class
