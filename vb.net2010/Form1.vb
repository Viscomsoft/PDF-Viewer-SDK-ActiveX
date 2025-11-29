Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim iResult As Integer
        OpenFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        AxPDFViewer1.EnablePanning = chkpanning.Checked


        If Me.OpenFileDialog1.ShowDialog() = DialogResult.OK Then


            If TextBoxPassword.Text <> "" Then

                Me.AxPDFViewer1.Password = TextBoxPassword.Text

            End If


            iResult = Me.AxPDFViewer1.LoadPDFFile(Me.OpenFileDialog1.FileName)
            If iResult = -1 Then
                MessageBox.Show("Load Failed")
                Exit Sub
            End If

            If iResult = -2 Then
                MessageBox.Show("Password is not correct")
                Exit Sub
            End If

            If AxPDFViewer1.IsEncrypted And TextBoxPassword.Text = "" Then
                MessageBox.Show("This PDF is protected, Please input password")
            End If

            Me.TextBox3.Text = Me.AxPDFViewer1.TotalPage

            Me.txtprintto.Text = Me.AxPDFViewer1.PrinterGetPageCount
            RefreshPageNumber()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.AxPDFViewer1.GoToPrevPage()
        RefreshPageNumber()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.AxPDFViewer1.GoToNextPage()
        RefreshPageNumber()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.AxPDFViewer1.GoToPage(TextBox1.Text)
        RefreshPageNumber()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim iPage As Integer
        iPage = 0
        If chkcopytexttoclipboard.Checked Then
            AxPDFViewer1.SearchedTextToClipboard = True
        Else
            AxPDFViewer1.SearchedTextToClipboard = False
        End If


        If (Me.RadioButton1.Checked = True) Then
            iPage = Me.AxPDFViewer1.SearchPrevText
            If (iPage < 0) Then
                lblsearchtextmsg.Text = "No Matches were found"
            Else
                lblsearchtextmsg.Text = "Found text at page " + iPage.ToString()
            End If
        End If
        If (Me.RadioButton2.Checked = True) Then
            iPage = AxPDFViewer1.SearchNextText()
            If (iPage < 0) Then
                lblsearchtextmsg.Text = "No Matches were found"
            Else
                lblsearchtextmsg.Text = "Found text at page " + iPage.ToString()
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Me.AxPDFViewer1.SearchPrevText() < 0) Then
            MessageBox.Show("Can't search text")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Me.AxPDFViewer1.SearchNextText() < 0) Then
            MessageBox.Show("Can't search text")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
    

        Me.AxPDFViewer1.PDFZoomIn()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
     
        Me.AxPDFViewer1.PDFZoomOut()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.AxPDFViewer1.ShowOriginalSize()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.AxPDFViewer1.SaveBitmaps(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.AxPDFViewer1.PrinterShowPrintDlg(Me.Handle)
        Me.AxPDFViewer1.PDFPrint()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Me.ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.AxPDFViewer1.BackGroudColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim iPage As Integer = 0

        If chkcopytexttoclipboard.Checked Then
            AxPDFViewer1.SearchedTextToClipboard = True
        Else
            AxPDFViewer1.SearchedTextToClipboard = False
        End If

        iPage = AxPDFViewer1.Search(TextBox2.Text, False)

        If iPage < 0 Then
            lblsearchtextmsg.Text = "No Matches were found"

        Else
            lblsearchtextmsg.Text = "Found text at page " + iPage.ToString()
        End If

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub OptionRotate90_Click(sender As System.Object, e As System.EventArgs) Handles OptionRotate90.Click
        Me.AxPDFViewer1.RotateAngle = 90

    End Sub

    Private Sub OptionRotate180_Click(sender As System.Object, e As System.EventArgs) Handles OptionRotate180.Click
        Me.AxPDFViewer1.RotateAngle = 180
    End Sub

    Private Sub OptionRotate270_Click(sender As System.Object, e As System.EventArgs) Handles OptionRotate270.Click
        Me.AxPDFViewer1.RotateAngle = 270
    End Sub

    Private Sub OptionRotate45_Click(sender As System.Object, e As System.EventArgs) Handles OptionRotate45.Click
        Me.AxPDFViewer1.RotateAngle = 45
    End Sub

    Private Sub OptionRotate0_Click(sender As System.Object, e As System.EventArgs) Handles OptionRotate0.Click
        Me.AxPDFViewer1.RotateAngle = 0
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AxPDFViewer1.FitWidth()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        AxPDFViewer1.FitHeight()
    End Sub

    Private Sub txtPageNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblprintstatus.Click

    End Sub

    Private Sub RefreshPageNumber()
        lblcurrentpage.Text = "Current Page:" + AxPDFViewer1.GetCurrentPage().ToString()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboencryptmode.Items.Add("RC4 40 bit")
        cboencryptmode.Items.Add("RC4 128 bit")
        cboencryptmode.Items.Add("AES 128 bit")
        cboencryptmode.Items.Add("AES 256 bit")
        cboencryptmode.SelectedIndex = 0

        For i = 0 To AxPDFViewer1.PrinterCount - 1
            cboprinter.Items.Add(AxPDFViewer1.PrinterName(i))
        Next

        If cboprinter.Items.Count > 0 Then
            cboprinter.SelectedIndex = 0
        End If

        cboExportTextType.Items.Add("UTF8 Text File")
        cboExportTextType.Items.Add("XML File")
        cboExportTextType.Items.Add("HTML File")
        cboExportTextType.SelectedIndex = 0


    End Sub

    Private Sub Button6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        AxPDFViewer1.PrinterSetPrinterName(cboprinter.Text)

        If RadioButtonPortrait.Checked Then
            AxPDFViewer1.PrinterSetPageOrientation(0)
        Else
            AxPDFViewer1.PrinterSetPageOrientation(1)
        End If
        If chkshowpagesetup.Checked Then
            AxPDFViewer1.PrinterShowPageSetupDlg(Me.Handle)
        End If

        AxPDFViewer1.PrinterSetPageRange(Me.txtprintfrom.Text, Me.txtprintto.Text)
        AxPDFViewer1.PDFPrint()
    End Sub

    Private Sub AxPDFViewer1_OnPrint(ByVal sender As System.Object, ByVal e As AxPDFViewerLib._DPDFViewerEvents_OnPrintEvent) Handles AxPDFViewer1.OnPrint


        If e.bIsFinish Then
            lblprintstatus.Text = "Printing Finished"

        Else
            lblprintstatus.Text = "Printing Page " + Trim(Str(e.iPage)) + " of " + Trim(Str(e.iTotalPage))

        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub BtnFitWindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFitWindow.Click
        Me.AxPDFViewer1.FitWindow()
    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If chksavebitmapbysizeallpage.Checked Then

            If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.AxPDFViewer1.SaveBitmapsBySize(FolderBrowserDialog1.SelectedPath, -1, txtsavescale.Text)

            End If
        Else
            SaveFileDialog1.Filter = "BMP file (*.bmp)|*.bmp||"
            SaveFileDialog1.DefaultExt = "bmp"

            SaveFileDialog1.ShowDialog()
            Me.AxPDFViewer1.SaveBitmapsBySize(SaveFileDialog1.FileName, txtsavebitmapbysizepageno.Text, txtsavescale.Text)

        End If
    End Sub

    Private Sub chksavebitmapbysizeallpage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksavebitmapbysizeallpage.CheckedChanged
        If chksavebitmapbysizeallpage.Checked Then
            txtsavebitmapbysizepageno.Enabled = False
        Else
            txtsavebitmapbysizepageno.Enabled = True

        End If

    End Sub

    Private Sub chkpanning_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpanning.CheckedChanged

        If AxPDFViewer1.Handle() <> 0 Then

            If chkpanning.Checked Then
                AxPDFViewer1.EnablePanning = True
            Else
                AxPDFViewer1.EnablePanning = False

            End If
        End If

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        AxPDFViewer1.Zoom = txtcustomzoom.Text
    End Sub

    Private Sub btnExportText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportText.Click
        If cboExportTextType.SelectedIndex = 0 Then
            SaveFileDialog1.Filter = "Text file (*.txt)|*.txt||"
            SaveFileDialog1.DefaultExt = "txt"
        ElseIf cboExportTextType.SelectedIndex = 1 Then
            SaveFileDialog1.Filter = "XML file (*.xml)|*.xml||"
            SaveFileDialog1.DefaultExt = "xml"
        ElseIf cboExportTextType.SelectedIndex = 2 Then
            SaveFileDialog1.Filter = "Html file (*.html)|*.html||"
            SaveFileDialog1.DefaultExt = "html"

        End If



        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            AxPDFViewer1.ExportText(SaveFileDialog1.FileName, TextBox1.Text, cboExportTextType.SelectedIndex)
        End If

    End Sub

    Private Sub chkhighlightallmatch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhighlightallmatch.CheckedChanged
        If chkhighlightallmatch.Checked Then
            AxPDFViewer1.HighlightAllMatchedText = True
        Else
            AxPDFViewer1.HighlightAllMatchedText = False

        End If
    End Sub

    Private Sub ChangePage(ByVal iDelta As Integer)
        If (iDelta > 0) Then 'wheel up

            AxPDFViewer1.GoToPrevPage()


        Else

            AxPDFViewer1.GoToNextPage()

        End If

    End Sub

    Private Sub AxPDFViewer1_OnMouseWheel(ByVal sender As System.Object, ByVal e As AxPDFViewerLib._DPDFViewerEvents_OnMouseWheelEvent) Handles AxPDFViewer1.OnMouseWheel
        If radioChangePage1.Checked Then

            ChangePage(e.iDelta)

        ElseIf radioChangePage2.Checked Then
            If (e.bControlDown) Then

                ChangePage(e.iDelta)
            End If


        ElseIf (radioChangePage3.Checked) Then
            If (e.bRButtonDown) Then

                ChangePage(e.iDelta)
            End If
        End If




        RefreshPageNumber()



    End Sub

    Private Sub AxPDFViewer1_MMouseButtonDblClk(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxPDFViewer1.MMouseButtonDblClk
        Button12.PerformClick()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim bResult As Boolean
        SaveFileDialog1.Filter = "PDF file (*.pdf)|*.pdf||"
        SaveFileDialog1.DefaultExt = "pdf"

        If chkusefastview.Checked Then
            AxPDFViewer1.FastWebAccess = True
        Else
            AxPDFViewer1.FastWebAccess = False
        End If



        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            bResult = AxPDFViewer1.SavePDF(SaveFileDialog1.FileName)

            If bResult = True Then
                MessageBox.Show("Save " + SaveFileDialog1.FileName + " Completed")
            End If
        End If

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim bResult As Boolean
        SaveFileDialog1.Filter = "PDF file (*.pdf)|*.pdf||"
        SaveFileDialog1.DefaultExt = "pdf"


        If chkusefastview.Checked Then
            AxPDFViewer1.FastWebAccess = True
        Else
            AxPDFViewer1.FastWebAccess = False
        End If



        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            bResult = AxPDFViewer1.SavePDFWithPassword(SaveFileDialog1.FileName, cboencryptmode.SelectedIndex, txtsavepassword.Text, txtsavepassword.Text)

            If bResult = True Then
                MessageBox.Show("Save " + SaveFileDialog1.FileName + " Completed")
            End If
        End If

    End Sub

    Private Sub button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button17.Click
        Dim bResult As Boolean
        SaveFileDialog1.Filter = "PDF file (*.pdf)|*.pdf||"
        SaveFileDialog1.DefaultExt = "pdf"


        If chkusefastview.Checked Then
            AxPDFViewer1.FastWebAccess = True
        Else
            AxPDFViewer1.FastWebAccess = False
        End If



        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            bResult = AxPDFViewer1.SavePDFWithDeletePage(SaveFileDialog1.FileName, txtdelpagefrom.Text, txtdelpageto.Text)

            If bResult = True Then
                MessageBox.Show("Save " + SaveFileDialog1.FileName + " Completed")
            End If
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim str1 As String
        str1 = "Title: " + AxPDFViewer1.PDFGetTitle + Chr(13) + Chr(10)
        str1 = str1 + "Author: " + AxPDFViewer1.PDFGetAuthor + Chr(13) + Chr(10)
        str1 = str1 + "Keywords: " + AxPDFViewer1.PDFGetKeyword + Chr(13) + Chr(10)
        str1 = str1 + "Subject: " + AxPDFViewer1.PDFGetSubject + Chr(13) + Chr(10)
        str1 = str1 + "Producer: " + AxPDFViewer1.PDFGetProducer + Chr(13) + Chr(10)
        str1 = str1 + "Creation Date: " + AxPDFViewer1.PDFGetCreationDate + Chr(13) + Chr(10)
        str1 = str1 + "Modify Date: " + AxPDFViewer1.PDFGetModifyDate + Chr(13) + Chr(10)
        str1 = str1 + "Version No: " + AxPDFViewer1.PDFGetVersionNo.ToString() + Chr(13) + Chr(10)

        MessageBox.Show(str1)

    End Sub
End Class
