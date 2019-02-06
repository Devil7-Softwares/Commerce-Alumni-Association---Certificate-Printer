<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Item
    Inherits Utils.XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Item))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_RegNo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_StudentName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Batch = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Course = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Year = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Shift = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_EndowmentName = New DevExpress.XtraEditors.TextEdit()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Done = New DevExpress.XtraEditors.SimpleButton()
        Me.pic_Photo = New System.Windows.Forms.PictureBox()
        Me.btn_SelectImage = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_ResetImage = New DevExpress.XtraEditors.SimpleButton()
        Me.dlg_SelectImage = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_RegNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_StudentName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Batch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Course.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Year.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Shift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EndowmentName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.pic_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl9, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl10, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl11, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl12, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl13, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl14, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl15, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl16, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_RegNo, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_StudentName, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Batch, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Course, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Year, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Shift, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_EndowmentName, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(468, 407)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Registration Number"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 29)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Student Name"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(3, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Batch"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 81)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Course"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(3, 107)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Year"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(3, 133)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Shift"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(3, 159)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Endowment Name"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(3, 185)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Photo"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(107, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = ":"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(107, 29)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = ":"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(107, 55)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = ":"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(107, 81)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl12.TabIndex = 11
        Me.LabelControl12.Text = ":"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(107, 107)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl13.TabIndex = 12
        Me.LabelControl13.Text = ":"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(107, 133)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl14.TabIndex = 13
        Me.LabelControl14.Text = ":"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(107, 159)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl15.TabIndex = 14
        Me.LabelControl15.Text = ":"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(107, 185)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl16.TabIndex = 15
        Me.LabelControl16.Text = ":"
        '
        'txt_RegNo
        '
        Me.txt_RegNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_RegNo.Location = New System.Drawing.Point(117, 3)
        Me.txt_RegNo.Name = "txt_RegNo"
        Me.txt_RegNo.Size = New System.Drawing.Size(348, 20)
        Me.txt_RegNo.TabIndex = 0
        '
        'txt_StudentName
        '
        Me.txt_StudentName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_StudentName.Location = New System.Drawing.Point(117, 29)
        Me.txt_StudentName.Name = "txt_StudentName"
        Me.txt_StudentName.Size = New System.Drawing.Size(348, 20)
        Me.txt_StudentName.TabIndex = 1
        '
        'txt_Batch
        '
        Me.txt_Batch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Batch.Location = New System.Drawing.Point(117, 55)
        Me.txt_Batch.Name = "txt_Batch"
        Me.txt_Batch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Batch.Size = New System.Drawing.Size(348, 20)
        Me.txt_Batch.TabIndex = 2
        '
        'txt_Course
        '
        Me.txt_Course.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Course.Location = New System.Drawing.Point(117, 81)
        Me.txt_Course.Name = "txt_Course"
        Me.txt_Course.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Course.Properties.Items.AddRange(New Object() {"B.Com", "M.Com"})
        Me.txt_Course.Size = New System.Drawing.Size(348, 20)
        Me.txt_Course.TabIndex = 3
        '
        'txt_Year
        '
        Me.txt_Year.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Year.Location = New System.Drawing.Point(117, 107)
        Me.txt_Year.Name = "txt_Year"
        Me.txt_Year.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Year.Properties.Items.AddRange(New Object() {"Passed Out", "First Year", "Second Year", "Third Year"})
        Me.txt_Year.Size = New System.Drawing.Size(348, 20)
        Me.txt_Year.TabIndex = 4
        '
        'txt_Shift
        '
        Me.txt_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Shift.Location = New System.Drawing.Point(117, 133)
        Me.txt_Shift.Name = "txt_Shift"
        Me.txt_Shift.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Shift.Properties.Items.AddRange(New Object() {"Shift I", "Shift II"})
        Me.txt_Shift.Size = New System.Drawing.Size(348, 20)
        Me.txt_Shift.TabIndex = 5
        '
        'txt_EndowmentName
        '
        Me.txt_EndowmentName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_EndowmentName.Location = New System.Drawing.Point(117, 159)
        Me.txt_EndowmentName.Name = "txt_EndowmentName"
        Me.txt_EndowmentName.Size = New System.Drawing.Size(348, 20)
        Me.txt_EndowmentName.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pic_Photo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_SelectImage, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_ResetImage, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(117, 185)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(348, 219)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_Done)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 407)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(468, 43)
        Me.PanelControl1.TabIndex = 1
        '
        'btn_Done
        '
        Me.btn_Done.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Done.Location = New System.Drawing.Point(381, 5)
        Me.btn_Done.Name = "btn_Done"
        Me.btn_Done.Size = New System.Drawing.Size(75, 33)
        Me.btn_Done.TabIndex = 0
        Me.btn_Done.Text = "Done"
        '
        'pic_Photo
        '
        Me.pic_Photo.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.SetColumnSpan(Me.pic_Photo, 2)
        Me.pic_Photo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_Photo.Image = Global.Devil7.Automation.CertificatePrinter.My.Resources.Resources.student
        Me.pic_Photo.Location = New System.Drawing.Point(3, 3)
        Me.pic_Photo.Name = "pic_Photo"
        Me.pic_Photo.Size = New System.Drawing.Size(342, 178)
        Me.pic_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Photo.TabIndex = 0
        Me.pic_Photo.TabStop = False
        '
        'btn_SelectImage
        '
        Me.btn_SelectImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SelectImage.Location = New System.Drawing.Point(3, 187)
        Me.btn_SelectImage.Name = "btn_SelectImage"
        Me.btn_SelectImage.Size = New System.Drawing.Size(168, 29)
        Me.btn_SelectImage.TabIndex = 1
        Me.btn_SelectImage.Text = "Select Image"
        '
        'btn_ResetImage
        '
        Me.btn_ResetImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ResetImage.Location = New System.Drawing.Point(177, 187)
        Me.btn_ResetImage.Name = "btn_ResetImage"
        Me.btn_ResetImage.Size = New System.Drawing.Size(168, 29)
        Me.btn_ResetImage.TabIndex = 2
        Me.btn_ResetImage.TabStop = False
        Me.btn_ResetImage.Text = "Reset Image"
        '
        'dlg_SelectImage
        '
        Me.dlg_SelectImage.Filter = "Supported Image Formats|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        '
        'frm_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_RegNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_StudentName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Batch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Course.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Year.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Shift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EndowmentName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.pic_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_RegNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_StudentName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Batch As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Course As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Year As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Shift As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_EndowmentName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pic_Photo As PictureBox
    Friend WithEvents btn_SelectImage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ResetImage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Done As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dlg_SelectImage As OpenFileDialog
End Class
