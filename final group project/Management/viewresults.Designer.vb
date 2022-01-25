<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewresults
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tindex = New System.Windows.Forms.TextBox()
        Me.bexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(37, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Index"
        '
        'tindex
        '
        Me.tindex.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tindex.ForeColor = System.Drawing.Color.DarkRed
        Me.tindex.Location = New System.Drawing.Point(119, 49)
        Me.tindex.Name = "tindex"
        Me.tindex.ReadOnly = True
        Me.tindex.Size = New System.Drawing.Size(228, 29)
        Me.tindex.TabIndex = 20
        Me.tindex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bexit
        '
        Me.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bexit.Location = New System.Drawing.Point(612, 1)
        Me.bexit.Name = "bexit"
        Me.bexit.Size = New System.Drawing.Size(54, 41)
        Me.bexit.TabIndex = 17
        Me.bexit.Text = "X"
        Me.bexit.UseVisualStyleBackColor = True
        '
        'viewresults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(667, 603)
        Me.Controls.Add(Me.bexit)
        Me.Controls.Add(Me.tindex)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "viewresults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewresults"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tindex As System.Windows.Forms.TextBox
    Friend WithEvents bexit As System.Windows.Forms.Button
End Class
