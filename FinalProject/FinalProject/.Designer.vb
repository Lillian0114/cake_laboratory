<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.rdbCheese = New System.Windows.Forms.RadioButton()
        Me.GroupBoxCakes = New System.Windows.Forms.GroupBox()
        Me.picR = New System.Windows.Forms.PictureBox()
        Me.picT = New System.Windows.Forms.PictureBox()
        Me.picM = New System.Windows.Forms.PictureBox()
        Me.picC = New System.Windows.Forms.PictureBox()
        Me.PictureBoxR = New System.Windows.Forms.PictureBox()
        Me.PictureBoxM = New System.Windows.Forms.PictureBox()
        Me.PictureBoxT = New System.Windows.Forms.PictureBox()
        Me.PictureBoxC = New System.Windows.Forms.PictureBox()
        Me.lblRprice = New System.Windows.Forms.Label()
        Me.lblTprice = New System.Windows.Forms.Label()
        Me.lblMprice = New System.Windows.Forms.Label()
        Me.lblCprice = New System.Windows.Forms.Label()
        Me.rdbCarrot = New System.Windows.Forms.RadioButton()
        Me.rdbMatcha = New System.Windows.Forms.RadioButton()
        Me.rdbTiramisu = New System.Windows.Forms.RadioButton()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblShowprice = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.GroupBoxCakes.SuspendLayout()
        CType(Me.picR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbCheese
        '
        Me.rdbCheese.AutoSize = True
        Me.rdbCheese.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdbCheese.Location = New System.Drawing.Point(33, 65)
        Me.rdbCheese.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbCheese.Name = "rdbCheese"
        Me.rdbCheese.Size = New System.Drawing.Size(202, 44)
        Me.rdbCheese.TabIndex = 0
        Me.rdbCheese.TabStop = True
        Me.rdbCheese.Text = "重乳酪蛋糕"
        Me.rdbCheese.UseVisualStyleBackColor = True
        '
        'GroupBoxCakes
        '
        Me.GroupBoxCakes.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxCakes.Controls.Add(Me.picR)
        Me.GroupBoxCakes.Controls.Add(Me.picT)
        Me.GroupBoxCakes.Controls.Add(Me.picM)
        Me.GroupBoxCakes.Controls.Add(Me.picC)
        Me.GroupBoxCakes.Controls.Add(Me.PictureBoxR)
        Me.GroupBoxCakes.Controls.Add(Me.PictureBoxM)
        Me.GroupBoxCakes.Controls.Add(Me.PictureBoxT)
        Me.GroupBoxCakes.Controls.Add(Me.PictureBoxC)
        Me.GroupBoxCakes.Controls.Add(Me.lblRprice)
        Me.GroupBoxCakes.Controls.Add(Me.lblTprice)
        Me.GroupBoxCakes.Controls.Add(Me.lblMprice)
        Me.GroupBoxCakes.Controls.Add(Me.lblCprice)
        Me.GroupBoxCakes.Controls.Add(Me.rdbCarrot)
        Me.GroupBoxCakes.Controls.Add(Me.rdbMatcha)
        Me.GroupBoxCakes.Controls.Add(Me.rdbTiramisu)
        Me.GroupBoxCakes.Controls.Add(Me.rdbCheese)
        Me.GroupBoxCakes.Location = New System.Drawing.Point(19, 20)
        Me.GroupBoxCakes.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxCakes.Name = "GroupBoxCakes"
        Me.GroupBoxCakes.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxCakes.Size = New System.Drawing.Size(843, 645)
        Me.GroupBoxCakes.TabIndex = 6
        Me.GroupBoxCakes.TabStop = False
        Me.GroupBoxCakes.Text = "請選擇要製作的蛋糕"
        '
        'picR
        '
        Me.picR.Image = CType(resources.GetObject("picR.Image"), System.Drawing.Image)
        Me.picR.Location = New System.Drawing.Point(531, 430)
        Me.picR.Name = "picR"
        Me.picR.Size = New System.Drawing.Size(259, 186)
        Me.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picR.TabIndex = 15
        Me.picR.TabStop = False
        '
        'picT
        '
        Me.picT.Image = CType(resources.GetObject("picT.Image"), System.Drawing.Image)
        Me.picT.Location = New System.Drawing.Point(78, 430)
        Me.picT.Name = "picT"
        Me.picT.Size = New System.Drawing.Size(245, 186)
        Me.picT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picT.TabIndex = 14
        Me.picT.TabStop = False
        '
        'picM
        '
        Me.picM.Image = CType(resources.GetObject("picM.Image"), System.Drawing.Image)
        Me.picM.Location = New System.Drawing.Point(531, 120)
        Me.picM.Name = "picM"
        Me.picM.Size = New System.Drawing.Size(257, 178)
        Me.picM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picM.TabIndex = 13
        Me.picM.TabStop = False
        '
        'picC
        '
        Me.picC.Image = CType(resources.GetObject("picC.Image"), System.Drawing.Image)
        Me.picC.Location = New System.Drawing.Point(78, 135)
        Me.picC.Name = "picC"
        Me.picC.Size = New System.Drawing.Size(245, 197)
        Me.picC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picC.TabIndex = 12
        Me.picC.TabStop = False
        '
        'PictureBoxR
        '
        Me.PictureBoxR.Image = CType(resources.GetObject("PictureBoxR.Image"), System.Drawing.Image)
        Me.PictureBoxR.Location = New System.Drawing.Point(607, 328)
        Me.PictureBoxR.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBoxR.Name = "PictureBoxR"
        Me.PictureBoxR.Size = New System.Drawing.Size(96, 106)
        Me.PictureBoxR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxR.TabIndex = 11
        Me.PictureBoxR.TabStop = False
        Me.PictureBoxR.Visible = False
        '
        'PictureBoxM
        '
        Me.PictureBoxM.Image = CType(resources.GetObject("PictureBoxM.Image"), System.Drawing.Image)
        Me.PictureBoxM.Location = New System.Drawing.Point(629, 32)
        Me.PictureBoxM.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBoxM.Name = "PictureBoxM"
        Me.PictureBoxM.Size = New System.Drawing.Size(84, 97)
        Me.PictureBoxM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxM.TabIndex = 10
        Me.PictureBoxM.TabStop = False
        Me.PictureBoxM.Visible = False
        '
        'PictureBoxT
        '
        Me.PictureBoxT.Image = CType(resources.GetObject("PictureBoxT.Image"), System.Drawing.Image)
        Me.PictureBoxT.Location = New System.Drawing.Point(142, 324)
        Me.PictureBoxT.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBoxT.Name = "PictureBoxT"
        Me.PictureBoxT.Size = New System.Drawing.Size(88, 111)
        Me.PictureBoxT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxT.TabIndex = 9
        Me.PictureBoxT.TabStop = False
        Me.PictureBoxT.Visible = False
        '
        'PictureBoxC
        '
        Me.PictureBoxC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxC.Image = CType(resources.GetObject("PictureBoxC.Image"), System.Drawing.Image)
        Me.PictureBoxC.Location = New System.Drawing.Point(162, 32)
        Me.PictureBoxC.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBoxC.Name = "PictureBoxC"
        Me.PictureBoxC.Size = New System.Drawing.Size(88, 97)
        Me.PictureBoxC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxC.TabIndex = 8
        Me.PictureBoxC.TabStop = False
        Me.PictureBoxC.Visible = False
        '
        'lblRprice
        '
        Me.lblRprice.AutoSize = True
        Me.lblRprice.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRprice.Location = New System.Drawing.Point(713, 364)
        Me.lblRprice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRprice.Name = "lblRprice"
        Me.lblRprice.Size = New System.Drawing.Size(117, 30)
        Me.lblRprice.TabIndex = 7
        Me.lblRprice.Text = "$300/6吋"
        '
        'lblTprice
        '
        Me.lblTprice.AutoSize = True
        Me.lblTprice.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTprice.Location = New System.Drawing.Point(240, 365)
        Me.lblTprice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTprice.Name = "lblTprice"
        Me.lblTprice.Size = New System.Drawing.Size(117, 30)
        Me.lblTprice.TabIndex = 6
        Me.lblTprice.Text = "$380/6吋"
        '
        'lblMprice
        '
        Me.lblMprice.AutoSize = True
        Me.lblMprice.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMprice.Location = New System.Drawing.Point(723, 71)
        Me.lblMprice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMprice.Name = "lblMprice"
        Me.lblMprice.Size = New System.Drawing.Size(108, 28)
        Me.lblMprice.TabIndex = 5
        Me.lblMprice.Text = "$420/6吋"
        '
        'lblCprice
        '
        Me.lblCprice.AutoSize = True
        Me.lblCprice.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCprice.Location = New System.Drawing.Point(246, 71)
        Me.lblCprice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCprice.Name = "lblCprice"
        Me.lblCprice.Size = New System.Drawing.Size(117, 30)
        Me.lblCprice.TabIndex = 4
        Me.lblCprice.Text = "$450/6吋"
        '
        'rdbCarrot
        '
        Me.rdbCarrot.AutoSize = True
        Me.rdbCarrot.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdbCarrot.Location = New System.Drawing.Point(473, 358)
        Me.rdbCarrot.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbCarrot.Name = "rdbCarrot"
        Me.rdbCarrot.Size = New System.Drawing.Size(202, 44)
        Me.rdbCarrot.TabIndex = 3
        Me.rdbCarrot.TabStop = True
        Me.rdbCarrot.Text = "胡蘿蔔蛋糕"
        Me.rdbCarrot.UseVisualStyleBackColor = True
        '
        'rdbMatcha
        '
        Me.rdbMatcha.AutoSize = True
        Me.rdbMatcha.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdbMatcha.Location = New System.Drawing.Point(473, 65)
        Me.rdbMatcha.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbMatcha.Name = "rdbMatcha"
        Me.rdbMatcha.Size = New System.Drawing.Size(234, 44)
        Me.rdbMatcha.TabIndex = 2
        Me.rdbMatcha.TabStop = True
        Me.rdbMatcha.Text = "抹茶戚風蛋糕"
        Me.rdbMatcha.UseVisualStyleBackColor = True
        '
        'rdbTiramisu
        '
        Me.rdbTiramisu.AutoSize = True
        Me.rdbTiramisu.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdbTiramisu.Location = New System.Drawing.Point(33, 360)
        Me.rdbTiramisu.Margin = New System.Windows.Forms.Padding(5)
        Me.rdbTiramisu.Name = "rdbTiramisu"
        Me.rdbTiramisu.Size = New System.Drawing.Size(170, 44)
        Me.rdbTiramisu.TabIndex = 1
        Me.rdbTiramisu.TabStop = True
        Me.rdbTiramisu.Text = "提拉米蘇"
        Me.rdbTiramisu.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(264, 705)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(62, 48)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "數量:"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(377, 698)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(181, 55)
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPrice.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(264, 777)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(62, 48)
        Me.lblTotalPrice.TabIndex = 2
        Me.lblTotalPrice.Text = "價錢:"
        '
        'lblShowprice
        '
        Me.lblShowprice.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblShowprice.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblShowprice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShowprice.Location = New System.Drawing.Point(377, 768)
        Me.lblShowprice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblShowprice.Name = "lblShowprice"
        Me.lblShowprice.Size = New System.Drawing.Size(181, 55)
        Me.lblShowprice.TabIndex = 3
        Me.lblShowprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnNext.Location = New System.Drawing.Point(662, 723)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(147, 68)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "下一頁"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(661, 723)
        Me.btnTotal.Margin = New System.Windows.Forms.Padding(5)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(147, 68)
        Me.btnTotal.TabIndex = 1
        Me.btnTotal.Text = "總金額"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 861)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblShowprice)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.GroupBoxCakes)
        Me.Controls.Add(Me.btnTotal)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "主頁面"
        Me.GroupBoxCakes.ResumeLayout(False)
        Me.GroupBoxCakes.PerformLayout()
        CType(Me.picR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbCheese As RadioButton
    Friend WithEvents GroupBoxCakes As GroupBox
    Friend WithEvents lblRprice As Label
    Friend WithEvents lblTprice As Label
    Friend WithEvents lblMprice As Label
    Friend WithEvents lblCprice As Label
    Friend WithEvents rdbCarrot As RadioButton
    Friend WithEvents rdbMatcha As RadioButton
    Friend WithEvents rdbTiramisu As RadioButton
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblShowprice As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents PictureBoxR As PictureBox
    Friend WithEvents PictureBoxM As PictureBox
    Friend WithEvents PictureBoxT As PictureBox
    Friend WithEvents PictureBoxC As PictureBox
    Friend WithEvents picR As PictureBox
    Friend WithEvents picT As PictureBox
    Friend WithEvents picM As PictureBox
    Friend WithEvents picC As PictureBox
End Class
