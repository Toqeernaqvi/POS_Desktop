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
    public partial class issue_btn : UserControl
    {
        bool LinkExpanded = false;
        public issue_btn()
        {
            InitializeComponent();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 215;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 43;
                LinkExpanded = false;
            }
        }

        private void btnIssues_Click(object sender, EventArgs e)
        {
            FormMain.loadIssueform();
        }

        private void btnIssuelisting_Click(object sender, EventArgs e)
        {
            FormMain.loadIssueListingForm();
        }

        private void btnComments_Click(object sender, EventArgs e)
        {

        }
    }
}
