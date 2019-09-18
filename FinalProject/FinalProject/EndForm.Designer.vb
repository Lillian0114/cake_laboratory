<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndForm))
        Me.lblCon1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCon1
        '
        Me.lblCon1.AutoSize = True
        Me.lblCon1.BackColor = System.Drawing.Color.Transparent
        Me.lblCon1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCon1.Location = New System.Drawing.Point(164, 216)
        Me.lblCon1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCon1.Name = "lblCon1"
        Me.lblCon1.Size = New System.Drawing.Size(393, 40)
        Me.lblCon1.TabIndex = 0
        Me.lblCon1.Text = "恭喜您完成蛋糕製作了呦~"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(270, 278)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 47)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "離開"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'EndForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(900, 900)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCon1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EndForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EndForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCon1 As Label
    Friend WithEvents btnExit As Button
End Class
