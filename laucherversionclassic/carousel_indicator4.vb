Public Class carousel_indicator4

    Private Sub carousel_indicator4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources._4
    End Sub

    Private Sub carousel_indicator4_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Me.BackgroundImage = My.Resources._4_selected
    End Sub
End Class
