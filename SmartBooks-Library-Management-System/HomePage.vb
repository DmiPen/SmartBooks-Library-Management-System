'Names : Alekxzander Calderon, Jason Coc, Angel Madrid, D'imitri Wu
'Date : April 29 2025
'Title : Library Management System (Smart Books)
Public Class HomePage
    Private Sub NewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRecordsToolStripMenuItem.Click
        'Hides the current Form
        Me.Hide()
        'Opens the New Records Form
        NewRecords.Show()
    End Sub
    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        'Hides the current Form
        Me.Hide()
        'Opens the ViewRecords Form
        ViewRecords.Show()
    End Sub
    Private Sub EditRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditRecordToolStripMenuItem.Click
        'Hides the current Form
        Me.Hide()
        'Opens EditRecords Form
        EditRecords.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        'Hides the current Form
        Me.Hide()
        'Opens Login Form
        Login.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Terminates the Program
        Application.Exit()
    End Sub

    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        'Hides current Form
        Me.Hide()
        'Opens DeleteRecords Form
        DeleteRecords.Show()
    End Sub

    Private Sub AboutProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProgramToolStripMenuItem.Click
        'Hides current Form
        Me.Hide()
        'Opens AboutProgram Form
        AboutProgram.Show()
    End Sub

    Private Sub AboutCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCompanyToolStripMenuItem.Click
        'Hides current Form
        Me.Hide()
        'Opens AboutCompany Form
        AboutCompany.Show()
    End Sub
End Class