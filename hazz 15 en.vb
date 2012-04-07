﻿Public Class hazz_15_en
    Public Function HAZZ15_Encode(ByVal input As String) As String
        input = Uri.EscapeDataString(input)
        Dim key As String = "HNO4klm6ij9n+J2hyf0gzA8uvwDEq3X1Q7ZKeFrWcVTts/MRGYbdxSo=ILaUpPBC5"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs As Integer() = {0, 0, 0}
            For b As Integer = 0 To 2
                If i < input.Length Then chrs(b) = Asc(input(i))
                i += 1
            Next
            enc(0) = chrs(0) >> 2
            enc(1) = ((chrs(0) And 3) << 4) Or (chrs(1) >> 4)
            enc(2) = ((chrs(1) And 15) << 2) Or (chrs(2) >> 6)
            enc(3) = chrs(2) And 63
            If chrs(1) = 0 Then
                enc(2) = 64
                enc(3) = 64
            End If
            If chrs(2) = 0 Then
                enc(3) = 64
            End If
            For Each x As Integer In enc
                out.Append(key(x))
            Next
        Loop While i < input.Length
        Return out.ToString
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Value += 1
        TextBox1.Text = HAZZ15_Encode(TextBox1.Text)

    End Sub
End Class