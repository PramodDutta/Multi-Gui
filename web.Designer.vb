<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class web
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GoForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoBackwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleDorkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(873, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(24, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "URL"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoForwardToolStripMenuItem, Me.GoBackwardToolStripMenuItem, Me.RefreshToolStripMenuItem1, Me.GoSearchToolStripMenuItem, Me.GoogleDorkToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(977, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GoForwardToolStripMenuItem
        '
        Me.GoForwardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem})
        Me.GoForwardToolStripMenuItem.Name = "GoForwardToolStripMenuItem"
        Me.GoForwardToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.GoForwardToolStripMenuItem.Text = "GoForward"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'GoBackwardToolStripMenuItem
        '
        Me.GoBackwardToolStripMenuItem.Name = "GoBackwardToolStripMenuItem"
        Me.GoBackwardToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.GoBackwardToolStripMenuItem.Text = "GoBackward"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'GoSearchToolStripMenuItem
        '
        Me.GoSearchToolStripMenuItem.Name = "GoSearchToolStripMenuItem"
        Me.GoSearchToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.GoSearchToolStripMenuItem.Text = "GoSearch"
        '
        'GoogleDorkToolStripMenuItem
        '
        Me.GoogleDorkToolStripMenuItem.Name = "GoogleDorkToolStripMenuItem"
        Me.GoogleDorkToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.GoogleDorkToolStripMenuItem.Text = "Google Dork"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 78)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(953, 445)
        Me.WebBrowser1.TabIndex = 6
        Me.WebBrowser1.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"http://www.google.com", "http://www.facebook.com", "http://www.bing.com", "http://www.yahoo.com", "http://www.hackforums.net", "http://www.indishell.in", "http://www.gmail.com", "http://www.lmgfy.com", "http://www.ipu.ac.in"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(781, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'web
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(977, 535)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "web"
        Me.ShowIcon = False
        Me.Text = "Web_browser eliteh4xer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GoForwardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents GoBackwardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoogleDorkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
