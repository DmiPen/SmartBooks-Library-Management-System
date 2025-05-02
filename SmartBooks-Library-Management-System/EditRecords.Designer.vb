<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditRecords
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
        Me.RecordsDGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BookTitletxt = New System.Windows.Forms.TextBox()
        Me.AuthorNametxt = New System.Windows.Forms.TextBox()
        Me.ISBNtxt = New System.Windows.Forms.TextBox()
        Me.PublishedDatetxt = New System.Windows.Forms.TextBox()
        Me.Caregorytxt = New System.Windows.Forms.TextBox()
        Me.Quantitytxt = New System.Windows.Forms.TextBox()
        Me.UserIDtxt = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.RecordsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 595)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'RecordsDGV
        '
        Me.RecordsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordsDGV.Location = New System.Drawing.Point(356, 109)
        Me.RecordsDGV.Name = "RecordsDGV"
        Me.RecordsDGV.RowHeadersWidth = 51
        Me.RecordsDGV.RowTemplate.Height = 24
        Me.RecordsDGV.Size = New System.Drawing.Size(751, 364)
        Me.RecordsDGV.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Book Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Author Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter ISBN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Published Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Caregory"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "User ID"
        '
        'BookTitletxt
        '
        Me.BookTitletxt.Location = New System.Drawing.Point(218, 120)
        Me.BookTitletxt.Name = "BookTitletxt"
        Me.BookTitletxt.Size = New System.Drawing.Size(100, 22)
        Me.BookTitletxt.TabIndex = 9
        '
        'AuthorNametxt
        '
        Me.AuthorNametxt.Location = New System.Drawing.Point(218, 171)
        Me.AuthorNametxt.Name = "AuthorNametxt"
        Me.AuthorNametxt.Size = New System.Drawing.Size(100, 22)
        Me.AuthorNametxt.TabIndex = 10
        '
        'ISBNtxt
        '
        Me.ISBNtxt.Location = New System.Drawing.Point(218, 229)
        Me.ISBNtxt.Name = "ISBNtxt"
        Me.ISBNtxt.Size = New System.Drawing.Size(100, 22)
        Me.ISBNtxt.TabIndex = 11
        '
        'PublishedDatetxt
        '
        Me.PublishedDatetxt.Location = New System.Drawing.Point(218, 281)
        Me.PublishedDatetxt.Name = "PublishedDatetxt"
        Me.PublishedDatetxt.Size = New System.Drawing.Size(100, 22)
        Me.PublishedDatetxt.TabIndex = 12
        '
        'Caregorytxt
        '
        Me.Caregorytxt.Location = New System.Drawing.Point(218, 340)
        Me.Caregorytxt.Name = "Caregorytxt"
        Me.Caregorytxt.Size = New System.Drawing.Size(100, 22)
        Me.Caregorytxt.TabIndex = 13
        '
        'Quantitytxt
        '
        Me.Quantitytxt.Location = New System.Drawing.Point(218, 391)
        Me.Quantitytxt.Name = "Quantitytxt"
        Me.Quantitytxt.Size = New System.Drawing.Size(100, 22)
        Me.Quantitytxt.TabIndex = 14
        '
        'UserIDtxt
        '
        Me.UserIDtxt.Location = New System.Drawing.Point(218, 450)
        Me.UserIDtxt.Name = "UserIDtxt"
        Me.UserIDtxt.Size = New System.Drawing.Size(100, 22)
        Me.UserIDtxt.TabIndex = 15
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(597, 540)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 33)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(800, 540)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 34)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'EditRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 654)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.UserIDtxt)
        Me.Controls.Add(Me.Quantitytxt)
        Me.Controls.Add(Me.Caregorytxt)
        Me.Controls.Add(Me.PublishedDatetxt)
        Me.Controls.Add(Me.ISBNtxt)
        Me.Controls.Add(Me.AuthorNametxt)
        Me.Controls.Add(Me.BookTitletxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RecordsDGV)
        Me.Controls.Add(Me.btnBack)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EditRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditRecords"
        CType(Me.RecordsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents RecordsDGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BookTitletxt As TextBox
    Friend WithEvents AuthorNametxt As TextBox
    Friend WithEvents ISBNtxt As TextBox
    Friend WithEvents PublishedDatetxt As TextBox
    Friend WithEvents Caregorytxt As TextBox
    Friend WithEvents Quantitytxt As TextBox
    Friend WithEvents UserIDtxt As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
End Class
