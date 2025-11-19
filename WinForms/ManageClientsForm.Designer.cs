namespace WinForms
{
    partial class ManageClientsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctrlTabClients = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPClientsList = new System.Windows.Forms.TabPage();
            this.grdVClientsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabPAddClient = new System.Windows.Forms.TabPage();
            this.DTBkrBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmboBCountriesNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.txtBPhoneCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel24 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.txtBBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBPINCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel10 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel11 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            this.btnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.rBFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rBMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtBEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabPUpdateClient = new System.Windows.Forms.TabPage();
            this.cmboBUpdateCountriesNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel12 = new ReaLTaiizor.Controls.BigLabel();
            this.txtBUpdatePhoneCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBUpdatePhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel13 = new ReaLTaiizor.Controls.BigLabel();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2Button();
            this.cmboBCLientsIDsForUpdate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel17 = new ReaLTaiizor.Controls.BigLabel();
            this.txtBUpdateEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBUpdateLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBUpdatePINCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBUpdateFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel16 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel21 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel22 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel23 = new ReaLTaiizor.Controls.BigLabel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabPDeleteClient = new System.Windows.Forms.TabPage();
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.cmboBClientsIDsForDelete = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel18 = new ReaLTaiizor.Controls.BigLabel();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlTabClients.SuspendLayout();
            this.tabPClientsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVClientsList)).BeginInit();
            this.tabPAddClient.SuspendLayout();
            this.tabPUpdateClient.SuspendLayout();
            this.tabPDeleteClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlTabClients
            // 
            this.ctrlTabClients.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctrlTabClients.Controls.Add(this.tabPClientsList);
            this.ctrlTabClients.Controls.Add(this.tabPAddClient);
            this.ctrlTabClients.Controls.Add(this.tabPUpdateClient);
            this.ctrlTabClients.Controls.Add(this.tabPDeleteClient);
            this.ctrlTabClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlTabClients.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTabClients.ForeColorA = System.Drawing.Color.White;
            this.ctrlTabClients.ForeColorB = System.Drawing.Color.Silver;
            this.ctrlTabClients.ForeColorC = System.Drawing.Color.Silver;
            this.ctrlTabClients.ItemSize = new System.Drawing.Size(180, 50);
            this.ctrlTabClients.Location = new System.Drawing.Point(0, 0);
            this.ctrlTabClients.Name = "ctrlTabClients";
            this.ctrlTabClients.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.ctrlTabClients.SelectedIndex = 0;
            this.ctrlTabClients.Size = new System.Drawing.Size(1155, 628);
            this.ctrlTabClients.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ctrlTabClients.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.ctrlTabClients.TabIndex = 1;
            this.ctrlTabClients.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ctrlTabClients.ThemeColorA = System.Drawing.Color.White;
            this.ctrlTabClients.ThemeColorB = System.Drawing.Color.Silver;
            this.ctrlTabClients.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            this.ctrlTabClients.SelectedIndexChanged += new System.EventHandler(this.ctrlTabClients_SelectedIndexChanged);
            // 
            // tabPClientsList
            // 
            this.tabPClientsList.Controls.Add(this.grdVClientsList);
            this.tabPClientsList.Controls.Add(this.guna2ControlBox1);
            this.tabPClientsList.Location = new System.Drawing.Point(0, 50);
            this.tabPClientsList.Name = "tabPClientsList";
            this.tabPClientsList.Size = new System.Drawing.Size(1155, 578);
            this.tabPClientsList.TabIndex = 0;
            this.tabPClientsList.Text = "Clients List";
            this.tabPClientsList.UseVisualStyleBackColor = true;
            // 
            // grdVClientsList
            // 
            this.grdVClientsList.AllowUserToAddRows = false;
            this.grdVClientsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdVClientsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVClientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdVClientsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVClientsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdVClientsList.ColumnHeadersHeight = 35;
            this.grdVClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVClientsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdVClientsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdVClientsList.EnableHeadersVisualStyles = true;
            this.grdVClientsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdVClientsList.Location = new System.Drawing.Point(0, 38);
            this.grdVClientsList.MultiSelect = false;
            this.grdVClientsList.Name = "grdVClientsList";
            this.grdVClientsList.ReadOnly = true;
            this.grdVClientsList.RowHeadersVisible = false;
            this.grdVClientsList.RowHeadersWidth = 40;
            this.grdVClientsList.RowTemplate.Height = 24;
            this.grdVClientsList.Size = new System.Drawing.Size(1155, 540);
            this.grdVClientsList.TabIndex = 8;
            this.grdVClientsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.grdVClientsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdVClientsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdVClientsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdVClientsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdVClientsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdVClientsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdVClientsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdVClientsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.grdVClientsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdVClientsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVClientsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.grdVClientsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdVClientsList.ThemeStyle.HeaderStyle.Height = 35;
            this.grdVClientsList.ThemeStyle.ReadOnly = true;
            this.grdVClientsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdVClientsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdVClientsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVClientsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdVClientsList.ThemeStyle.RowsStyle.Height = 24;
            this.grdVClientsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdVClientsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdVClientsList.VirtualMode = true;
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
            // tabPAddClient
            // 
            this.tabPAddClient.Controls.Add(this.DTBkrBirthDate);
            this.tabPAddClient.Controls.Add(this.cmboBCountriesNames);
            this.tabPAddClient.Controls.Add(this.bigLabel5);
            this.tabPAddClient.Controls.Add(this.txtBPhoneCode);
            this.tabPAddClient.Controls.Add(this.txtBPhoneNumber);
            this.tabPAddClient.Controls.Add(this.bigLabel24);
            this.tabPAddClient.Controls.Add(this.bigLabel6);
            this.tabPAddClient.Controls.Add(this.txtBBalance);
            this.tabPAddClient.Controls.Add(this.txtBPINCode);
            this.tabPAddClient.Controls.Add(this.bigLabel10);
            this.tabPAddClient.Controls.Add(this.bigLabel11);
            this.tabPAddClient.Controls.Add(this.bigLabel9);
            this.tabPAddClient.Controls.Add(this.bigLabel7);
            this.tabPAddClient.Controls.Add(this.btnAddClient);
            this.tabPAddClient.Controls.Add(this.rBFemale);
            this.tabPAddClient.Controls.Add(this.rBMale);
            this.tabPAddClient.Controls.Add(this.txtBEmail);
            this.tabPAddClient.Controls.Add(this.txtBLastName);
            this.tabPAddClient.Controls.Add(this.txtBFirstName);
            this.tabPAddClient.Controls.Add(this.bigLabel8);
            this.tabPAddClient.Controls.Add(this.bigLabel4);
            this.tabPAddClient.Controls.Add(this.bigLabel2);
            this.tabPAddClient.Controls.Add(this.bigLabel1);
            this.tabPAddClient.Controls.Add(this.guna2ControlBox2);
            this.tabPAddClient.Location = new System.Drawing.Point(0, 50);
            this.tabPAddClient.Name = "tabPAddClient";
            this.tabPAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPAddClient.Size = new System.Drawing.Size(1155, 578);
            this.tabPAddClient.TabIndex = 1;
            this.tabPAddClient.Text = "Add Client";
            this.tabPAddClient.UseVisualStyleBackColor = true;
            // 
            // DTBkrBirthDate
            // 
            this.DTBkrBirthDate.AutoRoundedCorners = true;
            this.DTBkrBirthDate.BorderColor = System.Drawing.Color.White;
            this.DTBkrBirthDate.Checked = true;
            this.DTBkrBirthDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DTBkrBirthDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTBkrBirthDate.ForeColor = System.Drawing.Color.White;
            this.DTBkrBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTBkrBirthDate.Location = new System.Drawing.Point(228, 415);
            this.DTBkrBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTBkrBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTBkrBirthDate.Name = "DTBkrBirthDate";
            this.DTBkrBirthDate.Size = new System.Drawing.Size(327, 36);
            this.DTBkrBirthDate.TabIndex = 83;
            this.DTBkrBirthDate.Value = new System.DateTime(2025, 11, 16, 12, 37, 24, 478);
            // 
            // cmboBCountriesNames
            // 
            this.cmboBCountriesNames.AutoRoundedCorners = true;
            this.cmboBCountriesNames.BackColor = System.Drawing.Color.Transparent;
            this.cmboBCountriesNames.BorderColor = System.Drawing.Color.White;
            this.cmboBCountriesNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBCountriesNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBCountriesNames.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBCountriesNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBCountriesNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBCountriesNames.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBCountriesNames.ForeColor = System.Drawing.Color.White;
            this.cmboBCountriesNames.ItemHeight = 30;
            this.cmboBCountriesNames.Location = new System.Drawing.Point(228, 289);
            this.cmboBCountriesNames.Name = "cmboBCountriesNames";
            this.cmboBCountriesNames.Size = new System.Drawing.Size(328, 36);
            this.cmboBCountriesNames.TabIndex = 82;
            this.cmboBCountriesNames.SelectedIndexChanged += new System.EventHandler(this.cmboBCountriesNames_SelectedIndexChanged);
            this.cmboBCountriesNames.Click += new System.EventHandler(this.cmboBCountriesNames_Click);
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel5.Location = new System.Drawing.Point(47, 297);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(113, 28);
            this.bigLabel5.TabIndex = 81;
            this.bigLabel5.Text = "Country";
            // 
            // txtBPhoneCode
            // 
            this.txtBPhoneCode.AutoRoundedCorners = true;
            this.txtBPhoneCode.BorderColor = System.Drawing.Color.White;
            this.txtBPhoneCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBPhoneCode.DefaultText = "";
            this.txtBPhoneCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBPhoneCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBPhoneCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBPhoneCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBPhoneCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBPhoneCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBPhoneCode.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBPhoneCode.ForeColor = System.Drawing.Color.White;
            this.txtBPhoneCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBPhoneCode.Location = new System.Drawing.Point(228, 346);
            this.txtBPhoneCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBPhoneCode.Name = "txtBPhoneCode";
            this.txtBPhoneCode.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBPhoneCode.PlaceholderText = "";
            this.txtBPhoneCode.ReadOnly = true;
            this.txtBPhoneCode.SelectedText = "";
            this.txtBPhoneCode.Size = new System.Drawing.Size(82, 42);
            this.txtBPhoneCode.TabIndex = 80;
            // 
            // txtBPhoneNumber
            // 
            this.txtBPhoneNumber.AutoRoundedCorners = true;
            this.txtBPhoneNumber.BorderColor = System.Drawing.Color.White;
            this.txtBPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBPhoneNumber.DefaultText = "";
            this.txtBPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBPhoneNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBPhoneNumber.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtBPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBPhoneNumber.Location = new System.Drawing.Point(316, 346);
            this.txtBPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBPhoneNumber.Name = "txtBPhoneNumber";
            this.txtBPhoneNumber.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBPhoneNumber.PlaceholderText = "";
            this.txtBPhoneNumber.SelectedText = "";
            this.txtBPhoneNumber.Size = new System.Drawing.Size(239, 42);
            this.txtBPhoneNumber.TabIndex = 79;
            // 
            // bigLabel24
            // 
            this.bigLabel24.AutoSize = true;
            this.bigLabel24.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel24.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel24.Location = new System.Drawing.Point(47, 360);
            this.bigLabel24.Name = "bigLabel24";
            this.bigLabel24.Size = new System.Drawing.Size(92, 28);
            this.bigLabel24.TabIndex = 78;
            this.bigLabel24.Text = "Phone";
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel6.Location = new System.Drawing.Point(44, 423);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(142, 28);
            this.bigLabel6.TabIndex = 77;
            this.bigLabel6.Text = "Birth Date";
            // 
            // txtBBalance
            // 
            this.txtBBalance.AutoRoundedCorners = true;
            this.txtBBalance.BorderColor = System.Drawing.Color.White;
            this.txtBBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBBalance.DefaultText = "";
            this.txtBBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBBalance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBBalance.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBBalance.ForeColor = System.Drawing.Color.White;
            this.txtBBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBBalance.Location = new System.Drawing.Point(779, 163);
            this.txtBBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBBalance.Name = "txtBBalance";
            this.txtBBalance.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBBalance.PlaceholderText = "";
            this.txtBBalance.SelectedText = "";
            this.txtBBalance.Size = new System.Drawing.Size(327, 42);
            this.txtBBalance.TabIndex = 37;
            // 
            // txtBPINCode
            // 
            this.txtBPINCode.AutoRoundedCorners = true;
            this.txtBPINCode.BorderColor = System.Drawing.Color.White;
            this.txtBPINCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBPINCode.DefaultText = "";
            this.txtBPINCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBPINCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBPINCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBPINCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBPINCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBPINCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBPINCode.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBPINCode.ForeColor = System.Drawing.Color.White;
            this.txtBPINCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBPINCode.Location = new System.Drawing.Point(779, 94);
            this.txtBPINCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBPINCode.Name = "txtBPINCode";
            this.txtBPINCode.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBPINCode.PlaceholderText = "";
            this.txtBPINCode.SelectedText = "";
            this.txtBPINCode.Size = new System.Drawing.Size(327, 42);
            this.txtBPINCode.TabIndex = 36;
            // 
            // bigLabel10
            // 
            this.bigLabel10.AutoSize = true;
            this.bigLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel10.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel10.Location = new System.Drawing.Point(623, 177);
            this.bigLabel10.Name = "bigLabel10";
            this.bigLabel10.Size = new System.Drawing.Size(113, 28);
            this.bigLabel10.TabIndex = 35;
            this.bigLabel10.Text = "Balance";
            // 
            // bigLabel11
            // 
            this.bigLabel11.AutoSize = true;
            this.bigLabel11.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel11.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel11.Location = new System.Drawing.Point(623, 108);
            this.bigLabel11.Name = "bigLabel11";
            this.bigLabel11.Size = new System.Drawing.Size(133, 28);
            this.bigLabel11.TabIndex = 34;
            this.bigLabel11.Text = "PIN Code";
            // 
            // bigLabel9
            // 
            this.bigLabel9.AutoSize = true;
            this.bigLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel9.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel9.Location = new System.Drawing.Point(806, 28);
            this.bigLabel9.Name = "bigLabel9";
            this.bigLabel9.Size = new System.Drawing.Size(116, 28);
            this.bigLabel9.TabIndex = 33;
            this.bigLabel9.Text = "Account";
            // 
            // bigLabel7
            // 
            this.bigLabel7.AutoSize = true;
            this.bigLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel7.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel7.Location = new System.Drawing.Point(168, 28);
            this.bigLabel7.Name = "bigLabel7";
            this.bigLabel7.Size = new System.Drawing.Size(86, 28);
            this.bigLabel7.TabIndex = 32;
            this.bigLabel7.Text = "Client";
            // 
            // btnAddClient
            // 
            this.btnAddClient.AutoRoundedCorners = true;
            this.btnAddClient.BorderColor = System.Drawing.Color.White;
            this.btnAddClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddClient.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(628, 289);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(230, 62);
            this.btnAddClient.TabIndex = 31;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // rBFemale
            // 
            this.rBFemale.AutoSize = true;
            this.rBFemale.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rBFemale.CheckedState.BorderThickness = 0;
            this.rBFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBFemale.CheckedState.InnerOffset = -4;
            this.rBFemale.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.rBFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBFemale.Location = new System.Drawing.Point(351, 486);
            this.rBFemale.Name = "rBFemale";
            this.rBFemale.Size = new System.Drawing.Size(115, 32);
            this.rBFemale.TabIndex = 28;
            this.rBFemale.Text = "Female";
            this.rBFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBFemale.UncheckedState.BorderThickness = 2;
            this.rBFemale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBFemale.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // rBMale
            // 
            this.rBMale.AutoSize = true;
            this.rBMale.Checked = true;
            this.rBMale.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rBMale.CheckedState.BorderThickness = 0;
            this.rBMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rBMale.CheckedState.InnerOffset = -4;
            this.rBMale.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBMale.Location = new System.Drawing.Point(228, 486);
            this.rBMale.Name = "rBMale";
            this.rBMale.Size = new System.Drawing.Size(86, 32);
            this.rBMale.TabIndex = 27;
            this.rBMale.TabStop = true;
            this.rBMale.Text = "Male";
            this.rBMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBMale.UncheckedState.BorderThickness = 2;
            this.rBMale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBMale.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtBEmail
            // 
            this.txtBEmail.AutoRoundedCorners = true;
            this.txtBEmail.BorderColor = System.Drawing.Color.White;
            this.txtBEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBEmail.DefaultText = "";
            this.txtBEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBEmail.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBEmail.ForeColor = System.Drawing.Color.White;
            this.txtBEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBEmail.Location = new System.Drawing.Point(228, 220);
            this.txtBEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBEmail.Name = "txtBEmail";
            this.txtBEmail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBEmail.PlaceholderText = "";
            this.txtBEmail.SelectedText = "";
            this.txtBEmail.Size = new System.Drawing.Size(328, 42);
            this.txtBEmail.TabIndex = 23;
            // 
            // txtBLastName
            // 
            this.txtBLastName.AutoRoundedCorners = true;
            this.txtBLastName.BorderColor = System.Drawing.Color.White;
            this.txtBLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBLastName.DefaultText = "";
            this.txtBLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBLastName.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBLastName.ForeColor = System.Drawing.Color.White;
            this.txtBLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBLastName.Location = new System.Drawing.Point(228, 157);
            this.txtBLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBLastName.Name = "txtBLastName";
            this.txtBLastName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBLastName.PlaceholderText = "";
            this.txtBLastName.SelectedText = "";
            this.txtBLastName.Size = new System.Drawing.Size(327, 42);
            this.txtBLastName.TabIndex = 22;
            // 
            // txtBFirstName
            // 
            this.txtBFirstName.AutoRoundedCorners = true;
            this.txtBFirstName.BorderColor = System.Drawing.Color.White;
            this.txtBFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBFirstName.DefaultText = "";
            this.txtBFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBFirstName.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBFirstName.ForeColor = System.Drawing.Color.White;
            this.txtBFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBFirstName.Location = new System.Drawing.Point(228, 94);
            this.txtBFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBFirstName.Name = "txtBFirstName";
            this.txtBFirstName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBFirstName.PlaceholderText = "";
            this.txtBFirstName.SelectedText = "";
            this.txtBFirstName.Size = new System.Drawing.Size(327, 42);
            this.txtBFirstName.TabIndex = 17;
            // 
            // bigLabel8
            // 
            this.bigLabel8.AutoSize = true;
            this.bigLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel8.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel8.Location = new System.Drawing.Point(44, 486);
            this.bigLabel8.Name = "bigLabel8";
            this.bigLabel8.Size = new System.Drawing.Size(104, 28);
            this.bigLabel8.TabIndex = 11;
            this.bigLabel8.Text = "Gender";
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel4.Location = new System.Drawing.Point(47, 234);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(83, 28);
            this.bigLabel4.TabIndex = 7;
            this.bigLabel4.Text = "Email";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel2.Location = new System.Drawing.Point(47, 171);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(147, 28);
            this.bigLabel2.TabIndex = 6;
            this.bigLabel2.Text = "Last Name";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel1.Location = new System.Drawing.Point(44, 108);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(151, 28);
            this.bigLabel1.TabIndex = 5;
            this.bigLabel1.Text = "First Name";
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
            // tabPUpdateClient
            // 
            this.tabPUpdateClient.Controls.Add(this.cmboBUpdateCountriesNames);
            this.tabPUpdateClient.Controls.Add(this.bigLabel12);
            this.tabPUpdateClient.Controls.Add(this.txtBUpdatePhoneCode);
            this.tabPUpdateClient.Controls.Add(this.txtBUpdatePhoneNumber);
            this.tabPUpdateClient.Controls.Add(this.bigLabel13);
            this.tabPUpdateClient.Controls.Add(this.btnUpdateClient);
            this.tabPUpdateClient.Controls.Add(this.cmboBCLientsIDsForUpdate);
            this.tabPUpdateClient.Controls.Add(this.bigLabel17);
            this.tabPUpdateClient.Controls.Add(this.txtBUpdateEmail);
            this.tabPUpdateClient.Controls.Add(this.txtBUpdateLastName);
            this.tabPUpdateClient.Controls.Add(this.txtBUpdatePINCode);
            this.tabPUpdateClient.Controls.Add(this.txtBUpdateFirstName);
            this.tabPUpdateClient.Controls.Add(this.bigLabel16);
            this.tabPUpdateClient.Controls.Add(this.bigLabel21);
            this.tabPUpdateClient.Controls.Add(this.bigLabel22);
            this.tabPUpdateClient.Controls.Add(this.bigLabel23);
            this.tabPUpdateClient.Controls.Add(this.guna2ControlBox3);
            this.tabPUpdateClient.Location = new System.Drawing.Point(0, 50);
            this.tabPUpdateClient.Name = "tabPUpdateClient";
            this.tabPUpdateClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPUpdateClient.Size = new System.Drawing.Size(1155, 578);
            this.tabPUpdateClient.TabIndex = 2;
            this.tabPUpdateClient.Text = "Update Client";
            this.tabPUpdateClient.UseVisualStyleBackColor = true;
            // 
            // cmboBUpdateCountriesNames
            // 
            this.cmboBUpdateCountriesNames.AutoRoundedCorners = true;
            this.cmboBUpdateCountriesNames.BackColor = System.Drawing.Color.Transparent;
            this.cmboBUpdateCountriesNames.BorderColor = System.Drawing.Color.White;
            this.cmboBUpdateCountriesNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBUpdateCountriesNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBUpdateCountriesNames.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBUpdateCountriesNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBUpdateCountriesNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBUpdateCountriesNames.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBUpdateCountriesNames.ForeColor = System.Drawing.Color.White;
            this.cmboBUpdateCountriesNames.ItemHeight = 30;
            this.cmboBUpdateCountriesNames.Location = new System.Drawing.Point(565, 307);
            this.cmboBUpdateCountriesNames.Name = "cmboBUpdateCountriesNames";
            this.cmboBUpdateCountriesNames.Size = new System.Drawing.Size(279, 36);
            this.cmboBUpdateCountriesNames.TabIndex = 87;
            this.cmboBUpdateCountriesNames.SelectedIndexChanged += new System.EventHandler(this.cmboBUpdateCountriesNames_SelectedIndexChanged);
            this.cmboBUpdateCountriesNames.Click += new System.EventHandler(this.cmboBCountriesNames_Click);
            // 
            // bigLabel12
            // 
            this.bigLabel12.AutoSize = true;
            this.bigLabel12.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel12.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel12.Location = new System.Drawing.Point(381, 315);
            this.bigLabel12.Name = "bigLabel12";
            this.bigLabel12.Size = new System.Drawing.Size(113, 28);
            this.bigLabel12.TabIndex = 86;
            this.bigLabel12.Text = "Country";
            // 
            // txtBUpdatePhoneCode
            // 
            this.txtBUpdatePhoneCode.AutoRoundedCorners = true;
            this.txtBUpdatePhoneCode.BorderColor = System.Drawing.Color.White;
            this.txtBUpdatePhoneCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBUpdatePhoneCode.DefaultText = "";
            this.txtBUpdatePhoneCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBUpdatePhoneCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBUpdatePhoneCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdatePhoneCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdatePhoneCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBUpdatePhoneCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdatePhoneCode.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBUpdatePhoneCode.ForeColor = System.Drawing.Color.White;
            this.txtBUpdatePhoneCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdatePhoneCode.Location = new System.Drawing.Point(565, 361);
            this.txtBUpdatePhoneCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBUpdatePhoneCode.Name = "txtBUpdatePhoneCode";
            this.txtBUpdatePhoneCode.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBUpdatePhoneCode.PlaceholderText = "";
            this.txtBUpdatePhoneCode.ReadOnly = true;
            this.txtBUpdatePhoneCode.SelectedText = "";
            this.txtBUpdatePhoneCode.Size = new System.Drawing.Size(82, 42);
            this.txtBUpdatePhoneCode.TabIndex = 85;
            // 
            // txtBUpdatePhoneNumber
            // 
            this.txtBUpdatePhoneNumber.AutoRoundedCorners = true;
            this.txtBUpdatePhoneNumber.BorderColor = System.Drawing.Color.White;
            this.txtBUpdatePhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBUpdatePhoneNumber.DefaultText = "";
            this.txtBUpdatePhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBUpdatePhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBUpdatePhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdatePhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdatePhoneNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBUpdatePhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdatePhoneNumber.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBUpdatePhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtBUpdatePhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdatePhoneNumber.Location = new System.Drawing.Point(654, 361);
            this.txtBUpdatePhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBUpdatePhoneNumber.Name = "txtBUpdatePhoneNumber";
            this.txtBUpdatePhoneNumber.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBUpdatePhoneNumber.PlaceholderText = "";
            this.txtBUpdatePhoneNumber.SelectedText = "";
            this.txtBUpdatePhoneNumber.Size = new System.Drawing.Size(190, 42);
            this.txtBUpdatePhoneNumber.TabIndex = 84;
            // 
            // bigLabel13
            // 
            this.bigLabel13.AutoSize = true;
            this.bigLabel13.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel13.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel13.Location = new System.Drawing.Point(381, 375);
            this.bigLabel13.Name = "bigLabel13";
            this.bigLabel13.Size = new System.Drawing.Size(92, 28);
            this.bigLabel13.TabIndex = 83;
            this.bigLabel13.Text = "Phone";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.AutoRoundedCorners = true;
            this.btnUpdateClient.BorderColor = System.Drawing.Color.White;
            this.btnUpdateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateClient.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClient.Location = new System.Drawing.Point(480, 482);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(250, 62);
            this.btnUpdateClient.TabIndex = 53;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // cmboBCLientsIDsForUpdate
            // 
            this.cmboBCLientsIDsForUpdate.AutoRoundedCorners = true;
            this.cmboBCLientsIDsForUpdate.BackColor = System.Drawing.Color.Transparent;
            this.cmboBCLientsIDsForUpdate.BorderColor = System.Drawing.Color.White;
            this.cmboBCLientsIDsForUpdate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBCLientsIDsForUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBCLientsIDsForUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBCLientsIDsForUpdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBCLientsIDsForUpdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBCLientsIDsForUpdate.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBCLientsIDsForUpdate.ForeColor = System.Drawing.Color.White;
            this.cmboBCLientsIDsForUpdate.ItemHeight = 30;
            this.cmboBCLientsIDsForUpdate.Location = new System.Drawing.Point(540, 30);
            this.cmboBCLientsIDsForUpdate.Name = "cmboBCLientsIDsForUpdate";
            this.cmboBCLientsIDsForUpdate.Size = new System.Drawing.Size(326, 36);
            this.cmboBCLientsIDsForUpdate.TabIndex = 52;
            this.cmboBCLientsIDsForUpdate.SelectedIndexChanged += new System.EventHandler(this.cmboBCLientsIDsForUpdate_SelectedIndexChanged);
            this.cmboBCLientsIDsForUpdate.Click += new System.EventHandler(this.cmboBClientsIDs_Click);
            // 
            // bigLabel17
            // 
            this.bigLabel17.AutoSize = true;
            this.bigLabel17.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel17.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel17.Location = new System.Drawing.Point(260, 38);
            this.bigLabel17.Name = "bigLabel17";
            this.bigLabel17.Size = new System.Drawing.Size(228, 28);
            this.bigLabel17.TabIndex = 51;
            this.bigLabel17.Text = "Choose Client ID";
            // 
            // txtBUpdateEmail
            // 
            this.txtBUpdateEmail.AutoRoundedCorners = true;
            this.txtBUpdateEmail.BorderColor = System.Drawing.Color.White;
            this.txtBUpdateEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBUpdateEmail.DefaultText = "";
            this.txtBUpdateEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBUpdateEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBUpdateEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdateEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdateEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBUpdateEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdateEmail.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBUpdateEmail.ForeColor = System.Drawing.Color.White;
            this.txtBUpdateEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdateEmail.Location = new System.Drawing.Point(565, 241);
            this.txtBUpdateEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBUpdateEmail.Name = "txtBUpdateEmail";
            this.txtBUpdateEmail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBUpdateEmail.PlaceholderText = "";
            this.txtBUpdateEmail.SelectedText = "";
            this.txtBUpdateEmail.Size = new System.Drawing.Size(279, 42);
            this.txtBUpdateEmail.TabIndex = 44;
            // 
            // txtBUpdateLastName
            // 
            this.txtBUpdateLastName.AutoRoundedCorners = true;
            this.txtBUpdateLastName.BorderColor = System.Drawing.Color.White;
            this.txtBUpdateLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBUpdateLastName.DefaultText = "";
            this.txtBUpdateLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBUpdateLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBUpdateLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdateLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdateLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBUpdateLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdateLastName.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBUpdateLastName.ForeColor = System.Drawing.Color.White;
            this.txtBUpdateLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdateLastName.Location = new System.Drawing.Point(565, 181);
            this.txtBUpdateLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBUpdateLastName.Name = "txtBUpdateLastName";
            this.txtBUpdateLastName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBUpdateLastName.PlaceholderText = "";
            this.txtBUpdateLastName.SelectedText = "";
            this.txtBUpdateLastName.Size = new System.Drawing.Size(279, 42);
            this.txtBUpdateLastName.TabIndex = 43;
            // 
            // txtBUpdatePINCode
            // 
            this.txtBUpdatePINCode.AutoRoundedCorners = true;
            this.txtBUpdatePINCode.BorderColor = System.Drawing.Color.White;
            this.txtBUpdatePINCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBUpdatePINCode.DefaultText = "";
            this.txtBUpdatePINCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBUpdatePINCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBUpdatePINCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdatePINCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdatePINCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBUpdatePINCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdatePINCode.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBUpdatePINCode.ForeColor = System.Drawing.Color.White;
            this.txtBUpdatePINCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdatePINCode.Location = new System.Drawing.Point(565, 421);
            this.txtBUpdatePINCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBUpdatePINCode.Name = "txtBUpdatePINCode";
            this.txtBUpdatePINCode.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBUpdatePINCode.PlaceholderText = "";
            this.txtBUpdatePINCode.SelectedText = "";
            this.txtBUpdatePINCode.Size = new System.Drawing.Size(279, 42);
            this.txtBUpdatePINCode.TabIndex = 42;
            // 
            // txtBUpdateFirstName
            // 
            this.txtBUpdateFirstName.AutoRoundedCorners = true;
            this.txtBUpdateFirstName.BorderColor = System.Drawing.Color.White;
            this.txtBUpdateFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBUpdateFirstName.DefaultText = "";
            this.txtBUpdateFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBUpdateFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBUpdateFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdateFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUpdateFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBUpdateFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdateFirstName.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBUpdateFirstName.ForeColor = System.Drawing.Color.White;
            this.txtBUpdateFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUpdateFirstName.Location = new System.Drawing.Point(565, 121);
            this.txtBUpdateFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBUpdateFirstName.Name = "txtBUpdateFirstName";
            this.txtBUpdateFirstName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBUpdateFirstName.PlaceholderText = "";
            this.txtBUpdateFirstName.SelectedText = "";
            this.txtBUpdateFirstName.Size = new System.Drawing.Size(279, 42);
            this.txtBUpdateFirstName.TabIndex = 41;
            // 
            // bigLabel16
            // 
            this.bigLabel16.AutoSize = true;
            this.bigLabel16.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel16.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel16.Location = new System.Drawing.Point(381, 435);
            this.bigLabel16.Name = "bigLabel16";
            this.bigLabel16.Size = new System.Drawing.Size(133, 28);
            this.bigLabel16.TabIndex = 39;
            this.bigLabel16.Text = "PIN Code";
            // 
            // bigLabel21
            // 
            this.bigLabel21.AutoSize = true;
            this.bigLabel21.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel21.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel21.Location = new System.Drawing.Point(381, 255);
            this.bigLabel21.Name = "bigLabel21";
            this.bigLabel21.Size = new System.Drawing.Size(83, 28);
            this.bigLabel21.TabIndex = 34;
            this.bigLabel21.Text = "Email";
            // 
            // bigLabel22
            // 
            this.bigLabel22.AutoSize = true;
            this.bigLabel22.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel22.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel22.Location = new System.Drawing.Point(381, 195);
            this.bigLabel22.Name = "bigLabel22";
            this.bigLabel22.Size = new System.Drawing.Size(147, 28);
            this.bigLabel22.TabIndex = 33;
            this.bigLabel22.Text = "Last Name";
            // 
            // bigLabel23
            // 
            this.bigLabel23.AutoSize = true;
            this.bigLabel23.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel23.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel23.Location = new System.Drawing.Point(381, 135);
            this.bigLabel23.Name = "bigLabel23";
            this.bigLabel23.Size = new System.Drawing.Size(151, 28);
            this.bigLabel23.TabIndex = 32;
            this.bigLabel23.Text = "First Name";
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
            // tabPDeleteClient
            // 
            this.tabPDeleteClient.Controls.Add(this.btnDeleteClient);
            this.tabPDeleteClient.Controls.Add(this.cmboBClientsIDsForDelete);
            this.tabPDeleteClient.Controls.Add(this.bigLabel18);
            this.tabPDeleteClient.Controls.Add(this.guna2ControlBox4);
            this.tabPDeleteClient.Location = new System.Drawing.Point(0, 50);
            this.tabPDeleteClient.Name = "tabPDeleteClient";
            this.tabPDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPDeleteClient.Size = new System.Drawing.Size(1155, 578);
            this.tabPDeleteClient.TabIndex = 3;
            this.tabPDeleteClient.Text = "Delete Client";
            this.tabPDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.AutoRoundedCorners = true;
            this.btnDeleteClient.BorderColor = System.Drawing.Color.White;
            this.btnDeleteClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteClient.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Location = new System.Drawing.Point(470, 278);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(248, 62);
            this.btnDeleteClient.TabIndex = 55;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // cmboBClientsIDsForDelete
            // 
            this.cmboBClientsIDsForDelete.AutoRoundedCorners = true;
            this.cmboBClientsIDsForDelete.BackColor = System.Drawing.Color.Transparent;
            this.cmboBClientsIDsForDelete.BorderColor = System.Drawing.Color.White;
            this.cmboBClientsIDsForDelete.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBClientsIDsForDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBClientsIDsForDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBClientsIDsForDelete.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBClientsIDsForDelete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBClientsIDsForDelete.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBClientsIDsForDelete.ForeColor = System.Drawing.Color.White;
            this.cmboBClientsIDsForDelete.ItemHeight = 30;
            this.cmboBClientsIDsForDelete.Location = new System.Drawing.Point(518, 112);
            this.cmboBClientsIDsForDelete.Name = "cmboBClientsIDsForDelete";
            this.cmboBClientsIDsForDelete.Size = new System.Drawing.Size(332, 36);
            this.cmboBClientsIDsForDelete.TabIndex = 54;
            this.cmboBClientsIDsForDelete.Click += new System.EventHandler(this.cmboBClientsIDs_Click);
            // 
            // bigLabel18
            // 
            this.bigLabel18.AutoSize = true;
            this.bigLabel18.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel18.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel18.Location = new System.Drawing.Point(241, 120);
            this.bigLabel18.Name = "bigLabel18";
            this.bigLabel18.Size = new System.Drawing.Size(228, 28);
            this.bigLabel18.TabIndex = 53;
            this.bigLabel18.Text = "Choose Client ID";
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
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 628);
            this.Controls.Add(this.ctrlTabClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClients";
            this.ctrlTabClients.ResumeLayout(false);
            this.tabPClientsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVClientsList)).EndInit();
            this.tabPAddClient.ResumeLayout(false);
            this.tabPAddClient.PerformLayout();
            this.tabPUpdateClient.ResumeLayout(false);
            this.tabPUpdateClient.PerformLayout();
            this.tabPDeleteClient.ResumeLayout(false);
            this.tabPDeleteClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage ctrlTabClients;
        private System.Windows.Forms.TabPage tabPClientsList;
        private Guna.UI2.WinForms.Guna2DataGridView grdVClientsList;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.TabPage tabPAddClient;
        private Guna.UI2.WinForms.Guna2Button btnAddClient;
        private Guna.UI2.WinForms.Guna2RadioButton rBFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rBMale;
        private Guna.UI2.WinForms.Guna2TextBox txtBEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtBLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtBFirstName;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.TabPage tabPUpdateClient;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClient;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBCLientsIDsForUpdate;
        private ReaLTaiizor.Controls.BigLabel bigLabel17;
        private Guna.UI2.WinForms.Guna2TextBox txtBUpdateEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtBUpdateLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtBUpdatePINCode;
        private Guna.UI2.WinForms.Guna2TextBox txtBUpdateFirstName;
        private ReaLTaiizor.Controls.BigLabel bigLabel16;
        private ReaLTaiizor.Controls.BigLabel bigLabel21;
        private ReaLTaiizor.Controls.BigLabel bigLabel22;
        private ReaLTaiizor.Controls.BigLabel bigLabel23;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.TabPage tabPDeleteClient;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClient;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBClientsIDsForDelete;
        private ReaLTaiizor.Controls.BigLabel bigLabel18;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2TextBox txtBBalance;
        private Guna.UI2.WinForms.Guna2TextBox txtBPINCode;
        private ReaLTaiizor.Controls.BigLabel bigLabel10;
        private ReaLTaiizor.Controls.BigLabel bigLabel11;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTBkrBirthDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBCountriesNames;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtBPhoneCode;
        private Guna.UI2.WinForms.Guna2TextBox txtBPhoneNumber;
        private ReaLTaiizor.Controls.BigLabel bigLabel24;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBUpdateCountriesNames;
        private ReaLTaiizor.Controls.BigLabel bigLabel12;
        private Guna.UI2.WinForms.Guna2TextBox txtBUpdatePhoneCode;
        private Guna.UI2.WinForms.Guna2TextBox txtBUpdatePhoneNumber;
        private ReaLTaiizor.Controls.BigLabel bigLabel13;
    }
}