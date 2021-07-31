<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stumainframe
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
        Me.components = New System.ComponentModel.Container()
        Me.blogout = New System.Windows.Forms.Button()
        Me.bschedule = New System.Windows.Forms.Button()
        Me.bpassword = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lm = New System.Windows.Forms.Label()
        Me.ldate = New System.Windows.Forms.Label()
        Me.ls = New System.Windows.Forms.Label()
        Me.lh = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tim = New System.Windows.Forms.Timer(Me.components)
        Me.lwelcome = New System.Windows.Forms.Label()
        Me.bnotice = New System.Windows.Forms.Button()
        Me.bresults = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'blogout
        '
        Me.blogout.BackColor = System.Drawing.Color.Black
        Me.blogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.blogout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.blogout.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.blogout.Location = New System.Drawing.Point(693, -3)
        Me.blogout.Name = "blogout"
        Me.blogout.Size = New System.Drawing.Size(94, 70)
        Me.blogout.TabIndex = 18
        Me.blogout.Text = "Logout"
        Me.blogout.UseVisualStyleBackColor = False
        '
        'bschedule
        '
        Me.bschedule.BackColor = System.Drawing.Color.Black
        Me.bschedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.bschedule.ForeColor = System.Drawing.Color.Transparent
        Me.bschedule.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bschedule.Location = New System.Drawing.Point(464, 182)
        Me.bschedule.Name = "bschedule"
        Me.bschedule.Size = New System.Drawing.Size(151, 70)
        Me.bschedule.TabIndex = 19
        Me.bschedule.Text = "View Schedule"
        Me.bschedule.UseVisualStyleBackColor = False
        '
        'bpassword
        '
        Me.bpassword.BackColor = System.Drawing.Color.Black
        Me.bpassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.bpassword.ForeColor = System.Drawing.Color.Transparent
        Me.bpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bpassword.Location = New System.Drawing.Point(464, 394)
        Me.bpassword.Name = "bpassword"
        Me.bpassword.Size = New System.Drawing.Size(155, 64)
        Me.bpassword.TabIndex = 16
        Me.bpassword.Text = "Change Password"
        Me.bpassword.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(263, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 31)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = ":"
        '
        'lm
        '
        Me.lm.AutoSize = True
        Me.lm.BackColor = System.Drawing.Color.Transparent
        Me.lm.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lm.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lm.Location = New System.Drawing.Point(169, 229)
        Me.lm.Name = "lm"
        Me.lm.Size = New System.Drawing.Size(106, 73)
        Me.lm.TabIndex = 12
        Me.lm.Text = "10"
        '
        'ldate
        '
        Me.ldate.BackColor = System.Drawing.Color.Transparent
        Me.ldate.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold)
        Me.ldate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ldate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ldate.Location = New System.Drawing.Point(75, 321)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(211, 45)
        Me.ldate.TabIndex = 17
        Me.ldate.Text = "30/11/2020"
        Me.ldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ls
        '
        Me.ls.AutoSize = True
        Me.ls.BackColor = System.Drawing.Color.Transparent
        Me.ls.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.ls.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ls.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ls.Location = New System.Drawing.Point(280, 261)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(49, 33)
        Me.ls.TabIndex = 11
        Me.ls.Text = "10"
        '
        'lh
        '
        Me.lh.AutoSize = True
        Me.lh.BackColor = System.Drawing.Color.Transparent
        Me.lh.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lh.Location = New System.Drawing.Point(54, 229)
        Me.lh.Name = "lh"
        Me.lh.Size = New System.Drawing.Size(106, 73)
        Me.lh.TabIndex = 10
        Me.lh.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(141, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 73)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = ":"
        '
        'tim
        '
        Me.tim.Enabled = True
        Me.tim.Interval = 1000
        '
        'lwelcome
        '
        Me.lwelcome.AutoSize = True
        Me.lwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lwelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lwelcome.Location = New System.Drawing.Point(12, 30)
        Me.lwelcome.Name = "lwelcome"
        Me.lwelcome.Size = New System.Drawing.Size(0, 37)
        Me.lwelcome.TabIndex = 20
        '
        'bnotice
        '
        Me.bnotice.BackColor = System.Drawing.Color.Black
        Me.bnotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bnotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.bnotice.ForeColor = System.Drawing.Color.Transparent
        Me.bnotice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bnotice.Location = New System.Drawing.Point(464, 287)
        Me.bnotice.Name = "bnotice"
        Me.bnotice.Size = New System.Drawing.Size(151, 70)
        Me.bnotice.TabIndex = 15
        Me.bnotice.Text = "View Notices"
        Me.bnotice.UseVisualStyleBackColor = False
        '
        'bresults
        '
        Me.bresults.BackColor = System.Drawing.Color.Black
        Me.bresults.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bresults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bresults.ForeColor = System.Drawing.Color.Transparent
        Me.bresults.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bresults.Location = New System.Drawing.Point(464, 80)
        Me.bresults.Name = "bresults"
        Me.bresults.Size = New System.Drawing.Size(151, 70)
        Me.bresults.TabIndex = 19
        Me.bresults.Text = "View Assignment Marks"
        Me.bresults.UseVisualStyleBackColor = False
        '
        'stumainframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(784, 501)
        Me.Controls.Add(Me.lwelcome)
        Me.Controls.Add(Me.blogout)
        Me.Controls.Add(Me.bresults)
        Me.Controls.Add(Me.bschedule)
        Me.Controls.Add(Me.bpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lm)
        Me.Controls.Add(Me.bnotice)
        Me.Controls.Add(Me.ldate)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.lh)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stumainframe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stumainframe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents blogout As System.Windows.Forms.Button
    Friend WithEvents bschedule As System.Windows.Forms.Button
    Friend WithEvents bpassword As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lm As System.Windows.Forms.Label
    Friend WithEvents ldate As System.Windows.Forms.Label
    Friend WithEvents ls As System.Windows.Forms.Label
    Friend WithEvents lh As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tim As System.Windows.Forms.Timer
    Friend WithEvents lwelcome As System.Windows.Forms.Label
    Friend WithEvents bnotice As System.Windows.Forms.Button
    Friend WithEvents bresults As System.Windows.Forms.Button
End Class
