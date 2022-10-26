using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManagementBranchUI
{
    public partial class FormCreateManagementBranch : Form
    {
        public FormCreateManagementBranch()
        {
            InitializeComponent();
        }

        private void tbxManagementBranchName_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblManagementBranchName, tbxManagementBranchName);
        }

        private void tbxManagementBranchID_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblManagementBranchID, tbxManagementBranchID);
        }

        private void btnConfirmManagementBranch_Click(object sender, EventArgs e)
        {
            ConfirmDataControl
                (
                btnConfirmManagementBranch,
                tabController,
                tabCompanyManagers,
                tbxManagementBranchID,
                tbxManagementBranchName
                );
        }

        private void tbxManagementTCIN_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblDirectorTCIN, tbxDirectorTCIN);
        }

        private void tbxManagementName_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblDirectorName, tbxDirectorName);
        }

        private void tbxManagementSurname_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblDirectorSurname, tbxDirectorSurname);
        }

        private void tbxManagementMobilePhone_TextChanged(object sender, EventArgs e)
        {
            SetLabelText (lblDirectorMobilePhone, tbxDirectorMobilePhone);
        }

        private void tbxManagementEMail_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblDirectorEMail, tbxDirectorEMail);
        }

        private void btnCreateManagementPassword_Click(object sender, EventArgs e)
        {
            tbxDirectorPassword.Text = CreatePassword(btnCreateDirectorPassword);
        }

        private void tbxLawyerTCIN_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblLawyerTCIN, tbxLawyerTCIN);
        }

        private void tbxLawyerName_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblLawyerName, tbxLawyerName);
        }

        private void tbxLawyerSurname_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblLawyerSurname, tbxLawyerSurname);
        }

        private void tbxLawyerMobilePhone_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblLawyerMobilePhone, tbxLawyerMobilePhone);
        }

        private void tbxLawyerEMail_TextChanged(object sender, EventArgs e)
        {
            SetLabelText(lblLawyerEMail, tbxLawyerEMail);
        }

        private void btnCreateLawyerPassword_Click(object sender, EventArgs e)
        {
            tbxLawyerPassword.Text = CreatePassword(btnCreateLawyerPassword);
        }

        private void btnConfirmManagement_Click(object sender, EventArgs e)
        {
            ConfirmDataControl
                (
                btnConfirmManagement, 
                tabController, 
                tabCompanyManagers, 
                tbxDirectorTCIN, 
                tbxDirectorName, 
                tbxDirectorSurname, 
                tbxDirectorMobilePhone, 
                tbxDirectorEMail, 
                tbxDirectorPassword,
                tbxLawyerTCIN,
                tbxLawyerName,
                tbxLawyerSurname,
                tbxLawyerMobilePhone,
                tbxLawyerEMail,
                tbxLawyerPassword
                );
        }

        // Girilen verileri onaylama fonksiyonu
        private void ConfirmData(params TextBox[] tbx)
        {
            DialogResult confirmResult = MessageBox.Show(SetConfirmMessage(), "Onay Penceresi", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foreach (TextBox item in tbx)
                {
                    item.Enabled = false;
                }
            }

            tabController.SelectedTab.BackColor = Color.LightGreen;
        }

        // Girilmemiş veri tespit etme fonksiyonu
        private bool ControlEmptyData(params TextBox[] tbx)
        {
            foreach (TextBox item in tbx)
            {
                if (item.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        // Onaylama mesajı oluşturma fonksiyonu
        private string SetConfirmMessage()
        {
            string confirmMessage = "";

            if (tabController.SelectedTab == tabBranchNameAndID)
            {
                confirmMessage = 
                    $"\"{tbxManagementBranchID.Text}\" ID'sini ve " +
                    $"\"{tbxManagementBranchName.Text}\" ismini " +
                    "onaylıyor musunuz? Geri alamazsınız!";
            }

            if (tabController.SelectedTab == tabCompanyManagers)
            {
                confirmMessage =
                    "Şirket Müdürü için: \n" +
                    $"\"{tbxDirectorTCIN.Text}\" TCKN'sunu, " +
                    $"\"{tbxDirectorName.Text}\" adını, " +
                    $"\"{tbxDirectorSurname.Text}\" soyadını, " +
                    $"\"{tbxDirectorMobilePhone.Text}\" cep telefonunu, " +
                    $"\"{tbxDirectorEMail.Text}\" e-postasını ve " +
                    $"\"{tbxDirectorPassword.Text}\" şifresini " +
                    "\n Şirket Avukatı için: \n" +
                    $"\"{tbxLawyerTCIN.Text}\" TCKN'sunu, " +
                    $"\"{tbxLawyerName.Text}\" adını, " +
                    $"\"{tbxLawyerSurname.Text}\" soyadını, " +
                    $"\"{tbxLawyerMobilePhone.Text}\" cep telefonunu, " +
                    $"\"{tbxLawyerEMail.Text}\" e-postasını ve " +
                    $"\"{tbxLawyerPassword.Text}\" şifresini " +
                    "onaylıyor musunuz? Geri alamazsınız!";
            }

            return confirmMessage;
        }

        // Girilen değerleri Label ile kullanıcıya gösterme fonksiyonu
        private void SetLabelText(Label lbl, TextBox tbx)
        {
            lbl.Text = tbx.Text;
        }

        // 6 haneli rastgele şifre oluşturma fonksiyonu
        private string CreatePassword(Button btn)
        {
            string password = "";
            string charactersForPassword = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";

            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                password += charactersForPassword[random.Next(charactersForPassword.Length)];
            }

            btn.Enabled = false;

            return password;
        }

        // Girilen verileri onaylama kontrolü fonksiyonu
        private void ConfirmDataControl(Button btn, TabControl tabController, TabPage tabPage, params TextBox[] tbx)
        {
            if (!ControlEmptyData(tbx))
            {
                MessageBox.Show("Lütfen gerekli değerleri giriniz.");
            }
            else
            {
                ConfirmData(tbx);
                btn.Enabled = false;
                tabController.SelectedTab = tabPage;
            }
        }

        // Yönetim Şubesi için veri elde etme fonksiyonu
        public ManagementBranchData.ManagementBranchData CreatManagementBranchData()
        {
            ManagementBranchData.ManagementBranchData managementBranchData = new ManagementBranchData.ManagementBranchData();

            managementBranchData.ID = tbxManagementBranchID.Text;
            managementBranchData.ManagementBranchName = tbxManagementBranchName.Text;

            ManagementBranchData.ManagementData directorData = new ManagementBranchData.ManagementData();
            ManagementBranchData.ManagementData lawyerData = new ManagementBranchData.ManagementData();
            directorData.TCIN = tbxDirectorTCIN.Text;
            directorData.BranchID = tbxManagementBranchID.Text;
            directorData.Position = "Şube Müdürü";
            directorData.Name = tbxDirectorName.Text;
            directorData.Surname = tbxDirectorSurname.Text;
            directorData.MobilePhone = tbxDirectorMobilePhone.Text;
            directorData.EMail = tbxDirectorEMail.Text;
            directorData.Password = tbxDirectorPassword.Text;
            lawyerData.TCIN = tbxLawyerTCIN.Text;
            lawyerData.BranchID = tbxManagementBranchID.Text;
            lawyerData.Position = "Şirket Avukatı";
            lawyerData.Name = tbxLawyerName.Text;
            lawyerData.Surname = tbxLawyerSurname.Text;
            lawyerData.MobilePhone = tbxLawyerMobilePhone.Text;
            lawyerData.EMail = tbxLawyerEMail.Text;
            lawyerData.Password = tbxLawyerPassword.Text;

            managementBranchData.Director = directorData;
            managementBranchData.Lawyer = lawyerData;

            return managementBranchData;
        }
    }
}
