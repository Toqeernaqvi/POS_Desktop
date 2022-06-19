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

namespace SicParvisMagna.Forms.Hospital.Patient
{
    public partial class ucPatient : UserControl
    {
        ValidationRegex objvr = new ValidationRegex();
        bool[] var = new bool[11];
        private Guid id = Guid.Empty;
        patient_basicDAL db = new patient_basicDAL();
        List<patient_basicBAL> All_PatientList;

        public ucPatient()
        {
            InitializeComponent();

            initial();
            LoadPatient_Grid();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
           // FormMain.loadPatientIndexForm();
        }
        private void Load_PatientCountry()
        {
            CountryDAL gv = new CountryDAL();
            cmbx_Pateint_country.DataSource = gv.LoadAll();
            cmbx_Pateint_country.DisplayMember = "Name";
            cmbx_Pateint_country.ValueMember = "country_id";
            cmbx_Pateint_country.SelectedIndex = -1;
            try
            {

                Load_PatientState(Guid.Parse(cmbx_Pateint_country.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                cmbx_Pateint_country.DataSource = null;
                cmbx_Patient_City.DataSource = null;
                cmbx_Patient_Area.DataSource = null;
            }
        }

        private void Load_PatientState(Guid ido)
        {
            StateDAL gv = new StateDAL();
            StateBAL objBAL = new StateBAL();
            objBAL.Country_id = ido;
            cmbx_Patient_State.DataSource = gv.LoadByCountry(objBAL);
            cmbx_Patient_State.DisplayMember = "Name";
            cmbx_Patient_State.ValueMember = "state_id";
           cmbx_Patient_State.Text = "Punjab";
            try
            {
                Load_PatientCity(Guid.Parse(cmbx_Patient_State.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                cmbx_Patient_City.DataSource = null;
                cmbx_Patient_Area.DataSource = null;
            }
        }

        private void Load_PatientCity(Guid ido)
        {
            CityDAL gv = new CityDAL();
            CityBAL objBAL = new CityBAL();
            objBAL.State_id = ido;
            cmbx_Patient_City.DataSource = gv.LoadByState(objBAL);
            cmbx_Patient_City.DisplayMember = "Name";
            cmbx_Patient_City.ValueMember = "city_id";
            cmbx_Patient_City.Text = "Lahore";
            try
            {
                Load_PatientArea(Guid.Parse(cmbx_Patient_City.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                cmbx_Patient_Area.DataSource = null;
            }
        }

        private void Load_PatientArea(Guid ido)
        {
            try
            {
                AreaDAL gv = new AreaDAL();
                AreaBAL objBAL = new AreaBAL();
                objBAL.City_id = ido;
                cmbx_Patient_Area.DataSource = gv.LoadByCity(objBAL);
                cmbx_Patient_Area.DisplayMember = "Name";
                cmbx_Patient_Area.ValueMember = "area_id";
                cmbx_Patient_Area.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        //Validation Method
        public bool Validate_cmbx_Pateint_country()
        {
            if (cmbx_Pateint_country.Text == string.Empty)
            {
                lblError_Patient_Country.Text = "*Required";
                return false;
            }
            lblError_Patient_Country.Text = "";
            return true;
        }

        private void cmbx_Pateint_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_Pateint_country();
        }

        private void cmbx_Pateint_country_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_Pateint_country();
        }
        public bool Validate_cmbx_Patient_State()
        {
            if (cmbx_Patient_State.Text == string.Empty)
            {
                lblError_Patient_State.Text = "*Required";
                return false;
            }
            lblError_Patient_State.Text = "";
            return true;
        }

        private void cmbx_Patient_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_Patient_State();
        }

        private void cmbx_Patient_State_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_Patient_State();
        }
        public bool Validate_cmbx_Patient_City()
        {
            if (cmbx_Patient_City.Text == string.Empty)
            {
                lbl_Error_Patient_City.Text = "*Required";
                return false;
            }
            lbl_Error_Patient_City.Text = "";
            return true;
        }

        private void cmbx_Patient_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_Patient_City();
        }

        private void cmbx_Patient_City_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_Patient_City();
        }
        public bool Validate_cmbx_Patient_Area()
        {
            if (cmbx_Patient_Area.Text == string.Empty)
            {
                lblError_Patient_Area.Text = "*Required";
                return false;
            }
            lblError_Patient_Area.Text = "";
            return true;
        }

        private void cmbx_Patient_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_Patient_Area();
        }

        private void cmbx_Patient_Area_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_Patient_Area();
        }
        public bool Validate_cmbx_RelativeCountry()
        {
            if (cmbx_RelativeCountry.Text == string.Empty)
            {
                lbl_Error_Relative_Country.Text = "*Required";
                return false;
            }
            lbl_Error_Relative_Country.Text = "";
            return true;
        }

        private void cmbx_RelativeCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_RelativeCountry();
        }

        private void cmbx_RelativeCountry_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_RelativeCountry();
        }
        public bool Validate_cmbx_RelativeState()
        {
            if (cmbx_RelativeState.Text == string.Empty)
            {
                lbl_Error_Relative_Sate.Text = "*Required";
                return false;
            }
            lbl_Error_Relative_Sate.Text = "";
            return true;
        }

        private void cmbx_RelativeState_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_RelativeState();
        }

        private void cmbx_RelativeState_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_RelativeState();
        }
        public bool Validate_cmbx_RelativeCity()
        {
            if (cmbx_RelativeCity.Text == string.Empty)
            {
                lbl_Error_Relative_City.Text = "*Required";
                return false;
            }
            lbl_Error_Relative_City.Text = "";
            return true;
        }

        private void cmbx_RelativeCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_RelativeCity();
        }

        private void cmbx_RelativeCity_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_RelativeCity();
        }
        public bool Validate_cmbx_RelativeArea()
        {
            if (cmbx_RelativeArea.Text == string.Empty)
            {
                lbl_Error_Relative_Area.Text = "*Required";
                return false;
            }
            lbl_Error_Relative_Area.Text = "";
            return true;
        }

        private void cmbx_RelativeArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate_cmbx_RelativeArea();
        }

        private void cmbx_RelativeArea_Leave(object sender, EventArgs e)
        {
            Validate_cmbx_RelativeArea();
        }
        private void Load_RelativeCountry()
        {
            CountryDAL gv = new CountryDAL();
            cmbx_RelativeCountry.DataSource = gv.LoadAll();
            cmbx_RelativeCountry.DisplayMember = "Name";
            cmbx_RelativeCountry.ValueMember = "country_id";
            cmbx_RelativeCountry.SelectedIndex = -1;
            try
            {

                Load_RelativeState(Guid.Parse(cmbx_RelativeCountry.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                cmbx_RelativeState.DataSource = null;

                cmbx_RelativeCity.DataSource = null;

                cmbx_RelativeArea.DataSource = null;

            }
        }

        private void Load_RelativeState(Guid ido)
        {
            StateDAL gv = new StateDAL();
            StateBAL objBAL = new StateBAL();
            objBAL.Country_id = ido;
            cmbx_RelativeState.DataSource = gv.LoadByCountry(objBAL);
            cmbx_RelativeState.DisplayMember = "Name";
            cmbx_RelativeState.ValueMember = "state_id";
            cmbx_RelativeState.Text = "Punjab";
            try
            {

                Load_RelativeCity(Guid.Parse(cmbx_RelativeState.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                cmbx_RelativeCity.DataSource = null;

                cmbx_RelativeArea.DataSource = null;
            }
        }

        private void Load_RelativeCity(Guid ido)
        {
            CityDAL gv = new CityDAL();
            CityBAL objBAL = new CityBAL();
            objBAL.State_id = ido;
            cmbx_RelativeCity.DataSource = gv.LoadByState(objBAL);
            cmbx_RelativeCity.DisplayMember = "Name";
            cmbx_RelativeCity.ValueMember = "city_id";
            cmbx_RelativeCity.Text = "Lahore";
            try
            {
                Load_RelativeArea(Guid.Parse(cmbx_RelativeCity.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                cmbx_RelativeArea.DataSource = null;
            }
        }

        private void Load_RelativeArea(Guid ido)
        {
            AreaDAL gv = new AreaDAL();
            AreaBAL objBAL = new AreaBAL();
            objBAL.City_id = ido;
            cmbx_RelativeArea.DataSource = gv.LoadByCity(objBAL);
            cmbx_RelativeArea.DisplayMember = "Name";
            cmbx_RelativeArea.ValueMember = "area_id";
            cmbx_RelativeArea.SelectedIndex = -1;
        }

        private void LoadPatient_Grid()
        {
            All_PatientList = db.LoadAll();
            grid_Patient.DataSource = All_PatientList;
            grid_Patient.Columns[0].HeaderText = "ID";
            grid_Patient.Columns[0].Visible = false;
            grid_Patient.Columns[1].HeaderText = "Patient Name";
            grid_Patient.Columns[1].Width = 200;
            grid_Patient.Columns[2].HeaderText = "Patient Gender";
            grid_Patient.Columns[3].HeaderText = "Patient Age";
            grid_Patient.Columns[4].HeaderText = "Patient Date of Birth";
            grid_Patient.Columns[4].Width = 200;
            grid_Patient.Columns[5].HeaderText = "Patient Record no";
            grid_Patient.Columns[5].Width = 200;
            grid_Patient.Columns["AddDate"].Visible = false;
            grid_Patient.Columns["Addby"].Visible = false;
            grid_Patient.Columns["EditDate"].Visible = false;
            grid_Patient.Columns["Editby"].Visible = false;
            grid_Patient.Columns["Flag"].Visible = false;
            grid_Patient.Columns["status"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (
                //   Validate_cmbx_Pateint_country() &&
                //   Validate_cmbx_Patient_State() &&
                //   Validate_cmbx_Patient_City() &&
                //   Validate_cmbx_Patient_Area() &&
                //   Validate_cmbx_RelativeCountry() &&
                //   Validate_cmbx_RelativeState() &&
                //   Validate_cmbx_RelativeCity() &&
                //   Validate_cmbx_RelativeArea() &&
                //   Validate_txt_RecordNo() &&
                Validate_txt_Patient_Name()
                )
            {

                // objBAL.Company = txt_Company.Text;
                Guid temp_id = add_update_BasicPatient();
                add_update_Contact_patient(temp_id);
                add_update_Contact_relative(temp_id);

                initial();
                LoadPatient_Grid();

            }
        }
        public Guid add_update_BasicPatient()
        {
            patient_basicBAL patient = new patient_basicBAL();
            if (id != null)
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
            if (id != null && patient != null)
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
            return db.LoadAll().Max(m => m.patient_id);
        }
        public void add_update_Contact_patient(Guid patient_id)
        {
            patient_contact_addressDAL patient_contact_address_db = new patient_contact_addressDAL();
            patient_contact_addressBAL patient_contact_address = new patient_contact_addressBAL();
            if (id != null)
            {
                patient_contact_address = patient_contact_address_db.LoadAll().Where(m => m.patient_id == id).FirstOrDefault();
                patient_id = id;
            }
            if (patient_contact_address == null)
            {
                patient_contact_address = new patient_contact_addressBAL();
            }
            patient_contact_address.patient_id = patient_id;
            patient_contact_address.email = txt_Patient_Email.Text;
            patient_contact_address.home_phone = txt_patient_homePhone.Text;
            patient_contact_address.personal_phone = txt_pateint_PersonalPhone.Text;
            patient_contact_address.office_phone = txt_patient_officePhone.Text;
            patient_contact_address.first_address = txt_Pateint_firstAddress.Text;
            patient_contact_address.second_address = txt_Second_Address.Text;
            patient_contact_address.country_id = Guid.Parse(cmbx_Pateint_country.SelectedValue.ToString());
            patient_contact_address.state_id = Guid.Parse(cmbx_Patient_State.SelectedValue.ToString());
            patient_contact_address.city_id = Guid.Parse(cmbx_Patient_City.SelectedValue.ToString());
            patient_contact_address.area_id = Guid.Parse(cmbx_Patient_Area.SelectedValue.ToString());
            try
            {
                patient_contact_address.zipcode = Convert.ToInt32(txt_Relative_ZipCode.Text);
            }
            catch
            {
                patient_contact_address.zipcode = 0;
            }
            if (id != null)
            {
                patient_contact_address.Editby = "admin";
                patient_contact_address.EditDate = DateTime.Now.ToString();
                patient_contact_address_db.Update(patient_contact_address);
            }
            else
            {
                patient_contact_address.Addby = "admin";
                patient_contact_address.AddDate = DateTime.Now;
                patient_contact_address.Flag = 1;
                patient_contact_address_db.Add(patient_contact_address);
            }
        }
        public void add_update_Contact_relative(Guid patient_id)
        {
            patient_Next_of_kinDAL patient_relative_db = new patient_Next_of_kinDAL();
            patient_Next_of_kinBAL patient_relative = new patient_Next_of_kinBAL();
            if (id != null)
            {
                patient_relative = patient_relative_db.LoadAll().Where(m => m.patient_id == id).FirstOrDefault();
                patient_id = id;
            }
            if (patient_relative == null)
            {
                patient_relative = new patient_Next_of_kinBAL();
            }
            patient_relative.patient_id = patient_id;
            patient_relative.name = txt_Relative_Name.Text;
            patient_relative.relation_to_patient = txt_Relative_RelationWithPAtient.Text;
            patient_relative.phone_no = txt_Relative_personalPhone.Text;
            patient_relative.first_address = txt_Pateint_firstAddress.Text;
            patient_relative.second_address = txt_Second_Address.Text;
            patient_relative.country_id = Guid.Parse(cmbx_RelativeCountry.SelectedValue.ToString());
            patient_relative.state_id = Guid.Parse(cmbx_RelativeState.SelectedValue.ToString());
            patient_relative.city_id = Guid.Parse(cmbx_RelativeCity.SelectedValue.ToString());
            patient_relative.area_id = Guid.Parse(cmbx_RelativeArea.SelectedValue.ToString());
            patient_relative.zipcode = txt_Patient_ZipCode.Text;
            if (id != null)
            {
                patient_relative.Editby = "admin";
                patient_relative.EditDate = DateTime.Now;
                patient_relative_db.Update(patient_relative);
            }
            else
            {
                patient_relative.Addby = "admin";
                patient_relative.AddDate = DateTime.Now;
                patient_relative.Flag = 1;
                patient_relative_db.Add(patient_relative);
            }
        }

        public void initial()
        {
            txt_Patient_Name.Text = "";
            combo_Patient_Gender.SelectedIndex = -1;
            txt_Age_year.Text = "";
            Date_of_Birth_Picker.Value = DateTime.Now;
            txt_RecordNo.Text = "";
            txt_Patient_Email.Text = "";
            txt_patient_homePhone.Text = "";
            txt_pateint_PersonalPhone.Text = "";
            txt_patient_officePhone.Text = "";
            txt_Pateint_firstAddress.Text = "";
            txt_Second_Address.Text = "";
            Load_PatientCountry();
            txt_Relative_Name.Text = "";
            txt_Relative_RelationWithPAtient.Text = "";
            txt_Relative_personalPhone.Text = "";
            txt_Relative_FirstAddress.Text = "";
            txt_Relative_SecondAddress.Text = "";
            Load_RelativeCountry();
            txt_Patient_ZipCode.Text = "";
            txt_Relative_ZipCode.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                patient_contact_addressDAL patient_contact_address_db = new patient_contact_addressDAL();
                patient_contact_addressBAL patient_contact_address = patient_contact_address_db.LoadAll().Where(m => m.patient_id == id).FirstOrDefault();
                patient_Next_of_kinDAL patient_relative_db = new patient_Next_of_kinDAL();
                patient_Next_of_kinBAL patient_relative = patient_relative_db.LoadAll().Where(m => m.patient_id == id).FirstOrDefault();
                if (patient_contact_address != null)
                    patient_contact_address_db.Delete(patient_contact_address);
                if (patient_relative != null)
                    patient_relative_db.Delete(patient_relative);
                var patient = db.LoadAll().Where(m => m.patient_id == id).FirstOrDefault();
                db.Delete(patient);
                initial();
                LoadPatient_Grid();

            }
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
            patient_basicBAL patient_basic = new patient_basicBAL();
            patient_basicDAL patient_basic_db = new patient_basicDAL();

            patient_basic.patient_name = txt_search.Text;
            patient_basic.patient_record_no = txt_search.Text;
            grid_Pateint.DataSource = patient_basic_db.Search(patient_basic);

        }
        private void Content(DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                Guid.TryParse(grid_Pateint.Rows[rowindex].Cells["patient_id"].Value.ToString(), out id);
                txt_Patient_Name.Text = grid_Pateint.Rows[rowindex].Cells["patient_name"].Value.ToString();
                combo_Patient_Gender.Text = grid_Pateint.Rows[rowindex].Cells["patient_gender"].Value.ToString();
                txt_Age_year.Text = grid_Pateint.Rows[rowindex].Cells["patient_Age"].Value.ToString();
                txt_Age_month.Text = grid_Pateint.Rows[rowindex].Cells["patient_Age_month"].Value.ToString();
                Date_of_Birth_Picker.Value = Convert.ToDateTime(grid_Pateint.Rows[rowindex].Cells["patient_Date_of_Birth"].Value.ToString());
                txt_RecordNo.Text = grid_Pateint.Rows[rowindex].Cells["patient_record_no"].Value.ToString();

                patient_contact_addressDAL patient_contact_address_db = new patient_contact_addressDAL();
                patient_contact_addressBAL patient_contact_address = patient_contact_address_db.LoadAll().Where(m => m.patient_id == id).FirstOrDefault();
                if (patient_contact_address != null)
                {
                    txt_Patient_Email.Text = patient_contact_address.email;
                    txt_patient_homePhone.Text = patient_contact_address.home_phone;
                    txt_pateint_PersonalPhone.Text = patient_contact_address.personal_phone;
                    txt_patient_officePhone.Text = patient_contact_address.office_phone;
                    txt_Pateint_firstAddress.Text = patient_contact_address.first_address;
                    txt_Second_Address.Text = patient_contact_address.second_address;
                    Load_PatientCountry();
                    cmbx_Pateint_country.SelectedValue = patient_contact_address.country_id;
                    Load_PatientState(patient_contact_address.country_id);
                    cmbx_Patient_State.SelectedValue = patient_contact_address.state_id;
                    Load_PatientCity(patient_contact_address.state_id);
                    cmbx_Patient_City.SelectedValue = patient_contact_address.city_id;
                    Load_PatientArea(patient_contact_address.city_id);
                    cmbx_Patient_Area.SelectedValue = patient_contact_address.area_id;
                    txt_Patient_ZipCode.Text = patient_contact_address.zipcode.ToString();
                }

                patient_Next_of_kinDAL patient_relative_db = new patient_Next_of_kinDAL();
                patient_Next_of_kinBAL patient_relative = patient_relative_db.LoadAll().Where(m => m.patient_id == id).FirstOrDefault();
                if (patient_relative != null)
                {
                    txt_Relative_Name.Text = patient_relative.name;
                    txt_Relative_RelationWithPAtient.Text = patient_relative.relation_to_patient;
                    txt_Relative_personalPhone.Text = patient_relative.phone_no;
                    txt_Relative_FirstAddress.Text = patient_relative.first_address;
                    txt_Relative_SecondAddress.Text = patient_relative.second_address;
                    Load_RelativeCountry();
                    cmbx_RelativeCountry.SelectedValue = patient_relative.country_id;
                    Load_RelativeState(patient_relative.country_id);
                    cmbx_RelativeState.SelectedValue = patient_relative.state_id;
                    Load_RelativeCity(patient_relative.state_id);
                    cmbx_RelativeCity.SelectedValue = patient_relative.city_id;
                    Load_RelativeArea(patient_relative.city_id);
                    cmbx_RelativeArea.SelectedValue = patient_relative.area_id;
                    txt_Relative_ZipCode.Text = patient_relative.zipcode;
                }

                btnSave.Text = "     Update";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            initial();
        }

        private void gridPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Content(e);
        }
        public void LoadDateofBrthFromAge()
        {
            int age = 0;
            string value = "";
            try
            {
                age = Convert.ToInt32(txt_Age_year.Text);
                value = (DateTime.Now.Year - age) + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " 00:00:00.000";
                Date_of_Birth_Picker.Value = Convert.ToDateTime(value);
            }
            catch (Exception)
            {
                Date_of_Birth_Picker.Value = DateTime.Now;
            }
        }

        private void txt_Age_year_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_Age_year.Text == "0")
                txt_Age_year.Text = "";
        }

        private void txt_Age_year_KeyUp(object sender, KeyEventArgs e)
        {
            LoadDateofBrthFromAge();
        }

        private void txt_Age_year_Leave(object sender, EventArgs e)
        {
            LoadDateofBrthFromAge();
        }
        public void LoadAgefromdateofBirth()
        {
            int age = 0;
            age = DateTime.Now.Year - Date_of_Birth_Picker.Value.Year;
            if (age >= 0)
            {
                txt_Age_year.Text = age.ToString();
            }
        }

        private void Date_of_Birth_Picker_ValueChanged(object sender, EventArgs e)
        {
            LoadAgefromdateofBirth();
        }

        private void cmbx_Pateint_country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Validate_cmbx_Pateint_country())
            {
                Load_PatientState(Guid.Parse(cmbx_Pateint_country.SelectedValue.ToString()));
            }
        }

        private void cmbx_Patient_State_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Validate_cmbx_Patient_State())
            {
                Load_PatientCity(Guid.Parse(cmbx_Patient_State.SelectedValue.ToString()));
            }
        }

        private void cmbx_Patient_City_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Validate_cmbx_Patient_City())
            {
                Load_PatientArea(Guid.Parse(cmbx_Patient_City.SelectedValue.ToString()));
            }
        }

        private void cmbx_RelativeCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Validate_cmbx_RelativeCountry())
            {
                Load_RelativeState(Guid.Parse(cmbx_RelativeCountry.SelectedValue.ToString()));
            }
        }

        private void cmbx_RelativeState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Validate_cmbx_RelativeState())
            {
                Load_RelativeCity(Guid.Parse(cmbx_RelativeState.SelectedValue.ToString()));
            }
        }

        private void cmbx_RelativeCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Validate_cmbx_RelativeCity())
            {
                Load_RelativeArea(Guid.Parse(cmbx_RelativeCity.SelectedValue.ToString()));
            }
        }
        public bool Validate_txt_RecordNo()
        {
            if (txt_RecordNo.Text == string.Empty)
            {
                lblError_RecordNo.Text = "*Required";
                return false;
            }
            else
            {
                if (All_PatientList.Where(m => m.patient_record_no.ToString() == txt_RecordNo.Text).ToList().Count > 0)
                {
                    lblError_RecordNo.Text = "Record No Already Exist";
                    return false;
                }
                else
                {
                    lblError_RecordNo.Text = "";
                    return true;
                }
            }
        }

        private void txt_RecordNo_KeyUp(object sender, KeyEventArgs e)
        {
            Validate_txt_RecordNo();
        }

        private void txt_RecordNo_Leave(object sender, EventArgs e)
        {
            Validate_txt_RecordNo();
        }
        public bool Validate_txt_Patient_Name()
        {
            if (txt_Patient_Name.Text == string.Empty)
            {
                lblError_PatientName.Text = "*Required";
                return false;
            }
            lblError_PatientName.Text = "";
            return true;
        }

        private void txt_Patient_Name_KeyUp(object sender, KeyEventArgs e)
        {
            Validate_txt_Patient_Name();
        }

        private void txt_Patient_Name_Leave(object sender, EventArgs e)
        {
            Validate_txt_Patient_Name();
        }

        private void txt_Age_month_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_Age_year.Text == "0")
                txt_Age_year.Text = "";
        }
    }
}
