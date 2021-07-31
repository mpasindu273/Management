<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminmainframe
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
        Me.tim = New System.Windows.Forms.Timer(Me.components)
        Me.blogout = New System.Windows.Forms.Button()
        Me.blecturer = New System.Windows.Forms.Button()
        Me.bpassword = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lm = New System.Windows.Forms.Label()
        Me.bstudent = New System.Windows.Forms.Button()
        Me.ldate = New System.Windows.Forms.Label()
        Me.ls = New System.Windows.Forms.Label()
        Me.lh = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bschedule = New System.Windows.Forms.Button()
        Me.bnotice = New System.Windows.Forms.Button()
        Me.lwelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tim
        '
        Me.tim.Enabled = True
        Me.tim.Interval = 1000
        '
        'blogout
        '
        Me.blogout.BackColor = System.Drawing.Color.Black
        Me.blogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.blogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.blogout.ForeColor = System.Drawing.Color.White
        Me.blogout.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.blogout.Location = New System.Drawing.Point(692, 0)
        Me.blogout.Name = "blogout"
        Me.blogout.Size = New System.Drawing.Size(94, 70)
        Me.blogout.TabIndex = 64
        Me.blogout.Text = "Logout"
        Me.blogout.UseVisualStyleBackColor = False
        '
        'blecturer
        '
        Me.blecturer.BackColor = System.Drawing.Color.Black
        Me.blecturer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.blecturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.blecturer.ForeColor = System.Drawing.Color.White
        Me.blecturer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.blecturer.Location = New System.Drawing.Point(439, 196)
        Me.blecturer.Name = "blecturer"
        Me.blecturer.Size = New System.Drawing.Size(154, 64)
        Me.blecturer.TabIndex = 65
        Me.blecturer.Text = "Edit lecturers"
        Me.blecturer.UseVisualStyleBackColor = False
        '
        'bpassword
        '
        Me.bpassword.BackColor = System.Drawing.Color.Black
        Me.bpassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.bpassword.ForeColor = System.Drawing.Color.White
        Me.bpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bpassword.Location = New System.Drawing.Point(100, 356)
        Me.bpassword.Name = "bpassword"
        Me.bpassword.Size = New System.Drawing.Size(154, 59)
        Me.bpassword.TabIndex = 62
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
        Me.Label5.Location = New System.Drawing.Point(283, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 31)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = ":"
        '
        'lm
        '
        Me.lm.AutoSize = True
        Me.lm.BackColor = System.Drawing.Color.Transparent
        Me.lm.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lm.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lm.Location = New System.Drawing.Point(189, 155)
        Me.lm.Name = "lm"
        Me.lm.Size = New System.Drawing.Size(106, 73)
        Me.lm.TabIndex = 58
        Me.lm.Text = "10"
        '
        'bstudent
        '
        Me.bstudent.BackColor = System.Drawing.Color.Black
        Me.bstudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.bstudent.ForeColor = System.Drawing.Color.White
        Me.bstudent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bstudent.Location = New System.Drawing.Point(439, 107)
        Me.bstudent.Name = "bstudent"
        Me.bstudent.Size = New System.Drawing.Size(154, 64)
        Me.bstudent.TabIndex = 61
        Me.bstudent.Text = "Edit students"
        Me.bstudent.UseVisualStyleBackColor = False
        '
        'ldate
        '
        Me.ldate.BackColor = System.Drawing.Color.Transparent
        Me.ldate.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold)
        Me.ldate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ldate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ldate.Location = New System.Drawing.Point(95, 247)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(211, 45)
        Me.ldate.TabIndex = 63
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
        Me.ls.Location = New System.Drawing.Point(300, 187)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(49, 33)
        Me.ls.TabIndex = 57
        Me.ls.Text = "10"
        '
        'lh
        '
        Me.lh.AutoSize = True
        Me.lh.BackColor = System.Drawing.Color.Transparent
        Me.lh.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lh.Location = New System.Drawing.Point(74, 155)
        Me.lh.Name = "lh"
        Me.lh.Size = New System.Drawing.Size(106, 73)
        Me.lh.TabIndex = 56
        Me.lh.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(161, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 73)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = ":"
        '
        'bschedule
        '
        Me.bschedule.BackColor = System.Drawing.Color.Black
        Me.bschedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.bschedule.ForeColor = System.Drawing.Color.White
        Me.bschedule.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bschedule.Location = New System.Drawing.Point(439, 373)
        Me.bschedule.Name = "bschedule"
        Me.bschedule.Size = New System.Drawing.Size(154, 62)
        Me.bschedule.TabIndex = 66
        Me.bschedule.Text = "Edit course schedule"
        Me.bschedule.UseVisualStyleBackColor = False
        '
        'bnotice
        '
        Me.bnotice.BackColor = System.Drawing.Color.Black
        Me.bnotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bnotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.bnotice.ForeColor = System.Drawing.Color.White
        Me.bnotice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bnotice.Location = New System.Drawing.Point(439, 286)
        Me.bnotice.Name = "bnotice"
        Me.bnotice.Size = New System.Drawing.Size(154, 64)
        Me.bnotice.TabIndex = 67
        Me.bnotice.Text = "Add Notice"
        Me.bnotice.UseVisualStyleBackColor = False
        '
        'lwelcome
        '
        Me.lwelcome.AutoSize = True
        Me.lwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lwelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lwelcome.Location = New System.Drawing.Point(23, 34)
        Me.lwelcome.Name = "lwelcome"
        Me.lwelcome.Size = New System.Drawing.Size(352, 36)
        Me.lwelcome.TabIndex = 68
        Me.lwelcome.Text = "Signed in as adminstrator"
        '
        'adminmainframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(784, 501)
        Me.Controls.Add(Me.blogout)
        Me.Controls.Add(Me.blecturer)
        Me.Controls.Add(Me.bpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lm)
        Me.Controls.Add(Me.bstudent)
        Me.Controls.Add(Me.ldate)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.lh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bschedule)
        Me.Controls.Add(Me.bnotice)
        Me.Controls.Add(Me.lwelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminmainframe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminmainframe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tim As System.Windows.Forms.Timer
    Friend WithEvents blogout As System.Windows.Forms.Button
    Friend WithEvents blecturer As System.Windows.Forms.Button
    Friend WithEvents bpassword As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lm As System.Windows.Forms.Label
    Friend WithEvents bstudent As System.Windows.Forms.Button
    Friend WithEvents ldate As System.Windows.Forms.Label
    Friend WithEvents ls As System.Windows.Forms.Label
    Friend WithEvents lh As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bschedule As System.Windows.Forms.Button
    Friend WithEvents bnotice As System.Windows.Forms.Button
    Friend WithEvents lwelcome As System.Windows.Forms.Label
End Class
