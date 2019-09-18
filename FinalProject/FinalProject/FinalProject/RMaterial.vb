Public Class RMaterial
    Public quality_temp As Integer
    Public dlgButton As DialogResult
    Private Sub CMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Text = "紅蘿蔔" & quality_temp * 180 & "g"
        CheckBox2.Text = "細砂糖" & quality_temp * 90 & "g"
        CheckBox3.Text = "低筋麵粉" & quality_temp * 100 & "g"
        CheckBox4.Text = "無鹽奶油" & quality_temp * 100 & "g"
        CheckBox5.Text = "雞蛋" & quality_temp * 2 & "顆"
        CheckBox6.Text = "泡打粉" & quality_temp * 1 & "茶匙"
        CheckBox7.Text = "葵瓜子" & quality_temp * 1 & "把"
        CheckBox8.Text = "鹽巴" & quality_temp * 1 & "小撮"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And
            CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True And
            CheckBox7.Checked = True And CheckBox8.Checked = True Then

            Dim NewForm2 As New RProcedure
            Me.Hide()
            NewForm2.ShowDialog()
            Me.Close()
        Else
            dlgButton = MessageBox.Show("您還有食材沒有準備齊全喔！", "請確切勾選", MessageBoxButtons.OK)
        End If
    End Sub
End Class
