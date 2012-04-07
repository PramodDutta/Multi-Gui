Imports System.Drawing.Text
Imports System.Drawing.Drawing2D

Public Class graph

    Private Sub graph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub graph_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Using p As New Drawing2D.GraphicsPath
            p.AddString("*** eliteh4xer made grapichs***", New FontFamily("Times New Roman"), CInt(FontStyle.Bold), 80, New Point(10, 10), StringFormat.GenericTypographic)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.FillPath(Brushes.White, p)
            Using thick_pen As New Pen(Color.Black, 3)
                e.Graphics.DrawPath(thick_pen, p)
                e.Graphics.FillPath(Brushes.Thistle, p)



            End Using
        End Using

        '  Using the_font As New Font(Me.Font.FontFamily, 40, FontStyle.Bold, GraphicsUnit.Pixel)
        '' Draw without anti - aliasing.
        ' e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
        ' e.Graphics.DrawString("eliteh4xer", the_font, Brushes.Black, 5, 5)
        ' e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel
        ' e.Graphics.DrawString("eliteh4xer in bad format", the_font, Brushes.Black, 5, 50)




        ' End Using
    End Sub
End Class