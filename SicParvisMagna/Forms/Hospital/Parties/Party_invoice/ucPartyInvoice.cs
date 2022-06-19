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

namespace SicParvisMagna.Forms.Hospital.Parties.Party_invoice
{
    public partial class ucPartyInvoice : UserControl
    {
        private FormMain formMain;

        int TotalrowIndex = 0;
        List<int> removed_medicines_id = new List<int>();
        List<party_invoice_medicineBAL> removedItemsList = new List<party_invoice_medicineBAL>();
        PricingDAL pricing_DB = new PricingDAL();
        party_invoiceBAL party_invoice = new party_invoiceBAL();
        party_invoiceDAL party_invoice_db = new party_invoiceDAL();
        party_invoice_medicineBAL party_invoice_medicine = new party_invoice_medicineBAL();
        party_invoice_medicineDAL party_invoice_medicine_db = new party_invoice_medicineDAL();
        DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btn_delrow = new DataGridViewButtonColumn();

        DataGridViewComboBoxColumn cmbx_medicine = new DataGridViewComboBoxColumn();
        ValidationRegex objvr = new ValidationRegex();
        private Guid id = Guid.Empty;
        public ucPartyInvoice(FormMain formMain)
        {
            InitializeComponent();
            LoadParty();
            Load_Grid();
            inti();
            this.formMain = formMain;

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
          //  formMain.loadPartyIndexForm();
            //FormMain.loadPartyIndexForm();
        }
        public ucPartyInvoice(Guid invoice_id)
        {
            id = invoice_id;
            InitializeComponent();
            LoadParty();
            inti();
            FillMedicineCat_value();
            FillMedicines_in_grid();
        }

        public void LoadParty()
        {
            PartyDAL party_db = new PartyDAL();
            combo_Party.DataSource = party_db.LoadAll();
            combo_Party.DisplayMember = "name";
            combo_Party.ValueMember = "p_id";
            combo_Party.SelectedIndex = -1;
        }
        private void txt_Name_KeyUp(object sender, KeyEventArgs e)
        {
        }

        //ON Leave
        private void txt_Name_Leave(object sender, EventArgs e)
        {

        }

        public void inti()
        {

            this.txt_EntryNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyUp);
            this.txt_EntryNo.Leave += new System.EventHandler(this.txt_Name_Leave);


        }
        public void FillMedicineCat_value()
        {
            var party_invoice_medicineOBJ = party_invoice_db.LoadAll().Where(m => m.party_invoice_id == id).FirstOrDefault();
            txt_EntryNo.Text = party_invoice_medicineOBJ.entry_no.ToString();
            txt_CustomerNo.Text = party_invoice_medicineOBJ.customer_no.ToString();
            combo_Party.SelectedValue = party_invoice_medicineOBJ.p_id;
            try { dtp_Date.Value = party_invoice_medicineOBJ.date; }
            catch { }
        }
        public void FillMedicines_in_grid()
        {

            Load_Grid();
            int i = 0;
            foreach (var item in party_invoice_medicine_db.LoadAll().Where(m => m.party_invoice_id == id).OrderBy(m => m.medicine_id).ToList())
            {
                addRow();
                gridPartyInvoice.Rows[i].Cells[0].Value = item.medicine_id;
                gridPartyInvoice.Rows[i].Cells[1].Value = item.description;
                gridPartyInvoice.Rows[i].Cells["price"].Value = item.price;
                gridPartyInvoice.Rows[i].Cells[3].Value = item.quantity;
                gridPartyInvoice.Rows[i].Cells[4].Value = item.discount_percentage;
                gridPartyInvoice.Rows[i].Cells[5].Value = item.discount_amount;
                gridPartyInvoice.Rows[i].Cells[6].Value = item.tax_percentage;
                gridPartyInvoice.Rows[i].Cells[7].Value = item.tax_amount;
                gridPartyInvoice.Rows[i].Cells["net_amount"].Value = item.net_amount;
                gridPartyInvoice.Rows[i].Cells[11].Value = item.party_invoice_medicine_id;
                gridPartyInvoice.Rows[i].Cells["Date"].Value = item.Date;
                gridPartyInvoice.Rows[i].Cells["packprice"].Value = item.packprice;

                i++;
            }
            CalculateTotal();
            LoadPriceQuantity();
        }
        public void Load_Grid()
        {
            cmbx_medicine.HeaderText = "Medicines";
            cmbx_medicine.Name = "cmb_item";
            gridPartyInvoice.Columns.Add(cmbx_medicine);
            MedicineDAL medicine_db = new MedicineDAL();                     ///0   
            cmbx_medicine.DataSource = medicine_db.LoadAll();
            cmbx_medicine.DisplayMember = "shortname";
            cmbx_medicine.ValueMember = "medicine_id";
            gridPartyInvoice.Columns[0].Width = 250;

            gridPartyInvoice.Columns.Add("description", "Description");        //1
            gridPartyInvoice.Columns["description"].Width = 250;
            gridPartyInvoice.Columns[1].ReadOnly = true;

            gridPartyInvoice.Columns.Add("price", "Price");             //2
            gridPartyInvoice.Columns[2].ReadOnly = false;

            gridPartyInvoice.Columns.Add("quantity", "quantity");          //3
            gridPartyInvoice.Columns[3].ReadOnly = false;

            gridPartyInvoice.Columns.Add("discount_percentage", "Discount Percentage");          //4
            gridPartyInvoice.Columns.Add("discount_amount", "Discount Amount");          //5
            gridPartyInvoice.Columns[5].ReadOnly = true;
            gridPartyInvoice.Columns.Add("tax_percentage", "Tax Percentage");          //6
            gridPartyInvoice.Columns.Add("tax_amount", "tax_amount");          //7
            gridPartyInvoice.Columns[7].ReadOnly = true;
            gridPartyInvoice.Columns.Add("net_amount", "Net Amount");          //8  
            gridPartyInvoice.Columns[8].ReadOnly = true;

            gridPartyInvoice.Columns.Add(btn_newrow);
            btn_newrow.HeaderText = "Add";                                              //9
            btn_newrow.Text = "Add Invoice Medicine";
            btn_newrow.Name = "btn_newrow";
            btn_newrow.UseColumnTextForButtonValue = true;
            gridPartyInvoice.Columns[9].Width = 200;
            gridPartyInvoice.Columns.Add(btn_delrow);                                        //10
            btn_delrow.HeaderText = "Delete";
            btn_delrow.Text = "Delete Invoice Medicine";
            btn_delrow.Name = "btn_delrow";
            btn_delrow.UseColumnTextForButtonValue = true;
            gridPartyInvoice.Columns[10].Width = 200;

            gridPartyInvoice.Columns.Add("ID", "ID");  //11
            gridPartyInvoice.Columns[11].Visible = false;
            gridPartyInvoice.Columns.Add("Date", "Date");
            gridPartyInvoice.Columns["Date"].Visible = false;


            gridPartyInvoice.Columns.Add("packprice", "PackPrice");             //13
            gridPartyInvoice.Columns["packprice"].ReadOnly = false;        //13
            gridPartyInvoice.Columns["packprice"].DisplayIndex = 3;

            if (id == Guid.Empty)
                addRow();
        }
        public void addRow()
        {
            string[] row = null;
            if (id != null)
            {
                row = new string[] { null, "", "0", "0", "0", "0", "0", "0", "0", null, null, "0", "0", "0" };
            }
            else
            {
                row = new string[] { null, "", "0", "0", "0", "0", "0", "0", "0", null, null, "0", "0", "0" };
            }
            if (row != null)
                gridPartyInvoice.Rows.Add(row);
        }
        public void CalculateTotal()
        {
            for (int i = 0; i < gridPartyInvoice.RowCount; i++)
            {
                double price = 0, quantity = 0, packprice = 0, total = 0, discount_percentage = 0, discount_amount = 0, tax_percentage = 0, tax_amount = 0, net_amount = 0;
                try
                {
                    price = (double)Convert.ToDouble(gridPartyInvoice.Rows[i].Cells[2].Value.ToString());
                }
                catch (Exception)
                {
                    gridPartyInvoice.Rows[i].Cells[2].Value = 0;
                }
                try
                {
                    packprice = (double)Convert.ToDouble(gridPartyInvoice.Rows[i].Cells["packprice"].Value.ToString());
                }
                catch (Exception)
                {
                    gridPartyInvoice.Rows[i].Cells["packprice"].Value = 0;
                }
                try
                {
                    quantity = Convert.ToDouble(gridPartyInvoice.Rows[i].Cells[3].Value.ToString());
                }
                catch (Exception)
                {
                    gridPartyInvoice.Rows[i].Cells[3].Value = 0;
                }
                total = packprice * quantity;
                try
                {
                    discount_percentage = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[4].Value.ToString()) / 100;
                    if (discount_percentage > 1.0)
                    {
                        gridPartyInvoice.Rows[i].Cells[4].Value = 100;
                        discount_percentage = (float)1.0;
                    }
                }
                catch (Exception)
                {
                    gridPartyInvoice.Rows[i].Cells[4].Value = 0;
                }
                discount_amount = discount_percentage * total;
                gridPartyInvoice.Rows[i].Cells[5].Value = discount_amount;

                try
                {
                    tax_percentage = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[6].Value.ToString()) / 100;
                    if (tax_percentage > 1.0)
                    {
                        gridPartyInvoice.Rows[i].Cells[6].Value = 100;
                        tax_percentage = (float)1.0;
                    }
                }
                catch (Exception)
                {
                    gridPartyInvoice.Rows[i].Cells[6].Value = 0;
                }
                tax_amount = tax_percentage * total;
                net_amount = (total - discount_amount) + tax_amount;

                gridPartyInvoice.Rows[i].Cells[7].Value = tax_amount;

                gridPartyInvoice.Rows[i].Cells[8].Value = net_amount;

            }
        }
        public void LoadPriceQuantity()
        {
            //MedicineDAL medicine_db = new MedicineDAL();
            //for (int i = 0; i < gridPartyInvoice.Rows.Count; i++)
            //{
            //    try
            //    {
            //        int medicine_id = Convert.ToInt32(gridPartyInvoice.Rows[i].Cells[0].Value.ToString());
            //        var medicine = medicine_db.LoadbyId(medicine_id);
            //        if (medicine != null)
            //        {
            //            gridPartyInvoice.Rows[i].Cells[1].Value = medicine.description;
            //            PricingDAL pricingDB = new PricingDAL();
            //            PricingBAL pricing = new PricingBAL();
            //            pricing = pricingDB.LoadAll().Where(m => m.item_id == medicine_id && m.item_type == "Medicine" && m.qty > 0).OrderByDescending(m => m.Date).Take(1).FirstOrDefault();
            //            if (pricing != null)
            //            {
            //                gridPartyInvoice.Rows[i].Cells[2].Value = pricing.price;
            //                gridPartyInvoice.Rows[i].Cells[3].Value = pricing.qty;
            //            }
            //            else
            //            {
            //                gridPartyInvoice.Rows[i].Cells[2].Value = 0;
            //                gridPartyInvoice.Rows[i].Cells[3].Value = 0;
            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {

            //    }

            // }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private bool Validated()
        {
            if (!(combo_Party.SelectedIndex >= 0))
            {
                lblError_Party.Text = " Party Required!";
                return false;
            }
            else
                lblError_Party.Text = "";

            return true;
        }

        public Guid Insert_Party_invoice()
        {
            party_invoice = new party_invoiceBAL();
            party_invoice.entry_no = combo_Party.Text + " | " + dtp_Date.Value.ToString("dd/MM/yyyy");// Convert.ToInt32(txt_EntryNo.Text);
            party_invoice.customer_no = 0;// Convert.ToInt32(txt_CustomerNo.Text);
            party_invoice.p_id = Guid.Parse(combo_Party.SelectedValue.ToString());
            party_invoice.date = dtp_Date.Value;
            party_invoice_db.Add(party_invoice);
            return party_invoice_db.LoadAll().Max(m => m.party_invoice_id);
        }
        public void Update_Party_invoice()
        {

            party_invoice = party_invoice_db.LoadbyId(id).FirstOrDefault();
            if (party_invoice != null)
            {
                party_invoice.entry_no = txt_EntryNo.Text;
                party_invoice.customer_no = Convert.ToInt32(txt_CustomerNo.Text);
                party_invoice.p_id = Guid.Parse(combo_Party.SelectedValue.ToString());
                party_invoice.date = dtp_Date.Value;
                party_invoice_db.Update(party_invoice);
            }
        }
        public void Insert_Medicines(Guid party_invoice_id)
        {
            if (party_invoice_id != Guid.Empty)
                for (int i = 0; i < gridPartyInvoice.Rows.Count; i++)
                {
                    party_invoice_medicine = new party_invoice_medicineBAL();
                    party_invoice_medicine.medicine_id = Guid.Parse(gridPartyInvoice.Rows[i].Cells[0].Value.ToString());
                    party_invoice_medicine.description = gridPartyInvoice.Rows[i].Cells[1].Value.ToString();
                    party_invoice_medicine.price = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[2].Value.ToString());
                    party_invoice_medicine.packprice = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells["packprice"].Value.ToString());
                    party_invoice_medicine.quantity = (float)Convert.ToDouble(gridPartyInvoice.Rows[i].Cells[3].Value.ToString());
                    party_invoice_medicine.discount_percentage = Convert.ToInt32(gridPartyInvoice.Rows[i].Cells[4].Value.ToString());
                    party_invoice_medicine.discount_amount = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[5].Value.ToString());
                    party_invoice_medicine.tax_percentage = Convert.ToInt32(gridPartyInvoice.Rows[i].Cells[6].Value.ToString());
                    party_invoice_medicine.tax_amount = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[7].Value.ToString());
                    party_invoice_medicine.net_amount = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[8].Value.ToString());
                    party_invoice_medicine.Date = dtp_Date.Value;
                    party_invoice_medicine.party_invoice_id = party_invoice_id;
                    party_invoice_medicine_db.Add(party_invoice_medicine);
                    ManagePrices(party_invoice_medicine);
                }
        }
        public void DeletePriceInvoice(Guid invoiceId)
        {
            // GEt pricingMedicine by 
            pricing_DB.Delete(invoiceId);
        }

        public void DeletePrice(party_invoice_medicineBAL party_invoice_medicine)
        {
            // GEt pricingMedicine by 
           // PricingBAL medicinePrice = pricing_DB.LoadAll().Where(m => m.item_id == party_invoice_medicine.medicine_id && m.InvoiceID == party_invoice_medicine.party_invoice_id && m.status).OrderByDescending(m => m.Date).Take(1).FirstOrDefault();
            //if (medicinePrice != null)
            //{
            //    pricing_DB.Delete(medicinePrice);
            //}
        }

        public void ManagePrices(party_invoice_medicineBAL party_invoice_medicine)
        {
            // GEt pricingMedicine by 
            PricingBAL medicinePrice  = new PricingBAL();//pricing_DB.LoadAll().Where(m => m.item_id == party_invoice_medicine.medicine_id && m.InvoiceID == party_invoice_medicine.party_invoice_id && m.status).OrderByDescending(m => m.Date).Take(1).FirstOrDefault();
            if (medicinePrice != null)
            {
                medicinePrice.price = party_invoice_medicine.price;
                medicinePrice.qty = party_invoice_medicine.quantity;
                // medicinePrice.remaining  = party_invoice_medicine.quantity;
                medicinePrice.Date = dtp_Date.Value;
                medicinePrice.total = medicinePrice.price * medicinePrice.qty;
                medicinePrice.InvoiceID = party_invoice_medicine.party_invoice_id;
                medicinePrice.qty = party_invoice_medicine.quantity;
                pricing_DB.Update(medicinePrice);

            }
            else
            {
                medicinePrice = new PricingBAL();
                medicinePrice.item_id = party_invoice_medicine.medicine_id;
                medicinePrice.item_type = "Medicine";
                medicinePrice.price = party_invoice_medicine.price;
                medicinePrice.qty = party_invoice_medicine.quantity;
                medicinePrice.total = medicinePrice.price * medicinePrice.qty;
                medicinePrice.InvoiceID = party_invoice_medicine.party_invoice_id;
                medicinePrice.Date = dtp_Date.Value;
                pricing_DB.Add(medicinePrice);
            }
        }
        public void Update_Medicines()
        {
            for (int i = 0; i < gridPartyInvoice.Rows.Count; i++)
            {
                party_invoice_medicine = new party_invoice_medicineBAL();
                party_invoice_medicine = new party_invoice_medicineBAL();
                try
                {
                    party_invoice_medicine.medicine_id = Guid.Parse(gridPartyInvoice.Rows[i].Cells[0].Value.ToString());
                }
                catch
                {
                    continue;
                }
                party_invoice_medicine.description = gridPartyInvoice.Rows[i].Cells[1].Value.ToString();
                party_invoice_medicine.price = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[2].Value.ToString());
                party_invoice_medicine.packprice = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells["packprice"].Value.ToString());
                party_invoice_medicine.quantity = (float)Convert.ToDouble(gridPartyInvoice.Rows[i].Cells[3].Value.ToString());
                party_invoice_medicine.discount_percentage = Convert.ToInt32(gridPartyInvoice.Rows[i].Cells[4].Value.ToString());
                party_invoice_medicine.discount_amount = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[5].Value.ToString());
                party_invoice_medicine.tax_percentage = Convert.ToInt32(gridPartyInvoice.Rows[i].Cells[6].Value.ToString());
                party_invoice_medicine.tax_amount = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[7].Value.ToString());
                party_invoice_medicine.net_amount = (float)Convert.ToDecimal(gridPartyInvoice.Rows[i].Cells[8].Value.ToString());
                party_invoice_medicine.party_invoice_medicine_id = Guid.Parse(gridPartyInvoice.Rows[i].Cells[11].Value.ToString());

                party_invoice_medicine.party_invoice_id = id;
                try
                {
                    party_invoice_medicine.Date = Convert.ToDateTime(gridPartyInvoice.Rows[i].Cells["Date"].Value.ToString());
                }
                catch
                {
                    party_invoice_medicine.Date = dtp_Date.Value;
                }
                if (party_invoice_medicine.party_invoice_medicine_id != null)
                {
                    party_invoice_medicine_db.Update(party_invoice_medicine);
                }
                else
                {
                    party_invoice_medicine_db.Add(party_invoice_medicine);
                }
                ManagePrices(party_invoice_medicine);
            }
            foreach (var item in removedItemsList)
            {
                // party_invoice_medicine.party_invoice_medicine_id = item.party_invoice_medicine_id;
                party_invoice_medicine_db.Delete(item);
                DeletePrice(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearAll()
        {
            id = Guid.Empty;

            txt_EntryNo.Text = "";
            txt_CustomerNo.Text = "";
            combo_Party.SelectedIndex = -1;

            gridPartyInvoice.Rows.Clear();
            addRow();
            inti();
            btnSave.Text = "     Save";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            if (id != null)
            {
            }
        }

        private void gridPartyInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }
        private void Content(DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 9)
            {
                addRow();
            }
            if (e.ColumnIndex == 10 && gridPartyInvoice.RowCount > 1)
            {

                Guid partyInvoiceMedicineId = Guid.Parse(gridPartyInvoice.Rows[e.RowIndex].Cells[11].Value.ToString());
                Guid invoiceid = id;
                Guid medicineid = Guid.Empty;
                try
                {
                    medicineid = Guid.Parse(gridPartyInvoice.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                catch
                {

                }
                if (partyInvoiceMedicineId != null)
                {
                    party_invoice_medicineBAL obj = new party_invoice_medicineBAL();
                    obj.party_invoice_medicine_id = partyInvoiceMedicineId;
                    obj.party_invoice_id = id;
                    obj.medicine_id = medicineid;
                    //removed_medicines_id.Add(id);
                    removedItemsList.Add(obj);
                }

                gridPartyInvoice.Rows.RemoveAt(e.RowIndex);
            }

            int rowindex = e.RowIndex;
            if (rowindex < 4)
            {

                //int.TryParse(gridVoucher.Rows[rowindex].Cells["ID"].Value.ToString(), out id);
                //txt_vouchername.Text = gridVoucher.Rows[rowindex].Cells["Name"].Value.ToString();

                //txt_shortName.Text = gridVoucher.Rows[rowindex].Cells["Short Name"].Value.ToString();

                //txt_Code.Text = gridVoucher.Rows[rowindex].Cells["Code"].Value.ToString();

                //txt_Description.Text = gridVoucher.Rows[rowindex].Cells["Description"].Value.ToString();
                //cmbx_vcat.Text = gridVoucher.Rows[rowindex].Cells["Country"].Value.ToString();
                //Valid_it();
                //btnSave.Text = "     Update";
            }

        }

        private void gridPartyInvoice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void gridMedicine_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            CalculateTotal();
            LoadPriceQuantity();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (Validated())
            {
                party_invoiceBAL obj = new party_invoiceBAL();
                obj.party_invoice_id = id;


                PromotionDAL objDAL = new PromotionDAL();
                if (id != Guid.Empty)
                {
                    obj.EditDate = DateTime.Now;
                    obj.Editby = "Admin";

                    Update_Party_invoice();
                    Update_Medicines();
                }
                else
                {
                    obj.AddDate = DateTime.Now;
                    obj.Addby = "Admin";
                    obj.status = true;
                    obj.Flag = 1;
                    Insert_Medicines(Insert_Party_invoice());
                }
                ClearAll();
                inti();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (id != Guid.Empty)
            {
                party_invoice.party_invoice_id = id;
                party_invoice_db.Delete(party_invoice);
                foreach (var item in party_invoice_medicine_db.LoadAll().Where(m => m.party_invoice_id == id).ToList())
                {
                    party_invoice_medicine_db.Delete(item);
                    DeletePriceInvoice(id);
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
