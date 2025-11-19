namespace WinForms
{
    partial class ManageCurrenciesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ctrlTabCurrencies = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPCurrenciesList = new System.Windows.Forms.TabPage();
            this.grdVCurrenciesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabPAddCurrency = new System.Windows.Forms.TabPage();
            this.txtBAddCurrencyRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.cmboBAddCountriesNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.btnAddCurrency = new Guna.UI2.WinForms.Guna2Button();
            this.txtBAddCurrencyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabPUpdateRate = new System.Windows.Forms.TabPage();
            this.txtBNewRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.cmboBCurrenciesCodesForUpdate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.btnUpdateRate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabPDeleteCurrency = new System.Windows.Forms.TabPage();
            this.bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            this.btnDeleteCurrency = new Guna.UI2.WinForms.Guna2Button();
            this.cmboBCurrenciesCodeForDelete = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlTabCurrencies.SuspendLayout();
            this.tabPCurrenciesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVCurrenciesList)).BeginInit();
            this.tabPAddCurrency.SuspendLayout();
            this.tabPUpdateRate.SuspendLayout();
            this.tabPDeleteCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ctrlTabCurrencies
            // 
            this.ctrlTabCurrencies.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctrlTabCurrencies.Controls.Add(this.tabPCurrenciesList);
            this.ctrlTabCurrencies.Controls.Add(this.tabPAddCurrency);
            this.ctrlTabCurrencies.Controls.Add(this.tabPUpdateRate);
            this.ctrlTabCurrencies.Controls.Add(this.tabPDeleteCurrency);
            this.ctrlTabCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlTabCurrencies.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTabCurrencies.ForeColorA = System.Drawing.Color.White;
            this.ctrlTabCurrencies.ForeColorB = System.Drawing.Color.Silver;
            this.ctrlTabCurrencies.ForeColorC = System.Drawing.Color.Silver;
            this.ctrlTabCurrencies.ItemSize = new System.Drawing.Size(200, 50);
            this.ctrlTabCurrencies.Location = new System.Drawing.Point(0, 0);
            this.ctrlTabCurrencies.Name = "ctrlTabCurrencies";
            this.ctrlTabCurrencies.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.ctrlTabCurrencies.SelectedIndex = 0;
            this.ctrlTabCurrencies.Size = new System.Drawing.Size(1155, 628);
            this.ctrlTabCurrencies.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ctrlTabCurrencies.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.ctrlTabCurrencies.TabIndex = 2;
            this.ctrlTabCurrencies.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ctrlTabCurrencies.ThemeColorA = System.Drawing.Color.White;
            this.ctrlTabCurrencies.ThemeColorB = System.Drawing.Color.Silver;
            this.ctrlTabCurrencies.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            this.ctrlTabCurrencies.SelectedIndexChanged += new System.EventHandler(this.ctrlTabCurrencies_SelectedIndexChanged);
            // 
            // tabPCurrenciesList
            // 
            this.tabPCurrenciesList.Controls.Add(this.grdVCurrenciesList);
            this.tabPCurrenciesList.Controls.Add(this.guna2ControlBox1);
            this.tabPCurrenciesList.Location = new System.Drawing.Point(0, 50);
            this.tabPCurrenciesList.Name = "tabPCurrenciesList";
            this.tabPCurrenciesList.Size = new System.Drawing.Size(1155, 578);
            this.tabPCurrenciesList.TabIndex = 0;
            this.tabPCurrenciesList.Text = "Currencies List";
            this.tabPCurrenciesList.UseVisualStyleBackColor = true;
            // 
            // grdVCurrenciesList
            // 
            this.grdVCurrenciesList.AllowUserToAddRows = false;
            this.grdVCurrenciesList.AllowUserToDeleteRows = false;
            this.grdVCurrenciesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdVCurrenciesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVCurrenciesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdVCurrenciesList.ColumnHeadersHeight = 35;
            this.grdVCurrenciesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVCurrenciesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdVCurrenciesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdVCurrenciesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdVCurrenciesList.Location = new System.Drawing.Point(0, 38);
            this.grdVCurrenciesList.Name = "grdVCurrenciesList";
            this.grdVCurrenciesList.ReadOnly = true;
            this.grdVCurrenciesList.RowHeadersVisible = false;
            this.grdVCurrenciesList.RowHeadersWidth = 51;
            this.grdVCurrenciesList.RowTemplate.Height = 24;
            this.grdVCurrenciesList.Size = new System.Drawing.Size(1155, 540);
            this.grdVCurrenciesList.TabIndex = 8;
            this.grdVCurrenciesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.grdVCurrenciesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdVCurrenciesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdVCurrenciesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdVCurrenciesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdVCurrenciesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdVCurrenciesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdVCurrenciesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdVCurrenciesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.grdVCurrenciesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdVCurrenciesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVCurrenciesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.grdVCurrenciesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdVCurrenciesList.ThemeStyle.HeaderStyle.Height = 35;
            this.grdVCurrenciesList.ThemeStyle.ReadOnly = true;
            this.grdVCurrenciesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdVCurrenciesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdVCurrenciesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVCurrenciesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdVCurrenciesList.ThemeStyle.RowsStyle.Height = 24;
            this.grdVCurrenciesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdVCurrenciesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdVCurrenciesList.VirtualMode = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1107, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // tabPAddCurrency
            // 
            this.tabPAddCurrency.Controls.Add(this.txtBAddCurrencyRate);
            this.tabPAddCurrency.Controls.Add(this.bigLabel2);
            this.tabPAddCurrency.Controls.Add(this.cmboBAddCountriesNames);
            this.tabPAddCurrency.Controls.Add(this.bigLabel1);
            this.tabPAddCurrency.Controls.Add(this.btnAddCurrency);
            this.tabPAddCurrency.Controls.Add(this.txtBAddCurrencyName);
            this.tabPAddCurrency.Controls.Add(this.bigLabel6);
            this.tabPAddCurrency.Controls.Add(this.guna2ControlBox2);
            this.tabPAddCurrency.Location = new System.Drawing.Point(0, 50);
            this.tabPAddCurrency.Name = "tabPAddCurrency";
            this.tabPAddCurrency.Padding = new System.Windows.Forms.Padding(3);
            this.tabPAddCurrency.Size = new System.Drawing.Size(1155, 578);
            this.tabPAddCurrency.TabIndex = 1;
            this.tabPAddCurrency.Text = "Add Currency";
            this.tabPAddCurrency.UseVisualStyleBackColor = true;
            // 
            // txtBAddCurrencyRate
            // 
            this.txtBAddCurrencyRate.AutoRoundedCorners = true;
            this.txtBAddCurrencyRate.BorderColor = System.Drawing.Color.White;
            this.txtBAddCurrencyRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBAddCurrencyRate.DefaultText = "";
            this.txtBAddCurrencyRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBAddCurrencyRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBAddCurrencyRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBAddCurrencyRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBAddCurrencyRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBAddCurrencyRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBAddCurrencyRate.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBAddCurrencyRate.ForeColor = System.Drawing.Color.White;
            this.txtBAddCurrencyRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBAddCurrencyRate.Location = new System.Drawing.Point(487, 164);
            this.txtBAddCurrencyRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBAddCurrencyRate.Name = "txtBAddCurrencyRate";
            this.txtBAddCurrencyRate.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBAddCurrencyRate.PlaceholderText = "";
            this.txtBAddCurrencyRate.SelectedText = "";
            this.txtBAddCurrencyRate.Size = new System.Drawing.Size(326, 42);
            this.txtBAddCurrencyRate.TabIndex = 56;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel2.Location = new System.Drawing.Point(220, 178);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(193, 28);
            this.bigLabel2.TabIndex = 55;
            this.bigLabel2.Text = "Currency Rate";
            // 
            // cmboBAddCountriesNames
            // 
            this.cmboBAddCountriesNames.AutoRoundedCorners = true;
            this.cmboBAddCountriesNames.BackColor = System.Drawing.Color.Transparent;
            this.cmboBAddCountriesNames.BorderColor = System.Drawing.Color.White;
            this.cmboBAddCountriesNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBAddCountriesNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBAddCountriesNames.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBAddCountriesNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAddCountriesNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAddCountriesNames.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBAddCountriesNames.ForeColor = System.Drawing.Color.White;
            this.cmboBAddCountriesNames.ItemHeight = 30;
            this.cmboBAddCountriesNames.Location = new System.Drawing.Point(487, 248);
            this.cmboBAddCountriesNames.Name = "cmboBAddCountriesNames";
            this.cmboBAddCountriesNames.Size = new System.Drawing.Size(326, 36);
            this.cmboBAddCountriesNames.TabIndex = 54;
            this.cmboBAddCountriesNames.Click += new System.EventHandler(this.cmboBAddCountriesNames_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel1.Location = new System.Drawing.Point(220, 256);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(236, 28);
            this.bigLabel1.TabIndex = 53;
            this.bigLabel1.Text = "Currency Country";
            // 
            // btnAddCurrency
            // 
            this.btnAddCurrency.AutoRoundedCorners = true;
            this.btnAddCurrency.BorderColor = System.Drawing.Color.White;
            this.btnAddCurrency.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCurrency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCurrency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCurrency.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddCurrency.ForeColor = System.Drawing.Color.White;
            this.btnAddCurrency.Location = new System.Drawing.Point(448, 372);
            this.btnAddCurrency.Name = "btnAddCurrency";
            this.btnAddCurrency.Size = new System.Drawing.Size(272, 62);
            this.btnAddCurrency.TabIndex = 31;
            this.btnAddCurrency.Text = "Add Currency";
            this.btnAddCurrency.Click += new System.EventHandler(this.btnAddCurrency_Click);
            // 
            // txtBAddCurrencyName
            // 
            this.txtBAddCurrencyName.AutoRoundedCorners = true;
            this.txtBAddCurrencyName.BorderColor = System.Drawing.Color.White;
            this.txtBAddCurrencyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBAddCurrencyName.DefaultText = "";
            this.txtBAddCurrencyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBAddCurrencyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBAddCurrencyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBAddCurrencyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBAddCurrencyName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBAddCurrencyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBAddCurrencyName.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBAddCurrencyName.ForeColor = System.Drawing.Color.White;
            this.txtBAddCurrencyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBAddCurrencyName.Location = new System.Drawing.Point(487, 88);
            this.txtBAddCurrencyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBAddCurrencyName.Name = "txtBAddCurrencyName";
            this.txtBAddCurrencyName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBAddCurrencyName.PlaceholderText = "";
            this.txtBAddCurrencyName.SelectedText = "";
            this.txtBAddCurrencyName.Size = new System.Drawing.Size(326, 42);
            this.txtBAddCurrencyName.TabIndex = 25;
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel6.Location = new System.Drawing.Point(220, 102);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(208, 28);
            this.bigLabel6.TabIndex = 9;
            this.bigLabel6.Text = "Currency Name";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(1104, 6);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // tabPUpdateRate
            // 
            this.tabPUpdateRate.Controls.Add(this.txtBNewRate);
            this.tabPUpdateRate.Controls.Add(this.bigLabel4);
            this.tabPUpdateRate.Controls.Add(this.cmboBCurrenciesCodesForUpdate);
            this.tabPUpdateRate.Controls.Add(this.bigLabel5);
            this.tabPUpdateRate.Controls.Add(this.btnUpdateRate);
            this.tabPUpdateRate.Controls.Add(this.guna2ControlBox3);
            this.tabPUpdateRate.Location = new System.Drawing.Point(0, 50);
            this.tabPUpdateRate.Name = "tabPUpdateRate";
            this.tabPUpdateRate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPUpdateRate.Size = new System.Drawing.Size(1155, 578);
            this.tabPUpdateRate.TabIndex = 2;
            this.tabPUpdateRate.Text = "Update Rate";
            this.tabPUpdateRate.UseVisualStyleBackColor = true;
            // 
            // txtBNewRate
            // 
            this.txtBNewRate.AutoRoundedCorners = true;
            this.txtBNewRate.BorderColor = System.Drawing.Color.White;
            this.txtBNewRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBNewRate.DefaultText = "";
            this.txtBNewRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBNewRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBNewRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBNewRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBNewRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBNewRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBNewRate.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBNewRate.ForeColor = System.Drawing.Color.White;
            this.txtBNewRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBNewRate.Location = new System.Drawing.Point(562, 250);
            this.txtBNewRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBNewRate.Name = "txtBNewRate";
            this.txtBNewRate.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBNewRate.PlaceholderText = "";
            this.txtBNewRate.SelectedText = "";
            this.txtBNewRate.Size = new System.Drawing.Size(326, 42);
            this.txtBNewRate.TabIndex = 60;
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel4.Location = new System.Drawing.Point(187, 250);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(135, 28);
            this.bigLabel4.TabIndex = 59;
            this.bigLabel4.Text = "New Rate";
            // 
            // cmboBCurrenciesCodesForUpdate
            // 
            this.cmboBCurrenciesCodesForUpdate.AutoRoundedCorners = true;
            this.cmboBCurrenciesCodesForUpdate.BackColor = System.Drawing.Color.Transparent;
            this.cmboBCurrenciesCodesForUpdate.BorderColor = System.Drawing.Color.White;
            this.cmboBCurrenciesCodesForUpdate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBCurrenciesCodesForUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBCurrenciesCodesForUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBCurrenciesCodesForUpdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBCurrenciesCodesForUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBCurrenciesCodesForUpdate.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBCurrenciesCodesForUpdate.ForeColor = System.Drawing.Color.White;
            this.cmboBCurrenciesCodesForUpdate.ItemHeight = 30;
            this.cmboBCurrenciesCodesForUpdate.Location = new System.Drawing.Point(562, 145);
            this.cmboBCurrenciesCodesForUpdate.Name = "cmboBCurrenciesCodesForUpdate";
            this.cmboBCurrenciesCodesForUpdate.Size = new System.Drawing.Size(326, 36);
            this.cmboBCurrenciesCodesForUpdate.TabIndex = 58;
            this.cmboBCurrenciesCodesForUpdate.Click += new System.EventHandler(this.cmboBCurrenciesCodes_Click);
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel5.Location = new System.Drawing.Point(187, 153);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(301, 28);
            this.bigLabel5.TabIndex = 57;
            this.bigLabel5.Text = "Choose Currency Code";
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.AutoRoundedCorners = true;
            this.btnUpdateRate.BorderColor = System.Drawing.Color.White;
            this.btnUpdateRate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateRate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateRate.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateRate.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRate.Location = new System.Drawing.Point(471, 418);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(259, 62);
            this.btnUpdateRate.TabIndex = 53;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox3.Location = new System.Drawing.Point(1104, 6);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 1;
            // 
            // tabPDeleteCurrency
            // 
            this.tabPDeleteCurrency.Controls.Add(this.bigLabel7);
            this.tabPDeleteCurrency.Controls.Add(this.btnDeleteCurrency);
            this.tabPDeleteCurrency.Controls.Add(this.cmboBCurrenciesCodeForDelete);
            this.tabPDeleteCurrency.Controls.Add(this.guna2ControlBox4);
            this.tabPDeleteCurrency.Location = new System.Drawing.Point(0, 50);
            this.tabPDeleteCurrency.Name = "tabPDeleteCurrency";
            this.tabPDeleteCurrency.Padding = new System.Windows.Forms.Padding(3);
            this.tabPDeleteCurrency.Size = new System.Drawing.Size(1155, 578);
            this.tabPDeleteCurrency.TabIndex = 3;
            this.tabPDeleteCurrency.Text = "Delete Currency";
            this.tabPDeleteCurrency.UseVisualStyleBackColor = true;
            // 
            // bigLabel7
            // 
            this.bigLabel7.AutoSize = true;
            this.bigLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel7.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel7.Location = new System.Drawing.Point(169, 120);
            this.bigLabel7.Name = "bigLabel7";
            this.bigLabel7.Size = new System.Drawing.Size(301, 28);
            this.bigLabel7.TabIndex = 58;
            this.bigLabel7.Text = "Choose Currency Code";
            // 
            // btnDeleteCurrency
            // 
            this.btnDeleteCurrency.AutoRoundedCorners = true;
            this.btnDeleteCurrency.BorderColor = System.Drawing.Color.White;
            this.btnDeleteCurrency.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCurrency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCurrency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteCurrency.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCurrency.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCurrency.Location = new System.Drawing.Point(431, 283);
            this.btnDeleteCurrency.Name = "btnDeleteCurrency";
            this.btnDeleteCurrency.Size = new System.Drawing.Size(298, 62);
            this.btnDeleteCurrency.TabIndex = 55;
            this.btnDeleteCurrency.Text = "Delete Currency";
            this.btnDeleteCurrency.Click += new System.EventHandler(this.btnDeleteCurrency_Click);
            // 
            // cmboBCurrenciesCodeForDelete
            // 
            this.cmboBCurrenciesCodeForDelete.AutoRoundedCorners = true;
            this.cmboBCurrenciesCodeForDelete.BackColor = System.Drawing.Color.Transparent;
            this.cmboBCurrenciesCodeForDelete.BorderColor = System.Drawing.Color.White;
            this.cmboBCurrenciesCodeForDelete.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBCurrenciesCodeForDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBCurrenciesCodeForDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBCurrenciesCodeForDelete.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBCurrenciesCodeForDelete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBCurrenciesCodeForDelete.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBCurrenciesCodeForDelete.ForeColor = System.Drawing.Color.White;
            this.cmboBCurrenciesCodeForDelete.ItemHeight = 30;
            this.cmboBCurrenciesCodeForDelete.Location = new System.Drawing.Point(518, 112);
            this.cmboBCurrenciesCodeForDelete.Name = "cmboBCurrenciesCodeForDelete";
            this.cmboBCurrenciesCodeForDelete.Size = new System.Drawing.Size(332, 36);
            this.cmboBCurrenciesCodeForDelete.TabIndex = 54;
            this.cmboBCurrenciesCodeForDelete.Click += new System.EventHandler(this.cmboBCurrenciesCodes_Click);
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.BorderColor = System.Drawing.Color.White;
            this.guna2ControlBox4.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox4.Location = new System.Drawing.Point(1104, 6);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.PressedColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 1;
            // 
            // ManageCurrenciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 628);
            this.Controls.Add(this.ctrlTabCurrencies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCurrenciesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCurrencies";
            this.ctrlTabCurrencies.ResumeLayout(false);
            this.tabPCurrenciesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVCurrenciesList)).EndInit();
            this.tabPAddCurrency.ResumeLayout(false);
            this.tabPAddCurrency.PerformLayout();
            this.tabPUpdateRate.ResumeLayout(false);
            this.tabPUpdateRate.PerformLayout();
            this.tabPDeleteCurrency.ResumeLayout(false);
            this.tabPDeleteCurrency.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private ReaLTaiizor.Controls.HopeTabPage ctrlTabCurrencies;
        private System.Windows.Forms.TabPage tabPCurrenciesList;
        private Guna.UI2.WinForms.Guna2DataGridView grdVCurrenciesList;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.TabPage tabPAddCurrency;
        private Guna.UI2.WinForms.Guna2Button btnAddCurrency;
        private Guna.UI2.WinForms.Guna2TextBox txtBAddCurrencyName;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.TabPage tabPUpdateRate;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRate;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.TabPage tabPDeleteCurrency;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCurrency;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBCurrenciesCodeForDelete;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2TextBox txtBAddCurrencyRate;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBAddCountriesNames;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBNewRate;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBCurrenciesCodesForUpdate;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
    }
}