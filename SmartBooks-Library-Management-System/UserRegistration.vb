Imports System.ComponentModel
Imports SmartBooks_Library_Management_System.SmartBooksDataSetTableAdapters

Public Class UserRegistration
    Inherits Form

    ' Single UsersTableAdapter instance
    Private ReadOnly _usersAdapter As New UsersTableAdapter()

    Private Sub UserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Point adapter at your persistent MDF
        _usersAdapter.Connection.ConnectionString =
            "Data Source=(LocalDB)\MSSQLLocalDB;" &
            "AttachDbFilename=C:\Users\descl\Source\Repos\" &
            "SmartBooks-Library-Management-System\SmartBooks-Library-Management-System\" &
            "LibraryManagement.mdf;" &
            "Integrated Security=True"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim uname = txtUsername.Text.Trim()
        Dim pwd = txtPassword.Text
        Dim fullName = txtFullName.Text.Trim()

        If uname = "" OrElse pwd = "" Then
            MessageBox.Show("Username and password are required.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check for existing username
        Dim checkTable As New SmartBooksDataSet.UsersDataTable()
        _usersAdapter.FillByUsername(checkTable, uname)
        If checkTable.Rows.Count > 0 Then
            MessageBox.Show("Username already exists.", "Registration Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Insert new user as Standard & Inactive
        Try
            _usersAdapter.Insert(uname, pwd, fullName, "Standard", False)
            MessageBox.Show("Registration successful! Waiting for admin activation.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Return to login
            Dim loginForm As New login()
            loginForm.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Registration failed: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
