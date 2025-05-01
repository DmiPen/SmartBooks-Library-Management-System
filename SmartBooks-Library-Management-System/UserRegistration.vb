Imports System.ComponentModel
Imports SmartBooks_Library_Management_System.SmartBooksDataSetTableAdapters

Public Class UserRegistration
    Inherits Form

    ' Use a single, internally managed UsersTableAdapter
    Private ReadOnly _usersAdapter As New UsersTableAdapter()
    Private usersAdapter As UsersTableAdapter

    ' No custom constructor needed—this default one calls InitializeComponent()
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(usersAdapter As UsersTableAdapter, components As Container)
        Me.usersAdapter = usersAdapter
        Me.components = components
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

        ' Register new user (AccessLevel defaults to "User", IsActive is False)
        Try
            _usersAdapter.Insert(uname, pwd, fullName, "User", False)
            MessageBox.Show("Registration successful! Waiting for admin activation.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Return to login form
            Dim loginForm As New login()
            loginForm.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Registration failed: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
