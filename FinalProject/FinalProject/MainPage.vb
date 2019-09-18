Option Explicit On
Option Infer Off
Option Strict On

Public Class MainPage
    Public quality As Integer
    Public dlgButton As DialogResult
    Public count(4) As Integer

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inputfile As IO.StreamReader
        inputfile = IO.File.OpenText("top.txt")
        Dim num As Integer = 0
        Do Until inputfile.Peek = -1
            Integer.TryParse(inputfile.ReadLine, count(num))
            num = num + 1
        Loop
        inputfile.Close()
        Dim outfile As IO.StreamWriter
        outfile = IO.File.CreateText("top.txt")
        outfile.Close()
        If (count(0) > count(1) And count(0) > count(2) And count(0) > count(3)) Then
            PictureBoxC.Visible = True
        ElseIf (count(1) > count(0) And count(1) > count(2) And count(1) > count(3)) Then
            PictureBoxT.Visible = True
        ElseIf (count(2) > count(0) And count(2) > count(1) And count(2) > count(3)) Then
            PictureBoxM.Visible = True
        ElseIf (count(3) > count(0) And count(3) > count(2) And count(3) > count(1)) Then
            PictureBoxR.Visible = True
        End If


    End Sub

    Private Sub Changed(sender As Object, e As EventArgs) Handles rdbCheese.CheckedChanged, rdbTiramisu.CheckedChanged,
                                                                  rdbMatcha.CheckedChanged, rdbCarrot.CheckedChanged,
                                                                  txtAmount.TextChanged
        lblShowprice.Text = String.Empty
        'TextBox1.Text = String.Empty
        If btnNext.Visible = True Then
            btnNext.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim price As Integer
        Integer.TryParse(txtAmount.Text, quality)

        If rdbCheese.Checked = False And rdbTiramisu.Checked = False And rdbMatcha.Checked = False And rdbCarrot.Checked = False Then
            dlgButton = MessageBox.Show("您要製作的蛋糕尚未勾選喔!", "請勾選要製作的蛋糕種類", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtAmount.Text = String.Empty OrElse txtAmount.Text = "0" Then
            dlgButton = MessageBox.Show("您的數量尚未輸入喔!", "請輸入正確數量", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If rdbCheese.Checked Then
                price = 450 * quality
            End If
            If rdbTiramisu.Checked Then
                price = 380 * quality
            End If
            If rdbMatcha.Checked Then
                price = 420 * quality
            End If
            If rdbCarrot.Checked Then
                price = 300 * quality
            End If
            lblShowprice.Text = price.ToString("C0")
        End If

        If btnNext.Visible = False Then
            btnNext.Visible = True
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles txtAmount.Enter
        txtAmount.SelectAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Integer.TryParse(txtAmount.Text, Me.quality)
        Dim outfile As IO.StreamWriter
        outfile = IO.File.AppendText("top.txt")
        If rdbCheese.Checked = True Then
            count(0) += 1
            For i As Integer = 0 To 3
                outfile.WriteLine(count(i))
            Next
            Dim NewForm As New CMaterial
            NewForm.quality_temp = Me.quality
            Me.Hide()
            NewForm.ShowDialog()
            Me.Close()
        ElseIf rdbTiramisu.Checked = True Then
            count(1) += 1
            For i As Integer = 0 To 3
                outfile.WriteLine(count(i))
            Next
            Dim NewForm As New TMaterial
            NewForm.quality_temp = Me.quality
            Me.Hide()
            NewForm.ShowDialog()
            Me.Close()
        ElseIf rdbMatcha.Checked = True Then
            count(2) += 1
            For i As Integer = 0 To 3
                outfile.WriteLine(count(i))
            Next
            Dim NewForm As New MMaterail
            NewForm.quality_temp = Me.quality
            Me.Hide()
            NewForm.ShowDialog()
            Me.Close()
        ElseIf rdbCarrot.Checked = True Then
            count(3) += 1
            For i As Integer = 0 To 3
                outfile.WriteLine(count(i))
            Next
            Dim NewForm As New RMaterial
            NewForm.quality_temp = Me.quality
            Me.Hide()
            NewForm.ShowDialog()
            Me.Close()
        End If
        outfile.Close()
    End Sub

End Class
