<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMaterial
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CMaterial))
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.chkNeed1 = New System.Windows.Forms.CheckBox()
        Me.chkNeed2 = New System.Windows.Forms.CheckBox()
        Me.chkNeed3 = New System.Windows.Forms.CheckBox()
        Me.chkNeed4 = New System.Windows.Forms.CheckBox()
        Me.chkNeed5 = New System.Windows.Forms.CheckBox()
        Me.chkNeed6 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.Location = New System.Drawing.Point(332, 229)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(54, 27)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "食材"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(461, 654)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(134, 56)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "下一頁"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'chkNeed1
        '
        Me.chkNeed1.AutoSize = True
        Me.chkNeed1.BackColor = System.Drawing.Color.Transparent
        Me.chkNeed1.Location = New System.Drawing.Point(337, 304)
        Me.chkNeed1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNeed1.Name = "chkNeed1"
        Me.chkNeed1.Size = New System.Drawing.Size(143, 31)
        Me.chkNeed1.TabIndex = 2
        Me.chkNeed1.Text = "消化餅110g"
        Me.chkNeed1.UseVisualStyleBackColor = False
        '
        'chkNeed2
        '
        Me.chkNeed2.AutoSize = True
        Me.chkNeed2.BackColor = System.Drawing.Color.Transparent
        Me.chkNeed2.Location = New System.Drawing.Point(337, 372)
        Me.chkNeed2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNeed2.Name = "chkNeed2"
        Me.chkNeed2.Size = New System.Drawing.Size(152, 31)
        Me.chkNeed2.TabIndex = 3
        Me.chkNeed2.Text = "無鹽奶油30g"
        Me.chkNeed2.UseVisualStyleBackColor = False
        '
        'chkNeed3
        '
        Me.chkNeed3.AutoSize = True
        Me.chkNeed3.BackColor = System.Drawing.Color.Transparent
        Me.chkNeed3.Location = New System.Drawing.Point(337, 444)
        Me.chkNeed3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNeed3.Name = "chkNeed3"
        Me.chkNeed3.Size = New System.Drawing.Size(164, 31)
        Me.chkNeed3.TabIndex = 4
        Me.chkNeed3.Text = "奶油乳酪500g"
        Me.chkNeed3.UseVisualStyleBackColor = False
        '
        'chkNeed4
        '
        Me.chkNeed4.AutoSize = True
        Me.chkNeed4.BackColor = System.Drawing.Color.Transparent
        Me.chkNeed4.Location = New System.Drawing.Point(337, 509)
        Me.chkNeed4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNeed4.Name = "chkNeed4"
        Me.chkNeed4.Size = New System.Drawing.Size(122, 31)
        Me.chkNeed4.TabIndex = 5
        Me.chkNeed4.Text = "砂糖100g"
        Me.chkNeed4.UseVisualStyleBackColor = False
        '
        'chkNeed5
        '
        Me.chkNeed5.AutoSize = True
        Me.chkNeed5.BackColor = System.Drawing.Color.Transparent
        Me.chkNeed5.Location = New System.Drawing.Point(565, 304)
        Me.chkNeed5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNeed5.Name = "chkNeed5"
        Me.chkNeed5.Size = New System.Drawing.Size(106, 31)
        Me.chkNeed5.TabIndex = 6
        Me.chkNeed5.Text = "全蛋3顆"
        Me.chkNeed5.UseVisualStyleBackColor = False
        '
        'chkNeed6
        '
        Me.chkNeed6.AutoSize = True
        Me.chkNeed6.BackColor = System.Drawing.Color.Transparent
        Me.chkNeed6.Location = New System.Drawing.Point(565, 372)
        Me.chkNeed6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNeed6.Name = "chkNeed6"
        Me.chkNeed6.Size = New System.Drawing.Size(106, 31)
        Me.chkNeed6.TabIndex = 7
        Me.chkNeed6.Text = "檸檬1顆"
        Me.chkNeed6.UseVisualStyleBackColor = False
        '
        'CMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(900, 900)
        Me.Controls.Add(Me.chkNeed6)
        Me.Controls.Add(Me.chkNeed5)
        Me.Controls.Add(Me.chkNeed4)
        Me.Controls.Add(Me.chkNeed3)
        Me.Controls.Add(Me.chkNeed2)
        Me.Controls.Add(Me.chkNeed1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblMenu)
        Me.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "起司蛋糕材料需求"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents chkNeed1 As CheckBox
    Friend WithEvents chkNeed2 As CheckBox
    Friend WithEvents chkNeed3 As CheckBox
    Friend WithEvents chkNeed4 As CheckBox
    Friend WithEvents chkNeed5 As CheckBox
    Friend WithEvents chkNeed6 As CheckBox
End Class
