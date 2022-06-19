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
using System.IO;

namespace SicParvisMagna.Forms
{
    public partial class ucComments : UserControl
    {

        private Guid COMID = Guid.Empty;
        private Guid IssueId = Guid.Empty;
        private string sourceFile = "";
        private string destinationFile = "";
        private string issueStatus = "";
        private FormMain parentForm;

        public ucComments(FormMain fmr,Guid issID)
        {
            InitializeComponent();
            loadIssueByID(issID);
            IssueId = issID;
            parentForm = fmr;

        }

        public ucComments()
        {
            InitializeComponent();

        }
        public void loadIssueByID(Guid ID)
        {
            IssueDAL objDAL = new IssueDAL();

            DataTable dt = objDAL.LoadByID(ID);
            if (dt.Rows.Count > 0)
            {

                txt_Name.Text = dt.Rows[0]["Title"].ToString();
                txt_Description.Text = dt.Rows[0]["descript"].ToString();
                issueStatus = dt.Rows[0]["status"].ToString();
                if (issueStatus == "Active")
                    btnChangeStatus.Text = "Close Issue";
                else
                    btnChangeStatus.Text = "Open Issue";
            }
            else
            {
                MessageBox.Show("Invalid Issue");
            }
        }
        private void loadComments()
        {
            CommDAL objDAL = new CommDAL();
            gridview_comment.DataSource = objDAL.Loadcomment();

            //gridview_comment.DataSource = objDAL.LoadByIssue(IssueId);
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            IssueDAL objDAL = new IssueDAL();
            IssueBAL objBAL = new IssueBAL();
            //objBAL.title = txt_title.Text;
            objBAL.Title = txt_Name.Text;
            objBAL.descript = txt_Description.Text;
            objBAL.Issue_id = IssueId;

            objDAL.Update(objBAL);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucAddCountry_Load(object sender, EventArgs e)
        {
            loadComments();
            clearAll();
        }

        private void gridCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            if (rowindex >= 0)
            {
                Guid.TryParse(gridview_comment.Rows[rowindex].Cells["Comm_id"].Value.ToString(), out COMID);
                //  txt_title.Text = gridview_comment.Rows[rowindex].Cells["title"].Value.ToString();

                txt_Description.Text = gridview_comment.Rows[rowindex].Cells["descript"].Value.ToString();
               btnSave.Text = "Update Comment";


            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridCountries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_bkcolor_Click(object sender, EventArgs e)
        {
          
        }

        private void clearAll()
        {
          
        }


    
        private void btn_forecolor_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Please select your file";
            opf.Filter = "TextFile|*.txt|ZipFile|*.zip|All|*.*";//your filter;
            opf.FilterIndex = 1;
            DialogResult result = opf.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = opf.FileName;//file path
                string ext = Path.GetExtension(fileName);
                //  string[] foldername = { @"D:\PROJECTS", "ticket-management-system", "BasicCRUD", "bin" ,"Debug","Attachments"};
                string path = System.IO.Path.GetDirectoryName(
                                 System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Substring(6);
                Random random = new Random();
                path = path + "\\Attachments\\" + IssueId + random.Next() + ext; // concatinate folder name
                                                                                         // Copy file and rename file

                sourceFile = fileName;
                destinationFile = path;
                //File.Copy(fileName, path);//(newPath, newPath.Replace(sourceLoc, destLoc));
                // File path concatinate
                // Save path in database on save

                //do something...
            }

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            CommentBAL objBAL = new CommentBAL();
            //objBAL.title = txt_title.Text;
            objBAL.descript = txt_Description.Text;
            objBAL.Issue_id = IssueId;



            CommDAL objDAL = new CommDAL();

            if (COMID!=Guid.Empty)
            {
                objBAL.Comm_id = COMID;
                objBAL.Issue_id = IssueId;
                objBAL.edit_by = "Admin";
                objBAL.status = "Active";
                objBAL.attachments = destinationFile;
                objBAL.flag = 1;
                objBAL.date = DateTime.Now;
                objBAL.descript = txt_Description.Text;
                objDAL.Update(objBAL);

                // objBAL.attachments = path; // attach attachment path  | change datatype to string in sp/bal/dal
                // objBAL.Add(objBAL);


                if (!string.IsNullOrEmpty(sourceFile))
                    File.Copy(sourceFile, destinationFile); //(newPath, newPath.Replace(sourceLoc, destLoc));

            }

            else
            {
                objBAL.edit_by = "Admin";
                objBAL.status = "Active";
                objBAL.attachments = destinationFile;
                objBAL.flag = 1;
                objBAL.date = DateTime.Now;
                objDAL.Add(objBAL);

                if (!string.IsNullOrEmpty(sourceFile))
                    File.Copy(sourceFile, destinationFile); //(newPath, newPath.Replace(sourceLoc, destLoc));



            }

            loadComments();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            IssueDAL objDAL = new IssueDAL();
            IssueBAL objBAL = new IssueBAL();
            objBAL.Issue_id = Guid.Empty;

            if (issueStatus == "Active")
                objDAL.buttonClose_Issue(objBAL);
            else
                objDAL.buttonClose_Issue(objBAL); // 
            


        }

        private void bunifuTileButton2_Click_1(object sender, EventArgs e)
        {
            parentForm.loadIssuesListingForm();
        }
    }
}
