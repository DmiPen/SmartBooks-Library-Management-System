<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutProgram
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(28, 418)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(182, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(343, 59)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "About Program" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblContent
        '
        Me.lblContent.Location = New System.Drawing.Point(24, 84)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(435, 164)
        Me.lblContent.TabIndex = 2
        Me.lblContent.Text = "Welcome to Smart Books." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This program is to demonstarte the different UI's of a u" &
    "ser " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when a particular user enter."
        '
        'AboutProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "AboutProgram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutProgram"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblContent As Label
End Class
