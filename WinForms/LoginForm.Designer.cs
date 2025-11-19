namespace WinForms
{
    partial class LoginForm
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
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.txtBUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.chkBShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(287, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(143, 48);
            this.bigLabel1.TabIndex = 2;
            this.bigLabel1.Text = "Login";
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.White;
            this.bigLabel3.Location = new System.Drawing.Point(50, 145);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(230, 45);
            this.bigLabel3.TabIndex = 4;
            this.bigLabel3.Text = "Username";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.White;
            this.bigLabel2.Location = new System.Drawing.Point(50, 263);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(221, 45);
            this.bigLabel2.TabIndex = 5;
            this.bigLabel2.Text = "Password";
            // 
            // txtBUsername
            // 
            this.txtBUsername.AutoRoundedCorners = true;
            this.txtBUsername.BorderColor = System.Drawing.Color.White;
            this.txtBUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBUsername.DefaultText = "";
            this.txtBUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUsername.Font = new System.Drawing.Font("Verdana", 19.8F);
            this.txtBUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBUsername.Location = new System.Drawing.Point(295, 130);
            this.txtBUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtBUsername.Name = "txtBUsername";
            this.txtBUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBUsername.PlaceholderText = "";
            this.txtBUsername.SelectedText = "";
            this.txtBUsername.Size = new System.Drawing.Size(279, 60);
            this.txtBUsername.TabIndex = 6;
            // 
            // txtBPassword
            // 
            this.txtBPassword.AutoRoundedCorners = true;
            this.txtBPassword.BorderColor = System.Drawing.Color.White;
            this.txtBPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBPassword.DefaultText = "";
            this.txtBPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBPassword.Font = new System.Drawing.Font("Verdana", 19.8F);
            this.txtBPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBPassword.Location = new System.Drawing.Point(295, 248);
            this.txtBPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtBPassword.Name = "txtBPassword";
            this.txtBPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBPassword.PlaceholderText = "";
            this.txtBPassword.SelectedText = "";
            this.txtBPassword.Size = new System.Drawing.Size(279, 60);
            this.txtBPassword.TabIndex = 7;
            this.txtBPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(371, 402);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(278, 81);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkBShowPassword
            // 
            this.chkBShowPassword.AutoSize = true;
            this.chkBShowPassword.CheckedState.BorderColor = System.Drawing.Color.White;
            this.chkBShowPassword.CheckedState.BorderRadius = 0;
            this.chkBShowPassword.CheckedState.BorderThickness = 0;
            this.chkBShowPassword.CheckedState.FillColor = System.Drawing.Color.White;
            this.chkBShowPassword.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chkBShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkBShowPassword.Location = new System.Drawing.Point(590, 273);
            this.chkBShowPassword.Name = "chkBShowPassword";
            this.chkBShowPassword.Size = new System.Drawing.Size(18, 17);
            this.chkBShowPassword.TabIndex = 9;
            this.chkBShowPassword.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.chkBShowPassword.UncheckedState.BorderRadius = 0;
            this.chkBShowPassword.UncheckedState.BorderThickness = 0;
            this.chkBShowPassword.UncheckedState.FillColor = System.Drawing.Color.White;
            this.chkBShowPassword.CheckedChanged += new System.EventHandler(this.chkBShowPassword_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(58, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(278, 81);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(736, 545);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkBShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBPassword);
            this.Controls.Add(this.txtBUsername);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.bigLabel3);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtBPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtBUsername;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private Guna.UI2.WinForms.Guna2CheckBox chkBShowPassword;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}