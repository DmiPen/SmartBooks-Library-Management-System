Imports System.Windows.Forms
Imports SmartBooks_Library_Management_System.SmartBooksDataSetTableAdapters

Public Class login
    Inherits Form

    Private ReadOnly _usersAdapter As New UsersTableAdapter()
    Private ReadOnly _usersTable As New SmartBooksDataSet.UsersDataTable()

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ── Point the adapter at your project’s MDF, not the bin\Debug copy ──
        _usersAdapter.Connection.ConnectionString =
            "Data Source=(LocalDB)\MSSQLLocalDB;" &
            "AttachDbFilename=|DataDirectory|\LibraryManagement.mdf;" &
            "Integrated Security=True"
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname = txtUsername.Text.Trim()
        Dim pwd = txtPassword.Text

        If uname = "" OrElse pwd = "" Then
            MessageBox.Show("Enter both username and password.", "Missing Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Fetch the user by username
            _usersTable.Clear()
            _usersAdapter.FillByUsername(_usersTable, uname)

            If _usersTable.Rows.Count = 0 Then
                MessageBox.Show("Username not found.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validate password and activation
            Dim userRow = DirectCast(_usersTable.Rows(0), SmartBooksDataSet.UsersRow)
            If userRow.Password <> pwd Then
                MessageBox.Show("Incorrect password.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If Not userRow.IsActive Then
                MessageBox.Show("Account not activated.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Store user info in Session module
            Session.CurrentUserID = userRow.UserID
            Session.CurrentUserName = userRow.FullName
            Session.CurrentUserAccess = userRow.AccessLevel

            ' Open HomePage and hide login form
            Dim home As New HomePage()
            home.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim regForm As New UserRegistration()
        regForm.Show()
        Me.Hide()
    End Sub

    ' Ensure application only exits when login is closed and no other forms remain
    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        MyBase.OnFormClosed(e)
        If Application.OpenForms.Count = 0 Then
            Application.Exit()
        End If
    End Sub

End Class
