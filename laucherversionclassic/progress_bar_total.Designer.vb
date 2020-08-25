<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class progress_bar_total
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.porcentagem = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'porcentagem
        '
        Me.porcentagem.AutoSize = True
        Me.porcentagem.BackColor = System.Drawing.Color.Transparent
        Me.porcentagem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.porcentagem.ForeColor = System.Drawing.Color.Gold
        Me.porcentagem.Location = New System.Drawing.Point(224, 4)
        Me.porcentagem.Name = "porcentagem"
        Me.porcentagem.Size = New System.Drawing.Size(39, 15)
        Me.porcentagem.TabIndex = 11
        Me.porcentagem.Text = "100%"
        '
        'progress_bar_total
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.laucherversionclassic.My.Resources.Resources.progressbar_total
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.porcentagem)
        Me.DoubleBuffered = True
        Me.Name = "progress_bar_total"
        Me.Size = New System.Drawing.Size(481, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents porcentagem As System.Windows.Forms.Label

End Class
