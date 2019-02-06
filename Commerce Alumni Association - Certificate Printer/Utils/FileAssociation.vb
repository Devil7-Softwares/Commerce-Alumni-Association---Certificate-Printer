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

Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Utils
    Public Class FileAssociation

#Region "Public Functions"
        Public Shared Sub Associate(ByVal extension As String, ByVal progID As String, ByVal description As String, ByVal icon As String, ByVal application As String)
            If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
                Registry.ClassesRoot.CreateSubKey(extension).SetValue("", progID)

                If progID IsNot Nothing AndAlso progID.Length > 0 Then

                    Using key As RegistryKey = Registry.ClassesRoot.CreateSubKey(progID)
                        If description IsNot Nothing Then key.SetValue("", description)
                        If icon IsNot Nothing Then key.CreateSubKey("DefaultIcon").SetValue("", ToShortPathName(icon))
                        If application IsNot Nothing Then key.CreateSubKey("Shell\Open\Command").SetValue("", ToShortPathName(application) & " ""%1""")
                    End Using
                End If
            End If
        End Sub

        Public Shared Function IsAssociated(ByVal extension As String) As Boolean
            Return (Registry.ClassesRoot.OpenSubKey(extension, False) IsNot Nothing)
        End Function
#End Region

#Region "Private Functions"
        <DllImport("Kernel32.dll")>
        Private Shared Function GetShortPathName(ByVal lpszLongPath As String, <Out> ByVal lpszShortPath As StringBuilder, ByVal cchBuffer As UInteger) As UInteger
        End Function

        Private Shared Function ToShortPathName(ByVal longName As String) As String
            Dim s As StringBuilder = New StringBuilder(1000)
            Dim iSize As UInteger = CUInt(s.Capacity)
            Dim iRet As UInteger = GetShortPathName(longName, s, iSize)
            Return s.ToString()
        End Function
#End Region
    End Class
End Namespace