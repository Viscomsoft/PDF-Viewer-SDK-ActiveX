<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxPDFViewer1 = New AxPDFViewerLib.AxPDFViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblsearchtextmsg = New System.Windows.Forms.Label()
        Me.chkhighlightallmatch = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboExportTextType = New System.Windows.Forms.ComboBox()
        Me.btnExportText = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OptionRotate0 = New System.Windows.Forms.RadioButton()
        Me.OptionRotate45 = New System.Windows.Forms.RadioButton()
        Me.OptionRotate270 = New System.Windows.Forms.RadioButton()
        Me.OptionRotate180 = New System.Windows.Forms.RadioButton()
        Me.OptionRotate90 = New System.Windows.Forms.RadioButton()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboprinter = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprintfrom = New System.Windows.Forms.TextBox()
        Me.txtprintto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioLandscape = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPortrait = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblprintstatus = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkshowpagesetup = New System.Windows.Forms.CheckBox()
        Me.BtnFitWindow = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsavescale = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chksavebitmapbysizeallpage = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsavebitmapbysizepageno = New System.Windows.Forms.TextBox()
        Me.chkpanning = New System.Windows.Forms.CheckBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.txtcustomzoom = New System.Windows.Forms.TextBox()
        Me.groupBox10 = New System.Windows.Forms.GroupBox()
        Me.radioChangePage3 = New System.Windows.Forms.RadioButton()
        Me.radioChangePage2 = New System.Windows.Forms.RadioButton()
        Me.radioChangePage1 = New System.Windows.Forms.RadioButton()
        Me.lblcurrentpage = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.AxPDFViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.groupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxPDFViewer1
        '
        Me.AxPDFViewer1.Enabled = True
        Me.AxPDFViewer1.Location = New System.Drawing.Point(385, 4)
        Me.AxPDFViewer1.Name = "AxPDFViewer1"
        Me.AxPDFViewer1.OcxState = CType(resources.GetObject("AxPDFViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxPDFViewer1.Size = New System.Drawing.Size(672, 565)
        Me.AxPDFViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(385, 587)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Prev Page"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(506, 587)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Next Page"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(78, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Go"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(57, 21)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(197, 42)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 21)
        Me.TextBox2.TabIndex = 7
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 115)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(168, 23)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Zoom In"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 144)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(168, 23)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Zoom Out"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(186, 144)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(168, 23)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "OriginalSize"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(14, 231)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(168, 23)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "Save Bitmaps"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(14, 286)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(168, 23)
        Me.Button12.TabIndex = 14
        Me.Button12.Text = "Print( Print Dialog)"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(671, 592)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Total Page"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(775, 589)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(48, 21)
        Me.TextBox3.TabIndex = 16
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(12, 87)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(168, 23)
        Me.Button13.TabIndex = 17
        Me.Button13.Text = "Backgroud Color"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblsearchtextmsg)
        Me.GroupBox1.Controls.Add(Me.chkhighlightallmatch)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 495)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 87)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Text"
        '
        'lblsearchtextmsg
        '
        Me.lblsearchtextmsg.AutoSize = True
        Me.lblsearchtextmsg.Location = New System.Drawing.Point(196, 68)
        Me.lblsearchtextmsg.Name = "lblsearchtextmsg"
        Me.lblsearchtextmsg.Size = New System.Drawing.Size(125, 12)
        Me.lblsearchtextmsg.TabIndex = 67
        Me.lblsearchtextmsg.Text = "Found text at Page 1"
        '
        'chkhighlightallmatch
        '
        Me.chkhighlightallmatch.AutoSize = True
        Me.chkhighlightallmatch.Location = New System.Drawing.Point(8, 20)
        Me.chkhighlightallmatch.Name = "chkhighlightallmatch"
        Me.chkhighlightallmatch.Size = New System.Drawing.Size(180, 16)
        Me.chkhighlightallmatch.TabIndex = 66
        Me.chkhighlightallmatch.Text = "Highlight All Matched Text"
        Me.chkhighlightallmatch.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(274, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Down"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(206, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.Text = "Up"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboExportTextType)
        Me.GroupBox2.Controls.Add(Me.btnExportText)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(234, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 107)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Go to Page"
        '
        'cboExportTextType
        '
        Me.cboExportTextType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExportTextType.FormattingEnabled = True
        Me.cboExportTextType.Location = New System.Drawing.Point(80, 46)
        Me.cboExportTextType.Name = "cboExportTextType"
        Me.cboExportTextType.Size = New System.Drawing.Size(60, 20)
        Me.cboExportTextType.TabIndex = 54
        '
        'btnExportText
        '
        Me.btnExportText.Location = New System.Drawing.Point(9, 75)
        Me.btnExportText.Name = "btnExportText"
        Me.btnExportText.Size = New System.Drawing.Size(131, 24)
        Me.btnExportText.TabIndex = 54
        Me.btnExportText.Text = "Export Text "
        Me.btnExportText.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 12)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Export Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "For open password protected PDF "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(73, 62)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(75, 21)
        Me.TextBoxPassword.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OptionRotate0)
        Me.GroupBox3.Controls.Add(Me.OptionRotate45)
        Me.GroupBox3.Controls.Add(Me.OptionRotate270)
        Me.GroupBox3.Controls.Add(Me.OptionRotate180)
        Me.GroupBox3.Controls.Add(Me.OptionRotate90)
        Me.GroupBox3.Location = New System.Drawing.Point(184, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 67)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rotate"
        '
        'OptionRotate0
        '
        Me.OptionRotate0.AutoSize = True
        Me.OptionRotate0.Location = New System.Drawing.Point(56, 47)
        Me.OptionRotate0.Name = "OptionRotate0"
        Me.OptionRotate0.Size = New System.Drawing.Size(29, 16)
        Me.OptionRotate0.TabIndex = 4
        Me.OptionRotate0.TabStop = True
        Me.OptionRotate0.Text = "0"
        Me.OptionRotate0.UseVisualStyleBackColor = True
        '
        'OptionRotate45
        '
        Me.OptionRotate45.AutoSize = True
        Me.OptionRotate45.Location = New System.Drawing.Point(11, 46)
        Me.OptionRotate45.Name = "OptionRotate45"
        Me.OptionRotate45.Size = New System.Drawing.Size(35, 16)
        Me.OptionRotate45.TabIndex = 3
        Me.OptionRotate45.TabStop = True
        Me.OptionRotate45.Text = "45"
        Me.OptionRotate45.UseVisualStyleBackColor = True
        '
        'OptionRotate270
        '
        Me.OptionRotate270.AutoSize = True
        Me.OptionRotate270.Location = New System.Drawing.Point(104, 18)
        Me.OptionRotate270.Name = "OptionRotate270"
        Me.OptionRotate270.Size = New System.Drawing.Size(41, 16)
        Me.OptionRotate270.TabIndex = 2
        Me.OptionRotate270.TabStop = True
        Me.OptionRotate270.Text = "270"
        Me.OptionRotate270.UseVisualStyleBackColor = True
        '
        'OptionRotate180
        '
        Me.OptionRotate180.AutoSize = True
        Me.OptionRotate180.Location = New System.Drawing.Point(54, 18)
        Me.OptionRotate180.Name = "OptionRotate180"
        Me.OptionRotate180.Size = New System.Drawing.Size(41, 16)
        Me.OptionRotate180.TabIndex = 1
        Me.OptionRotate180.TabStop = True
        Me.OptionRotate180.Text = "180"
        Me.OptionRotate180.UseVisualStyleBackColor = True
        '
        'OptionRotate90
        '
        Me.OptionRotate90.AutoSize = True
        Me.OptionRotate90.Location = New System.Drawing.Point(11, 18)
        Me.OptionRotate90.Name = "OptionRotate90"
        Me.OptionRotate90.Size = New System.Drawing.Size(35, 16)
        Me.OptionRotate90.TabIndex = 0
        Me.OptionRotate90.TabStop = True
        Me.OptionRotate90.Text = "90"
        Me.OptionRotate90.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 173)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(168, 23)
        Me.Button7.TabIndex = 28
        Me.Button7.Text = "Fit Width"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(11, 202)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(168, 23)
        Me.Button14.TabIndex = 29
        Me.Button14.Text = "Fit Height"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Printer"
        '
        'cboprinter
        '
        Me.cboprinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboprinter.FormattingEnabled = True
        Me.cboprinter.Location = New System.Drawing.Point(97, 11)
        Me.cboprinter.Name = "cboprinter"
        Me.cboprinter.Size = New System.Drawing.Size(131, 20)
        Me.cboprinter.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 12)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Page From"
        '
        'txtprintfrom
        '
        Me.txtprintfrom.Location = New System.Drawing.Point(99, 36)
        Me.txtprintfrom.Name = "txtprintfrom"
        Me.txtprintfrom.Size = New System.Drawing.Size(39, 21)
        Me.txtprintfrom.TabIndex = 33
        Me.txtprintfrom.Text = "1"
        '
        'txtprintto
        '
        Me.txtprintto.Location = New System.Drawing.Point(168, 36)
        Me.txtprintto.Name = "txtprintto"
        Me.txtprintto.Size = New System.Drawing.Size(34, 21)
        Me.txtprintto.TabIndex = 34
        Me.txtprintto.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "To"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioLandscape)
        Me.GroupBox4.Controls.Add(Me.RadioButtonPortrait)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 40)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Page Orientation"
        '
        'RadioLandscape
        '
        Me.RadioLandscape.AutoSize = True
        Me.RadioLandscape.Location = New System.Drawing.Point(120, 16)
        Me.RadioLandscape.Name = "RadioLandscape"
        Me.RadioLandscape.Size = New System.Drawing.Size(77, 16)
        Me.RadioLandscape.TabIndex = 39
        Me.RadioLandscape.Text = "Landscape"
        Me.RadioLandscape.UseVisualStyleBackColor = True
        '
        'RadioButtonPortrait
        '
        Me.RadioButtonPortrait.AutoSize = True
        Me.RadioButtonPortrait.Checked = True
        Me.RadioButtonPortrait.Location = New System.Drawing.Point(19, 16)
        Me.RadioButtonPortrait.Name = "RadioButtonPortrait"
        Me.RadioButtonPortrait.Size = New System.Drawing.Size(71, 16)
        Me.RadioButtonPortrait.TabIndex = 38
        Me.RadioButtonPortrait.TabStop = True
        Me.RadioButtonPortrait.Text = "Portrait"
        Me.RadioButtonPortrait.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 12)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Print Status:"
        '
        'lblprintstatus
        '
        Me.lblprintstatus.AutoSize = True
        Me.lblprintstatus.Location = New System.Drawing.Point(135, 132)
        Me.lblprintstatus.Name = "lblprintstatus"
        Me.lblprintstatus.Size = New System.Drawing.Size(47, 12)
        Me.lblprintstatus.TabIndex = 40
        Me.lblprintstatus.Text = "Nothing"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(14, 147)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(165, 27)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Print( No UI)"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkshowpagesetup)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.lblprintstatus)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtprintto)
        Me.GroupBox5.Controls.Add(Me.txtprintfrom)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.cboprinter)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 315)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(230, 182)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        '
        'chkshowpagesetup
        '
        Me.chkshowpagesetup.AutoSize = True
        Me.chkshowpagesetup.Location = New System.Drawing.Point(11, 119)
        Me.chkshowpagesetup.Name = "chkshowpagesetup"
        Me.chkshowpagesetup.Size = New System.Drawing.Size(114, 16)
        Me.chkshowpagesetup.TabIndex = 42
        Me.chkshowpagesetup.Text = "Show Page Setup"
        Me.chkshowpagesetup.UseVisualStyleBackColor = True
        '
        'BtnFitWindow
        '
        Me.BtnFitWindow.Location = New System.Drawing.Point(186, 173)
        Me.BtnFitWindow.Name = "BtnFitWindow"
        Me.BtnFitWindow.Size = New System.Drawing.Size(168, 23)
        Me.BtnFitWindow.TabIndex = 43
        Me.BtnFitWindow.Text = "Fit Window"
        Me.BtnFitWindow.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(14, 260)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(168, 23)
        Me.Button15.TabIndex = 44
        Me.Button15.Text = "Save Bitmaps By Size"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(193, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 12)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Scale"
        '
        'txtsavescale
        '
        Me.txtsavescale.Location = New System.Drawing.Point(240, 268)
        Me.txtsavescale.Name = "txtsavescale"
        Me.txtsavescale.Size = New System.Drawing.Size(41, 21)
        Me.txtsavescale.TabIndex = 46
        Me.txtsavescale.Text = "2.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "All Pages"
        '
        'chksavebitmapbysizeallpage
        '
        Me.chksavebitmapbysizeallpage.AutoSize = True
        Me.chksavebitmapbysizeallpage.Checked = True
        Me.chksavebitmapbysizeallpage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksavebitmapbysizeallpage.Location = New System.Drawing.Point(262, 240)
        Me.chksavebitmapbysizeallpage.Name = "chksavebitmapbysizeallpage"
        Me.chksavebitmapbysizeallpage.Size = New System.Drawing.Size(15, 14)
        Me.chksavebitmapbysizeallpage.TabIndex = 48
        Me.chksavebitmapbysizeallpage.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Page"
        '
        'txtsavebitmapbysizepageno
        '
        Me.txtsavebitmapbysizepageno.Enabled = False
        Me.txtsavebitmapbysizepageno.Location = New System.Drawing.Point(297, 268)
        Me.txtsavebitmapbysizepageno.Name = "txtsavebitmapbysizepageno"
        Me.txtsavebitmapbysizepageno.Size = New System.Drawing.Size(38, 21)
        Me.txtsavebitmapbysizepageno.TabIndex = 50
        Me.txtsavebitmapbysizepageno.Text = "1"
        '
        'chkpanning
        '
        Me.chkpanning.AutoSize = True
        Me.chkpanning.Checked = True
        Me.chkpanning.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkpanning.Location = New System.Drawing.Point(200, 19)
        Me.chkpanning.Margin = New System.Windows.Forms.Padding(2)
        Me.chkpanning.Name = "chkpanning"
        Me.chkpanning.Size = New System.Drawing.Size(174, 16)
        Me.chkpanning.TabIndex = 51
        Me.chkpanning.Text = "Enable Panning with Mouse"
        Me.chkpanning.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(183, 202)
        Me.Button16.Margin = New System.Windows.Forms.Padding(2)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(94, 23)
        Me.Button16.TabIndex = 52
        Me.Button16.Text = "Custom Zoom"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'txtcustomzoom
        '
        Me.txtcustomzoom.Location = New System.Drawing.Point(288, 206)
        Me.txtcustomzoom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcustomzoom.Name = "txtcustomzoom"
        Me.txtcustomzoom.Size = New System.Drawing.Size(68, 21)
        Me.txtcustomzoom.TabIndex = 53
        Me.txtcustomzoom.Text = "2.0"
        '
        'groupBox10
        '
        Me.groupBox10.Controls.Add(Me.radioChangePage3)
        Me.groupBox10.Controls.Add(Me.radioChangePage2)
        Me.groupBox10.Controls.Add(Me.radioChangePage1)
        Me.groupBox10.Location = New System.Drawing.Point(11, 587)
        Me.groupBox10.Name = "groupBox10"
        Me.groupBox10.Size = New System.Drawing.Size(362, 95)
        Me.groupBox10.TabIndex = 66
        Me.groupBox10.TabStop = False
        Me.groupBox10.Text = "change pages by scrolling mouse wheel "
        '
        'radioChangePage3
        '
        Me.radioChangePage3.AutoSize = True
        Me.radioChangePage3.Location = New System.Drawing.Point(11, 75)
        Me.radioChangePage3.Name = "radioChangePage3"
        Me.radioChangePage3.Size = New System.Drawing.Size(275, 16)
        Me.radioChangePage3.TabIndex = 2
        Me.radioChangePage3.Text = "Right mouse button + scrolling mouse wheel"
        Me.radioChangePage3.UseVisualStyleBackColor = True
        '
        'radioChangePage2
        '
        Me.radioChangePage2.AutoSize = True
        Me.radioChangePage2.Checked = True
        Me.radioChangePage2.Location = New System.Drawing.Point(12, 48)
        Me.radioChangePage2.Name = "radioChangePage2"
        Me.radioChangePage2.Size = New System.Drawing.Size(215, 16)
        Me.radioChangePage2.TabIndex = 1
        Me.radioChangePage2.TabStop = True
        Me.radioChangePage2.Text = "Ctrl Key + scrolling mouse wheel"
        Me.radioChangePage2.UseVisualStyleBackColor = True
        '
        'radioChangePage1
        '
        Me.radioChangePage1.AutoSize = True
        Me.radioChangePage1.Location = New System.Drawing.Point(12, 20)
        Me.radioChangePage1.Name = "radioChangePage1"
        Me.radioChangePage1.Size = New System.Drawing.Size(149, 16)
        Me.radioChangePage1.TabIndex = 0
        Me.radioChangePage1.Text = "Scrolling mouse wheel"
        Me.radioChangePage1.UseVisualStyleBackColor = True
        '
        'lblcurrentpage
        '
        Me.lblcurrentpage.AutoSize = True
        Me.lblcurrentpage.Location = New System.Drawing.Point(236, 447)
        Me.lblcurrentpage.Name = "lblcurrentpage"
        Me.lblcurrentpage.Size = New System.Drawing.Size(95, 12)
        Me.lblcurrentpage.TabIndex = 67
        Me.lblcurrentpage.Text = "Current Page: 0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(399, 624)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(299, 12)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "double click middle mouse button to print the PDF"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 674)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblcurrentpage)
        Me.Controls.Add(Me.groupBox10)
        Me.Controls.Add(Me.txtcustomzoom)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.chkpanning)
        Me.Controls.Add(Me.txtsavebitmapbysizepageno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chksavebitmapbysizeallpage)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtsavescale)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.BtnFitWindow)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxPDFViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxPDFViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.groupBox10.ResumeLayout(False)
        Me.groupBox10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxPDFViewer1 As AxPDFViewerLib.AxPDFViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OptionRotate0 As System.Windows.Forms.RadioButton
    Friend WithEvents OptionRotate45 As System.Windows.Forms.RadioButton
    Friend WithEvents OptionRotate270 As System.Windows.Forms.RadioButton
    Friend WithEvents OptionRotate180 As System.Windows.Forms.RadioButton
    Friend WithEvents OptionRotate90 As System.Windows.Forms.RadioButton
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboprinter As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtprintfrom As System.Windows.Forms.TextBox
    Friend WithEvents txtprintto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonPortrait As System.Windows.Forms.RadioButton
    Friend WithEvents RadioLandscape As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblprintstatus As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkshowpagesetup As System.Windows.Forms.CheckBox
    Friend WithEvents BtnFitWindow As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsavescale As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chksavebitmapbysizeallpage As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsavebitmapbysizepageno As System.Windows.Forms.TextBox
    Friend WithEvents chkpanning As System.Windows.Forms.CheckBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents txtcustomzoom As System.Windows.Forms.TextBox
    Friend WithEvents cboExportTextType As System.Windows.Forms.ComboBox
    Friend WithEvents btnExportText As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents chkhighlightallmatch As System.Windows.Forms.CheckBox
    Private WithEvents lblsearchtextmsg As System.Windows.Forms.Label
    Private WithEvents groupBox10 As System.Windows.Forms.GroupBox
    Private WithEvents radioChangePage3 As System.Windows.Forms.RadioButton
    Private WithEvents radioChangePage2 As System.Windows.Forms.RadioButton
    Private WithEvents radioChangePage1 As System.Windows.Forms.RadioButton
    Private WithEvents lblcurrentpage As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
