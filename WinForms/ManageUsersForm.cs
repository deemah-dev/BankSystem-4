using Components;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using SystemBusiness;
using SystemModules;

namespace WinForms
{
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm(BankUser bankUser)
        {
            InitializeComponent();
            grdVUsersList.DataSource = BankUserService.Table();
            currentUser = bankUser;
        }
        BankUser currentUser = null;

        private void ctrlTabUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ctrlTabUsers.SelectedTab == tabPUsersList)
            {
                grdVUsersList.DataSource = BankUserService.Table();
                return;
            }
            if(ctrlTabUsers.SelectedTab == tabPAddUser)
            {
                if(!BankUserService.checkPermissions(currentUser, Permissions.AddUsers))
                {
                    tabPAddUser.Enabled = false;
                    return;
                }
            }
            if(ctrlTabUsers.SelectedTab == tabPUpdateUser)
            {
                if(!BankUserService.checkPermissions(currentUser, Permissions.UpdateUsers))
                {
                    tabPUpdateUser.Enabled = false;
                    return;
                }
            }
            if(ctrlTabUsers.SelectedTab == tabPDeleteUser)
            {
                if(!BankUserService.checkPermissions(currentUser, Permissions.DeleteUsers))
                {
                    tabPDeleteUser.Enabled = false;
                    return;
                }
            }
        }

        private void tglAddPManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (tglAddPManageUsers.Checked)
            {
                chkBAddPAddUser.Checked = true;
                chkBAddPUpdateUser.Checked = true;
                chkBAddPDeleteUser.Checked = true;
            }
        }

        private void tglAddPManageClients_CheckedChanged(object sender, EventArgs e)
        {
            if (tglAddPManageClients.Checked)
            {
                chkBAddPAddClient.Checked = true;
                chkBAddPUpdateClient.Checked = true;
                chkBAddPDeleteClient.Checked = true;
            }
        }

        private void tglUpdatePManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (tglUpdatePManageUsers.Checked)
            {
                chkBUpdatePAddUser.Checked = true;
                chkBUpdatePUpdateUser.Checked = true;
                chkBUpdatePDeleteUser.Checked = true;
            }
        }

        private void tglUpdatePManageClients_CheckedChanged(object sender, EventArgs e)
        {
            if (tglUpdatePManageClients.Checked)
            {
                chkBUpdatePAddClient.Checked = true;
                chkBUpdatePUpdateClient.Checked = true;
                chkBUpdatePDeleteClient.Checked = true;
            }
        }

        private void EnableAddPermissions(bool Enabled)
        {
            tglAddPManageUsers.Enabled = Enabled;
            lblAddPManageUsers.Enabled = Enabled;
            chkBAddPAddUser.Enabled = Enabled;
            chkBAddPUpdateUser.Enabled = Enabled;
            chkBAddPDeleteUser.Enabled = Enabled;
            guna2Shapes2.Enabled = Enabled;
            tglAddPManageClients.Enabled = Enabled;
            lblAddPManageClients.Enabled = Enabled;
            chkBAddPAddClient.Enabled = Enabled;
            chkBAddPUpdateClient.Enabled = Enabled;
            chkBAddPDeleteClient.Enabled = Enabled;
            guna2Shapes1.Enabled = Enabled;
            chkBAddPManageCurrencies.Enabled = Enabled;
            chkBAddPShowRegisters.Enabled = Enabled;
            chkBAddPDoTransactions.Enabled = Enabled;
        }

        private void EnableUpdatePermissions(bool Enabled)
        {
            tglUpdatePManageUsers.Enabled = Enabled;
            lblUpdatePManageUsers.Enabled = Enabled;
            chkBUpdatePAddUser.Enabled = Enabled;
            chkBUpdatePUpdateUser.Enabled = Enabled;
            chkBUpdatePDeleteUser.Enabled = Enabled;
            guna2Shapes3.Enabled = Enabled;
            tglUpdatePManageClients.Enabled = Enabled;
            lblUpdatePManageClients.Enabled = Enabled;
            chkBUpdatePAddClient.Enabled = Enabled;
            chkBUpdatePUpdateClient.Enabled = Enabled;
            chkBUpdatePDeleteClient.Enabled = Enabled;
            guna2Shapes4.Enabled = Enabled;
            chkBUpdatePManageCurrencies.Enabled = Enabled;
            chkBUpdatePShowRegisters.Enabled = Enabled;
            chkBUpdatePDoTransactions.Enabled = Enabled;
        }

        private void rBAddAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if (rBAddAllPermissions.Checked)
            {
                EnableAddPermissions(false);
            }
        }

        private void rBAddSetPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if (rBAddSetPermissions.Checked)
            {
                EnableAddPermissions(true);
            }
        }

        private void rBUpdateAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if (rBUpdateAllPermissions.Checked)
            {
                EnableUpdatePermissions(false);
            }
        }

        private void rBUpdateSetPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if (rBUpdateSetPermissions.Checked)
            {
                EnableUpdatePermissions(true);
            }
        }

        private int GetPermissionsForNewUser()
        {
            int permissions = 0;
            if (rBAddAllPermissions.Checked) permissions = -1;
            if (rBAddSetPermissions.Checked)
            {
                if (tglAddPManageUsers.Checked) permissions += (int)Permissions.ManageUsers;
                if (chkBAddPAddUser.Checked) permissions += (int)Permissions.AddUsers;
                if (chkBAddPUpdateUser.Checked) permissions += (int)Permissions.UpdateUsers;
                if (chkBAddPDeleteUser.Checked) permissions += (int)Permissions.DeleteUsers;

                if (tglAddPManageClients.Checked) permissions += (int)Permissions.ManageClients;
                if (chkBAddPAddClient.Checked) permissions += (int)Permissions.AddClients;
                if (chkBAddPUpdateClient.Checked) permissions += (int)Permissions.UpdateClients;
                if (chkBAddPDeleteClient.Checked) permissions += (int)Permissions.DeleteClients;

                if (chkBAddPManageCurrencies.Checked) permissions += (int)Permissions.ManageCurrencies;
                if (chkBAddPDoTransactions.Checked) permissions += (int)Permissions.DoTransactions;
                if (chkBAddPShowRegisters.Checked) permissions += (int)Permissions.ShowRegisters;
            }
            return permissions;
        }

        private int GetPermissionsForUpdateUser()
        {
            int permissions = 0;
            if (rBUpdateAllPermissions.Checked) permissions = -1;
            if (rBUpdateSetPermissions.Checked)
            {
                if (tglUpdatePManageUsers.Checked) permissions += (int)Permissions.ManageUsers;
                if (chkBUpdatePAddUser.Checked) permissions += (int)Permissions.AddUsers;
                if (chkBUpdatePUpdateUser.Checked) permissions += (int)Permissions.UpdateUsers;
                if (chkBUpdatePDeleteUser.Checked) permissions += (int)Permissions.DeleteUsers;

                if (tglUpdatePManageClients.Checked) permissions += (int)Permissions.ManageClients;
                if (chkBUpdatePAddClient.Checked) permissions += (int)Permissions.AddClients;
                if (chkBUpdatePUpdateClient.Checked) permissions += (int)Permissions.UpdateClients;
                if (chkBUpdatePDeleteClient.Checked) permissions += (int)Permissions.DeleteClients;

                if (chkBUpdatePManageCurrencies.Checked) permissions += (int)Permissions.ManageCurrencies;
                if (chkBUpdatePDoTransactions.Checked) permissions += (int)Permissions.DoTransactions;
                if (chkBUpdatePShowRegisters.Checked) permissions += (int)Permissions.ShowRegisters;
            }
            return permissions;
        }

        private void cmboBCountriesName_Click(object sender, EventArgs e)
        {
            ((Guna2ComboBox)sender).DataSource = CountryService.CountriesNamesList();
        }

        private void cmboBAddCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBAddPhoneCode.Text = CountryService.PhoneCode(cmboBAddCountry.Text);
        }

        private void cmboBUpdateCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBUpdatePhoneCode.Text = CountryService.PhoneCode(cmboBUpdateCountry.Text);
        }

        private void clearAddTabP()
        {
            txtBAddFirstName.Clear();
            txtBAddLastName.Clear();
            txtBAddEmail.Clear();
            cmboBAddCountry.SelectedIndex = -1;
            txtBAddPhoneNumber.Clear();
            dtBkrAddBirthDate.Value = DateTime.Now;
            rBAddMale.Checked = true;
            txtBAddUsername.Clear();
            txtBAddPassword.Clear();
            rBAddAllPermissions.Checked = true;
            EnableAddPermissions(false);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to add this user?", "Confirm Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string FirstName = txtBAddFirstName.Text;
                string LastName = txtBAddLastName.Text;
                string Email = txtBAddEmail.Text;
                string CountryName = cmboBAddCountry.Text;
                string PhoneNumber = txtBAddPhoneNumber.Text;
                DateTime BirthDate = dtBkrAddBirthDate.Value;
                string Gender = null;
                if (rBAddFemale.Checked) Gender = rBAddFemale.Text;
                if (rBAddMale.Checked) Gender = rBAddMale.Text;
                string Username = txtBAddUsername.Text;
                string Password = txtBAddPassword.Text;
                int Permissions = GetPermissionsForNewUser();
                if (BankUserService.Add(FirstName, LastName, Email, CountryName, PhoneNumber, BirthDate, Gender, Username, Password, Permissions))
                {
                    MessageBox.Show("User Added Successfully");
                    clearAddTabP();
                }
            }
        }

        private void clearUpdateTabP()
        {
            cmboBUsernamesForUpdate.SelectedIndex = -1;
            txtBUpdateFirstName.Clear();
            txtBUpdateLastName.Clear();
            txtBUpdateEmail.Clear();
            cmboBUpdateCountry.SelectedIndex = -1;
            txtBUpdatePhoneNumber.Clear();
            txtBUpdatePassword.Clear();
            rBUpdateAllPermissions.Checked = true;
            EnableUpdatePermissions(false);

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update this user?", "Confirm Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Username = cmboBUsernamesForUpdate.Text;
                string FirstName = txtBUpdateFirstName.Text;
                string LastName = txtBUpdateLastName.Text;
                string Email = txtBUpdateEmail.Text;
                string CountryName = cmboBUpdateCountry.Text;
                string PhoneNumber = txtBUpdatePhoneNumber.Text;
                string Password = txtBUpdatePassword.Text;
                int Permissions = GetPermissionsForUpdateUser();
                if (BankUserService.Update(Username, FirstName, LastName, Email, CountryName, PhoneNumber, Password, Permissions))
                {
                    MessageBox.Show("User Updated Successfully");
                    clearUpdateTabP();
                }
            }
        }

        private void clearDeleteTabP()
        {
            cmboBUsernamesForDelete.SelectedIndex = -1;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete this user?", "Confirm Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Username = cmboBUsernamesForDelete.Text;
                if (BankUserService.Delete(Username))
                {
                    MessageBox.Show("User Deleted Successfully");
                    clearDeleteTabP();
                }
            }
        }

        private void cmboBUsernames_Click(object sender, EventArgs e)
        {
            ((Guna2ComboBox)sender).DataSource = BankUserService.UsernamesList();
        }

        private void cmboBUsernamesForUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankUserComponent bankUserComponent = BankUserService.Component(cmboBUsernamesForUpdate.Text);
            txtBUpdateFirstName.Text = bankUserComponent.Person.FirstName;
            txtBUpdateLastName.Text = bankUserComponent.Person.LastName;
            txtBUpdateEmail.Text = bankUserComponent.Person.Email;
            Country country = CountryService.Find(bankUserComponent.Phone.CountryID);
            cmboBUpdateCountry.Text = country.CountryName;
            txtBUpdatePhoneCode.Text = country.PhoneCode;
            txtBUpdatePhoneNumber.Text = bankUserComponent.Phone.PhoneNumber;
            txtBUpdatePassword.Text = bankUserComponent.BankUser.Password;
            if (bankUserComponent.BankUser.Permissions == (int)Permissions.All)
            {
                rBUpdateAllPermissions.Checked = true;
            }
            else
            {
                rBUpdateSetPermissions.Checked = true;
                if (BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.ManageUsers)) tglUpdatePManageUsers.Checked = true;
                if (!BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.AddUsers)) chkBUpdatePAddUser.Checked = false;
                if (!BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.UpdateUsers)) chkBUpdatePUpdateUser.Checked = false;
                if (!BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.DeleteUsers)) chkBUpdatePDeleteUser.Checked = false;

                if (BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.ManageClients)) tglUpdatePManageClients.Checked = true;
                if (!BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.AddClients)) chkBUpdatePAddClient.Checked = false;
                if (!BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.UpdateClients)) chkBUpdatePUpdateClient.Checked = false;
                if (!BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.DeleteClients)) chkBUpdatePDeleteClient.Checked = false;

                if (BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.ManageCurrencies)) chkBUpdatePManageCurrencies.Checked = true;
                if (BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.DoTransactions)) chkBUpdatePDoTransactions.Checked = true;
                if (BankUserService.checkPermissions(bankUserComponent.BankUser, Permissions.ShowRegisters)) chkBUpdatePShowRegisters.Checked = true;
            }
        }
    }
}
