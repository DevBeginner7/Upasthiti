<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff
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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.listViewStaff = New System.Windows.Forms.ListView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.UpasthitidbDataSet1 = New Upasthiti.upasthitidbDataSet()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblNoStaff = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.UpasthitidbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listViewStaff
        '
        Me.listViewStaff.HideSelection = False
        Me.listViewStaff.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.listViewStaff.Location = New System.Drawing.Point(12, 57)
        Me.listViewStaff.Name = "listViewStaff"
        Me.listViewStaff.Size = New System.Drawing.Size(1052, 438)
        Me.listViewStaff.TabIndex = 0
        Me.listViewStaff.UseCompatibleStateImageBehavior = False
        Me.listViewStaff.View = System.Windows.Forms.View.Details
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(317, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(156, 39)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'UpasthitidbDataSet1
        '
        Me.UpasthitidbDataSet1.DataSetName = "upasthitidbDataSet"
        Me.UpasthitidbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(21, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(274, 26)
        Me.txtSearch.TabIndex = 2
        '
        'lblNoStaff
        '
        Me.lblNoStaff.AutoSize = True
        Me.lblNoStaff.Location = New System.Drawing.Point(363, 213)
        Me.lblNoStaff.Name = "lblNoStaff"
        Me.lblNoStaff.Size = New System.Drawing.Size(0, 20)
        Me.lblNoStaff.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(511, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 39)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 490)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblNoStaff)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.listViewStaff)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Staff"
        Me.Text = "Staff"
        CType(Me.UpasthitidbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listViewStaff As ListView
    Friend WithEvents btnSearch As Button
    Friend WithEvents UpasthitidbDataSet1 As upasthitidbDataSet
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblNoStaff As Label
    Friend WithEvents btnClear As Button
End Class
