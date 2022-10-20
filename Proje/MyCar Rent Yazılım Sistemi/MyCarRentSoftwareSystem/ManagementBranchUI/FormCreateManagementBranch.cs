using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManagementBranchUI
{
    public partial class FormCreateManagementBranch : Form
    {
        ManagementBranchData.ManagementBranchData _data;

        #region BranchNameAndIDSettings
        public FormCreateManagementBranch()
        {
            InitializeComponent();
            _data = new ManagementBranchData.ManagementBranchData();
        }

        private void tbxManagementBranchName_TextChanged(object sender, EventArgs e)
        {
            lblManagementBranchName.Text = tbxManagementBranchName.Text;
        }

        private void tbxManagementBranchID_TextChanged(object sender, EventArgs e)
        {
            lblManagementBranchID.Text = tbxManagementBranchID.Text;
        }

        private void btnConfirmManagementBranchNameAndID_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(setConfirmMessage(), "Şube İsmi ve ID'si Onay Penceresi", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                tabBranchName.BackColor = Color.LightGreen;

                lblManagementBranchName.Enabled = false;
                tbxManagementBranchName.Enabled = false;
                lblManagementBranchID.Enabled = false;
                tbxManagementBranchID.Enabled = false;

                btnConfirmManagementBranchNameAndID.Enabled = false;

                _data.ID = tbxManagementBranchID.Text;
                _data.ManagementBranchName = tbxManagementBranchName.Text;
                
                tabController.SelectedTab = tabCompanyManagers;
            }
        }

        private string setConfirmMessage()
        {
            string confirmMessage = $"\"{tbxManagementBranchName.Text}\" ismini ve \"{tbxManagementBranchID.Text}\" ID'sini onaylıyor musunuz? Geri Alamazsınız!";
            return confirmMessage;
        }

        #endregion

        //todo Şirket Yönetimi ekleme ekran tasarımı yapılıp veriler elde edilecek.
    }
}
