Public Class TMaterial
    Public quality_temp As Integer
    Public dlgButton As DialogResult
    Private Sub CMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkNeed1.Text = "馬斯卡彭起司" & quality_temp * 500 & "g"
        chkNeed2.Text = "細砂糖" & quality_temp * 100 & "g"
        chkNeed3.Text = "蛋黃" & quality_temp * 5 & "個"
        chkNeed4.Text = "蛋白" & quality_temp * 3 & "個"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If chkNeed1.Checked = True And chkNeed2.Checked = True And chkNeed3.Checked = True And
            chkNeed4.Checked = True And chkNeed5.Checked = True And chkNeed6.Checked = True And
            chkNeed7.Checked = True Then

            Dim NewForm2 As New TProcedure
            Me.Hide()
            NewForm2.ShowDialog()
            Me.Close()
        Else
            dlgButton = MessageBox.Show("您還有食材沒有準備齊全喔！", "請確切勾選", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub CheckedChangedEvent(sender As Object, e As EventArgs) Handles chkNeed1.CheckedChanged, chkNeed2.CheckedChanged, chkNeed3.CheckedChanged, chkNeed4.CheckedChanged, chkNeed5.CheckedChanged, chkNeed6.CheckedChanged, chkNeed7.CheckedChanged
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
    End Sub
End Class
