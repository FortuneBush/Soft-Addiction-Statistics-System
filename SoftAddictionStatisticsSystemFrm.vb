Imports System.IO

Public Class SoftAddictionStatisticsSystemFrm
    Dim categoryList As List(Of String) = New List(Of String)
    Dim categoryFile As String = "category.txt"
    Dim timeFile As String = "time.txt"
    Dim moneyFile As String = "money.txt"

    Private Sub rdoTimetime_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTime.CheckedChanged
        Dim timeString() As String = {"拖延行为", "看电视", "工作", "饮食", "购物", "幻想", "抱怨", "沉迷网络"}
        rtxCategory.SelectedIndex = -1
        txtRevise.Text = ""
        cboCategoryName.Text = ""
        cboCategoryName.Items.Clear()
        cboCategoryName.Items.AddRange(timeString)
    End Sub

    Private Sub rdoMoney_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMoney.CheckedChanged
        Dim moneyString() As String = {"食物", "饮品", "购物", "游戏充值", "出行支出", "房租水电"}
        rtxCategory.SelectedIndex = -1
        txtRevise.Text = ""
        cboCategoryName.Text = ""
        cboCategoryName.Items.Clear()
        cboCategoryName.Items.AddRange(moneyString)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tmp As String = "金钱类型 "

        If cboCategoryName.Text <> "" Then
            If rdoTime.Checked Then
                tmp = "时间类型 "
            End If
            '分析S 是否已经在LBox中，如果在则直接退出
            Dim S = tmp + cboCategoryName.Text
            For i As Integer = 0 To rtxCategory.Items.Count - 1
                If rtxCategory.Items(i) = S Then
                    MsgBox("此项已经存在，不需要重复添加", vbOKOnly, "提示信息")
                    Exit Sub
                End If
            Next
            rtxCategory.Items.Add(S)
        End If
    End Sub

    Private Sub RichTextBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rtxCategory.SelectedIndexChanged
        If rtxCategory.SelectedIndex = -1 Then Exit Sub
        txtRevise.Text = Split(rtxCategory.Items(rtxCategory.SelectedIndex), Space(1))(1)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim tmp As String = "金钱类型 "
        If rdoTime.Checked Then
            tmp = "时间类型 "
        End If
        tmp += txtRevise.Text
        Dim i As Integer
        For i = 0 To rtxCategory.Items.Count - 1
            If rtxCategory.Items(i) = tmp Then
                Exit For
            End If
        Next
        If (rtxCategory.Items.Count = i) Then
            MsgBox("此项不存在，不能进行删除操作", vbOKOnly, "提示信息")
        Else
            rtxCategory.Items.RemoveAt(i)
            txtRevise.Text = ""
        End If
    End Sub

    Private Sub btnRevise_Click(sender As Object, e As EventArgs) Handles btnRevise.Click
        If txtRevise.Text = "" Then
            Exit Sub
        End If

        Dim tmp As String = "金钱类型 "
        If rdoTime.Checked Then
            tmp = "时间类型 "
        End If
        tmp += txtRevise.Text

        For i = 0 To rtxCategory.Items.Count - 1
            If rtxCategory.Items(i) = tmp Then
                MsgBox("已经存在，不能进行修改操作", vbOKOnly, "提示信息")
                Exit Sub
            End If
        Next

        rtxCategory.Items(rtxCategory.SelectedIndex) = tmp
        txtRevise.Text = ""

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If rtxCategory.Items.Count = 0 Then
            MsgBox("没有记录无需保存文件", vbOKOnly, "提示信息")
            Exit Sub
        End If
        Dim file As New StreamWriter(categoryFile)
        For i = 0 To rtxCategory.Items.Count - 1
            file.WriteLine(rtxCategory.Items(i))
        Next
        file.Close()
        cboCategoryName.Text = ""
        txtRevise.Text = ""
        MsgBox("保存文件成功", vbOKOnly, "提示信息")

        '刷新 时间与金钱的下列列表框的内容
        cboTime.Items.Clear()
        cboMoney.Items.Clear()
        categoryList = ReadFile(categoryFile)
        For Each category As String In categoryList
            If Mid(category, 1, 2) = "时间" Then
                cboTime.Items.Add(Split(category, Space(1))(1))
            Else
                cboMoney.Items.Add(Split(category, Space(1))(1))
            End If
        Next
    End Sub

    Private Function ReadFile(fileName As String) As List(Of String)
        Dim list As List(Of String) = New List(Of String)
        If Not System.IO.File.Exists(fileName) Then Return list
        Dim file As New StreamReader(fileName)
        Dim oneLine As String
        oneLine = file.ReadLine()
        While (oneLine <> "")
            list.Add(oneLine)
            oneLine = file.ReadLine()
        End While

        file.Close()

        Return list
    End Function

    Private Sub softAddictionStatisticsSystemFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '导入文件里所有的项
        categoryList = ReadFile(categoryFile)
        rtxCategory.Items.AddRange(categoryList.ToArray())
        For Each category As String In categoryList
            If Mid(category, 1, 2) = "时间" Then
                cboTime.Items.Add(Split(category, Space(1))(1))
            Else
                cboMoney.Items.Add(Split(category, Space(1))(1))
            End If
        Next

        timeList = ReadFile(timeFile)
        For Each time As String In timeList
            Dim tmp() As String
            tmp = Split(time, Space(1))
            dgvTime.Rows.Add(tmp)
        Next
        moneyList = ReadFile(moneyFile)
        For Each money As String In moneyList
            Dim tmp() As String
            tmp = Split(money, Space(1))
            dgvMoney.Rows.Add(tmp)
        Next

        dgvMoney.ClearSelection()
        dgvTime.ClearSelection()
    End Sub

    Private Sub btnTimeAdd_Click(sender As Object, e As EventArgs) Handles btnTimeAdd.Click
        If cboTime.Text = "" Then
            MsgBox("时间管理类型没有选择，请检查后重新操作", vbOKOnly, "提示信息")
            Exit Sub
        End If
        Dim result As Integer
        Dim bool As Boolean = Int32.TryParse(txtDuration.Text, result)
        If bool Then
            Dim row(1) As String
            row(0) = cboTime.Text
            row(1) = txtDuration.Text
            dgvTime.Rows.Add(row)
        Else
            MsgBox("时长输入信息有误，请检查后重新操作", vbOKOnly, "提示信息")
            Exit Sub
        End If
        dgvTime.ClearSelection()
    End Sub

    Private Sub btnTimeDel_Click(sender As Object, e As EventArgs) Handles btnTimeDel.Click
        For Each r As DataGridViewRow In dgvTime.SelectedRows
            If r.IsNewRow Then
                Exit For
            End If
            dgvTime.Rows.Remove(r)
        Next

        dgvTime.ClearSelection()
    End Sub

    Private Sub btnTimeSave_Click(sender As Object, e As EventArgs) Handles btnTimeSave.Click
        If dgvTime.Rows.Count = 0 Then
            MsgBox("没有记录无需保存文件", vbOKOnly, "提示信息")
            Exit Sub
        End If
        Dim file As New StreamWriter(timeFile)
        For Each r As DataGridViewRow In dgvTime.Rows
            If Not r.IsNewRow Then
                Dim tmp As String = ""
                tmp += r.Cells.Item(0).Value
                tmp += " "
                tmp += r.Cells.Item(1).Value
                file.WriteLine(tmp)
            End If
        Next

        file.Close()
        '更新timeList
        timeList = ReadFile(timeFile)
        MsgBox("保存文件成功", vbOKOnly, "提示信息")
    End Sub

    Private Sub btnMoneyAdd_Click(sender As Object, e As EventArgs) Handles btnMoneyAdd.Click
        If cboMoney.Text = "" Then
            MsgBox("金钱管理类型没有选择，请检查后重新操作", vbOKOnly, "提示信息")
            Exit Sub
        End If
        Dim result As Integer
        Dim bool As Boolean = Int32.TryParse(txtAmount.Text, result)
        If bool Then
            Dim row(1) As String
            row(0) = cboMoney.Text
            row(1) = txtAmount.Text
            dgvMoney.Rows.Add(row)
        Else
            MsgBox("金额输入信息有误，请检查后重新操作", vbOKOnly, "提示信息")
            Exit Sub
        End If

        dgvMoney.ClearSelection()
    End Sub

    Private Sub btnMoneyDel_Click(sender As Object, e As EventArgs) Handles btnMoneyDel.Click
        For Each r As DataGridViewRow In dgvMoney.SelectedRows
            If r.IsNewRow Then
                Exit For
            End If
            dgvMoney.Rows.Remove(r)
        Next

        dgvMoney.ClearSelection()
    End Sub

    Private Sub btnMoneySave_Click(sender As Object, e As EventArgs) Handles btnMoneySave.Click
        If dgvMoney.Rows.Count = 0 Then
            MsgBox("没有记录无需保存文件", vbOKOnly, "提示信息")
            Exit Sub
        End If
        Dim file As New StreamWriter(moneyFile)
        For Each r As DataGridViewRow In dgvMoney.Rows
            If Not r.IsNewRow Then
                Dim tmp As String = ""
                tmp += r.Cells.Item(0).Value
                tmp += " "
                tmp += r.Cells.Item(1).Value
                file.WriteLine(tmp)
            End If
        Next

        file.Close()
        '更新 moneyList
        moneyList = ReadFile(moneyFile)
        MsgBox("保存文件成功", vbOKOnly, "提示信息")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        Dim frm As Form = New VisualAnalysisFrm
        frm.Show()
    End Sub
End Class
