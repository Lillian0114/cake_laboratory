Public Class TProcedure
    Private Sub TProcedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lblTop As New Label
        Me.Controls.Add(lblTop)
        lblTop.Location = New Point(0, 0)
        lblTop.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Dim NewForm As New EndForm
        Me.Hide()
        NewForm.ShowDialog()
        Me.Close()
    End Sub
End Class