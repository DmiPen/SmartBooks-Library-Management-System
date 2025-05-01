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
    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToToolStripMenuItem.Click
        'Hides current Form
        Me.Hide()
        'Opens How-To Form
        How_To.Show()
    End Sub
    Private Sub btnNewRecords_Click(sender As Object, e As EventArgs) Handles btnNewRecords.Click
        'Hides the current Form
        Me.Hide()
        'Opens the New Records Form
        NewRecords.Show()
    End Sub
    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        'Hides the current Form
        Me.Hide()
        'Opens the ViewRecords Form
        ViewRecords.Show()
    End Sub
    Private Sub btnEditRecords_Click(sender As Object, e As EventArgs) Handles btnEditRecords.Click
        'Hides the current Form
        Me.Hide()
        'Opens EditRecords Form
        EditRecords.Show()
    End Sub
    Private Sub btnDeleteRecords_Click(sender As Object, e As EventArgs) Handles btnDeleteRecords.Click
        'Hides current Form
        Me.Hide()
        'Opens DeleteRecords Form
        DeleteRecords.Show()
    End Sub
    Private Sub btnAboutProgram_Click(sender As Object, e As EventArgs) Handles btnAboutProgram.Click
        'Hides current Form
        Me.Hide()
        'Opens AboutProgram Form
        AboutProgram.Show()
    End Sub
    Private Sub btnAboutCompany_Click(sender As Object, e As EventArgs) Handles btnAboutCompany.Click
        'Hides current Form
        Me.Hide()
        'Opens AboutCompany Form
        AboutCompany.Show()
    End Sub
    Private Sub btnHowTo_Click(sender As Object, e As EventArgs) Handles btnHowTo.Click
        'Hides current Form
        Me.Hide()
        'Opens How-To Form
        How_To.Show()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Hides the current Form
        Me.Hide()
        'Opens Login Form
        Login.Show()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class