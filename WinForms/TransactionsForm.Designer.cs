namespace WinForms
{
    partial class TransactionsForm
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPDeposit = new System.Windows.Forms.TabPage();
            this.btnConfirmDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.txtBDepositAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel23 = new ReaLTaiizor.Controls.BigLabel();
            this.cmboBAccountsIdsForDeposit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel17 = new ReaLTaiizor.Controls.BigLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabPWithdraw = new System.Windows.Forms.TabPage();
            this.btnConfirmWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.txtBWithdrawAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.cmboBAccountsIdsForWithdraw = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabPTransfer = new System.Windows.Forms.TabPage();
            this.cmboBAccountsIdsForTransfer_Sender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.btnConfirmTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.txtBTransferAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.cmboBAccountsIdsForTransfer_Reciever = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.hopeTabPage1.SuspendLayout();
            this.tabPDeposit.SuspendLayout();
            this.tabPWithdraw.SuspendLayout();
            this.tabPTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // hopeTabPage1
            // 
            this.hopeTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hopeTabPage1.Controls.Add(this.tabPDeposit);
            this.hopeTabPage1.Controls.Add(this.tabPWithdraw);
            this.hopeTabPage1.Controls.Add(this.tabPTransfer);
            this.hopeTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hopeTabPage1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTabPage1.ForeColorA = System.Drawing.Color.White;
            this.hopeTabPage1.ForeColorB = System.Drawing.Color.Silver;
            this.hopeTabPage1.ForeColorC = System.Drawing.Color.Silver;
            this.hopeTabPage1.ItemSize = new System.Drawing.Size(180, 50);
            this.hopeTabPage1.Location = new System.Drawing.Point(0, 0);
            this.hopeTabPage1.Name = "hopeTabPage1";
            this.hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopeTabPage1.SelectedIndex = 0;
            this.hopeTabPage1.Size = new System.Drawing.Size(1155, 628);
            this.hopeTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopeTabPage1.TabIndex = 1;
            this.hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hopeTabPage1.ThemeColorA = System.Drawing.Color.White;
            this.hopeTabPage1.ThemeColorB = System.Drawing.Color.Silver;
            this.hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPDeposit
            // 
            this.tabPDeposit.Controls.Add(this.btnConfirmDeposit);
            this.tabPDeposit.Controls.Add(this.txtBDepositAmount);
            this.tabPDeposit.Controls.Add(this.bigLabel23);
            this.tabPDeposit.Controls.Add(this.cmboBAccountsIdsForDeposit);
            this.tabPDeposit.Controls.Add(this.bigLabel17);
            this.tabPDeposit.Controls.Add(this.guna2ControlBox1);
            this.tabPDeposit.Location = new System.Drawing.Point(0, 50);
            this.tabPDeposit.Name = "tabPDeposit";
            this.tabPDeposit.Size = new System.Drawing.Size(1155, 578);
            this.tabPDeposit.TabIndex = 0;
            this.tabPDeposit.Text = "Deposit";
            this.tabPDeposit.UseVisualStyleBackColor = true;
            // 
            // btnConfirmDeposit
            // 
            this.btnConfirmDeposit.AutoRoundedCorners = true;
            this.btnConfirmDeposit.BorderColor = System.Drawing.Color.White;
            this.btnConfirmDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmDeposit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmDeposit.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmDeposit.ForeColor = System.Drawing.Color.White;
            this.btnConfirmDeposit.Location = new System.Drawing.Point(481, 331);
            this.btnConfirmDeposit.Name = "btnConfirmDeposit";
            this.btnConfirmDeposit.Size = new System.Drawing.Size(289, 62);
            this.btnConfirmDeposit.TabIndex = 57;
            this.btnConfirmDeposit.Text = "Confirm Deposit";
            this.btnConfirmDeposit.Click += new System.EventHandler(this.btnConfirmDeposit_Click);
            // 
            // txtBDepositAmount
            // 
            this.txtBDepositAmount.AutoRoundedCorners = true;
            this.txtBDepositAmount.BorderColor = System.Drawing.Color.White;
            this.txtBDepositAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBDepositAmount.DefaultText = "";
            this.txtBDepositAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBDepositAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBDepositAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBDepositAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBDepositAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBDepositAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBDepositAmount.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBDepositAmount.ForeColor = System.Drawing.Color.White;
            this.txtBDepositAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBDepositAmount.Location = new System.Drawing.Point(528, 188);
            this.txtBDepositAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBDepositAmount.Name = "txtBDepositAmount";
            this.txtBDepositAmount.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBDepositAmount.PlaceholderText = "";
            this.txtBDepositAmount.SelectedText = "";
            this.txtBDepositAmount.Size = new System.Drawing.Size(332, 42);
            this.txtBDepositAmount.TabIndex = 56;
            // 
            // bigLabel23
            // 
            this.bigLabel23.AutoSize = true;
            this.bigLabel23.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel23.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel23.Location = new System.Drawing.Point(242, 202);
            this.bigLabel23.Name = "bigLabel23";
            this.bigLabel23.Size = new System.Drawing.Size(218, 28);
            this.bigLabel23.TabIndex = 55;
            this.bigLabel23.Text = "Deposit Amount";
            // 
            // cmboBAccountsIdsForDeposit
            // 
            this.cmboBAccountsIdsForDeposit.AutoRoundedCorners = true;
            this.cmboBAccountsIdsForDeposit.BackColor = System.Drawing.Color.Transparent;
            this.cmboBAccountsIdsForDeposit.BorderColor = System.Drawing.Color.White;
            this.cmboBAccountsIdsForDeposit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBAccountsIdsForDeposit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBAccountsIdsForDeposit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBAccountsIdsForDeposit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAccountsIdsForDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAccountsIdsForDeposit.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBAccountsIdsForDeposit.ForeColor = System.Drawing.Color.White;
            this.cmboBAccountsIdsForDeposit.ItemHeight = 30;
            this.cmboBAccountsIdsForDeposit.Location = new System.Drawing.Point(528, 89);
            this.cmboBAccountsIdsForDeposit.Name = "cmboBAccountsIdsForDeposit";
            this.cmboBAccountsIdsForDeposit.Size = new System.Drawing.Size(332, 36);
            this.cmboBAccountsIdsForDeposit.TabIndex = 54;
            this.cmboBAccountsIdsForDeposit.Click += new System.EventHandler(this.cmboBAccountsIds_Click);
            // 
            // bigLabel17
            // 
            this.bigLabel17.AutoSize = true;
            this.bigLabel17.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel17.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel17.Location = new System.Drawing.Point(242, 97);
            this.bigLabel17.Name = "bigLabel17";
            this.bigLabel17.Size = new System.Drawing.Size(258, 28);
            this.bigLabel17.TabIndex = 53;
            this.bigLabel17.Text = "Choose Account ID";
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
            // tabPWithdraw
            // 
            this.tabPWithdraw.Controls.Add(this.btnConfirmWithdraw);
            this.tabPWithdraw.Controls.Add(this.txtBWithdrawAmount);
            this.tabPWithdraw.Controls.Add(this.bigLabel1);
            this.tabPWithdraw.Controls.Add(this.cmboBAccountsIdsForWithdraw);
            this.tabPWithdraw.Controls.Add(this.bigLabel2);
            this.tabPWithdraw.Controls.Add(this.guna2ControlBox2);
            this.tabPWithdraw.Location = new System.Drawing.Point(0, 50);
            this.tabPWithdraw.Name = "tabPWithdraw";
            this.tabPWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabPWithdraw.Size = new System.Drawing.Size(1155, 578);
            this.tabPWithdraw.TabIndex = 1;
            this.tabPWithdraw.Text = "Withdraw";
            this.tabPWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnConfirmWithdraw
            // 
            this.btnConfirmWithdraw.AutoRoundedCorners = true;
            this.btnConfirmWithdraw.BorderColor = System.Drawing.Color.White;
            this.btnConfirmWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmWithdraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmWithdraw.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnConfirmWithdraw.Location = new System.Drawing.Point(435, 336);
            this.btnConfirmWithdraw.Name = "btnConfirmWithdraw";
            this.btnConfirmWithdraw.Size = new System.Drawing.Size(319, 62);
            this.btnConfirmWithdraw.TabIndex = 62;
            this.btnConfirmWithdraw.Text = "Confirm Withdraw";
            this.btnConfirmWithdraw.Click += new System.EventHandler(this.btnConfirmWithdraw_Click);
            // 
            // txtBWithdrawAmount
            // 
            this.txtBWithdrawAmount.AutoRoundedCorners = true;
            this.txtBWithdrawAmount.BorderColor = System.Drawing.Color.White;
            this.txtBWithdrawAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBWithdrawAmount.DefaultText = "";
            this.txtBWithdrawAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBWithdrawAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBWithdrawAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBWithdrawAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBWithdrawAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBWithdrawAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBWithdrawAmount.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBWithdrawAmount.ForeColor = System.Drawing.Color.White;
            this.txtBWithdrawAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBWithdrawAmount.Location = new System.Drawing.Point(530, 192);
            this.txtBWithdrawAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBWithdrawAmount.Name = "txtBWithdrawAmount";
            this.txtBWithdrawAmount.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBWithdrawAmount.PlaceholderText = "";
            this.txtBWithdrawAmount.SelectedText = "";
            this.txtBWithdrawAmount.Size = new System.Drawing.Size(332, 42);
            this.txtBWithdrawAmount.TabIndex = 61;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel1.Location = new System.Drawing.Point(244, 206);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(245, 28);
            this.bigLabel1.TabIndex = 60;
            this.bigLabel1.Text = "Withdraw Amount";
            // 
            // cmboBAccountsIdsForWithdraw
            // 
            this.cmboBAccountsIdsForWithdraw.AutoRoundedCorners = true;
            this.cmboBAccountsIdsForWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.cmboBAccountsIdsForWithdraw.BorderColor = System.Drawing.Color.White;
            this.cmboBAccountsIdsForWithdraw.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBAccountsIdsForWithdraw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBAccountsIdsForWithdraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBAccountsIdsForWithdraw.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAccountsIdsForWithdraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAccountsIdsForWithdraw.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBAccountsIdsForWithdraw.ForeColor = System.Drawing.Color.White;
            this.cmboBAccountsIdsForWithdraw.ItemHeight = 30;
            this.cmboBAccountsIdsForWithdraw.Location = new System.Drawing.Point(530, 93);
            this.cmboBAccountsIdsForWithdraw.Name = "cmboBAccountsIdsForWithdraw";
            this.cmboBAccountsIdsForWithdraw.Size = new System.Drawing.Size(332, 36);
            this.cmboBAccountsIdsForWithdraw.TabIndex = 59;
            this.cmboBAccountsIdsForWithdraw.Click += new System.EventHandler(this.cmboBAccountsIds_Click);
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel2.Location = new System.Drawing.Point(244, 101);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(258, 28);
            this.bigLabel2.TabIndex = 58;
            this.bigLabel2.Text = "Choose Account ID";
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
            // tabPTransfer
            // 
            this.tabPTransfer.Controls.Add(this.cmboBAccountsIdsForTransfer_Sender);
            this.tabPTransfer.Controls.Add(this.bigLabel5);
            this.tabPTransfer.Controls.Add(this.btnConfirmTransfer);
            this.tabPTransfer.Controls.Add(this.txtBTransferAmount);
            this.tabPTransfer.Controls.Add(this.bigLabel3);
            this.tabPTransfer.Controls.Add(this.cmboBAccountsIdsForTransfer_Reciever);
            this.tabPTransfer.Controls.Add(this.bigLabel4);
            this.tabPTransfer.Controls.Add(this.guna2ControlBox3);
            this.tabPTransfer.Location = new System.Drawing.Point(0, 50);
            this.tabPTransfer.Name = "tabPTransfer";
            this.tabPTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTransfer.Size = new System.Drawing.Size(1155, 578);
            this.tabPTransfer.TabIndex = 2;
            this.tabPTransfer.Text = "Transfer";
            this.tabPTransfer.UseVisualStyleBackColor = true;
            // 
            // cmboBAccountsIdsForTransfer_Sender
            // 
            this.cmboBAccountsIdsForTransfer_Sender.AutoRoundedCorners = true;
            this.cmboBAccountsIdsForTransfer_Sender.BackColor = System.Drawing.Color.Transparent;
            this.cmboBAccountsIdsForTransfer_Sender.BorderColor = System.Drawing.Color.White;
            this.cmboBAccountsIdsForTransfer_Sender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBAccountsIdsForTransfer_Sender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBAccountsIdsForTransfer_Sender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBAccountsIdsForTransfer_Sender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAccountsIdsForTransfer_Sender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAccountsIdsForTransfer_Sender.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBAccountsIdsForTransfer_Sender.ForeColor = System.Drawing.Color.White;
            this.cmboBAccountsIdsForTransfer_Sender.ItemHeight = 30;
            this.cmboBAccountsIdsForTransfer_Sender.Location = new System.Drawing.Point(554, 69);
            this.cmboBAccountsIdsForTransfer_Sender.Name = "cmboBAccountsIdsForTransfer_Sender";
            this.cmboBAccountsIdsForTransfer_Sender.Size = new System.Drawing.Size(332, 36);
            this.cmboBAccountsIdsForTransfer_Sender.TabIndex = 69;
            this.cmboBAccountsIdsForTransfer_Sender.Click += new System.EventHandler(this.cmboBAccountsIds_Click);
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel5.Location = new System.Drawing.Point(139, 77);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(355, 28);
            this.bigLabel5.TabIndex = 68;
            this.bigLabel5.Text = "Choose Sender Account ID";
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.AutoRoundedCorners = true;
            this.btnConfirmTransfer.BorderColor = System.Drawing.Color.White;
            this.btnConfirmTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmTransfer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmTransfer.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmTransfer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(445, 384);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(319, 62);
            this.btnConfirmTransfer.TabIndex = 67;
            this.btnConfirmTransfer.Text = "Confirm Transfer";
            this.btnConfirmTransfer.Click += new System.EventHandler(this.btnConfirmTransfer_Click);
            // 
            // txtBTransferAmount
            // 
            this.txtBTransferAmount.AutoRoundedCorners = true;
            this.txtBTransferAmount.BorderColor = System.Drawing.Color.White;
            this.txtBTransferAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBTransferAmount.DefaultText = "";
            this.txtBTransferAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBTransferAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBTransferAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBTransferAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBTransferAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBTransferAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBTransferAmount.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.txtBTransferAmount.ForeColor = System.Drawing.Color.White;
            this.txtBTransferAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBTransferAmount.Location = new System.Drawing.Point(554, 245);
            this.txtBTransferAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBTransferAmount.Name = "txtBTransferAmount";
            this.txtBTransferAmount.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBTransferAmount.PlaceholderText = "";
            this.txtBTransferAmount.SelectedText = "";
            this.txtBTransferAmount.Size = new System.Drawing.Size(332, 42);
            this.txtBTransferAmount.TabIndex = 66;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel3.Location = new System.Drawing.Point(139, 259);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(228, 28);
            this.bigLabel3.TabIndex = 65;
            this.bigLabel3.Text = "Transfer Amount";
            // 
            // cmboBAccountsIdsForTransfer_Reciever
            // 
            this.cmboBAccountsIdsForTransfer_Reciever.AutoRoundedCorners = true;
            this.cmboBAccountsIdsForTransfer_Reciever.BackColor = System.Drawing.Color.Transparent;
            this.cmboBAccountsIdsForTransfer_Reciever.BorderColor = System.Drawing.Color.White;
            this.cmboBAccountsIdsForTransfer_Reciever.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBAccountsIdsForTransfer_Reciever.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBAccountsIdsForTransfer_Reciever.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmboBAccountsIdsForTransfer_Reciever.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAccountsIdsForTransfer_Reciever.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboBAccountsIdsForTransfer_Reciever.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBAccountsIdsForTransfer_Reciever.ForeColor = System.Drawing.Color.White;
            this.cmboBAccountsIdsForTransfer_Reciever.ItemHeight = 30;
            this.cmboBAccountsIdsForTransfer_Reciever.Location = new System.Drawing.Point(554, 144);
            this.cmboBAccountsIdsForTransfer_Reciever.Name = "cmboBAccountsIdsForTransfer_Reciever";
            this.cmboBAccountsIdsForTransfer_Reciever.Size = new System.Drawing.Size(332, 36);
            this.cmboBAccountsIdsForTransfer_Reciever.TabIndex = 64;
            this.cmboBAccountsIdsForTransfer_Reciever.Click += new System.EventHandler(this.cmboBAccountsIds_Click);
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bigLabel4.Location = new System.Drawing.Point(139, 152);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(377, 28);
            this.bigLabel4.TabIndex = 63;
            this.bigLabel4.Text = "Choose Reciever Account ID";
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
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 628);
            this.Controls.Add(this.hopeTabPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionsForm";
            this.hopeTabPage1.ResumeLayout(false);
            this.tabPDeposit.ResumeLayout(false);
            this.tabPDeposit.PerformLayout();
            this.tabPWithdraw.ResumeLayout(false);
            this.tabPWithdraw.PerformLayout();
            this.tabPTransfer.ResumeLayout(false);
            this.tabPTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private System.Windows.Forms.TabPage tabPDeposit;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.TabPage tabPWithdraw;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.TabPage tabPTransfer;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBAccountsIdsForDeposit;
        private ReaLTaiizor.Controls.BigLabel bigLabel17;
        private Guna.UI2.WinForms.Guna2TextBox txtBDepositAmount;
        private ReaLTaiizor.Controls.BigLabel bigLabel23;
        private Guna.UI2.WinForms.Guna2Button btnConfirmDeposit;
        private Guna.UI2.WinForms.Guna2Button btnConfirmWithdraw;
        private Guna.UI2.WinForms.Guna2TextBox txtBWithdrawAmount;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBAccountsIdsForWithdraw;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBAccountsIdsForTransfer_Sender;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private Guna.UI2.WinForms.Guna2Button btnConfirmTransfer;
        private Guna.UI2.WinForms.Guna2TextBox txtBTransferAmount;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmboBAccountsIdsForTransfer_Reciever;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
    }
}