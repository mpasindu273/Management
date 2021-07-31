<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminnotice
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
        Me.ltime = New System.Windows.Forms.Label()
        Me.ldate = New System.Windows.Forms.Label()
        Me.ttime = New System.Windows.Forms.TextBox()
        Me.tdate = New System.Windows.Forms.TextBox()
        Me.bnxt = New System.Windows.Forms.Button()
        Me.bprev = New System.Windows.Forms.Button()
        Me.bback = New System.Windows.Forms.Button()
        Me.bdelete = New System.Windows.Forms.Button()
        Me.bcommit = New System.Windows.Forms.Button()
        Me.badd = New System.Windows.Forms.Button()
        Me.tnote = New System.Windows.Forms.RichTextBox()
        Me.bexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltime
        '
        Me.ltime.AutoSize = True
        Me.ltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ltime.Location = New System.Drawing.Point(363, 43)
        Me.ltime.Name = "ltime"
        Me.ltime.Size = New System.Drawing.Size(47, 20)
        Me.ltime.TabIndex = 13
        Me.ltime.Text = "Time"
        '
        'ldate
        '
        Me.ldate.AutoSize = True
        Me.ldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ldate.Location = New System.Drawing.Point(44, 43)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(48, 20)
        Me.ldate.TabIndex = 14
        Me.ldate.Text = "Date"
        '
        'ttime
        '
        Me.ttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttime.Location = New System.Drawing.Point(431, 40)
        Me.ttime.Name = "ttime"
        Me.ttime.ReadOnly = True
        Me.ttime.Size = New System.Drawing.Size(130, 26)
        Me.ttime.TabIndex = 11
        Me.ttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tdate
        '
        Me.tdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdate.Location = New System.Drawing.Point(104, 40)
        Me.tdate.Name = "tdate"
        Me.tdate.ReadOnly = True
        Me.tdate.Size = New System.Drawing.Size(150, 26)
        Me.tdate.TabIndex = 12
        Me.tdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bnxt
        '
        Me.bnxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnxt.Location = New System.Drawing.Point(367, 429)
        Me.bnxt.Name = "bnxt"
        Me.bnxt.Size = New System.Drawing.Size(139, 34)
        Me.bnxt.TabIndex = 5
        Me.bnxt.Text = ">>"
        Me.bnxt.UseVisualStyleBackColor = True
        Me.bnxt.Visible = False
        '
        'bprev
        '
        Me.bprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bprev.Location = New System.Drawing.Point(130, 429)
        Me.bprev.Name = "bprev"
        Me.bprev.Size = New System.Drawing.Size(143, 34)
        Me.bprev.TabIndex = 6
        Me.bprev.Text = "<<"
        Me.bprev.UseVisualStyleBackColor = True
        Me.bprev.Visible = False
        '
        'bback
        '
        Me.bback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bback.Location = New System.Drawing.Point(635, 292)
        Me.bback.Name = "bback"
        Me.bback.Size = New System.Drawing.Size(105, 39)
        Me.bback.TabIndex = 7
        Me.bback.Text = "Back"
        Me.bback.UseVisualStyleBackColor = True
        Me.bback.Visible = False
        '
        'bdelete
        '
        Me.bdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdelete.Location = New System.Drawing.Point(635, 292)
        Me.bdelete.Name = "bdelete"
        Me.bdelete.Size = New System.Drawing.Size(105, 39)
        Me.bdelete.TabIndex = 8
        Me.bdelete.Text = "Delete Notice"
        Me.bdelete.UseVisualStyleBackColor = True
        '
        'bcommit
        '
        Me.bcommit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcommit.Location = New System.Drawing.Point(635, 192)
        Me.bcommit.Name = "bcommit"
        Me.bcommit.Size = New System.Drawing.Size(105, 39)
        Me.bcommit.TabIndex = 9
        Me.bcommit.Text = "Commit"
        Me.bcommit.UseVisualStyleBackColor = True
        Me.bcommit.Visible = False
        '
        'badd
        '
        Me.badd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badd.Location = New System.Drawing.Point(635, 171)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(105, 80)
        Me.badd.TabIndex = 10
        Me.badd.Text = "Add New Notice"
        Me.badd.UseVisualStyleBackColor = True
        '
        'tnote
        '
        Me.tnote.BackColor = System.Drawing.SystemColors.Control
        Me.tnote.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnote.Location = New System.Drawing.Point(36, 97)
        Me.tnote.Name = "tnote"
        Me.tnote.ReadOnly = True
        Me.tnote.Size = New System.Drawing.Size(553, 306)
        Me.tnote.TabIndex = 4
        Me.tnote.Text = ""
        '
        'bexit
        '
        Me.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bexit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bexit.Location = New System.Drawing.Point(725, 0)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(54, 41)
        Me.bexit.TabIndex = 17
        Me.bexit.Text = "X"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'adminnotice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.ClientSize = New System.Drawing.Size(777, 502)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.ltime)
        Me.Controls.Add(Me.ldate)
        Me.Controls.Add(Me.ttime)
        Me.Controls.Add(Me.tdate)
        Me.Controls.Add(Me.bnxt)
        Me.Controls.Add(Me.bprev)
        Me.Controls.Add(Me.bback)
        Me.Controls.Add(Me.bdelete)
        Me.Controls.Add(Me.bcommit)
        Me.Controls.Add(Me.badd)
        Me.Controls.Add(Me.tnote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminnotice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminnotice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ltime As System.Windows.Forms.Label
    Friend WithEvents ldate As System.Windows.Forms.Label
    Friend WithEvents ttime As System.Windows.Forms.TextBox
    Friend WithEvents tdate As System.Windows.Forms.TextBox
    Friend WithEvents bnxt As System.Windows.Forms.Button
    Friend WithEvents bprev As System.Windows.Forms.Button
    Friend WithEvents bback As System.Windows.Forms.Button
    Friend WithEvents bdelete As System.Windows.Forms.Button
    Friend WithEvents bcommit As System.Windows.Forms.Button
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents tnote As System.Windows.Forms.RichTextBox
    Friend WithEvents bexit As System.Windows.Forms.Button
End Class
