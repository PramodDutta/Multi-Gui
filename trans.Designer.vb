<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trans
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Translate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 41)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(615, 180)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 266)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(627, 180)
        Me.TextBox2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"hi (Hindi)", "fr (french)", "af (Afrikaans)", "sq (Albanian)", "am (Amharic)", "ar (Arabic)", "hy (Armenian)", "en (English)", "az (Azerbaijani)", "eu (Basque)", "be (Belarusian)", "bn (bengali)", "bh (Bihari)", "br (Breton)", "bg (Bulgarian)", "my (Burmese)", "ca (Catalan)", "chr (Cherokee)", "zh (chinese)", "zh-CN (Chinese_Simplified)", "zh-TW (Chinese_Traditional)", "co (Corsian)", "hr (Croatian)", "cs (CZech)", "da (Danish)", "dv (Dhivehi)", "nl (Dutch)", "en (English)", "eo (Esperanto)", "et (Estonian)", "fo (Faroese)", "tl (Filipino)", "fi (Finnish)", "fy (Frisian)", "gl (Galjcjan)", "ka (Georgian)", "de (German)", "el (Greek)", "gu (Gujarati)", "ht (Haitian_Creole)", "iw (hebrew)", "hu (hungarian)", "is (Icelandic)", "id (Indonesian)", "iu (Inuktitut)", "ga (Irish)", "it (Italian)", "ja (japanese)", "jw (Javanese)", "kn (Kannada)", "kk (Kazakh)", "km (khmer)", "ko (korean)", "ku (kurdish)", "ky (kyrgyz)", "lo (lao)", "la (latin)", "lv (latvian)", "lt (lithuanian)", "lb (luxembourgish)", "ml (macedonian)", "ms (malay)", "ml (malayalam)", "mt (maltese)", "mi (maori)", "mr (marathi)", "mn (mongolian)", "ne (Nepali)", "no (Norwegian)", "oc (Occitan)", "or (Oriya)", "ps (Pashto)", "fa (persian)", "pl (Polish)", "pt (portuguese)", "pa (punjabi)", "qu (Quechua)", "ro (romanian)", "ru (Russian)", "sa (Sanskrit)", "gd (Scots_Gaelic)", "sr (Serbian)", "sd (Sindhi)", "si (sinhalese)", "sk (Slovak)", "sl (Slovenian)", "es (spanish)", "su (Sundanese)", "sw (Swahili)", "sv (Swedish)", "syr (syriac)", "tg (Tajik)", "ta (Tamil)", "tt (Tatar)", "te (telugu)", "thai (th)", "bo (Tibetan)", "Tonga (to)", "tr (Turkish)", "uk (Ukrainian)", "ur (urdu)", "uz (uzbek)", "ug (uighur)", "vi (vietnamese)", "cy (Welsh)", "yi (Yiddish)", "yo (yoruba)"})
        Me.ComboBox1.Location = New System.Drawing.Point(498, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(395, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose Language"
        '
        'trans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 458)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "trans"
        Me.ShowIcon = False
        Me.Text = "ELITEH4XER TRANSLATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
