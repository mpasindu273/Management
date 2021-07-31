<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notice
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
        Me.admintab = New System.Windows.Forms.TabPage()
        Me.lectab = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.bexit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'admintab
        '
        Me.admintab.AutoScroll = True
        Me.admintab.AutoScrollMinSize = New System.Drawing.Size(0, 1100)
        Me.admintab.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.admintab.Location = New System.Drawing.Point(4, 27)
        Me.admintab.Name = "admintab"
        Me.admintab.Padding = New System.Windows.Forms.Padding(3)
        Me.admintab.Size = New System.Drawing.Size(782, 502)
        Me.admintab.TabIndex = 1
        Me.admintab.Text = "Admin"
        '
        'lectab
        '
        Me.lectab.AutoScroll = True
        Me.lectab.AutoScrollMinSize = New System.Drawing.Size(0, 1050)
        Me.lectab.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lectab.Location = New System.Drawing.Point(4, 27)
        Me.lectab.Name = "lectab"
        Me.lectab.Padding = New System.Windows.Forms.Padding(3)
        Me.lectab.Size = New System.Drawing.Size(782, 502)
        Me.lectab.TabIndex = 0
        Me.lectab.Text = "Lecturer"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.lectab)
        Me.TabControl1.Controls.Add(Me.admintab)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-3, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(790, 533)
        Me.TabControl1.TabIndex = 0
        '
        'bexit
        '
        Me.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bexit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bexit.Location = New System.Drawing.Point(749, 0)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(34, 30)
        Me.bexit.TabIndex = 12
        Me.bexit.Text = "X"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'notice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(788, 541)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "notice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "notice"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents admintab As System.Windows.Forms.TabPage
    Friend WithEvents lectab As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents bexit As System.Windows.Forms.Button
End Class
