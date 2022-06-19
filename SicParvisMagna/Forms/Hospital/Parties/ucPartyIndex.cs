using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Forms.Hospital.Parties
{
    public partial class ucPartyIndex : UserControl
    {
        private FormMain formMain;
        public ucPartyIndex(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btn_party_Click(object sender, EventArgs e)
        {
            formMain.loadPartyForm();
            //FormMain.loadPartyForm();
        }

        private void btn_partyIV_Click(object sender, EventArgs e)
        {
          //  formMain.loadPartyInvoiceIndexForm();
            //FormMain.loadPartyInvoiceIndexForm();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            formMain.loadIndexBackForm();
            //FormMain.loadIndexBackForm();
        }
    }
}
