using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBusiness;
using SystemModules;

namespace WinForms
{
    public partial class RegistersForm : Form
    {
        public RegistersForm()
        {
            InitializeComponent();
            grdVLoginRegister.DataSource = RegisterService.LoginRegisterTable();
        }

        private void ctrlTabReagisters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ctrlTabRegisters.SelectedTab == tabPLoginRegister)
            {
                grdVLoginRegister.DataSource = RegisterService.LoginRegisterTable();
                return;
            }
            if(ctrlTabRegisters.SelectedTab == tabPTransferRegister)
            {
                grdVTransferRegister.DataSource = RegisterService.TransferRegisterTable();
                return;
            }
            if(ctrlTabRegisters.SelectedTab == tabPPhoneRegisters)
            {
                grdVPhonesRegister.DataSource = RegisterService.PhoneRegisterTable();
                return;
            }
        }
    }
}