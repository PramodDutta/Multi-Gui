Public Class web

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(ComboBox1.SelectedItem)

    End Sub

    Private Sub GoForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub GoBackwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBackwardToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        WebBrowser1.Refresh()


    End Sub

    Private Sub GoSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoSearchToolStripMenuItem.Click
        WebBrowser1.GoSearch()
    End Sub

    Private Sub GoogleDorkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleDorkToolStripMenuItem.Click

    End Sub
End Class