<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaveStatusForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LeaveStatusForm))
        Me.listViewLeaves = New System.Windows.Forms.ListView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewLeaves
        '
        Me.listViewLeaves.HideSelection = False
        Me.listViewLeaves.Location = New System.Drawing.Point(1, 69)
        Me.listViewLeaves.Name = "listViewLeaves"
        Me.listViewLeaves.Size = New System.Drawing.Size(1083, 381)
        Me.listViewLeaves.TabIndex = 0
        Me.listViewLeaves.UseCompatibleStateImageBehavior = False
        Me.listViewLeaves.View = System.Windows.Forms.View.Details
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(128, 17)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(283, 32)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(463, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(145, 35)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search Staff"
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(642, 17)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(145, 35)
        Me.btnShowAll.TabIndex = 4
        Me.btnShowAll.Text = "Clear"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'LeaveStatusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 450)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.listViewLeaves)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LeaveStatusForm"
        Me.Text = "Leaves"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listViewLeaves As ListView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowAll As Button
End Class
