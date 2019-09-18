Public Class CMaterial
    Public quality_temp As Integer
    'Public temp As Integer
    Public dlgButton As DialogResult
    Private Sub CMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'temp = quality_temp
        Me.quality_temp = My.Forms.MainPage.quality
        CheckBox1.Text = "消化餅" & quality_temp * 110 & "g"
        CheckBox2.Text = "無鹽奶油" & quality_temp * 30 & "g"
        CheckBox3.Text = "奶油乳酪" & quality_temp * 500 & "g"
        CheckBox4.Text = "砂糖" & quality_temp * 100 & "g"
        CheckBox5.Text = "全蛋" & quality_temp * 3 & "顆"
        CheckBox6.Text = "檸檬" & quality_temp * 1 & "顆"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And
            CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then

            Dim NewForm2 As New CProcedure
            Me.Hide()
            NewForm2.ShowDialog()
            Me.Close()
        Else
            dlgButton = MessageBox.Show("您還有食材沒有準備齊全喔！", "請確切勾選", MessageBoxButtons.OK)
        End If
    End Sub
End Class
