using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace SicParvisMagna.Forms.PointOfSale
{
	public partial class ucGenerateBarcode : UserControl
	{		
		public ucGenerateBarcode()
		{
			InitializeComponent();
		}

		private void GenerateBtn_Click(object sender, EventArgs e)
		{
			string barcode = GenerateBtn.Text;
			Bitmap bitMap = new Bitmap(barcode.Length * 40, 150);
			using (Graphics graphics = Graphics.FromImage(bitMap));
			{
				Font oFont = new System.Drawing.Font("Code 128", 28);
				Bitmap btimap = new Bitmap(barcode.Length * 40, 150);
				PointF point = new PointF(2f, 2f);
				SolidBrush black = new SolidBrush(Color.Black);
				SolidBrush White = new SolidBrush(Color.White);
				//graphics.FillRectangle(White, 0, 0, bitMap.Width, bitMap.Height);
				//graphics.DrawString("*" + barcode + "*", oFont, black, point);
				
			}
			using (MemoryStream ms = new MemoryStream())
			{
				bitMap.Save(ms, ImageFormat.Png);
				pictureBox1.Image = bitMap;
				pictureBox1.Height = bitMap.Height;
				pictureBox1.Width = bitMap.Width;
			}
			


		}
	}
}
