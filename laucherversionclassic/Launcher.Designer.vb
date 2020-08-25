<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.filespatch = New System.Windows.Forms.Label()
        Me.arquivo_label = New System.Windows.Forms.Label()
        Me.total_label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timereal = New System.Windows.Forms.Timer(Me.components)
        Me.site = New System.Windows.Forms.LinkLabel()
        Me.datafeed1 = New System.Windows.Forms.Label()
        Me.feed1 = New System.Windows.Forms.LinkLabel()
        Me.datafeed2 = New System.Windows.Forms.Label()
        Me.feed2 = New System.Windows.Forms.LinkLabel()
        Me.datafeed3 = New System.Windows.Forms.Label()
        Me.feed3 = New System.Windows.Forms.LinkLabel()
        Me.Progress_bar_total1 = New laucherversionclassic.progress_bar_total()
        Me.Progress_bar_archive1 = New laucherversionclassic.progress_bar_archive()
        Me.Carousel_slider1 = New laucherversionclassic.carousel_slider()
        Me.Button_entrar1 = New laucherversionclassic.button_entrar()
        Me.Carousel_indicator41 = New laucherversionclassic.carousel_indicator4()
        Me.Carousel_indicator31 = New laucherversionclassic.carousel_indicator3()
        Me.Carousel_indicator21 = New laucherversionclassic.carousel_indicator2()
        Me.Carousel_indicator11 = New laucherversionclassic.carousel_indicator1()
        Me.Button_minimize1 = New laucherversionclassic.button_minimize()
        Me.Button_exit1 = New laucherversionclassic.button_exit()
        Me.SuspendLayout()
        '
        'filespatch
        '
        Me.filespatch.AutoSize = True
        Me.filespatch.BackColor = System.Drawing.Color.Transparent
        Me.filespatch.ForeColor = System.Drawing.Color.White
        Me.filespatch.Location = New System.Drawing.Point(165, 613)
        Me.filespatch.Name = "filespatch"
        Me.filespatch.Size = New System.Drawing.Size(145, 13)
        Me.filespatch.TabIndex = 8
        Me.filespatch.Text = "model/model_abt_data3.kom"
        '
        'arquivo_label
        '
        Me.arquivo_label.AutoSize = True
        Me.arquivo_label.BackColor = System.Drawing.Color.Transparent
        Me.arquivo_label.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arquivo_label.ForeColor = System.Drawing.Color.Gold
        Me.arquivo_label.Location = New System.Drawing.Point(38, 634)
        Me.arquivo_label.Name = "arquivo_label"
        Me.arquivo_label.Size = New System.Drawing.Size(47, 15)
        Me.arquivo_label.TabIndex = 9
        Me.arquivo_label.Text = "Arquivo"
        '
        'total_label
        '
        Me.total_label.AutoSize = True
        Me.total_label.BackColor = System.Drawing.Color.Transparent
        Me.total_label.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_label.ForeColor = System.Drawing.Color.Gold
        Me.total_label.Location = New System.Drawing.Point(39, 659)
        Me.total_label.Name = "total_label"
        Me.total_label.Size = New System.Drawing.Size(33, 15)
        Me.total_label.TabIndex = 10
        Me.total_label.Text = "Total"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timereal
        '
        Me.timereal.Interval = 1000
        '
        'site
        '
        Me.site.ActiveLinkColor = System.Drawing.Color.White
        Me.site.AutoSize = True
        Me.site.BackColor = System.Drawing.Color.Transparent
        Me.site.LinkColor = System.Drawing.Color.Red
        Me.site.Location = New System.Drawing.Point(648, 516)
        Me.site.Name = "site"
        Me.site.Size = New System.Drawing.Size(52, 13)
        Me.site.TabIndex = 20
        Me.site.TabStop = True
        Me.site.Text = "Ver todas"
        '
        'datafeed1
        '
        Me.datafeed1.AutoSize = True
        Me.datafeed1.BackColor = System.Drawing.Color.Transparent
        Me.datafeed1.ForeColor = System.Drawing.Color.OrangeRed
        Me.datafeed1.Location = New System.Drawing.Point(469, 357)
        Me.datafeed1.Name = "datafeed1"
        Me.datafeed1.Size = New System.Drawing.Size(65, 13)
        Me.datafeed1.TabIndex = 21
        Me.datafeed1.Text = "24/04/2020"
        '
        'feed1
        '
        Me.feed1.ActiveLinkColor = System.Drawing.Color.Red
        Me.feed1.AutoSize = True
        Me.feed1.BackColor = System.Drawing.Color.Transparent
        Me.feed1.LinkColor = System.Drawing.Color.White
        Me.feed1.Location = New System.Drawing.Point(469, 377)
        Me.feed1.Name = "feed1"
        Me.feed1.Size = New System.Drawing.Size(149, 13)
        Me.feed1.TabIndex = 22
        Me.feed1.TabStop = True
        Me.feed1.Text = "Hotfixes e Bugs improvements"
        '
        'datafeed2
        '
        Me.datafeed2.AutoSize = True
        Me.datafeed2.BackColor = System.Drawing.Color.Transparent
        Me.datafeed2.ForeColor = System.Drawing.Color.OrangeRed
        Me.datafeed2.Location = New System.Drawing.Point(469, 412)
        Me.datafeed2.Name = "datafeed2"
        Me.datafeed2.Size = New System.Drawing.Size(65, 13)
        Me.datafeed2.TabIndex = 23
        Me.datafeed2.Text = "24/04/2020"
        '
        'feed2
        '
        Me.feed2.ActiveLinkColor = System.Drawing.Color.Red
        Me.feed2.AutoSize = True
        Me.feed2.BackColor = System.Drawing.Color.Transparent
        Me.feed2.LinkColor = System.Drawing.Color.White
        Me.feed2.Location = New System.Drawing.Point(467, 432)
        Me.feed2.Name = "feed2"
        Me.feed2.Size = New System.Drawing.Size(165, 13)
        Me.feed2.TabIndex = 24
        Me.feed2.TabStop = True
        Me.feed2.Text = "Pacotes limitados na loja de Cash"
        '
        'datafeed3
        '
        Me.datafeed3.AutoSize = True
        Me.datafeed3.BackColor = System.Drawing.Color.Transparent
        Me.datafeed3.ForeColor = System.Drawing.Color.OrangeRed
        Me.datafeed3.Location = New System.Drawing.Point(469, 471)
        Me.datafeed3.Name = "datafeed3"
        Me.datafeed3.Size = New System.Drawing.Size(65, 13)
        Me.datafeed3.TabIndex = 25
        Me.datafeed3.Text = "24/04/2020"
        '
        'feed3
        '
        Me.feed3.ActiveLinkColor = System.Drawing.Color.Red
        Me.feed3.AutoSize = True
        Me.feed3.BackColor = System.Drawing.Color.Transparent
        Me.feed3.LinkColor = System.Drawing.Color.White
        Me.feed3.Location = New System.Drawing.Point(469, 492)
        Me.feed3.Name = "feed3"
        Me.feed3.Size = New System.Drawing.Size(142, 13)
        Me.feed3.TabIndex = 26
        Me.feed3.TabStop = True
        Me.feed3.Text = "Distribuição de Token de Vp"
        '
        'Progress_bar_total1
        '
        Me.Progress_bar_total1.BackColor = System.Drawing.Color.Transparent
        Me.Progress_bar_total1.BackgroundImage = CType(resources.GetObject("Progress_bar_total1.BackgroundImage"), System.Drawing.Image)
        Me.Progress_bar_total1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Progress_bar_total1.Location = New System.Drawing.Point(91, 655)
        Me.Progress_bar_total1.Name = "Progress_bar_total1"
        Me.Progress_bar_total1.Size = New System.Drawing.Size(481, 23)
        Me.Progress_bar_total1.TabIndex = 19
        '
        'Progress_bar_archive1
        '
        Me.Progress_bar_archive1.BackColor = System.Drawing.Color.Transparent
        Me.Progress_bar_archive1.BackgroundImage = CType(resources.GetObject("Progress_bar_archive1.BackgroundImage"), System.Drawing.Image)
        Me.Progress_bar_archive1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Progress_bar_archive1.Location = New System.Drawing.Point(91, 639)
        Me.Progress_bar_archive1.Name = "Progress_bar_archive1"
        Me.Progress_bar_archive1.Size = New System.Drawing.Size(481, 9)
        Me.Progress_bar_archive1.TabIndex = 18
        '
        'Carousel_slider1
        '
        Me.Carousel_slider1.BackColor = System.Drawing.Color.Transparent
        Me.Carousel_slider1.BackgroundImage = CType(resources.GetObject("Carousel_slider1.BackgroundImage"), System.Drawing.Image)
        Me.Carousel_slider1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Carousel_slider1.Location = New System.Drawing.Point(22, 209)
        Me.Carousel_slider1.Name = "Carousel_slider1"
        Me.Carousel_slider1.Size = New System.Drawing.Size(431, 375)
        Me.Carousel_slider1.TabIndex = 7
        '
        'Button_entrar1
        '
        Me.Button_entrar1.BackColor = System.Drawing.Color.Transparent
        Me.Button_entrar1.BackgroundImage = CType(resources.GetObject("Button_entrar1.BackgroundImage"), System.Drawing.Image)
        Me.Button_entrar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_entrar1.Location = New System.Drawing.Point(594, 598)
        Me.Button_entrar1.Name = "Button_entrar1"
        Me.Button_entrar1.Size = New System.Drawing.Size(133, 95)
        Me.Button_entrar1.TabIndex = 6
        '
        'Carousel_indicator41
        '
        Me.Carousel_indicator41.BackColor = System.Drawing.Color.Transparent
        Me.Carousel_indicator41.BackgroundImage = CType(resources.GetObject("Carousel_indicator41.BackgroundImage"), System.Drawing.Image)
        Me.Carousel_indicator41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Carousel_indicator41.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Carousel_indicator41.Location = New System.Drawing.Point(633, 268)
        Me.Carousel_indicator41.Name = "Carousel_indicator41"
        Me.Carousel_indicator41.Size = New System.Drawing.Size(32, 22)
        Me.Carousel_indicator41.TabIndex = 5
        '
        'Carousel_indicator31
        '
        Me.Carousel_indicator31.BackColor = System.Drawing.Color.Transparent
        Me.Carousel_indicator31.BackgroundImage = CType(resources.GetObject("Carousel_indicator31.BackgroundImage"), System.Drawing.Image)
        Me.Carousel_indicator31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Carousel_indicator31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Carousel_indicator31.Location = New System.Drawing.Point(588, 268)
        Me.Carousel_indicator31.Name = "Carousel_indicator31"
        Me.Carousel_indicator31.Size = New System.Drawing.Size(26, 22)
        Me.Carousel_indicator31.TabIndex = 4
        '
        'Carousel_indicator21
        '
        Me.Carousel_indicator21.BackColor = System.Drawing.Color.Transparent
        Me.Carousel_indicator21.BackgroundImage = CType(resources.GetObject("Carousel_indicator21.BackgroundImage"), System.Drawing.Image)
        Me.Carousel_indicator21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Carousel_indicator21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Carousel_indicator21.Location = New System.Drawing.Point(540, 268)
        Me.Carousel_indicator21.Name = "Carousel_indicator21"
        Me.Carousel_indicator21.Size = New System.Drawing.Size(28, 22)
        Me.Carousel_indicator21.TabIndex = 3
        '
        'Carousel_indicator11
        '
        Me.Carousel_indicator11.BackColor = System.Drawing.Color.Transparent
        Me.Carousel_indicator11.BackgroundImage = CType(resources.GetObject("Carousel_indicator11.BackgroundImage"), System.Drawing.Image)
        Me.Carousel_indicator11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Carousel_indicator11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Carousel_indicator11.Location = New System.Drawing.Point(504, 268)
        Me.Carousel_indicator11.Name = "Carousel_indicator11"
        Me.Carousel_indicator11.Size = New System.Drawing.Size(16, 22)
        Me.Carousel_indicator11.TabIndex = 2
        '
        'Button_minimize1
        '
        Me.Button_minimize1.BackColor = System.Drawing.Color.Transparent
        Me.Button_minimize1.BackgroundImage = CType(resources.GetObject("Button_minimize1.BackgroundImage"), System.Drawing.Image)
        Me.Button_minimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_minimize1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_minimize1.Location = New System.Drawing.Point(618, 15)
        Me.Button_minimize1.Name = "Button_minimize1"
        Me.Button_minimize1.Size = New System.Drawing.Size(53, 32)
        Me.Button_minimize1.TabIndex = 1
        '
        'Button_exit1
        '
        Me.Button_exit1.BackColor = System.Drawing.Color.Transparent
        Me.Button_exit1.BackgroundImage = CType(resources.GetObject("Button_exit1.BackgroundImage"), System.Drawing.Image)
        Me.Button_exit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button_exit1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_exit1.ForeColor = System.Drawing.Color.Transparent
        Me.Button_exit1.Location = New System.Drawing.Point(691, 12)
        Me.Button_exit1.Name = "Button_exit1"
        Me.Button_exit1.Size = New System.Drawing.Size(37, 39)
        Me.Button_exit1.TabIndex = 0
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = Global.laucherversionclassic.My.Resources.Resources.launcherv2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(740, 700)
        Me.Controls.Add(Me.feed3)
        Me.Controls.Add(Me.datafeed3)
        Me.Controls.Add(Me.feed2)
        Me.Controls.Add(Me.datafeed2)
        Me.Controls.Add(Me.feed1)
        Me.Controls.Add(Me.datafeed1)
        Me.Controls.Add(Me.site)
        Me.Controls.Add(Me.Progress_bar_total1)
        Me.Controls.Add(Me.Progress_bar_archive1)
        Me.Controls.Add(Me.total_label)
        Me.Controls.Add(Me.arquivo_label)
        Me.Controls.Add(Me.filespatch)
        Me.Controls.Add(Me.Carousel_slider1)
        Me.Controls.Add(Me.Button_entrar1)
        Me.Controls.Add(Me.Carousel_indicator41)
        Me.Controls.Add(Me.Carousel_indicator31)
        Me.Controls.Add(Me.Carousel_indicator21)
        Me.Controls.Add(Me.Carousel_indicator11)
        Me.Controls.Add(Me.Button_minimize1)
        Me.Controls.Add(Me.Button_exit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = false
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Button_exit1 As laucherversionclassic.button_exit
    Friend WithEvents Button_minimize1 As laucherversionclassic.button_minimize
    Friend WithEvents Carousel_indicator11 As laucherversionclassic.carousel_indicator1
    Friend WithEvents Carousel_indicator21 As laucherversionclassic.carousel_indicator2
    Friend WithEvents Carousel_indicator31 As laucherversionclassic.carousel_indicator3
    Friend WithEvents Carousel_indicator41 As laucherversionclassic.carousel_indicator4
    Friend WithEvents Button_entrar1 As laucherversionclassic.button_entrar
    Friend WithEvents Carousel_slider1 As laucherversionclassic.carousel_slider
    Friend WithEvents filespatch As System.Windows.Forms.Label
    Friend WithEvents arquivo_label As System.Windows.Forms.Label
    Friend WithEvents total_label As System.Windows.Forms.Label
    Friend WithEvents Progress_bar_archive1 As laucherversionclassic.progress_bar_archive
    Friend WithEvents Progress_bar_total1 As laucherversionclassic.progress_bar_total
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents timereal As System.Windows.Forms.Timer
    Friend WithEvents site As System.Windows.Forms.LinkLabel
    Friend WithEvents datafeed1 As System.Windows.Forms.Label
    Friend WithEvents feed1 As System.Windows.Forms.LinkLabel
    Friend WithEvents datafeed2 As System.Windows.Forms.Label
    Friend WithEvents feed2 As System.Windows.Forms.LinkLabel
    Friend WithEvents datafeed3 As System.Windows.Forms.Label
    Friend WithEvents feed3 As System.Windows.Forms.LinkLabel
End Class
