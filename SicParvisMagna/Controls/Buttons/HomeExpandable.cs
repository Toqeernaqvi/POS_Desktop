using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Controls.Buttons
{
    public partial class HomeExpandable : UserControl
    {
        bool LinkExpanded = false;
        public HomeExpandable()
        {
            InitializeComponent();
        }

        private void btnOpenHome_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 189;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 47;
                LinkExpanded = false;
            }
        }

        private void HomeExpandable_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormMain.loadChangePasswordForm();

        }

        private void btnManagePassword_Click(object sender, EventArgs e)
        {
            FormMain.loadPermissionForm();
        }

        private void btnDomainType_Click(object sender, EventArgs e)
        {
            FormMain.loadDomainTypes();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            FormMain.loadAccounts();
        }
    }
}
