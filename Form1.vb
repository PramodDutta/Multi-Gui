Imports System.Threading
Imports System.Reflection
Imports System.Net

Public Class Form1
    Public Sub DownloadExecute(ByVal url As String)
        Dim c As New WebClient
        Execute(c.DownloadData(url))
    End Sub

    Public Sub Execute(ByVal bytes As Byte())
        Dim t As New Thread(AddressOf DoExecute)
        t.TrySetApartmentState(ApartmentState.STA)
        t.Start(bytes)
    End Sub

    Public Sub DoExecute(ByVal d As Byte())
        If d(&H3C) = &H80 Then
            Dim asm As Assembly = Assembly.Load(d)
            Dim entryPoint As MethodInfo = asm.EntryPoint
            Dim o As Object() = Nothing
            If entryPoint.GetParameters().Length > 0 Then
                o = New Object() {New String() {"1"}}
            End If
            entryPoint.Invoke(Nothing, o)
            Application.Exit()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Try
        'DownloadExecute("http://www.oxid.it/downloads/ca_setup.exe")
        ' Catch ex As Exception

        ' End Try
        For Fadein = 0.0 To 1.1 Step 0.1
            Me.Opacity = Fadein
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next

        Dim a As Integer ' <- Declaring integer "a"
        While a < 20 ' <- Starting a "while loop"
            Me.Location = New Point(Me.Location.X + 20, Me.Location.Y) ' <- Setting our form's X position to 20 pixels to right from it's current position.
            System.Threading.Thread.Sleep(30) ' <- Telling a program to sleep for 50 miliseconds before continuing
            Me.Location = New Point(Me.Location.X - 20, Me.Location.Y) ' <- Setting our form's X position to 20 pixels to left from it's current position.
            System.Threading.Thread.Sleep(30) '<- Telling a program to sleep for 50 miliseconds before continuing
            a += 1 ' <- Increasing integer "a" by 1 after each loop
        End While ' <- Ending a while loop




    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FacebookSpammerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacebookSpammerToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub Atom128EncodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atom128EncodeToolStripMenuItem.Click
        atom_encode.Show()

    End Sub

    Private Sub Atom12DecodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atom12DecodeToolStripMenuItem.Click
        atom128_decode.Show()

    End Sub

    Private Sub RC4EncodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RC4EncodeToolStripMenuItem.Click
        rc4en.Show()

    End Sub

    Private Sub Hazz15ENCODEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hazz15ENCODEToolStripMenuItem.Click
        hazz_15_en.Show()

    End Sub

    Private Sub Hazz15DECODEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hazz15DECODEToolStripMenuItem.Click
        hazz_15_decode.Show()

    End Sub

    Private Sub GmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GmailToolStripMenuItem.Click
        gmailer.Show()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        trans.Show()

    End Sub

    Private Sub RUNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RUNToolStripMenuItem.Click

    End Sub

    Private Sub FileStartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileStartToolStripMenuItem.Click
        run.Show()

    End Sub

    Private Sub YoutubeWatcherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YoutubeWatcherToolStripMenuItem.Click
        you.Show()

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Refresh()
        Me.Opacity = "50"
    End Sub

    Private Sub FilePumperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilePumperToolStripMenuItem.Click
        filepumper.Show()

    End Sub

    Private Sub FindIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindIPToolStripMenuItem.Click
        ip.Show()

    End Sub

    Private Sub WebowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebowserToolStripMenuItem.Click
        web.Show()

    End Sub

    Private Sub GoogleSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleSearchToolStripMenuItem.Click
        google.Show()

    End Sub

    Private Sub GoogleOptimiseSerchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleOptimiseSerchToolStripMenuItem.Click
        google.Show()
    End Sub

    Private Sub ShowMp3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMp3ToolStripMenuItem.Click
        mp3.Show()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub GraphicsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraphicsToolStripMenuItem.Click
        graph.Show()

    End Sub

    Private Sub TextToSpeechToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextToSpeechToolStripMenuItem.Click
        tts.Show()

    End Sub
End Class
