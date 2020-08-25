Public Class carousel_indicator3

    Private Sub carousel_indicator3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources._3
    End Sub

    Private Sub carousel_indicator3_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Me.BackgroundImage = My.Resources._3_selected
    End Sub
End Class
