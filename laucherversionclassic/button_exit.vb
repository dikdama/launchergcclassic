Public Class button_exit

    Private Sub button_exit_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BackgroundImage = My.Resources.exit_onfocused
    End Sub

    Private Sub button_exit_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackgroundImage = My.Resources._exit
    End Sub

    Private Sub button_exit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources._exit
    End Sub

    Private Sub button_exit_Click(sender As Object, e As MouseEventArgs) Handles MyBase.Click
        Me.BackgroundImage = My.Resources.exit_onclicked
    End Sub
End Class
