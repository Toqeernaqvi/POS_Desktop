using SicParvisMagna.Controls.Buttons;

namespace SicParvisMagna
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         
         

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation5 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            AnimatorNS.Animation animation6 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.animLogo = new AnimatorNS.Animator(this.components);
            this.container = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelTopRight = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblFormHeading = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHeaderProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHeaderLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelSidebarParent = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelSidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.flowSidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddCredentials = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.attendencecs1 = new SicParvisMagna.Controls.Buttons.Attendencecs();
            this.inventory1 = new SicParvisMagna.Controls.Buttons.Inventory();
            this.issue_btn1 = new SicParvisMagna.Controls.Buttons.issue_btn();
            this.class1 = new SicParvisMagna.Controls.Buttons.Class();
            this.btnChartOfAccounts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployeeSalry = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teachers1 = new SicParvisMagna.Controls.Buttons.Teachers();
            this.btnSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.employeeReports1 = new SicParvisMagna.Controls.Buttons.EmployeeReports();
            this.btnSidebarToggle = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Supplier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployeeSalary = new Bunifu.Framework.UI.BunifuFlatButton();
            this.employeeReports = new SicParvisMagna.Controls.Buttons.EmployeeReports();
            this.animSideBar = new AnimatorNS.Animator(this.components);
            this.bunifuDragHeaderTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animPanelTopRight = new AnimatorNS.Animator(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTopRight.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panelSidebarParent.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.flowSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebarToggle)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 0;
            this.bunifuElipse.TargetControl = this;
            // 
            // animLogo
            // 
            this.animLogo.AnimationType = AnimatorNS.AnimationType.Leaf;
            this.animLogo.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.animLogo.DefaultAnimation = animation5;
            this.animLogo.Interval = 3;
            this.animLogo.MaxAnimationTime = 750;
            this.animLogo.TimeStep = 0.03F;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.animLogo.SetDecoration(this.container, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.container, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.container, AnimatorNS.DecorationType.None);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(270, 40);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(754, 688);
            this.container.TabIndex = 4;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton3.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Edit Calendar";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animLogo.SetDecoration(this.bunifuFlatButton3, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.bunifuFlatButton3, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.bunifuFlatButton3, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 55D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(4, 435);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(256, 47);
            this.bunifuFlatButton3.TabIndex = 44;
            this.bunifuFlatButton3.Text = "Edit Calendar";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            // 
            // panelTopRight
            // 
            this.panelTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.panelTopRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopRight.BackgroundImage")));
            this.panelTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTopRight.Controls.Add(this.lblFormHeading);
            this.panelTopRight.Controls.Add(this.panelControl);
            this.animLogo.SetDecoration(this.panelTopRight, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.panelTopRight, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.panelTopRight, AnimatorNS.DecorationType.None);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopRight.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.panelTopRight.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.panelTopRight.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.panelTopRight.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.panelTopRight.Location = new System.Drawing.Point(270, 0);
            this.panelTopRight.MaximumSize = new System.Drawing.Size(0, 40);
            this.panelTopRight.MinimumSize = new System.Drawing.Size(0, 40);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Quality = 10;
            this.panelTopRight.Size = new System.Drawing.Size(754, 40);
            this.panelTopRight.TabIndex = 5;
            // 
            // lblFormHeading
            // 
            this.lblFormHeading.AutoSize = true;
            this.lblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.animPanelTopRight.SetDecoration(this.lblFormHeading, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.lblFormHeading, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.lblFormHeading, AnimatorNS.DecorationType.None);
            this.lblFormHeading.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFormHeading.Location = new System.Drawing.Point(18, 9);
            this.lblFormHeading.Name = "lblFormHeading";
            this.lblFormHeading.Size = new System.Drawing.Size(113, 22);
            this.lblFormHeading.TabIndex = 5;
            this.lblFormHeading.Text = "Dashboard";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Controls.Add(this.bunifuImageButton1);
            this.panelControl.Controls.Add(this.panel2);
            this.panelControl.Controls.Add(this.btnExit);
            this.panelControl.Controls.Add(this.btnMinimize);
            this.animLogo.SetDecoration(this.panelControl, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.panelControl, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.panelControl, AnimatorNS.DecorationType.None);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(155, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(599, 40);
            this.panelControl.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnHeaderProfile);
            this.panel1.Controls.Add(this.lblMainHeader);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animLogo.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(104, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 40);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHeaderProfile
            // 
            this.btnHeaderProfile.Active = false;
            this.btnHeaderProfile.Activecolor = System.Drawing.Color.Transparent;
            this.btnHeaderProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderProfile.BorderRadius = 0;
            this.btnHeaderProfile.ButtonText = "";
            this.btnHeaderProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animLogo.SetDecoration(this.btnHeaderProfile, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.btnHeaderProfile, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnHeaderProfile, AnimatorNS.DecorationType.None);
            this.btnHeaderProfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnHeaderProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHeaderProfile.Iconimage = global::SicParvisMagna.Properties.Resources.icons8_user_24;
            this.btnHeaderProfile.Iconimage_right = null;
            this.btnHeaderProfile.Iconimage_right_Selected = null;
            this.btnHeaderProfile.Iconimage_Selected = null;
            this.btnHeaderProfile.IconMarginLeft = 0;
            this.btnHeaderProfile.IconMarginRight = 0;
            this.btnHeaderProfile.IconRightVisible = true;
            this.btnHeaderProfile.IconRightZoom = 0D;
            this.btnHeaderProfile.IconVisible = true;
            this.btnHeaderProfile.IconZoom = 50D;
            this.btnHeaderProfile.IsTab = false;
            this.btnHeaderProfile.Location = new System.Drawing.Point(4, 4);
            this.btnHeaderProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeaderProfile.Name = "btnHeaderProfile";
            this.btnHeaderProfile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderProfile.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderProfile.selected = false;
            this.btnHeaderProfile.Size = new System.Drawing.Size(33, 34);
            this.btnHeaderProfile.TabIndex = 4;
            this.btnHeaderProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHeaderProfile.Textcolor = System.Drawing.Color.White;
            this.btnHeaderProfile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeaderProfile.Click += new System.EventHandler(this.btnHeaderProfile_Click_1);
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblMainHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.lblMainHeader, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.lblMainHeader, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.lblMainHeader, AnimatorNS.DecorationType.None);
            this.lblMainHeader.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMainHeader.Location = new System.Drawing.Point(40, 9);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(113, 22);
            this.lblMainHeader.TabIndex = 4;
            this.lblMainHeader.Text = "Dashboard";
            this.lblMainHeader.Click += new System.EventHandler(this.lblMainHeader_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.animLogo.SetDecoration(this.bunifuImageButton1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.bunifuImageButton1, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.bunifuImageButton1, AnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::SicParvisMagna.Properties.Resources.round_maximize_white_18dp;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(514, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnHeaderLogout);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animLogo.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(354, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 40);
            this.panel2.TabIndex = 7;
            // 
            // btnHeaderLogout
            // 
            this.btnHeaderLogout.Active = false;
            this.btnHeaderLogout.Activecolor = System.Drawing.Color.Transparent;
            this.btnHeaderLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeaderLogout.BorderRadius = 0;
            this.btnHeaderLogout.ButtonText = "Logout";
            this.btnHeaderLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animLogo.SetDecoration(this.btnHeaderLogout, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.btnHeaderLogout, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnHeaderLogout, AnimatorNS.DecorationType.None);
            this.btnHeaderLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnHeaderLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHeaderLogout.Iconimage = global::SicParvisMagna.Properties.Resources.icons8_exit_24;
            this.btnHeaderLogout.Iconimage_right = null;
            this.btnHeaderLogout.Iconimage_right_Selected = null;
            this.btnHeaderLogout.Iconimage_Selected = null;
            this.btnHeaderLogout.IconMarginLeft = 0;
            this.btnHeaderLogout.IconMarginRight = 0;
            this.btnHeaderLogout.IconRightVisible = true;
            this.btnHeaderLogout.IconRightZoom = 0D;
            this.btnHeaderLogout.IconVisible = true;
            this.btnHeaderLogout.IconZoom = 50D;
            this.btnHeaderLogout.IsTab = false;
            this.btnHeaderLogout.Location = new System.Drawing.Point(0, 4);
            this.btnHeaderLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeaderLogout.Name = "btnHeaderLogout";
            this.btnHeaderLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.btnHeaderLogout.OnHovercolor = System.Drawing.Color.Gray;
            this.btnHeaderLogout.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnHeaderLogout.selected = false;
            this.btnHeaderLogout.Size = new System.Drawing.Size(108, 34);
            this.btnHeaderLogout.TabIndex = 5;
            this.btnHeaderLogout.Text = "Logout";
            this.btnHeaderLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHeaderLogout.Textcolor = System.Drawing.Color.White;
            this.btnHeaderLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeaderLogout.Click += new System.EventHandler(this.btnHeaderLogout_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.animLogo.SetDecoration(this.btnExit, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnExit, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.btnExit, AnimatorNS.DecorationType.None);
            this.btnExit.Image = global::SicParvisMagna.Properties.Resources.icons8_multiply_24;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(561, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_2);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.animLogo.SetDecoration(this.btnMinimize, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnMinimize, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.btnMinimize, AnimatorNS.DecorationType.None);
            this.btnMinimize.Image = global::SicParvisMagna.Properties.Resources.round_minimize_white_18dp;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(469, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_2);
            // 
            // panelSidebarParent
            // 
            this.panelSidebarParent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSidebarParent.BackgroundImage")));
            this.panelSidebarParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSidebarParent.Controls.Add(this.panelSidebar);
            this.animLogo.SetDecoration(this.panelSidebarParent, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.panelSidebarParent, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.panelSidebarParent, AnimatorNS.DecorationType.None);
            this.panelSidebarParent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebarParent.GradientBottomLeft = System.Drawing.Color.Olive;
            this.panelSidebarParent.GradientBottomRight = System.Drawing.Color.DarkGoldenrod;
            this.panelSidebarParent.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSidebarParent.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(37)))));
            this.panelSidebarParent.Location = new System.Drawing.Point(0, 0);
            this.panelSidebarParent.MaximumSize = new System.Drawing.Size(270, 0);
            this.panelSidebarParent.MinimumSize = new System.Drawing.Size(50, 0);
            this.panelSidebarParent.Name = "panelSidebarParent";
            this.panelSidebarParent.Quality = 10;
            this.panelSidebarParent.Size = new System.Drawing.Size(270, 728);
            this.panelSidebarParent.TabIndex = 0;
            this.panelSidebarParent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSidebar.BackgroundImage")));
            this.panelSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSidebar.Controls.Add(this.flowSidePanel);
            this.panelSidebar.Controls.Add(this.btnSidebarToggle);
            this.animLogo.SetDecoration(this.panelSidebar, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.panelSidebar, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.panelSidebar, AnimatorNS.DecorationType.None);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.panelSidebar.GradientBottomRight = System.Drawing.Color.Red;
            this.panelSidebar.GradientTopLeft = System.Drawing.Color.Yellow;
            this.panelSidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(73)))));
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.MaximumSize = new System.Drawing.Size(260, 0);
            this.panelSidebar.MinimumSize = new System.Drawing.Size(50, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Quality = 10;
            this.panelSidebar.Size = new System.Drawing.Size(260, 728);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // flowSidePanel
            // 
            this.flowSidePanel.AutoScroll = true;
            this.flowSidePanel.BackColor = System.Drawing.Color.Transparent;
            this.flowSidePanel.Controls.Add(this.bunifuFlatButton1);
            this.flowSidePanel.Controls.Add(this.btnEmployee);
            this.flowSidePanel.Controls.Add(this.btnEmployeeSalry);
            this.flowSidePanel.Controls.Add(this.btnSetting);
            this.flowSidePanel.Controls.Add(this.btnAddCredentials);
            this.flowSidePanel.Controls.Add(this.bunifuFlatButton2);
            this.flowSidePanel.Controls.Add(this.attendencecs1);
            this.flowSidePanel.Controls.Add(this.inventory1);
            this.flowSidePanel.Controls.Add(this.issue_btn1);
            this.flowSidePanel.Controls.Add(this.class1);
            this.flowSidePanel.Controls.Add(this.btnChartOfAccounts);
            this.flowSidePanel.Controls.Add(this.bunifuFlatButton4);
            this.flowSidePanel.Controls.Add(this.teachers1);
            this.flowSidePanel.Controls.Add(this.employeeReports1);
            this.animPanelTopRight.SetDecoration(this.flowSidePanel, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.flowSidePanel, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.flowSidePanel, AnimatorNS.DecorationType.None);
            this.flowSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowSidePanel.Location = new System.Drawing.Point(0, 34);
            this.flowSidePanel.Name = "flowSidePanel";
            this.flowSidePanel.Size = new System.Drawing.Size(260, 694);
            this.flowSidePanel.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Users";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.bunifuFlatButton1, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.bunifuFlatButton1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.bunifuFlatButton1, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 100D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(4, 4);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(252, 47);
            this.bunifuFlatButton1.TabIndex = 18;
            this.bunifuFlatButton1.Text = "Users";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // btnAddCredentials
            // 
            this.btnAddCredentials.Active = false;
            this.btnAddCredentials.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnAddCredentials.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnAddCredentials.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCredentials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCredentials.BorderRadius = 0;
            this.btnAddCredentials.ButtonText = "Add Credentials";
            this.btnAddCredentials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.btnAddCredentials, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.btnAddCredentials, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnAddCredentials, AnimatorNS.DecorationType.None);
            this.btnAddCredentials.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCredentials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCredentials.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCredentials.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCredentials.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCredentials.Iconimage")));
            this.btnAddCredentials.Iconimage_right = null;
            this.btnAddCredentials.Iconimage_right_Selected = null;
            this.btnAddCredentials.Iconimage_Selected = null;
            this.btnAddCredentials.IconMarginLeft = 0;
            this.btnAddCredentials.IconMarginRight = 0;
            this.btnAddCredentials.IconRightVisible = true;
            this.btnAddCredentials.IconRightZoom = 0D;
            this.btnAddCredentials.IconVisible = true;
            this.btnAddCredentials.IconZoom = 100D;
            this.btnAddCredentials.IsTab = true;
            this.btnAddCredentials.Location = new System.Drawing.Point(1, 215);
            this.btnAddCredentials.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddCredentials.Name = "btnAddCredentials";
            this.btnAddCredentials.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddCredentials.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnAddCredentials.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.btnAddCredentials.selected = false;
            this.btnAddCredentials.Size = new System.Drawing.Size(252, 47);
            this.btnAddCredentials.TabIndex = 30;
            this.btnAddCredentials.Text = "Add Credentials";
            this.btnAddCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCredentials.Textcolor = System.Drawing.Color.Transparent;
            this.btnAddCredentials.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCredentials.Click += new System.EventHandler(this.btnAddCredentials_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Labels";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.bunifuFlatButton2, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.bunifuFlatButton2, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.bunifuFlatButton2, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(4, 267);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(252, 47);
            this.bunifuFlatButton2.TabIndex = 38;
            this.bunifuFlatButton2.Text = "Labels";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_2);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Active = false;
            this.btnEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnEmployee.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.BorderRadius = 0;
            this.btnEmployee.ButtonText = "Employees";
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.btnEmployee, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.btnEmployee, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnEmployee, AnimatorNS.DecorationType.None);
            this.btnEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Iconimage")));
            this.btnEmployee.Iconimage_right = null;
            this.btnEmployee.Iconimage_right_Selected = null;
            this.btnEmployee.Iconimage_Selected = null;
            this.btnEmployee.IconMarginLeft = 0;
            this.btnEmployee.IconMarginRight = 0;
            this.btnEmployee.IconRightVisible = true;
            this.btnEmployee.IconRightZoom = 0D;
            this.btnEmployee.IconVisible = true;
            this.btnEmployee.IconZoom = 100D;
            this.btnEmployee.IsTab = true;
            this.btnEmployee.Location = new System.Drawing.Point(4, 59);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnEmployee.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.btnEmployee.selected = false;
            this.btnEmployee.Size = new System.Drawing.Size(252, 47);
            this.btnEmployee.TabIndex = 39;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmployee.Textcolor = System.Drawing.Color.Transparent;
            this.btnEmployee.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // attendencecs1
            // 
            this.attendencecs1.BackColor = System.Drawing.Color.Transparent;
            this.animPanelTopRight.SetDecoration(this.attendencecs1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.attendencecs1, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.attendencecs1, AnimatorNS.DecorationType.None);
            this.attendencecs1.Location = new System.Drawing.Point(3, 321);
            this.attendencecs1.Name = "attendencecs1";
            this.attendencecs1.Size = new System.Drawing.Size(252, 47);
            this.attendencecs1.TabIndex = 40;
            // 
            // inventory1
            // 
            this.inventory1.BackColor = System.Drawing.Color.Transparent;
            this.animPanelTopRight.SetDecoration(this.inventory1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.inventory1, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.inventory1, AnimatorNS.DecorationType.None);
            this.inventory1.Location = new System.Drawing.Point(3, 374);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(251, 54);
            this.inventory1.TabIndex = 42;
            // 
            // issue_btn1
            // 
            this.issue_btn1.BackColor = System.Drawing.Color.Transparent;
            this.animPanelTopRight.SetDecoration(this.issue_btn1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.issue_btn1, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.issue_btn1, AnimatorNS.DecorationType.None);
            this.issue_btn1.Location = new System.Drawing.Point(3, 434);
            this.issue_btn1.Name = "issue_btn1";
            this.issue_btn1.Size = new System.Drawing.Size(251, 55);
            this.issue_btn1.TabIndex = 41;
            // 
            // class1
            // 
            this.class1.BackColor = System.Drawing.Color.Transparent;
            this.animPanelTopRight.SetDecoration(this.class1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.class1, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.class1, AnimatorNS.DecorationType.None);
            this.class1.Location = new System.Drawing.Point(4, 497);
            this.class1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(254, 51);
            this.class1.TabIndex = 0;
            // 
            // btnChartOfAccounts
            // 
            this.btnChartOfAccounts.Active = false;
            this.btnChartOfAccounts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnChartOfAccounts.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnChartOfAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnChartOfAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChartOfAccounts.BorderRadius = 0;
            this.btnChartOfAccounts.ButtonText = "Chart of Accounts";
            this.btnChartOfAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.btnChartOfAccounts, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.btnChartOfAccounts, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnChartOfAccounts, AnimatorNS.DecorationType.None);
            this.btnChartOfAccounts.DisabledColor = System.Drawing.Color.Gray;
            this.btnChartOfAccounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChartOfAccounts.ForeColor = System.Drawing.Color.Transparent;
            this.btnChartOfAccounts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChartOfAccounts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChartOfAccounts.Iconimage")));
            this.btnChartOfAccounts.Iconimage_right = null;
            this.btnChartOfAccounts.Iconimage_right_Selected = null;
            this.btnChartOfAccounts.Iconimage_Selected = null;
            this.btnChartOfAccounts.IconMarginLeft = 0;
            this.btnChartOfAccounts.IconMarginRight = 0;
            this.btnChartOfAccounts.IconRightVisible = true;
            this.btnChartOfAccounts.IconRightZoom = 0D;
            this.btnChartOfAccounts.IconVisible = true;
            this.btnChartOfAccounts.IconZoom = 100D;
            this.btnChartOfAccounts.IsTab = true;
            this.btnChartOfAccounts.Location = new System.Drawing.Point(4, 557);
            this.btnChartOfAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.btnChartOfAccounts.Name = "btnChartOfAccounts";
            this.btnChartOfAccounts.Normalcolor = System.Drawing.Color.Transparent;
            this.btnChartOfAccounts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnChartOfAccounts.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.btnChartOfAccounts.selected = false;
            this.btnChartOfAccounts.Size = new System.Drawing.Size(252, 47);
            this.btnChartOfAccounts.TabIndex = 43;
            this.btnChartOfAccounts.Text = "Chart of Accounts";
            this.btnChartOfAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChartOfAccounts.Textcolor = System.Drawing.Color.Transparent;
            this.btnChartOfAccounts.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChartOfAccounts.Click += new System.EventHandler(this.btnChartOfAccounts_Click);
            // 
            // btnEmployeeSalry
            // 
            this.btnEmployeeSalry.Active = false;
            this.btnEmployeeSalry.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnEmployeeSalry.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnEmployeeSalry.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeSalry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeSalry.BorderRadius = 0;
            this.btnEmployeeSalry.ButtonText = "Employee Salary";
            this.btnEmployeeSalry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.btnEmployeeSalry, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.btnEmployeeSalry, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnEmployeeSalry, AnimatorNS.DecorationType.None);
            this.btnEmployeeSalry.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployeeSalry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSalry.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmployeeSalry.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployeeSalry.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeSalry.Iconimage")));
            this.btnEmployeeSalry.Iconimage_right = null;
            this.btnEmployeeSalry.Iconimage_right_Selected = null;
            this.btnEmployeeSalry.Iconimage_Selected = null;
            this.btnEmployeeSalry.IconMarginLeft = 0;
            this.btnEmployeeSalry.IconMarginRight = 0;
            this.btnEmployeeSalry.IconRightVisible = true;
            this.btnEmployeeSalry.IconRightZoom = 0D;
            this.btnEmployeeSalry.IconVisible = true;
            this.btnEmployeeSalry.IconZoom = 100D;
            this.btnEmployeeSalry.IsTab = true;
            this.btnEmployeeSalry.Location = new System.Drawing.Point(1, 111);
            this.btnEmployeeSalry.Margin = new System.Windows.Forms.Padding(1);
            this.btnEmployeeSalry.Name = "btnEmployeeSalry";
            this.btnEmployeeSalry.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmployeeSalry.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnEmployeeSalry.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.btnEmployeeSalry.selected = false;
            this.btnEmployeeSalry.Size = new System.Drawing.Size(252, 47);
            this.btnEmployeeSalry.TabIndex = 44;
            this.btnEmployeeSalry.Text = "Employee Salary";
            this.btnEmployeeSalry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmployeeSalry.Textcolor = System.Drawing.Color.Transparent;
            this.btnEmployeeSalry.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeSalry.Click += new System.EventHandler(this.btnEmployeeSalry_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Active = false;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton4.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Add Student";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.bunifuFlatButton4, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.bunifuFlatButton4, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.bunifuFlatButton4, AnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton4.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Turquoise;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 100D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(1, 609);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(1);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(252, 47);
            this.bunifuFlatButton4.TabIndex = 45;
            this.bunifuFlatButton4.Text = "Add Student";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click_5);
            // 
            // teachers1
            // 
            this.teachers1.BackColor = System.Drawing.Color.Transparent;
            this.animPanelTopRight.SetDecoration(this.teachers1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.teachers1, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.teachers1, AnimatorNS.DecorationType.None);
            this.teachers1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teachers1.Location = new System.Drawing.Point(3, 660);
            this.teachers1.Name = "teachers1";
            this.teachers1.Size = new System.Drawing.Size(254, 45);
            this.teachers1.TabIndex = 41;
            this.teachers1.Load += new System.EventHandler(this.teachers1_Load);
            // 
            // btnSetting
            // 
            this.btnSetting.Active = false;
            this.btnSetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnSetting.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.BorderRadius = 0;
            this.btnSetting.ButtonText = "Setting";
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animPanelTopRight.SetDecoration(this.btnSetting, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.btnSetting, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnSetting, AnimatorNS.DecorationType.None);
            this.btnSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSetting.Iconimage")));
            this.btnSetting.Iconimage_right = null;
            this.btnSetting.Iconimage_right_Selected = null;
            this.btnSetting.Iconimage_Selected = null;
            this.btnSetting.IconMarginLeft = 0;
            this.btnSetting.IconMarginRight = 0;
            this.btnSetting.IconRightVisible = true;
            this.btnSetting.IconRightZoom = 0D;
            this.btnSetting.IconVisible = true;
            this.btnSetting.IconZoom = 100D;
            this.btnSetting.IsTab = true;
            this.btnSetting.Location = new System.Drawing.Point(4, 163);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(161)))), ((int)(((byte)(52)))));
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.btnSetting.selected = false;
            this.btnSetting.Size = new System.Drawing.Size(252, 47);
            this.btnSetting.TabIndex = 46;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetting.Textcolor = System.Drawing.Color.Transparent;
            this.btnSetting.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click_1);
            // 
            // employeeReports1
            // 
            this.employeeReports1.BackColor = System.Drawing.Color.Transparent;
            this.animPanelTopRight.SetDecoration(this.employeeReports1, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.employeeReports1, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.employeeReports1, AnimatorNS.DecorationType.None);
            this.employeeReports1.Location = new System.Drawing.Point(3, 711);
            this.employeeReports1.Name = "employeeReports1";
            this.employeeReports1.Size = new System.Drawing.Size(251, 51);
            this.employeeReports1.TabIndex = 47;
            // 
            // btnSidebarToggle
            // 
            this.btnSidebarToggle.BackColor = System.Drawing.Color.Transparent;
            this.animLogo.SetDecoration(this.btnSidebarToggle, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnSidebarToggle, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.btnSidebarToggle, AnimatorNS.DecorationType.None);
            this.btnSidebarToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSidebarToggle.Image = global::SicParvisMagna.Properties.Resources.menu;
            this.btnSidebarToggle.ImageActive = null;
            this.btnSidebarToggle.Location = new System.Drawing.Point(0, 0);
            this.btnSidebarToggle.Name = "btnSidebarToggle";
            this.btnSidebarToggle.Size = new System.Drawing.Size(260, 34);
            this.btnSidebarToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSidebarToggle.TabIndex = 0;
            this.btnSidebarToggle.TabStop = false;
            this.btnSidebarToggle.Zoom = 10;
            this.btnSidebarToggle.Click += new System.EventHandler(this.SidebarToggle_Click);
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.Active = false;
            this.btn_Supplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Supplier.BorderRadius = 0;
            this.btn_Supplier.ButtonText = "     Bunifu Flat Button";
            this.btn_Supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animLogo.SetDecoration(this.btn_Supplier, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.btn_Supplier, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btn_Supplier, AnimatorNS.DecorationType.None);
            this.btn_Supplier.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Supplier.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Supplier.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Supplier.Iconimage")));
            this.btn_Supplier.Iconimage_right = null;
            this.btn_Supplier.Iconimage_right_Selected = null;
            this.btn_Supplier.Iconimage_Selected = null;
            this.btn_Supplier.IconMarginLeft = 0;
            this.btn_Supplier.IconMarginRight = 0;
            this.btn_Supplier.IconRightVisible = true;
            this.btn_Supplier.IconRightZoom = 0D;
            this.btn_Supplier.IconVisible = true;
            this.btn_Supplier.IconZoom = 90D;
            this.btn_Supplier.IsTab = false;
            this.btn_Supplier.Location = new System.Drawing.Point(0, 0);
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Supplier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Supplier.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Supplier.selected = false;
            this.btn_Supplier.Size = new System.Drawing.Size(241, 48);
            this.btn_Supplier.TabIndex = 0;
            this.btn_Supplier.Text = "     Bunifu Flat Button";
            this.btn_Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Supplier.Textcolor = System.Drawing.Color.White;
            this.btn_Supplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEmployeeSalary
            // 
            this.btnEmployeeSalary.Active = false;
            this.btnEmployeeSalary.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmployeeSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmployeeSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployeeSalary.BorderRadius = 0;
            this.btnEmployeeSalary.ButtonText = "     Bunifu Flat Button";
            this.btnEmployeeSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animLogo.SetDecoration(this.btnEmployeeSalary, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this.btnEmployeeSalary, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.btnEmployeeSalary, AnimatorNS.DecorationType.None);
            this.btnEmployeeSalary.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployeeSalary.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployeeSalary.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeSalary.Iconimage")));
            this.btnEmployeeSalary.Iconimage_right = null;
            this.btnEmployeeSalary.Iconimage_right_Selected = null;
            this.btnEmployeeSalary.Iconimage_Selected = null;
            this.btnEmployeeSalary.IconMarginLeft = 0;
            this.btnEmployeeSalary.IconMarginRight = 0;
            this.btnEmployeeSalary.IconRightVisible = true;
            this.btnEmployeeSalary.IconRightZoom = 0D;
            this.btnEmployeeSalary.IconVisible = true;
            this.btnEmployeeSalary.IconZoom = 90D;
            this.btnEmployeeSalary.IsTab = false;
            this.btnEmployeeSalary.Location = new System.Drawing.Point(0, 0);
            this.btnEmployeeSalary.Name = "btnEmployeeSalary";
            this.btnEmployeeSalary.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmployeeSalary.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEmployeeSalary.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployeeSalary.selected = false;
            this.btnEmployeeSalary.Size = new System.Drawing.Size(241, 48);
            this.btnEmployeeSalary.TabIndex = 0;
            this.btnEmployeeSalary.Text = "     Bunifu Flat Button";
            this.btnEmployeeSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeSalary.Textcolor = System.Drawing.Color.White;
            this.btnEmployeeSalary.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // employeeReports
            // 
            this.employeeReports.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animPanelTopRight.SetDecoration(this.employeeReports, AnimatorNS.DecorationType.None);
            this.animSideBar.SetDecoration(this.employeeReports, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this.employeeReports, AnimatorNS.DecorationType.None);
            this.employeeReports.Location = new System.Drawing.Point(0, 0);
            this.employeeReports.Name = "employeeReports";
            this.employeeReports.Size = new System.Drawing.Size(251, 145);
            this.employeeReports.TabIndex = 0;
            // 
            // animSideBar
            // 
            this.animSideBar.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            this.animSideBar.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.animSideBar.DefaultAnimation = animation6;
            // 
            // bunifuDragHeaderTop
            // 
            this.bunifuDragHeaderTop.Fixed = true;
            this.bunifuDragHeaderTop.Horizontal = true;
            this.bunifuDragHeaderTop.TargetControl = this.panelTopRight;
            this.bunifuDragHeaderTop.Vertical = true;
            // 
            // animPanelTopRight
            // 
            this.animPanelTopRight.AnimationType = AnimatorNS.AnimationType.VertBlind;
            this.animPanelTopRight.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animPanelTopRight.DefaultAnimation = animation4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTopRight;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1024, 728);
            this.ControlBox = false;
            this.Controls.Add(this.container);
            this.Controls.Add(this.panelTopRight);
            this.Controls.Add(this.panelSidebarParent);
            this.animSideBar.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.animLogo.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.animPanelTopRight.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panelSidebarParent.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.flowSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSidebarToggle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel panelSidebar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuImageButton btnSidebarToggle;
        private AnimatorNS.Animator animLogo;
        private AnimatorNS.Animator animSideBar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragHeaderTop;
        private System.Windows.Forms.Panel container;
        private AnimatorNS.Animator animPanelTopRight;
        private Bunifu.Framework.UI.BunifuGradientPanel panelTopRight;
        private System.Windows.Forms.Label lblFormHeading;
        private SicParvisMagna.Controls.Buttons.issue_btn issue_btn1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnHeaderLogout;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHeaderProfile;
        private System.Windows.Forms.Label lblMainHeader;
        private System.Windows.Forms.Panel panelControl;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuGradientPanel panelSidebarParent;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.FlowLayoutPanel flowSidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Controls.Buttons.Location location1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCredentials;

        private Controls.Buttons.ManageOrganizations btnOrganization;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
         private Controls.Buttons.ManageOrganizations manageOrganizations1;

        private Controls.Buttons.EmployeeReports employeeReports;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployeeSalary;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Supplier;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployee;
        private Controls.Buttons.Attendencecs attendencecs1;
        private Controls.Buttons.Hospital hospital1;
        private Controls.Buttons.Inventory inventory1;
        private Controls.Buttons.Teachers teachers1;
        private Controls.Buttons.Marksheet marksheet1;
        private Controls.Buttons.Test test1;
        
        private Bunifu.Framework.UI.BunifuFlatButton btnChartOfAccounts;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployeeSalry;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetting;
        private Controls.Buttons.Class class1;
        private EmployeeReports employeeReports1;
        private Location location2;
        private ManageOrganizations manageOrganizations2;
        private Location location3;
    }
}

