<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editcourse
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
        Me.badd = New System.Windows.Forms.Button()
        Me.bdelete = New System.Windows.Forms.Button()
        Me.bcommit = New System.Windows.Forms.Button()
        Me.bcancel = New System.Windows.Forms.Button()
        Me.searchpanel = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plong = New System.Windows.Forms.Panel()
        Me.llongname = New System.Windows.Forms.Label()
        Me.pshort = New System.Windows.Forms.Panel()
        Me.lshortname = New System.Windows.Forms.Label()
        Me.ptop = New System.Windows.Forms.Panel()
        Me.lcourse = New System.Windows.Forms.Label()
        Me.tcourse = New System.Windows.Forms.TextBox()
        Me.tsub = New System.Windows.Forms.TextBox()
        Me.lsub = New System.Windows.Forms.Label()
        Me.tcourseShort = New System.Windows.Forms.TextBox()
        Me.bsub = New System.Windows.Forms.Button()
        Me.searchpanel.SuspendLayout()
        Me.ptop.SuspendLayout()
        Me.SuspendLayout()
        '
        'badd
        '
        Me.badd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badd.Location = New System.Drawing.Point(537, 248)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(75, 30)
        Me.badd.TabIndex = 1
        Me.badd.Text = "Add new"
        Me.badd.UseVisualStyleBackColor = True
        '
        'bdelete
        '
        Me.bdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdelete.Location = New System.Drawing.Point(537, 324)
        Me.bdelete.Name = "bdelete"
        Me.bdelete.Size = New System.Drawing.Size(75, 30)
        Me.bdelete.TabIndex = 1
        Me.bdelete.Text = "Delete"
        Me.bdelete.UseVisualStyleBackColor = True
        '
        'bcommit
        '
        Me.bcommit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcommit.Location = New System.Drawing.Point(537, 248)
        Me.bcommit.Name = "bcommit"
        Me.bcommit.Size = New System.Drawing.Size(75, 30)
        Me.bcommit.TabIndex = 1
        Me.bcommit.Text = "Commit"
        Me.bcommit.UseVisualStyleBackColor = True
        Me.bcommit.Visible = False
        '
        'bcancel
        '
        Me.bcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancel.Location = New System.Drawing.Point(537, 324)
        Me.bcancel.Name = "bcancel"
        Me.bcancel.Size = New System.Drawing.Size(75, 30)
        Me.bcancel.TabIndex = 1
        Me.bcancel.Text = "Cancel"
        Me.bcancel.UseVisualStyleBackColor = True
        Me.bcancel.Visible = False
        '
        'searchpanel
        '
        Me.searchpanel.Controls.Add(Me.ComboBox1)
        Me.searchpanel.Controls.Add(Me.Label1)
        Me.searchpanel.Location = New System.Drawing.Point(442, 12)
        Me.searchpanel.Name = "searchpanel"
        Me.searchpanel.Size = New System.Drawing.Size(242, 79)
        Me.searchpanel.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(44, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Course"
        '
        'plong
        '
        Me.plong.AutoSize = True
        Me.plong.Location = New System.Drawing.Point(18, 176)
        Me.plong.Name = "plong"
        Me.plong.Size = New System.Drawing.Size(311, 323)
        Me.plong.TabIndex = 7
        '
        'llongname
        '
        Me.llongname.AutoSize = True
        Me.llongname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llongname.Location = New System.Drawing.Point(144, 156)
        Me.llongname.Name = "llongname"
        Me.llongname.Size = New System.Drawing.Size(79, 17)
        Me.llongname.TabIndex = 7
        Me.llongname.Text = "Long name"
        Me.llongname.Visible = False
        '
        'pshort
        '
        Me.pshort.Location = New System.Drawing.Point(335, 176)
        Me.pshort.Name = "pshort"
        Me.pshort.Size = New System.Drawing.Size(115, 323)
        Me.pshort.TabIndex = 7
        '
        'lshortname
        '
        Me.lshortname.AutoSize = True
        Me.lshortname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lshortname.Location = New System.Drawing.Point(370, 156)
        Me.lshortname.Name = "lshortname"
        Me.lshortname.Size = New System.Drawing.Size(42, 17)
        Me.lshortname.TabIndex = 6
        Me.lshortname.Text = "Short"
        Me.lshortname.Visible = False
        '
        'ptop
        '
        Me.ptop.Controls.Add(Me.lcourse)
        Me.ptop.Controls.Add(Me.tcourse)
        Me.ptop.Controls.Add(Me.tsub)
        Me.ptop.Controls.Add(Me.lsub)
        Me.ptop.Controls.Add(Me.tcourseShort)
        Me.ptop.Controls.Add(Me.bsub)
        Me.ptop.Location = New System.Drawing.Point(12, 3)
        Me.ptop.Name = "ptop"
        Me.ptop.Size = New System.Drawing.Size(415, 129)
        Me.ptop.TabIndex = 8
        Me.ptop.Visible = False
        '
        'lcourse
        '
        Me.lcourse.AutoSize = True
        Me.lcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcourse.Location = New System.Drawing.Point(3, 28)
        Me.lcourse.Name = "lcourse"
        Me.lcourse.Size = New System.Drawing.Size(96, 17)
        Me.lcourse.TabIndex = 22
        Me.lcourse.Text = "Course name:"
        '
        'tcourse
        '
        Me.tcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcourse.Location = New System.Drawing.Point(123, 28)
        Me.tcourse.Name = "tcourse"
        Me.tcourse.Size = New System.Drawing.Size(205, 23)
        Me.tcourse.TabIndex = 18
        '
        'tsub
        '
        Me.tsub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsub.Location = New System.Drawing.Point(123, 78)
        Me.tsub.Name = "tsub"
        Me.tsub.Size = New System.Drawing.Size(77, 23)
        Me.tsub.TabIndex = 20
        '
        'lsub
        '
        Me.lsub.AutoSize = True
        Me.lsub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsub.Location = New System.Drawing.Point(3, 81)
        Me.lsub.Name = "lsub"
        Me.lsub.Size = New System.Drawing.Size(102, 17)
        Me.lsub.TabIndex = 23
        Me.lsub.Text = "No. of subjects"
        '
        'tcourseShort
        '
        Me.tcourseShort.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcourseShort.Location = New System.Drawing.Point(344, 28)
        Me.tcourseShort.Name = "tcourseShort"
        Me.tcourseShort.Size = New System.Drawing.Size(68, 23)
        Me.tcourseShort.TabIndex = 19
        '
        'bsub
        '
        Me.bsub.Location = New System.Drawing.Point(222, 78)
        Me.bsub.Name = "bsub"
        Me.bsub.Size = New System.Drawing.Size(52, 23)
        Me.bsub.TabIndex = 21
        Me.bsub.Text = "Ok"
        Me.bsub.UseVisualStyleBackColor = True
        '
        'editcourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(683, 544)
        Me.Controls.Add(Me.llongname)
        Me.Controls.Add(Me.lshortname)
        Me.Controls.Add(Me.ptop)
        Me.Controls.Add(Me.pshort)
        Me.Controls.Add(Me.plong)
        Me.Controls.Add(Me.searchpanel)
        Me.Controls.Add(Me.bdelete)
        Me.Controls.Add(Me.bcommit)
        Me.Controls.Add(Me.bcancel)
        Me.Controls.Add(Me.badd)
        Me.Name = "editcourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editcourse"
        Me.searchpanel.ResumeLayout(False)
        Me.searchpanel.PerformLayout()
        Me.ptop.ResumeLayout(False)
        Me.ptop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents bdelete As System.Windows.Forms.Button
    Friend WithEvents bcommit As System.Windows.Forms.Button
    Friend WithEvents bcancel As System.Windows.Forms.Button
    Friend WithEvents searchpanel As System.Windows.Forms.Panel
    Friend WithEvents plong As System.Windows.Forms.Panel
    Friend WithEvents pshort As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ptop As System.Windows.Forms.Panel
    Friend WithEvents lcourse As System.Windows.Forms.Label
    Friend WithEvents tcourse As System.Windows.Forms.TextBox
    Friend WithEvents tsub As System.Windows.Forms.TextBox
    Friend WithEvents lsub As System.Windows.Forms.Label
    Friend WithEvents tcourseShort As System.Windows.Forms.TextBox
    Friend WithEvents bsub As System.Windows.Forms.Button
    Friend WithEvents lshortname As System.Windows.Forms.Label
    Friend WithEvents llongname As System.Windows.Forms.Label
End Class
