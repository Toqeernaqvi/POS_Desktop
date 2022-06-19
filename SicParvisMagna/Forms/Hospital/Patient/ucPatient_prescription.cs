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
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using Telerik.WinControls.UI;

namespace SicParvisMagna.Forms.Hospital.Patient
{
    public partial class ucPatient_prescription : UserControl
    {
        DataGridViewComboBoxColumn cmbx_medicine = new DataGridViewComboBoxColumn();
        Guid ProductId = Guid.Empty;
        int x = 0;

        DataGridViewComboBoxColumn cmbx_LAbTest = new DataGridViewComboBoxColumn();
        ValidationRegex objvr = new ValidationRegex();
        Guid patientid = Guid.Empty;
        private Guid id = Guid.Empty;
        patient_prescriptionDAL db = new patient_prescriptionDAL();
        patient_basicDAL dbP = new patient_basicDAL();
        patient_basicDAL patient_basic_db = new patient_basicDAL();
        patient_contact_addressDAL patient_contact_addressDb = new patient_contact_addressDAL();
        List<patient_prescription_medicineBAL> Removed_medicines_id = new List<patient_prescription_medicineBAL>();
        List<Guid> Remover_LabTest_id = new List<Guid>();
        public ucPatient_prescription()
        {
            InitializeComponent();
            // LoadPatient();
            Load_PatientLabTest_Columns();
            Load_PatientMedicine_Columns();
            LoadPrescription();
            LoadCmbProduct();
            Init();

        }
        private void Init()
        {
            txt_RecordNo.Focus();
            txt_RecordNo.Select();
        }
        private void LoadCmbProduct()
        {
            ProductDAL objDAL = new ProductDAL();
            cmbProduct.DataSource = objDAL.LoadProductNameWithCategory();
            cmbProduct.ValueMember = "id";
            cmbProduct.DisplayMember = "Title";
            cmbProduct.SelectedIndex = -1;
        }

        public void LoadPatient()
        {
            patient_basicBAL patient_basic = null;
            patient_contact_addressBAL patient_contact_address = null;
            var list = patient_basic_db.LoadAll();

            if (!string.IsNullOrEmpty(txt_RecordNo.Text))
            {

                patient_basic = list.Where(m => m.patient_record_no.ToString().ToLower().Equals(txt_RecordNo.Text.ToLower())).FirstOrDefault();
            }
            else if (!string.IsNullOrEmpty(txt_Patient_Name.Text))
            {
                patient_basic = list.Where(m => m.patient_name.ToLower().Contains(txt_Patient_Name.Text.ToLower())).FirstOrDefault();
            }
            else if (!string.IsNullOrEmpty(txt_pateint_Phone.Text) && patient_basic == null)
            {
                patient_contact_address = patient_contact_addressDb.LoadAll().Where(m =>
                 m.personal_phone.Equals(txt_pateint_Phone.Text) ||
                 m.home_phone.Equals(txt_pateint_Phone.Text) ||
                 m.office_phone.Equals(txt_pateint_Phone.Text)).Take(1).FirstOrDefault();
            }

            if (patient_basic != null)
            {
                patientid = patient_basic.patient_id;
                txt_Patient_Name.Text = patient_basic.patient_name;
                txt_RecordNo.Text = patient_basic.patient_record_no.ToString();
                try
                {
                    txt_pateint_Phone.Text = patient_contact_addressDb.LoadAll().Where(m => m.patient_id == patient_basic.patient_id).FirstOrDefault().personal_phone;
                }
                catch
                { txt_pateint_Phone.Text = ""; }

                txt_Age_year.Text = patient_basic.patient_Age.ToString();
                txt_Age_month.Text = patient_basic.patient_Age_month.ToString();
                if (patient_basic.patient_gender == "Male")
                    combo_Patient_Gender.SelectedIndex = 0;
                else if (patient_basic.patient_gender == "Female")
                    combo_Patient_Gender.SelectedIndex = 1;

                //     lblError_RecordNo.Text = "";
            }
            else if (patient_contact_address != null)
            {
                patientid = patient_contact_address.patient_id;
                patient_basic = patient_basic_db.LoadbyId(patient_contact_address.patient_id).FirstOrDefault();
                txt_Patient_Name.Text = patient_basic.patient_name;
                txt_RecordNo.Text = patient_basic.patient_record_no.ToString();
                txt_pateint_Phone.Text = patient_contact_address.personal_phone;
                txt_Age_year.Text = patient_basic.patient_Age.ToString();
                txt_Age_month.Text = patient_basic.patient_Age_month.ToString();
                if (patient_basic.patient_gender == "Male")
                    combo_Patient_Gender.SelectedIndex = 0;
                else if (patient_basic.patient_gender == "Female")
                    combo_Patient_Gender.SelectedIndex = 1;

                //    lblError_RecordNo.Text = "";
            }
            else
            {
                //    lblError_RecordNo.Text = "No Record found";
            }
         //   LoadPrescription(patientid);
            //cmbx_Patient.DataSource = patient_basic_db.LoadAll();
            //cmbx_Patient.DisplayMember = "patient_name";
            //cmbx_Patient.ValueMember = "patient_id";
            //cmbx_Patient.SelectedIndex = -1;
        }





        public void Load_PatientMedicine_Columns()
        {
            if (Grid_Patient_Medicine.Columns.Count > 0)
            {
                Grid_Patient_Medicine.Columns.Clear();
                Grid_Patient_Medicine.Columns.Clear();
            }
            DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn_delrow = new DataGridViewButtonColumn();
 
        
            cmbx_medicine.HeaderText = "Medicines";
            cmbx_medicine.Name = "cmb_item";
            ProductDAL medicine_db = new ProductDAL();                     ///0   
            cmbx_medicine.DataSource = medicine_db.LoadProductNameWithCategory();
            cmbx_medicine.DisplayMember = "Title";
            cmbx_medicine.ValueMember = "id";
            Grid_Patient_Medicine.Columns.Add(cmbx_medicine);

            Grid_Patient_Medicine.Columns[0].Width = 255;

            Grid_Patient_Medicine.Columns.Add("price", "Price");                    //1 
            Grid_Patient_Medicine.Columns[1].ReadOnly = true;
            Grid_Patient_Medicine.Columns[1].Visible = false;
            Grid_Patient_Medicine.Columns.Add("quantity", "Quantity");              //2

            Grid_Patient_Medicine.Columns.Add("total_price", "Total Price");        //3
            Grid_Patient_Medicine.Columns[3].ReadOnly = true;
            Grid_Patient_Medicine.Columns[3].Visible = false;

            Grid_Patient_Medicine.Columns.Add(btn_newrow);
            btn_newrow.HeaderText = "Add";                              //4
            btn_newrow.Text = "Add Medicine";
            btn_newrow.Name = "btn_newrow";
            btn_newrow.UseColumnTextForButtonValue = true;
            Grid_Patient_Medicine.Columns[4].Width = 100;
            Grid_Patient_Medicine.Columns.Add(btn_delrow);              //5
            btn_delrow.HeaderText = "Delete";
            btn_delrow.Text = "Delete Medicine";
            btn_delrow.Name = "btn_delrow";
            btn_delrow.UseColumnTextForButtonValue = true;
            Grid_Patient_Medicine.Columns[5].Width = 100;


            Grid_Patient_Medicine.Columns.Add("ID", "ID");  //6
            Grid_Patient_Medicine.Columns[6].Visible = false;

            //Grid_Patient_Medicine.Columns.Add("pricing_id", "pricing_id");  //7
            //Grid_Patient_Medicine.Columns[6].Visible = false;


            if (id == Guid.Empty)
            {
                addRow_MedicineGrid();
            }

        }
        public void addRow_MedicineGrid_byProduct(Guid Product_id)
        {
           // if (row != null)
            this.Grid_Patient_Medicine.Rows.Add(ProductId, "0", "0", "0", null, null, new Guid().ToString(), new Guid().ToString());
            //ProductDAL medicine_db = new ProductDAL();                     ///0   
            //cmbx_medicine.DataSource = medicine_db.LoadProdcutbyCategory(ProductId);
            //cmbx_medicine.DisplayMember = "Title";
            //cmbx_medicine.ValueMember = "id";
            //int rowindex = 0;
          //  string[] row = null;

            //row = new string[] { null, "0", "0", "0", null, null, new Guid().ToString(), new Guid().ToString() };
           //load All Medicnes
           


            //if (row != null)
            //rowindex = Grid_Patient_Medicine.Rows.Add(row);


            //Grid_Patient_Medicine.Rows[rowindex].Cells[0].Selected = true;
        }
        public void addRow_MedicineGrid()
        {
            int rowindex = 0;
            string[] row = null;

             row = new string[] { null, "0", "0", "0", null, null,new Guid().ToString(), new Guid().ToString() };

            if (row != null)
                rowindex = Grid_Patient_Medicine.Rows.Add(row);

       Grid_Patient_Medicine.Rows[rowindex].Cells[0].Selected = true;
        }

        //public void addRow_MedicineGrid(Guid id)
        //{
        //    int rowindex = 0;
        //    string[] row = null;

        //    row = new string[] {id.ToString(), "0", "0", "0", null, null, new Guid().ToString(), new Guid().ToString() };

        //    if (row != null)
        //        rowindex = Grid_Patient_Medicine.Rows.Add(row);

        //    Grid_Patient_Medicine.Rows[rowindex].Cells[0].Selected = true;
        //}

        private void Grid_Patient_Medicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridCellClick(e.RowIndex, e.ColumnIndex);
        }
        private void gridCellClick(int rowIndex, int columnIndex)
        {
            if (columnIndex == 4)
            {
                addRow_MedicineGrid();
            }
            else if (columnIndex == 5 && Grid_Patient_Medicine.RowCount > 1)
            {
                try
                {
                    Guid temp_id = Guid.Parse(Grid_Patient_Medicine.Rows[rowIndex].Cells[6].Value.ToString());
                   // int pricing_id = Convert.ToInt32(Grid_Patient_Medicine.Rows[rowIndex].Cells[7].Value.ToString());
                    int qty = Convert.ToInt32(Grid_Patient_Medicine.Rows[rowIndex].Cells[2].Value.ToString());
                    Guid medicineId = Guid.Parse(Grid_Patient_Medicine.Rows[rowIndex].Cells[0].Value.ToString());
                    if (temp_id !=  Guid.Empty)
                    {
                         patient_prescription_medicineBAL obj = new patient_prescription_medicineBAL();
                        obj.patient_prescription_medicine_id = temp_id;
                     //   obj.pricing_id = pricing_id;
                        obj.quantity = qty;
                        obj.medicine_id = medicineId;
                        Removed_medicines_id.Add(obj);
                    }
                }
                catch (Exception)
                {

                }
                Grid_Patient_Medicine.Rows.RemoveAt(rowIndex);
            }
            else if (columnIndex == 5 && Grid_Patient_Medicine.RowCount == 1)
            {
                try
                {
                    Guid temp_id = Guid.Parse(Grid_Patient_Medicine.Rows[rowIndex].Cells[6].Value.ToString());
                  //  int pricing_id = Convert.ToInt32(Grid_Patient_Medicine.Rows[rowIndex].Cells[7].Value.ToString());
                    int qty = Convert.ToInt32(Grid_Patient_Medicine.Rows[rowIndex].Cells[2].Value.ToString());
                    Guid medicineId = Guid.Parse(Grid_Patient_Medicine.Rows[rowIndex].Cells[0].Value.ToString());
                    if (temp_id !=Guid.Empty)
                    {
                        patient_prescription_medicineBAL obj = new patient_prescription_medicineBAL();
                        obj.patient_prescription_medicine_id = temp_id;
                       // obj.pricing_id = pricing_id;
                        obj.quantity = qty;
                        obj.medicine_id = medicineId;
                        Removed_medicines_id.Add(obj);
                    }
                }
                catch (Exception)
                {

                }
                Grid_Patient_Medicine.Rows.RemoveAt(rowIndex);
                addRow_MedicineGrid();
            }
         }

        public void Load_PatientLabTest_Columns()
        {
            Grid_Pateint_LabTest.Rows.Clear();
            Grid_Pateint_LabTest.Columns.Clear();
            DataGridViewButtonColumn btn_newrow = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn_delrow = new DataGridViewButtonColumn();


            cmbx_LAbTest.HeaderText = "Lab Test";
            cmbx_LAbTest.Name = "cmb_item";
            Grid_Pateint_LabTest.Columns.Add(cmbx_LAbTest);
            lab_testDAL lab_test_db = new lab_testDAL();                            //0   
            cmbx_LAbTest.DataSource = lab_test_db.LoadAll();
            cmbx_LAbTest.DisplayMember = "name";
            cmbx_LAbTest.ValueMember = "lab_test_id";
            Grid_Pateint_LabTest.Columns[0].Width = 150;
            Grid_Pateint_LabTest.Columns.Add("price", "Price");                    //1 
            Grid_Pateint_LabTest.Columns[1].ReadOnly = true;

            Grid_Pateint_LabTest.Columns.Add("discount", "discount");              //2
            Grid_Pateint_LabTest.Columns.Add("total_price", "Total Price");        //3
                                                                                   // Grid_Pateint_LabTest.Columns[3].ReadOnly = true;

            Grid_Pateint_LabTest.Columns.Add(btn_newrow);
            btn_newrow.HeaderText = "Add";                              //4
            btn_newrow.Text = "Add Lab Test";
            btn_newrow.Name = "btn_newrow";
            btn_newrow.UseColumnTextForButtonValue = true;
            Grid_Pateint_LabTest.Columns[4].Width = 100;
            Grid_Pateint_LabTest.Columns.Add(btn_delrow);              //5
            btn_delrow.HeaderText = "Delete";
            btn_delrow.Text = "Delete Lab Test";
            btn_delrow.Name = "btn_delrow";
            btn_delrow.UseColumnTextForButtonValue = true;
            Grid_Pateint_LabTest.Columns[5].Width = 100;


            Grid_Pateint_LabTest.Columns.Add("ID", "ID");  //6
            Grid_Pateint_LabTest.Columns[6].Visible = false;

            Grid_Pateint_LabTest.Columns.Add("welfare_discount", "welfare discount");        //7
            Grid_Pateint_LabTest.Columns["welfare_discount"].DisplayIndex = 4;

            Grid_Pateint_LabTest.Columns.Add("net_total", "Net Total");        //7
            Grid_Pateint_LabTest.Columns["net_total"].DisplayIndex = 5;

            if (id == Guid.Empty)
            {
                addRow_LabTest();
            }
        }
        public void addRow_LabTest()
        {
            string[] row = null;

            row = new string[] { null, "0", "0", "0", null, null, new Guid().ToString(), "0", "0" };

            if (row != null)
                Grid_Pateint_LabTest.Rows.Add(row);
        }
        public bool CalculateLabTest_Total()
        {
            lab_testDAL lab_test_db = new lab_testDAL();
            List<bool> isexception = new List<bool>();
            for (int i = 0; i < Grid_Pateint_LabTest.RowCount; i++)
            {
                float price = 0, discount = 0;
              Guid lab_test_id =Guid.Empty;

                //if (Grid_Pateint_LabTest.Rows.Count == 1 && Grid_Pateint_LabTest.Rows[i].Cells["price"].Value == "0")
                //    return true;

                try
                {
                    lab_test_id =Guid.Parse(Grid_Pateint_LabTest.Rows[i].Cells[0].Value.ToString());
                    price = lab_test_db.LoadbyId(lab_test_id).FirstOrDefault().price;
                    Grid_Pateint_LabTest.Rows[i].Cells["price"].Value = price;
                }
                catch (Exception)
                {
                    Grid_Pateint_LabTest.Rows[i].Cells["price"].Value = price;
                    isexception.Add(true);
                }
                try
                {
                    //   discount = Convert.ToInt32(Grid_Pateint_LabTest.Rows[i].Cells[2].Value.ToString());
                    //   float discount_amount = 0;
                    //   if (discount > 100)
                    //    {
                    //       Grid_Pateint_LabTest.Rows[i].Cells[2].Value = 100;
                    //      discount = 100;
                    //  }
                    //  discount_amount = (discount / 100) * price;
                    //   Grid_Pateint_LabTest.Rows[i].Cells[3].Value = price - discount_amount;                    
                }
                catch (Exception)
                {
                    //    Grid_Pateint_LabTest.Rows[i].Cells[2].Value = 0;
                }
            }
            if (isexception.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void Grid_Pateint_LabTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                addRow_LabTest();
            }
            else if (e.ColumnIndex == 5 && Grid_Pateint_LabTest.RowCount > 1)
            {
                try
                {
                    Guid temp_id = Guid.Parse(Grid_Pateint_LabTest.Rows[e.RowIndex].Cells[6].Value.ToString());
                    if (temp_id !=Guid.Empty)
                    {
                        Remover_LabTest_id.Add(temp_id);
                    }
                }
                catch (Exception)
                {

                }
                Grid_Pateint_LabTest.Rows.RemoveAt(e.RowIndex);
            }
            CalculateLabTest_Total();
        }
        public void Calculate_Total_Cost()
        {
            int LabTest_Total = 0, Medicine_Total = 0;
            //for (int i = 0; i < Grid_Patient_Medicine.RowCount; i++)
            //{
            //    Medicine_Total += Convert.ToInt32(Grid_Patient_Medicine.Rows[i].Cells[3].Value);
            //}
            for (int i = 0; i < Grid_Pateint_LabTest.RowCount; i++)
            {
                LabTest_Total += Convert.ToInt32(Grid_Pateint_LabTest.Rows[i].Cells["net_total"].Value);
            }
            txt_TotalCost.Text = (LabTest_Total + Medicine_Total).ToString();
        }
        private void LoadPrescription(Guid PatientId)
        {
            gridPatient_Prescription.Rows.Clear();
            gridPatient_Prescription.Columns.Clear();
            gridPatient_Prescription.Columns.Add("patient_prescription_id", "ID");
            gridPatient_Prescription.Columns[0].Visible = false;
            gridPatient_Prescription.Columns.Add("patient", "Patient");
            gridPatient_Prescription.Columns[1].Width = 400;
            gridPatient_Prescription.Columns.Add("AssignedDate", "Assigned Date");
            gridPatient_Prescription.Columns[2].Width = 200;
            gridPatient_Prescription.Columns.Add("total_cost", "Total Cost");
            gridPatient_Prescription.Columns[3].Width = 200;
            patient_basicDAL patient_basic_db = new patient_basicDAL();
            foreach (var item in db.LoadAll().Where(m => m.patient_id == PatientId))
            {
                gridPatient_Prescription.Rows.Add(
                item.patient_prescription_id,
                patient_basic_db.LoadbyId(item.patient_id).FirstOrDefault().patient_name,
                item.assigned_Date.Date.ToShortDateString(),
                item.total_cost

                );
            }
        }
  
        private void LoadPrescription()
        {
            gridPatient_Prescription.Rows.Clear();
            gridPatient_Prescription.Columns.Clear();
            gridPatient_Prescription.Columns.Add("patient_prescription_id", "ID");
            gridPatient_Prescription.Columns[0].Visible = false;
            gridPatient_Prescription.Columns.Add("patient", "Patient");
            gridPatient_Prescription.Columns[1].Width = 400;
            gridPatient_Prescription.Columns.Add("AssignedDate", "Assigned Date");
            gridPatient_Prescription.Columns[2].Width = 200;
            gridPatient_Prescription.Columns.Add("total_cost", "Total Cost");
            gridPatient_Prescription.Columns[3].Width = 200;
            patient_basicDAL patient_basic_db = new patient_basicDAL();
            foreach (var item in db.LoadAll())
            {
                string pname;
                try { pname = patient_basic_db.LoadbyId(item.patient_id).FirstOrDefault().patient_name; } catch { pname = "Deleted Patient"; }

                gridPatient_Prescription.Rows.Add(
                item.patient_prescription_id,
                pname,
                item.assigned_Date.Date.ToShortDateString(),
                item.total_cost
                );
            }
        }
        private void Content(DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                //Overhead Stuff
                Guid.TryParse(gridPatient_Prescription.Rows[rowindex].Cells["patient_prescription_id"].Value.ToString(), out id);
                patientid = db.LoadbyId(id).FirstOrDefault().patient_id;
                txt_Patient_Name.Text = gridPatient_Prescription.Rows[rowindex].Cells["patient"].Value.ToString();
                 //cmbx_Patient.Text = gridPatient_Prescription.Rows[rowindex].Cells["patient"].Value.ToString();
                Assigned_Date.Value = Convert.ToDateTime(gridPatient_Prescription.Rows[rowindex].Cells["AssignedDate"].Value.ToString());
                txt_TotalCost.Text = gridPatient_Prescription.Rows[rowindex].Cells["total_cost"].Value.ToString();
                LoadPatient();

                Load_PatientMedicine_Columns();
                patient_prescription_medicineDAL medicine_db = new patient_prescription_medicineDAL();
             
                foreach (var item in medicine_db.LoadByPrescription(id).Where(m => m.patient_prescription_id == id).ToList())
                {

                    Grid_Patient_Medicine.Rows.Add(
                    item.medicine_id,
                    item.price,
                    item.quantity,
                    item.total_price,
                    null,
                    null,
                    item.patient_prescription_medicine_id,
                    item.pricing_id);
                }
                if (Grid_Patient_Medicine.Rows.Count == 0)
                    addRow_MedicineGrid();
                Load_PatientLabTest_Columns();
                patient_prescription_LabTestDAL labtest_db = new patient_prescription_LabTestDAL();
                foreach (var item in labtest_db.LoadAll().Where(m => m.patient_prescription_id == id).ToList())
                {
                    Grid_Pateint_LabTest.Rows.Add(
                    item.lab_test_id,
                    item.price,
                    item.discount,
                    item.total_price,
                    null,
                    null,
                    item.patient_prescription_LabTest_id,
                    item.welfare_discount,
                    item.net_price);
                }
                if (Grid_Pateint_LabTest.Rows.Count == 0)
                    addRow_LabTest();
                btnSave.LabelText = "Update";
             }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAll();
        }
        public void SaveAll()
        {
            Guid patient_prescription_id = Guid.Empty;
            if (btnSave.LabelText == "Save")
            {
                id = Guid.NewGuid();
                patient_prescription_id = id;
            }
            if (patientid != Guid.Empty)//&& CalculateMedicine_Total() && CalculateLabTest_Total()
            {
                patient_prescriptionBAL patient_prescription = new patient_prescriptionBAL();
                patient_prescription.patient_prescription_id = patient_prescription_id;
                patient_prescription.patient_id = patientid;
                patient_prescription.assigned_Date = Assigned_Date.Value;
                patient_prescription.total_cost = Convert.ToInt32(txt_TotalCost.Text);

                if (checkbox_Type.Checked)
                    patient_prescription.type = "Free";
                else
                    patient_prescription.type = "Paid";

                if (id == patient_prescription_id)
                {
                    patient_prescription.AddDate = DateTime.Now;
                    patient_prescription.Addby = "Admin";
                    patient_prescription.Flag = 1;
                    db.Add(patient_prescription);
                  
                   // Guid patient_prescription_id = db.LoadAll().Max(m => m.patient_prescription_id);
                    Add_Update_Patient_Medicine(patient_prescription_id);
                    Add_Update_Patient_LabTest(patient_prescription_id);
                }
                else
                {
                     patient_prescription.patient_prescription_id = id;

                    patient_prescription.EditDate = DateTime.Now;
                    patient_prescription.Editby = "Admin";
                    db.Update(patient_prescription);
                    Add_Update_Patient_Medicine(id);
                    Add_Update_Patient_LabTest(id);

                }
                ClearAll();
            }


            else
            {

                MessageBox.Show("Form is not Valid");
            }
        }
        public void Add_Update_Patient_Medicine(Guid patient_prescription_id)
        {
            patient_prescription_medicineBAL obj = new patient_prescription_medicineBAL();
            patient_prescription_medicineDAL objD = new patient_prescription_medicineDAL();
            PricingDAL objP = new PricingDAL();
            Guid patient_prescription_Medicine_id = Guid.Empty;
            DataTable dt = new DataTable();
            for (int i = 0; i < Grid_Patient_Medicine.Rows.Count; i++)

            {
                dt = objP.FindPrice_ProductId(Guid.Parse(Grid_Patient_Medicine.Rows[i].Cells[0].Value.ToString()));
                double price = Convert.ToDouble(dt.Rows[0]["Price"].ToString());
                double quantity = Convert.ToDouble(Grid_Patient_Medicine.Rows[i].Cells[2].Value);

                try
                {

                    // Add transaction in Prescription Medicine agianst 
                    {
                        obj.patient_prescription_id = patient_prescription_id;
                        obj.medicine_id = Guid.Parse(Grid_Patient_Medicine.Rows[i].Cells[0].Value.ToString());
                        obj.price = price;
                        obj.quantity = quantity;
                        obj.total_price = quantity * price;

                        obj.patient_prescription_medicine_id = Guid.Parse(Grid_Patient_Medicine.Rows[i].Cells[6].Value.ToString());


                        if (obj.patient_prescription_medicine_id == Guid.Empty)
                        {
                            obj.AddDate = DateTime.Now;
                            obj.Addby = "Admin";
                            obj.Flag = 1;
                            objD.Add(obj);
                           patient_prescription_Medicine_id = objD.LoadByPrescription(id).Max(m => m.patient_prescription_medicine_id);
                             
                        }
                        else

                        {
                            obj.AddDate = DateTime.Now;
                            obj.Addby = "Admin";
                            obj.EditDate = DateTime.Now;
                            obj.Editby = "Admin";
                            obj.Flag = 1;
                            patient_prescription_Medicine_id = Guid.Parse(Grid_Patient_Medicine.Rows[i].Cells[6].Value.ToString());
                            if (i == 0)//Delete single time  
                            {
                                objD.DeleteStockPrescriptionMedicine(patient_prescription_id);
                                objD.DeletePrescriptionMedicine(patient_prescription_id);
                            }

                            objD.Add(obj);
                             

                        }
                        //currentMedicine.opn -= quantity;
                        //   MedicineDAL medicineDB1 = new MedicineDAL();
                        //    medicineDB1.Update(currentMedicine);

                    }


                    //For Stock
                    dt = objP.FindPrice_ProductId(Guid.Parse(Grid_Patient_Medicine.Rows[i].Cells[0].Value.ToString()));
                    //For Manage Stock
                    StockDAL objStock = new StockDAL();
                    DataTable dtStock = new DataTable();
                    int stockQuantity = 0;
                    int gridQuantity = 0;
                    int tempQuantity = 0;
                    Guid Product_Category_id = Guid.Parse(dt.Rows[0]["CatID"].ToString()); 
                    Guid Pro_id = Guid.Empty;
                    Guid stock_id = Guid.Empty;

                    StockBAL objS = new StockBAL();
                    objS.Organization_id = Guid.Parse("13BCD2AD-F546-4E61-9BFE-2A540111FFE0");

                    Guid.TryParse(Grid_Patient_Medicine.Rows[i].Cells[0].Value.ToString(), out Pro_id);
                    objS.Product_Category_id = Product_Category_id;
                    Int32.TryParse(Grid_Patient_Medicine.Rows[i].Cells["Quantity"].Value.ToString(), out stockQuantity);

                    objS.Product_id = Pro_id;
                    objS.Branch_id = Guid.Parse("ED933606-A522-463E-97D4-8C541BD7F221");
                    objS.POS_id = Guid.Empty;
                    objS.Order_no = txt_RecordNo.Text + "     Medicne Prescription";
                    objS.quantity = stockQuantity;
                    objS.purchaseprice = price;
                    objS.saleprice = 0;
                    objS.barcode = stockQuantity.ToString();
                    objS.expiryDate = Convert.ToDateTime("02-02-2022");
                    objS.Addby = Program.User_id;
                    objS.AddDate = DateTime.Now;
                    objS.status = "Minus Stock";
                    objS.SOS_id = Guid.Empty;
                    objS.SOR_id = Guid.Empty;
                    objS.POR_id = Guid.Empty;
                    objS.Prescription_Medicine_id = patient_prescription_id;

                    objS.Source = Sources.PatientPrescriptionMedicine.ToString();
                    objS.Type = "-";
                    objS.Flag = 1;
                     objStock.Add(objS);


                }
                catch(Exception e){ MessageBox.Show(e.ToString()); }
                // end adding transaction in patientMedicine
            }

            
       
    }
        public void Add_Update_Patient_LabTest(Guid patient_prescription_id)
        {
            try
            {
                patient_prescription_LabTestDAL dal = new patient_prescription_LabTestDAL();
                for (int i = 0; i < Grid_Pateint_LabTest.RowCount; i++)
                {
                    patient_prescription_LabTestBAL patient_prescription_LabTest = new patient_prescription_LabTestBAL();
                    patient_prescription_LabTest.patient_prescription_id = patient_prescription_id;
                    patient_prescription_LabTest.lab_test_id = Guid.Parse(Grid_Pateint_LabTest.Rows[i].Cells[0].Value.ToString());
                    patient_prescription_LabTest.price = Convert.ToInt32(Grid_Pateint_LabTest.Rows[i].Cells[1].Value);
                    patient_prescription_LabTest.discount = Convert.ToInt32(Grid_Pateint_LabTest.Rows[i].Cells[2].Value);
                    patient_prescription_LabTest.welfare_discount = Convert.ToInt32(Grid_Pateint_LabTest.Rows[i].Cells["welfare_discount"].Value);
                    patient_prescription_LabTest.total_price = Convert.ToInt32(Grid_Pateint_LabTest.Rows[i].Cells[3].Value);
                    patient_prescription_LabTest.net_price = Convert.ToInt32(Grid_Pateint_LabTest.Rows[i].Cells["net_total"].Value);
                    patient_prescription_LabTest.patient_prescription_LabTest_id = Guid.Parse(Grid_Pateint_LabTest.Rows[i].Cells[6].Value.ToString());

                   
              
                    if (patient_prescription_LabTest.patient_prescription_LabTest_id == Guid.Empty)
                    {
                        patient_prescription_LabTest.Addby = "Admin";
                        patient_prescription_LabTest.AddDate = DateTime.Now;
                        patient_prescription_LabTest.Flag = 1;

                        dal.Add(patient_prescription_LabTest);
                    }
                    else

                    {
                        patient_prescription_LabTest.Editby = "Admin";
                        patient_prescription_LabTest.EditDate = DateTime.Now;
                        patient_prescription_LabTest.Flag = 1;

                        dal.Update(patient_prescription_LabTest);
                    }

                }
                foreach (var item in Remover_LabTest_id)
                {
                    dal.Delete(item);
                }
            }
            catch { }

        }
        private void ClearAll()
        {
            checkbox_Type.Checked = false;
            id = Guid.Empty;
            //cmbx_Patient.SelectedIndex = -1;
            txt_Patient_Name.Text = "";
            txt_RecordNo.Text = "";
            txt_pateint_Phone.Text = "";
            patientid = Guid.Empty;
            //    Assigned_Date.Value = DateTime.Now;
            txt_TotalCost.Text = "0";
            Load_PatientMedicine_Columns();
            Load_PatientLabTest_Columns();
            LoadPrescription();
            txt_Age_month.Clear();
            txt_Age_year.Clear();
            cmbProduct.SelectedIndex = -1;
            btnSave.LabelText = " Save";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != Guid.Empty)
            {
                patient_prescription_medicineDAL dal_med = new patient_prescription_medicineDAL();
                patient_prescription_LabTestDAL dal_labtest = new patient_prescription_LabTestDAL();
                foreach (var item in dal_med.LoadByPrescription(id).Where(m => m.patient_prescription_id == id))
                {
                    //PricingBAL pricing = new PricingBAL();
                    //pricing = pricingDB.LoadAll().Where(m => m.item_id == item.medicine_id && m.item_type == "Medicine" && m.qty > 0 && m.status).OrderByDescending(m => m.Date).Take(1).FirstOrDefault();
                    //pricing.qty += item.quantity;
                    //pricingDB.Update(pricing);

                    dal_med.Delete(item.patient_prescription_medicine_id);
                }
                foreach (DataGridViewRow row in Grid_Patient_Medicine.Rows)
                {
                    try
                    {
                        Guid temp_id = Guid.Parse(row.Cells[6].Value.ToString());
                        //int pricing_id = Convert.ToInt32(row.Cells[7].Value.ToString());
                        int qty = Convert.ToInt32(row.Cells[2].Value.ToString());
                       Guid medicineId = Guid.Parse(row.Cells[0].Value.ToString());
                        if (temp_id != Guid.Empty)
                        {
                            patient_prescription_medicineBAL item = new patient_prescription_medicineBAL();
                            item.patient_prescription_medicine_id = temp_id;
                          //  item.pricing_id = pricing_id;
                            item.quantity = qty;
                            item.medicine_id = medicineId;


                            MedicineDAL medicineDB = new MedicineDAL();
                            PricingDAL pricingDB = new PricingDAL();
                            MedicineBAL currentMedicine = new MedicineBAL();
                            currentMedicine = medicineDB.LoadbyId(item.medicine_id);
                            // delete from prescription
                            dal_med.Delete(item.patient_prescription_medicine_id);
                            // restore in Pricing table -- Stock
                            PricingBAL pricingBALObj = new PricingBAL();
                            pricingBALObj.Pricing_id = item.pricing_id;
                            pricingBALObj.remaining += (float)(item.quantity / currentMedicine.qie);
                            // pricingDB.UpdateRemaining(pricingBALObj);




                        }
                    }
                    catch (Exception)
                    {

                    }
                }

                foreach (var item in dal_labtest.LoadAll().Where(m => m.patient_prescription_id == id))
                {
                    dal_labtest.Delete(item.patient_prescription_LabTest_id);
                }
                db.Delete(id);
                ClearAll();
            }
        }

        private void gridPatient_Prescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Grid_Pateint_LabTest_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            CalculateLabTest_Total();
        }

        private void timer_total_Tick(object sender, EventArgs e)
        {
            Calculate_Total_Cost();
        }

        private void btn_ClearPatient_Click(object sender, EventArgs e)
        {
            txt_Patient_Name.Text = "";
            txt_RecordNo.Text = "";
            txt_pateint_Phone.Text = "";
            patientid = Guid.Empty;
            txt_Age_month.Text = "0";
            txt_Age_year.Text = "0";
            combo_Patient_Gender.SelectedIndex = -1;
        }

        private void btn_loadPatient_Click(object sender, EventArgs e)
        {
            LoadPatient();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            patient_basicBAL patient = new patient_basicBAL();
            patient_basicDAL db = new patient_basicDAL();
        
            patient.patient_name = txt_Patient_Name.Text;
            patient.patient_gender = combo_Patient_Gender.SelectedItem.ToString();
            try { patient.patient_Age = Convert.ToInt32(txt_Age_year.Text); } catch { patient.patient_Age = 0; }
            try { patient.patient_Age_month = Convert.ToInt32(txt_Age_month.Text); } catch { patient.patient_Age_month = 0; }
            patient.patient_Date_of_Birth =DateTime.Now;
            try
            {
                patient.patient_record_no = txt_RecordNo.Text;
            }
            catch
            {
                patient.patient_record_no = "";
            }

            try
            {
                patient.Addby = "admin";
                patient.AddDate = DateTime.Now;
                patient.Flag = 1;

                db.Add(patient);
                MessageBox.Show("Patinet is Added  and loaded Sucessfully");
                // ClearAll();
                LoadPatient();
            }
            catch { }
         
        }

        private void Grid_Patient_Medicine_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                //Grid_Patient_Medicine.BeginEdit(true);
                //ComboBox comboBox = (ComboBox)Grid_Patient_Medicine.EditingControl;
                //comboBox.DroppedDown = true;
            }
        }

        private void Grid_Patient_Medicine_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Grid_Patient_Medicine.BeginEdit(true);
                ComboBox comboBox = (ComboBox)Grid_Patient_Medicine.EditingControl;
                comboBox.DroppedDown = false;
            }
        }

        private void Grid_Patient_Medicine_KeyDown(object sender, KeyEventArgs e)
        {
            var cell = this.Grid_Patient_Medicine.CurrentCell;
            if (cell != null && e.KeyCode == Keys.Enter &&
                cell.RowIndex >= 0 && (cell.ColumnIndex == 4 || cell.ColumnIndex == 5))
            {
                gridCellClick(cell.RowIndex, cell.ColumnIndex);
                e.Handled = true;
            }
        }
         
            private void loadGrid_by_ProductID(Guid id)

            {
            int rowindex = Grid_Patient_Medicine.RowCount;
                ProductDAL obj = new ProductDAL();
                DataTable dt = obj.ProductLoadbyid(id);
                Product_CategoryDAL objDAL = new Product_CategoryDAL();
                cmbProduct.DataSource = obj.LoadAll();
                cmbProduct.DisplayMember = "Title";
                cmbProduct.ValueMember = "id";

               
                Grid_Patient_Medicine.Rows[rowindex].Cells["cmbx_medicine"].Value = ProductId;


            addRow_PurchasesGrid();
            x = Grid_Patient_Medicine.RowCount;
            x--;

        }
           public void addRow_PurchasesGrid()
            {
             
            int rowindex =Grid_Patient_Medicine.RowCount;
                string[] row = null;

                int i = rowindex;
               
                Grid_Patient_Medicine.Rows[i].Cells["quantity"].Value = 0;
            Grid_Patient_Medicine.Rows[i].Cells["total_price"].Value = 0;


            row = new string[] { null, "0", "0", "0", null, null, new Guid().ToString(), new Guid().ToString() };

            if (row != null)
                rowindex = Grid_Patient_Medicine.Rows.Add(row);



        }
            private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ucPatient_prescription_Load(object sender, EventArgs e)
        {
          //  cmbProduct.Visible = false;
            //lbl.Visible = false;
            btnSearch.Visible = false;
            btnDelete.Visible = false;
        }

        private void Assigned_Date_ValueChanged(object sender, EventArgs e)
        {
            //// CurrentYear - BirthDate  
            //DateTime startTime = Convert.ToDateTime(Assigned_Date.Value);
            //DateTime endTime = DateTime.Today;
            //TimeSpan span = endTime.Subtract(startTime);
            //var totalDays = span.TotalDays;
            //var totalYears = Math.Truncate(totalDays / 365);
            //var totalMonths = Math.Truncate((totalDays % 365) / 30);
            //var remainingDays = Math.Truncate((totalDays % 365) % 30);
            //txt_Age_year.Text = totalYears.ToString();
            //txt_Age_month.Text = totalMonths.ToString();
            ////  textBox11.Text = string.Format("{0} year(s), {1} month(s) and {2} day(s)", totalYears, totalMonths, remainingDays);

        }

        private void txt_RecordNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Patient_Name.Focus();
            }
        }

        private void txt_Patient_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pateint_Phone.Focus();
            }
        }

        private void txt_pateint_Phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Age_year.Focus();
            }
        }

        private void txt_Age_year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Age_month.Focus();
            }
        }

        private void combo_Patient_Gender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddPatient.Focus();
            }
        }

        private void btnAddPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Assigned_Date.Focus();
            }
        }

        private void Assigned_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkbox_Type.Focus();
            }
        }

        private void checkbox_Type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                txt_TotalCost.Focus();
            gridPatient_Prescription.Focus();
        }

        private void txt_TotalCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridPatient_Prescription.Focus();
            }
        }

        private void txt_Age_month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combo_Patient_Gender.Focus();
            }
        }

        private void cmbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{

            //    Guid.TryParse(cmbProduct.SelectedValue.ToString(), out ProductId);
            //    addRow_MedicineGrid_byProduct(ProductId);
            //    // loadGrid_by_ProductID(ProductId);
            //}
            //catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //if (Grid_Patient_Medicine.Rows.Count ==1)
                    //{
                    //    //var med_id = Guid.Parse(Grid_Patient_Medicine.Rows[0].Cells["].Value.ToString());
                    //    //var quantity = Convert.ToDouble(Grid_Patient_Medicine.Rows[0].Cells["Quantity"].Value.ToString());

                    //    //if (med_id!= null)
                    //    //{
                    //    //    if (quantity > 0)
                    //    //    {
                    //    //        Guid.TryParse(cmbProduct.SelectedValue.ToString(), out ProductId);
                    //    //        addRow_MedicineGrid_byProduct(ProductId);
                    //    //    }
                    //    //    else
                    //    //    {
                    //    //        Grid_Patient_Medicine.Rows.RemoveAt(0);

                    //    //    }
                    //    //}
                    //    //else if (med_id == null)
                    //    //{
                    //    //    Grid_Patient_Medicine.Rows.RemoveAt(0);

                    //    //}
                    //      Grid_Patient_Medicine.Rows.RemoveAt(0);

                    //}
                    Guid.TryParse(cmbProduct.SelectedValue.ToString(), out ProductId);
                    addRow_MedicineGrid_byProduct(ProductId);
                    // loadGrid_by_ProductID(ProductId);
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
    }
}
