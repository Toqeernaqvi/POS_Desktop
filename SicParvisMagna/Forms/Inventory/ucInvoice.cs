using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SicParvisMagna.Library;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;
using System.Data.SqlClient;
using System.IO;

namespace SicParvisMagna.Forms
{
    public partial class ucInvoice : UserControl
    {
     //   private System.Windows.Forms.Panel container;
        private Guid InvoiceID = Guid.Empty;
        private Guid User_id = Guid.Empty;
        private Guid TaxID = Guid.Empty;
        private Guid InVoiceItemID = Guid.Empty;
        private Guid ProID = Guid.Empty;
        

        public ucInvoice()
        {
            InitializeComponent();
        }

        private void ucInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void gridInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridIVItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            FormMain.loadBackForm();
        //    container.Controls.Clear();
        //    ucInventory form = new ucInventory();
          //  form.Dock = DockStyle.Fill;
           // container.Controls.Add(form);
            // lblFormHeading.Text = "Inventory";

        }
    }
}
