Public Class CMaterial
    Public quality_temp As Integer
    'Public temp As Integer
    Public dlgButton As DialogResult
    Private Sub CMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'temp = quality_temp
        Me.quality_temp = My.Forms.MainPage.quality
        chkNeed1.Text = "消化餅" & quality_temp * 110 & "g"
        chkNeed2.Text = "無鹽奶油" & quality_temp * 30 & "g"
        chkNeed3.Text = "奶油乳酪" & quality_temp * 500 & "g"
        chkNeed4.Text = "砂糖" & quality_temp * 100 & "g"
        chkNeed5.Text = "全蛋" & quality_temp * 3 & "顆"
        chkNeed6.Text = "檸檬" & quality_temp * 1 & "顆"

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If chkNeed1.Checked = True And chkNeed2.Checked = True And chkNeed3.Checked = True And
            chkNeed4.Checked = True And chkNeed5.Checked = True And chkNeed6.Checked = True Then

            Dim NewForm2 As New CProcedure
            Me.Hide()
            NewForm2.ShowDialog()
            Me.Close()
        Else
            dlgButton = MessageBox.Show("您還有食材沒有準備齊全喔！", "請確切勾選", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub CheckedChangedEvent(sender As Object, e As EventArgs) Handles chkNeed1.CheckedChanged, chkNeed2.CheckedChanged, chkNeed3.CheckedChanged, chkNeed4.CheckedChanged, chkNeed5.CheckedChanged, chkNeed6.CheckedChanged
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
    End Sub
End Class
