Imports System.Net.Mail
Public Class gmailer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Mail As New MailMessage
        Mail.Subject = TextBox5.Text
        Mail.To.Add(TextBox2.Text)
        Mail.From = New MailAddress(TextBox4.Text)
        Mail.Body = TextBox6.Text
        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential(TextBox1.Text, TextBox3.Text)
        SMTP.Port = 587
        SMTP.Send(Mail)
        MsgBox("sent :)")
    End Sub
End Class