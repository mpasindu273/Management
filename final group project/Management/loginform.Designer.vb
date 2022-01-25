<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Me.bback = New System.Windows.Forms.Button()
        Me.logbtn = New System.Windows.Forms.Button()
        Me.clrbtn = New System.Windows.Forms.Button()
        Me.tpass = New System.Windows.Forms.TextBox()
        Me.tuname = New System.Windows.Forms.TextBox()
        Me.lpass = New System.Windows.Forms.Label()
        Me.luname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.terror = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bback
        '
        Me.bback.BackColor = System.Drawing.Color.Firebrick
        Me.bback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bback.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bback.Location = New System.Drawing.Point(-1, -2)
        Me.bback.Name = "bback"
        Me.bback.Size = New System.Drawing.Size(70, 46)
        Me.bback.TabIndex = 17
        Me.bback.Text = "Back"
        Me.bback.UseVisualStyleBackColor = False
        '
        'logbtn
        '
        Me.logbtn.BackColor = System.Drawing.Color.Black
        Me.logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.logbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logbtn.Location = New System.Drawing.Point(311, 422)
        Me.logbtn.Name = "logbtn"
        Me.logbtn.Size = New System.Drawing.Size(153, 41)
        Me.logbtn.TabIndex = 16
        Me.logbtn.Text = "Login"
        Me.logbtn.UseVisualStyleBackColor = False
        '
        'clrbtn
        '
        Me.clrbtn.BackColor = System.Drawing.Color.Black
        Me.clrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clrbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clrbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clrbtn.Location = New System.Drawing.Point(495, 422)
        Me.clrbtn.Name = "clrbtn"
        Me.clrbtn.Size = New System.Drawing.Size(105, 41)
        Me.clrbtn.TabIndex = 15
        Me.clrbtn.Text = "Clear"
        Me.clrbtn.UseVisualStyleBackColor = False
        '
        'tpass
        '
        Me.tpass.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpass.Location = New System.Drawing.Point(311, 269)
        Me.tpass.Name = "tpass"
        Me.tpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tpass.Size = New System.Drawing.Size(289, 35)
        Me.tpass.TabIndex = 14
        '
        'tuname
        '
        Me.tuname.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuname.Location = New System.Drawing.Point(311, 176)
        Me.tuname.Name = "tuname"
        Me.tuname.Size = New System.Drawing.Size(289, 35)
        Me.tuname.TabIndex = 13
        '
        'lpass
        '
        Me.lpass.AutoSize = True
        Me.lpass.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lpass.Location = New System.Drawing.Point(75, 270)
        Me.lpass.Name = "lpass"
        Me.lpass.Size = New System.Drawing.Size(162, 32)
        Me.lpass.TabIndex = 12
        Me.lpass.Text = "Password :"
        '
        'luname
        '
        Me.luname.AutoSize = True
        Me.luname.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.luname.Location = New System.Drawing.Point(75, 176)
        Me.luname.Name = "luname"
        Me.luname.Size = New System.Drawing.Size(105, 32)
        Me.luname.TabIndex = 11
        Me.luname.Text = "Index :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 65.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 96)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Login"
        '
        'terror
        '
        Me.terror.AutoSize = True
        Me.terror.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terror.ForeColor = System.Drawing.Color.Gold
        Me.terror.Location = New System.Drawing.Point(306, 339)
        Me.terror.Name = "terror"
        Me.terror.Size = New System.Drawing.Size(0, 25)
        Me.terror.TabIndex = 18
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(672, 506)
        Me.Controls.Add(Me.terror)
        Me.Controls.Add(Me.bback)
        Me.Controls.Add(Me.logbtn)
        Me.Controls.Add(Me.clrbtn)
        Me.Controls.Add(Me.tpass)
        Me.Controls.Add(Me.tuname)
        Me.Controls.Add(Me.lpass)
        Me.Controls.Add(Me.luname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bback As System.Windows.Forms.Button
    Friend WithEvents logbtn As System.Windows.Forms.Button
    Friend WithEvents clrbtn As System.Windows.Forms.Button
    Friend WithEvents tpass As System.Windows.Forms.TextBox
    Friend WithEvents tuname As System.Windows.Forms.TextBox
    Friend WithEvents lpass As System.Windows.Forms.Label
    Friend WithEvents luname As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents terror As System.Windows.Forms.Label

End Class
