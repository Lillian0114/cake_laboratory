Public Class RProcedure
    Dim NewForm As New EndForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        NewForm.ShowDialog()
        Me.Close()
    End Sub

End Class
