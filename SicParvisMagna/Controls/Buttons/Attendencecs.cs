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
    public partial class Attendencecs : UserControl
    {
        bool LinkExpanded = false;
        public Attendencecs()
        {
            InitializeComponent();
        }

        private void btnOrganizarions_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 138;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 47;
                LinkExpanded = false;
            }
        }

        private void btnManualAttendence_Click(object sender, EventArgs e)
        {
            FormMain.loadManualAttendenceForm();
        }

        private void Attendencecs_Load(object sender, EventArgs e)
        {

        }

        private void btnMultipleAttendence_Click(object sender, EventArgs e)
        {
            FormMain.loadMultipleAttendence();
        }
    }
}
