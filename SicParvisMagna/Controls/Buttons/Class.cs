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
    public partial class Class : UserControl
    {
        bool LinkExpanded = false;
        public Class()
        {
            InitializeComponent();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            FormMain.loadClassform();
        }



        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (LinkExpanded == false)
            {
                this.Height = 300;
                LinkExpanded = true;
            }
            else
            {
                this.Height = 50;
                LinkExpanded = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormMain.loadSectionform();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FormMain.loadSessionform();
        
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            FormMain.loadSubjectform();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
       
            FormMain.loadStudentForm();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            FormMain.loadPromote_Studentform();
        }
    }
}
