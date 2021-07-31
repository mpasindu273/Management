<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepwd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnew = New System.Windows.Forms.Label()
        Me.tcurrent = New System.Windows.Forms.TextBox()
        Me.lconf = New System.Windows.Forms.Label()
        Me.tnew = New System.Windows.Forms.TextBox()
        Me.tconf = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.bok = New System.Windows.Forms.Button()
        Me.bcheck = New System.Windows.Forms.Button()
        Me.bexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(149, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(52, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current password: "
        '
        'lnew
        '
        Me.lnew.AutoSize = True
        Me.lnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnew.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lnew.Location = New System.Drawing.Point(52, 277)
        Me.lnew.Name = "lnew"
        Me.lnew.Size = New System.Drawing.Size(186, 29)
        Me.lnew.TabIndex = 1
        Me.lnew.Text = "New password: "
        Me.lnew.Visible = False
        '
        'tcurrent
        '
        Me.tcurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcurrent.Location = New System.Drawing.Point(314, 126)
        Me.tcurrent.Name = "tcurrent"
        Me.tcurrent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tcurrent.Size = New System.Drawing.Size(238, 32)
        Me.tcurrent.TabIndex = 0
        '
        'lconf
        '
        Me.lconf.AutoSize = True
        Me.lconf.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lconf.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lconf.Location = New System.Drawing.Point(52, 368)
        Me.lconf.Name = "lconf"
        Me.lconf.Size = New System.Drawing.Size(109, 29)
        Me.lconf.TabIndex = 1
        Me.lconf.Text = "Confirm: "
        Me.lconf.Visible = False
        '
        'tnew
        '
        Me.tnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnew.Location = New System.Drawing.Point(314, 277)
        Me.tnew.Name = "tnew"
        Me.tnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tnew.Size = New System.Drawing.Size(238, 32)
        Me.tnew.TabIndex = 2
        Me.tnew.Visible = False
        '
        'tconf
        '
        Me.tconf.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tconf.Location = New System.Drawing.Point(314, 368)
        Me.tconf.Name = "tconf"
        Me.tconf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tconf.Size = New System.Drawing.Size(238, 32)
        Me.tconf.TabIndex = 2
        Me.tconf.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(631, 506)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -5
        Me.LineShape1.X2 = 628
        Me.LineShape1.Y1 = 237
        Me.LineShape1.Y2 = 238
        '
        'bok
        '
        Me.bok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bok.Location = New System.Drawing.Point(477, 445)
        Me.bok.Name = "bok"
        Me.bok.Size = New System.Drawing.Size(75, 32)
        Me.bok.TabIndex = 5
        Me.bok.Text = "change"
        Me.bok.UseVisualStyleBackColor = True
        Me.bok.Visible = False
        '
        'bcheck
        '
        Me.bcheck.Location = New System.Drawing.Point(477, 184)
        Me.bcheck.Name = "bcheck"
        Me.bcheck.Size = New System.Drawing.Size(75, 26)
        Me.bcheck.TabIndex = 6
        Me.bcheck.Text = "Ok"
        Me.bcheck.UseVisualStyleBackColor = True
        '
        'bexit
        '
        Me.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bexit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bexit.Location = New System.Drawing.Point(577, 0)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(54, 41)
        Me.bexit.TabIndex = 11
        Me.bexit.Text = "X"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'changepwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(631, 506)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.bcheck)
        Me.Controls.Add(Me.bok)
        Me.Controls.Add(Me.tconf)
        Me.Controls.Add(Me.tnew)
        Me.Controls.Add(Me.tcurrent)
        Me.Controls.Add(Me.lconf)
        Me.Controls.Add(Me.lnew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "changepwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "changepw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lnew As System.Windows.Forms.Label
    Friend WithEvents tcurrent As System.Windows.Forms.TextBox
    Friend WithEvents lconf As System.Windows.Forms.Label
    Friend WithEvents tnew As System.Windows.Forms.TextBox
    Friend WithEvents tconf As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents bok As System.Windows.Forms.Button
    Friend WithEvents bcheck As System.Windows.Forms.Button
    Friend WithEvents bexit As System.Windows.Forms.Button
End Class
