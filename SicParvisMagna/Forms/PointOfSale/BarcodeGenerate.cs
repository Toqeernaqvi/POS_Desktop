using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SicParvisMagna.Library;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;
using System.Data.SqlClient;
using System.IO;
using Telerik.WinControls.UI;
using System.Web.UI.WebControls;
using Telerik.WinControls;
using System.Configuration;
using BasicCRUD.Controllers;
//using IronBarCode;
using Image = System.Drawing.Image;
using OnBarcode.Barcode;
using ZXing;
using Telerik.WinControls.UI.Barcode.Symbology;
using System.Diagnostics;

namespace SicParvisMagna.Forms.PointOfSale
{
    public partial class BarcodeGenerate : UserControl
    {
        private Guid Product_id = Guid.Empty;
        private Guid Category_id = Guid.Empty;
        private int UPCBarcode = 0;
        private string OrderNo = null;
        DataTable dt = new DataTable();
        public BarcodeGenerate()
        {
            InitializeComponent();
          

        }
        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //Load Categories
        private void loadCmbCategories()
        {
            ProductCategoryDAL objDAL = new ProductCategoryDAL();

         

            DataTable dt = objDAL.LoadAll();
            //
            


            //
            cmbCategory.DataSource = dt;
            cmbCategory.ValueMember = "id";
            cmbCategory.DisplayMember = "name";
            cmbCategory.SelectedIndex = -1;

      
        }


  
        private void LoadCmbProduct(Guid id)
        {
            ProductDAL objDAL = new ProductDAL();
            cmbProduct.DataSource = objDAL.LoadProdcutbyCategory(id);
            cmbProduct.ValueMember = "Pro_id";
            cmbProduct.DisplayMember = "name";
            cmbProduct.SelectedIndex = -1;
        }
        private void LoadCmbOrder()
        {
            BarcodeGenerateDAL obj = new BarcodeGenerateDAL();
            cmbOrder.DataSource = obj.LoadAll();
            cmbOrder.ValueMember = "id";
            cmbOrder.DisplayMember = "Order_No";
            cmbOrder.SelectedValue = -1;
        }
        private void LoaCmbUnit()
        {
            cmbUnit.Items.Add("Kg");
            cmbUnit.Items.Add("Grams");
            cmbUnit.Items.Add("Pound");
        }
        private void GenerateID_Order()
        {
            if (txt_Order.Text.Length == 0)
            {
                SqlDataReader dr;
                con.Open();
                cmd = new SqlCommand("Select Max(Order_no) from Barcode_Generate  ", con);
             
                dr = cmd.ExecuteReader();
                string newId = "";
                if (dr.HasRows)
                {
                    try
                    {

                        while (dr.Read())
                        {
                            string id = "00000";
                            id = (dr[0]).ToString();
                            string[] multiArray = id.Split(new Char[] { 'P', 'O', '-' });
                            string Mid = null;
                            foreach (string mid in multiArray)
                            {
                                if (mid.Trim() != "")
                                {
                                    Mid = mid;
                                }
                            }

                            int sequenceNumber = int.Parse(Mid);
                            sequenceNumber++;
                            newId = string.Format("{0}", sequenceNumber.ToString().PadLeft(5, '0'));
                        }
                    }
                    catch { }
                }
                else
                {
                    txt_Order.Text = "BO-00001";
                }
                if (string.IsNullOrEmpty(txt_Order.Text))
                {
                    if (string.IsNullOrWhiteSpace(newId.ToString()))
                    {
                        txt_Order.Text = "BO-00001" + newId.ToString();
                    }
                    else
                        txt_Order.Text = "BO-" + newId.ToString();

                }

                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BarcodeGenerateBAL objBAL = new BarcodeGenerateBAL();
            objBAL.Pro_id = Product_id;
            objBAL.Cat_id = Category_id;
            objBAL.Price = Double.Parse(txtPrice.Text);
            objBAL.Order_No = txt_Order.Text;
            objBAL.Quantity = Double.Parse(txtQuantity.Text);
            objBAL.Unit = cmbUnit.Text;
            objBAL.Description = txtDescription.Text;
            objBAL.Flag = 1;

            BarcodeGenerateDAL objDAL = new BarcodeGenerateDAL();

            objBAL.user_id = Program.User_id;
            objBAL.AddDate = DateTime.Now;
            try
            {
                objDAL.Add(objBAL);

            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            clearAll();
            LoadCmbOrder();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cmbCategory.SelectedValue.ToString(), out Category_id);
            LoadCmbProduct(Category_id);
        }

        private void clearAll()
        {
            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txt_Order.Clear();
            cmbOrder.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;
            pbBarcode.InitialImage = null;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void BarcodeGenerate_Load(object sender, EventArgs e)
        {
            loadCmbCategories();
            LoaCmbUnit();
            GenerateID_Order();
            LoadCmbOrder();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            /* Iron Barcode Liabrary
            // GeneratedBarcode MyBarCode = BarcodeWriter.CreateBarcode( UPCBarcode.ToString(), BarcodeWriterEncoding.UPCA);

            // // Any text (or commonly, the value of the barcode) can be added to the image in a default or specified font.
            // // Text positions are automatically centered, above or below.  Fonts that are too large for a given image are automatically scaled down.

            // // Resize, add Margins and Check final Image Dimensions
            //MyBarCode.ResizeTo(150, 60); // pixels
            // //MyBarCode.SetMargins(0, 20, 0, 20);

            // MyBarCode.AddBarcodeValueTextBelowBarcode();
            // MyBarCode.AddAnnotationTextAboveBarcode("Zakria cash& carry.", new Font(new FontFamily("Arial"), 12, FontStyle.Regular, GraphicsUnit.Pixel), Color.DarkSlateBlue);




            // MyBarCode.SaveAsPng(@"D:\" + cmbOrder.Text+".png");
             //BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode(@"C:\Users\Toqeer Abbas\Desktop\abc.png");
             //MessageBox.Show(Result.ToString());

             */

            /* Barcode Lib
            // Create an linear barcode object (BarcodeLib.Barcode.Linear)
            BarcodeLib.Barcode.Linear barcode = new BarcodeLib.Barcode.Linear();

            // Set barcode type to Code 39
            barcode.Type = BarcodeLib.Barcode.BarcodeType.CODE39;

            // Set your encoded barcode value
            barcode.Data = cmbOrder.Text;

            // Other barcode settings
            // Save barcode image into your system

            // Draw barcode image into a PNG file
            barcode.drawBarcode(@"D:\" + cmbOrder.Text + ".png");

            */

            //// On Barcode Lib
            //// Create linear barcode object
            //Linear barcode = new Linear();
            //// Set barcode symbology type to Code-39
            //barcode.Type = BarcodeType.CODE39;
            //// Set barcode data to encode
            //barcode.Data = "0123456789";
            //// Set barcode bar width (X dimension) in pixel
            //barcode.X = 1;
            //// Set barcode bar height (Y dimension) in pixel
            //barcode.Y = 60;
            //// Draw & print generated barcode to png image file
            //barcode.drawBarcode(@"D:\" + cmbOrder.Text + ".png");


            //// instantiate a writer object
            //var barcodeWriter = new BarcodeWriter();

            //// set the barcode format
            //barcodeWriter.Format = BarcodeFormat.CODE_128;

            //// write text and generate a 2-D barcode as a bitmap
            //barcodeWriter
            //    .Write(cmbOrder.Text)
            //    .Save(@"D:\" + cmbOrder.Text + ".png");

            //RadBarcode radBarcode1 = new RadBarcode();
            //Telerik.WinControls.UI.Barcode.Symbology.Code128A barcode = new Code128A();

            //Telerik.WinControls.UI.Barcode.Symbology.Code128 barcode = new Telerik.WinControls.UI.Barcode.Symbology.Code128();

            //radBarcode1.Value = "123456";
            //radBarcode1.Text = "Zakriya Cash & Carry";
            // // radBarcode1.ImageScalingSize = (Size.10, Size.20 );
            //radBarcode1.LoadElementTree();
            //string fileName = @"D:\" + cmbOrder.Text + ".png";
            //Image img = radBarcode1.ExportToImage();
            //img.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            //Process.Start(fileName);

            RadBarcode radBarcode1 = new RadBarcode();
            Telerik.WinControls.UI.Barcode.Symbology.Code39Extended code39Extended1 = new Telerik.WinControls.UI.Barcode.Symbology.Code39Extended();
            radBarcode1.Symbology = code39Extended1;
            radBarcode1.Value = "123456";
            radBarcode1.LoadElementTree();
            string fileName = @"..\..\exported.png";
            Image img = radBarcode1.ExportToImage();
            img.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            Process.Start(fileName);


            Image img1 = Image.FromFile(@"D:\" + cmbOrder.Text + ".png");
            //Image img1 = scaleImage(img, 100, 100);
            pbBarcode.Image = img1;
            pbBarcode.SizeMode = PictureBoxSizeMode.Zoom;

        }
        public Image scaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }
        private void cmbOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrderNo = cmbOrder.Text;
            try
            {
                BarcodeGenerateDAL obj = new BarcodeGenerateDAL();
                BarcodeGenerateBAL objBAL = new BarcodeGenerateBAL();
                objBAL.Order_No = OrderNo;
                dt = obj.LoadByOrderNo(objBAL);
                UPCBarcode = Convert.ToInt32(dt.Rows[0]["UPC Barcode"]);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            }

        private void cmbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Guid.TryParse(cmbProduct.SelectedValue.ToString(), out Product_id);
        }

         
    }

    }
