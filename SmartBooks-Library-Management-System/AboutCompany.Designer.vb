<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutCompany
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
        Me.lblManager = New System.Windows.Forms.Label()
        Me.lblGraphicDesigner = New System.Windows.Forms.Label()
        Me.lblWebDeveloper = New System.Windows.Forms.Label()
        Me.lblDatabaseAdministrator = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pbxDatabaseAdministrator = New System.Windows.Forms.PictureBox()
        Me.pbxWebDeveloper = New System.Windows.Forms.PictureBox()
        Me.pbxGraphicDesigner = New System.Windows.Forms.PictureBox()
        Me.pbxManager = New System.Windows.Forms.PictureBox()
        CType(Me.pbxDatabaseAdministrator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxWebDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGraphicDesigner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblManager
        '
        Me.lblManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblManager.Location = New System.Drawing.Point(22, 186)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(100, 33)
        Me.lblManager.TabIndex = 4
        Me.lblManager.Text = "Manager"
        Me.lblManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGraphicDesigner
        '
        Me.lblGraphicDesigner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGraphicDesigner.Location = New System.Drawing.Point(181, 186)
        Me.lblGraphicDesigner.Name = "lblGraphicDesigner"
        Me.lblGraphicDesigner.Size = New System.Drawing.Size(100, 33)
        Me.lblGraphicDesigner.TabIndex = 5
        Me.lblGraphicDesigner.Text = "Graphic  Designer"
        Me.lblGraphicDesigner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWebDeveloper
        '
        Me.lblWebDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWebDeveloper.Location = New System.Drawing.Point(330, 186)
        Me.lblWebDeveloper.Name = "lblWebDeveloper"
        Me.lblWebDeveloper.Size = New System.Drawing.Size(100, 33)
        Me.lblWebDeveloper.TabIndex = 6
        Me.lblWebDeveloper.Text = "Web Developer"
        Me.lblWebDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDatabaseAdministrator
        '
        Me.lblDatabaseAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDatabaseAdministrator.Location = New System.Drawing.Point(479, 186)
        Me.lblDatabaseAdministrator.Name = "lblDatabaseAdministrator"
        Me.lblDatabaseAdministrator.Size = New System.Drawing.Size(100, 33)
        Me.lblDatabaseAdministrator.TabIndex = 7
        Me.lblDatabaseAdministrator.Text = "Database " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Administrator"
        Me.lblDatabaseAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(279, 236)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'pbxDatabaseAdministrator
        '
        Me.pbxDatabaseAdministrator.BackgroundImage = Global.SmartBooks_Library_Management_System.My.Resources.Resources.angel
        Me.pbxDatabaseAdministrator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDatabaseAdministrator.Location = New System.Drawing.Point(479, 57)
        Me.pbxDatabaseAdministrator.Name = "pbxDatabaseAdministrator"
        Me.pbxDatabaseAdministrator.Size = New System.Drawing.Size(100, 107)
        Me.pbxDatabaseAdministrator.TabIndex = 3
        Me.pbxDatabaseAdministrator.TabStop = False
        '
        'pbxWebDeveloper
        '
        Me.pbxWebDeveloper.Location = New System.Drawing.Point(330, 57)
        Me.pbxWebDeveloper.Name = "pbxWebDeveloper"
        Me.pbxWebDeveloper.Size = New System.Drawing.Size(100, 107)
        Me.pbxWebDeveloper.TabIndex = 2
        Me.pbxWebDeveloper.TabStop = False
        '
        'pbxGraphicDesigner
        '
        Me.pbxGraphicDesigner.Location = New System.Drawing.Point(181, 57)
        Me.pbxGraphicDesigner.Name = "pbxGraphicDesigner"
        Me.pbxGraphicDesigner.Size = New System.Drawing.Size(100, 107)
        Me.pbxGraphicDesigner.TabIndex = 1
        Me.pbxGraphicDesigner.TabStop = False
        '
        'pbxManager
        '
        Me.pbxManager.BackgroundImage = Global.SmartBooks_Library_Management_System.My.Resources.Resources._me
        Me.pbxManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxManager.Location = New System.Drawing.Point(22, 57)
        Me.pbxManager.Name = "pbxManager"
        Me.pbxManager.Size = New System.Drawing.Size(100, 107)
        Me.pbxManager.TabIndex = 0
        Me.pbxManager.TabStop = False
        '
        'AboutCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 342)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblDatabaseAdministrator)
        Me.Controls.Add(Me.lblWebDeveloper)
        Me.Controls.Add(Me.lblGraphicDesigner)
        Me.Controls.Add(Me.lblManager)
        Me.Controls.Add(Me.pbxDatabaseAdministrator)
        Me.Controls.Add(Me.pbxWebDeveloper)
        Me.Controls.Add(Me.pbxGraphicDesigner)
        Me.Controls.Add(Me.pbxManager)
        Me.Name = "AboutCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbxDatabaseAdministrator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxWebDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGraphicDesigner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxManager As PictureBox
    Friend WithEvents pbxGraphicDesigner As PictureBox
    Friend WithEvents pbxWebDeveloper As PictureBox
    Friend WithEvents pbxDatabaseAdministrator As PictureBox
    Friend WithEvents lblManager As Label
    Friend WithEvents lblGraphicDesigner As Label
    Friend WithEvents lblWebDeveloper As Label
    Friend WithEvents lblDatabaseAdministrator As Label
    Friend WithEvents btnBack As Button
End Class
