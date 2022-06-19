using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicParvisMagna.Library;
using System.Data.SqlClient;

namespace SicParvisMagna
{
    public partial class FormLogin : Form
    {
        public static string username ;
        //Generate Hash
        static string generateHash(string rawData)


        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        //static UserDAL userdb = new UserDAL();
        //E_And_D ea = new E_And_D();
        //List<UserBAL> userlisst = userdb.LoadAll();
        //SpeechSynthesizer spch = new SpeechSynthesizer();



        public FormLogin()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //1024, 768
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1024, 768);
            }

            else
                this.WindowState = FormWindowState.Maximized;

          //  panelLeftFlow.Refresh();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                  this.WindowState = FormWindowState.Normal;
            else
                  this.WindowState = FormWindowState.Minimized;
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
          
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            UserBAL obj = new UserBAL();
            UserDAL objDAL = new UserDAL();
            obj.User_name = txtbUsername.Text;
            Program.User_name = txtbUsername.Text;
            string hash = generateHash(txtbPassword.Text);
            obj.password = hash;
            dt = objDAL.Login(obj);
            if (dt.Rows.Count > 0)
            {

                Program.User_id = Guid.Parse((dt.Rows[0]["User_id"]).ToString());
                POSMain frm = new POSMain(Program.User_name, Program.User_id);
                frm.Show();
                this.Hide();
            }
            //DataTable dt = new DataTable();
            //UserBAL obj = new UserBAL();
            //UserDAL objDAL = new UserDAL();
            //obj.User_name = txtbUsername.Text;
            //Program.User_name = txtbUsername.Text;
            //string hash = generateHash(txtbPassword.Text);
            //obj.password = hash;
            //dt = objDAL.Login(obj);
            //if (dt.Rows.Count > 0)
            //{

            //    Program.User_id = Guid.Parse((dt.Rows[0]["User_id"]).ToString());
            //    FormMain frm = new FormMain(Program.User_name, Program.User_id);
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    lbl_error.Text = "Invalid Username or Password";
            //}
            //FormMain frm = new FormMain("administration", Guid.Empty);
            //frm.Show();
            //this.Hide();

        }
        private void Authenticate ()
        {

            DataTable dt = new DataTable();
            UserBAL obj = new UserBAL();
            UserDAL objDAL = new UserDAL();
            obj.User_name = txtbUsername.Text;
            Program.User_name = txtbUsername.Text;
            string hash = generateHash(txtbPassword.Text);
            obj.password = hash;
            dt = objDAL.Login(obj);
            if (dt.Rows.Count > 0)
            {

                Program.User_id = Guid.Parse((dt.Rows[0]["User_id"]).ToString());
                FormMain frm = new FormMain(Program.User_name, Program.User_id);
                frm.Show();
                this.Hide();
            }
            else
            {
                lbl_error.Text = "Invalid Username or Password";
            }
             
        }
        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {

           
        }
    

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Authenticate();
                
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            UserBAL obj = new UserBAL();
            UserDAL objDAL = new UserDAL();
            obj.User_name = txtbUsername.Text;
            Program.User_name = txtbUsername.Text;
            string hash = generateHash(txtbPassword.Text);
            obj.password = hash;
            dt = objDAL.Login(obj);
            if (dt.Rows.Count > 0)
            {

                Program.User_id = Guid.Parse((dt.Rows[0]["User_id"]).ToString());
                POSMain1 frm = new POSMain1(Program.User_name, Program.User_id);
                frm.Show();
                this.Hide();

            }
        }
    }
}
