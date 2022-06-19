using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms.ChartOfAccounts
{
    public partial class ucManageArrearAndDiscounts : UserControl
    {
        private Guid ClassID = Guid.Empty;
        private Guid SessionID = Guid.Empty;
        private Guid SectionID = Guid.Empty;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public ucManageArrearAndDiscounts()
        {
            InitializeComponent();
            loadClass();
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "MM/yyyy";
            rdbtn_All.Checked = true;
            loadComboSessions();
        }
        private void loadComboSessions()
        {
            SessionDAL objDAL = new SessionDAL();
            cmbSession.DataSource = objDAL.LoadAll();
            cmbSession.ValueMember = "Session_id";
            cmbSession.DisplayMember = "Session_Name";
            cmbSession.SelectedIndex = -1;
        }
        public void loadClass()
        {
            ClassDAL objDAL = new ClassDAL();
            cmbClass.DataSource = objDAL.LoadAll();
            cmbClass.ValueMember = "id";
            cmbClass.DisplayMember = "title";
            cmbClass.SelectedIndex = -1;

        }
        public void loadSection()
        {
            Guid.TryParse(cmbClass.SelectedValue.ToString(), out ClassID);
            //MessageBox.Show(BranchID.ToString());

            AcademicsSectionBAL objBAL = new AcademicsSectionBAL();
            AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
            objBAL.classid = ClassID;
            cmbSection.DataSource = objDAL.LoadByClass(objBAL);
            cmbSection.ValueMember = "id";
            cmbSection.DisplayMember = "title";
            cmbSection.SelectedIndex = -1;
        }
        public void searchStudents()
        {
            loaddgvFeeSubmit();
        }

        private void loaddgvFeeSubmit()
        {
            if (ValidateFeeGenerate())
            {
                dgvStudFees.Rows.Clear();
                dgvStudFees.Columns.Clear();

                FeeGenerateBAL obj = new FeeGenerateBAL();
                FeeGenerateDAL objd = new FeeGenerateDAL();

                 Guid.TryParse(cmbClass.SelectedValue.ToString(), out ClassID);
                obj.class_id = ClassID;
                Guid.TryParse(cmbSection.SelectedValue.ToString(), out SectionID);
                obj.section_id = SectionID;

                obj.fee_month = dtp_Date.Value;
                obj.Session_id = SessionID;


                DataTable students = new DataTable();

                students = objd.getStudentsForFeeSubmittionAll(obj);
                // students = objd.getStudentsForFeeSubmittionByChallan(obj);


                foreach (DataColumn dc in students.Columns)
                {
                    dgvStudFees.Columns.Add(dc.ColumnName, dc.ColumnName);
                }
                foreach (DataRow dr in students.Rows)
                {
                    dgvStudFees.Rows.Add(dr.ItemArray);
                }

                dgvStudFees.Columns["challan_no"].Visible = false;
                dgvStudFees.Columns["id"].Visible = false;

                initDiscountInGrid();
                clearALL();
                // loadGridFeeGenerated();
            }
        }

        private void initDiscountInGrid()
        {
            for (int x = 0; x < dgvStudFees.Rows.Count; x++)
            {
                int num;
                try
                {
                    if (!Int32.TryParse(dgvStudFees.Rows[x].Cells["discountAmount"].Value.ToString(), out num))
                        dgvStudFees.Rows[x].Cells["discountAmount"].Value = "0";
                    if (!Int32.TryParse(dgvStudFees.Rows[x].Cells["discountPercentage"].Value.ToString(), out num))
                        dgvStudFees.Rows[x].Cells["discountPercentage"].Value = "0";
                    dgvStudFees.Rows[x].Cells["Net Amount"].Value = "0";

                    int discountAmount = Convert.ToInt32(dgvStudFees.Rows[x].Cells["discountAmount"].Value.ToString());
                    int totalAmount = Convert.ToInt32(dgvStudFees.Rows[x].Cells["Total Fee"].Value.ToString());
                    int Arrear = Convert.ToInt32(dgvStudFees.Rows[x].Cells["arrear"].Value.ToString());

                    dgvStudFees.Rows[x].Cells["Net Amount"].Value = (totalAmount + Arrear) - discountAmount;

                }
                catch { }
            }
        }
        private bool ValidateFeeGenerate()
        {
            if (cmbClass.SelectedIndex < 0)
            {
                cmbClass.BackColor = Color.Tomato;
                return false;
            }
            else
            {
                cmbClass.BackColor = Color.White;

            }
            if (cmbSection.SelectedIndex < 0)
            {
                cmbClass.BackColor = Color.Tomato;
                return false;
            }
            else
            {
                cmbClass.BackColor = Color.White;

            }


            return true;
        }
        public void clearALL()
        {

        }


        private void cmbSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
           SessionID = Guid.Parse(cmbSession.SelectedValue.ToString());

        }

        private void cmbSection_DropDown(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex > -1)
            {
                loadSection();
            }
        }

        private void rdbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            loaddgvFeeSubmit();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchStudents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dgvStudFees.Rows.Count; x++)
            {
                if (ValidateFeeGenerate())
                {
                    FeeGenerateDAL objd = new FeeGenerateDAL();
                    FeeGenerateBAL objStud = new FeeGenerateBAL();

                    objStud.arrear = Convert.ToInt32(dgvStudFees.Rows[x].Cells["arrear"].Value.ToString());
                    objStud.student_challan_id =  Guid.Parse(dgvStudFees.Rows[x].Cells["challan_no"].Value.ToString());
                    objStud.student_id =  Guid.Parse(dgvStudFees.Rows[x].Cells["id"].Value.ToString());
                    objStud.discount_Amount = Convert.ToInt32(dgvStudFees.Rows[x].Cells["discountAmount"].Value.ToString());
                    objStud.discount_Percentage = Convert.ToInt32(dgvStudFees.Rows[x].Cells["discountPercentage"].Value.ToString());

                    objd.saveStudentArrear(objStud);


                    //     this.Close();
                }
            }
            MessageBox.Show("Arrear Updated", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaddgvFeeSubmit();
        }

        private void rdbtn_paid_CheckedChanged(object sender, EventArgs e)
        {
            loaddgvFeeSubmit();

        }

        private void rdbtn_unpaid_CheckedChanged(object sender, EventArgs e)
        {
            loaddgvFeeSubmit();

        }

        private void dgvStudFees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStudFees.Rows[e.RowIndex].Cells["discountPercentage"].ColumnIndex || e.ColumnIndex == dgvStudFees.Rows[e.RowIndex].Cells["arrear"].ColumnIndex)
            {
                percentageCalc(e);
                calcNetTotal(e);
            }
            else if (e.ColumnIndex == dgvStudFees.Rows[e.RowIndex].Cells["discountAmount"].ColumnIndex)
            {
                calcNetTotal(e);
                calcPercentage(e);
             }
        }

        private void percentageCalc(DataGridViewCellEventArgs e)
        {
            try
            {
                double percentage = Convert.ToDouble(dgvStudFees.Rows[e.RowIndex].Cells["discountPercentage"].Value.ToString());
                double totalAmount = Convert.ToDouble(dgvStudFees.Rows[e.RowIndex].Cells["Total Fee"].Value.ToString());

                double unit = (totalAmount / 100);
                double discountAmount = unit * percentage;
                dgvStudFees.Rows[e.RowIndex].Cells["discountAmount"].Value = Math.Round(discountAmount).ToString();


            }
            catch { }
        }

        private void calcNetTotal(DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            try
            {
                int discountAmount = Convert.ToInt32(dgvStudFees.Rows[x].Cells["discountAmount"].Value.ToString());
                int totalAmount = Convert.ToInt32(dgvStudFees.Rows[x].Cells["Total Fee"].Value.ToString());
                int Arrear = Convert.ToInt32(dgvStudFees.Rows[x].Cells["arrear"].Value.ToString());

                dgvStudFees.Rows[x].Cells["Net Amount"].Value = (totalAmount + Arrear) - discountAmount;

            }
            catch { dgvStudFees.Rows[x].Cells["Net Amount"].Value = 0; }

        }

        private void calcPercentage(DataGridViewCellEventArgs e)
        {
            try
            {
                double discountAmount = Convert.ToDouble(dgvStudFees.Rows[e.RowIndex].Cells["discountAmount"].Value.ToString());
                double totalAmount = Convert.ToDouble(dgvStudFees.Rows[e.RowIndex].Cells["Total Fee"].Value.ToString());

                 
                double  Percentage =  (discountAmount/totalAmount) * 100;
                dgvStudFees.Rows[e.RowIndex].Cells["discountPercentage"].Value = Math.Round(Percentage);


            }
            catch { }
        }


    }
}
