<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewstuschedule
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InstituteDataSet = New Management.instituteDataSet()
        Me.IT_TimeTableAdapter = New Management.instituteDataSetTableAdapters.IT_TimeTableAdapter()
        Me.IT_courseTableAdapter = New Management.instituteDataSetTableAdapters.IT_courseTableAdapter()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Field1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MondayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TuesdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WednesdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThursdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FridayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IT_TimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Management.instituteDataSetTableAdapters.TableAdapterManager()
        Me.ITcourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstituteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IT_TimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITcourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeDataGridViewTextBoxColumn, Me.Field1DataGridViewTextBoxColumn, Me.MondayDataGridViewTextBoxColumn, Me.TuesdayDataGridViewTextBoxColumn, Me.WednesdayDataGridViewTextBoxColumn, Me.ThursdayDataGridViewTextBoxColumn, Me.FridayDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IT_TimeBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 45
        Me.DataGridView1.Size = New System.Drawing.Size(1063, 363)
        Me.DataGridView1.TabIndex = 0
        '
        'InstituteDataSet
        '
        Me.InstituteDataSet.DataSetName = "instituteDataSet"
        Me.InstituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IT_TimeTableAdapter
        '
        Me.IT_TimeTableAdapter.ClearBeforeFill = True
        '
        'IT_courseTableAdapter
        '
        Me.IT_courseTableAdapter.ClearBeforeFill = True
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeDataGridViewTextBoxColumn.Width = 170
        '
        'Field1DataGridViewTextBoxColumn
        '
        Me.Field1DataGridViewTextBoxColumn.DataPropertyName = "Field1"
        Me.Field1DataGridViewTextBoxColumn.HeaderText = "Field1"
        Me.Field1DataGridViewTextBoxColumn.Name = "Field1DataGridViewTextBoxColumn"
        Me.Field1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Field1DataGridViewTextBoxColumn.Visible = False
        '
        'MondayDataGridViewTextBoxColumn
        '
        Me.MondayDataGridViewTextBoxColumn.DataPropertyName = "Monday"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MondayDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MondayDataGridViewTextBoxColumn.HeaderText = "Monday"
        Me.MondayDataGridViewTextBoxColumn.Name = "MondayDataGridViewTextBoxColumn"
        Me.MondayDataGridViewTextBoxColumn.ReadOnly = True
        Me.MondayDataGridViewTextBoxColumn.Width = 170
        '
        'TuesdayDataGridViewTextBoxColumn
        '
        Me.TuesdayDataGridViewTextBoxColumn.DataPropertyName = "Tuesday"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TuesdayDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.TuesdayDataGridViewTextBoxColumn.HeaderText = "Tuesday"
        Me.TuesdayDataGridViewTextBoxColumn.Name = "TuesdayDataGridViewTextBoxColumn"
        Me.TuesdayDataGridViewTextBoxColumn.ReadOnly = True
        Me.TuesdayDataGridViewTextBoxColumn.Width = 170
        '
        'WednesdayDataGridViewTextBoxColumn
        '
        Me.WednesdayDataGridViewTextBoxColumn.DataPropertyName = "Wednesday"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.WednesdayDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.WednesdayDataGridViewTextBoxColumn.HeaderText = "Wednesday"
        Me.WednesdayDataGridViewTextBoxColumn.Name = "WednesdayDataGridViewTextBoxColumn"
        Me.WednesdayDataGridViewTextBoxColumn.ReadOnly = True
        Me.WednesdayDataGridViewTextBoxColumn.Width = 170
        '
        'ThursdayDataGridViewTextBoxColumn
        '
        Me.ThursdayDataGridViewTextBoxColumn.DataPropertyName = "Thursday"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ThursdayDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ThursdayDataGridViewTextBoxColumn.HeaderText = "Thursday"
        Me.ThursdayDataGridViewTextBoxColumn.Name = "ThursdayDataGridViewTextBoxColumn"
        Me.ThursdayDataGridViewTextBoxColumn.ReadOnly = True
        Me.ThursdayDataGridViewTextBoxColumn.Width = 170
        '
        'FridayDataGridViewTextBoxColumn
        '
        Me.FridayDataGridViewTextBoxColumn.DataPropertyName = "Friday"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FridayDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.FridayDataGridViewTextBoxColumn.HeaderText = "Friday"
        Me.FridayDataGridViewTextBoxColumn.Name = "FridayDataGridViewTextBoxColumn"
        Me.FridayDataGridViewTextBoxColumn.ReadOnly = True
        Me.FridayDataGridViewTextBoxColumn.Width = 170
        '
        'IT_TimeBindingSource
        '
        Me.IT_TimeBindingSource.DataMember = "IT_Time"
        Me.IT_TimeBindingSource.DataSource = Me.InstituteDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminnoticeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.IT_courseTableAdapter = Nothing
        Me.TableAdapterManager.IT_TimeTableAdapter = Nothing
        Me.TableAdapterManager.ITnoticeTableAdapter = Nothing
        Me.TableAdapterManager.lecturerTableAdapter = Nothing
        Me.TableAdapterManager.resultsTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Management.instituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ITcourseBindingSource
        '
        Me.ITcourseBindingSource.DataMember = "IT_course"
        Me.ITcourseBindingSource.DataSource = Me.InstituteDataSet
        '
        'viewstuschedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 341)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "viewstuschedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewstuschedule"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstituteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IT_TimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITcourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents InstituteDataSet As Management.instituteDataSet
    Friend WithEvents IT_TimeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IT_TimeTableAdapter As Management.instituteDataSetTableAdapters.IT_TimeTableAdapter
    Friend WithEvents TableAdapterManager As Management.instituteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ITcourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IT_courseTableAdapter As Management.instituteDataSetTableAdapters.IT_courseTableAdapter
    Friend WithEvents TimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Field1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MondayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TuesdayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WednesdayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThursdayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FridayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
