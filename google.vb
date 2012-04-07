Public Class google

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("http://www.google.com/search?q=inurl:" & ComboBox1.SelectedItem)
    End Sub
End Class