using System;
using System.Windows.Forms;
using SystemBusiness;
using SystemModules;

namespace WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cleanForm();
            Form form = new MainForm(null);
            form.Show();
            this.Close();
        }

        private void chkBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBShowPassword.Checked) txtBPassword.UseSystemPasswordChar = false;
            else txtBPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BankUser bankUser = BankUserService.Login(txtBUsername.Text, txtBPassword.Text);
            cleanForm();
            if (bankUser == null)
            {
                MessageBox.Show("Wrong Username Or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form form = new MainForm(bankUser);
            form.Show();
            RegisterService.AddLoginRecord(bankUser.ID, DateTime.Now);
            this.Hide();
        }

        private void cleanForm()
        {
            txtBPassword.Clear();
            txtBUsername.Clear();
        }
    }
}
