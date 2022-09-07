using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*))|*.* ";

            if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

                if (this.TextBoxPassword.Text != "")
                {
                    this.axPDFViewer1.Password = this.TextBoxPassword.Text;
                }

                if (this.axPDFViewer1.LoadPDFFile(this.openFileDialog1.FileName) < 0)
                {
                    MessageBox.Show("Load File Failed");
                }

                

                if( axPDFViewer1.IsEncrypted() && TextBoxPassword.Text=="") 
                {
                    MessageBox.Show("This PDF is protected, Please input password");
            
                }

                this.label1.Text = Convert.ToString(this.axPDFViewer1.TotalPage);
                txtprintto.Text = axPDFViewer1.PrinterGetPageCount().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axPDFViewer1.BackgroudColor = this.colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axPDFViewer1.PDFZoomIn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.axPDFViewer1.PDFZoomOut();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.axPDFViewer1.ShowOriginalSize();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                axPDFViewer1.PrinterShowPrintDlg ((int)this.Handle);
                axPDFViewer1.PDFPrint();

        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            if(this.folderBrowserDialog1.ShowDialog(this)==DialogResult.OK)
            {
                this.axPDFViewer1.SaveBitmaps(this.folderBrowserDialog1.SelectedPath);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.axPDFViewer1.Search(this.textBox1.Text,false) < 0)
            {
                MessageBox.Show("Can't search the text");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                if (this.axPDFViewer1.SearchPrevText() < 0)
                {
                    MessageBox.Show("Can't search the text");
                }

            }
            if (this.radioButton2.Checked == true)
            {
                if (this.axPDFViewer1.SearchNextText() < 0)
                {
                    MessageBox.Show("Can't search the text");
                }
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.axPDFViewer1.GoToPage(Convert.ToInt16(this.textBox2.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.axPDFViewer1.GoToPrevPage();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.axPDFViewer1.GoToNextPage();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           // this.axPDFViewer1.PDFPageNo = Convert.ToInt16(txtPageNo.Text);
            this.axPDFViewer1.PDFPrint();
       
        }

        private void OptionRotate90_CheckedChanged(object sender, EventArgs e)
        {
            this.axPDFViewer1.RotateAngle = 90;

        }

        private void OptionRotate180_CheckedChanged(object sender, EventArgs e)
        {
            this.axPDFViewer1.RotateAngle = 180;

        }

        private void OptionRotate270_CheckedChanged(object sender, EventArgs e)
        {
            this.axPDFViewer1.RotateAngle = 270;

        }

        private void OptionRotate45_CheckedChanged(object sender, EventArgs e)
        {
            this.axPDFViewer1.RotateAngle = 45;

        }

        private void OptionRotate0_CheckedChanged(object sender, EventArgs e)
        {
            this.axPDFViewer1.RotateAngle = 0;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
              for(int i = 0; i <axPDFViewer1.PrinterCount();i++)
              {
                cboprinter.Items.Add(axPDFViewer1.PrinterName((short)i));
              }

            if(cboprinter.Items.Count > 0)
            cboprinter.SelectedIndex = 0;
        
            
        cboExportTextType.Items.Add("UTF8 Text File");
        cboExportTextType.Items.Add("XML File");
        cboExportTextType.Items.Add("HTML File");
        cboExportTextType.SelectedIndex = 0;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            axPDFViewer1.FitWidth();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            axPDFViewer1.FitHeight();
        }

        private void axPDFViewer1_OnPrint(object sender, AxPDFViewerLib._DPDFViewerEvents_OnPrintEvent e)
        {

            if (e.bIsFinish)
                lblprintstatus.Text = "Printing Finished";
            else
                lblprintstatus.Text = "Printing Page " + e.iPage.ToString() + " of " + e.iTotalPage.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
               axPDFViewer1.PrinterSetPrinterName(cboprinter.Text);

        if(RadioButtonPortrait.Checked)
            axPDFViewer1.PrinterSetPageOrientation(0);
        else
            axPDFViewer1.PrinterSetPageOrientation(1);

        
        if(chkshowpagesetup.Checked)
            axPDFViewer1.PrinterShowPageSetupDlg((int)this.Handle);


        axPDFViewer1.PrinterSetPageRange((short)int.Parse(txtprintfrom.Text), (short)int.Parse(txtprintto.Text));
        axPDFViewer1.PDFPrint();
        }

        private void BtnFitWindow_Click(object sender, EventArgs e)
        {
            axPDFViewer1.FitWindow();
        }

        private void chksavebitmapbysizeallpage_CheckedChanged(object sender, EventArgs e)
        {
            if(chksavebitmapbysizeallpage.Checked)
                 txtsavebitmapbysizepageno.Enabled = false;
            else
            txtsavebitmapbysizepageno.Enabled = true;

        
        }

        private void btnsavebitmapbysize_Click(object sender, EventArgs e)
        {
            if (chksavebitmapbysizeallpage.Checked)
            {
                if (this.folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    this.axPDFViewer1.SaveBitmapsBySize(this.folderBrowserDialog1.SelectedPath, -1, double.Parse(txtsavescale.Text));
                }
            }
            else
            {
                   saveFileDialog1.Filter = "BMP file (*.bmp)|*.bmp||";
                     saveFileDialog1.DefaultExt = "bmp";

                  if(  saveFileDialog1.ShowDialog(this)==DialogResult.OK)
                      this.axPDFViewer1.SaveBitmapsBySize(saveFileDialog1.FileName, (short)int.Parse(txtsavebitmapbysizepageno.Text), double.Parse(txtsavescale.Text));
            }
        }

        private void chkpanning_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkpanning.Checked)
                axPDFViewer1.EnablePanning = true;
            else
                axPDFViewer1.EnablePanning = false;

            
        
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            axPDFViewer1.Zoom = double.Parse(txtcustomzoom.Text);
        }

        private void btnExportText_Click(object sender, EventArgs e)
        {
              if(cboExportTextType.SelectedIndex == 0)
              {
                  saveFileDialog1.Filter = "Text file (*.txt)|*.txt||";
                 saveFileDialog1.DefaultExt = "txt";
              }
              else  if(cboExportTextType.SelectedIndex == 1)
              {
                    saveFileDialog1.Filter = "XML file (*.xml)|*.xml||";
                     saveFileDialog1.DefaultExt = "xml";
       
              }
              else if(cboExportTextType.SelectedIndex == 2)
              {
                    saveFileDialog1.Filter = "Html file (*.html)|*.html||";
                    saveFileDialog1.DefaultExt = "html";

              }

              if (saveFileDialog1.ShowDialog() ==  System.Windows.Forms.DialogResult.OK)
                  axPDFViewer1.ExportText(saveFileDialog1.FileName, (short)Convert.ToInt16(this.textBox2.Text), (short)cboExportTextType.SelectedIndex);
  

        }

        private void chkhighlightallmatch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhighlightallmatch.Checked)
                axPDFViewer1.HighlightAllMatchedText = true;
            else
                axPDFViewer1.HighlightAllMatchedText = false;
         
        }
    }
}
