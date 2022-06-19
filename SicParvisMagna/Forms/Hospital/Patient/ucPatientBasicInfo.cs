using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;

namespace SicParvisMagna.Forms.Hospital.Patient
{

    public partial class ucPatientBasicInfo : UserControl
    {

        private Guid id = Guid.Empty;
        patient_basicDAL db = new patient_basicDAL();
        List<patient_basicBAL> All_PatientList;

        public ucPatientBasicInfo()
        {
            InitializeComponent();
            LoadPatient_Grid();
        }
        private void clearAll()
        {
            txt_RecordNo.Clear();
            txt_Patient_Name.Clear();
            txt_Age_year.Clear();
            txt_Age_month.Clear();
            combo_Patient_Gender.SelectedIndex = -1;

        }
        private void LoadPatient_Grid()
        {
            All_PatientList = db.LoadAll();
            gridPatient.DataSource = All_PatientList;
            gridPatient.Columns[0].HeaderText = "ID";
            gridPatient.Columns[0].Visible = false;
            gridPatient.Columns[1].HeaderText = "Patient Name";
            gridPatient.Columns[1].Width = 200;
            gridPatient.Columns[2].HeaderText = "Patient Gender";
            gridPatient.Columns[3].HeaderText = "Patient Age";
            gridPatient.Columns[4].HeaderText = "Patient Date of Birth";
            gridPatient.Columns[4].Width = 200;
            gridPatient.Columns[5].HeaderText = "Patient Record no";
            gridPatient.Columns[5].Width = 200;
            gridPatient.Columns["AddDate"].Visible = false;
            gridPatient.Columns["Addby"].Visible = false;
            gridPatient.Columns["EditDate"].Visible = false;
            gridPatient.Columns["Editby"].Visible = false;
            gridPatient.Columns["Flag"].Visible = false;
            gridPatient.Columns["status"].Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool chkRecord = false;
            if (btnSave.LabelText == "Save")
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = db.FindRecordNo();
                    for (int x = 0; x < dt.Rows.Count; x++)
                    {

                        Double rec = Convert.ToDouble(dt.Rows[x]["patient_record_no"]);
                        Double tempRec = Double.Parse(txt_RecordNo.Text);
                        if (rec == tempRec)
                        {
                            MessageBox.Show("RecNo. is already assigned .");
                            clearAll();
                            LoadPatient_Grid();
                        }
                        chkRecord = true;

                    }
                }
                catch { }
            }
            if (chkRecord == false)
            {
                try
                {
                    patient_basicBAL patient = new patient_basicBAL();
                    if (id != Guid.Empty)
                    {
                        patient = db.LoadbyId(id).FirstOrDefault();
                    }
                    patient.patient_name = txt_Patient_Name.Text;
                    patient.patient_gender = combo_Patient_Gender.SelectedItem.ToString();
                    try { patient.patient_Age = Convert.ToInt32(txt_Age_year.Text); } catch { patient.patient_Age = 0; }
                    try { patient.patient_Age_month = Convert.ToInt32(txt_Age_month.Text); } catch { patient.patient_Age_month = 0; }
                    patient.patient_Date_of_Birth = Date_of_Birth_Picker.Value;
                    try
                    {
                        patient.patient_record_no = txt_RecordNo.Text;
                    }
                    catch
                    {
                        patient.patient_record_no = "";
                    }
                    if (id != Guid.Empty && patient != null)
                    {
                        patient.Editby = "admin";
                        patient.EditDate = DateTime.Now;
                        db.Update(patient);
                    }
                    else
                    {
                        patient.Addby = "admin";
                        patient.AddDate = DateTime.Now;
                        patient.Flag = 1;

                        db.Add(patient);
                    }
                    clearAll();
                    LoadPatient_Grid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void gridPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                Guid.TryParse(gridPatient.Rows[rowindex].Cells["patient_id"].Value.ToString(), out id);
                txt_Patient_Name.Text = gridPatient.Rows[rowindex].Cells["patient_name"].Value.ToString();
                combo_Patient_Gender.Text = gridPatient.Rows[rowindex].Cells["patient_gender"].Value.ToString();
                txt_Age_year.Text = gridPatient.Rows[rowindex].Cells["patient_Age"].Value.ToString();
                txt_Age_month.Text = gridPatient.Rows[rowindex].Cells["patient_Age_month"].Value.ToString();
                Date_of_Birth_Picker.Value = Convert.ToDateTime(gridPatient.Rows[rowindex].Cells["patient_Date_of_Birth"].Value.ToString());
                txt_RecordNo.Text = gridPatient.Rows[rowindex].Cells["patient_record_no"].Value.ToString();
            }
            btnSave.Update();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != Guid.Empty)
            {

                var patient = db.LoadAll().Where(m => m.patient_id == id).FirstOrDefault();
                db.Delete(patient);
                clearAll();
                LoadPatient_Grid();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            patient_basicBAL patient_basic = new patient_basicBAL();
            patient_basicDAL patient_basic_db = new patient_basicDAL();

            patient_basic.patient_name = txt_search.Text;
            patient_basic.patient_record_no = txt_search.Text;
            gridPatient.DataSource = patient_basic_db.Search(patient_basic);
        }

        private void gridPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                Guid.TryParse(gridPatient.Rows[rowindex].Cells["patient_id"].Value.ToString(), out id);
                txt_Patient_Name.Text = gridPatient.Rows[rowindex].Cells["patient_name"].Value.ToString();
                combo_Patient_Gender.Text = gridPatient.Rows[rowindex].Cells["patient_gender"].Value.ToString();
                txt_Age_year.Text = gridPatient.Rows[rowindex].Cells["patient_Age"].Value.ToString();
                txt_Age_month.Text = gridPatient.Rows[rowindex].Cells["patient_Age_month"].Value.ToString();
                Date_of_Birth_Picker.Value = Convert.ToDateTime(gridPatient.Rows[rowindex].Cells["patient_Date_of_Birth"].Value.ToString());
                txt_RecordNo.Text = gridPatient.Rows[rowindex].Cells["patient_record_no"].Value.ToString();
            }
            btnSave.LabelText = "Update";
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
                combo_Patient_Gender.Focus();
            }
        }

        private void combo_Patient_Gender_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_Age_month_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Date_of_Birth_Picker.Focus();
            }
        }

        private void Date_of_Birth_Picker_ValueChanged(object sender, EventArgs e)
        {

            // CurrentYear - BirthDate  
            DateTime startTime = Convert.ToDateTime(Date_of_Birth_Picker.Value);
            DateTime endTime = DateTime.Today;
            TimeSpan span = endTime.Subtract(startTime);
            var totalDays = span.TotalDays;
            var totalYears = Math.Truncate(totalDays / 365);
            var totalMonths = Math.Truncate((totalDays % 365) / 30);
            var remainingDays = Math.Truncate((totalDays % 365) % 30);
            txt_Age_year.Text = totalYears.ToString();
            txt_Age_month.Text = totalMonths.ToString();

        }
    }
}
