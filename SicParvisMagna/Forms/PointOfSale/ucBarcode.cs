using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;
namespace SicParvisMagna.Forms.PointOfSale
{
	public partial class ucBarcode : UserControl
	{
		public ucBarcode()
		{
			InitializeComponent();
		}

		private void btnBarcode_Click(object sender, EventArgs e)
		{
			POSMain.loadBarcode();
		}

		private void btnGenBarcode_Click(object sender, EventArgs e)
		{
			POSMain.loadGenerateBarcode();
		}

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Create A Barcode in 1 Line of Code
            //BarcodeWriter.CreateBarcode("1234577777", BarcodeWriterEncoding.UPCA).SaveAsJpeg("C:\\Users\\Toqeer Abbas\\Desktop\\QuickStart.jpg");

            //  BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode(@"C:\Users\Toqeer Abbas\Desktop\abc.png");

            // BarcodeWriter.CreateBarcode creates a GeneratedBarcode object which allows the barcode to be styled and annotated.
            GeneratedBarcode MyBarCode = BarcodeWriter.CreateBarcode("678973345", BarcodeWriterEncoding.UPCA);
       
            // Any text (or commonly, the value of the barcode) can be added to the image in a default or specified font.
            // Text positions are automatically centered, above or below.  Fonts that are too large for a given image are automatically scaled down.
            MyBarCode.AddBarcodeValueTextBelowBarcode();
            MyBarCode.AddAnnotationTextAboveBarcode("This is My Barcode", new Font(new FontFamily("Arial"), 12, FontStyle.Regular, GraphicsUnit.Pixel), Color.DarkSlateBlue);

            MyBarCode.SaveAsPng(@"C:\Users\Toqeer Abbas\Desktop\abc.png");
            BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode(@"C:\Users\Toqeer Abbas\Desktop\abc.png");
          MessageBox.Show(Result.ToString());
        }

        private void btnBarcodeGenerate_Click(object sender, EventArgs e)
        {
            POSMain.BarcodeGenerate();
        }
    }
}
