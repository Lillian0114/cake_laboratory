Option Explicit On
Option Infer Off
Option Strict On

Public Class MainPage
    Public quality As Integer
    Public dlgButton As DialogResult

    Private Sub Changed(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged,
                                                                  RadioButton3.CheckedChanged, RadioButton4.CheckedChanged,
                                                                  TextBox1.TextChanged
        Label3.Text = String.Empty
        'TextBox1.Text = String.Empty
        If Button1.Visible = True Then
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim price As Integer
        'Dim quality As Integer
        Integer.TryParse(TextBox1.Text, quality)
        'Dim dlgButton As DialogResult

        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
            dlgButton = MessageBox.Show("您要製作的蛋糕尚未勾選喔!", "請勾選要製作的蛋糕種類", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox1.Text = String.Empty OrElse TextBox1.Text = "0" Then
            dlgButton = MessageBox.Show("您的數量尚未輸入喔!", "請輸入正確數量", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If RadioButton1.Checked Then
                price = 450 * quality
            End If
            If RadioButton2.Checked Then
                price = 380 * quality
            End If
            If RadioButton3.Checked Then
                price = 420 * quality
            End If
            If RadioButton4.Checked Then
                price = 300 * quality
            End If
            Label3.Text = price.ToString("C0")
        End If

        If Button1.Visible = False Then
            Button1.Visible = True
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.SelectAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Integer.TryParse(TextBox1.Text, Me.quality)

        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
            dlgButton = MessageBox.Show("您要製作的蛋糕尚未勾選喔!", "請勾選要製作的蛋糕種類", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox1.Text = String.Empty OrElse TextBox1.Text = "0" Then
            dlgButton = MessageBox.Show("您的數量尚未輸入喔!", "請輸入正確數量", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf RadioButton1.Checked = True Then
            Dim NewForm As New CMaterial
            NewForm.quality_temp = Me.quality
            Me.Hide()
            NewForm.ShowDialog()
            Me.Close()
        ElseIf RadioButton2.Checked = True Then
            Dim NewForm As New TMaterial
            NewForm.quality_temp = Me.quality
            Me.Hide()
            NewForm.ShowDialog()
            Me.Close()
        ElseIf RadioButton3.Checked = True Then
            Dim NewForm As New MMaterail
            NewForm.quality_temp = Me.quality
            Me.Hide()
            NewForm.ShowDialog()
            Me.Close()
        ElseIf RadioButton4.Checked = True Then
            Dim NewForm As New RMaterial
            NewForm.quality_temp = Me.quality
            Me.Hide()
            NewForm.ShowDialog()
            Me.Close()
        End If
    End Sub

End Class
