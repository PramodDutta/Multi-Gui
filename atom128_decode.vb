Public Class atom128_decode
    Public Function Atom128_Decode(ByVal input As String) As String
        Dim key As String = "/128GhIoPQROSTeUbADfgHijKLM+n0pFWXY456xyzB7=39VaqrstJklmNuZvwcdEC"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs() As Integer = {0, 0, 0}
            For b As Integer = 0 To 3
                enc(b) = key.IndexOf(input(i))
                i = i + 1
            Next
            chrs(0) = (enc(0) << 2) Or (enc(1) >> 4)
            chrs(1) = (enc(1) And 15) << 4 Or (enc(2) >> 2)
            chrs(2) = (enc(2) And 3) << 6 Or enc(3)
            out.Append(Chr(chrs(0)))
            If enc(2) <> 64 Then out.Append(Chr(chrs(1)))
            If enc(3) <> 64 Then out.Append(Chr(chrs(2)))
        Loop While i < input.Length
        Return out.ToString
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Atom128_Decode(TextBox1.Text)

    End Sub
End Class