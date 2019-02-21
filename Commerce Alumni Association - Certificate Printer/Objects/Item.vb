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

Namespace Objects
    Public Class Item

#Region "Properties/Fields"
        <DisplayName("Regisgration Number")>
        Property RegNo As String

        <DisplayName("Student Name")>
        Property StudentName As String

        Property Gender As Enums.Gender

        <DisplayName("Batch")>
        Property Batch As String

        <DisplayName("Course")>
        Property Course As Enums.Course

        <DisplayName("Year")>
        Property Year As Enums.Year

        <DisplayName("Shift")>
        Property Shift As Enums.Shift

        <DisplayName("Name of the Endowment")>
        Property EndowmentName As String

        <Browsable(False)>
        Property PhotoData As Byte()

        <Xml.Serialization.XmlIgnore>
        ReadOnly Property Photo As Image
            Get
                Dim R As Image = My.Resources.student
                Try
                    R = Image.FromStream(New IO.MemoryStream(PhotoData))
                Catch ex As Exception

                End Try
                Return R
            End Get
        End Property

        Property [Date] As Date
#End Region

#Region "Constructors"
        Sub New(ByVal RegNo As String, ByVal StudentName As String, ByVal Gender As Enums.Gender, ByVal Batch As String, ByVal Course As Enums.Course, ByVal Year As Enums.Year, ByVal Shift As Enums.Shift, ByVal EndowmentName As String, ByVal PhotoData As Byte(), ByVal [Date] As Date)
            Me.RegNo = RegNo
            Me.Batch = Batch
            Me.Course = Course
            Me.Year = Year
            Me.Shift = Shift
            Me.EndowmentName = EndowmentName
            Me.PhotoData = PhotoData
            Me.Date = [Date]
            Me.Gender = Gender
        End Sub

        Sub New()
            Me.RegNo = ""
            Me.StudentName = ""
            Me.Batch = ""
            Me.Course = Enums.Course.BCOM
            Me.Year = Enums.Year.PassedOut
            Me.Shift = Enums.Shift.ShiftI
            Me.EndowmentName = ""
            Me.PhotoData = Nothing
            Me.Date = Now
            Me.Gender = Enums.Gender.Male
        End Sub
#End Region

#Region "Shared Functions"
        Public Shared Function SaveToFile(ByVal Filename As String, ByVal List As List(Of Item)) As Boolean
            Try
                Using MS As New IO.FileStream(Filename, IO.FileMode.Create)
                    Dim Serializer As New XmlSerializer(GetType(List(Of Item)))
                    Serializer.Serialize(MS, List)
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Unable to save list to file!{0}{0}{1}", vbNewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            Return True
        End Function

        Public Shared Function LoadFromFile(ByVal Filename As String) As List(Of Item)
            Dim R As New List(Of Item)

            Try
                Using MS As New IO.MemoryStream(My.Computer.FileSystem.ReadAllBytes(Filename))
                    Dim Serializer As New XmlSerializer(GetType(List(Of Item)))
                    R = CType(Serializer.Deserialize(MS), List(Of Item))
                End Using
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Unable to load list from file!{0}{0}{1}", vbNewLine, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return R
        End Function
#End Region

    End Class
End Namespace