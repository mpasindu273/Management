<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editlecturer
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
        Dim Lecturer_nameLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Phone_noLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PWLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.bclear = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bdelete = New System.Windows.Forms.Button()
        Me.bsearch = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.bcommit = New System.Windows.Forms.Button()
        Me.bnew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.t4 = New System.Windows.Forms.TextBox()
        Me.t5 = New System.Windows.Forms.TextBox()
        Me.t6 = New System.Windows.Forms.TextBox()
        Me.t7 = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.ComboBox()
        Me.bupdate = New System.Windows.Forms.Button()
        Me.bcancel = New System.Windows.Forms.Button()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.t8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Lecturer_nameLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Phone_noLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PWLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lecturer_nameLabel
        '
        Lecturer_nameLabel.AutoSize = True
        Lecturer_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lecturer_nameLabel.Location = New System.Drawing.Point(59, 130)
        Lecturer_nameLabel.Name = "Lecturer_nameLabel"
        Lecturer_nameLabel.Size = New System.Drawing.Size(121, 18)
        Lecturer_nameLabel.TabIndex = 55
        Lecturer_nameLabel.Text = "Lecturer name:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubjectLabel.Location = New System.Drawing.Point(56, 306)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(69, 18)
        SubjectLabel.TabIndex = 56
        SubjectLabel.Text = "Subject:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(57, 350)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(42, 18)
        CityLabel.TabIndex = 57
        CityLabel.Text = "City:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(56, 383)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(55, 18)
        EmailLabel.TabIndex = 58
        EmailLabel.Text = "Email:"
        '
        'Phone_noLabel
        '
        Phone_noLabel.AutoSize = True
        Phone_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_noLabel.Location = New System.Drawing.Point(56, 422)
        Phone_noLabel.Name = "Phone_noLabel"
        Phone_noLabel.Size = New System.Drawing.Size(85, 18)
        Phone_noLabel.TabIndex = 59
        Phone_noLabel.Text = "Phone no:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(57, 216)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(90, 18)
        UsernameLabel.TabIndex = 60
        UsernameLabel.Text = "Username:"
        '
        'PWLabel
        '
        PWLabel.AutoSize = True
        PWLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PWLabel.Location = New System.Drawing.Point(57, 259)
        PWLabel.Name = "PWLabel"
        PWLabel.Size = New System.Drawing.Size(40, 18)
        PWLabel.TabIndex = 61
        PWLabel.Text = "PW:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(55, 177)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(63, 18)
        Label3.TabIndex = 56
        Label3.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "ID"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button10.Location = New System.Drawing.Point(785, 396)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(91, 28)
        Me.Button10.TabIndex = 55
        Me.Button10.Text = "Last"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'bclear
        '
        Me.bclear.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bclear.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bclear.Location = New System.Drawing.Point(728, 131)
        Me.bclear.Margin = New System.Windows.Forms.Padding(2)
        Me.bclear.Name = "bclear"
        Me.bclear.Size = New System.Drawing.Size(58, 26)
        Me.bclear.TabIndex = 54
        Me.bclear.Text = "Clear"
        Me.bclear.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button8.Location = New System.Drawing.Point(665, 353)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 28)
        Me.Button8.TabIndex = 53
        Me.Button8.Text = "First"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 469)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.Size = New System.Drawing.Size(884, 173)
        Me.DataGridView1.TabIndex = 51
        '
        'bdelete
        '
        Me.bdelete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bdelete.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bdelete.Location = New System.Drawing.Point(728, 286)
        Me.bdelete.Margin = New System.Windows.Forms.Padding(2)
        Me.bdelete.Name = "bdelete"
        Me.bdelete.Size = New System.Drawing.Size(88, 33)
        Me.bdelete.TabIndex = 48
        Me.bdelete.Text = "Delete"
        Me.bdelete.UseVisualStyleBackColor = False
        '
        'bsearch
        '
        Me.bsearch.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bsearch.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bsearch.Location = New System.Drawing.Point(649, 130)
        Me.bsearch.Margin = New System.Windows.Forms.Padding(2)
        Me.bsearch.Name = "bsearch"
        Me.bsearch.Size = New System.Drawing.Size(65, 26)
        Me.bsearch.TabIndex = 47
        Me.bsearch.Text = "Search"
        Me.bsearch.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(785, 353)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 28)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Next"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(665, 396)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 28)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Previous"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'bcommit
        '
        Me.bcommit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bcommit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bcommit.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcommit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bcommit.Location = New System.Drawing.Point(728, 198)
        Me.bcommit.Margin = New System.Windows.Forms.Padding(2)
        Me.bcommit.Name = "bcommit"
        Me.bcommit.Size = New System.Drawing.Size(88, 33)
        Me.bcommit.TabIndex = 43
        Me.bcommit.Text = "Commit"
        Me.bcommit.UseVisualStyleBackColor = False
        Me.bcommit.Visible = False
        '
        'bnew
        '
        Me.bnew.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bnew.FlatAppearance.BorderSize = 3
        Me.bnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bnew.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnew.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bnew.Location = New System.Drawing.Point(728, 198)
        Me.bnew.Margin = New System.Windows.Forms.Padding(2)
        Me.bnew.Name = "bnew"
        Me.bnew.Size = New System.Drawing.Size(88, 33)
        Me.bnew.TabIndex = 42
        Me.bnew.Text = "Add new"
        Me.bnew.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 36)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Lecturer Records"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Location = New System.Drawing.Point(228, 130)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(407, 24)
        Me.t1.TabIndex = 0
        '
        't3
        '
        Me.t3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3.Location = New System.Drawing.Point(227, 344)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(407, 24)
        Me.t3.TabIndex = 58
        '
        't4
        '
        Me.t4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4.Location = New System.Drawing.Point(225, 383)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(407, 24)
        Me.t4.TabIndex = 59
        '
        't5
        '
        Me.t5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t5.Location = New System.Drawing.Point(225, 422)
        Me.t5.MaxLength = 10
        Me.t5.Name = "t5"
        Me.t5.Size = New System.Drawing.Size(407, 24)
        Me.t5.TabIndex = 60
        Me.t5.Tag = ""
        '
        't6
        '
        Me.t6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t6.Location = New System.Drawing.Point(227, 217)
        Me.t6.Name = "t6"
        Me.t6.ReadOnly = True
        Me.t6.Size = New System.Drawing.Size(407, 24)
        Me.t6.TabIndex = 7
        '
        't7
        '
        Me.t7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t7.Location = New System.Drawing.Point(225, 259)
        Me.t7.Name = "t7"
        Me.t7.ReadOnly = True
        Me.t7.Size = New System.Drawing.Size(407, 24)
        Me.t7.TabIndex = 62
        Me.t7.Tag = ""
        '
        't2
        '
        Me.t2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.FormattingEnabled = True
        Me.t2.Location = New System.Drawing.Point(224, 301)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(407, 26)
        Me.t2.TabIndex = 63
        '
        'bupdate
        '
        Me.bupdate.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bupdate.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bupdate.Location = New System.Drawing.Point(728, 244)
        Me.bupdate.Margin = New System.Windows.Forms.Padding(2)
        Me.bupdate.Name = "bupdate"
        Me.bupdate.Size = New System.Drawing.Size(88, 33)
        Me.bupdate.TabIndex = 43
        Me.bupdate.Text = "Update"
        Me.bupdate.UseVisualStyleBackColor = False
        '
        'bcancel
        '
        Me.bcancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bcancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bcancel.Location = New System.Drawing.Point(728, 286)
        Me.bcancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bcancel.Name = "bcancel"
        Me.bcancel.Size = New System.Drawing.Size(88, 33)
        Me.bcancel.TabIndex = 43
        Me.bcancel.Text = "Cancel"
        Me.bcancel.UseVisualStyleBackColor = False
        Me.bcancel.Visible = False
        '
        'tid
        '
        Me.tid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tid.Location = New System.Drawing.Point(401, 48)
        Me.tid.Name = "tid"
        Me.tid.ReadOnly = True
        Me.tid.Size = New System.Drawing.Size(60, 24)
        Me.tid.TabIndex = 61
        '
        't8
        '
        Me.t8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t8.FormattingEnabled = True
        Me.t8.Location = New System.Drawing.Point(225, 177)
        Me.t8.Name = "t8"
        Me.t8.Size = New System.Drawing.Size(407, 26)
        Me.t8.TabIndex = 63
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All Lecturers"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 24)
        Me.ComboBox1.TabIndex = 64
        Me.ComboBox1.Text = "All Lecturers"
        '
        'editlecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(908, 642)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.t8)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(PWLabel)
        Me.Controls.Add(Me.t7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.t6)
        Me.Controls.Add(Phone_noLabel)
        Me.Controls.Add(Me.t5)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.t4)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(SubjectLabel)
        Me.Controls.Add(Lecturer_nameLabel)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.bclear)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bdelete)
        Me.Controls.Add(Me.bsearch)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.bcancel)
        Me.Controls.Add(Me.bupdate)
        Me.Controls.Add(Me.bcommit)
        Me.Controls.Add(Me.bnew)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "editlecturer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editlecturer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents bclear As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bdelete As System.Windows.Forms.Button
    Friend WithEvents bsearch As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents bcommit As System.Windows.Forms.Button
    Friend WithEvents bnew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents t5 As System.Windows.Forms.TextBox
    Friend WithEvents t6 As System.Windows.Forms.TextBox
    Friend WithEvents t7 As System.Windows.Forms.TextBox
    Friend WithEvents t2 As System.Windows.Forms.ComboBox
    Friend WithEvents bupdate As System.Windows.Forms.Button
    Friend WithEvents bcancel As System.Windows.Forms.Button
    Friend WithEvents tid As System.Windows.Forms.TextBox
    Friend WithEvents t8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
