﻿Public Class filepumper

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Exe Files|*.exe"
        ofd.ShowDialog()
        TextBox1.Text = ofd.FileName
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Value += 100

        Dim sfd As New SaveFileDialog
        sfd.Filter = "Exe Files|*.exe"
        sfd.ShowDialog()
        Dim filesize As Double = Val(NumericUpDown1.Value)
        IO.File.Copy(TextBox1.Text, sfd.FileName)
        If RadioButton1.Checked Then
            filesize = filesize * 1024
        End If
        If RadioButton2.Checked Then
            filesize = filesize * 1048576
        End If
    End Sub
End Class