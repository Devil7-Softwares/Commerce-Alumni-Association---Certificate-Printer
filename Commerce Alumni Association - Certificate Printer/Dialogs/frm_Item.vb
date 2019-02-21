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

Public Class frm_Item

#Region "Variables"
    Dim DialogMode As Enums.DialogMode = Enums.DialogMode.Add
#End Region

#Region "Properties"
    Property Item As Objects.Item = Nothing
#End Region

#Region "Constructor"
    Sub New(ByVal DialogMode As Enums.DialogMode)
        InitializeComponent()

        Me.DialogMode = DialogMode
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Item_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i As Integer = Now.Year To 2000 Step -1
            txt_Batch.Properties.Items.Add(i)
        Next

        If DialogMode = Enums.DialogMode.Edit And Item IsNot Nothing Then
            txt_Batch.SelectedText = Item.Batch.Split("-")(0)
            txt_Course.SelectedIndex = Item.Course
            txt_EndowmentName.Text = Item.EndowmentName
            txt_RegNo.Text = Item.RegNo
            txt_Shift.SelectedIndex = Item.Shift
            txt_StudentName.Text = Item.StudentName
            txt_Year.SelectedIndex = Item.Year
            pic_Photo.Image = Item.Photo
            txt_Date.DateTime = Item.Date
            txt_Gender.SelectedIndex = Item.Gender
        Else
            txt_Batch.SelectedIndex = 0
            txt_Course.SelectedIndex = 0
            txt_Shift.SelectedIndex = 0
            txt_Year.SelectedIndex = 0
            txt_Date.DateTime = Now
            txt_Gender.SelectedIndex = 0
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
        If Item Is Nothing Then Item = New Objects.Item

        Dim Add As Integer = 0
        If txt_Year.SelectedIndex = 0 Then
            Add = If(txt_Course.SelectedIndex = 0, 3, 2)
        Else
            Add = 1
        End If

        Item.Batch = String.Format("{0}-{1}", txt_Batch.SelectedItem, CInt(txt_Batch.SelectedItem) + Add)
        Item.Course = txt_Course.SelectedIndex
        Item.EndowmentName = txt_EndowmentName.Text
        Item.RegNo = txt_RegNo.Text
        Item.Shift = txt_Shift.SelectedIndex
        Item.StudentName = txt_StudentName.Text
        Item.Year = txt_Year.SelectedIndex
        Item.Date = txt_Date.DateTime
        Item.Gender = txt_Gender.SelectedIndex
        Using MS As New IO.MemoryStream
            pic_Photo.Image.Save(MS, pic_Photo.Image.RawFormat)
            Item.PhotoData = MS.ToArray
        End Using

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btn_SelectImage_Click(sender As Object, e As EventArgs) Handles btn_SelectImage.Click
        If dlg_SelectImage.ShowDialog = DialogResult.OK Then
            pic_Photo.Image = Image.FromFile(dlg_SelectImage.FileName)
        End If
    End Sub

    Private Sub btn_ResetImage_Click(sender As Object, e As EventArgs) Handles btn_ResetImage.Click
        pic_Photo.Image = My.Resources.student
    End Sub
#End Region

End Class