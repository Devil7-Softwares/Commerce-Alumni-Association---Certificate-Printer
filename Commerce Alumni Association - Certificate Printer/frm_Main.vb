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

Partial Public Class frm_Main

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

#Region "Form Events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gc_List.DataSource = New List(Of Objects.Item)
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_List_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_List_Add.ItemClick
        Dim D As New frm_Item(Enums.DialogMode.Add)
        If D.ShowDialog = DialogResult.OK Then
            List.Add(D.Item)
            gc_List.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_List_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_List_Edit.ItemClick
        If gv_List.SelectedRowsCount = 1 Then
            Dim D As New frm_Item(Enums.DialogMode.Edit)
            D.Item = CType(gv_List.GetRow(gv_List.GetSelectedRows(0)), Objects.Item)
            If D.ShowDialog = DialogResult.OK Then
                gc_List.RefreshDataSource()
            End If
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
            End If
        End If
    End Sub
#End Region

End Class
