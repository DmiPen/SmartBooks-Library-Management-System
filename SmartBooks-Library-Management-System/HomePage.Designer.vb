<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewRecords = New System.Windows.Forms.Button()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.btnEditRecords = New System.Windows.Forms.Button()
        Me.btnDeleteRecords = New System.Windows.Forms.Button()
        Me.btnAboutProgram = New System.Windows.Forms.Button()
        Me.btnAboutCompany = New System.Windows.Forms.Button()
        Me.btnHowTo = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAdminPanel = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordsToolStripMenuItem, Me.ViewRecordsToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewRecordsToolStripMenuItem
        '
        Me.NewRecordsToolStripMenuItem.Name = "NewRecordsToolStripMenuItem"
        Me.NewRecordsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewRecordsToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.NewRecordsToolStripMenuItem.Text = "New Records"
        '
        'ViewRecordsToolStripMenuItem
        '
        Me.ViewRecordsToolStripMenuItem.Name = "ViewRecordsToolStripMenuItem"
        Me.ViewRecordsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewRecordsToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.ViewRecordsToolStripMenuItem.Text = "View Records"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditRecordToolStripMenuItem, Me.DeleteRecordToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditRecordToolStripMenuItem
        '
        Me.EditRecordToolStripMenuItem.Name = "EditRecordToolStripMenuItem"
        Me.EditRecordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditRecordToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.EditRecordToolStripMenuItem.Text = "Edit Records"
        '
        'DeleteRecordToolStripMenuItem
        '
        Me.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem"
        Me.DeleteRecordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteRecordToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.DeleteRecordToolStripMenuItem.Text = "Delete Records"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutProgramToolStripMenuItem, Me.AboutCompanyToolStripMenuItem, Me.HowToToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutProgramToolStripMenuItem
        '
        Me.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem"
        Me.AboutProgramToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.AboutProgramToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.AboutProgramToolStripMenuItem.Text = "About Program"
        '
        'AboutCompanyToolStripMenuItem
        '
        Me.AboutCompanyToolStripMenuItem.Name = "AboutCompanyToolStripMenuItem"
        Me.AboutCompanyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.AboutCompanyToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.AboutCompanyToolStripMenuItem.Text = "About Company"
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.HowToToolStripMenuItem.Text = "How To"
        '
        'btnNewRecords
        '
        Me.btnNewRecords.Location = New System.Drawing.Point(847, 246)
        Me.btnNewRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewRecords.Name = "btnNewRecords"
        Me.btnNewRecords.Size = New System.Drawing.Size(100, 43)
        Me.btnNewRecords.TabIndex = 1
        Me.btnNewRecords.Text = "New Records"
        Me.btnNewRecords.UseVisualStyleBackColor = True
        '
        'btnViewRecords
        '
        Me.btnViewRecords.Location = New System.Drawing.Point(459, 58)
        Me.btnViewRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewRecords.Name = "btnViewRecords"
        Me.btnViewRecords.Size = New System.Drawing.Size(100, 43)
        Me.btnViewRecords.TabIndex = 2
        Me.btnViewRecords.Text = "View Records"
        Me.btnViewRecords.UseVisualStyleBackColor = True
        '
        'btnEditRecords
        '
        Me.btnEditRecords.Location = New System.Drawing.Point(40, 246)
        Me.btnEditRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditRecords.Name = "btnEditRecords"
        Me.btnEditRecords.Size = New System.Drawing.Size(100, 43)
        Me.btnEditRecords.TabIndex = 3
        Me.btnEditRecords.Text = "Edit Records"
        Me.btnEditRecords.UseVisualStyleBackColor = True
        '
        'btnDeleteRecords
        '
        Me.btnDeleteRecords.Location = New System.Drawing.Point(459, 246)
        Me.btnDeleteRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteRecords.Name = "btnDeleteRecords"
        Me.btnDeleteRecords.Size = New System.Drawing.Size(100, 43)
        Me.btnDeleteRecords.TabIndex = 4
        Me.btnDeleteRecords.Text = "Delete Records"
        Me.btnDeleteRecords.UseVisualStyleBackColor = True
        '
        'btnAboutProgram
        '
        Me.btnAboutProgram.Location = New System.Drawing.Point(847, 159)
        Me.btnAboutProgram.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAboutProgram.Name = "btnAboutProgram"
        Me.btnAboutProgram.Size = New System.Drawing.Size(100, 43)
        Me.btnAboutProgram.TabIndex = 5
        Me.btnAboutProgram.Text = "About Program"
        Me.btnAboutProgram.UseVisualStyleBackColor = True
        '
        'btnAboutCompany
        '
        Me.btnAboutCompany.Location = New System.Drawing.Point(40, 159)
        Me.btnAboutCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAboutCompany.Name = "btnAboutCompany"
        Me.btnAboutCompany.Size = New System.Drawing.Size(100, 43)
        Me.btnAboutCompany.TabIndex = 6
        Me.btnAboutCompany.Text = "About Company"
        Me.btnAboutCompany.UseVisualStyleBackColor = True
        '
        'btnHowTo
        '
        Me.btnHowTo.Location = New System.Drawing.Point(235, 304)
        Me.btnHowTo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHowTo.Name = "btnHowTo"
        Me.btnHowTo.Size = New System.Drawing.Size(100, 43)
        Me.btnHowTo.TabIndex = 7
        Me.btnHowTo.Text = "How-To"
        Me.btnHowTo.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(663, 304)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 43)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAdminPanel
        '
        Me.btnAdminPanel.Location = New System.Drawing.Point(459, 160)
        Me.btnAdminPanel.Name = "btnAdminPanel"
        Me.btnAdminPanel.Size = New System.Drawing.Size(100, 42)
        Me.btnAdminPanel.TabIndex = 9
        Me.btnAdminPanel.Text = "AdminPanel"
        Me.btnAdminPanel.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnAdminPanel)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnHowTo)
        Me.Controls.Add(Me.btnAboutCompany)
        Me.Controls.Add(Me.btnAboutProgram)
        Me.Controls.Add(Me.btnDeleteRecords)
        Me.Controls.Add(Me.btnEditRecords)
        Me.Controls.Add(Me.btnViewRecords)
        Me.Controls.Add(Me.btnNewRecords)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNewRecords As Button
    Friend WithEvents btnViewRecords As Button
    Friend WithEvents btnEditRecords As Button
    Friend WithEvents btnDeleteRecords As Button
    Friend WithEvents btnAboutProgram As Button
    Friend WithEvents btnAboutCompany As Button
    Friend WithEvents btnHowTo As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAdminPanel As Button
End Class
