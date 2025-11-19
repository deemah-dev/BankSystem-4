using System;
using System.Windows.Forms;
using SystemBusiness;
using SystemModules;

namespace WinForms
{
    public partial class PersonalInformationForm : Form
    {
        public PersonalInformationForm(BankUser bankUser)
        {
            InitializeComponent();
            currentUser = bankUser;
        }
        BankUser currentUser = null;

        private void clearUpdatePasswordTabP()
        {
            txtBOldPassword.Clear();
            txtBNewPassword.Clear();
            txtBConfirmNewPassword.Clear();
            chkBShowConfirmNewPassword.Checked = false;
            chkBShowNewPassword.Checked = false;
            chkBShowOldPassword.Checked = false;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(PersonalInformationService.UpdatePassword(currentUser, txtBOldPassword.Text, txtBNewPassword.Text, txtBConfirmNewPassword.Text))
            {
                MessageBox.Show("Update Password Done Successfully");
                clearUpdatePasswordTabP();
            }
        }

        private void clearUpdateEmailTabP()
        {
            txtBNewEmail.Clear();
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            if (PersonalInformationService.UpdateEmail(currentUser, txtBNewEmail.Text))
            {
                MessageBox.Show("Update Email Done Successfully");
                clearUpdateEmailTabP();
            }
        }

        private void cmboBCountriesNames_Click(object sender, EventArgs e)
        {
            cmboBCountriesNames.DataSource = CountryService.CountriesNamesList();
        }

        private void cmboBCountriesNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBPhoneCode.Text = CountryService.PhoneCode(cmboBCountriesNames.Text);

        }

        private void clearUpdatePhoneTabP()
        {
            cmboBCountriesNames.SelectedIndex = -1;
            txtBPhoneNumber.Clear();
            txtBPhoneCode.Clear();
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            if (PersonalInformationService.UpdatePhone(currentUser, cmboBCountriesNames.Text, txtBPhoneNumber.Text))
            {
                MessageBox.Show("Update Phone Done Successfully");
            }
        }

        private void chkBShowOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBShowOldPassword.Checked)
                txtBOldPassword.UseSystemPasswordChar = false;
            else if(!chkBShowOldPassword.Checked)
                txtBOldPassword.UseSystemPasswordChar = true;
        }

        private void chkBShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBShowNewPassword.Checked)
                txtBNewPassword.UseSystemPasswordChar = false;
            else if (!chkBShowNewPassword.Checked)
                txtBNewPassword.UseSystemPasswordChar = true;
        }

        private void chkBShowConfirmNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBShowConfirmNewPassword.Checked)
                txtBConfirmNewPassword.UseSystemPasswordChar = false;
            else if (!chkBShowConfirmNewPassword.Checked)
                txtBConfirmNewPassword.UseSystemPasswordChar = true;
        }
    }
}
