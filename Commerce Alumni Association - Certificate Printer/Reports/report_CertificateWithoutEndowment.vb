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

Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class report_CertificateWithoutEndowment

#Region "Constructor"
    Sub New(ByVal Item As data_Certificate)
        InitializeComponent()

        Me.ObjectDataSource.DataSource = Item
    End Sub
#End Region

#Region "Events"
    Private Sub pic_Student_BeforePrint(sender As Object, e As PrintEventArgs) Handles pic_Student.BeforePrint
        Dim pictureBox As XRPictureBox = TryCast(sender, XRPictureBox)
        Dim image As Image = pictureBox.Image
        Dim bmp As Bitmap = New Bitmap(pictureBox.Width - 10, pictureBox.Height - 10, Imaging.PixelFormat.Format32bppArgb)
        Dim r As Rectangle = New Rectangle((bmp.Width * 0.1) / 2, (bmp.Height * 0.1) / 2, bmp.Width - (bmp.Width * 0.1), bmp.Height - (bmp.Height * 0.1))

        Using g As Graphics = Graphics.FromImage(bmp)
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.CompositingQuality = CompositingQuality.HighQuality
            g.PixelOffsetMode = PixelOffsetMode.HighQuality

            Using pen As Pen = New Pen(pictureBox.BorderColor, 5)
                Dim path As GraphicsPath = New GraphicsPath()
                path.AddEllipse(r)
                Dim region As Region = New Region(path)
                g.DrawPath(pen, path)
                g.SetClip(region, CombineMode.Replace)
                g.DrawImage(image, r)
                g.DrawEllipse(pen, r)
            End Using
        End Using

        pictureBox.Image = bmp
    End Sub
#End Region


End Class