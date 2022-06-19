using MyProg;
using SicParvisMagna.Forms;
using SicParvisMagna.Setting_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace SicParvisMagna
{
    public partial class FormSetting : Form
    {
        public static Panel formContainer;
      
        public FormSetting()
        {
            InitializeComponent();
            formContainer = this.container;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccountTypes_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucAddAccounts form = new ucAddAccounts();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void btnAddDomainTypes_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucAddDomain form = new ucAddDomain();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

            formContainer.Controls.Clear();

            panelCredentials.Visible = false;
            panelGeneral.Visible = false;
            panelBackup.Visible = true;
            panelBackup.Location = new Point(0,0);

            panelBackup.Dock = DockStyle.Left;
            formContainer.Controls.Add(panelBackup);
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
           
            panelCredentials.Visible = false;
            panelBackup.Visible = false;
            panelGeneral.Visible = false;
            pnlSetting.Visible = false;
            btnCedential.Visible = false;
            btnEditCalender.Visible = false;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();

            pnlSetting.Dock = DockStyle.Left;
            panelGeneral.Visible = false;
            panelBackup.Visible = false;
            panelCredentials.Visible = false;
            pnlSetting.Location = new Point(0, 0);
            pnlSetting.Visible = true;
            formContainer.Controls.Add(pnlSetting);
        }

        

        private void btnEditCalender_Click_1(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucEditCalendar form = new ucEditCalendar();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void btnGenerateBakup_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucBackup form = new ucBackup();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
          
            panelGeneral.Dock = DockStyle.Left;
            panelCredentials.Visible = false;
            panelBackup.Visible = false;
            panelGeneral.Visible = true;
            panelGeneral.Location = new Point(0,0);
            formContainer.Controls.Add(panelGeneral);




        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();

            panelCredentials.Dock = DockStyle.Left;
             panelGeneral.Visible = false;
            panelBackup.Visible = false;
            panelCredentials.Location = new Point(0, 0);
            panelCredentials.Visible = true;
            formContainer.Controls.Add(panelCredentials);
        }

        private void btnCredentials_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucAddCredntials form = new ucAddCredntials();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //1024, 768
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Size = new Size(1024, 728);
            }

            else
            {
                System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
                this.MaximizedBounds = Screen.GetWorkingArea(this);
                this.WindowState = FormWindowState.Maximized;
                //WindowState = FormWindowState.Maximized;
            }
        }

        
        private void panelBackup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerateBackup_Click_1(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucBackup form = new ucBackup();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void btnAddDomainTypes_Click_1(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucDomainTypes form = new ucDomainTypes();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void btnCredentials_Click_1(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucAddCredntials form = new ucAddCredntials();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }

        private void btnManagePermissions_Click(object sender, EventArgs e)
        {
            formContainer.Controls.Clear();
            ucAddPermission form = new ucAddPermission();
            form.Dock = DockStyle.Fill;

            formContainer.Controls.Add(form);
        }
    }
}
