Imports System.Windows.Forms
Imports SmartBooks_Library_Management_System.SmartBooksDataSetTableAdapters

Public Class AdminPanel
    Inherits Form

    Private usersAdapter As New UsersTableAdapter()
    Private usersTable As New SmartBooksDataSet.UsersDataTable()

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usersAdapter.Connection.ConnectionString =
          "Data Source=(LocalDB)\MSSQLLocalDB;" &
            "AttachDbFilename=|DataDirectory|\LibraryManagement.mdf;" &
            "Integrated Security=True"

        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        usersTable.Clear()
        usersAdapter.Fill(usersTable)
        dgvUsers.DataSource = usersTable
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvUsers.SelectedRows.Count = 0 Then Return
        Dim userId = CInt(dgvUsers.SelectedRows(0).Cells("UserID").Value)
        usersAdapter.UpdateIsActive(True, userId)
        LoadUsers()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        If dgvUsers.SelectedRows.Count = 0 Then Return
        Dim userId = CInt(dgvUsers.SelectedRows(0).Cells("UserID").Value)
        usersAdapter.UpdateIsActive(False, userId)
        LoadUsers()
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        Try
            Dim count As Integer = usersAdapter.Update(usersTable)
            MessageBox.Show($"Successfully applied {count} change(s).",
                            "Users Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating users: " & ex.Message,
                            "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            LoadUsers()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUsers()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes the current Form
        Me.Close()
        'Opens Homepage Form
        HomePage.Show()
    End Sub
End Class
