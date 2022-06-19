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

namespace SicParvisMagna.Forms.Attendance
{
    public partial class ucClasswiseMonthlyAttendanceReport : UserControl
    {
        public ucClasswiseMonthlyAttendanceReport()
        {
            InitializeComponent();
            loadCmbOrganization();

        }
        private Guid OrganizationID = Guid.Empty;
        private Guid BranchID = Guid.Empty;
        private Guid SectionId = Guid.Empty;
        private Guid SessionID = Guid.Empty;
        private Guid ClassID = Guid.Empty;
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

        private void loadComboSessions()
        {
            SessionDAL objDAL = new SessionDAL();
            cmbSession.DataSource = objDAL.LoadAll();
            cmbSession.ValueMember = "Session_id";
            cmbSession.DisplayMember = "Session_Name";
            cmbSession.SelectedIndex = -1;
        }
        public void clearALL()
        {
            cmbOrganization.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbSession.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            SectionId = Guid.Empty;
            ClassID = Guid.Empty;
            SessionID = Guid.Empty;
            OrganizationID = Guid.Empty;
            BranchID = Guid.Empty;
            
 
        }

        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {

            loadCmbBranch();
        }

        private void cmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadDepartment();

        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadComboSessions();

        }

        private void cmbSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SessionID = Guid.Parse(cmbSession.SelectedValue.ToString());
            loadClass();
        }

        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadSection();
        }

        private void btn_LoadREcords_Click(object sender, EventArgs e)
        {
            FormReport Form = new FormReport("Students Daily Attendance - Classwise Report", "DailyStudentAttendance", ClassID, SectionId, SessionID, dtp_Date.Value);
            Form.Show();
        }

        private void cmbSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SectionId = Guid.Parse(cmbSection.SelectedValue.ToString());

        }
    }
}
