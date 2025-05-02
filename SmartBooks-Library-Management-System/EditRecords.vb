Imports System.Data
Imports System.Data.SqlClient

Public Class EditRecords
    Private ReadOnly _conString As String =
      "Data Source=(LocalDB)\MSSQLLocalDB;" &
      "AttachDbFilename=C:\Users\descl\Source\Repos\" &
      "SmartBooks-Library-Management-System\SmartBooks-Library-Management-System\" &
      "LibraryManagement.mdf;Integrated Security=True"
    Private _con As SqlConnection

    Private Sub EditRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub RecordsDGV_SelectionChanged(sender As Object, e As EventArgs) Handles RecordsDGV.SelectionChanged
        If RecordsDGV.SelectedRows.Count = 0 Then Return
        Dim row = RecordsDGV.SelectedRows(0)
        BookTitletxt.Text = row.Cells("Title").Value.ToString()
        AuthorNametxt.Text = row.Cells("Author").Value.ToString()
        ISBNtxt.Text = row.Cells("ISBN").Value.ToString()
        PublishedDatetxt.Text = Convert.ToDateTime(row.Cells("PublishedDate").Value).ToShortDateString()
        Caregorytxt.Text = row.Cells("Category").Value.ToString()
        Quantitytxt.Text = row.Cells("Quantity").Value.ToString()
        UserIDtxt.Text = row.Cells("AddedByUserID").Value.ToString()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim bookID = Convert.ToInt32(RecordsDGV.SelectedRows(0).Cells("BookID").Value)
            Dim sql = "
UPDATE Books
SET Title=@Title,
    Author=@Author,
    ISBN=@ISBN,
    PublishedDate=@PublishedDate,
    Category=@Category,
    Quantity=@Quantity,
    AddedByUserID=@AddedByUserID
WHERE BookID=@BookID"
            Using cmd As New SqlCommand(sql, _con)
                cmd.Parameters.AddWithValue("@Title", BookTitletxt.Text.Trim())
                cmd.Parameters.AddWithValue("@Author", AuthorNametxt.Text.Trim())
                cmd.Parameters.AddWithValue("@ISBN", ISBNtxt.Text.Trim())
                cmd.Parameters.AddWithValue("@PublishedDate", DateTime.Parse(PublishedDatetxt.Text))
                cmd.Parameters.AddWithValue("@Category", Caregorytxt.Text.Trim())
                cmd.Parameters.AddWithValue("@Quantity", Integer.Parse(Quantitytxt.Text))
                cmd.Parameters.AddWithValue("@AddedByUserID", Integer.Parse(UserIDtxt.Text))
                cmd.Parameters.AddWithValue("@BookID", bookID)

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record updated!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadRecords()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Update Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRecords()
    End Sub

    Private Sub EditRecords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _con?.State = ConnectionState.Open Then _con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    'Hides the current Form
    Me.Hide()
    'Opens the HomePage Form
    HomePage.Show()
End Sub
End Class