Public Class carousel_indicator2

    Private Sub carousel_indicator2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources._2
    End Sub

    Private Sub carousel_indicator2_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Me.BackgroundImage = My.Resources._2_selected
    End Sub
End Class
