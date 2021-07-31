<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeuname
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
        Me.bpw = New System.Windows.Forms.Button()
        Me.buname = New System.Windows.Forms.Button()
        Me.tuname = New System.Windows.Forms.TextBox()
        Me.tpass = New System.Windows.Forms.TextBox()
        Me.luname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bpw
        '
        Me.bpw.Location = New System.Drawing.Point(454, 208)
        Me.bpw.Name = "bpw"
        Me.bpw.Size = New System.Drawing.Size(75, 26)
        Me.bpw.TabIndex = 15
        Me.bpw.Text = "Ok"
        Me.bpw.UseVisualStyleBackColor = True
        '
        'buname
        '
        Me.buname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buname.Location = New System.Drawing.Point(454, 398)
        Me.buname.Name = "buname"
        Me.buname.Size = New System.Drawing.Size(75, 31)
        Me.buname.TabIndex = 14
        Me.buname.Text = "change"
        Me.buname.UseVisualStyleBackColor = True
        Me.buname.Visible = False
        '
        'tuname
        '
        Me.tuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuname.Location = New System.Drawing.Point(291, 328)
        Me.tuname.Name = "tuname"
        Me.tuname.Size = New System.Drawing.Size(238, 31)
        Me.tuname.TabIndex = 12
        Me.tuname.Visible = False
        '
        'tpass
        '
        Me.tpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpass.Location = New System.Drawing.Point(291, 150)
        Me.tpass.Name = "tpass"
        Me.tpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tpass.Size = New System.Drawing.Size(238, 32)
        Me.tpass.TabIndex = 0
        '
        'luname
        '
        Me.luname.AutoSize = True
        Me.luname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.luname.Location = New System.Drawing.Point(29, 328)
        Me.luname.Name = "luname"
        Me.luname.Size = New System.Drawing.Size(188, 29)
        Me.luname.TabIndex = 9
        Me.luname.Text = "New username: "
        Me.luname.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(29, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter password: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(126, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 46)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Change Username"
        '
        'bexit
        '
        Me.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bexit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bexit.Location = New System.Drawing.Point(551, -3)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(54, 41)
        Me.bexit.TabIndex = 16
        Me.bexit.Text = "X"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'changeuname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(603, 471)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.bpw)
        Me.Controls.Add(Me.buname)
        Me.Controls.Add(Me.tuname)
        Me.Controls.Add(Me.tpass)
        Me.Controls.Add(Me.luname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "changeuname"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "change username"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bpw As System.Windows.Forms.Button
    Friend WithEvents buname As System.Windows.Forms.Button
    Friend WithEvents tuname As System.Windows.Forms.TextBox
    Friend WithEvents tpass As System.Windows.Forms.TextBox
    Friend WithEvents luname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bexit As System.Windows.Forms.Button
End Class
