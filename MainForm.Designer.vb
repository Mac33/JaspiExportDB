Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraTab
Namespace PhotoViewer
	Partial Public Class MainForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.applicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
            Me.mainRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.rbLoad = New DevExpress.XtraBars.BarButtonItem()
            Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barPDF = New DevExpress.XtraBars.BarButtonItem()
            Me.barXLS = New DevExpress.XtraBars.BarButtonItem()
            Me.barCount = New DevExpress.XtraBars.BarStaticItem()
            Me.barTXT = New DevExpress.XtraBars.BarButtonItem()
            Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
            Me.repRok = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.barActiv = New DevExpress.XtraBars.BarEditItem()
            Me.repAktiv = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.rbFile = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.defaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
            Me.galleryItemMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.barFilterSimilar = New DevExpress.XtraBars.BarCheckItem()
            CType(Me.applicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barAndDockingController, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repRok, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repAktiv, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.galleryItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'applicationMenu1
            '
            Me.applicationMenu1.Name = "applicationMenu1"
            Me.applicationMenu1.Ribbon = Me.mainRibbon
            '
            'mainRibbon
            '
            Me.mainRibbon.ApplicationButtonDropDownControl = Me.applicationMenu1
            Me.mainRibbon.ApplicationButtonText = Nothing
            Me.mainRibbon.Controller = Me.barAndDockingController
            '
            '
            '
            Me.mainRibbon.ExpandCollapseItem.Id = 0
            Me.mainRibbon.ExpandCollapseItem.Name = ""
            Me.mainRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mainRibbon.ExpandCollapseItem, Me.rbLoad, Me.BarButtonItem1, Me.barPDF, Me.barXLS, Me.barCount, Me.barTXT, Me.BarEditItem2, Me.barActiv, Me.barFilterSimilar})
            Me.mainRibbon.Location = New System.Drawing.Point(0, 0)
            Me.mainRibbon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.mainRibbon.MaxItemId = 48
            Me.mainRibbon.Name = "mainRibbon"
            Me.mainRibbon.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
            Me.mainRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rbFile})
            Me.mainRibbon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repRok, Me.repAktiv})
            Me.mainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.mainRibbon.Size = New System.Drawing.Size(1112, 149)
            Me.mainRibbon.StatusBar = Me.ribbonStatusBar1
            Me.mainRibbon.Toolbar.ItemLinks.Add(Me.barFilterSimilar)
            Me.mainRibbon.TransparentEditors = True
            '
            'rbLoad
            '
            Me.rbLoad.Caption = "Open"
            Me.rbLoad.Id = 33
            Me.rbLoad.LargeGlyph = Global.My.Resources.Resources.AddFolder_32x32
            Me.rbLoad.Name = "rbLoad"
            '
            'BarButtonItem1
            '
            Me.BarButtonItem1.Caption = "XLSX"
            Me.BarButtonItem1.Id = 37
            Me.BarButtonItem1.LargeGlyph = Global.My.Resources.Resources.xlsx
            Me.BarButtonItem1.Name = "BarButtonItem1"
            '
            'barPDF
            '
            Me.barPDF.Caption = "PDF"
            Me.barPDF.Id = 38
            Me.barPDF.LargeGlyph = Global.My.Resources.Resources.pdf
            Me.barPDF.Name = "barPDF"
            '
            'barXLS
            '
            Me.barXLS.Caption = "XLS"
            Me.barXLS.Id = 39
            Me.barXLS.LargeGlyph = Global.My.Resources.Resources.XLS
            Me.barXLS.Name = "barXLS"
            '
            'barCount
            '
            Me.barCount.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.barCount.Id = 40
            Me.barCount.Name = "barCount"
            Me.barCount.TextAlignment = System.Drawing.StringAlignment.Near
            '
            'barTXT
            '
            Me.barTXT.Caption = "TXT"
            Me.barTXT.Id = 41
            Me.barTXT.LargeGlyph = Global.My.Resources.Resources.txt__2_
            Me.barTXT.Name = "barTXT"
            '
            'BarEditItem2
            '
            Me.BarEditItem2.Caption = "Rok"
            Me.BarEditItem2.Edit = Me.repRok
            Me.BarEditItem2.EditValue = "2012"
            Me.BarEditItem2.Id = 43
            Me.BarEditItem2.Name = "BarEditItem2"
            '
            'repRok
            '
            Me.repRok.AutoHeight = False
            Me.repRok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repRok.Name = "repRok"
            Me.repRok.UseParentBackground = True
            '
            'barActiv
            '
            Me.barActiv.Caption = "Aktívny"
            Me.barActiv.Edit = Me.repAktiv
            Me.barActiv.Id = 44
            Me.barActiv.Name = "barActiv"
            '
            'repAktiv
            '
            Me.repAktiv.AutoHeight = False
            Me.repAktiv.Name = "repAktiv"
            Me.repAktiv.UseParentBackground = True
            '
            'rbFile
            '
            Me.rbFile.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
            Me.rbFile.Name = "rbFile"
            Me.rbFile.Text = "File"
            '
            'RibbonPageGroup1
            '
            Me.RibbonPageGroup1.ItemLinks.Add(Me.rbLoad)
            Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
            Me.RibbonPageGroup1.Text = "Load"
            '
            'RibbonPageGroup2
            '
            Me.RibbonPageGroup2.ItemLinks.Add(Me.barXLS)
            Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem1)
            Me.RibbonPageGroup2.ItemLinks.Add(Me.barPDF)
            Me.RibbonPageGroup2.ItemLinks.Add(Me.barTXT)
            Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
            Me.RibbonPageGroup2.Text = "Export"
            '
            'ribbonStatusBar1
            '
            Me.ribbonStatusBar1.ItemLinks.Add(Me.barCount)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 746)
            Me.ribbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.mainRibbon
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1112, 23)
            '
            'defaultToolTipController1
            '
            '
            '
            '
            Me.defaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            '
            'galleryItemMenu
            '
            Me.galleryItemMenu.Name = "galleryItemMenu"
            Me.galleryItemMenu.Ribbon = Me.mainRibbon
            '
            'dockManager
            '
            Me.dockManager.Controller = Me.barAndDockingController
            Me.dockManager.Form = Me
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            '
            'documentManager
            '
            Me.documentManager.BarAndDockingController = Me.barAndDockingController
            Me.documentManager.MdiParent = Me
            Me.documentManager.MenuManager = Me.mainRibbon
            Me.documentManager.View = Me.tabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView})
            '
            'barFilterSimilar
            '
            Me.barFilterSimilar.Caption = "Filter Similar"
            Me.barFilterSimilar.Id = 46
            Me.barFilterSimilar.Name = "barFilterSimilar"
            '
            'MainForm
            '
            Me.defaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1112, 769)
            Me.Controls.Add(Me.mainRibbon)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "MainForm"
            Me.Ribbon = Me.mainRibbon
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "JaspiExportDB"
            CType(Me.applicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainRibbon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barAndDockingController, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repRok, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repAktiv, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.galleryItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private defaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
        Private galleryItemMenu As DevExpress.XtraBars.PopupMenu
        Private applicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager
        Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private barAndDockingController As DevExpress.XtraBars.BarAndDockingController
        Private WithEvents mainRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
        Friend WithEvents rbLoad As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents rbFile As DevExpress.XtraBars.Ribbon.RibbonPage
        Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents barPDF As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barXLS As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barCount As DevExpress.XtraBars.BarStaticItem
        Friend WithEvents barTXT As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
        Friend WithEvents repRok As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Friend WithEvents barActiv As DevExpress.XtraBars.BarEditItem
        Friend WithEvents repAktiv As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents barFilterSimilar As DevExpress.XtraBars.BarCheckItem

	End Class
End Namespace
