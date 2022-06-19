namespace SicParvisMagna.Forms.PointOfSale
{
	partial class ucProductParty
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProductParty));
            this.gridParty = new System.Windows.Forms.DataGridView();
            this.txt_goods_and_service_tax = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_National_Tax_Number = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbOrganizationBranch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlcmbBranch = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lblSectionTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblErrorAdress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblErrorPhone = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblErrorEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_shortName = new System.Windows.Forms.TextBox();
            this.txt_iban = new System.Windows.Forms.TextBox();
            this.lblSectionCode = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_IBAN = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Bank_account_number = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Bank_account_number = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblError_Address = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Standard_Report_Number = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Standard_Report_Number = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_Gurranty = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Gurranty = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Goods_And_Services_Tax = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_National_Tax_Number = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_add = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Description = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridParty)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panelToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridParty
            // 
            this.gridParty.AllowUserToAddRows = false;
            this.gridParty.AllowUserToDeleteRows = false;
            this.gridParty.AllowUserToOrderColumns = true;
            this.gridParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridParty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridParty.Location = new System.Drawing.Point(0, 502);
            this.gridParty.Name = "gridParty";
            this.gridParty.Size = new System.Drawing.Size(712, 196);
            this.gridParty.TabIndex = 28;
            this.gridParty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridParty_CellClick);
            // 
            // txt_goods_and_service_tax
            // 
            this.txt_goods_and_service_tax.Location = new System.Drawing.Point(306, 572);
            this.txt_goods_and_service_tax.MaxLength = 20;
            this.txt_goods_and_service_tax.Name = "txt_goods_and_service_tax";
            this.txt_goods_and_service_tax.Size = new System.Drawing.Size(202, 20);
            this.txt_goods_and_service_tax.TabIndex = 33;
            this.txt_goods_and_service_tax.Visible = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(124, 572);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(163, 17);
            this.bunifuCustomLabel4.TabIndex = 31;
            this.bunifuCustomLabel4.Text = "Goods and Services Tax";
            this.bunifuCustomLabel4.Visible = false;
            // 
            // txt_National_Tax_Number
            // 
            this.txt_National_Tax_Number.Location = new System.Drawing.Point(306, 546);
            this.txt_National_Tax_Number.MaxLength = 20;
            this.txt_National_Tax_Number.Name = "txt_National_Tax_Number";
            this.txt_National_Tax_Number.Size = new System.Drawing.Size(202, 20);
            this.txt_National_Tax_Number.TabIndex = 30;
            this.txt_National_Tax_Number.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(146, 546);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(141, 17);
            this.bunifuCustomLabel2.TabIndex = 28;
            this.bunifuCustomLabel2.Text = "National Tax Number";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(306, 520);
            this.txt_add.MaxLength = 20;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(202, 20);
            this.txt_add.TabIndex = 27;
            this.txt_add.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(254, 520);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(33, 17);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Add";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.panel1);
            this.flowLayoutPanel.Controls.Add(this.pnlcmbBranch);
            this.flowLayoutPanel.Controls.Add(this.panel10);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 115);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(712, 387);
            this.flowLayoutPanel.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbOrganizationBranch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbOrganization);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 81);
            this.panel1.TabIndex = 55;
            // 
            // cmbOrganizationBranch
            // 
            this.cmbOrganizationBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganizationBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbOrganizationBranch.FormattingEnabled = true;
            this.cmbOrganizationBranch.Location = new System.Drawing.Point(125, 48);
            this.cmbOrganizationBranch.Name = "cmbOrganizationBranch";
            this.cmbOrganizationBranch.Size = new System.Drawing.Size(202, 25);
            this.cmbOrganizationBranch.TabIndex = 34;
            this.cmbOrganizationBranch.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganizationBranch_SelectionChangeCommitted_1);
            this.cmbOrganizationBranch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrganizationBranch_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(57, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 33;
            this.label8.Tag = "Code";
            this.label8.Text = "Branch";
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(123, 12);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(202, 25);
            this.cmbOrganization.TabIndex = 32;
            this.cmbOrganization.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganization_SelectionChangeCommitted);
            this.cmbOrganization.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrganization_KeyDown);
            this.cmbOrganization.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbOrganization_KeyUp);
            this.cmbOrganization.Leave += new System.EventHandler(this.cmbOrganization_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 31;
            this.label4.Tag = "Code";
            this.label4.Text = "Organization";
            // 
            // pnlcmbBranch
            // 
            this.pnlcmbBranch.Location = new System.Drawing.Point(3, 90);
            this.pnlcmbBranch.Name = "pnlcmbBranch";
            this.pnlcmbBranch.Size = new System.Drawing.Size(548, 10);
            this.pnlcmbBranch.TabIndex = 48;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtEmail);
            this.panel10.Controls.Add(this.txt_Name);
            this.panel10.Controls.Add(this.txt_code);
            this.panel10.Controls.Add(this.lblSectionTitle);
            this.panel10.Controls.Add(this.lblError_name);
            this.panel10.Controls.Add(this.lblErrorAdress);
            this.panel10.Controls.Add(this.bunifuCustomLabel3);
            this.panel10.Controls.Add(this.lblErrorPhone);
            this.panel10.Controls.Add(this.lblErrorEmail);
            this.panel10.Controls.Add(this.txt_shortName);
            this.panel10.Controls.Add(this.txt_iban);
            this.panel10.Controls.Add(this.lblSectionCode);
            this.panel10.Controls.Add(this.bunifuCustomLabel11);
            this.panel10.Controls.Add(this.lblError_IBAN);
            this.panel10.Controls.Add(this.txt_Bank_account_number);
            this.panel10.Controls.Add(this.bunifuCustomLabel10);
            this.panel10.Controls.Add(this.lblError_Bank_account_number);
            this.panel10.Controls.Add(this.bunifuCustomLabel8);
            this.panel10.Controls.Add(this.lblError_email);
            this.panel10.Controls.Add(this.txtAdress);
            this.panel10.Controls.Add(this.lblError_Address);
            this.panel10.Controls.Add(this.bunifuCustomLabel9);
            this.panel10.Controls.Add(this.txtPhone);
            this.panel10.Controls.Add(this.bunifuCustomLabel7);
            this.panel10.Controls.Add(this.txt_Standard_Report_Number);
            this.panel10.Controls.Add(this.bunifuCustomLabel6);
            this.panel10.Controls.Add(this.lblError_Standard_Report_Number);
            this.panel10.Controls.Add(this.txt_Gurranty);
            this.panel10.Controls.Add(this.bunifuCustomLabel5);
            this.panel10.Controls.Add(this.lblError_Gurranty);
            this.panel10.Controls.Add(this.lblError_Goods_And_Services_Tax);
            this.panel10.Controls.Add(this.lblError_National_Tax_Number);
            this.panel10.Controls.Add(this.lblError_add);
            this.panel10.Controls.Add(this.lblError_Description);
            this.panel10.Location = new System.Drawing.Point(3, 106);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(548, 284);
            this.panel10.TabIndex = 53;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Name.Location = new System.Drawing.Point(122, 11);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(202, 25);
            this.txt_Name.TabIndex = 11;
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyDown);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_code.Location = new System.Drawing.Point(123, 93);
            this.txt_code.MaxLength = 20;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(202, 25);
            this.txt_code.TabIndex = 15;
            this.txt_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_code_KeyDown);
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(54, 16);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(44, 17);
            this.lblSectionTitle.TabIndex = 6;
            this.lblSectionTitle.Text = "Name";
            // 
            // lblError_name
            // 
            this.lblError_name.AutoSize = true;
            this.lblError_name.BackColor = System.Drawing.Color.Transparent;
            this.lblError_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblError_name.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_name.Location = new System.Drawing.Point(330, 11);
            this.lblError_name.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_name.Name = "lblError_name";
            this.lblError_name.Size = new System.Drawing.Size(13, 16);
            this.lblError_name.TabIndex = 10;
            this.lblError_name.Text = "*";
            // 
            // lblErrorAdress
            // 
            this.lblErrorAdress.AutoSize = true;
            this.lblErrorAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblErrorAdress.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorAdress.Location = new System.Drawing.Point(429, 198);
            this.lblErrorAdress.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblErrorAdress.Name = "lblErrorAdress";
            this.lblErrorAdress.Size = new System.Drawing.Size(13, 16);
            this.lblErrorAdress.TabIndex = 57;
            this.lblErrorAdress.Text = "*";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(59, 94);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(39, 17);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Code";
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorPhone.Location = new System.Drawing.Point(330, 162);
            this.lblErrorPhone.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(13, 16);
            this.lblErrorPhone.TabIndex = 56;
            this.lblErrorPhone.Text = "*";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorEmail.Location = new System.Drawing.Point(330, 121);
            this.lblErrorEmail.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(13, 16);
            this.lblErrorEmail.TabIndex = 55;
            this.lblErrorEmail.Text = "*";
            // 
            // txt_shortName
            // 
            this.txt_shortName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_shortName.Location = new System.Drawing.Point(123, 50);
            this.txt_shortName.MaxLength = 20;
            this.txt_shortName.Name = "txt_shortName";
            this.txt_shortName.Size = new System.Drawing.Size(202, 25);
            this.txt_shortName.TabIndex = 12;
            this.txt_shortName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_shortName_KeyDown);
            // 
            // txt_iban
            // 
            this.txt_iban.Location = new System.Drawing.Point(213, 753);
            this.txt_iban.MaxLength = 50;
            this.txt_iban.Name = "txt_iban";
            this.txt_iban.Size = new System.Drawing.Size(202, 20);
            this.txt_iban.TabIndex = 54;
            this.txt_iban.Visible = false;
            // 
            // lblSectionCode
            // 
            this.lblSectionCode.AutoSize = true;
            this.lblSectionCode.BackColor = System.Drawing.Color.Transparent;
            this.lblSectionCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSectionCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.lblSectionCode.Location = new System.Drawing.Point(21, 50);
            this.lblSectionCode.Name = "lblSectionCode";
            this.lblSectionCode.Size = new System.Drawing.Size(77, 17);
            this.lblSectionCode.TabIndex = 6;
            this.lblSectionCode.Text = "ShortName";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(-37, 753);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(231, 17);
            this.bunifuCustomLabel11.TabIndex = 52;
            this.bunifuCustomLabel11.Text = "International Bank Account Number";
            this.bunifuCustomLabel11.Visible = false;
            // 
            // lblError_IBAN
            // 
            this.lblError_IBAN.AutoSize = true;
            this.lblError_IBAN.BackColor = System.Drawing.Color.Transparent;
            this.lblError_IBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_IBAN.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_IBAN.Location = new System.Drawing.Point(474, 753);
            this.lblError_IBAN.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_IBAN.Name = "lblError_IBAN";
            this.lblError_IBAN.Size = new System.Drawing.Size(0, 17);
            this.lblError_IBAN.TabIndex = 53;
            this.lblError_IBAN.Visible = false;
            // 
            // txt_Bank_account_number
            // 
            this.txt_Bank_account_number.Location = new System.Drawing.Point(213, 706);
            this.txt_Bank_account_number.MaxLength = 50;
            this.txt_Bank_account_number.Name = "txt_Bank_account_number";
            this.txt_Bank_account_number.Size = new System.Drawing.Size(202, 20);
            this.txt_Bank_account_number.TabIndex = 51;
            this.txt_Bank_account_number.Visible = false;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(45, 706);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(149, 17);
            this.bunifuCustomLabel10.TabIndex = 49;
            this.bunifuCustomLabel10.Text = "Bank Account Number";
            this.bunifuCustomLabel10.Visible = false;
            // 
            // lblError_Bank_account_number
            // 
            this.lblError_Bank_account_number.AutoSize = true;
            this.lblError_Bank_account_number.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Bank_account_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Bank_account_number.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Bank_account_number.Location = new System.Drawing.Point(474, 706);
            this.lblError_Bank_account_number.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Bank_account_number.Name = "lblError_Bank_account_number";
            this.lblError_Bank_account_number.Size = new System.Drawing.Size(0, 17);
            this.lblError_Bank_account_number.TabIndex = 50;
            this.lblError_Bank_account_number.Visible = false;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(58, 131);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(40, 17);
            this.bunifuCustomLabel8.TabIndex = 46;
            this.bunifuCustomLabel8.Text = "Email";
            // 
            // lblError_email
            // 
            this.lblError_email.AutoSize = true;
            this.lblError_email.BackColor = System.Drawing.Color.Transparent;
            this.lblError_email.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_email.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_email.Location = new System.Drawing.Point(311, 361);
            this.lblError_email.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_email.Name = "lblError_email";
            this.lblError_email.Size = new System.Drawing.Size(0, 20);
            this.lblError_email.TabIndex = 47;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAdress.Location = new System.Drawing.Point(122, 209);
            this.txtAdress.MaxLength = 250;
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(301, 62);
            this.txtAdress.TabIndex = 45;
            // 
            // lblError_Address
            // 
            this.lblError_Address.AutoSize = true;
            this.lblError_Address.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Address.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Address.Location = new System.Drawing.Point(290, 282);
            this.lblError_Address.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Address.Name = "lblError_Address";
            this.lblError_Address.Size = new System.Drawing.Size(0, 20);
            this.lblError_Address.TabIndex = 44;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(41, 209);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(57, 17);
            this.bunifuCustomLabel9.TabIndex = 43;
            this.bunifuCustomLabel9.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(122, 172);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(202, 25);
            this.txtPhone.TabIndex = 42;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(51, 172);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(47, 17);
            this.bunifuCustomLabel7.TabIndex = 40;
            this.bunifuCustomLabel7.Text = "Phone";
            // 
            // txt_Standard_Report_Number
            // 
            this.txt_Standard_Report_Number.Location = new System.Drawing.Point(270, 493);
            this.txt_Standard_Report_Number.MaxLength = 20;
            this.txt_Standard_Report_Number.Name = "txt_Standard_Report_Number";
            this.txt_Standard_Report_Number.Size = new System.Drawing.Size(202, 20);
            this.txt_Standard_Report_Number.TabIndex = 39;
            this.txt_Standard_Report_Number.Visible = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(81, 493);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(167, 17);
            this.bunifuCustomLabel6.TabIndex = 37;
            this.bunifuCustomLabel6.Text = "Standard Report Number";
            this.bunifuCustomLabel6.Visible = false;
            // 
            // lblError_Standard_Report_Number
            // 
            this.lblError_Standard_Report_Number.AutoSize = true;
            this.lblError_Standard_Report_Number.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Standard_Report_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Standard_Report_Number.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Standard_Report_Number.Location = new System.Drawing.Point(531, 493);
            this.lblError_Standard_Report_Number.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Standard_Report_Number.Name = "lblError_Standard_Report_Number";
            this.lblError_Standard_Report_Number.Size = new System.Drawing.Size(0, 17);
            this.lblError_Standard_Report_Number.TabIndex = 38;
            this.lblError_Standard_Report_Number.Visible = false;
            // 
            // txt_Gurranty
            // 
            this.txt_Gurranty.Location = new System.Drawing.Point(270, 467);
            this.txt_Gurranty.MaxLength = 20;
            this.txt_Gurranty.Name = "txt_Gurranty";
            this.txt_Gurranty.Size = new System.Drawing.Size(202, 20);
            this.txt_Gurranty.TabIndex = 36;
            this.txt_Gurranty.Visible = false;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(187, 467);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(64, 17);
            this.bunifuCustomLabel5.TabIndex = 34;
            this.bunifuCustomLabel5.Text = "Gurranty";
            this.bunifuCustomLabel5.Visible = false;
            // 
            // lblError_Gurranty
            // 
            this.lblError_Gurranty.AutoSize = true;
            this.lblError_Gurranty.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Gurranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Gurranty.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Gurranty.Location = new System.Drawing.Point(531, 467);
            this.lblError_Gurranty.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Gurranty.Name = "lblError_Gurranty";
            this.lblError_Gurranty.Size = new System.Drawing.Size(0, 17);
            this.lblError_Gurranty.TabIndex = 35;
            this.lblError_Gurranty.Visible = false;
            // 
            // lblError_Goods_And_Services_Tax
            // 
            this.lblError_Goods_And_Services_Tax.AutoSize = true;
            this.lblError_Goods_And_Services_Tax.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Goods_And_Services_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Goods_And_Services_Tax.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Goods_And_Services_Tax.Location = new System.Drawing.Point(531, 441);
            this.lblError_Goods_And_Services_Tax.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Goods_And_Services_Tax.Name = "lblError_Goods_And_Services_Tax";
            this.lblError_Goods_And_Services_Tax.Size = new System.Drawing.Size(0, 17);
            this.lblError_Goods_And_Services_Tax.TabIndex = 32;
            this.lblError_Goods_And_Services_Tax.Visible = false;
            // 
            // lblError_National_Tax_Number
            // 
            this.lblError_National_Tax_Number.AutoSize = true;
            this.lblError_National_Tax_Number.BackColor = System.Drawing.Color.Transparent;
            this.lblError_National_Tax_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_National_Tax_Number.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_National_Tax_Number.Location = new System.Drawing.Point(531, 415);
            this.lblError_National_Tax_Number.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_National_Tax_Number.Name = "lblError_National_Tax_Number";
            this.lblError_National_Tax_Number.Size = new System.Drawing.Size(0, 17);
            this.lblError_National_Tax_Number.TabIndex = 29;
            this.lblError_National_Tax_Number.Visible = false;
            // 
            // lblError_add
            // 
            this.lblError_add.AutoSize = true;
            this.lblError_add.BackColor = System.Drawing.Color.Transparent;
            this.lblError_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_add.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_add.Location = new System.Drawing.Point(531, 389);
            this.lblError_add.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_add.Name = "lblError_add";
            this.lblError_add.Size = new System.Drawing.Size(0, 17);
            this.lblError_add.TabIndex = 26;
            this.lblError_add.Visible = false;
            // 
            // lblError_Description
            // 
            this.lblError_Description.AutoSize = true;
            this.lblError_Description.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Description.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Description.Location = new System.Drawing.Point(292, 120);
            this.lblError_Description.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Description.Name = "lblError_Description";
            this.lblError_Description.Size = new System.Drawing.Size(0, 20);
            this.lblError_Description.TabIndex = 23;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnSave);
            this.flowLayoutPanel3.Controls.Add(this.btnClear);
            this.flowLayoutPanel3.Controls.Add(this.btnDelete);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(295, 105);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSave.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePosition = 16;
            this.btnSave.ImageZoom = 73;
            this.btnSave.LabelPosition = 32;
            this.btnSave.LabelText = "Save";
            this.btnSave.Location = new System.Drawing.Point(5, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 96);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnClear.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImagePosition = 16;
            this.btnClear.ImageZoom = 73;
            this.btnClear.LabelPosition = 32;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(82, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 96);
            this.btnClear.TabIndex = 6;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnDelete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePosition = 16;
            this.btnDelete.ImageZoom = 73;
            this.btnDelete.LabelPosition = 32;
            this.btnDelete.LabelText = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(159, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 96);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.flowLayoutPanel3);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(712, 115);
            this.panelToolBox.TabIndex = 22;
            this.panelToolBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelToolBox_Paint);
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = true;
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(122, 128);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 25);
            this.txtEmail.TabIndex = 58;
            // 
            // ucProductParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.gridParty);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txt_National_Tax_Number);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txt_goods_and_service_tax);
            this.Name = "ucProductParty";
            this.Size = new System.Drawing.Size(712, 698);
            this.Load += new System.EventHandler(this.ucProductParty_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ucProductParty_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridParty)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panelToolBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView gridParty;
		private System.Windows.Forms.TextBox txt_goods_and_service_tax;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
		private System.Windows.Forms.TextBox txt_National_Tax_Number;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private System.Windows.Forms.TextBox txt_add;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.ComboBox cmbOrganization;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Name;
		private Bunifu.Framework.UI.BunifuCustomLabel lblSectionTitle;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_name;
		private System.Windows.Forms.TextBox txt_code;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private System.Windows.Forms.TextBox txt_shortName;
		private Bunifu.Framework.UI.BunifuCustomLabel lblSectionCode;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.TextBox txt_iban;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_IBAN;
		private System.Windows.Forms.TextBox txt_Bank_account_number;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_Bank_account_number;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_email;
		private System.Windows.Forms.TextBox txtAdress;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_Address;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
		private System.Windows.Forms.TextBox txtPhone;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
		private System.Windows.Forms.TextBox txt_Standard_Report_Number;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_Standard_Report_Number;
		private System.Windows.Forms.TextBox txt_Gurranty;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_Gurranty;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_Goods_And_Services_Tax;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_National_Tax_Number;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_add;
		private Bunifu.Framework.UI.BunifuCustomLabel lblError_Description;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		public Bunifu.Framework.UI.BunifuTileButton btnSave;
		private Bunifu.Framework.UI.BunifuTileButton btnClear;
		public Bunifu.Framework.UI.BunifuTileButton btnDelete;
		private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuCustomLabel lblErrorAdress;
        private Bunifu.Framework.UI.BunifuCustomLabel lblErrorPhone;
        private Bunifu.Framework.UI.BunifuCustomLabel lblErrorEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbOrganizationBranch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlcmbBranch;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
