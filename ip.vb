Imports System.Net
Public Class ip

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text.Contains("http://") Then
                Dim iphe As IPHostEntry = Dns.GetHostEntry(TextBox1.Text.Replace("http://", String.Empty))
                TextBox2.Text = iphe.AddressList(0).ToString()
            Else
                Dim iphe As IPHostEntry = Dns.GetHostEntry(TextBox1.Text)
                TextBox2.Text = iphe.AddressList(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class