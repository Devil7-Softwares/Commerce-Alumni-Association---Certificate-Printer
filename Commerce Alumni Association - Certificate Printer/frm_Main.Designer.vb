Partial Public Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.menu_Ribbon = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.btn_Open = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Exit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_List_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_List_Edit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_List_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_Print = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_PDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_Word = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Export_JPG = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_List = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Export = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.gc_List = New DevExpress.XtraGrid.GridControl()
        Me.gv_List = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cv_List = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.dlg_OpenList = New System.Windows.Forms.OpenFileDialog()
        Me.dlg_SaveList = New System.Windows.Forms.SaveFileDialog()
        Me.btn_SaveAs = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cv_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.menu_Ribbon
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.btn_List_Add, Me.btn_List_Edit, Me.btn_List_Remove, Me.btn_Export_Print, Me.btn_Export_PDF, Me.btn_Export_Word, Me.btn_Export_JPG, Me.btn_Open, Me.btn_Save, Me.btn_Exit, Me.btn_SaveAs})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 13
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.ribbonControl.ShowCategoryInCaption = False
        Me.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(758, 143)
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        '
        'menu_Ribbon
        '
        Me.menu_Ribbon.ItemLinks.Add(Me.btn_Open)
        Me.menu_Ribbon.ItemLinks.Add(Me.btn_Save)
        Me.menu_Ribbon.ItemLinks.Add(Me.btn_SaveAs)
        Me.menu_Ribbon.ItemLinks.Add(Me.btn_Exit, True)
        Me.menu_Ribbon.Name = "menu_Ribbon"
        Me.menu_Ribbon.Ribbon = Me.ribbonControl
        '
        'btn_Open
        '
        Me.btn_Open.Caption = "Open"
        Me.btn_Open.Description = "Open List from File"
        Me.btn_Open.Id = 9
        Me.btn_Open.ImageOptions.SvgImage = CType(resources.GetObject("btn_Open.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Open.Name = "btn_Open"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Description = "Save List to File"
        Me.btn_Save.Id = 10
        Me.btn_Save.ImageOptions.SvgImage = CType(resources.GetObject("btn_Save.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_Exit
        '
        Me.btn_Exit.Caption = "Exit"
        Me.btn_Exit.Description = "Close All Forms & Exit Application"
        Me.btn_Exit.Id = 11
        Me.btn_Exit.ImageOptions.SvgImage = CType(resources.GetObject("btn_Exit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Exit.Name = "btn_Exit"
        '
        'btn_List_Add
        '
        Me.btn_List_Add.Caption = "Add"
        Me.btn_List_Add.Id = 1
        Me.btn_List_Add.ImageOptions.SvgImage = CType(resources.GetObject("btn_List_Add.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_List_Add.Name = "btn_List_Add"
        '
        'btn_List_Edit
        '
        Me.btn_List_Edit.Caption = "Edit"
        Me.btn_List_Edit.Id = 2
        Me.btn_List_Edit.ImageOptions.SvgImage = CType(resources.GetObject("btn_List_Edit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_List_Edit.Name = "btn_List_Edit"
        '
        'btn_List_Remove
        '
        Me.btn_List_Remove.Caption = "Remove"
        Me.btn_List_Remove.Id = 3
        Me.btn_List_Remove.ImageOptions.SvgImage = CType(resources.GetObject("btn_List_Remove.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_List_Remove.Name = "btn_List_Remove"
        '
        'btn_Export_Print
        '
        Me.btn_Export_Print.Caption = "Print"
        Me.btn_Export_Print.Id = 4
        Me.btn_Export_Print.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Print.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Print.Name = "btn_Export_Print"
        '
        'btn_Export_PDF
        '
        Me.btn_Export_PDF.Caption = "PDF"
        Me.btn_Export_PDF.Id = 5
        Me.btn_Export_PDF.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_PDF.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_PDF.Name = "btn_Export_PDF"
        '
        'btn_Export_Word
        '
        Me.btn_Export_Word.Caption = "Word"
        Me.btn_Export_Word.Id = 6
        Me.btn_Export_Word.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_Word.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_Word.Name = "btn_Export_Word"
        '
        'btn_Export_JPG
        '
        Me.btn_Export_JPG.Caption = "JPG"
        Me.btn_Export_JPG.Id = 7
        Me.btn_Export_JPG.ImageOptions.SvgImage = CType(resources.GetObject("btn_Export_JPG.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Export_JPG.Name = "btn_Export_JPG"
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_List, Me.rpg_Export})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_List
        '
        Me.rpg_List.ItemLinks.Add(Me.btn_List_Add)
        Me.rpg_List.ItemLinks.Add(Me.btn_List_Edit)
        Me.rpg_List.ItemLinks.Add(Me.btn_List_Remove)
        Me.rpg_List.Name = "rpg_List"
        Me.rpg_List.ShowCaptionButton = False
        Me.rpg_List.Text = "List"
        '
        'rpg_Export
        '
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_Print)
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_PDF, True)
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_Word)
        Me.rpg_Export.ItemLinks.Add(Me.btn_Export_JPG)
        Me.rpg_Export.Name = "rpg_Export"
        Me.rpg_Export.ShowCaptionButton = False
        Me.rpg_Export.Text = "Export"
        '
        'gc_List
        '
        Me.gc_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_List.Location = New System.Drawing.Point(0, 143)
        Me.gc_List.MainView = Me.gv_List
        Me.gc_List.MenuManager = Me.ribbonControl
        Me.gc_List.Name = "gc_List"
        Me.gc_List.Size = New System.Drawing.Size(758, 341)
        Me.gc_List.TabIndex = 1
        Me.gc_List.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_List, Me.cv_List})
        '
        'gv_List
        '
        Me.gv_List.GridControl = Me.gc_List
        Me.gv_List.Name = "gv_List"
        Me.gv_List.OptionsBehavior.Editable = False
        Me.gv_List.OptionsBehavior.ReadOnly = True
        Me.gv_List.OptionsSelection.MultiSelect = True
        '
        'cv_List
        '
        Me.cv_List.GridControl = Me.gc_List
        Me.cv_List.Name = "cv_List"
        Me.cv_List.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'dlg_OpenList
        '
        Me.dlg_OpenList.FileName = "Certificate Sudents List.certlist"
        Me.dlg_OpenList.Filter = "Certificate Printer List Files (*.certlist)|*.certlist"
        Me.dlg_OpenList.FilterIndex = 0
        '
        'dlg_SaveList
        '
        Me.dlg_SaveList.DefaultExt = "certlist"
        Me.dlg_SaveList.Filter = "Certificate Printer List Files (*.certlist)|*.certlist"
        '
        'btn_SaveAs
        '
        Me.btn_SaveAs.Caption = "Save As"
        Me.btn_SaveAs.Description = "Save File to Disk with New Name"
        Me.btn_SaveAs.Id = 12
        Me.btn_SaveAs.ImageOptions.SvgImage = CType(resources.GetObject("btn_SaveAs.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_SaveAs.Name = "btn_SaveAs"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 484)
        Me.Controls.Add(Me.gc_List)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.ribbonControl
        Me.Text = "Commerce Alumni Association - Certificate Printer"
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cv_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents rpg_List As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gc_List As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_List As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_List_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_List_Edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_List_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_Print As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_PDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_Word As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Export_JPG As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Export As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cv_List As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents menu_Ribbon As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents btn_Open As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Exit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dlg_OpenList As OpenFileDialog
    Friend WithEvents dlg_SaveList As SaveFileDialog
    Friend WithEvents btn_SaveAs As DevExpress.XtraBars.BarButtonItem
End Class
