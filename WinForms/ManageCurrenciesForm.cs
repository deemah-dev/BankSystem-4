using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using SystemBusiness;
using SystemModules;

namespace WinForms
{
    public partial class ManageCurrenciesForm : Form
    {
        public ManageCurrenciesForm(BankUser bankUser)
        {
            InitializeComponent();
            currentUser = bankUser;
        }
        BankUser currentUser = null;

        private void ctrlTabCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ctrlTabCurrencies.SelectedTab == tabPCurrenciesList)
            {
                grdVCurrenciesList.DataSource = CurrencyService.Table();
                return;
            }   
        }

        private void clearAddTabP()
        {
            txtBAddCurrencyName.Clear();
            txtBAddCurrencyRate.Clear();
            cmboBAddCountriesNames.SelectedIndex = -1;
        }

        private void btnAddCurrency_Click(object sender, EventArgs e)
        {
            string CurrencyName = txtBAddCurrencyName.Text;
            decimal CurrencyRate = Convert.ToDecimal(txtBAddCurrencyRate.Text);
            string CountryName = cmboBAddCountriesNames.Text;
            if(CurrencyService.Add(CurrencyName, CurrencyRate, CountryName))
            {
                MessageBox.Show("Currency Added Successfully");
                clearAddTabP();
            }
        }

        private void clearUpdateTabP()
        {
            cmboBCurrenciesCodesForUpdate.SelectedIndex = -1;
            txtBNewRate.Clear();
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            string CurrencyCode = cmboBCurrenciesCodesForUpdate.Text;
            decimal NewRate = Convert.ToDecimal(txtBNewRate.Text);
            if (CurrencyService.UpdateRate(CurrencyCode, NewRate))
            {
                MessageBox.Show("Rate Updated Successfully");
                clearUpdateTabP();
            }
        }

        private void clearDeleteTabP()
        {
            cmboBCurrenciesCodeForDelete.SelectedIndex = -1;
        }

        private void btnDeleteCurrency_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this currency?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CurrencyService.DeleteCurrency(cmboBCurrenciesCodeForDelete.Text))
                {
                    MessageBox.Show("Currency Deleted Successfully");
                    clearDeleteTabP();
                }
            }
        }

        private void cmboBAddCountriesNames_Click(object sender, EventArgs e)
        {
            cmboBAddCountriesNames.DataSource = CountryService.CountriesNamesList();
        }

        private void cmboBCurrenciesCodes_Click(object sender, EventArgs e)
        {
            ((Guna2ComboBox)sender).DataSource = CountryService.CountriesCodesList();
        }
    }
}
