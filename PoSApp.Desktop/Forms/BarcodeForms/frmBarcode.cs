using Patagames.Pdf;
using Serilog.Parsing;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using ZXing;
using ZXing.Windows.Compatibility;
using Alignment = Xceed.Document.NET.Alignment;
using Patagames.Pdf.Net;
using Patagames.Pdf.Net.Controls.WinForms;

namespace PoSApp.Desktop.Forms.BarcodeForms
{
    public partial class frmBarcode : Form
    {
        public frmBarcode()
        {
            InitializeComponent();
        }
        Bitmap barcodeBitmap;
        string tempImagePath = Path.GetTempFileName();
        string barcodeData = "";
        string docDirectory = $"{System.IO.Path.GetDirectoryName(Application.ExecutablePath)}\\wordfiles";


        private void btnSave_Click(object sender, EventArgs e)
        {
            string docFile = $"WordFile-{DateTime.Now.Ticks.ToString()}.docx";
            string pdfFile = $"WordFile-{DateTime.Now.Ticks.ToString()}.pdf";
            if (!Path.Exists(docDirectory))
            {
                Directory.CreateDirectory(docDirectory);
            }
            if (chkMasaustu.Checked)
            {
                string masaustuKlasoru= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                docFile = $"{masaustuKlasoru}\\{docFile}";
                pdfFile = $"{masaustuKlasoru}\\{pdfFile}";
            }
            else
            {
                docFile = $"{docDirectory}\\{docFile}";
                pdfFile = $"{docDirectory}\\{pdfFile}";
            }
            
            using (DocX document = DocX.Create(docFile))
            {

                document.MarginTop = float.Parse(txtA4Ust.Text);
                document.MarginBottom = 0;
                document.MarginLeft = float.Parse(txtA4Sol.Text);
                document.MarginRight = 0;


                int numRows = 14;
                int numColumns = 5;
                int totalBarcodes = numRows * numColumns;
                // Generate and insert barcodes
                for (int row = 0; row < numRows; row++)
                {
                    var table = document.AddTable(1, numColumns);

                    table.SetBorder(TableBorderType.InsideH, new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, System.Drawing.Color.Transparent));
                    table.SetBorder(TableBorderType.InsideV, new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, System.Drawing.Color.Transparent));
                    table.Alignment = Alignment.center;

                    for (int col = 0; col < numColumns; col++)
                    {
                        var cell = table.Rows[0].Cells[col];
                        cell.Width = 120;
                        cell.SetBorder(TableCellBorderType.Bottom, new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, System.Drawing.Color.Transparent));
                        cell.SetBorder(TableCellBorderType.Top, new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, System.Drawing.Color.Transparent));
                        cell.SetBorder(TableCellBorderType.Left, new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, System.Drawing.Color.Transparent));
                        cell.SetBorder(TableCellBorderType.Right, new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, System.Drawing.Color.Transparent));






                        var image = document.AddImage(tempImagePath);
                        var picture = image.CreatePicture();

                        cell.InsertParagraph().AppendPicture(picture);

                    }

                    document.InsertTable(table);
                }

              

                document.Save();


                if (chkPdf.Checked)
                {
                    Spire.Doc.Document docxDocument = new Spire.Doc.Document(docFile, FileFormat.PDF);

                    docxDocument.SaveToFile(pdfFile, FileFormat.PDF);
                    Thread.Sleep(500);
                    try
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = "CHROME.EXE";
                        startInfo.Arguments = pdfFile;
                        startInfo.UseShellExecute = true;
                        Process.Start(startInfo);
                    }
                    catch
                    {

                        MessageBox.Show("Yazma Hatası, tekrar deneniyor.");
                        try
                        {
                            Thread.Sleep(1000);
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.FileName = "CHROME.EXE";
                            startInfo.Arguments = pdfFile;
                            startInfo.UseShellExecute = true;
                            Process.Start(startInfo);
                        }
                        catch
                        {

                        }
                    }
                }
                else
                {

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "WINWORD.EXE";
                    startInfo.Arguments = docFile;
                    startInfo.UseShellExecute = true;
                    Process.Start(startInfo);



                }




            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            BarcodeWriter barcodeWriter = new BarcodeWriter();

            barcodeWriter.Format = BarcodeFormat.CODE_128;
            barcodeWriter.Options.Height = 60;
            barcodeWriter.Options.Width = 120;
            barcodeWriter.Options.Margin = 0;
            barcodeWriter.Options.NoPadding = true;
            barcodeWriter.Options.PureBarcode = false;

            barcodeData = $"{txtBarcode.Text}";
            barcodeBitmap = barcodeWriter.Write(barcodeData);

            pBoxBarcode.Image = barcodeBitmap;
            pBoxBarcode.Size = pBoxBarcode.Image.Size;


            barcodeBitmap.Save(tempImagePath, ImageFormat.Png);
            btnSave.Enabled = true;
        }

        private void pBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
