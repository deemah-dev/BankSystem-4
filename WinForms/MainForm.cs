using System;
using System.Windows.Forms;
using SystemBusiness;
using SystemModules;

namespace WinForms
{
    public partial class MainForm : Form
    {
        private void EnableButtons(bool Enabled)
        {
            btnDoTransactions.Enabled = Enabled;
            btnEditPersonalInformation.Enabled = Enabled;
            btnManageClients.Enabled = Enabled;
            btnManageCurrencies.Enabled = Enabled;
            btnManageUsers.Enabled = Enabled;
            btnShowRegisters.Enabled = Enabled;
            btnLogOut.Enabled = Enabled;
        }

        private void FormWithNullUser()
        {
            lblWelcomUsewr.Text = "Login To Use Permissions";
            lblUsername.Text = "";
            lblUsername.Visible = false;
            EnableButtons(false);
        }

        public MainForm(BankUser bankUser)
        {
            InitializeComponent();
            currentUser = bankUser;
            if(currentUser == null)
            {
                FormWithNullUser();
            }
            else
            {
                lblWelcomUsewr.Text = "Welcom User";
                lblUsername.Visible = true;
                lblUsername.Text = currentUser.Username;
                EnableButtons(true);
            }
        }

        private BankUser currentUser = null;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(currentUser == null)
            {
                Form form = new LoginForm();
                form.Show();
                this.Hide();
            }
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (BankUserService.checkPermissions(currentUser, Permissions.ManageUsers))
            {
                Form form = new ManageUsersForm(currentUser);
                form.ShowDialog();
            }
        }

        private void btnShowRegisters_Click(object sender, EventArgs e)
        {
            if (BankUserService.checkPermissions(currentUser, Permissions.ShowRegisters))
            {
                Form form = new RegistersForm();
                form.ShowDialog();
            }
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            if (BankUserService.checkPermissions(currentUser, Permissions.ManageClients))
            {
                Form form = new ManageClientsForm(currentUser);
                form.ShowDialog();
            }
        }

        private void btnDoTransactions_Click(object sender, EventArgs e)
        {
            if (BankUserService.checkPermissions(currentUser, Permissions.DoTransactions))
            {
                Form form = new TransactionsForm(currentUser);
                form.ShowDialog();
            }
        }

        private void btnManageCurrencies_Click(object sender, EventArgs e)
        {
            if (BankUserService.checkPermissions(currentUser, Permissions.ManageCurrencies))
            {
                Form form = new ManageCurrenciesForm(currentUser);
                form.ShowDialog();
            }
        }

        private void btnEditPersonalInformation_Click(object sender, EventArgs e)
        {
            Form form = new PersonalInformationForm(currentUser);
            form.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(currentUser != null)
            {
                if (MessageBox.Show("Are you sure you want to log out", "Confirm Log Out", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    FormWithNullUser();
                }
            }
        }
    }
}