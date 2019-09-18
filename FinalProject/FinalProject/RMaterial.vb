Public Class RMaterial
    Public quality_temp As Integer
    Public dlgButton As DialogResult
    Private Sub CMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkNeed1.Text = "紅蘿蔔" & quality_temp * 180 & "g"
        chkNeed2.Text = "細砂糖" & quality_temp * 90 & "g"
        chkNeed3.Text = "低筋麵粉" & quality_temp * 100 & "g"
        chkNeed4.Text = "無鹽奶油" & quality_temp * 100 & "g"
        chkNeed5.Text = "雞蛋" & quality_temp * 2 & "顆"
        chkNeed6.Text = "泡打粉" & quality_temp * 1 & "茶匙"
        chkNeed7.Text = "葵瓜子" & quality_temp * 1 & "把"
        chkNeed8.Text = "鹽巴" & quality_temp * 1 & "小撮"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If chkNeed1.Checked = True And chkNeed2.Checked = True And chkNeed3.Checked = True And
            chkNeed4.Checked = True And chkNeed5.Checked = True And chkNeed6.Checked = True And
            chkNeed7.Checked = True And chkNeed8.Checked = True Then

            Dim NewForm2 As New RProcedure
            Me.Hide()
            NewForm2.ShowDialog()
            Me.Close()
        Else
            dlgButton = MessageBox.Show("您還有食材沒有準備齊全喔！", "請確切勾選", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub CheckedChangedEvent(sender As Object, e As EventArgs) Handles chkNeed1.CheckedChanged, chkNeed2.CheckedChanged, chkNeed3.CheckedChanged, chkNeed4.CheckedChanged, chkNeed5.CheckedChanged, chkNeed6.CheckedChanged, chkNeed7.CheckedChanged, chkNeed8.CheckedChanged
        If chkNeed1.Checked = True Then
            chkNeed1.ForeColor = Color.DarkOliveGreen
        End If
        If chkNeed1.Checked = False Then
            chkNeed1.ForeColor = Color.Black
        End If
        If chkNeed2.Checked = True Then
            chkNeed2.ForeColor = Color.DarkOliveGreen
        End If
        If chkNeed2.Checked = False Then
            chkNeed2.ForeColor = Color.Black
        End If
        If chkNeed3.Checked = True Then
            chkNeed3.ForeColor = Color.DarkOliveGreen
        End If
        If chkNeed3.Checked = False Then
            chkNeed3.ForeColor = Color.Black
        End If
        If chkNeed4.Checked = True Then
            chkNeed4.ForeColor = Color.DarkOliveGreen
        End If
        If chkNeed4.Checked = False Then
            chkNeed4.ForeColor = Color.Black
        End If
        If chkNeed5.Checked = True Then
            chkNeed5.ForeColor = Color.DarkOliveGreen
        End If
        If chkNeed5.Checked = False Then
            chkNeed5.ForeColor = Color.Black
        End If
        If chkNeed6.Checked = True Then
            chkNeed6.ForeColor = Color.DarkOliveGreen
        End If
        If chkNeed6.Checked = False Then
            chkNeed6.ForeColor = Color.Black
        End If
        If chkNeed7.Checked = True Then
            chkNeed7.ForeColor = Color.DarkOliveGreen
        End If
        If chkNeed7.Checked = False Then
            chkNeed7.ForeColor = Color.Black
        End If
        If chkNeed8.Checked = True Then
            chkNeed8.ForeColor = Color.DarkOliveGreen
        End If
        If chkNeed8.Checked = False Then
            chkNeed8.ForeColor = Color.Black
        End If
    End Sub
End Class
