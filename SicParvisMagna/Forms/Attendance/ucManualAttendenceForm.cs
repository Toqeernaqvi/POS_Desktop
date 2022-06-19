using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SicParvisMagna.Forms
{
    public partial class ucManualAttendenceForm : UserControl
    {
        private Guid ClassID = Guid.Empty;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid SectionId = Guid.Empty;
        private Guid SessionID = Guid.Empty;
        private Guid feechallanid = Guid.Empty;
        bool Update = false;

        private void loadCmbOrganization()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            cmbOrganization.DataSource = objDAL.LoadAll();
            cmbOrganization.ValueMember = "Organization_id";
            cmbOrganization.DisplayMember = "Title";
            cmbOrganization.SelectedIndex = -1;
        }

        private void loadCmbBranch()
        {
            OrganizationDAL objDAL = new OrganizationDAL();
            OrganizationBAL obj = new OrganizationBAL();
            OrganizationID = Guid.Parse(cmbOrganization.SelectedValue.ToString());
            obj.Parent_id = OrganizationID;

            cmbBranch.DataSource = objDAL.LoadBranch(obj);
            cmbBranch.ValueMember = "Organization_id";
            cmbBranch.DisplayMember = "Title";
            cmbBranch.SelectedIndex = -1;
        }

        public void loadDepartment()
        {
            //   ClassesDAL objDAL = new ClassesDAL();
            var objDAL = new Department_DAL();
            cmbDepartment.DataSource = objDAL.Load();
            // cmbClass.DataSource = objDAL.LoadAll();
            cmbDepartment.ValueMember = "dept_id";
            cmbDepartment.DisplayMember = "name";
            cmbDepartment.SelectedIndex = -1;

        }
        public void loadGridHeads()
        {


        }

        public void loadGridFeeGenerated()
        {
            Search();
        }

        public void loadClass()
        {
            try
            {
                //   ClassesDAL objDAL = new ClassesDAL();
                var objDAL = new ClassDAL();
                var objBal = new ClassBAL();
                BranchID = Guid.Parse(cmbBranch.SelectedValue.ToString());
                objBal.branchid = BranchID;
                cmbClass.DataSource = objDAL.Loadbyinstid(objBal);
                // cmbClass.DataSource = objDAL.LoadAll();
                cmbClass.ValueMember = "id";
                cmbClass.DisplayMember = "title";
                cmbClass.SelectedIndex = -1;
            }
            catch { }

        }

        public void loadSection()
        {
            ClassID = Guid.Parse(cmbClass.SelectedValue.ToString());
            //MessageBox.Show(BranchID.ToString());
            var objDAL = new SectionDAL();
            var objBal = new SectionBAL();
            objBal.Classid = ClassID;
            cmbSection.DataSource = objDAL.loadbyclass(objBal);
            cmbSection.ValueMember = "id";
            cmbSection.DisplayMember = "title";
            cmbSection.SelectedIndex = -1;
        }
        public void clearALL()
        {
            cmbSession.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            SectionId = Guid.Empty;
            ClassID = Guid.Empty;
            SessionID = Guid.Empty;
            Update = false;

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearALL();
        }
        public ucManualAttendenceForm()
        {
            InitializeComponent();
            loadClass();
            loadGridHeads();
            loadGridFeeGenerated();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateFeeGenerate())
            {
                 
                AttendanceBAL obj = new AttendanceBAL();
                AttendanceDAL objd = new AttendanceDAL();

                obj.Class_id =  Guid.Parse(cmbClass.SelectedValue.ToString());
                obj.Section_id =  Guid.Parse(cmbSection.SelectedValue.ToString());
                obj.Session_id = SessionID;
                obj.date = dtp_Date.Value;

                for (int x = 0; x < dataGridView_Attendance.Rows.Count; x++)
                {
                    obj.studentid = Guid.Parse(dataGridView_Attendance.Rows[x].Cells["StudentId"].Value.ToString());
                    try
                    {
                        int status = Convert.ToInt32(dataGridView_Attendance.Rows[x].Cells["Status"].Value);
                        if (status < 0)
                        {
                            continue;
                        }
                        else if (status == 1)
                        {
                            obj.status = "Present";
                        }
                        else if (status == 2)
                        {
                            obj.status = "Absent";
                        }
                        else if (status == 3)
                        {
                            obj.status = "On Leave";
                        }
                        else if (status == 4)
                        {
                            obj.status = "InActive";
                        }
                    }
                    catch
                    {
                        obj.status = dataGridView_Attendance.Rows[x].Cells["Status"].Value.ToString();
                    }

                    if (Update)
                    {
                        Guid RowID;
                        try
                        {
                            RowID = Guid.Parse(dataGridView_Attendance.Rows[x].Cells["Id"].Value.ToString());
                        }
                        catch
                        {
                            RowID = Guid.Empty;
                        }


                        if (RowID!=Guid.Empty)
                        {
                            objd.TimeIn_ManualUpdate(obj);
                        }
                        else
                        {
                            objd.TimeIn_Manual(obj);
                        }
                    }
                    else
                        objd.TimeIn_Manual(obj);


                }
            }
            clearALL();
            loadGridFeeGenerated();
        }

        private bool ValidateFeeGenerate()
        {
            return true;
        }
        private bool ValidateForm()
        {
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (feechallanid!=Guid.Empty)
            {
                FeeGenerateBAL objBal = new FeeGenerateBAL();
                objBal.fee_challan_id = feechallanid;

                FeeGenerateDAL objDal = new FeeGenerateDAL();
                objDal.suspendFeeChallan(objBal);

                loadGridFeeGenerated();
            }
            else
            {
                MessageBox.Show("Please Select FeeChallan in order to suspend it");
            }
        }

        private void cmbSection_DropDown(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex > -1)
            {
                loadSection();
            }
        }

        private void loadComboSessions()
        {
            SessionDAL objDAL = new SessionDAL();
            cmbSession.DataSource = objDAL.LoadAll();
            cmbSession.ValueMember = "Session_id";
            cmbSession.DisplayMember = "Session_Name";
            cmbSession.SelectedIndex = -1;
        }

        private void cmbSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SessionID = Guid.Parse(cmbSession.SelectedValue.ToString());
            loadClass();

        }
        private bool ValidateSearch()
        {
            if (cmbSession.SelectedIndex < 0)
            {
                lblError_Session.Text = "Session Required";
                return false;
            }
            else
                lblError_Session.Text = "";

            if (cmbClass.SelectedIndex < 0)
            {
                lblError_class.Text = "Class Required";
                return false;
            }
            else
                lblError_class.Text = "";

            if (cmbSection.SelectedIndex < 0)
            {
                lblError_section.Text = "Section Required";
                return false;
            }
            else
                lblError_section.Text = "";

            return true;
        }
        private void updateStudentStatusCount()
        {
            int present = 0, absent = 0, leaves = 0;

            for (int x = 0; x < dataGridView_Attendance.Rows.Count; x++)
            {
                string status = "";
                try
                {
                    status = dataGridView_Attendance.Rows[x].Cells["Status"].Value.ToString();
                }
                catch { }

                if (status == "1")
                    present++;
                else if (status == "2")
                    absent++;
                else if (status == "3")
                    leaves++;

            }
            lblPresents.Text = present.ToString();
            lblAbsentees.Text = absent.ToString();
            lblLeaves.Text = leaves.ToString();

        }
        private void cmbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {

              SectionId = Guid.Parse(cmbSection.SelectedValue.ToString());
        }

        private void panelToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_Attendance_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }
        private void Search()
        {
            if (ValidateSearch())
            {
                dataGridView_Attendance.DataSource = null;
                dataGridView_Attendance.Rows.Clear();
                dataGridView_Attendance.Columns.Clear();


                AttendanceDAL objDal = new AttendanceDAL();
                AttendanceBAL objBal = new AttendanceBAL();

                objBal.Class_id = ClassID;
                objBal.Section_id = SectionId;
                objBal.Session_id = SessionID;
                objBal.date = dtp_Date.Value;


                DataTable dt = objDal.SearchExistingAttendance(objBal);

                if (dt.Rows.Count <= 0)
                {
                    // For New Entry
                    Update = false;
                    dataGridView_Attendance.DataSource = objDal.SearchAttendanceNoStatusStudents(objBal);

                    DataGridViewComboBoxColumn statuscbc = new DataGridViewComboBoxColumn();
                    List<Item> items = new List<Item>();

                    items.Add(new Item() { Name = "Present", Id = 1 });
                    items.Add(new Item() { Name = "Absent", Id = 2 });
                    items.Add(new Item() { Name = "On Leave", Id = 3 });
                    items.Add(new Item() { Name = "InActive", Id = 4 });

                    statuscbc.DataSource = items;
                    statuscbc.ValueMember = "Id";
                    statuscbc.DisplayMember = "Name";
                    statuscbc.HeaderText = "Status";
                    statuscbc.DataPropertyName = "Status";
                    statuscbc.Name = "Status";

                    dataGridView_Attendance.Columns.Add(statuscbc);

                    for (int x = 0; x < dataGridView_Attendance.Rows.Count; x++)
                    {
                        dataGridView_Attendance.Rows[x].Cells["Status"].Value = 1;
                    }

                }
                else
                {
                    // For Updating
                    Update = true;

                    dataGridView_Attendance.DataSource = dt;

                    dataGridView_Attendance.Columns["Id"].Visible = false;

                    DataGridViewComboBoxColumn statuscbc = new DataGridViewComboBoxColumn();
                    List<Item> items = new List<Item>();

                    items.Add(new Item() { Name = "Present", Id = 1 });
                    items.Add(new Item() { Name = "Absent", Id = 2 });
                    items.Add(new Item() { Name = "On Leave", Id = 3 });
                    items.Add(new Item() { Name = "InActive", Id = 4 });

                    statuscbc.DataSource = items;
                    statuscbc.ValueMember = "Id";
                    statuscbc.DisplayMember = "Name";
                    statuscbc.HeaderText = "Status";
                    statuscbc.DataPropertyName = "Status";
                    statuscbc.Name = "Status";

                    dataGridView_Attendance.Columns.Add(statuscbc);
                    dataGridView_Attendance.Columns["SavedStatus"].Visible = false;

                    for (int x = 0; x < dataGridView_Attendance.Rows.Count; x++)
                    {
                        try
                        {
                            if (dataGridView_Attendance.Rows[x].Cells["SavedStatus"].Value.ToString() == "Present")
                                dataGridView_Attendance.Rows[x].Cells["Status"].Value = 1;
                            else if (dataGridView_Attendance.Rows[x].Cells["SavedStatus"].Value.ToString() == "Absent")
                                dataGridView_Attendance.Rows[x].Cells["Status"].Value = 2;
                            else if (dataGridView_Attendance.Rows[x].Cells["SavedStatus"].Value.ToString() == "On Leave")
                                dataGridView_Attendance.Rows[x].Cells["Status"].Value = 3;
                            else if (dataGridView_Attendance.Rows[x].Cells["SavedStatus"].Value.ToString() == "InActive")
                                dataGridView_Attendance.Rows[x].Cells["Status"].Value = 4;
                            else
                                dataGridView_Attendance.Rows[x].Cells["Status"].Value = 1;
                        }
                        catch
                        {
                            dataGridView_Attendance.Rows[x].Cells["Status"].Value = 4;
                        }

                    }
                    //objDal.DeleteByClass(objBal);
                    //dataGridView_Attendance.DataSource = objDal.SearchAttendance(objBal);
                }

                //  DataTable dt1 = objDal.SearchAttendanceNoAttendance(objBal);
                //  if (dt1.Rows.Count <= 0)
                //    else
                //      dataGridView_Attendance.DataSource = objDal.SearchAttendanceNoAttendance(objBal);

                // Update = false;
                dataGridView_Attendance.Columns["StudentId"].Visible = false;
                updateStudentStatusCount();
            }
            else
            {
                dataGridView_Attendance.DataSource = null;
                dataGridView_Attendance.Rows.Clear();
                dataGridView_Attendance.Columns.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbSection_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
             SectionId = Guid.Parse(cmbSection.SelectedValue.ToString());

        }

        private void dataGridView_Attendance_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }

        private void dataGridView_Attendance_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateStudentStatusCount();
        }

        private void dataGridView_Attendance_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            updateStudentStatusCount();
        }
        public class Item
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }

        private void ucManualAttendenceForm_Load(object sender, EventArgs e)
        {
            loadCmbOrganization();
            loadComboSessions();
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadCmbBranch();
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadDepartment();
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
