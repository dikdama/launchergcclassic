Public Class Gc_start
    Dim tempoinit As Integer = 0
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
        Timer1.Start()
    End Sub
    Private Function golauncher()
        If tempoinit > 5 And My.Computer.Network.IsAvailable Then
            My.Forms.Launcher.Show()
            Hide()
        ElseIf My.Computer.Network.IsAvailable.Equals(False) Then
            Application.Exit()
        End If
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempoinit = tempoinit + 1
        golauncher()
    End Sub
End Class
