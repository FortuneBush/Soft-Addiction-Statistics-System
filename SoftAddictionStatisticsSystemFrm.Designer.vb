<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SoftAddictionStatisticsSystemFrm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxCategoryManagement = New System.Windows.Forms.GroupBox()
        Me.lblRevise = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnRevise = New System.Windows.Forms.Button()
        Me.txtRevise = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rtxCategory = New System.Windows.Forms.ListBox()
        Me.lblCategoryName = New System.Windows.Forms.Label()
        Me.cboCategoryName = New System.Windows.Forms.ComboBox()
        Me.gbxCategory = New System.Windows.Forms.GroupBox()
        Me.rdoMoney = New System.Windows.Forms.RadioButton()
        Me.rdoTime = New System.Windows.Forms.RadioButton()
        Me.gbxTime = New System.Windows.Forms.GroupBox()
        Me.btnTimeSave = New System.Windows.Forms.Button()
        Me.dgvTime = New System.Windows.Forms.DataGridView()
        Me.类型 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.时长 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTimeDel = New System.Windows.Forms.Button()
        Me.btnTimeAdd = New System.Windows.Forms.Button()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.gbxMoney = New System.Windows.Forms.GroupBox()
        Me.btnMoneySave = New System.Windows.Forms.Button()
        Me.dgvMoney = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMoneyDel = New System.Windows.Forms.Button()
        Me.btnMoneyAdd = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cboMoney = New System.Windows.Forms.ComboBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.gbxCategoryManagement.SuspendLayout()
        Me.gbxCategory.SuspendLayout()
        Me.gbxTime.SuspendLayout()
        CType(Me.dgvTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxMoney.SuspendLayout()
        CType(Me.dgvMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxCategoryManagement
        '
        Me.gbxCategoryManagement.Controls.Add(Me.lblRevise)
        Me.gbxCategoryManagement.Controls.Add(Me.btnSave)
        Me.gbxCategoryManagement.Controls.Add(Me.btnDel)
        Me.gbxCategoryManagement.Controls.Add(Me.btnRevise)
        Me.gbxCategoryManagement.Controls.Add(Me.txtRevise)
        Me.gbxCategoryManagement.Controls.Add(Me.btnAdd)
        Me.gbxCategoryManagement.Controls.Add(Me.rtxCategory)
        Me.gbxCategoryManagement.Controls.Add(Me.lblCategoryName)
        Me.gbxCategoryManagement.Controls.Add(Me.cboCategoryName)
        Me.gbxCategoryManagement.Controls.Add(Me.gbxCategory)
        Me.gbxCategoryManagement.Location = New System.Drawing.Point(996, 13)
        Me.gbxCategoryManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxCategoryManagement.Name = "gbxCategoryManagement"
        Me.gbxCategoryManagement.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxCategoryManagement.Size = New System.Drawing.Size(328, 552)
        Me.gbxCategoryManagement.TabIndex = 0
        Me.gbxCategoryManagement.TabStop = False
        Me.gbxCategoryManagement.Text = "类别管理"
        '
        'lblRevise
        '
        Me.lblRevise.AutoSize = True
        Me.lblRevise.Location = New System.Drawing.Point(29, 407)
        Me.lblRevise.Name = "lblRevise"
        Me.lblRevise.Size = New System.Drawing.Size(67, 15)
        Me.lblRevise.TabIndex = 10
        Me.lblRevise.Text = "名称修改"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(225, 450)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 29)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(133, 450)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(69, 29)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "删除"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnRevise
        '
        Me.btnRevise.Location = New System.Drawing.Point(40, 450)
        Me.btnRevise.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRevise.Name = "btnRevise"
        Me.btnRevise.Size = New System.Drawing.Size(69, 29)
        Me.btnRevise.TabIndex = 6
        Me.btnRevise.Text = "修改"
        Me.btnRevise.UseVisualStyleBackColor = True
        '
        'txtRevise
        '
        Me.txtRevise.Location = New System.Drawing.Point(103, 402)
        Me.txtRevise.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRevise.Name = "txtRevise"
        Me.txtRevise.Size = New System.Drawing.Size(201, 25)
        Me.txtRevise.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(229, 146)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(69, 29)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "添加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'rtxCategory
        '
        Me.rtxCategory.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.rtxCategory.FormattingEnabled = True
        Me.rtxCategory.ItemHeight = 15
        Me.rtxCategory.Location = New System.Drawing.Point(19, 210)
        Me.rtxCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.rtxCategory.Name = "rtxCategory"
        Me.rtxCategory.Size = New System.Drawing.Size(297, 184)
        Me.rtxCategory.TabIndex = 3
        '
        'lblCategoryName
        '
        Me.lblCategoryName.AutoSize = True
        Me.lblCategoryName.Location = New System.Drawing.Point(50, 153)
        Me.lblCategoryName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Size = New System.Drawing.Size(45, 15)
        Me.lblCategoryName.TabIndex = 2
        Me.lblCategoryName.Text = "名称:"
        '
        'cboCategoryName
        '
        Me.cboCategoryName.FormattingEnabled = True
        Me.cboCategoryName.Location = New System.Drawing.Point(103, 149)
        Me.cboCategoryName.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCategoryName.Name = "cboCategoryName"
        Me.cboCategoryName.Size = New System.Drawing.Size(117, 23)
        Me.cboCategoryName.TabIndex = 1
        '
        'gbxCategory
        '
        Me.gbxCategory.Controls.Add(Me.rdoMoney)
        Me.gbxCategory.Controls.Add(Me.rdoTime)
        Me.gbxCategory.Location = New System.Drawing.Point(16, 54)
        Me.gbxCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxCategory.Name = "gbxCategory"
        Me.gbxCategory.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxCategory.Size = New System.Drawing.Size(301, 71)
        Me.gbxCategory.TabIndex = 0
        Me.gbxCategory.TabStop = False
        '
        'rdoMoney
        '
        Me.rdoMoney.AutoSize = True
        Me.rdoMoney.Location = New System.Drawing.Point(156, 25)
        Me.rdoMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMoney.Name = "rdoMoney"
        Me.rdoMoney.Size = New System.Drawing.Size(88, 19)
        Me.rdoMoney.TabIndex = 1
        Me.rdoMoney.Text = "金钱类别"
        Me.rdoMoney.UseVisualStyleBackColor = True
        '
        'rdoTime
        '
        Me.rdoTime.AutoSize = True
        Me.rdoTime.Checked = True
        Me.rdoTime.Location = New System.Drawing.Point(24, 26)
        Me.rdoTime.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTime.Name = "rdoTime"
        Me.rdoTime.Size = New System.Drawing.Size(88, 19)
        Me.rdoTime.TabIndex = 0
        Me.rdoTime.TabStop = True
        Me.rdoTime.Text = "时间类别"
        Me.rdoTime.UseVisualStyleBackColor = True
        '
        'gbxTime
        '
        Me.gbxTime.Controls.Add(Me.btnTimeSave)
        Me.gbxTime.Controls.Add(Me.dgvTime)
        Me.gbxTime.Controls.Add(Me.btnTimeDel)
        Me.gbxTime.Controls.Add(Me.btnTimeAdd)
        Me.gbxTime.Controls.Add(Me.txtDuration)
        Me.gbxTime.Controls.Add(Me.cboTime)
        Me.gbxTime.Controls.Add(Me.lblDuration)
        Me.gbxTime.Controls.Add(Me.lblTime)
        Me.gbxTime.Location = New System.Drawing.Point(13, 13)
        Me.gbxTime.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxTime.Name = "gbxTime"
        Me.gbxTime.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxTime.Size = New System.Drawing.Size(423, 552)
        Me.gbxTime.TabIndex = 1
        Me.gbxTime.TabStop = False
        Me.gbxTime.Text = "时间管理"
        '
        'btnTimeSave
        '
        Me.btnTimeSave.Location = New System.Drawing.Point(298, 91)
        Me.btnTimeSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTimeSave.Name = "btnTimeSave"
        Me.btnTimeSave.Size = New System.Drawing.Size(116, 29)
        Me.btnTimeSave.TabIndex = 9
        Me.btnTimeSave.Text = "保存"
        Me.btnTimeSave.UseVisualStyleBackColor = True
        '
        'dgvTime
        '
        Me.dgvTime.AllowUserToAddRows = False
        Me.dgvTime.AllowUserToDeleteRows = False
        Me.dgvTime.AllowUserToResizeColumns = False
        Me.dgvTime.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvTime.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTime.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.类型, Me.时长})
        Me.dgvTime.Location = New System.Drawing.Point(9, 128)
        Me.dgvTime.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTime.Name = "dgvTime"
        Me.dgvTime.RowHeadersWidth = 51
        Me.dgvTime.RowTemplate.Height = 23
        Me.dgvTime.Size = New System.Drawing.Size(404, 401)
        Me.dgvTime.TabIndex = 9
        '
        '类型
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.类型.DefaultCellStyle = DataGridViewCellStyle3
        Me.类型.HeaderText = "类型"
        Me.类型.MinimumWidth = 6
        Me.类型.Name = "类型"
        Me.类型.ReadOnly = True
        Me.类型.Width = 125
        '
        '时长
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.时长.DefaultCellStyle = DataGridViewCellStyle4
        Me.时长.HeaderText = "时长(单位:h)"
        Me.时长.MinimumWidth = 6
        Me.时长.Name = "时长"
        Me.时长.Width = 125
        '
        'btnTimeDel
        '
        Me.btnTimeDel.Location = New System.Drawing.Point(140, 91)
        Me.btnTimeDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTimeDel.Name = "btnTimeDel"
        Me.btnTimeDel.Size = New System.Drawing.Size(130, 29)
        Me.btnTimeDel.TabIndex = 8
        Me.btnTimeDel.Text = "删除"
        Me.btnTimeDel.UseVisualStyleBackColor = True
        '
        'btnTimeAdd
        '
        Me.btnTimeAdd.Location = New System.Drawing.Point(8, 91)
        Me.btnTimeAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTimeAdd.Name = "btnTimeAdd"
        Me.btnTimeAdd.Size = New System.Drawing.Size(100, 29)
        Me.btnTimeAdd.TabIndex = 7
        Me.btnTimeAdd.Text = "添加"
        Me.btnTimeAdd.UseVisualStyleBackColor = True
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(248, 38)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(132, 25)
        Me.txtDuration.TabIndex = 6
        '
        'cboTime
        '
        Me.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Location = New System.Drawing.Point(50, 40)
        Me.cboTime.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(117, 23)
        Me.cboTime.TabIndex = 5
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(203, 45)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(37, 15)
        Me.lblDuration.TabIndex = 4
        Me.lblDuration.Text = "时长"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(5, 43)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(37, 15)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "名称"
        '
        'gbxMoney
        '
        Me.gbxMoney.Controls.Add(Me.btnMoneySave)
        Me.gbxMoney.Controls.Add(Me.dgvMoney)
        Me.gbxMoney.Controls.Add(Me.btnMoneyDel)
        Me.gbxMoney.Controls.Add(Me.btnMoneyAdd)
        Me.gbxMoney.Controls.Add(Me.txtAmount)
        Me.gbxMoney.Controls.Add(Me.cboMoney)
        Me.gbxMoney.Controls.Add(Me.lblAmount)
        Me.gbxMoney.Controls.Add(Me.lblMoney)
        Me.gbxMoney.Location = New System.Drawing.Point(505, 13)
        Me.gbxMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxMoney.Name = "gbxMoney"
        Me.gbxMoney.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxMoney.Size = New System.Drawing.Size(423, 552)
        Me.gbxMoney.TabIndex = 2
        Me.gbxMoney.TabStop = False
        Me.gbxMoney.Text = "金钱管理"
        '
        'btnMoneySave
        '
        Me.btnMoneySave.Location = New System.Drawing.Point(299, 91)
        Me.btnMoneySave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMoneySave.Name = "btnMoneySave"
        Me.btnMoneySave.Size = New System.Drawing.Size(116, 29)
        Me.btnMoneySave.TabIndex = 9
        Me.btnMoneySave.Text = "保存"
        Me.btnMoneySave.UseVisualStyleBackColor = True
        '
        'dgvMoney
        '
        Me.dgvMoney.AllowUserToAddRows = False
        Me.dgvMoney.AllowUserToDeleteRows = False
        Me.dgvMoney.AllowUserToResizeColumns = False
        Me.dgvMoney.AllowUserToResizeRows = False
        Me.dgvMoney.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMoney.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMoney.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvMoney.Location = New System.Drawing.Point(11, 128)
        Me.dgvMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMoney.Name = "dgvMoney"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMoney.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMoney.RowHeadersWidth = 51
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvMoney.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMoney.RowTemplate.Height = 23
        Me.dgvMoney.Size = New System.Drawing.Size(404, 401)
        Me.dgvMoney.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "类型"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "金额(单位:元)"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'btnMoneyDel
        '
        Me.btnMoneyDel.Location = New System.Drawing.Point(146, 91)
        Me.btnMoneyDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMoneyDel.Name = "btnMoneyDel"
        Me.btnMoneyDel.Size = New System.Drawing.Size(117, 29)
        Me.btnMoneyDel.TabIndex = 8
        Me.btnMoneyDel.Text = "删除"
        Me.btnMoneyDel.UseVisualStyleBackColor = True
        '
        'btnMoneyAdd
        '
        Me.btnMoneyAdd.Location = New System.Drawing.Point(8, 91)
        Me.btnMoneyAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMoneyAdd.Name = "btnMoneyAdd"
        Me.btnMoneyAdd.Size = New System.Drawing.Size(100, 29)
        Me.btnMoneyAdd.TabIndex = 7
        Me.btnMoneyAdd.Text = "添加"
        Me.btnMoneyAdd.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(254, 35)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(132, 25)
        Me.txtAmount.TabIndex = 6
        '
        'cboMoney
        '
        Me.cboMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoney.FormattingEnabled = True
        Me.cboMoney.Location = New System.Drawing.Point(51, 37)
        Me.cboMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMoney.Name = "cboMoney"
        Me.cboMoney.Size = New System.Drawing.Size(117, 23)
        Me.cboMoney.TabIndex = 5
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(209, 41)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(37, 15)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "金额"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(8, 43)
        Me.lblMoney.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(37, 15)
        Me.lblMoney.TabIndex = 3
        Me.lblMoney.Text = "名称"
        '
        'btnTable
        '
        Me.btnTable.BackColor = System.Drawing.Color.LightBlue
        Me.btnTable.Font = New System.Drawing.Font("宋体", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnTable.Location = New System.Drawing.Point(530, 550)
        Me.btnTable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(361, 39)
        Me.btnTable.TabIndex = 3
        Me.btnTable.Text = "可视化时间金钱消费统计表"
        Me.btnTable.UseVisualStyleBackColor = False
        '
        'SoftAddictionStatisticsSystemFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1337, 614)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.gbxMoney)
        Me.Controls.Add(Me.gbxTime)
        Me.Controls.Add(Me.gbxCategoryManagement)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SoftAddictionStatisticsSystemFrm"
        Me.Text = "软瘾统计系统"
        Me.gbxCategoryManagement.ResumeLayout(False)
        Me.gbxCategoryManagement.PerformLayout()
        Me.gbxCategory.ResumeLayout(False)
        Me.gbxCategory.PerformLayout()
        Me.gbxTime.ResumeLayout(False)
        Me.gbxTime.PerformLayout()
        CType(Me.dgvTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxMoney.ResumeLayout(False)
        Me.gbxMoney.PerformLayout()
        CType(Me.dgvMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCategoryManagement As GroupBox
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents cboCategoryName As ComboBox
    Friend WithEvents gbxCategory As GroupBox
    Friend WithEvents rdoMoney As RadioButton
    Friend WithEvents rdoTime As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnRevise As Button
    Friend WithEvents txtRevise As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents rtxCategory As ListBox
    Friend WithEvents gbxTime As GroupBox
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents dgvTime As DataGridView
    Friend WithEvents btnTimeDel As Button
    Friend WithEvents btnTimeAdd As Button
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents btnTimeSave As Button
    Friend WithEvents gbxMoney As GroupBox
    Friend WithEvents btnMoneySave As Button
    Friend WithEvents dgvMoney As DataGridView
    Friend WithEvents btnMoneyDel As Button
    Friend WithEvents btnMoneyAdd As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cboMoney As ComboBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents btnTable As Button
    Friend WithEvents lblRevise As Label
    Friend WithEvents 类型 As DataGridViewTextBoxColumn
    Friend WithEvents 时长 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
