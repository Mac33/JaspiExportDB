Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid

Namespace PhotoViewer
    Partial Public Class MainForm
        Inherits RibbonForm
        Friend lockParentRibbonPageChanged As Integer
        Public Shared HoverSkinImageSize As Size = New Size(116, 86)
        Public Shared SkinImageSize As Size = New Size(58, 43)

        Dim f As frmData

        Public Sub New()
            InitializeComponent()
            mainRibbon.MdiMergeStyle = RibbonMdiMergeStyle.Always
            InitSkins()


        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
        End Sub




        Private Sub InitSkins()
            'SkinHelper.InitSkinGallery(skinGalleryBarItem, True)
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
        End Sub



        Private Sub rbLoad_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbLoad.ItemClick
            Dim oDialog As New OpenFileDialog

            oDialog.DefaultExt = "*.txt"
            oDialog.Filter = "*.txt|*.txt"
            oDialog.FileName = "x.txt"
            If oDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim parser As New Parse(oDialog.FileName)
                parser.FilterSimilar = Me.barFilterSimilar.Checked
                parser.Parse()
                f = New frmData()
                f.Parser = parser
                f.Text = oDialog.FileName
                AddHandler f.GridControl1.MainView.RowCountChanged, AddressOf Me.RowCountChanged
                f.MdiParent = Me
                f.DataSource = parser.Persons
                f.Show()
            End If



        End Sub

        Private Sub RowCountChanged(sender As Object, e As System.EventArgs)

            Dim grdv As GridView
            grdv = TryCast(sender, GridView)
            If grdv IsNot Nothing Then
                barCount.Caption = String.Format("Poèet záznamov {0} ", grdv.RowCount)
            End If

        End Sub


        Private Sub BarButtonItem1_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
            Me.Export("xlsx")
        End Sub

        Private Sub barPDF_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barPDF.ItemClick
            Me.Export("pdf")
        End Sub

        Private Sub barXLS_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barXLS.ItemClick
            Me.Export("xls")
        End Sub

        Private Sub barTXT_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barTXT.ItemClick
            Me.Export("txt")
        End Sub

        Private Sub Export(ByVal extension As String)

            Dim dlgSave As New SaveFileDialog()
            Dim actualFrm As frmData
            If documentManager.View.ActiveDocument IsNot Nothing Then


                actualFrm = TryCast(documentManager.View.ActiveDocument.Form, frmData)

                If actualFrm IsNot Nothing Then
                    dlgSave.DefaultExt = String.Format("*.{0}", extension)
                    dlgSave.AddExtension = True
                    dlgSave.Filter = String.Format("*.{0}|*.{0}", extension)
                    If dlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Try
                            If extension = "xls" Then
                                f.GridView1.ExportToXls(dlgSave.FileName)
                            End If
                            If extension = "xlsx" Then
                                f.GridView1.ExportToXlsx(dlgSave.FileName)
                            End If
                            If extension = "pdf" Then
                                f.GridView1.ExportToPdf(dlgSave.FileName)
                            End If
                            If extension = "txt" Then
                                f.GridView1.ExportToText(dlgSave.FileName)
                            End If
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                        
                    End If

                End If
            End If

        End Sub


      
       
       
        Private Sub barFilterSimilar_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barFilterSimilar.CheckedChanged
            For Each frm As frmData In Me.MdiChildren
                frm.Parser.FilterSimilar = Me.barFilterSimilar.Checked
                frm.Parser.Parse()
                f.DataSource = frm.Parser.Persons
                Me.RowCountChanged(f.GridControl1.MainView, Nothing)
            Next
        End Sub
    End Class
End Namespace
