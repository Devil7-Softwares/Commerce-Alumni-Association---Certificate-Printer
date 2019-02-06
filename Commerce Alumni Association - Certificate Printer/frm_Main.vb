'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI

Partial Public Class frm_Main

#Region "Variables"
    Dim FileName As String = ""
    Dim Saved As Boolean = True
#End Region

#Region "Constructors"
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Properties"
    ReadOnly Property List As List(Of Objects.Item)
        Get
            If gc_List.DataSource Is Nothing Then gc_List.DataSource = New List(Of Objects.Item)
            Return CType(gc_List.DataSource, List(Of Objects.Item))
        End Get
    End Property
#End Region

#Region "Subs/Functions"
    Private Sub OpenFile(ByVal Filename As String)
        gc_List.DataSource = Objects.Item.LoadFromFile(Filename)
        gc_List.RefreshDataSource()
        Me.FileName = Filename
        Me.Saved = True
    End Sub

    Private Function GetReport(ByVal Item As Objects.Item) As XtraReport
        Dim TmpCourse As String = ""
        Select Case Item.Course
            Case Enums.Course.BCOM
                TmpCourse = "B.Com"
            Case Enums.Course.MCOM
                TmpCourse = "M.Com"
        End Select
        Dim TmpYear As String = ""
        Select Case Item.Year
            Case Enums.Year.PassedOut
                TmpYear = ""
            Case Enums.Year.FirstYear
                TmpYear = "I"
            Case Enums.Year.SecondYear
                TmpYear = "II"
            Case Enums.Year.ThirdYear
                TmpYear = "III"
        End Select
        Dim TmpShift As String = ""
        Select Case Item.Shift
            Case Enums.Shift.ShiftI
                TmpShift = "I-Shift"
            Case Enums.Shift.ShiftII
                TmpShift = "II-Shift"
        End Select

        Dim Course As String = ""
        If Item.Year = Enums.Year.PassedOut Then
            Course = TmpCourse
        Else
            If Item.Course = Enums.Course.BCOM Then
                Course = String.Format("{0}-{1} ({2})", TmpYear, TmpCourse, TmpShift)
            Else
                Course = String.Format("{0}-{1}", TmpYear, TmpCourse)
            End If
        End If

        Dim Data As New data_Certificate(Item.RegNo, Item.StudentName, Item.Batch, Course, TmpCourse, Item.EndowmentName, Item.Photo, Item.Date)

        If Item.EndowmentName = "" Then
            Return New report_CertificateWithoutEndowment(Data)
        Else
            Return New report_CertificateWithEndowment(Data)
        End If
    End Function
#End Region

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gc_List.DataSource = New List(Of Objects.Item)
    End Sub
#End Region

#Region "Application Menu Events"
    Private Sub btn_Open_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Open.ItemClick
        If Saved Then
OPEN:
            If dlg_OpenList.ShowDialog = DialogResult.OK Then
                OpenFile(dlg_OpenList.FileName)
            End If
        Else
            Dim Result As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Previous changes are unsaved! Do you want to save the changes..?", "Unsaved!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If Result = DialogResult.Yes Then
                btn_Save.PerformClick()
                GoTo OPEN
            ElseIf Result = DialogResult.No Then
                GoTo OPEN
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Save.ItemClick
        If Me.FileName = "" Then
            If dlg_SaveList.ShowDialog = DialogResult.OK Then
                Me.FileName = dlg_SaveList.FileName
            Else
                Exit Sub
            End If
        End If

        If Objects.Item.SaveToFile(Me.FileName, List) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Successfully saved file to selected location.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Saved = True
        End If
    End Sub

    Private Sub btn_SaveAs_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SaveAs.ItemClick
        If dlg_SaveList.ShowDialog = DialogResult.OK Then
            Me.FileName = dlg_SaveList.FileName
            If Objects.Item.SaveToFile(Me.FileName, List) Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Successfully saved file to selected location.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Saved = True
            End If
        End If
    End Sub

    Private Sub btn_Exit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Exit.ItemClick
        Me.Close()
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_List_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_List_Add.ItemClick
        Dim D As New frm_Item(Enums.DialogMode.Add)
        If D.ShowDialog = DialogResult.OK Then
            List.Add(D.Item)
            gc_List.RefreshDataSource()
            Saved = False
        End If
    End Sub

    Private Sub btn_List_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_List_Edit.ItemClick
        If gv_List.SelectedRowsCount = 1 Then
            Dim D As New frm_Item(Enums.DialogMode.Edit)
            D.Item = CType(gv_List.GetRow(gv_List.GetSelectedRows(0)), Objects.Item)
            If D.ShowDialog = DialogResult.OK Then
                gc_List.RefreshDataSource()
            End If
            Saved = False
        End If
    End Sub

    Private Sub btn_List_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_List_Remove.ItemClick
        If gv_List.SelectedRowsCount > 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Are you sure? Do you want to remove selected {0} item{1}", gv_List.SelectedRowsCount, If(gv_List.SelectedRowsCount > 1, "s", "")), "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Dim Items2Remove As New List(Of Objects.Item)
                For Each i As Integer In gv_List.GetSelectedRows
                    Items2Remove.Add(CType(gv_List.GetRow(i), Objects.Item))
                Next
                For Each Item As Objects.Item In Items2Remove
                    List.Remove(Item)
                Next
                gc_List.RefreshDataSource()
                Saved = False
            End If
        End If
    End Sub

    Private Sub btn_Export_Print_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Export_Print.ItemClick
        If gv_List.SelectedRowsCount = 1 Then
            Dim D As New frm_ReportViewer(GetReport(CType(gv_List.GetRow(gv_List.GetSelectedRows(0)), Objects.Item)))
            D.ShowDialog()
        End If
    End Sub
#End Region

End Class
