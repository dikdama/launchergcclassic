'O launcher tem toda uma lógica simples, porém bem descrita de forma mais recursiva possivel.
'Foi projetado pra rodar em máquinas bem inferiores, com runtime .Net Framework 3.0 de base.
'A lógica de fazer o download de atualizações ainda não está descrita no código.
'Com isso, tambem a lógica de conexão coma database não se encontra.
'O esse programa é apenas um starter simples, e nostálgico do grand chase.
'Usei tempo de execução na máquina como pre-charger, assim o programa não pausa/para as threads, facilitando pra CPU ler com clareza e calma as instruções.'

'The launcher has a simple logic, but well described in the most recursive way possible.
'It was designed to run on much lesser machines, with a basic .NET Framework 3.0 runtime.
'The logic of downloading updates is not yet described in the code.
'With that, also the connection logic with the database is not found.
'This program is just a simple, nostalgic grand chase starter.
'I used runtime on the machine as a pre-charger, so the program doesn't pause / stop the threads, making it easier for the CPU to read the instructions clearly and calmly.'
'Any questions about something on the project, you can tell me.
Imports System.IO
Public Class Launcher
    Dim contador As Integer = 0
    Dim conta As Integer = 0
    Dim tempo As Integer = 0
    Dim readybora As Boolean = False
    Dim porcent As Integer = 0
    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
        Timer1.Start()
        timereal.Start()
        Progress_bar_archive1.Width = 10
        Progress_bar_total1.Width = 10
        Progress_bar_total1.porcentagem.Text = porcent & "%"
        Me.Button_entrar1.BackgroundImage = My.Resources.entrar_default
        If My.Computer.FileSystem.FileExists(".\\checkList.txt") Then
            filespatch.Text = "Baixando atualizações"
        Else
            filespatch.Text = "Criando árvore de arquivos"
            For Each foundFile As String In
                My.Computer.FileSystem.GetFiles(".\\")
                foundFile = foundFile & vbCrLf
                My.Computer.FileSystem.WriteAllText(".\\checkList.txt", foundFile, True)
            Next
        End If
        gogo()
    End Sub
    Private Function bora()
        If tempo = 3 And readybora = True Then
            filespatch.Text = "Atualização do Grand Chase concluída!"
            Progress_bar_archive1.Width = 481
            Progress_bar_total1.Width = 481
            porcent = 100
            Progress_bar_total1.porcentagem.Text = porcent & "%"
            Me.Button_entrar1.BackgroundImage = My.Resources.entrar_charged
        End If
    End Function
    Private Function slider()
        If contador < 5 Then
            Me.Carousel_slider1.BackgroundImage = My.Resources.slide1
            Me.Carousel_indicator11.BackgroundImage = My.Resources._1_selected
            Me.Carousel_indicator21.BackgroundImage = My.Resources._2
            Me.Carousel_indicator31.BackgroundImage = My.Resources._3
            Me.Carousel_indicator41.BackgroundImage = My.Resources._4
        End If
        If contador >= 5 And contador < 10 Then
            Me.Carousel_slider1.BackgroundImage = My.Resources.slide2
            Me.Carousel_indicator21.BackgroundImage = My.Resources._2_selected
            Me.Carousel_indicator11.BackgroundImage = My.Resources._1
            Me.Carousel_indicator31.BackgroundImage = My.Resources._3
            Me.Carousel_indicator41.BackgroundImage = My.Resources._4
        End If
        If contador >= 10 And contador < 15 Then
            Me.Carousel_slider1.BackgroundImage = My.Resources.slide3
            Me.Carousel_indicator31.BackgroundImage = My.Resources._3_selected
            Me.Carousel_indicator11.BackgroundImage = My.Resources._1
            Me.Carousel_indicator21.BackgroundImage = My.Resources._2
            Me.Carousel_indicator41.BackgroundImage = My.Resources._4
        End If
        If contador >= 15 And contador < 20 Then
            Me.Carousel_slider1.BackgroundImage = My.Resources.slide4
            Me.Carousel_indicator41.BackgroundImage = My.Resources._4_selected
            Me.Carousel_indicator11.BackgroundImage = My.Resources._1
            Me.Carousel_indicator21.BackgroundImage = My.Resources._2
            Me.Carousel_indicator31.BackgroundImage = My.Resources._3
        End If
    End Function

    Public Sub Carousel_indicator11_Click(sender As Object, e As EventArgs) Handles Carousel_indicator11.Click
        Me.Carousel_slider1.BackgroundImage = My.Resources.slide1
        Me.Carousel_indicator21.BackgroundImage = My.Resources._2
        Me.Carousel_indicator31.BackgroundImage = My.Resources._3
        Me.Carousel_indicator41.BackgroundImage = My.Resources._4
    End Sub

    Private Sub Carousel_indicator21_Click(sender As Object, e As EventArgs) Handles Carousel_indicator21.Click
        Me.Carousel_slider1.BackgroundImage = My.Resources.slide2
        Me.Carousel_indicator11.BackgroundImage = My.Resources._1
        Me.Carousel_indicator31.BackgroundImage = My.Resources._3
        Me.Carousel_indicator41.BackgroundImage = My.Resources._4
    End Sub

    Private Sub Carousel_indicator31_Click(sender As Object, e As EventArgs) Handles Carousel_indicator31.Click
        Me.Carousel_slider1.BackgroundImage = My.Resources.slide3
        Me.Carousel_indicator11.BackgroundImage = My.Resources._1
        Me.Carousel_indicator21.BackgroundImage = My.Resources._2
        Me.Carousel_indicator41.BackgroundImage = My.Resources._4
    End Sub

    Private Sub Carousel_indicator41_Click(sender As Object, e As EventArgs) Handles Carousel_indicator41.Click
        Me.Carousel_slider1.BackgroundImage = My.Resources.slide4
        Me.Carousel_indicator11.BackgroundImage = My.Resources._1
        Me.Carousel_indicator21.BackgroundImage = My.Resources._2
        Me.Carousel_indicator31.BackgroundImage = My.Resources._3
    End Sub

    Private Sub Button_minimize1_Click(sender As Object, e As EventArgs) Handles Button_minimize1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button_exit1_Click(sender As Object, e As EventArgs) Handles Button_exit1.Click
        Application.Exit()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador = contador + 1
        If contador.Equals(20) Then
            contador = 0
        End If
        slider()
    End Sub
    Private Sub timereal_Tick(sender As Object, e As EventArgs) Handles timereal.Tick
        tempo = tempo + 1
        bora()
    End Sub

    Private Sub Button_entrar1_Click(sender As Object, e As EventArgs) Handles Button_entrar1.Click
        If readybora.Equals(True) And tempo > 3 Then
            Me.Button_entrar1.BackgroundImage = My.Resources.entrar_onclicked
            Try
                System.Diagnostics.Process.Start(".\\Main.exe")
            Catch ex As Exception
                MsgBox("Arquivo não encontrado")
                Console.WriteLine(ex.Message)
            End Try
            Application.Exit()
        End If
    End Sub

    Private Sub Button_entrar1_MouseEnter(sender As Object, e As EventArgs) Handles Button_entrar1.MouseEnter
        If readybora.Equals(True) And tempo > 3 Then
            Me.Button_entrar1.BackgroundImage = My.Resources.entrar_onfocused
        End If
    End Sub

    Private Sub Button_entrar1_MouseLeave(sender As Object, e As EventArgs) Handles Button_entrar1.MouseLeave
        If readybora.Equals(True) And tempo > 3 Then
            Me.Button_entrar1.BackgroundImage = My.Resources.entrar_charged
        End If
    End Sub
    Private Function gogo()
        'Executando teste se os arquivos descritos na checklist.txt realmente existem no PATH
        'Running test if the files described in checklist.txt really exist in PATH
        Dim linhaTexto As String
        Try
            Dim texto As New StreamReader(".\\checklist.txt")
            Do While texto.Peek <> -1
                linhaTexto = texto.ReadLine
                If Not My.Computer.FileSystem.FileExists(linhaTexto) = True Then
                    conta = conta + 1
                End If
            Loop
            texto.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        If conta > 0 Then
            filespatch.Text = conta & " Arquivos não encontrados"
            readybora = False
        Else
            readybora = True
        End If
        Return readybora
    End Function
End Class