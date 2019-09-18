Public Class MMaterail
    Public quality_temp As Integer
    Public dlgButton As DialogResult

    Private Sub CMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Text = "液體油" & quality_temp * 30 & "g"
        CheckBox2.Text = "抹茶粉" & quality_temp * 5 & "g"
        CheckBox3.Text = "牛奶" & quality_temp * 50 & "g"
        CheckBox4.Text = "砂糖" & quality_temp * 50 & "g"
        CheckBox5.Text = "低筋麵粉" & quality_temp * 45 & "g"
        CheckBox6.Text = "蛋黃" & quality_temp * 3 & "個"
        CheckBox7.Text = "蛋白" & quality_temp * 3 & "個"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And
           CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True And
           CheckBox7.Checked = True Then
            Dim NewForm2 As New MProcedure
            Me.Hide()
            NewForm2.ShowDialog()
            Me.Close()
        Else
            dlgButton = MessageBox.Show("您還有食材沒有準備齊全喔！", "請確切勾選", MessageBoxButtons.OK)
        End If
    End Sub

End Class
