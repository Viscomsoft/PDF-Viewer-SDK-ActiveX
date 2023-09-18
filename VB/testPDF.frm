VERSION 5.00
Object = "{49BEA983-661F-4F32-8793-E638A91989AF}#1.0#0"; "PDFViewer.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form Form1 
   Caption         =   "PDF Viewer Control"
   ClientHeight    =   9990
   ClientLeft      =   165
   ClientTop       =   555
   ClientWidth     =   16935
   LinkTopic       =   "Form1"
   ScaleHeight     =   9990
   ScaleWidth      =   16935
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtcustomzoom 
      Height          =   285
      Left            =   4320
      TabIndex        =   55
      Text            =   "1.0"
      Top             =   3480
      Width           =   615
   End
   Begin VB.CommandButton Command5 
      Caption         =   "Zoom"
      Height          =   375
      Left            =   2880
      TabIndex        =   54
      Top             =   3480
      Width           =   1095
   End
   Begin VB.CheckBox chkenablepanning 
      Caption         =   "Enable Panning"
      Height          =   375
      Left            =   3000
      TabIndex        =   53
      Top             =   240
      Value           =   1  'Checked
      Width           =   2055
   End
   Begin VB.TextBox txtsavebysizescale 
      Height          =   285
      Left            =   3600
      TabIndex        =   52
      Text            =   "2.0"
      Top             =   4680
      Width           =   615
   End
   Begin VB.TextBox txtsavebysizepageno 
      Enabled         =   0   'False
      Height          =   285
      Left            =   4560
      TabIndex        =   50
      Text            =   "1"
      Top             =   4680
      Width           =   615
   End
   Begin VB.CheckBox chksavebysizeallpage 
      Caption         =   "All Page"
      Height          =   255
      Left            =   3000
      TabIndex        =   48
      Top             =   4320
      Value           =   1  'Checked
      Width           =   1095
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Save Bitmaps By Size"
      Height          =   375
      Left            =   240
      TabIndex        =   47
      Top             =   4080
      Width           =   2535
   End
   Begin VB.CommandButton cmdfitwindow 
      Caption         =   "Fit Window"
      Height          =   375
      Left            =   2880
      TabIndex        =   46
      Top             =   2640
      Width           =   2535
   End
   Begin VB.Frame Frame5 
      Height          =   2655
      Left            =   240
      TabIndex        =   32
      Top             =   5040
      Width           =   4815
      Begin VB.CommandButton Command3 
         Caption         =   "Print (No UI)"
         Height          =   375
         Left            =   240
         TabIndex        =   45
         Top             =   2160
         Width           =   1455
      End
      Begin VB.CheckBox chkshowpagesetup 
         Caption         =   "Show Page Setup"
         Height          =   255
         Left            =   240
         TabIndex        =   42
         Top             =   1800
         Width           =   1695
      End
      Begin VB.Frame Frame6 
         Caption         =   "Page Orientation"
         Height          =   615
         Left            =   240
         TabIndex        =   39
         Top             =   960
         Width           =   3495
         Begin VB.OptionButton OptionLandscape 
            Caption         =   "Landscape"
            Height          =   255
            Left            =   1800
            TabIndex        =   41
            Top             =   240
            Width           =   1215
         End
         Begin VB.OptionButton OptionPortrait 
            Caption         =   "Portrait"
            Height          =   255
            Left            =   240
            TabIndex        =   40
            Top             =   240
            Width           =   1215
         End
      End
      Begin VB.TextBox txtpageto 
         Height          =   285
         Left            =   2640
         TabIndex        =   38
         Text            =   "1"
         Top             =   600
         Width           =   735
      End
      Begin VB.TextBox txtpagefrom 
         Height          =   285
         Left            =   1320
         TabIndex        =   36
         Text            =   "1"
         Top             =   600
         Width           =   495
      End
      Begin VB.ComboBox cboprinter 
         Height          =   315
         Left            =   960
         Style           =   2  'Dropdown List
         TabIndex        =   34
         Top             =   240
         Width           =   3375
      End
      Begin VB.Label LabelPrintStatus 
         Caption         =   "Nothing"
         Height          =   375
         Left            =   2400
         TabIndex        =   44
         Top             =   2040
         Width           =   1575
      End
      Begin VB.Label Label4 
         Caption         =   "Print Status"
         Height          =   255
         Left            =   2400
         TabIndex        =   43
         Top             =   1680
         Width           =   1335
      End
      Begin VB.Label Label7 
         Caption         =   "To"
         Height          =   255
         Left            =   2160
         TabIndex        =   37
         Top             =   600
         Width           =   495
      End
      Begin VB.Label Label6 
         Caption         =   "Page From"
         Height          =   255
         Left            =   120
         TabIndex        =   35
         Top             =   600
         Width           =   975
      End
      Begin VB.Label Label5 
         Caption         =   "Printer"
         Height          =   255
         Left            =   120
         TabIndex        =   33
         Top             =   240
         Width           =   615
      End
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Fit Height"
      Height          =   375
      Left            =   240
      TabIndex        =   31
      Top             =   3120
      Width           =   2535
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Fit Width"
      Height          =   375
      Left            =   240
      TabIndex        =   30
      Top             =   2640
      Width           =   2535
   End
   Begin VB.TextBox txtpassword 
      Height          =   285
      Left            =   1200
      TabIndex        =   27
      Top             =   840
      Width           =   855
   End
   Begin VB.Frame Frame4 
      Caption         =   "Rotate"
      Height          =   1095
      Left            =   2880
      TabIndex        =   20
      Top             =   840
      Width           =   2295
      Begin VB.OptionButton OptionRotate0 
         Caption         =   "0"
         Height          =   255
         Left            =   960
         TabIndex        =   25
         Top             =   720
         Width           =   615
      End
      Begin VB.OptionButton OptionRotate45 
         Caption         =   "45"
         Height          =   195
         Left            =   240
         TabIndex        =   24
         Top             =   720
         Width           =   615
      End
      Begin VB.OptionButton OptionRotate270 
         Caption         =   "270"
         Height          =   255
         Left            =   1680
         TabIndex        =   23
         Top             =   360
         Width           =   735
      End
      Begin VB.OptionButton OptionRotate180 
         Caption         =   "180"
         Height          =   255
         Left            =   960
         TabIndex        =   22
         Top             =   360
         Width           =   615
      End
      Begin VB.OptionButton OptionRotate90 
         Caption         =   "90"
         Height          =   255
         Left            =   240
         TabIndex        =   21
         Top             =   360
         Width           =   495
      End
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   1320
      Top             =   10200
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton nextpage 
      Caption         =   "Next Page"
      Height          =   375
      Left            =   8880
      TabIndex        =   19
      Top             =   10320
      Width           =   1815
   End
   Begin VB.CommandButton prevpage 
      Caption         =   "Previous Page"
      Height          =   375
      Left            =   6600
      TabIndex        =   18
      Top             =   10320
      Width           =   1815
   End
   Begin VB.Frame Frame3 
      Caption         =   "Go to Page"
      Height          =   975
      Left            =   5520
      TabIndex        =   15
      Top             =   9000
      Width           =   4095
      Begin VB.CommandButton go 
         Caption         =   "Go"
         Height          =   375
         Left            =   2400
         TabIndex        =   17
         Top             =   360
         Width           =   1335
      End
      Begin VB.TextBox pagetogo 
         Height          =   375
         Left            =   360
         TabIndex        =   16
         Top             =   360
         Width           =   1695
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Total Page"
      Height          =   1095
      Left            =   240
      TabIndex        =   13
      Top             =   7800
      Width           =   2415
      Begin VB.TextBox totalpage 
         Height          =   405
         Left            =   360
         TabIndex        =   14
         Top             =   360
         Width           =   1695
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Search Text"
      Height          =   2175
      Left            =   2760
      TabIndex        =   8
      Top             =   7800
      Width           =   2655
      Begin VB.CheckBox chkhighlightallmatch 
         Caption         =   "Highlight All Matched Text"
         Height          =   255
         Left            =   240
         TabIndex        =   57
         Top             =   240
         Width           =   2295
      End
      Begin VB.CommandButton search 
         Caption         =   "Search"
         Height          =   375
         Left            =   240
         TabIndex        =   12
         Top             =   1320
         Width           =   1935
      End
      Begin VB.OptionButton down 
         Caption         =   "Down"
         Height          =   375
         Left            =   1200
         TabIndex        =   11
         Top             =   960
         Value           =   -1  'True
         Width           =   855
      End
      Begin VB.OptionButton up 
         Caption         =   "Up"
         Height          =   375
         Left            =   240
         TabIndex        =   10
         Top             =   960
         Width           =   855
      End
      Begin VB.TextBox searchtext 
         Height          =   375
         Left            =   120
         TabIndex        =   9
         Top             =   600
         Width           =   2175
      End
      Begin VB.Label lblsearchtextmsg 
         Caption         =   "Found Text at Page 1"
         Height          =   255
         Left            =   240
         TabIndex        =   58
         Top             =   1800
         Width           =   2295
      End
   End
   Begin VB.CommandButton print 
      Caption         =   "Print (Print Dialog)"
      Height          =   375
      Left            =   240
      TabIndex        =   7
      Top             =   4560
      Width           =   2535
   End
   Begin VB.CommandButton savebitmaps 
      Caption         =   "Save Bitmaps"
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   3600
      Width           =   2535
   End
   Begin VB.CommandButton originalsize 
      Caption         =   "Original Size"
      Height          =   375
      Left            =   2880
      TabIndex        =   5
      Top             =   2160
      Width           =   2535
   End
   Begin VB.CommandButton zoomout 
      Caption         =   "Zoom Out"
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   2160
      Width           =   2535
   End
   Begin VB.CommandButton zoomin 
      Caption         =   "Zoom In"
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Top             =   1680
      Width           =   2535
   End
   Begin VB.CommandButton backgroudcolor 
      Caption         =   "Backgroud Color"
      Height          =   375
      Left            =   240
      TabIndex        =   2
      Top             =   1200
      Width           =   2535
   End
   Begin VB.CommandButton open 
      Caption         =   "Open"
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   120
      Width           =   2535
   End
   Begin PDFViewerLib.PDFViewer PDFViewer1 
      Height          =   8775
      Left            =   5520
      TabIndex        =   0
      Top             =   120
      Width           =   11175
      _Version        =   65536
      _ExtentX        =   19711
      _ExtentY        =   15478
      _StockProps     =   0
   End
   Begin VB.Label Label10 
      Caption         =   "1.0 = 100%"
      Height          =   375
      Left            =   4320
      TabIndex        =   56
      Top             =   3120
      Width           =   855
   End
   Begin VB.Label Label9 
      Caption         =   "Scale"
      Height          =   375
      Left            =   3000
      TabIndex        =   51
      Top             =   4680
      Width           =   495
   End
   Begin VB.Label Label8 
      Caption         =   "Page"
      Height          =   255
      Left            =   4560
      TabIndex        =   49
      Top             =   4320
      Width           =   495
   End
   Begin VB.Label Label3 
      Caption         =   "For open password protected PDF "
      Height          =   255
      Left            =   240
      TabIndex        =   29
      Top             =   600
      Width           =   2655
   End
   Begin VB.Label Label2 
      Caption         =   "password protected PDF "
      Height          =   15
      Left            =   360
      TabIndex        =   28
      Top             =   720
      Width           =   1695
   End
   Begin VB.Label Label1 
      Caption         =   "Password"
      Height          =   255
      Left            =   240
      TabIndex        =   26
      Top             =   840
      Width           =   735
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub backgroudcolor_Click()
Me.CommonDialog1.ShowColor
Me.PDFViewer1.backgroudcolor = CommonDialog1.Color
End Sub

Private Sub chkenablepanning_Click()

If chkenablepanning.Value = 1 Then
    PDFViewer1.EnablePanning = True
Else
    PDFViewer1.EnablePanning = False
End If


End Sub

Private Sub chkhighlightallmatch_Click()
If Me.chkhighlightallmatch.Value = 1 Then
    PDFViewer1.HighlightAllMatchedText = True
Else
    PDFViewer1.HighlightAllMatchedText = False

End If

End Sub

Private Sub chksavebysizeallpage_Click()

If Me.chksavebysizeallpage.Value = 1 Then
    txtsavebysizepageno.Enabled = False
 
Else

    txtsavebysizepageno.Enabled = True
    
End If


End Sub

Private Sub cmdfitwindow_Click()
Me.PDFViewer1.FitWindow
End Sub

Private Sub Command1_Click()
Me.PDFViewer1.FitWidth

End Sub

Private Sub Command2_Click()
PDFViewer1.FitHeight
End Sub

Private Sub Command3_Click()
  PDFViewer1.PrinterSetPrinterName (cboprinter.Text)

        If Me.OptionPortrait.Value = 1 Then
            PDFViewer1.PrinterSetPageOrientation (0)
        Else
            PDFViewer1.PrinterSetPageOrientation (1)
        End If
        
        If chkshowpagesetup.Value = 1 Then
            PDFViewer1.PrinterShowPageSetupDlg (Me.hWnd)
        End If

        PDFViewer1.PrinterSetPageRange txtpagefrom.Text, Me.txtpageto.Text
        PDFViewer1.PDFPrint

End Sub

Private Sub Command4_Click()

If Me.chksavebysizeallpage.Value = 1 Then

Form2.Show 1
 strSelPath = Form2.Dir1.Path
   
   If strSelPath <> "" Then
        Me.PDFViewer1.SaveBitmapsBySize strSelPath, -1, txtsavebysizescale.Text
   End If
   

Else
    Me.CommonDialog1.Filter = "BMP File (*.bmp)|*.bmp"
    Me.CommonDialog1.ShowSave
    
    Me.PDFViewer1.SaveBitmapsBySize CommonDialog1.FileName, txtsavebysizepageno.Text, txtsavebysizescale.Text
    

End If


End Sub

Private Sub Command5_Click()
PDFViewer1.Zoom = txtcustomzoom.Text
End Sub

Private Sub Form_Load()

 For i = 0 To PDFViewer1.PrinterCount - 1
            cboprinter.AddItem (PDFViewer1.PrinterName(i))
        Next

        If cboprinter.ListCount > 0 Then
            cboprinter.ListIndex = 0
        End If


End Sub

Private Sub go_Click()
Me.PDFViewer1.GoToPage Me.pagetogo.Text
End Sub

Private Sub nextpage_Click()
Me.PDFViewer1.GoToNextPage
End Sub

Private Sub open_Click()
Me.CommonDialog1.Filter = "PDF Files (*.pdf)|*.pdf|All Files(*.*)|*.*"
Me.CommonDialog1.ShowOpen

If txtpassword.Text <> "" Then
        Me.PDFViewer1.Password = txtpassword.Text
End If

Me.PDFViewer1.LoadPDFFile CommonDialog1.FileName

If PDFViewer1.IsEncrypted And txtpassword.Text = "" Then
    MsgBox "PDF file is protected, please input password"
End If

Me.totalpage.Text = PDFViewer1.totalpage
Me.txtpageto.Text = PDFViewer1.PrinterGetPageCount
 
End Sub

Private Sub OptionRotate0_Click()
Me.PDFViewer1.RotateAngle = 0

End Sub

Private Sub OptionRotate180_Click()
Me.PDFViewer1.RotateAngle = 180

End Sub

Private Sub OptionRotate270_Click()
Me.PDFViewer1.RotateAngle = 270

End Sub

Private Sub OptionRotate45_Click()
Me.PDFViewer1.RotateAngle = 45

End Sub

Private Sub OptionRotate90_Click()
Me.PDFViewer1.RotateAngle = 90

End Sub

Private Sub originalsize_Click()
Me.PDFViewer1.ShowOriginalSize
End Sub

Private Sub PDFViewer1_OnPrint(ByVal iPage As Integer, ByVal iTotalPage As Integer, ByVal bIsFinish As Boolean)
        If bIsFinish Then
            LabelPrintStatus.Caption = "Printing Finished"

        Else
            LabelPrintStatus.Caption = "Printing Page " + Trim(Str(iPage)) + " of " + Trim(Str(iTotalPage))

        End If
End Sub

Private Sub prevpage_Click()
Me.PDFViewer1.GoToPrevPage
End Sub

Private Sub print_Click()

 Me.PDFViewer1.PrinterShowPrintDlg (Me.hWnd)
 Me.PDFViewer1.PDFPrint
        
End Sub



Private Sub savebitmaps_Click()
 Form2.Show 1
 strSelPath = Form2.Dir1.Path
   
   If strSelPath <> "" Then
        Me.PDFViewer1.savebitmaps strSelPath
   End If
   
  
End Sub

Private Sub search_Click()
Dim iPage As Integer
If Me.up.Value = True Then
  iPage = Me.PDFViewer1.SearchPrevText
End If
If Me.down.Value = True Then
  iPage = Me.PDFViewer1.SearchNextText
End If




        If iPage < 0 Then
           lblsearchtextmsg.Caption = "No Matches were found"

        Else
            lblsearchtextmsg.Caption = "Found text at page " + Trim(Str(iPage))
        End If
End Sub

Private Sub searchtext_Change()
Dim iPage As Integer

iPage = Me.PDFViewer1.search(searchtext.Text, False)


        If iPage < 0 Then
           lblsearchtextmsg.Caption = "No Matches were found"

        Else
            lblsearchtextmsg.Caption = "Found text at page " + Trim(Str(iPage))
        End If
        
End Sub

Private Sub zoomin_Click()
Me.PDFViewer1.PDFZoomIn
End Sub

Private Sub zoomout_Click()
Me.PDFViewer1.PDFZoomOut
End Sub
