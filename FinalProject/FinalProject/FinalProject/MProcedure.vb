﻿Public Class MProcedure

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim NewForm As New EndForm
        Me.Hide()
        NewForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub MProcedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lblTop As New Label
        Me.Controls.Add(lblTop)
        lblTop.Location = New Point(0, 0)
        lblTop.Focus()
    End Sub
End Class