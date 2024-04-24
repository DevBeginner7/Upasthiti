<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HolidaysForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolidaysForm))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.listViewHolidays = New System.Windows.Forms.ListView()
        Me.addHoliday = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(44, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(236, 26)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(357, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(143, 36)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'listViewHolidays
        '
        Me.listViewHolidays.HideSelection = False
        Me.listViewHolidays.Location = New System.Drawing.Point(3, 64)
        Me.listViewHolidays.Name = "listViewHolidays"
        Me.listViewHolidays.Size = New System.Drawing.Size(808, 398)
        Me.listViewHolidays.TabIndex = 3
        Me.listViewHolidays.UseCompatibleStateImageBehavior = False
        Me.listViewHolidays.View = System.Windows.Forms.View.Details
        '
        'addHoliday
        '
        Me.addHoliday.Location = New System.Drawing.Point(549, 22)
        Me.addHoliday.Name = "addHoliday"
        Me.addHoliday.Size = New System.Drawing.Size(122, 31)
        Me.addHoliday.TabIndex = 4
        Me.addHoliday.Text = "Add Holiday"
        Me.addHoliday.UseVisualStyleBackColor = True
        '
        'HolidaysForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.addHoliday)
        Me.Controls.Add(Me.listViewHolidays)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HolidaysForm"
        Me.Text = "Holidays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents listViewHolidays As ListView
    Friend WithEvents addHoliday As Button
End Class
