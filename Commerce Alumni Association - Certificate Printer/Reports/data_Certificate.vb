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

Imports System.ComponentModel
Imports System.Xml.Serialization

Public Class data_Certificate

#Region "Properties/Fields"
    <DisplayName("Regisgration Number")>
    Property RegNo As String

    <DisplayName("Student Name")>
    Property StudentName As String

    <DisplayName("Batch")>
    Property Batch As String

    <DisplayName("Course Detail")>
    Property CourseDetail As String

    <DisplayName("Course Name")>
    Property CourseName As String

    <DisplayName("Name of the Endowment")>
    Property EndowmentName As String

    Property Photo As Image

    Property [Date] As Date
#End Region

#Region "Constructors"
    Sub New(ByVal RegNo As String, ByVal StudentName As String, ByVal Batch As String, ByVal CourseDetail As String, ByVal CourseName As String, ByVal EndowmentName As String, ByVal Photo As Image, ByVal [Date] As Date)
        Me.RegNo = RegNo
        Me.StudentName = StudentName
        Me.Batch = Batch
        Me.CourseDetail = CourseDetail
        Me.CourseName = CourseName
        Me.EndowmentName = EndowmentName
        Me.Photo = Photo
        Me.Date = [Date]
    End Sub
#End Region

End Class