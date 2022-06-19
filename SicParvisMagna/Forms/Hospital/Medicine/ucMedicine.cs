using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Library;
using System.Data.SqlClient;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms.Hospital.Medicine
{
    public partial class ucMedicine : UserControl
    {
        int TotalrowIndex = 0;
        List<Guid> removed_medicines_id = new List<Guid>();
        Medicine_CategoryBAL Medicine_Category_OBJ = new Medicine_CategoryBAL();
        Medicine_CategoryDAL medicine_CategoryDAL_db = new Medicine_CategoryDAL();
        MedicineBAL Medicine_obj = new MedicineBAL();
        MedicineDAL medicine_db = new MedicineDAL();
        DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btn_delrow = new DataGridViewButtonColumn();
        ValidationRegex objvr = new ValidationRegex();
        private Guid id = Guid.Empty;
        private FormMain formMain;
        public ucMedicine(FormMain formMain)
        {
            InitializeComponent();
            Load_Grid();
            inti();
            this.formMain = formMain;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formMain.loadMedicineBackForm();
            //FormMain.loadMedicineBackForm();
        }
        public ucMedicine(Guid invoice_id)
        {
            id = invoice_id;
            InitializeComponent();

            inti();
            FillMedicineCat_value();
            FillMedicines_in_grid();
        }

        //Validation Methodvar


        //KeyUP
        private void txt_Name_KeyUp(object sender, KeyEventArgs e)
        {
        }

        //ON Leave
        private void txt_Name_Leave(object sender, EventArgs e)
        {
        }
        public void inti()
        {

            this.txt_CategoryName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyUp);
            this.txt_CategoryName.Leave += new System.EventHandler(this.txt_Name_Leave);


        }
        public void FillMedicineCat_value()
        {
            txt_CategoryName.Text = medicine_CategoryDAL_db.LoadAll().Where(m => m.Medicine_Category_id == id).FirstOrDefault().name;
        }
        public void FillMedicines_in_grid()
        {

            PricingDAL pricingDB = new PricingDAL();
            Load_Grid();
            int i = 0;
            foreach (var item in medicine_db.LoadAll().Where(m => m.Medicine_Category_id == id).ToList())
            {
                addRow();
                gridMedicine.Rows[i].Cells["name"].Value = item.name;
                gridMedicine.Rows[i].Cells["rs"].Value = item.rs;
                gridMedicine.Rows[i].Cells["rm"].Value = item.rm;
                gridMedicine.Rows[i].Cells["OPN"].Value = item.opn;
                gridMedicine.Rows[i].Cells["QIE"].Value = item.qie;
                gridMedicine.Rows[i].Cells["company_name"].Value = item.company_name;
                gridMedicine.Rows[i].Cells["formula_name"].Value = item.formula_name;
                gridMedicine.Rows[i].Cells["ID"].Value = item.Medicine_id;

                gridMedicine.Rows[i].Cells["InStock"].Value = item.InStock;
                i++;
            }
            //  CalculateTotal();
        }
        public void Load_Grid()
        {
            gridMedicine.Columns.Add("name", "Medicine Name");        //0
            gridMedicine.Columns["name"].Width = 325;
            gridMedicine.Columns.Add("rs", "RS");                   //1  
            gridMedicine.Columns.Add("rm", "RM");                   //2          
            //gridMedicine.Columns.Add("price", "Price");             //
            //gridMedicine.Columns.Add("quantity", "quantity");          //
            //gridMedicine.Columns.Add("total_price", "Total Price");          // 
            gridMedicine.Columns.Add("company_name", "Company Name");         //3   
            gridMedicine.Columns["company_name"].Width = 250;
            gridMedicine.Columns.Add("formula_name", "Formula Name");          //4
            gridMedicine.Columns["formula_name"].Width = 250;

            gridMedicine.Columns.Add(btn_newrow);
            btn_newrow.HeaderText = "Add";                                              //5
            btn_newrow.Text = "Add Medicine";
            btn_newrow.Name = "btn_newrow";
            btn_newrow.UseColumnTextForButtonValue = true;

            gridMedicine.Columns.Add(btn_delrow);                                        //6
            btn_delrow.HeaderText = "Delete";
            btn_delrow.Text = "Delete Medicine";
            btn_delrow.Name = "btn_delrow";
            btn_delrow.UseColumnTextForButtonValue = true;

            gridMedicine.Columns.Add("ID", "ID");  //7


            gridMedicine.Columns.Add("OPN", "OPN");  //8
            gridMedicine.Columns["OPN"].DisplayIndex = 2;
            gridMedicine.Columns["OPN"].HeaderText = "Opened";

            gridMedicine.Columns.Add("QIE", "QIE");  //8
            gridMedicine.Columns["QIE"].DisplayIndex = 4;


            DataGridViewCheckBoxColumn cbc = new DataGridViewCheckBoxColumn();
            cbc.HeaderText = "InStock";
            cbc.Name = "InStock";


            gridMedicine.Columns.Add(cbc);  //8
            gridMedicine.Columns["InStock"].DisplayIndex = 4;


            gridMedicine.Columns["RM"].HeaderText = "Packed";

            gridMedicine.Columns[7].Visible = false;

            if (id == Guid.Empty)
                addRow();
        }
        public void ValidateRS_RM()
        {
            for (int i = 0; i < gridMedicine.RowCount; i++)
            {
                try
                {
                    double RS = Convert.ToDouble(gridMedicine.Rows[i].Cells[1].Value.ToString());
                }
                catch (Exception)
                {
                    gridMedicine.Rows[i].Cells[1].Value = 0;
                }

                try
                {
                    double qie = Convert.ToDouble(gridMedicine.Rows[i].Cells["QIE"].Value.ToString());
                }
                catch (Exception)
                {
                    gridMedicine.Rows[i].Cells["QIE"].Value = 0;
                }

                try
                {
                    double opn = Convert.ToDouble(gridMedicine.Rows[i].Cells["OPN"].Value.ToString());
                }
                catch (Exception)
                {
                    gridMedicine.Rows[i].Cells["OPN"].Value = 0;
                }

                try
                {
                    double RS = Convert.ToDouble(gridMedicine.Rows[i].Cells[2].Value.ToString());
                }
                catch (Exception)
                {
                    gridMedicine.Rows[i].Cells[2].Value = 0;
                }
            }
        }
        public void addRow()
        {
            string[] row = null;
            if (id != Guid.Empty)
            {
                row = new string[] { "", "0", "0", "", "", null, null, "0" };
            }
            else
            {
                row = new string[] { "", "0", "0", "", "", null, null, "0" };
            }
            if (row != null)
                gridMedicine.Rows.Add(row);
        }
        public void CalculateTotal()
        {
            for (int i = 0; i < gridMedicine.RowCount; i++)
            {
                double price = 0, quantity = 0;
                try
                {
                    price = Convert.ToDouble(gridMedicine.Rows[i].Cells[3].Value.ToString());
                }
                catch (Exception)
                {
                    gridMedicine.Rows[i].Cells[3].Value = 0;
                }
                try
                {
                    quantity += Convert.ToDouble(gridMedicine.Rows[i].Cells[4].Value.ToString());
                }
                catch (Exception)
                {
                    gridMedicine.Rows[i].Cells[4].Value = 0;
                }
                gridMedicine.Rows[i].Cells[5].Value = price * quantity;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
        }
        public Guid Insert_Medicine_Category()
        {
            Medicine_Category_OBJ = new Medicine_CategoryBAL();
            Medicine_Category_OBJ.name = txt_CategoryName.Text;
            Medicine_Category_OBJ.shortname = txt_CategoryName.Text;
            Medicine_Category_OBJ.description = txt_CategoryName.Text;
            Medicine_Category_OBJ.code = txt_CategoryName.Text;
            Medicine_Category_OBJ.Addby = "admin";
            Medicine_Category_OBJ.AddDate = DateTime.Now;
            Medicine_Category_OBJ.Flag = 1;
            medicine_CategoryDAL_db.Add(Medicine_Category_OBJ);
            return medicine_CategoryDAL_db.LoadAll().Max(m => m.Medicine_Category_id);
        }
        public void Update_Medicine_Category()
        {

            Medicine_Category_OBJ = medicine_CategoryDAL_db.LoadbyId(id).FirstOrDefault();
            if (Medicine_Category_OBJ != null)
            {
                Medicine_Category_OBJ.name = txt_CategoryName.Text;
                Medicine_Category_OBJ.shortname = txt_CategoryName.Text;
                Medicine_Category_OBJ.description = txt_CategoryName.Text;
                Medicine_Category_OBJ.code = txt_CategoryName.Text;
                Medicine_Category_OBJ.Editby = "admin";
                Medicine_Category_OBJ.EditDate = DateTime.Now;
                medicine_CategoryDAL_db.Update(Medicine_Category_OBJ);
            }
        }
        public void Insert_Medicines(Guid Medicine_Category_id)
        {
            if (Medicine_Category_id != Guid.Empty)
                for (int i = 0; i < gridMedicine.Rows.Count; i++)
                {
                    Medicine_obj = new MedicineBAL();
                    Medicine_obj.name = gridMedicine.Rows[i].Cells[0].Value.ToString();
                    Medicine_obj.shortname = gridMedicine.Rows[i].Cells[0].Value.ToString() + " | " + txt_CategoryName.Text;
                    Medicine_obj.description = gridMedicine.Rows[i].Cells[0].Value.ToString();
                    Medicine_obj.code = gridMedicine.Rows[i].Cells[0].Value.ToString();
                    try
                    {
                        Medicine_obj.InStock = Convert.ToBoolean(gridMedicine.Rows[i].Cells["InStock"].Value.ToString());
                    }
                    catch (Exception)
                    {
                        Medicine_obj.InStock = false;
                    }
                    try
                    {
                        Medicine_obj.opn = Convert.ToDouble(gridMedicine.Rows[i].Cells["OPN"].Value.ToString());
                    }
                    catch (Exception)
                    {
                        Medicine_obj.opn = 0;
                    }

                    try
                    {
                        Medicine_obj.qie = Convert.ToDouble(gridMedicine.Rows[i].Cells["QIE"].Value.ToString());
                    }
                    catch (Exception)
                    {
                        Medicine_obj.qie = 0;
                    }

                    try
                    {
                        Medicine_obj.rs = Convert.ToDouble(gridMedicine.Rows[i].Cells[1].Value.ToString());

                    }
                    catch (Exception)
                    {
                        Medicine_obj.rs = 0;

                    }
                    try
                    {
                        Medicine_obj.rm = Convert.ToDouble(gridMedicine.Rows[i].Cells[2].Value.ToString());

                    }
                    catch (Exception)
                    {

                        Medicine_obj.rm = 0;

                    }
                    //Medicine_obj.price = Convert.ToInt32(gridMedicine.Rows[i].Cells[3].Value.ToString());
                    //Medicine_obj.quantity = Convert.ToInt32(gridMedicine.Rows[i].Cells[4].Value.ToString());
                    //Medicine_obj.total_price = Convert.ToInt32(gridMedicine.Rows[i].Cells[5].Value.ToString());
                    Medicine_obj.company_name = gridMedicine.Rows[i].Cells["company_name"].Value.ToString();
                    Medicine_obj.formula_name = gridMedicine.Rows[i].Cells["formula_name"].Value.ToString();
                    Medicine_obj.Addby = "Admin";
                    Medicine_obj.AddDate = DateTime.Now;
                    Medicine_obj.Flag = 1;
                    Medicine_obj.Medicine_Category_id = Medicine_Category_id;
                    medicine_db.Add(Medicine_obj);

                }
        }

        public void Update_Medicines()
        {
            for (int i = 0; i < gridMedicine.Rows.Count; i++)
            {
                Medicine_obj = new MedicineBAL();
                Medicine_obj.Medicine_id = Guid.Parse(gridMedicine.Rows[i].Cells["ID"].Value.ToString());
                Medicine_obj.name = gridMedicine.Rows[i].Cells[0].Value.ToString();
                Medicine_obj.shortname = gridMedicine.Rows[i].Cells[0].Value.ToString() + " | " + txt_CategoryName.Text;
                Medicine_obj.description = gridMedicine.Rows[i].Cells[0].Value.ToString();
                Medicine_obj.code = gridMedicine.Rows[i].Cells[0].Value.ToString();
                try
                {
                    Medicine_obj.InStock = Convert.ToBoolean(gridMedicine.Rows[i].Cells["InStock"].Value.ToString());
                }
                catch
                {
                    Medicine_obj.InStock = false;
                }
                try
                {
                    Medicine_obj.rs = Convert.ToDouble(gridMedicine.Rows[i].Cells[1].Value.ToString());

                }
                catch (Exception)
                {
                    Medicine_obj.rs = 0;

                }
                try
                {
                    Medicine_obj.opn = Convert.ToDouble(gridMedicine.Rows[i].Cells["OPN"].Value.ToString());
                }
                catch (Exception)
                {
                    Medicine_obj.opn = 0;
                }

                try
                {
                    Medicine_obj.qie = Convert.ToDouble(gridMedicine.Rows[i].Cells["QIE"].Value.ToString());
                }
                catch (Exception)
                {
                    Medicine_obj.qie = 0;
                }
                try
                {
                    Medicine_obj.rm = Convert.ToDouble(gridMedicine.Rows[i].Cells[2].Value.ToString());

                }
                catch (Exception)
                {

                    Medicine_obj.rm = 0;

                }
                Medicine_obj.company_name = gridMedicine.Rows[i].Cells["company_name"].Value.ToString();
                Medicine_obj.formula_name = gridMedicine.Rows[i].Cells["formula_name"].Value.ToString();
                Medicine_obj.Editby = "Admin";
                Medicine_obj.EditDate = DateTime.Now;
                Medicine_obj.Medicine_Category_id = id;
                if (Medicine_obj.Medicine_id != null)
                {
                    medicine_db.Update(Medicine_obj);

                }
                else
                {
                    medicine_db.Add(Medicine_obj);

                }
            }
            foreach (var item in removed_medicines_id)
            {
                Medicine_obj.Medicine_id = item;
                medicine_db.Delete(Medicine_obj);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearAll()
        {
            id = Guid.Empty;

            txt_CategoryName.Text = "";

            gridMedicine.Rows.Clear();
            addRow();
            inti();
            btnSave.Text = "     Save";
        }
        private void Search()
        {
            if (id != Guid.Empty)
            {
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }
        private void Content(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                addRow();
            }
            if (e.ColumnIndex == 6 && gridMedicine.RowCount > 1)
            {

                Guid id = Guid.Parse(gridMedicine.Rows[e.RowIndex].Cells[7].Value.ToString());
                if (id != Guid.Empty)
                {
                    removed_medicines_id.Add(id);
                }

                gridMedicine.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void gridMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void gridVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void gridVoucher_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            ValidateRS_RM();
        }

        private void gridMedicine_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidateRS_RM();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ValidateRS_RM();
            if (id != Guid.Empty)
            {

                Update_Medicines();
            }
            else
            {

                Insert_Medicines(Insert_Medicine_Category());
            }
            ClearAll();
            inti();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (id != Guid.Empty)
            {

                PricingDAL pricingDB = new PricingDAL();
                Medicine_Category_OBJ.Medicine_Category_id = id;
                medicine_CategoryDAL_db.Delete(Medicine_Category_OBJ);
                foreach (var item in medicine_db.LoadAll().Where(m => m.Medicine_Category_id == id).ToList())
                {
                    medicine_db.Delete(item);

                    PricingBAL pricing = new PricingBAL();
                    foreach (var price in pricingDB.LoadAll().Where(m => m.item_id == item.Medicine_id && m.item_type == "Medicine"))
                    {
                        pricingDB.Delete(price);
                    }
                }
            }
            ClearAll();
            inti();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search();
        }
    }
}
