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
    public partial class ucEditCalendar : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        public ucEditCalendar()
        {
            InitializeComponent();
        }
        private void Loadgrid()
        {
            CalendarDAL objDAL = new CalendarDAL();
            gridCalendar.DataSource = objDAL.LoadAll();
        }
        private void LoadgridByDate()
        {
            DataTable dt = new DataTable();
            CalendarBAL objBAL = new CalendarBAL();
            CalendarDAL objDAL = new CalendarDAL();
            objBAL.date = dtpSelectDate.Value;
            dt = objDAL.LoadAllByDate(objBAL);

            gridCalendar.DataSource = dt;
                
            if (dt.Rows.Count > 0)
            {
                cmbKindOfDay.Text =  (dt.Rows[0]["KindOfDay"]).ToString();
                txtDecription.Text = (dt.Rows[0]["Description"]).ToString();
            }
        }


        private void Clear()
        {
            cmbKindOfDay.SelectedIndex = -1;
            txtDecription.Clear();
            Loadgrid();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                CalendarBAL objBAL = new CalendarBAL();
                CalendarDAL objDAL = new CalendarDAL();
            objBAL.KindOfDay = cmbKindOfDay.Text;
                objBAL.desc = txtDecription.Text;
            objBAL.date = dtpSelectDate.Value;
            objDAL.Update(objBAL);

            Clear();
            Loadgrid();


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadgridByDate();
        }

        private void ucEditCalendar_Load(object sender, EventArgs e)
        {
            Loadgrid();
            cmbKindOfDay.Items.Add("HOLIDAY");
            cmbKindOfDay.Items.Add("BANKDAY");
            cmbKindOfDay.Items.Add("SUNDAY");
            cmbKindOfDay.Items.Add("SATURDAY");







        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            Loadgrid();
        }
    }
    
}
