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

namespace SicParvisMagna
{
    public partial class FormSQLBackup : Form
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        public FormSQLBackup()
        {
            InitializeComponent();
        }
      
      

        private void FormSQLBackup_Load(object sender, EventArgs e)
        {
            //timer1.Start();
              radProgressBar.Text = " Backup Succesfull";
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
