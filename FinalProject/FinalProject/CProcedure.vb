Public Class CProcedure

    Dim NewForm As New EndForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Hide()
        NewForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub lblDP17_Click(sender As Object, e As EventArgs) Handles lblDP17.Click

    End Sub

    Private Sub CProcedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
