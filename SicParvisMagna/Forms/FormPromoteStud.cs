using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SicParvisMagna.Library;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;

namespace SicParvisMagna.Forms
{
    public partial class FormPromoteStud : UserControl
    {

        private Guid  BranchID = Guid.Empty;
        private Guid NewClassID = Guid.Empty;
        private Guid NewSectionID = Guid.Empty;
        private Guid NewSessionID = Guid.Empty;
        private Guid OldClassID = Guid.Empty;
        private Guid OldSectionID = Guid.Empty;
        private Guid OldSessionID = Guid.Empty;

        public FormPromoteStud()
        {
            InitializeComponent();
        }


        private void LoadOldSectionByClassId()
        {
          // OldClassID= Guid.Parse(cbx_PreviousClass.SelectedValue.ToString());
            AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
            AcademicsSectionBAL objBal = new AcademicsSectionBAL();
            objBal.classid = OldClassID;
            cbx_PreviousSection.DataSource = objDAL.LoadByClass(objBal);
            cbx_PreviousSection.ValueMember = "id";
            cbx_PreviousSection.DisplayMember = "title";
            cbx_PreviousSection.SelectedIndex = -1;
        }
        private void LoadNewSectionByClassId()
        {
           //NewClassID= Guid.Parse(cbx_NextClass.SelectedValue.ToString());

            AcademicsSectionDAL objDAL = new AcademicsSectionDAL();
            AcademicsSectionBAL objBal = new AcademicsSectionBAL();
            objBal.classid = NewClassID;
            cbx_NewSection.DataSource = objDAL.LoadByClass(objBal);
            cbx_NewSection.ValueMember = "id";
            cbx_NewSection.DisplayMember = "title";
            cbx_NewSection.SelectedIndex = -1;
        }


        private void LoadClassByBranchId()

        {
            ClassDAL objDAL = new ClassDAL();
            ClassBAL objBal = new ClassBAL();
            objBal.branchid = BranchID;
            cbx_PreviousClass.DataSource = objDAL.LoadByBranch(objBal);
           
            cbx_PreviousClass.ValueMember = "id";
            cbx_PreviousClass.DisplayMember = "title";
            cbx_PreviousClass.SelectedIndex = -1;

            cbx_NextClass.DataSource = objDAL.LoadByBranch(objBal);
            cbx_NextClass.ValueMember = "id";
            cbx_NextClass.DisplayMember = "title";
            cbx_NextClass.SelectedIndex = -1;
        }
        private void LoadSessions()
        {
            SessionDAL objDAL = new SessionDAL();
          //  SessionBAL objBAL = new SessionBAL();
            cbx_NextSession.DataSource = objDAL.LoadAll();
            cbx_NextSession.ValueMember = "Session_id";
            cbx_NextSession.DisplayMember = "Session_Name";
            cbx_NextSession.SelectedIndex = -1;

            cbx_PreviousSession.DataSource = objDAL.LoadAll();
            cbx_PreviousSession.ValueMember = "Session_id";
            cbx_PreviousSession.DisplayMember = "Session_Name";
            cbx_PreviousSession.SelectedIndex = -1;
        }



        private void FormPromoteStud_Load(object sender, EventArgs e)
        {
            LoadClassByBranchId();
           
           
            LoadSessions();
        }

        private bool ValidateForm()
        {
            if (!(cbx_PreviousSession.SelectedIndex >= 0))
            {
                LblError_PreSession.Text = "Previous Session Required!";
                return false;
            }
            else
                LblError_PreSession.Text = "";

            if (!(cbx_PreviousClass.SelectedIndex >= 0))
            {
                lblError_PreviousClass.Text = "Previous Class Required!";
                return false;
            }
            else
                lblError_PreviousClass.Text = "";


            if (!(cbx_PreviousSection.SelectedIndex >= 0))
            {
                lblError_PreviousSection.Text = "Previous Section Required!";
                return false;
            }
            else
                lblError_PreviousSection.Text = "";




            if (!(cbx_NextSession.SelectedIndex >= 0))
            {
                lblError_NewSession.Text = "New Session Required!";
                return false;
            }
            else
                lblError_NewSession.Text = "";

            if (!(cbx_NextClass.SelectedIndex >= 0))
            {
                lblError_NewClass.Text = "New Class Required!";
                return false;
            }
            else
                lblError_NewClass.Text = "";


            if (!(cbx_NewSection.SelectedIndex >= 0))
            {
                lblError_NewSection.Text = "New Section Required!";
                return false;
            }
            else
                lblError_NewSection.Text = "";





            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StudentBAL objBAL = new StudentBAL();
                Promote_stuBAL obj = new Promote_stuBAL();
               
                Promote_studDAL ObjDAL = new Promote_studDAL();

                SessionDAL objDAL = new SessionDAL();
                string check = "";
                for (int x = 0; x < gridPromoteStud.Rows.Count; x++)
                {
                    check = (string)gridPromoteStud.Rows[x].Cells[0].Value;

                    if (check == "True")
                    {
                        objBAL.id = Guid.Parse(gridPromoteStud.Rows[x].Cells["id"].Value.ToString());
                        objBAL.registration = gridPromoteStud.Rows[x].Cells["Regestraion_no"].Value.ToString();
                        objBAL.section = NewSectionID;
                        objBAL.classid = NewClassID;
                        objBAL.Session_id = NewSessionID;

                        objDAL.PromoteStudent(objBAL);
                        objDAL.StudentLOG(obj);
                        
                        
                      //  UpdateRegno(objBAL.Student_id, objBAL.Student_Registration);
                    }
                }
                Search();
            }
        }


        private void UpdateRegno(Guid id, string regno)
        {


            SqlConnection con = new SQLCon().getCon();
            SqlCommand cmd = new SqlCommand();
            try
            {

                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Students set registration='" + regno + "' Where id=" + id + "";
                cmd.Parameters.Clear();


                cmd.ExecuteNonQuery();
                con.Close();



            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ClearAll()
        {
            cbx_NewSection.SelectedIndex = -1;
            cbx_NextClass.SelectedIndex = -1;
            cbx_NextSession.SelectedIndex = -1;
            cbx_PreviousSession.SelectedIndex = -1;
            cbx_PreviousSection.SelectedIndex = -1;
            cbx_PreviousClass.SelectedIndex = -1;

            gridPromoteStud.DataSource = null;
            gridPromoteStud.Rows.Clear();


        }
        private void Search()
        {
            if (ValidateForm())
            {
                RegnoCls rgno = new RegnoCls();
                StudentBAL objBAL = new StudentBAL();
                SessionDAL objDAL = new SessionDAL();

                objBAL.Session_id = OldSessionID;
                objBAL.classid = OldClassID;
                objBAL.section = OldSectionID;

                gridPromoteStud.DataSource = objDAL.searchStudentsByClassSection(objBAL);
                string regno = "";
                for (int x = 0; x < gridPromoteStud.Rows.Count; x++)
                {
                    regno = rgno.getSerialno(Guid.Parse(gridPromoteStud.Rows[x].Cells["id"].Value.ToString()), OldClassID);
                    gridPromoteStud.Rows[x].Cells["Regestraion_no"].Value = regno;
                    if (regno == "*Class Level not set*")
                    {
                        gridPromoteStud.Rows[x].Cells["Regestraion_no"].Style.BackColor = Color.Red;
                    }

                }


            }
        }
        private void lblError_PreviousSession(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void cbx_PreviousClass_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbx_PreviousClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OldClassID = Guid.Parse(cbx_PreviousClass.SelectedValue.ToString());
        }

        private void cbx_PreviousSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OldSectionID = Guid.Parse(cbx_PreviousSection.SelectedValue.ToString());
        }

        private void cbx_NextClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NewClassID = Guid.Parse(cbx_NextClass.SelectedValue.ToString());
        }

        private void cbx_NewSection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NewSectionID = Guid.Parse(cbx_NewSection.SelectedValue.ToString());
        }

        private void cbx_NextSession_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadClassByBranchId();
        }
    }
}
