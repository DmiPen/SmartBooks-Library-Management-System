' Names : Alekxzander Calderon, Jason Coc, Angel Madrid, D'imitri Wu
' Date  : April 29 2025
' Title : Library Management System (Smart Books)

Public Class HomePage
    Inherits Form

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim role = Session.CurrentUserAccess  ' "Admin", "Manager", or "Standard"

        ' MenuStrip items
        ViewRecordsToolStripMenuItem.Visible = True
        NewRecordsToolStripMenuItem.Visible = (role = "Admin" OrElse role = "Manager")
        EditRecordToolStripMenuItem.Visible = (role = "Admin" OrElse role = "Manager")
        DeleteRecordToolStripMenuItem.Visible = (role = "Admin")
        btnAdminPanel.Visible = (role = "Admin")

        ' Dashboard buttons
        btnViewRecords.Visible = True
        btnNewRecords.Visible = (role = "Admin" OrElse role = "Manager")
        btnEditRecords.Visible = (role = "Admin" OrElse role = "Manager")
        btnDeleteRecords.Visible = (role = "Admin")
    End Sub

    ' Helper to enforce access
    Private Function HasAccess(action As String) As Boolean
        Dim role = Session.CurrentUserAccess
        Select Case action
            Case "Create", "Edit"
                Return (role = "Admin" OrElse role = "Manager")
            Case "Delete"
                Return (role = "Admin")
            Case Else
                Return True
        End Select
    End Function

    ' ---------- MenuStrip handlers ----------

    Private Sub NewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles NewRecordsToolStripMenuItem.Click
        If Not HasAccess("Create") Then
            MessageBox.Show("Access denied. Admins and Managers only.", "Unauthorized",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Me.Hide()
        Using frm As New NewRecords()
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles ViewRecordsToolStripMenuItem.Click
        Me.Hide()
        Using frm As New ViewRecords()
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub EditRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles EditRecordToolStripMenuItem.Click
        If Not HasAccess("Edit") Then
            MessageBox.Show("Access denied. Admins and Managers only.", "Unauthorized",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Me.Hide()
        Using frm As New EditRecords()
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles DeleteRecordToolStripMenuItem.Click
        If Not HasAccess("Delete") Then
            MessageBox.Show("Access denied. Admins only.", "Unauthorized",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Me.Hide()
        Using frm As New DeleteRecords()
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles AboutProgramToolStripMenuItem.Click
        Me.Hide()
        AboutProgram.Show()
    End Sub

    Private Sub AboutCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles AboutCompanyToolStripMenuItem.Click
        Me.Hide()
        AboutCompany.Show()
    End Sub

    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles HowToToolStripMenuItem.Click
        Me.Hide()
        How_To.Show()
    End Sub

    ' ---------- Dashboard button handlers ----------

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        ViewRecordsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnNewRecords_Click(sender As Object, e As EventArgs) Handles btnNewRecords.Click
        NewRecordsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnEditRecords_Click(sender As Object, e As EventArgs) Handles btnEditRecords.Click
        EditRecordToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnDeleteRecords_Click(sender As Object, e As EventArgs) Handles btnDeleteRecords.Click
        DeleteRecordToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnAboutProgram_Click(sender As Object, e As EventArgs) Handles btnAboutProgram.Click
        AboutProgramToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnAboutCompany_Click(sender As Object, e As EventArgs) Handles btnAboutCompany.Click
        AboutCompanyToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnHowTo_Click(sender As Object, e As EventArgs) Handles btnHowTo.Click
        HowToToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogOutToolStripMenuItem_Click(sender, e)
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

    Private Sub lblViewRecords_Click(sender As Object, e As EventArgs) Handles lblViewRecords.Click
        ViewRecordsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub lblEditRecords_Click(sender As Object, e As EventArgs) Handles lblEditRecords.Click
        EditRecordToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub lblAddRecords_Click(sender As Object, e As EventArgs) Handles lblAddRecords.Click
        NewRecordsToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub lblDeleteRecords_Click(sender As Object, e As EventArgs) Handles lblDeleteRecords.Click
        DeleteRecordToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub lblAdminPanel_Click(sender As Object, e As EventArgs) Handles lblAdminPanel.Click
        If Session.CurrentUserAccess = "Admin" Then
            Me.Hide()
            AdminPanel.Show()
        Else
            MessageBox.Show("Access denied. Admins only.", "Unauthorized",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub lblAboutCompany_Click(sender As Object, e As EventArgs) Handles lblAboutCompany.Click
        AboutCompanyToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub lblAboutProgram_Click(sender As Object, e As EventArgs) Handles lblAboutProgram.Click
        AboutProgramToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub lblHowTo_Click(sender As Object, e As EventArgs) Handles lblHowTo.Click
        HowToToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        LogOutToolStripMenuItem_Click(sender, e)

    End Sub
End Class
