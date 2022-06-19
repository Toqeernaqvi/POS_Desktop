using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using SicParvisMagna.Library;
using System.Data.SqlClient;

namespace SicParvisMagna.Forms.PointOfSale
{
	public partial class ucManageProductVariantDetails : UserControl
	{
		GridViewComboBoxColumn cmbProductVariantDetail = new GridViewComboBoxColumn();
		private SqlConnection con = new SQLCon().getCon();
		GridViewComboBoxColumn cmb_Variant = new GridViewComboBoxColumn();
		GridViewComboBoxColumn cmb_VariantType = new GridViewComboBoxColumn();
		GridViewCommandColumn btn_newrow = new GridViewCommandColumn();
		GridViewCommandColumn btn_delrow = new GridViewCommandColumn();

		private Guid Product_Id = Guid.Empty;
		private Guid ProductCategoryId = Guid.Empty;
		private Guid Product_Variant_Id = Guid.Empty;
		private Guid Product_Variant_Detail_Id = Guid.Empty;
		private Guid Variant_id = Guid.Empty;
		private Guid BarcodeTypeId = Guid.Empty;
		private Guid Variant_Type_id = Guid.Empty;
		int variantCount = 0;
		int x = 0;//f=for product Frid

		public ucManageProductVariantDetails()
		{
			InitializeComponent();
			gridProductVariants.TitleText = "Product Variants";
			gridProductVariants.GridViewElement.TitleLabelElement.ForeColor = Color.DarkRed;
			gridProductVariants.GridViewElement.TitleLabelElement.Font = new Font("Consolas", 12, FontStyle.Bold);
			LoadCmbBarcodeType();
			Load_Grid_Columns();
		}



		public ucManageProductVariantDetails(Guid Product_Variant_id)
		{
			InitializeComponent();
			gridProductVariants.TitleText = "Product Variants";
			gridProductVariants.GridViewElement.TitleLabelElement.ForeColor = Color.DarkRed;
			gridProductVariants.GridViewElement.TitleLabelElement.Font = new Font("Consolas", 12, FontStyle.Bold);
			Load_Grid_Columns();
			Load_FormById(Product_Variant_id);
			//	loadProductVariantDetailGridByProduct_id(Product_Variant_id);
			loadGrid_by_ProductVariantID(Product_Variant_id);
			Product_Variant_Id = Product_Variant_id;

		}

		private void Load_FormById(Guid ProductVariant_id)
		{
			LoadCmbProduct();
			LoadCmbBarcodeType();
			ProductVariantDAL obj = new ProductVariantDAL();
			DataTable dt = new DataTable();

			dt = obj.LoadAllByProductVariant_id(ProductVariant_id);
			txtName.Text = dt.Rows[0]["Title"].ToString();
			txtShortName.Text = dt.Rows[0]["ShortName"].ToString();
			txtBarcode.Text = dt.Rows[0]["Barcode"].ToString();
			BarcodeTypeId = Guid.Parse(dt.Rows[0]["Barcode_Type_Id"].ToString());
			ProductCategoryId = Guid.Parse(dt.Rows[0]["Product_Category_Id"].ToString());
			if (BarcodeTypeId == Guid.Empty) { LoadCmbBarcodeType(); }

			else
				cmbBarcodeType.SelectedValue = BarcodeTypeId;


			Product_Id = Guid.Parse(dt.Rows[0]["Product_Id"].ToString());
			cmbProduct.SelectedValue = Product_Id;

		}

		//private void  loadProductVariantDetailGridByProduct_id(Guid id)
		//      {
		//	ProductVariantDetailDAL obj = new ProductVariantDetailDAL();
		//	DataTable dt = new DataTable();
		//	dt = obj.productVariantsDetails_LoadByProductVariantId(id);
		//	//gridProductVariants.DataSource = dt;
		//	//gridProductVariants.Columns[0].Width = 500;
		//	//gridProductVariants.Columns[1].Width = 200;

		//}
		public void Load_Grid_Columns()
		{
			//gridVariantDetails.Columns.Clear();

			try
			{
				////
				//ProductVariantDetailDAL objD = new ProductVariantDetailDAL();

				//cmbProductVariantDetail.HeaderText = "VariantDetail";
				//cmbProductVariantDetail.Name = "VariantDetail";
				//this.gridVariantDetails.Columns.Add(cmbProductVariantDetail);
				//cmbProductVariantDetail.DataSource = objD.LoadAll();
				//cmbProductVariantDetail.DisplayMember = "Title";
				//cmbProductVariantDetail.ValueMember = "Product_Variant_Detail_id";
				////gridVariantDetails.Columns[0].Width =  0;









				VariantsDAL objDAL = new VariantsDAL();

				cmb_Variant.HeaderText = "Variant Name";
				cmb_Variant.Name = "cmb_Variant";

				this.gridVariantDetails.Columns.Add(cmb_Variant);
				cmb_Variant.DataSource = objDAL.LoadAll();
				cmb_Variant.DisplayMember = "Title";
				cmb_Variant.ValueMember = "Variant_id";

				gridVariantDetails.Columns[0].Width = 200;

				//Product Coloumn
				VariantTypeDAL objPDAL = new VariantTypeDAL();

				cmb_VariantType.HeaderText = "Types";
				cmb_VariantType.Name = "cmb_VariantType";
				cmb_VariantType.DataSource = objPDAL.LoadAll();
				cmb_VariantType.DisplayMember = "Title";
				cmb_VariantType.ValueMember = "Variant_Type_Id";
				gridVariantDetails.Columns.Add(cmb_VariantType);

				gridVariantDetails.Columns["cmb_VariantType"].Width = 200;



				////Quantity Colunm
				//Quantity.HeaderText = "Qty";
				//Quantity.Name = "Quantity";

				//gridVariantDetails.Columns.Add(Quantity);
				//gridVariantDetails.Columns["Quantity"].Width = 100;


				//
				gridVariantDetails.Columns.Add(btn_newrow);
				btn_newrow.HeaderText = "Add";
				btn_newrow.UseDefaultText = true;
				btn_newrow.DefaultText = "   +  ";
				btn_newrow.Name = "btn_newrow";
				gridVariantDetails.Columns["btn_newrow"].Width = 100;
				gridVariantDetails.Columns.Add(btn_delrow);              //5
				btn_delrow.HeaderText = "Delete";
				btn_delrow.UseDefaultText = true;
				btn_delrow.DefaultText = "  -  "; ;
				btn_delrow.Name = "btn_delrow";
				gridVariantDetails.Columns["btn_delrow"].Width = 100;

			}
			catch (Exception e) { MessageBox.Show(e.ToString()); }
		}
		public void addRow_VariantsGrid()
		{
			GridViewRowInfo row = gridVariantDetails.Rows.AddNew();

		}

		private void clearAll()
		{
			try
			{
				cmbProduct.SelectedIndex = 0;
				cmbBarcodeType.SelectedIndex = 0;
				//gridVariantDetails.Rows.Clear();
				//addRow_VariantsGrid();
			}
			catch { }

		}
		private void loadGrid_by_ProductVariantID(Guid id)

		{
			try
			{





				ProductVariantDetailDAL obj = new ProductVariantDetailDAL();
				VariantTypeDAL objVTD = new VariantTypeDAL();
				DataTable dt = obj.LoadProductVariantDetail_ByProductVariantId(id);

				for (x = 0; x < dt.Rows.Count; x++)
				{
					if (gridVariantDetails.Rows.Count != dt.Rows.Count)
					{
						addRow_VariantsGrid();
					}

					//ProductVariantDetailDAL objD = new ProductVariantDetailDAL();
					//cmbProductVariantDetail.DataSource = objD.LoadAll();
					//cmbProductVariantDetail.DisplayMember = "Title";
					//cmbProductVariantDetail.ValueMember = "Product_Variant_Detail_id";
					//var  ProductVariantDetail = dt.Rows[x]["Product_Variant_Detail_id" ] ;
					//gridVariantDetails.Rows[x].Cells[0].Value = ProductVariantDetail;

					VariantsDAL objDAL = new VariantsDAL();
					cmb_Variant.DataSource = objDAL.LoadAll();
					cmb_Variant.DisplayMember = "Title";
					cmb_Variant.ValueMember = "Variant_id";

					var Variants = dt.Rows[x]["Variant_id"];
					gridVariantDetails.Rows[x].Cells["cmb_Variant"].Value = Variants;
					//



					cmb_VariantType.DataSource = objVTD.LoadAll();
					cmb_VariantType.DisplayMember = "Title";
					cmb_VariantType.ValueMember = "Variant_Type_Id";

					var Variant_Type_Id = dt.Rows[x]["Variant_Type_Id"];
					gridVariantDetails.Rows[x].Cells["cmb_VariantType"].Value = Variant_Type_Id;

					//


					//var Quantity = dt.Rows[x]["Quantity"];
					//gridVariantDetails.Rows[x].Cells["Quantity"].Value = Quantity;

					//if (x < dt.Rows.Count - 1)
					//	addRow_VariantsGrid();
					//   x = gridVariantDetails.RowCount;
					// x--;

				}
			}
			catch (Exception ee)
			{
				Load_Grid_Columns();

			}

		}

		private void LoadCmbProduct()
		{
			ProductDAL objDAL = new ProductDAL();
			cmbProduct.DataSource = objDAL.LoadAll();
			cmbProduct.ValueMember = "id";
			cmbProduct.DisplayMember = "Title";
			cmbProduct.SelectedIndex = -1;
		}


		private void LoadCmbBarcodeType()
		{
			BarcodeTypeDAL objDAL = new BarcodeTypeDAL();
			cmbBarcodeType.DataSource = objDAL.LoadAll();
			cmbBarcodeType.ValueMember = "id";
			cmbBarcodeType.DisplayMember = "Name";
			cmbBarcodeType.SelectedIndex = 0;
		}

		private void labelMessage()
		{
			var t = new Timer();
			t.Interval = 3000; // it will Tick in 3 seconds
			t.Tick += (s, e) =>
			{
				lblConfirmationMsg.Hide();
				t.Stop();
			};
			t.Start();
		}

		private void gridVariantDetails_CellClick(object sender, GridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 2)
			{
				addRow_VariantsGrid();
			}
			if (e.ColumnIndex == 3)
			{
				if (gridVariantDetails.Rows.Count > 1)
					this.gridVariantDetails.Rows.RemoveAt(e.RowIndex);

			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			//Check Barcode Exist in Database or not

			int res = BarcodeCheckInDatabase(txtBarcode.Text);
			if (res == 0) {

				try
				{

					ProductVariantDetailDAL objD = new ProductVariantDetailDAL();
					if (Product_Variant_Id != Guid.Empty)
					{
						ProductVariantBAL obj = new ProductVariantBAL();
						ProductVariantDAL objDAL = new ProductVariantDAL();
						obj.Product_Category_Id = ProductCategoryId;
						obj.Title = txtName.Text;
						obj.ShortName = txtShortName.Text;
						obj.Product_Id = Product_Id;
						obj.Product_Variant_Id = Product_Variant_Id;
						obj.Barcode_Type_Id = BarcodeTypeId;
						obj.Barcode = txtBarcode.Text;
						obj.EditBy = "Admin";
						obj.EditDate = DateTime.Now;
						obj.Flag = 1;
						objDAL.Update(obj);
						lblConfirmationMsg.Text = "Barcode Added";
						labelMessage();
					}
					objD.DeleteByProductVariantId(Product_Variant_Id);


					//DataTable dt = objD.LoadProductVariantDetail_ByProductVariantId(Product_Variant_Id);
					for (int x = 0; x < gridVariantDetails.RowCount; x++)
					{

						//}
						//catch
						//{
						//	Product_Variant_Detail_Id = Guid.Empty;
						//}


						ProductVariantDetailsBAL objDetailBAL = new ProductVariantDetailsBAL();
						Guid.TryParse(gridVariantDetails.Rows[x].Cells["cmb_Variant"].Value.ToString(), out Variant_id);
						objDetailBAL.variant_Id = Variant_id;
						Guid.TryParse(gridVariantDetails.Rows[x].Cells["cmb_VariantType"].Value.ToString(), out Variant_Type_id);
						objDetailBAL.variant_Type_Id = Variant_Type_id;
						objDetailBAL.Product_Variant_Id = Product_Variant_Id;
						objDetailBAL.Quantity = " ";
						objDetailBAL.Title = "";
						objDetailBAL.ShortName = "";
						objDetailBAL.Description = "";
						objDetailBAL.Flag = 1;

						//Guid.TryParse(gridVariantDetails.Rows[x].Cells["cmbProductVariantDetail"].Value.ToString(), out Product_Variant_Detail_Id);
						//if (Product_Variant_Id != Guid.Empty)
						//{

						//	objD.DeleteByProductVariantId(Product_Variant_Id);
						//	objDetailBAL.AddBy = "Admin";
						//	objDetailBAL.AddDate = DateTime.Now;
						//	objD.Add(objDetailBAL);
						//	lblConfirmationMsg.Text = "Product Variants Add Succesfully !";

						//}
						//else
						//{
						//
						objDetailBAL.AddBy = "Admin";
						objDetailBAL.AddDate = DateTime.Now;
						objD.Add(objDetailBAL);
						lblConfirmationMsg.Text = "Product Variants Add Succesfully !";


						}


					}
			catch { }
				clearAll();
				labelMessage();
				loadGrid_by_ProductVariantID(Product_Variant_Id);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			clearAll();
		}




		private void gridVariantDetails_CellEditorInitialized(object sender, GridViewCellEventArgs e)
		{


			VariantTypeDAL objVTD = new VariantTypeDAL();
			DataTable dttt = new DataTable();
			if (e.Column.HeaderText == "Types")
			{
				try
				{
					Variant_id = Guid.Parse(e.Row.Cells["cmb_Variant"].Value.ToString());
				}
				catch { }
				if (this.gridVariantDetails.CurrentRow.Cells["cmb_Variant"].Value != DBNull.Value
					&& this.gridVariantDetails.CurrentRow.Cells["cmb_Variant"].Value != null)
				{
					RadDropDownListEditor editor = (RadDropDownListEditor)this.gridVariantDetails.ActiveEditor;
					RadDropDownListEditorElement editorElement = (RadDropDownListEditorElement)editor.EditorElement;
					dttt = objVTD.LoadByVariant(Variant_id);
					//fullList = Utility.GetListByDataTable(dt);
					editorElement.DataSource = Utility.GetVariantListByDataTable(dttt);

					// editorElement.SelectedValue = null;
					editorElement.SelectedValue = this.gridVariantDetails.CurrentCell.Value;
				}
			}





			////Break Repition
			////- User can select one type of variant at time

			//Guid id = Guid.Empty;
			//if (e.Column.HeaderText == "Variant Name")
			//{
			//	VariantsDAL obj = new VariantsDAL();
			//	DataTable dt = new DataTable();
			//	dt = obj.LoadAll();
			//	for (int y = 0; y < dt.Rows.Count; y++)
			//	{

			//			id = Guid.Parse(dt.Rows[y]["Variant_id"].ToString()) ;
			//			if(Variant_id == id) 
			//		{
			//			variantCount++;
			//			if (variantCount > 1)
			//			{
			//				MessageBox.Show("You can't select variant more than one time." +
			//					"Please Select another Variant");
			//			}
			//		}
			//	}
			//}
		}

		private void gridVariantDetails_CellEndEdit(object sender, GridViewCellEventArgs e)
		{

			//Break Repition
			//- User can select one type of variant at time

			Guid id = Guid.Empty;
			if (e.Column.HeaderText == "Variant Name")
			{
				VariantsDAL obj = new VariantsDAL();
				DataTable dtt = new DataTable();
				dtt = obj.LoadAll();
				for (int y = 0; y < dtt.Rows.Count; y++)
				{
					variantCount = 0;
					id = Guid.Parse(dtt.Rows[y]["Variant_id"].ToString());  //Get id from Variants Table

					for (int z = 0; z < gridVariantDetails.RowCount; z++)
					{
						Guid.TryParse(gridVariantDetails.Rows[z].Cells["cmb_Variant"].Value.ToString(), out Variant_id); // Get Variant_id from VariantDetails 


						if (Variant_id == id)
						{
							variantCount++;

						}

						if (variantCount > 1)
						{
							MessageBox.Show("You can't select variant more than one time." +
								"Please Select another Variant");


							this.gridVariantDetails.Rows.RemoveAt(e.RowIndex);

						}
					}


				}


			}
		}

		private void cmbProduct_SelectionChangeCommitted_1(object sender, EventArgs e)
		{
			if (cmbProduct.SelectedItem != null)
			{
				//gridVariantDetails.Rows.Clear();
				//addRow_VariantsGrid();
			}
			//Add Product Variant
			ProductVariantBAL objPVB = new ProductVariantBAL();
			ProductVariantDAL objPVD = new ProductVariantDAL();

			try
			{
				Guid.TryParse(cmbProduct.SelectedValue.ToString(), out Product_Id);
				ProductVariantDAL objD = new ProductVariantDAL();
				DataTable dt = new DataTable();
				dt = objD.GetProductVariantId_byProductId(Product_Id);
				Product_Variant_Id = Guid.Parse(dt.Rows[0]["Product_Variant_Id"].ToString());
				if (Product_Variant_Id == Guid.Empty)
				{
					// For Add Default Variant of Product
					objPVB.Product_Id = Product_Id;
					objPVB.Title = "Default Variant  " + cmbProduct.Text;
					objPVB.ShortName = "";
					objPVB.Barcode = "";
					objPVB.AddBy = "Admin";
					objPVB.AddDate = DateTime.Now;
					objPVD.Add(objPVB);
					dt = objD.GetProductVariantId_byProductId(Product_Id);
					Product_Variant_Id = Guid.Parse(dt.Rows[0]["Product_Variant_Id"].ToString());
				}
				//	loadGrid_by_ProductVariantID(Product_Variant_Id);
			}
			catch
			{
				DataTable dt = new DataTable();
				ProductVariantDAL objD = new ProductVariantDAL();


				if (Product_Variant_Id == Guid.Empty)
				{
					// For Add Default Variant of Product
					objPVB.Product_Id = Product_Id;
					objPVB.Title = "Default Variant  " + cmbProduct.Text;
					objPVB.ShortName = "";
					objPVB.Barcode = "";
					objPVB.AddBy = "Admin";
					objPVB.AddDate = DateTime.Now;
					objPVD.Add(objPVB);
					dt = objD.GetProductVariantId_byProductId(Product_Id);
					Product_Variant_Id = Guid.Parse(dt.Rows[0]["Product_Variant_Id"].ToString());
				}
				//	loadGrid_by_ProductVariantID(Product_Variant_Id);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			POSMain.loadProduct(Product_Id, "");
		}

		private void ucManageProductVariantDetails_Load(object sender, EventArgs e)
		{
			addRow_VariantsGrid();
		}


		private void cmbBarcodeType_SelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				Guid.TryParse(cmbBarcodeType.SelectedValue.ToString(), out BarcodeTypeId);
			}
			catch { }
		}

		private void btnAddNewVariant_Click(object sender, EventArgs e)
		{
			POSMain.loadVariants();
		}

      private int BarcodeCheckInDatabase(string barcode)
		{
			if (barcode.Length>5)
			{
				try
				{
					con.Open();
					using (var sqlCommand = new SqlCommand("SELECT COUNT(*) from  Product_Variant where Barcode =  '" + barcode + "'", con))
					{

						SqlDataReader reader = sqlCommand.ExecuteReader();
						reader.Dispose();
						DataTable dt = new DataTable();
						dt.Load(reader);
						int numRows = dt.Rows.Count;

						if (numRows>0)
						{
							MessageBox.Show("Record Already Exists.");
							//lblMessage.Text = "Record Already Exists.";
							txtBarcode.Clear();


							reader.Close();
							reader.Dispose();
							con.Close();

							return 1;
						}
						else
						{
							//MessageBox.Show("Record Not Exists.");
							//lblMessage.Text = "Record Not Exists.";
							return 0;

							reader.Close();
							reader.Dispose();
							con.Close();
						}

						reader.Close();
						reader.Dispose();
						con.Close();

					}
				}
				catch { }
			}
			return 0;


		}
	
    }
}
