using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using SystemBusiness;
using SystemModules;

namespace WinForms
{
    public partial class TransactionsForm : Form
    {
        private BankUser currentUser;

        public TransactionsForm(BankUser bankUser)
        {
            InitializeComponent();
            currentUser = bankUser;
        }

        private void clearDepositTabP()
        {
            cmboBAccountsIdsForDeposit.SelectedIndex = -1;
            txtBDepositAmount.Clear();
        }

        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure about this operation?", "Confirm Deposit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(TransactionService.Deposit(Convert.ToInt32(cmboBAccountsIdsForDeposit.Text), Convert.ToDecimal(txtBDepositAmount.Text)))
                {
                    MessageBox.Show("Deposit Done Successfully");
                    clearDepositTabP();
                }
            }
        }

        private void clearWithdrawTabP()
        {
            cmboBAccountsIdsForWithdraw.SelectedIndex = -1;
            txtBWithdrawAmount.Clear();
        }

        private void btnConfirmWithdraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about this operation?", "Confirm Withdraw", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TransactionService.Withdraw(Convert.ToInt32(cmboBAccountsIdsForWithdraw.Text), Convert.ToDecimal(txtBWithdrawAmount.Text)))
                {
                    MessageBox.Show("Withdraw Done Successfully");
                    clearWithdrawTabP();
                }
            }
        }

        private void clearTransferTabP()
        {
            cmboBAccountsIdsForTransfer_Sender.SelectedIndex = -1;
            cmboBAccountsIdsForTransfer_Reciever.SelectedIndex = -1;
            txtBTransferAmount.Clear();
        }

        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about this operation?", "Confirm Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TransactionService.Transfer(Convert.ToInt32(cmboBAccountsIdsForTransfer_Sender.Text), Convert.ToInt32(cmboBAccountsIdsForTransfer_Reciever.Text), Convert.ToDecimal(txtBTransferAmount.Text)))
                {
                    MessageBox.Show("Transfer Done Successfully");
                    if (RegisterService.AddTransferRecord(Convert.ToInt32(cmboBAccountsIdsForTransfer_Sender.Text), Convert.ToInt32(cmboBAccountsIdsForTransfer_Reciever.Text), Convert.ToDecimal(txtBTransferAmount.Text), currentUser.ID, DateTime.Now))
                    {
                        MessageBox.Show("Added Record To Transfer Register Done Successfully");
                        clearTransferTabP();
                    }
                }
            }
        }

        private void cmboBAccountsIds_Click(object sender, EventArgs e)
        {
            ((Guna2ComboBox)sender).DataSource = AccountService.AccountsIDsList();
        }


    }
}
