Imports System.Data
Imports System.Data.SqlClient

    Public Class NewRecords
        Private ReadOnly _conString As String =
      "Data Source=(LocalDB)\MSSQLLocalDB;" &
      "AttachDbFilename=C:\Users\descl\Source\Repos\" &
      "SmartBooks-Library-Management-System\SmartBooks-Library-Management-System\" &
      "LibraryManagement.mdf;Integrated Security=True"
        Private _con As SqlConnection

        Private Sub NewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
            Try
                Dim sql = "
INSERT INTO Books
 (Title, Author, ISBN, PublishedDate, Category, Quantity, AddedByUserID)
 VALUES
 (@Title,@Author,@ISBN,@PublishedDate,@Category,@Quantity,@AddedByUserID)"
                Using cmd As New SqlCommand(sql, _con)
                    cmd.Parameters.AddWithValue("@Title", BookTitletxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@Author", AuthorNametxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@ISBN", ISBNtxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@PublishedDate", DateTime.Parse(PublishedDatetxt.Text))
                    cmd.Parameters.AddWithValue("@Category", Caregorytxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@Quantity", Integer.Parse(Quantitytxt.Text))
                    cmd.Parameters.AddWithValue("@AddedByUserID", Integer.Parse(UserIDtxt.Text))

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Record added!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadRecords()
                        ClearFields()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Insert Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ClearFields()
            BookTitletxt.Clear()
            AuthorNametxt.Clear()
            ISBNtxt.Clear()
            PublishedDatetxt.Clear()
            Caregorytxt.Clear()
            Quantitytxt.Clear()
            UserIDtxt.Clear()
            BookTitletxt.Focus()
        End Sub

        Private Sub NewRecords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            If _con?.State = ConnectionState.Open Then _con.Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
            'Closes the current Form
            Me.Close()
            'Opens the HomePage
            HomePage.Show()
        End Sub

    End Class