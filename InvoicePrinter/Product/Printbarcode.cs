using GUIHelper;
using MarshellsSettings;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace InvoicePrinter.Product
{
    [ToolboxItem(false)]
    public partial class Printbarcode : GForm
    {
        Scanners sc = new Scanners();
        public Image Im;
        private string Bcode;
        private string BCType;

        //barcode size
        private int W = 200;
        private int H = 75;
        //amount of barcode to print
        public int A = 1;
        public Printbarcode()
        {
            InitializeComponent();
            BCType = MSetting.GetBarcodeType();
            try
            {
                HSize.Value = H;
                Wsize.Value = W;
            }
            catch (Exception)
            {

            }
            if (Bcode.Length > 1)
                Generate(Bcode);
        }
        public Printbarcode(string bc)
        {
            InitializeComponent();
            BCType = MSetting.GetBarcodeType();
            try
            {
                HSize.Value = H;
                Wsize.Value = W;
            }
            catch (Exception)
            {

            }
            GTxt1.Text = bc;
            Generate(bc);
        }

        private void GTxt1_TextChanged(object sender, EventArgs e)
        {
            Generate(GTxt1.Text);
        }
        private void Generate(string i)
        {
            Bcode = i;
            Im = sc.GetBarcode(i, BCType);
            PictureBox1.Image = Im;
        }

        private void Printbarcode_Load(object sender, EventArgs e)
        {
            labelPrint = false;
            cb1.Checked = false;
        }
        private void GButton1_Click(object sender, EventArgs e)
        {
            A = (int)amount.Value;
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Createimg);
            printPreviewDialog1.Document = printDocument;
            printDialog1.Document = printDocument;
            printDialog1.ShowDialog();
            if (MSetting.ShowPrintPreview() == true)
            {
                printPreviewDialog1.ShowDialog();
            }

            // Give the order to print
            printDocument.Print();
            //printDialog1.Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Createimg);
            //printDialog1.ShowDialog();
        }
        public void Createimg(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Arial", 12); //must use a mono spaced font as the spaces need to line up

            //float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 0;
            for (int l = 1; l <= A; l++)
            {
                graphic.DrawImage(Im, startX, startY + offset, W, H);
                offset += H;
            }

            if (labelPrint == true)
            {
                graphic.DrawString(Bcode, font, new SolidBrush(Color.Black), (int)((startX + W) - Bcode.Length) / 3, 100);
            }
            //graphic.DrawString(Bcode, new Font("Castellar", 20), new SolidBrush(Color.Black), startX, startY);
        }

        private void gButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
        private bool labelPrint
        {
            get; set;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.CheckState == CheckState.Checked)
            {
                labelPrint = true;
            }
            else
            {
                labelPrint = false;
            }
        }

        private void Wsize_ValueChanged(object sender, EventArgs e)
        {
            W = (int)Wsize.Value;
        }

        private void HSize_ValueChanged(object sender, EventArgs e)
        {
            H = (int)HSize.Value;
        }

        private void amount_ValueChanged(object sender, EventArgs e)
        {
            A = (int)amount.Value;
        }
    }
}
