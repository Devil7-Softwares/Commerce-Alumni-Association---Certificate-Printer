Imports System.ComponentModel

Namespace Objects
    Public Class Item

#Region "Properties/Fields"
        <DisplayName("Regisgration Number")>
        Property RegNo As String

        <DisplayName("Student Name")>
        Property StudentName As String

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
#End Region

#Region "Constructors"
        Sub New(ByVal RegNo As String, ByVal StudentName As String, ByVal Batch As String, ByVal Course As Enums.Course, ByVal Year As Enums.Year, ByVal Shift As Enums.Shift, ByVal EndowmentName As String, ByVal PhotoData As Byte())
            Me.RegNo = RegNo
            Me.Batch = Batch
            Me.Course = Course
            Me.Year = Year
            Me.Shift = Shift
            Me.EndowmentName = EndowmentName
            Me.PhotoData = PhotoData
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
        End Sub
#End Region

    End Class
End Namespace