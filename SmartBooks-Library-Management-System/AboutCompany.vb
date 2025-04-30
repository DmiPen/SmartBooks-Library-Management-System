Public Class AboutCompany
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Close current Form
        Me.Close()
        'Opens Homepage Form
        HomePage.Show()
    End Sub
End Class