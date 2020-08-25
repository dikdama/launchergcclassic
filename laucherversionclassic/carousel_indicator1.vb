Public Class carousel_indicator1

    Private Sub carousel_indicator1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources._1_selected
    End Sub

    Private Sub carousel_indicator1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Me.BackgroundImage = My.Resources._1_selected
    End Sub
End Class
