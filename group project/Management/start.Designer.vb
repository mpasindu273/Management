<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(start))
        Me.t1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bexit = New System.Windows.Forms.Button()
        Me.badmin = New System.Windows.Forms.Button()
        Me.blecturer = New System.Windows.Forms.Button()
        Me.bstudent = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        't1
        '
        Me.t1.Enabled = True
        Me.t1.Interval = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(118, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 63)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select an account"
        '
        'bexit
        '
        Me.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bexit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bexit.Location = New System.Drawing.Point(621, -2)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(54, 41)
        Me.bexit.TabIndex = 9
        Me.bexit.Text = "X"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'badmin
        '
        Me.badmin.BackColor = System.Drawing.Color.Orange
        Me.badmin.BackgroundImage = Global.Management.My.Resources.Resources.admin
        Me.badmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.badmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.badmin.ForeColor = System.Drawing.Color.White
        Me.badmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.badmin.Location = New System.Drawing.Point(485, 265)
        Me.badmin.Name = "badmin"
        Me.badmin.Size = New System.Drawing.Size(115, 106)
        Me.badmin.TabIndex = 7
        Me.badmin.UseVisualStyleBackColor = False
        '
        'blecturer
        '
        Me.blecturer.BackColor = System.Drawing.Color.Orange
        Me.blecturer.BackgroundImage = CType(resources.GetObject("blecturer.BackgroundImage"), System.Drawing.Image)
        Me.blecturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.blecturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.blecturer.ForeColor = System.Drawing.Color.White
        Me.blecturer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.blecturer.Location = New System.Drawing.Point(284, 265)
        Me.blecturer.Name = "blecturer"
        Me.blecturer.Size = New System.Drawing.Size(115, 106)
        Me.blecturer.TabIndex = 7
        Me.blecturer.UseVisualStyleBackColor = False
        '
        'bstudent
        '
        Me.bstudent.BackColor = System.Drawing.Color.Orange
        Me.bstudent.BackgroundImage = Global.Management.My.Resources.Resources.student
        Me.bstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.bstudent.ForeColor = System.Drawing.Color.White
        Me.bstudent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bstudent.Location = New System.Drawing.Point(71, 265)
        Me.bstudent.Name = "bstudent"
        Me.bstudent.Size = New System.Drawing.Size(115, 106)
        Me.bstudent.TabIndex = 7
        Me.bstudent.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(82, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Student"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(298, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Lecturer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(480, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Adminstrator"
        '
        'start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(672, 506)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.badmin)
        Me.Controls.Add(Me.blecturer)
        Me.Controls.Add(Me.bstudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t1 As System.Windows.Forms.Timer
    Friend WithEvents bstudent As System.Windows.Forms.Button
    Friend WithEvents blecturer As System.Windows.Forms.Button
    Friend WithEvents badmin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bexit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
