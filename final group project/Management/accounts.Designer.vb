<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accounts
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
        Me.t1 = New System.Windows.Forms.Timer(Me.components)
        Me.bstudent = New System.Windows.Forms.Button()
        Me.blecturer = New System.Windows.Forms.Button()
        Me.badmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        't1
        '
        Me.t1.Enabled = True
        Me.t1.Interval = 30
        '
        'bstudent
        '
        Me.bstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.bstudent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bstudent.Location = New System.Drawing.Point(251, 60)
        Me.bstudent.Name = "bstudent"
        Me.bstudent.Size = New System.Drawing.Size(164, 70)
        Me.bstudent.TabIndex = 10
        Me.bstudent.Text = "Student"
        Me.bstudent.UseVisualStyleBackColor = True
        '
        'blecturer
        '
        Me.blecturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.blecturer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.blecturer.Location = New System.Drawing.Point(251, 211)
        Me.blecturer.Name = "blecturer"
        Me.blecturer.Size = New System.Drawing.Size(164, 70)
        Me.blecturer.TabIndex = 10
        Me.blecturer.Text = "Lecturer"
        Me.blecturer.UseVisualStyleBackColor = True
        '
        'badmin
        '
        Me.badmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.badmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.badmin.Location = New System.Drawing.Point(251, 363)
        Me.badmin.Name = "badmin"
        Me.badmin.Size = New System.Drawing.Size(164, 70)
        Me.badmin.TabIndex = 10
        Me.badmin.Text = "Admin"
        Me.badmin.UseVisualStyleBackColor = True
        '
        'accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(672, 506)
        Me.Controls.Add(Me.badmin)
        Me.Controls.Add(Me.blecturer)
        Me.Controls.Add(Me.bstudent)
        Me.Name = "accounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents t1 As System.Windows.Forms.Timer
    Friend WithEvents bstudent As System.Windows.Forms.Button
    Friend WithEvents blecturer As System.Windows.Forms.Button
    Friend WithEvents badmin As System.Windows.Forms.Button
End Class
