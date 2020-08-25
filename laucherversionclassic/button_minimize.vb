Public Class button_minimize

    Private Sub button_minimize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.minimize
    End Sub

    Private Sub button_minimize_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BackgroundImage = My.Resources.minimize_onfocused
    End Sub

    Private Sub button_minimize_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackgroundImage = My.Resources.minimize
    End Sub

    Private Sub button_minimize_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.BackgroundImage = My.Resources.minimize_onclicked
    End Sub
End Class
