﻿Public Class TMaterial
    Public quality_temp As Integer
    Public dlgButton As DialogResult
    Private Sub CMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Text = "馬斯卡彭起司" & quality_temp * 500 & "g"
        CheckBox2.Text = "細砂糖" & quality_temp * 100 & "g"
        CheckBox3.Text = "蛋黃" & quality_temp * 5 & "個"
        CheckBox4.Text = "蛋白" & quality_temp * 3 & "個"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And
            CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True And
            CheckBox7.Checked = True Then

            Dim NewForm2 As New TProcedure
            Me.Hide()
            NewForm2.ShowDialog()
            Me.Close()
        Else
            dlgButton = MessageBox.Show("您還有食材沒有準備齊全喔！", "請確切勾選", MessageBoxButtons.OK)
        End If
    End Sub

End Class
