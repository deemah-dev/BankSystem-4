using Components;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using SystemBusiness;
using SystemModules;

namespace WinForms
{
    public partial class ManageClientsForm : Form
    {
        private BankUser currentUser;

        public ManageClientsForm(BankUser bankUser)
        {
            InitializeComponent();
            currentUser = bankUser;
            grdVClientsList.DataSource = BankClientService.Table();
        }

        private void cmboBClientsIDs_Click(object sender, EventArgs e)
        {
            ((Guna2ComboBox)sender).DataSource = BankClientService.IDsList();
        }

        private void cleanDeleteTabP()
        {
            cmboBClientsIDsForDelete.SelectedIndex = -1;
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this client?\nthis will delete every data related to this client", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BankClientService.Delete(Convert.ToInt32(cmboBClientsIDsForDelete.Text)))
                {
                    MessageBox.Show("Client Deleted Successfully");
                    cleanDeleteTabP();
                }
            }
        }

        private void cmboBCLientsIDsForUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankClientComponent bankClientComponent = BankClientService.Component(Convert.ToInt32(cmboBCLientsIDsForUpdate.Text));
            txtBUpdateFirstName.Text = bankClientComponent.Person.FirstName;
            txtBUpdateLastName.Text = bankClientComponent.Person.LastName;
            txtBUpdateEmail.Text = bankClientComponent.Person.Email;
            cmboBUpdateCountriesNames.DataSource = CountryService.CountriesNamesList();
            cmboBUpdateCountriesNames.Text = CountryService.Find(bankClientComponent.Phone.CountryID).CountryName;
            txtBUpdatePhoneCode.Text = CountryService.PhoneCode(cmboBUpdateCountriesNames.Text);
            txtBUpdatePhoneNumber.Text = bankClientComponent.Phone.PhoneNumber;
            txtBUpdatePINCode.Text = bankClientComponent.Account.PINCode;
        }

        private void cleanUpdateTabP()
        {
            txtBUpdateFirstName.Clear();
            txtBUpdateLastName.Clear();
            txtBUpdateEmail.Clear();
            cmboBUpdateCountriesNames.SelectedIndex = -1;
            txtBUpdatePhoneNumber.Clear();
            txtBUpdatePINCode.Clear();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update this client?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(cmboBCLientsIDsForUpdate.Text);
                string FirstName = txtBUpdateFirstName.Text;
                string LastName = txtBUpdateLastName.Text;
                string Email = txtBUpdateEmail.Text;
                string CountryName = cmboBUpdateCountriesNames.Text;
                string PhoneNumber = txtBUpdatePhoneNumber.Text;
                string PINCode = txtBUpdatePINCode.Text;
                if (BankClientService.Update(ID, FirstName, LastName, Email, CountryName, PhoneNumber, PINCode))
                {
                    MessageBox.Show("Client Updated Successfully");
                    cleanUpdateTabP();
                }
            }
        }

        private void cmboBUpdateCountriesNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBUpdatePhoneCode.Text = CountryService.PhoneCode(cmboBUpdateCountriesNames.Text);
        }

        private void cmboBCountriesNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBPhoneCode.Text = CountryService.PhoneCode(cmboBCountriesNames.Text);
        }

        private void cleanAddTabP()
        {
            txtBFirstName.Clear();
            txtBLastName.Clear();
            txtBEmail.Clear();
            cmboBCountriesNames.SelectedIndex = -1;
            txtBPhoneNumber.Clear();
            DTBkrBirthDate.Value = DateTime.Now;
            rBMale.Checked = true;
            txtBPINCode.Clear();
            txtBBalance.Clear();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to add this client?", "Confirm Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string FirstName = txtBFirstName.Text;
                string LastName = txtBLastName.Text;
                string Email = txtBEmail.Text;
                string CountryName = cmboBCountriesNames.Text;
                string PhoneNumber = txtBPhoneNumber.Text;
                DateTime BirthDate = DTBkrBirthDate.Value;
                string Gender = null;
                if (rBMale.Checked) Gender = rBMale.Text;
                else if (rBFemale.Checked) Gender = rBFemale.Text;
                string PINCode = txtBPINCode.Text;
                decimal Balance = Convert.ToDecimal(txtBBalance.Text);
                if (BankClientService.Add(FirstName, LastName, Email, CountryName, PhoneNumber, BirthDate, Gender, PINCode, Balance))
                {
                    MessageBox.Show("Client Added Successfully");
                    cleanAddTabP();
                }
            }
        }

        private void ctrlTabClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ctrlTabClients.SelectedTab == tabPClientsList)
            {
                grdVClientsList.DataSource = BankClientService.Table();
                return;
            }
            if(ctrlTabClients.SelectedTab == tabPAddClient)
            {
                if (!BankUserService.checkPermissions(currentUser, Permissions.AddClients))
                {
                    tabPAddClient.Enabled = false;
                    return;
                }
            }
            if(ctrlTabClients.SelectedTab == tabPUpdateClient)
            {
                if (!BankUserService.checkPermissions(currentUser, Permissions.UpdateClients))
                {
                    tabPUpdateClient.Enabled = false;
                    return;
                }
            }
            if(ctrlTabClients.SelectedTab == tabPDeleteClient)
            {
                if (!BankUserService.checkPermissions(currentUser, Permissions.DeleteClients))
                {
                    tabPDeleteClient.Enabled = false;
                    return;
                }
            }
        }

        private void cmboBCountriesNames_Click(object sender, EventArgs e)
        {
            ((Guna2ComboBox)sender).DataSource = CountryService.CountriesNamesList();
        }
    }
}
