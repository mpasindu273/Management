<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editnotice
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
        Me.tnote = New System.Windows.Forms.RichTextBox()
        Me.badd = New System.Windows.Forms.Button()
        Me.bdelete = New System.Windows.Forms.Button()
        Me.bprev = New System.Windows.Forms.Button()
        Me.bback = New System.Windows.Forms.Button()
        Me.bcommit = New System.Windows.Forms.Button()
        Me.tdate = New System.Windows.Forms.TextBox()
        Me.ttime = New System.Windows.Forms.TextBox()
        Me.ldate = New System.Windows.Forms.Label()
        Me.ltime = New System.Windows.Forms.Label()
        Me.bnxt = New System.Windows.Forms.Button()
        Me.bexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tnote
        '
        Me.tnote.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tnote.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnote.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tnote.Location = New System.Drawing.Point(25, 114)
        Me.tnote.Name = "tnote"
        Me.tnote.ReadOnly = True
        Me.tnote.Size = New System.Drawing.Size(553, 306)
        Me.tnote.TabIndex = 0
        Me.tnote.Text = ""
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.Black
        Me.badd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.badd.Location = New System.Drawing.Point(624, 188)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(105, 80)
        Me.badd.TabIndex = 1
        Me.badd.Text = "Add New Notice"
        Me.badd.UseVisualStyleBackColor = False
        '
        'bdelete
        '
        Me.bdelete.BackColor = System.Drawing.Color.Black
        Me.bdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bdelete.Location = New System.Drawing.Point(624, 309)
        Me.bdelete.Name = "bdelete"
        Me.bdelete.Size = New System.Drawing.Size(105, 65)
        Me.bdelete.TabIndex = 1
        Me.bdelete.Text = "Delete Notice"
        Me.bdelete.UseVisualStyleBackColor = False
        '
        'bprev
        '
        Me.bprev.BackColor = System.Drawing.Color.Black
        Me.bprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bprev.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bprev.Location = New System.Drawing.Point(119, 441)
        Me.bprev.Name = "bprev"
        Me.bprev.Size = New System.Drawing.Size(143, 39)
        Me.bprev.TabIndex = 1
        Me.bprev.Text = "<<"
        Me.bprev.UseVisualStyleBackColor = False
        Me.bprev.Visible = False
        '
        'bback
        '
        Me.bback.BackColor = System.Drawing.Color.Black
        Me.bback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bback.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bback.Location = New System.Drawing.Point(624, 309)
        Me.bback.Name = "bback"
        Me.bback.Size = New System.Drawing.Size(105, 39)
        Me.bback.TabIndex = 1
        Me.bback.Text = "Back"
        Me.bback.UseVisualStyleBackColor = False
        Me.bback.Visible = False
        '
        'bcommit
        '
        Me.bcommit.BackColor = System.Drawing.Color.Black
        Me.bcommit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcommit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bcommit.Location = New System.Drawing.Point(624, 209)
        Me.bcommit.Name = "bcommit"
        Me.bcommit.Size = New System.Drawing.Size(105, 39)
        Me.bcommit.TabIndex = 1
        Me.bcommit.Text = "Commit"
        Me.bcommit.UseVisualStyleBackColor = False
        Me.bcommit.Visible = False
        '
        'tdate
        '
        Me.tdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tdate.Location = New System.Drawing.Point(93, 57)
        Me.tdate.Name = "tdate"
        Me.tdate.ReadOnly = True
        Me.tdate.Size = New System.Drawing.Size(150, 26)
        Me.tdate.TabIndex = 2
        Me.tdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ttime
        '
        Me.ttime.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ttime.Location = New System.Drawing.Point(420, 57)
        Me.ttime.Name = "ttime"
        Me.ttime.ReadOnly = True
        Me.ttime.Size = New System.Drawing.Size(130, 26)
        Me.ttime.TabIndex = 2
        Me.ttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ldate
        '
        Me.ldate.AutoSize = True
        Me.ldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ldate.Location = New System.Drawing.Point(33, 60)
        Me.ldate.Name = "ldate"
        Me.ldate.Size = New System.Drawing.Size(48, 20)
        Me.ldate.TabIndex = 3
        Me.ldate.Text = "Date"
        '
        'ltime
        '
        Me.ltime.AutoSize = True
        Me.ltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ltime.Location = New System.Drawing.Point(352, 60)
        Me.ltime.Name = "ltime"
        Me.ltime.Size = New System.Drawing.Size(47, 20)
        Me.ltime.TabIndex = 3
        Me.ltime.Text = "Time"
        '
        'bnxt
        '
        Me.bnxt.BackColor = System.Drawing.Color.Black
        Me.bnxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnxt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bnxt.Location = New System.Drawing.Point(356, 441)
        Me.bnxt.Name = "bnxt"
        Me.bnxt.Size = New System.Drawing.Size(139, 39)
        Me.bnxt.TabIndex = 1
        Me.bnxt.Text = ">>"
        Me.bnxt.UseVisualStyleBackColor = False
        Me.bnxt.Visible = False
        '
        'bexit
        '
        Me.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bexit.Location = New System.Drawing.Point(726, -2)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(54, 41)
        Me.bexit.TabIndex = 10
        Me.bexit.Text = "X"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'editnotice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(778, 502)
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
        Me.Name = "editnotice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editnotice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tnote As System.Windows.Forms.RichTextBox
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents bdelete As System.Windows.Forms.Button
    Friend WithEvents bprev As System.Windows.Forms.Button
    Friend WithEvents bback As System.Windows.Forms.Button
    Friend WithEvents bcommit As System.Windows.Forms.Button
    Friend WithEvents tdate As System.Windows.Forms.TextBox
    Friend WithEvents ttime As System.Windows.Forms.TextBox
    Friend WithEvents ldate As System.Windows.Forms.Label
    Friend WithEvents ltime As System.Windows.Forms.Label
    Friend WithEvents bnxt As System.Windows.Forms.Button
    Friend WithEvents bexit As System.Windows.Forms.Button
End Class
