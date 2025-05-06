Imports System.Data
Imports System.Data.SqlClient

Public Class DeleteRecords
    Private ReadOnly _conString As String =
      "Data Source=(LocalDB)\MSSQLLocalDB;" &
            "AttachDbFilename=|DataDirectory|\LibraryManagement.mdf;" &
            "Integrated Security=True"
    Private _con As SqlConnection

    Private Sub DeleteRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If RecordsDGV.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a record first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bookID = Convert.ToInt32(RecordsDGV.SelectedRows(0).Cells("BookID").Value)
        If MessageBox.Show("Delete this record?", "Confirm Delete",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using cmd As New SqlCommand("DELETE FROM Books WHERE BookID=@BookID", _con)
                cmd.Parameters.AddWithValue("@BookID", bookID)
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record deleted!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadRecords()
                End If
            End Using
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRecords()
    End Sub

    Private Sub DeleteRecords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _con?.State = ConnectionState.Open Then _con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Hides the current Form
        Me.Hide()
        'Opens the HomePage Form
        HomePage.Show()
    End Sub
End Class