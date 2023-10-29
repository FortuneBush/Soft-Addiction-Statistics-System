Imports System.Windows.Forms.DataVisualization.Charting

Public Class VisualAnalysisFrm
    Dim timeDictionary As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Dim moneyDictionary As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Dim timeDt As DataTable = New DataTable
    Dim moneyDt As DataTable = New DataTable

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each time As String In timeList
            Dim tmp() As String
            Dim key As String
            Dim value As Integer
            Dim resValue As Integer
            tmp = Split(time, Space(1))
            key = tmp(0)
            value = Integer.Parse(tmp(1))
            Dim bool As Boolean = timeDictionary.TryGetValue(key, resValue)
            If bool = True Then
                timeDictionary(key) = resValue + value
            Else
                timeDictionary.Add(key, value)
            End If
        Next

        timeDt.Columns.Add("分类", GetType(String))
        timeDt.Columns.Add("时长", GetType(Integer))
        For Each d In timeDictionary.Keys
            timeDt.Rows.Add(d, timeDictionary(d))
        Next

        chartTime.Series.Clear()

        Dim dataTable1Series As Series = New Series("dataTable1")
        dataTable1Series.Points.DataBind(timeDt.AsEnumerable(), "分类", "时长", "")
        dataTable1Series.XValueType = ChartValueType.String
        dataTable1Series.ChartType = SeriesChartType.Pie
        dataTable1Series.Label = "#VALh #PERCENT{P1}"
        dataTable1Series.LegendText = "#VALX"
        chartTime.Series.Add(dataTable1Series)

        For Each money As String In moneyList
            Dim tmp() As String
            Dim key As String
            Dim value As Integer
            Dim resValue As Integer
            tmp = Split(money, Space(1))
            key = tmp(0)
            value = Integer.Parse(tmp(1))
            Dim bool As Boolean = moneyDictionary.TryGetValue(key, resValue)
            If bool = True Then
                moneyDictionary(key) = resValue + value
            Else
                moneyDictionary.Add(key, value)
            End If
        Next

        moneyDt.Columns.Add("分类", GetType(String))
        moneyDt.Columns.Add("金额", GetType(Integer))
        For Each d In moneyDictionary.Keys
            moneyDt.Rows.Add(d, moneyDictionary(d))
        Next

        chartMoney.Series.Clear()
        Dim dataTable1Series1 As Series = New Series("dataTable1")
        dataTable1Series1.Points.DataBind(moneyDt.AsEnumerable(), "分类", "金额", "")
        dataTable1Series1.XValueType = ChartValueType.String
        dataTable1Series1.ChartType = SeriesChartType.Pie
        dataTable1Series1.Label = "#VAL元 #PERCENT{P1}"
        dataTable1Series1.LegendText = "#VALX"
        chartMoney.Series.Add(dataTable1Series1)
    End Sub
End Class