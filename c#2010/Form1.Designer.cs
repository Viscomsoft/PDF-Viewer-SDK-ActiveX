namespace testPDF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Open = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsearchtextmsg = new System.Windows.Forms.Label();
            this.chkhighlightallmatch = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboExportTextType = new System.Windows.Forms.ComboBox();
            this.btnExportText = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.OptionRotate0 = new System.Windows.Forms.RadioButton();
            this.OptionRotate45 = new System.Windows.Forms.RadioButton();
            this.OptionRotate270 = new System.Windows.Forms.RadioButton();
            this.OptionRotate180 = new System.Windows.Forms.RadioButton();
            this.OptionRotate90 = new System.Windows.Forms.RadioButton();
            this.Button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.chkshowpagesetup = new System.Windows.Forms.CheckBox();
            this.button12 = new System.Windows.Forms.Button();
            this.lblprintstatus = new System.Windows.Forms.Label();
            this.RadioLandscape = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.RadioButtonPortrait = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtprintto = new System.Windows.Forms.TextBox();
            this.txtprintfrom = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.cboprinter = new System.Windows.Forms.ComboBox();
            this.axPDFViewer1 = new AxPDFViewerLib.AxPDFViewer();
            this.BtnFitWindow = new System.Windows.Forms.Button();
            this.btnsavebitmapbysize = new System.Windows.Forms.Button();
            this.txtsavebitmapbysizepageno = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.chksavebitmapbysizeallpage = new System.Windows.Forms.CheckBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtsavescale = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.chkpanning = new System.Windows.Forms.CheckBox();
            this.txtcustomzoom = new System.Windows.Forms.TextBox();
            this.Button16 = new System.Windows.Forms.Button();
            this.radioChangePage3 = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.radioChangePage2 = new System.Windows.Forms.RadioButton();
            this.radioChangePage1 = new System.Windows.Forms.RadioButton();
            this.lblcurrentpage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPDFViewer1)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(175, 28);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Backgroud Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zoom In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Zoom Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Original Size";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Print (Print Dialog)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsearchtextmsg);
            this.groupBox1.Controls.Add(this.chkhighlightallmatch);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(206, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Text";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblsearchtextmsg
            // 
            this.lblsearchtextmsg.AutoSize = true;
            this.lblsearchtextmsg.Location = new System.Drawing.Point(10, 120);
            this.lblsearchtextmsg.Name = "lblsearchtextmsg";
            this.lblsearchtextmsg.Size = new System.Drawing.Size(125, 12);
            this.lblsearchtextmsg.TabIndex = 66;
            this.lblsearchtextmsg.Text = "Found text at Page 1";
            // 
            // chkhighlightallmatch
            // 
            this.chkhighlightallmatch.AutoSize = true;
            this.chkhighlightallmatch.Location = new System.Drawing.Point(0, 14);
            this.chkhighlightallmatch.Name = "chkhighlightallmatch";
            this.chkhighlightallmatch.Size = new System.Drawing.Size(180, 16);
            this.chkhighlightallmatch.TabIndex = 65;
            this.chkhighlightallmatch.Text = "Highlight All Matched Text";
            this.chkhighlightallmatch.UseVisualStyleBackColor = true;
            this.chkhighlightallmatch.CheckedChanged += new System.EventHandler(this.chkhighlightallmatch_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(97, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Down";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Up";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboExportTextType);
            this.groupBox2.Controls.Add(this.btnExportText);
            this.groupBox2.Controls.Add(this.Label11);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(200, 538);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 122);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Go to Page";
            // 
            // cboExportTextType
            // 
            this.cboExportTextType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExportTextType.FormattingEnabled = true;
            this.cboExportTextType.Location = new System.Drawing.Point(91, 62);
            this.cboExportTextType.Name = "cboExportTextType";
            this.cboExportTextType.Size = new System.Drawing.Size(83, 20);
            this.cboExportTextType.TabIndex = 57;
            // 
            // btnExportText
            // 
            this.btnExportText.Location = new System.Drawing.Point(15, 91);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(141, 24);
            this.btnExportText.TabIndex = 56;
            this.btnExportText.Text = "Export Text ";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(12, 65);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(71, 12);
            this.Label11.TabIndex = 55;
            this.Label11.Text = "Export Type";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(92, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 21);
            this.button7.TabIndex = 1;
            this.button7.Text = "Go";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "1";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 289);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 29);
            this.button8.TabIndex = 9;
            this.button8.Text = "Save Bitmaps";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(556, 723);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 26);
            this.button9.TabIndex = 10;
            this.button9.Text = "Prev Page";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(678, 723);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(116, 26);
            this.button10.TabIndex = 11;
            this.button10.Text = "Next Page";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(17, 536);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 50);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(72, 59);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(75, 21);
            this.TextBoxPassword.TabIndex = 26;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 62);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 12);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 42);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(197, 12);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "For open password protected PDF ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.OptionRotate0);
            this.groupBox4.Controls.Add(this.OptionRotate45);
            this.groupBox4.Controls.Add(this.OptionRotate270);
            this.groupBox4.Controls.Add(this.OptionRotate180);
            this.groupBox4.Controls.Add(this.OptionRotate90);
            this.groupBox4.Location = new System.Drawing.Point(194, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 67);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rotate";
            // 
            // OptionRotate0
            // 
            this.OptionRotate0.AutoSize = true;
            this.OptionRotate0.Location = new System.Drawing.Point(56, 47);
            this.OptionRotate0.Name = "OptionRotate0";
            this.OptionRotate0.Size = new System.Drawing.Size(29, 16);
            this.OptionRotate0.TabIndex = 4;
            this.OptionRotate0.TabStop = true;
            this.OptionRotate0.Text = "0";
            this.OptionRotate0.UseVisualStyleBackColor = true;
            this.OptionRotate0.CheckedChanged += new System.EventHandler(this.OptionRotate0_CheckedChanged);
            // 
            // OptionRotate45
            // 
            this.OptionRotate45.AutoSize = true;
            this.OptionRotate45.Location = new System.Drawing.Point(11, 46);
            this.OptionRotate45.Name = "OptionRotate45";
            this.OptionRotate45.Size = new System.Drawing.Size(35, 16);
            this.OptionRotate45.TabIndex = 3;
            this.OptionRotate45.TabStop = true;
            this.OptionRotate45.Text = "45";
            this.OptionRotate45.UseVisualStyleBackColor = true;
            this.OptionRotate45.CheckedChanged += new System.EventHandler(this.OptionRotate45_CheckedChanged);
            // 
            // OptionRotate270
            // 
            this.OptionRotate270.AutoSize = true;
            this.OptionRotate270.Location = new System.Drawing.Point(104, 18);
            this.OptionRotate270.Name = "OptionRotate270";
            this.OptionRotate270.Size = new System.Drawing.Size(41, 16);
            this.OptionRotate270.TabIndex = 2;
            this.OptionRotate270.TabStop = true;
            this.OptionRotate270.Text = "270";
            this.OptionRotate270.UseVisualStyleBackColor = true;
            this.OptionRotate270.CheckedChanged += new System.EventHandler(this.OptionRotate270_CheckedChanged);
            // 
            // OptionRotate180
            // 
            this.OptionRotate180.AutoSize = true;
            this.OptionRotate180.Location = new System.Drawing.Point(54, 18);
            this.OptionRotate180.Name = "OptionRotate180";
            this.OptionRotate180.Size = new System.Drawing.Size(41, 16);
            this.OptionRotate180.TabIndex = 1;
            this.OptionRotate180.TabStop = true;
            this.OptionRotate180.Text = "180";
            this.OptionRotate180.UseVisualStyleBackColor = true;
            this.OptionRotate180.CheckedChanged += new System.EventHandler(this.OptionRotate180_CheckedChanged);
            // 
            // OptionRotate90
            // 
            this.OptionRotate90.AutoSize = true;
            this.OptionRotate90.Location = new System.Drawing.Point(11, 18);
            this.OptionRotate90.Name = "OptionRotate90";
            this.OptionRotate90.Size = new System.Drawing.Size(35, 16);
            this.OptionRotate90.TabIndex = 0;
            this.OptionRotate90.TabStop = true;
            this.OptionRotate90.Text = "90";
            this.OptionRotate90.UseVisualStyleBackColor = true;
            this.OptionRotate90.CheckedChanged += new System.EventHandler(this.OptionRotate90_CheckedChanged);
            // 
            // Button14
            // 
            this.Button14.Location = new System.Drawing.Point(14, 226);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(174, 23);
            this.Button14.TabIndex = 32;
            this.Button14.Text = "Fit Height";
            this.Button14.UseVisualStyleBackColor = true;
            this.Button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 197);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(176, 23);
            this.button11.TabIndex = 31;
            this.button11.Text = "Fit Width";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // chkshowpagesetup
            // 
            this.chkshowpagesetup.AutoSize = true;
            this.chkshowpagesetup.Location = new System.Drawing.Point(14, 469);
            this.chkshowpagesetup.Name = "chkshowpagesetup";
            this.chkshowpagesetup.Size = new System.Drawing.Size(114, 16);
            this.chkshowpagesetup.TabIndex = 53;
            this.chkshowpagesetup.Text = "Show Page Setup";
            this.chkshowpagesetup.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(17, 497);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(165, 27);
            this.button12.TabIndex = 52;
            this.button12.Text = "Print( No UI)";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // lblprintstatus
            // 
            this.lblprintstatus.AutoSize = true;
            this.lblprintstatus.Location = new System.Drawing.Point(152, 478);
            this.lblprintstatus.Name = "lblprintstatus";
            this.lblprintstatus.Size = new System.Drawing.Size(47, 12);
            this.lblprintstatus.TabIndex = 51;
            this.lblprintstatus.Text = "Nothing";
            // 
            // RadioLandscape
            // 
            this.RadioLandscape.AutoSize = true;
            this.RadioLandscape.Location = new System.Drawing.Point(108, 18);
            this.RadioLandscape.Name = "RadioLandscape";
            this.RadioLandscape.Size = new System.Drawing.Size(77, 16);
            this.RadioLandscape.TabIndex = 39;
            this.RadioLandscape.Text = "Landscape";
            this.RadioLandscape.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(19, 454);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(83, 12);
            this.Label4.TabIndex = 50;
            this.Label4.Text = "Print Status:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(15, 359);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 12);
            this.Label5.TabIndex = 43;
            this.Label5.Text = "Printer";
            // 
            // RadioButtonPortrait
            // 
            this.RadioButtonPortrait.AutoSize = true;
            this.RadioButtonPortrait.Checked = true;
            this.RadioButtonPortrait.Location = new System.Drawing.Point(19, 16);
            this.RadioButtonPortrait.Name = "RadioButtonPortrait";
            this.RadioButtonPortrait.Size = new System.Drawing.Size(71, 16);
            this.RadioButtonPortrait.TabIndex = 38;
            this.RadioButtonPortrait.TabStop = true;
            this.RadioButtonPortrait.Text = "Portrait";
            this.RadioButtonPortrait.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RadioLandscape);
            this.groupBox5.Controls.Add(this.RadioButtonPortrait);
            this.groupBox5.Location = new System.Drawing.Point(15, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 40);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Page Orientation";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(134, 389);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(17, 12);
            this.Label7.TabIndex = 48;
            this.Label7.Text = "To";
            // 
            // txtprintto
            // 
            this.txtprintto.Location = new System.Drawing.Point(167, 386);
            this.txtprintto.Name = "txtprintto";
            this.txtprintto.Size = new System.Drawing.Size(39, 21);
            this.txtprintto.TabIndex = 47;
            this.txtprintto.Text = "1";
            // 
            // txtprintfrom
            // 
            this.txtprintfrom.Location = new System.Drawing.Point(102, 386);
            this.txtprintfrom.Name = "txtprintfrom";
            this.txtprintfrom.Size = new System.Drawing.Size(26, 21);
            this.txtprintfrom.TabIndex = 46;
            this.txtprintfrom.Text = "1";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(13, 389);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 12);
            this.Label6.TabIndex = 45;
            this.Label6.Text = "Page From";
            // 
            // cboprinter
            // 
            this.cboprinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprinter.FormattingEnabled = true;
            this.cboprinter.Location = new System.Drawing.Point(102, 362);
            this.cboprinter.Name = "cboprinter";
            this.cboprinter.Size = new System.Drawing.Size(182, 20);
            this.cboprinter.TabIndex = 44;
            // 
            // axPDFViewer1
            // 
            this.axPDFViewer1.Enabled = true;
            this.axPDFViewer1.Location = new System.Drawing.Point(392, 6);
            this.axPDFViewer1.Name = "axPDFViewer1";
            this.axPDFViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPDFViewer1.OcxState")));
            this.axPDFViewer1.Size = new System.Drawing.Size(620, 665);
            this.axPDFViewer1.TabIndex = 0;
            this.axPDFViewer1.OnPrint += new AxPDFViewerLib._DPDFViewerEvents_OnPrintEventHandler(this.axPDFViewer1_OnPrint);
            this.axPDFViewer1.OnMouseWheel += new AxPDFViewerLib._DPDFViewerEvents_OnMouseWheelEventHandler(this.axPDFViewer1_OnMouseWheel);
            this.axPDFViewer1.MMouseButtonDblClk += new System.EventHandler(this.axPDFViewer1_MMouseButtonDblClk);
            // 
            // BtnFitWindow
            // 
            this.BtnFitWindow.Location = new System.Drawing.Point(194, 198);
            this.BtnFitWindow.Name = "BtnFitWindow";
            this.BtnFitWindow.Size = new System.Drawing.Size(148, 29);
            this.BtnFitWindow.TabIndex = 54;
            this.BtnFitWindow.Text = "Fit Window";
            this.BtnFitWindow.UseVisualStyleBackColor = true;
            this.BtnFitWindow.Click += new System.EventHandler(this.BtnFitWindow_Click);
            // 
            // btnsavebitmapbysize
            // 
            this.btnsavebitmapbysize.Location = new System.Drawing.Point(12, 327);
            this.btnsavebitmapbysize.Name = "btnsavebitmapbysize";
            this.btnsavebitmapbysize.Size = new System.Drawing.Size(175, 29);
            this.btnsavebitmapbysize.TabIndex = 55;
            this.btnsavebitmapbysize.Text = "Save Bitmaps By Size";
            this.btnsavebitmapbysize.UseVisualStyleBackColor = true;
            this.btnsavebitmapbysize.Click += new System.EventHandler(this.btnsavebitmapbysize_Click);
            // 
            // txtsavebitmapbysizepageno
            // 
            this.txtsavebitmapbysizepageno.Enabled = false;
            this.txtsavebitmapbysizepageno.Location = new System.Drawing.Point(300, 332);
            this.txtsavebitmapbysizepageno.Name = "txtsavebitmapbysizepageno";
            this.txtsavebitmapbysizepageno.Size = new System.Drawing.Size(38, 21);
            this.txtsavebitmapbysizepageno.TabIndex = 61;
            this.txtsavebitmapbysizepageno.Text = "1";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(298, 304);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(29, 12);
            this.Label10.TabIndex = 60;
            this.Label10.Text = "Page";
            // 
            // chksavebitmapbysizeallpage
            // 
            this.chksavebitmapbysizeallpage.AutoSize = true;
            this.chksavebitmapbysizeallpage.Checked = true;
            this.chksavebitmapbysizeallpage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksavebitmapbysizeallpage.Location = new System.Drawing.Point(265, 304);
            this.chksavebitmapbysizeallpage.Name = "chksavebitmapbysizeallpage";
            this.chksavebitmapbysizeallpage.Size = new System.Drawing.Size(15, 14);
            this.chksavebitmapbysizeallpage.TabIndex = 59;
            this.chksavebitmapbysizeallpage.UseVisualStyleBackColor = true;
            this.chksavebitmapbysizeallpage.CheckedChanged += new System.EventHandler(this.chksavebitmapbysizeallpage_CheckedChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(193, 306);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(59, 12);
            this.Label9.TabIndex = 58;
            this.Label9.Text = "All Pages";
            // 
            // txtsavescale
            // 
            this.txtsavescale.Location = new System.Drawing.Point(243, 332);
            this.txtsavescale.Name = "txtsavescale";
            this.txtsavescale.Size = new System.Drawing.Size(41, 21);
            this.txtsavescale.TabIndex = 57;
            this.txtsavescale.Text = "2.0";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(196, 335);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(35, 12);
            this.Label8.TabIndex = 56;
            this.Label8.Text = "Scale";
            // 
            // chkpanning
            // 
            this.chkpanning.AutoSize = true;
            this.chkpanning.Checked = true;
            this.chkpanning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkpanning.Location = new System.Drawing.Point(205, 19);
            this.chkpanning.Margin = new System.Windows.Forms.Padding(2);
            this.chkpanning.Name = "chkpanning";
            this.chkpanning.Size = new System.Drawing.Size(174, 16);
            this.chkpanning.TabIndex = 62;
            this.chkpanning.Text = "Enable Panning with Mouse";
            this.chkpanning.UseVisualStyleBackColor = true;
            this.chkpanning.CheckedChanged += new System.EventHandler(this.chkpanning_CheckedChanged);
            // 
            // txtcustomzoom
            // 
            this.txtcustomzoom.Location = new System.Drawing.Point(303, 261);
            this.txtcustomzoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomzoom.Name = "txtcustomzoom";
            this.txtcustomzoom.Size = new System.Drawing.Size(68, 21);
            this.txtcustomzoom.TabIndex = 64;
            this.txtcustomzoom.Text = "2.0";
            // 
            // Button16
            // 
            this.Button16.Location = new System.Drawing.Point(198, 257);
            this.Button16.Margin = new System.Windows.Forms.Padding(2);
            this.Button16.Name = "Button16";
            this.Button16.Size = new System.Drawing.Size(94, 23);
            this.Button16.TabIndex = 63;
            this.Button16.Text = "Custom Zoom";
            this.Button16.UseVisualStyleBackColor = true;
            this.Button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // radioChangePage3
            // 
            this.radioChangePage3.AutoSize = true;
            this.radioChangePage3.Location = new System.Drawing.Point(11, 75);
            this.radioChangePage3.Name = "radioChangePage3";
            this.radioChangePage3.Size = new System.Drawing.Size(275, 16);
            this.radioChangePage3.TabIndex = 2;
            this.radioChangePage3.Text = "Right mouse button + scrolling mouse wheel";
            this.radioChangePage3.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.radioChangePage3);
            this.groupBox10.Controls.Add(this.radioChangePage2);
            this.groupBox10.Controls.Add(this.radioChangePage1);
            this.groupBox10.Location = new System.Drawing.Point(17, 666);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(362, 95);
            this.groupBox10.TabIndex = 65;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "change pages by scrolling mouse wheel ";
            // 
            // radioChangePage2
            // 
            this.radioChangePage2.AutoSize = true;
            this.radioChangePage2.Checked = true;
            this.radioChangePage2.Location = new System.Drawing.Point(12, 48);
            this.radioChangePage2.Name = "radioChangePage2";
            this.radioChangePage2.Size = new System.Drawing.Size(215, 16);
            this.radioChangePage2.TabIndex = 1;
            this.radioChangePage2.TabStop = true;
            this.radioChangePage2.Text = "Ctrl Key + scrolling mouse wheel";
            this.radioChangePage2.UseVisualStyleBackColor = true;
            // 
            // radioChangePage1
            // 
            this.radioChangePage1.AutoSize = true;
            this.radioChangePage1.Location = new System.Drawing.Point(12, 20);
            this.radioChangePage1.Name = "radioChangePage1";
            this.radioChangePage1.Size = new System.Drawing.Size(149, 16);
            this.radioChangePage1.TabIndex = 0;
            this.radioChangePage1.Text = "Scrolling mouse wheel";
            this.radioChangePage1.UseVisualStyleBackColor = true;
            // 
            // lblcurrentpage
            // 
            this.lblcurrentpage.AutoSize = true;
            this.lblcurrentpage.Location = new System.Drawing.Point(19, 599);
            this.lblcurrentpage.Name = "lblcurrentpage";
            this.lblcurrentpage.Size = new System.Drawing.Size(95, 12);
            this.lblcurrentpage.TabIndex = 66;
            this.lblcurrentpage.Text = "Current Page: 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(390, 684);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(401, 12);
            this.label12.TabIndex = 67;
            this.label12.Text = "double click middle mouse button on control, it will print the PDF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 785);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblcurrentpage);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.txtcustomzoom);
            this.Controls.Add(this.Button16);
            this.Controls.Add(this.chkpanning);
            this.Controls.Add(this.txtsavebitmapbysizepageno);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.chksavebitmapbysizeallpage);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtsavescale);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.btnsavebitmapbysize);
            this.Controls.Add(this.BtnFitWindow);
            this.Controls.Add(this.chkshowpagesetup);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.lblprintstatus);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtprintto);
            this.Controls.Add(this.txtprintfrom);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cboprinter);
            this.Controls.Add(this.Button14);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.axPDFViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPDFViewer1)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxPDFViewerLib.AxPDFViewer axPDFViewer1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        internal System.Windows.Forms.TextBox TextBoxPassword;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.RadioButton OptionRotate0;
        internal System.Windows.Forms.RadioButton OptionRotate45;
        internal System.Windows.Forms.RadioButton OptionRotate270;
        internal System.Windows.Forms.RadioButton OptionRotate180;
        internal System.Windows.Forms.RadioButton OptionRotate90;
        internal System.Windows.Forms.Button Button14;
        internal System.Windows.Forms.Button button11;
        internal System.Windows.Forms.CheckBox chkshowpagesetup;
        internal System.Windows.Forms.Button button12;
        internal System.Windows.Forms.Label lblprintstatus;
        internal System.Windows.Forms.RadioButton RadioLandscape;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.RadioButton RadioButtonPortrait;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtprintto;
        internal System.Windows.Forms.TextBox txtprintfrom;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cboprinter;
        private System.Windows.Forms.Button BtnFitWindow;
        private System.Windows.Forms.Button btnsavebitmapbysize;
        internal System.Windows.Forms.TextBox txtsavebitmapbysizepageno;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.CheckBox chksavebitmapbysizeallpage;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtsavescale;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.CheckBox chkpanning;
        internal System.Windows.Forms.TextBox txtcustomzoom;
        internal System.Windows.Forms.Button Button16;
        internal System.Windows.Forms.ComboBox cboExportTextType;
        internal System.Windows.Forms.Button btnExportText;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.CheckBox chkhighlightallmatch;
        private System.Windows.Forms.Label lblsearchtextmsg;
        private System.Windows.Forms.RadioButton radioChangePage3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton radioChangePage2;
        private System.Windows.Forms.RadioButton radioChangePage1;
        private System.Windows.Forms.Label lblcurrentpage;
        private System.Windows.Forms.Label label12;
    }
}

