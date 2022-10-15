namespace ManagementBranch
{
    public partial class FormCreateManagementBranch : Form
    {
        Data _data;

        public FormCreateManagementBranch()
        {
            InitializeComponent();
            _data = new Data();
        }

        private void tbxManagementBranchName_TextChanged(object sender, EventArgs e)
        {
            lblManagementBranchName.Text = "Yönetim Şubesinin Adı:";
            lblManagementBranchName.Text = lblManagementBranchName.Text + " " + tbxManagementBranchName.Text;
        }

        private void btnNameConfirm_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Onaylıyor musunuz? Geri Alamazsınız!", "Onay Penceresi", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                lblManagementBranchName.Enabled = false;
                tbxManagementBranchName.Enabled = false;
                _data.Name = tbxManagementBranchName.Text;
            }
        }
    }
}