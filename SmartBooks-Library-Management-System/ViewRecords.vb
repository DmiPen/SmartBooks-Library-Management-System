Imports System.Data
Imports System.Data.SqlClient

Public Class ViewRecords

    Private ReadOnly _conString As String =
        "Data Source=(LocalDB)\MSSQLLocalDB;" &
        "AttachDbFilename=C:\Users\descl\Source\Repos\" &
        "SmartBooks-Library-Management-System\SmartBooks-Library-Management-System\" &
        "LibraryManagement.mdf;Integrated Security=True"

    Private _con As SqlConnection

    Private Sub ViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _con = New SqlConnection(_conString)
        _con.Open()
        LoadRecords()
    End Sub

    Private Sub LoadRecords()
        Dim dt As New DataTable()
        Using da As New SqlDataAdapter("SELECT * FROM Books", _con)
            da.Fill(dt)
        End Using
        RecordsDGV.DataSource = dt
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRecords()
    End Sub

    Private Sub ViewRecords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _con?.State = ConnectionState.Open Then _con.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Hides the current Form
        Me.Hide()
        ' Opens the HomePage Form
        HomePage.Show()
    End Sub

End Class