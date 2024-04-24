<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffHolidays
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffHolidays))
        Me.listViewHolidays = New System.Windows.Forms.ListView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'listViewHolidays
        '
        Me.listViewHolidays.HideSelection = False
        Me.listViewHolidays.Location = New System.Drawing.Point(-4, 47)
        Me.listViewHolidays.Name = "listViewHolidays"
        Me.listViewHolidays.Size = New System.Drawing.Size(808, 398)
        Me.listViewHolidays.TabIndex = 7
        Me.listViewHolidays.UseCompatibleStateImageBehavior = False
        Me.listViewHolidays.View = System.Windows.Forms.View.Details
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(350, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(143, 36)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(37, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(236, 26)
        Me.txtSearch.TabIndex = 5
        '
        'staffHolidays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.listViewHolidays)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "staffHolidays"
        Me.Text = "Staff Holidays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listViewHolidays As ListView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
