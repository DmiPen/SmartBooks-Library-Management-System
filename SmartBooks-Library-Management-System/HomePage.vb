'Names : Alekxzander Calderon, Jason Coc, Angel Madrid, D'imitri Wu
'Date : April 29 2025
'Title : Library Management System (Smart Books)
Public Class HomePage

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide Admin Panel button for non-admins
        btnAdminPanel.Visible = (Session.CurrentUserAccess = "Admin")
    End Sub

    Private Sub NewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRecordsToolStripMenuItem.Click
        Me.Hide()
        NewRecords.Show()
    End Sub

    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        Me.Hide()
        ViewRecords.Show()
    End Sub

    Private Sub EditRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditRecordToolStripMenuItem.Click
        Me.Hide()
        EditRecords.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        Me.Hide()
        DeleteRecords.Show()
    End Sub

    Private Sub AboutProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProgramToolStripMenuItem.Click
        Me.Hide()
        AboutProgram.Show()
    End Sub

    Private Sub AboutCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCompanyToolStripMenuItem.Click
        Me.Hide()
        AboutCompany.Show()
    End Sub

    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToToolStripMenuItem.Click
        Me.Hide()
        How_To.Show()
    End Sub

    Private Sub btnNewRecords_Click(sender As Object, e As EventArgs) Handles btnNewRecords.Click
        Me.Hide()
        NewRecords.Show()
    End Sub

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        Me.Hide()
        ViewRecords.Show()
    End Sub

    Private Sub btnEditRecords_Click(sender As Object, e As EventArgs) Handles btnEditRecords.Click
        Me.Hide()
        EditRecords.Show()
    End Sub

    Private Sub btnDeleteRecords_Click(sender As Object, e As EventArgs) Handles btnDeleteRecords.Click
        Me.Hide()
        DeleteRecords.Show()
    End Sub

    Private Sub btnAboutProgram_Click(sender As Object, e As EventArgs) Handles btnAboutProgram.Click
        Me.Hide()
        AboutProgram.Show()
    End Sub

    Private Sub btnAboutCompany_Click(sender As Object, e As EventArgs) Handles btnAboutCompany.Click
        Me.Hide()
        AboutCompany.Show()
    End Sub

    Private Sub btnHowTo_Click(sender As Object, e As EventArgs) Handles btnHowTo.Click
        Me.Hide()
        How_To.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub btnAdminPanel_Click(sender As Object, e As EventArgs) Handles btnAdminPanel.Click
        If Session.CurrentUserAccess = "Admin" Then
            Me.Hide()
            AdminPanel.Show()
        Else
            MessageBox.Show("Access denied. Admins only.", "Unauthorized",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
