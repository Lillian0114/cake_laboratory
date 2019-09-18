Public Class WelcomePage
    Private Sub WelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        Me.Hide()
        Timer.Enabled = False
        MainPage.ShowDialog()
        Me.Close()

    End Sub
End Class