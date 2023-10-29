<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisualAnalysisFrm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chartTime = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartMoney = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTimeChart = New System.Windows.Forms.Label()
        Me.lblMoneyChart = New System.Windows.Forms.Label()
        CType(Me.chartTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartTime
        '
        Me.chartTime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.chartTime.BorderlineColor = System.Drawing.SystemColors.ActiveCaption
        ChartArea1.Name = "ChartArea1"
        Me.chartTime.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartTime.Legends.Add(Legend1)
        Me.chartTime.Location = New System.Drawing.Point(13, 72)
        Me.chartTime.Margin = New System.Windows.Forms.Padding(4)
        Me.chartTime.Name = "chartTime"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartTime.Series.Add(Series1)
        Me.chartTime.Size = New System.Drawing.Size(497, 491)
        Me.chartTime.TabIndex = 0
        Me.chartTime.Text = "Chart1"
        '
        'chartMoney
        '
        Me.chartMoney.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.chartMoney.BackImageTransparentColor = System.Drawing.Color.White
        Me.chartMoney.BackSecondaryColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        Me.chartMoney.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartMoney.Legends.Add(Legend2)
        Me.chartMoney.Location = New System.Drawing.Point(586, 67)
        Me.chartMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.chartMoney.Name = "chartMoney"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartMoney.Series.Add(Series2)
        Me.chartMoney.Size = New System.Drawing.Size(497, 496)
        Me.chartMoney.TabIndex = 1
        Me.chartMoney.Text = "Chart1"
        '
        'lblTimeChart
        '
        Me.lblTimeChart.AutoSize = True
        Me.lblTimeChart.Font = New System.Drawing.Font("宋体", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTimeChart.Location = New System.Drawing.Point(174, 29)
        Me.lblTimeChart.Name = "lblTimeChart"
        Me.lblTimeChart.Size = New System.Drawing.Size(125, 23)
        Me.lblTimeChart.TabIndex = 2
        Me.lblTimeChart.Text = "时间统计表"
        '
        'lblMoneyChart
        '
        Me.lblMoneyChart.AutoSize = True
        Me.lblMoneyChart.Font = New System.Drawing.Font("宋体", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMoneyChart.Location = New System.Drawing.Point(786, 29)
        Me.lblMoneyChart.Name = "lblMoneyChart"
        Me.lblMoneyChart.Size = New System.Drawing.Size(125, 23)
        Me.lblMoneyChart.TabIndex = 3
        Me.lblMoneyChart.Text = "金钱统计表"
        '
        'VisualAnalysisFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1096, 578)
        Me.Controls.Add(Me.lblMoneyChart)
        Me.Controls.Add(Me.lblTimeChart)
        Me.Controls.Add(Me.chartMoney)
        Me.Controls.Add(Me.chartTime)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "VisualAnalysisFrm"
        Me.Text = "可视化时间金钱消费统计表"
        CType(Me.chartTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chartTime As DataVisualization.Charting.Chart
    Friend WithEvents chartMoney As DataVisualization.Charting.Chart
    Friend WithEvents lblTimeChart As Label
    Friend WithEvents lblMoneyChart As Label
End Class
