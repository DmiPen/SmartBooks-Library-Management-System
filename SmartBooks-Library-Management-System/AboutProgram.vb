Public Class AboutProgram
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes current Form
        Me.Close()
        'Opens HomePage Form
        HomePage.Show()
    End Sub
End Class