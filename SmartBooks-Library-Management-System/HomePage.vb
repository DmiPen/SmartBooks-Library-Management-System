Public Class HomePage
    Private Sub NewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRecordsToolStripMenuItem.Click
        'Hides the current Form
        Me.Hide()
        'Opens the New Records Form
        NewRecords.Show()
    End Sub

    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        'Hides the current Form
        Me.Hide()
        'Opens the ViewRecords Form
        ViewRecords.Show()
    End Sub
End Class