Public Class How_To
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes current Form
        Me.Close()
        'Opens HomePage Form
        HomePage.Show()
    End Sub
End Class