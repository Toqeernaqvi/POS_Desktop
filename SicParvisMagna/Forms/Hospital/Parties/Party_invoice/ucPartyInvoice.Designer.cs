namespace SicParvisMagna.Forms.Hospital.Parties.Party_invoice
{
    partial class ucPartyInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPartyInvoice));
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.mtcPartyInvoice = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lblErrorDAte = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError_Party = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combo_Party = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_CustomerNo = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_EntryNo = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblErrorName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_valueIncludingTax = new System.Windows.Forms.TextBox();
            this.txt_salestaxPayable = new System.Windows.Forms.TextBox();
            this.txt_rateofTax = new System.Windows.Forms.TextBox();
            this.txt_ValueExclusiveTax = new System.Windows.Forms.TextBox();
            this.gridPartyInvoice = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelToolBox.SuspendLayout();
            this.mtcPartyInvoice.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartyInvoice)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.panelToolBox.Controls.Add(this.flowLayoutPanel3);
            this.panelToolBox.Controls.Add(this.txt_search);
            this.panelToolBox.Controls.Add(this.btn_Back);
            this.panelToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBox.Location = new System.Drawing.Point(0, 0);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(737, 115);
            this.panelToolBox.TabIndex = 21;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_search.Location = new System.Drawing.Point(302, 47);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(258, 29);
            this.txt_search.TabIndex = 26;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // mtcPartyInvoice
            // 
            this.mtcPartyInvoice.Controls.Add(this.metroTabPage1);
            this.mtcPartyInvoice.Location = new System.Drawing.Point(0, 115);
            this.mtcPartyInvoice.Name = "mtcPartyInvoice";
            this.mtcPartyInvoice.SelectedIndex = 0;
            this.mtcPartyInvoice.Size = new System.Drawing.Size(737, 335);
            this.mtcPartyInvoice.TabIndex = 22;
            this.mtcPartyInvoice.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(729, 293);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Party Invoice";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Controls.Add(this.panel3);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(729, 293);
            this.flowLayoutPanel.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtp_Date);
            this.panel2.Controls.Add(this.lblErrorDAte);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.lblError_Party);
            this.panel2.Controls.Add(this.combo_Party);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 87);
            this.panel2.TabIndex = 0;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtp_Date.Location = new System.Drawing.Point(430, 17);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 27);
            this.dtp_Date.TabIndex = 74;
            // 
            // lblErrorDAte
            // 
            this.lblErrorDAte.AutoSize = true;
            this.lblErrorDAte.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorDAte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDAte.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorDAte.Location = new System.Drawing.Point(439, 53);
            this.lblErrorDAte.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblErrorDAte.Name = "lblErrorDAte";
            this.lblErrorDAte.Size = new System.Drawing.Size(0, 21);
            this.lblErrorDAte.TabIndex = 73;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(374, 18);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(44, 20);
            this.bunifuCustomLabel7.TabIndex = 72;
            this.bunifuCustomLabel7.Text = "Date";
            // 
            // lblError_Party
            // 
            this.lblError_Party.AutoSize = true;
            this.lblError_Party.BackColor = System.Drawing.Color.Transparent;
            this.lblError_Party.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_Party.ForeColor = System.Drawing.Color.Tomato;
            this.lblError_Party.Location = new System.Drawing.Point(77, 53);
            this.lblError_Party.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblError_Party.Name = "lblError_Party";
            this.lblError_Party.Size = new System.Drawing.Size(0, 21);
            this.lblError_Party.TabIndex = 70;
            // 
            // combo_Party
            // 
            this.combo_Party.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Party.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Party.FormattingEnabled = true;
            this.combo_Party.Location = new System.Drawing.Point(70, 15);
            this.combo_Party.Name = "combo_Party";
            this.combo_Party.Size = new System.Drawing.Size(202, 29);
            this.combo_Party.TabIndex = 69;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(14, 18);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(45, 20);
            this.bunifuCustomLabel5.TabIndex = 68;
            this.bunifuCustomLabel5.Text = "Party";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_CustomerNo);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.txt_EntryNo);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.lblErrorName);
            this.panel3.Location = new System.Drawing.Point(3, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 100);
            this.panel3.TabIndex = 1;
            // 
            // txt_CustomerNo
            // 
            this.txt_CustomerNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerNo.Location = new System.Drawing.Point(143, 13);
            this.txt_CustomerNo.MaxLength = 20;
            this.txt_CustomerNo.Name = "txt_CustomerNo";
            this.txt_CustomerNo.Size = new System.Drawing.Size(202, 27);
            this.txt_CustomerNo.TabIndex = 70;
            this.txt_CustomerNo.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 14);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(102, 20);
            this.bunifuCustomLabel2.TabIndex = 68;
            this.bunifuCustomLabel2.Text = "Customer No";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Tomato;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(351, 16);
            this.bunifuCustomLabel4.MaximumSize = new System.Drawing.Size(300, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(0, 21);
            this.bunifuCustomLabel4.TabIndex = 69;
            this.bunifuCustomLabel4.Visible = false;
            // 
            // txt_EntryNo
            // 
            this.txt_EntryNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EntryNo.Location = new System.Drawing.Point(143, 53);
            this.txt_EntryNo.MaxLength = 20;
            this.txt_EntryNo.Name = "txt_EntryNo";
            this.txt_EntryNo.Size = new System.Drawing.Size(202, 27);
            this.txt_EntryNo.TabIndex = 67;
            this.txt_EntryNo.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(62, 56);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(70, 20);
            this.bunifuCustomLabel3.TabIndex = 65;
            this.bunifuCustomLabel3.Text = "Entry No";
            this.bunifuCustomLabel3.Visible = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Tomato;
            this.lblErrorName.Location = new System.Drawing.Point(351, 56);
            this.lblErrorName.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 21);
            this.lblErrorName.TabIndex = 66;
            this.lblErrorName.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txt_valueIncludingTax);
            this.panel1.Controls.Add(this.txt_salestaxPayable);
            this.panel1.Controls.Add(this.txt_rateofTax);
            this.panel1.Controls.Add(this.txt_ValueExclusiveTax);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 58);
            this.panel1.TabIndex = 28;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(135, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(44, 20);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "Total";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // txt_valueIncludingTax
            // 
            this.txt_valueIncludingTax.BackColor = System.Drawing.SystemColors.Control;
            this.txt_valueIncludingTax.Location = new System.Drawing.Point(499, 19);
            this.txt_valueIncludingTax.Name = "txt_valueIncludingTax";
            this.txt_valueIncludingTax.ReadOnly = true;
            this.txt_valueIncludingTax.Size = new System.Drawing.Size(100, 20);
            this.txt_valueIncludingTax.TabIndex = 35;
            this.txt_valueIncludingTax.Visible = false;
            // 
            // txt_salestaxPayable
            // 
            this.txt_salestaxPayable.Location = new System.Drawing.Point(395, 19);
            this.txt_salestaxPayable.Name = "txt_salestaxPayable";
            this.txt_salestaxPayable.ReadOnly = true;
            this.txt_salestaxPayable.Size = new System.Drawing.Size(103, 20);
            this.txt_salestaxPayable.TabIndex = 34;
            this.txt_salestaxPayable.Visible = false;
            // 
            // txt_rateofTax
            // 
            this.txt_rateofTax.Location = new System.Drawing.Point(293, 19);
            this.txt_rateofTax.Name = "txt_rateofTax";
            this.txt_rateofTax.ReadOnly = true;
            this.txt_rateofTax.Size = new System.Drawing.Size(100, 20);
            this.txt_rateofTax.TabIndex = 33;
            this.txt_rateofTax.Visible = false;
            // 
            // txt_ValueExclusiveTax
            // 
            this.txt_ValueExclusiveTax.Location = new System.Drawing.Point(191, 19);
            this.txt_ValueExclusiveTax.Name = "txt_ValueExclusiveTax";
            this.txt_ValueExclusiveTax.ReadOnly = true;
            this.txt_ValueExclusiveTax.Size = new System.Drawing.Size(100, 20);
            this.txt_ValueExclusiveTax.TabIndex = 32;
            this.txt_ValueExclusiveTax.Visible = false;
            // 
            // gridPartyInvoice
            // 
            this.gridPartyInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPartyInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPartyInvoice.Location = new System.Drawing.Point(0, 445);
            this.gridPartyInvoice.Name = "gridPartyInvoice";
            this.gridPartyInvoice.Size = new System.Drawing.Size(737, 196);
            this.gridPartyInvoice.TabIndex = 29;
            this.gridPartyInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPartyInvoice_CellClick);
            this.gridPartyInvoice.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridMedicine_CellValidating);
            this.gridPartyInvoice.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridPartyInvoice_DataError);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnSave);
            this.flowLayoutPanel3.Controls.Add(this.btnClear);
            this.flowLayoutPanel3.Controls.Add(this.btnDelete);
            this.flowLayoutPanel3.Controls.Add(this.btnSearch);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(295, 111);
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
            this.btnSave.ImagePosition = 17;
            this.btnSave.ImageZoom = 73;
            this.btnSave.LabelPosition = 34;
            this.btnSave.LabelText = "Save";
            this.btnSave.Location = new System.Drawing.Point(5, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 99);
            this.btnSave.TabIndex = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
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
            this.btnClear.ImagePosition = 17;
            this.btnClear.ImageZoom = 73;
            this.btnClear.LabelPosition = 34;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(78, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 99);
            this.btnClear.TabIndex = 6;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
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
            this.btnDelete.ImagePosition = 17;
            this.btnDelete.ImageZoom = 73;
            this.btnDelete.LabelPosition = 34;
            this.btnDelete.LabelText = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(146, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 99);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(217)))), ((int)(((byte)(224)))));
            this.btnSearch.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImagePosition = 17;
            this.btnSearch.ImageZoom = 73;
            this.btnSearch.LabelPosition = 34;
            this.btnSearch.LabelText = "Search";
            this.btnSearch.Location = new System.Drawing.Point(212, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 99);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Image = global::SicParvisMagna.Properties.Resources.Back_Arrow_48px;
            this.btn_Back.ImageActive = null;
            this.btn_Back.Location = new System.Drawing.Point(656, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(77, 48);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Back.TabIndex = 25;
            this.btn_Back.TabStop = false;
            this.btn_Back.Zoom = 10;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // ucPartyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPartyInvoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtcPartyInvoice);
            this.Controls.Add(this.panelToolBox);
            this.Name = "ucPartyInvoice";
            this.Size = new System.Drawing.Size(737, 699);
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.mtcPartyInvoice.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartyInvoice)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBox;
        private Bunifu.Framework.UI.BunifuImageButton btn_Back;
        private MetroFramework.Controls.MetroTabControl mtcPartyInvoice;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txt_valueIncludingTax;
        private System.Windows.Forms.TextBox txt_salestaxPayable;
        private System.Windows.Forms.TextBox txt_rateofTax;
        private System.Windows.Forms.TextBox txt_ValueExclusiveTax;
        private System.Windows.Forms.DataGridView gridPartyInvoice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private Bunifu.Framework.UI.BunifuCustomLabel lblErrorDAte;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel lblError_Party;
        private System.Windows.Forms.ComboBox combo_Party;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_CustomerNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txt_EntryNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblErrorName;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public Bunifu.Framework.UI.BunifuTileButton btnSave;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        public Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnSearch;
    }
}
