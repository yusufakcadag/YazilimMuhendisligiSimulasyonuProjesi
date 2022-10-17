namespace ManagementBranchUI
{
    partial class FormCreateManagementBranch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabBranchName = new System.Windows.Forms.TabPage();
            this.tbxManagementBranchID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblManagementBranchID = new System.Windows.Forms.Label();
            this.tbxManagementBranchName = new System.Windows.Forms.TextBox();
            this.btnConfirmManagementBranchNameAndID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblManagementBranchName = new System.Windows.Forms.Label();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabCompanyManagers = new System.Windows.Forms.TabPage();
            this.tbxCompanyLawyerSurname = new System.Windows.Forms.TextBox();
            this.lblCompanyLawyerSurname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCompanyManagerSurname = new System.Windows.Forms.TextBox();
            this.lblCompanyManagerSurname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxCompanyLawyerName = new System.Windows.Forms.TextBox();
            this.lblCompanyLawyerName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCompanyManagerName = new System.Windows.Forms.TextBox();
            this.lblCompanyManagerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxCompanyLawyerTCIN = new System.Windows.Forms.TextBox();
            this.lblCompanyLawyerTCIN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCompanyManagerTCIN = new System.Windows.Forms.TextBox();
            this.lblCompanyManagerTCIN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabBranchName.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabCompanyManagers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBranchName
            // 
            this.tabBranchName.BackColor = System.Drawing.Color.Silver;
            this.tabBranchName.Controls.Add(this.tbxManagementBranchID);
            this.tabBranchName.Controls.Add(this.label3);
            this.tabBranchName.Controls.Add(this.lblManagementBranchID);
            this.tabBranchName.Controls.Add(this.tbxManagementBranchName);
            this.tabBranchName.Controls.Add(this.btnConfirmManagementBranchNameAndID);
            this.tabBranchName.Controls.Add(this.label1);
            this.tabBranchName.Controls.Add(this.lblManagementBranchName);
            this.tabBranchName.Location = new System.Drawing.Point(4, 28);
            this.tabBranchName.Name = "tabBranchName";
            this.tabBranchName.Padding = new System.Windows.Forms.Padding(3);
            this.tabBranchName.Size = new System.Drawing.Size(1152, 905);
            this.tabBranchName.TabIndex = 0;
            this.tabBranchName.Text = "Şube Adı Ve ID\'si";
            // 
            // tbxManagementBranchID
            // 
            this.tbxManagementBranchID.ForeColor = System.Drawing.Color.Green;
            this.tbxManagementBranchID.Location = new System.Drawing.Point(20, 175);
            this.tbxManagementBranchID.MaxLength = 4;
            this.tbxManagementBranchID.Name = "tbxManagementBranchID";
            this.tbxManagementBranchID.Size = new System.Drawing.Size(229, 26);
            this.tbxManagementBranchID.TabIndex = 6;
            this.tbxManagementBranchID.TextChanged += new System.EventHandler(this.tbxManagementBranchID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yönetim Şubesi ID:";
            // 
            // lblManagementBranchID
            // 
            this.lblManagementBranchID.AutoSize = true;
            this.lblManagementBranchID.ForeColor = System.Drawing.Color.Green;
            this.lblManagementBranchID.Location = new System.Drawing.Point(180, 125);
            this.lblManagementBranchID.Name = "lblManagementBranchID";
            this.lblManagementBranchID.Size = new System.Drawing.Size(69, 19);
            this.lblManagementBranchID.TabIndex = 5;
            this.lblManagementBranchID.Text = "Şube ID";
            // 
            // tbxManagementBranchName
            // 
            this.tbxManagementBranchName.ForeColor = System.Drawing.Color.Green;
            this.tbxManagementBranchName.Location = new System.Drawing.Point(20, 75);
            this.tbxManagementBranchName.MaxLength = 60;
            this.tbxManagementBranchName.Name = "tbxManagementBranchName";
            this.tbxManagementBranchName.Size = new System.Drawing.Size(269, 26);
            this.tbxManagementBranchName.TabIndex = 2;
            this.tbxManagementBranchName.TextChanged += new System.EventHandler(this.tbxManagementBranchName_TextChanged);
            // 
            // btnConfirmManagementBranchNameAndID
            // 
            this.btnConfirmManagementBranchNameAndID.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmManagementBranchNameAndID.Location = new System.Drawing.Point(20, 225);
            this.btnConfirmManagementBranchNameAndID.Name = "btnConfirmManagementBranchNameAndID";
            this.btnConfirmManagementBranchNameAndID.Size = new System.Drawing.Size(83, 35);
            this.btnConfirmManagementBranchNameAndID.TabIndex = 3;
            this.btnConfirmManagementBranchNameAndID.Text = "Onayla";
            this.btnConfirmManagementBranchNameAndID.UseVisualStyleBackColor = true;
            this.btnConfirmManagementBranchNameAndID.Click += new System.EventHandler(this.btnConfirmManagementBranchNameAndID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetim Şubesinin Adı:";
            // 
            // lblManagementBranchName
            // 
            this.lblManagementBranchName.AutoSize = true;
            this.lblManagementBranchName.ForeColor = System.Drawing.Color.Green;
            this.lblManagementBranchName.Location = new System.Drawing.Point(212, 25);
            this.lblManagementBranchName.Name = "lblManagementBranchName";
            this.lblManagementBranchName.Size = new System.Drawing.Size(77, 19);
            this.lblManagementBranchName.TabIndex = 1;
            this.lblManagementBranchName.Text = "Şube Adı";
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabBranchName);
            this.tabController.Controls.Add(this.tabCompanyManagers);
            this.tabController.Location = new System.Drawing.Point(12, 12);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1160, 937);
            this.tabController.TabIndex = 4;
            // 
            // tabCompanyManagers
            // 
            this.tabCompanyManagers.BackColor = System.Drawing.Color.Silver;
            this.tabCompanyManagers.Controls.Add(this.tbxCompanyLawyerSurname);
            this.tabCompanyManagers.Controls.Add(this.lblCompanyLawyerSurname);
            this.tabCompanyManagers.Controls.Add(this.label7);
            this.tabCompanyManagers.Controls.Add(this.tbxCompanyManagerSurname);
            this.tabCompanyManagers.Controls.Add(this.lblCompanyManagerSurname);
            this.tabCompanyManagers.Controls.Add(this.label10);
            this.tabCompanyManagers.Controls.Add(this.tbxCompanyLawyerName);
            this.tabCompanyManagers.Controls.Add(this.lblCompanyLawyerName);
            this.tabCompanyManagers.Controls.Add(this.label6);
            this.tabCompanyManagers.Controls.Add(this.tbxCompanyManagerName);
            this.tabCompanyManagers.Controls.Add(this.lblCompanyManagerName);
            this.tabCompanyManagers.Controls.Add(this.label8);
            this.tabCompanyManagers.Controls.Add(this.tbxCompanyLawyerTCIN);
            this.tabCompanyManagers.Controls.Add(this.lblCompanyLawyerTCIN);
            this.tabCompanyManagers.Controls.Add(this.label4);
            this.tabCompanyManagers.Controls.Add(this.tbxCompanyManagerTCIN);
            this.tabCompanyManagers.Controls.Add(this.lblCompanyManagerTCIN);
            this.tabCompanyManagers.Controls.Add(this.label2);
            this.tabCompanyManagers.Location = new System.Drawing.Point(4, 28);
            this.tabCompanyManagers.Name = "tabCompanyManagers";
            this.tabCompanyManagers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompanyManagers.Size = new System.Drawing.Size(1152, 905);
            this.tabCompanyManagers.TabIndex = 1;
            this.tabCompanyManagers.Text = "Şirket Yöneticileri";
            // 
            // tbxCompanyLawyerSurname
            // 
            this.tbxCompanyLawyerSurname.ForeColor = System.Drawing.Color.Green;
            this.tbxCompanyLawyerSurname.Location = new System.Drawing.Point(20, 575);
            this.tbxCompanyLawyerSurname.MaxLength = 15;
            this.tbxCompanyLawyerSurname.Name = "tbxCompanyLawyerSurname";
            this.tbxCompanyLawyerSurname.Size = new System.Drawing.Size(299, 26);
            this.tbxCompanyLawyerSurname.TabIndex = 18;
            // 
            // lblCompanyLawyerSurname
            // 
            this.lblCompanyLawyerSurname.AutoSize = true;
            this.lblCompanyLawyerSurname.ForeColor = System.Drawing.Color.Green;
            this.lblCompanyLawyerSurname.Location = new System.Drawing.Point(201, 525);
            this.lblCompanyLawyerSurname.Name = "lblCompanyLawyerSurname";
            this.lblCompanyLawyerSurname.Size = new System.Drawing.Size(118, 19);
            this.lblCompanyLawyerSurname.TabIndex = 17;
            this.lblCompanyLawyerSurname.Text = "Avukat Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Şirket Avukatı Soyadı:";
            // 
            // tbxCompanyManagerSurname
            // 
            this.tbxCompanyManagerSurname.ForeColor = System.Drawing.Color.Green;
            this.tbxCompanyManagerSurname.Location = new System.Drawing.Point(20, 475);
            this.tbxCompanyManagerSurname.MaxLength = 15;
            this.tbxCompanyManagerSurname.Name = "tbxCompanyManagerSurname";
            this.tbxCompanyManagerSurname.Size = new System.Drawing.Size(300, 26);
            this.tbxCompanyManagerSurname.TabIndex = 15;
            // 
            // lblCompanyManagerSurname
            // 
            this.lblCompanyManagerSurname.AutoSize = true;
            this.lblCompanyManagerSurname.ForeColor = System.Drawing.Color.Green;
            this.lblCompanyManagerSurname.Location = new System.Drawing.Point(205, 425);
            this.lblCompanyManagerSurname.Name = "lblCompanyManagerSurname";
            this.lblCompanyManagerSurname.Size = new System.Drawing.Size(115, 19);
            this.lblCompanyManagerSurname.TabIndex = 14;
            this.lblCompanyManagerSurname.Text = "Müdür Soyadı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Şirket Müdürü Soyadı:";
            // 
            // tbxCompanyLawyerName
            // 
            this.tbxCompanyLawyerName.ForeColor = System.Drawing.Color.Green;
            this.tbxCompanyLawyerName.Location = new System.Drawing.Point(20, 375);
            this.tbxCompanyLawyerName.MaxLength = 25;
            this.tbxCompanyLawyerName.Name = "tbxCompanyLawyerName";
            this.tbxCompanyLawyerName.Size = new System.Drawing.Size(242, 26);
            this.tbxCompanyLawyerName.TabIndex = 12;
            // 
            // lblCompanyLawyerName
            // 
            this.lblCompanyLawyerName.AutoSize = true;
            this.lblCompanyLawyerName.ForeColor = System.Drawing.Color.Green;
            this.lblCompanyLawyerName.Location = new System.Drawing.Point(172, 325);
            this.lblCompanyLawyerName.Name = "lblCompanyLawyerName";
            this.lblCompanyLawyerName.Size = new System.Drawing.Size(89, 19);
            this.lblCompanyLawyerName.TabIndex = 11;
            this.lblCompanyLawyerName.Text = "Avukat Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şirket Avukatı Adı:";
            // 
            // tbxCompanyManagerName
            // 
            this.tbxCompanyManagerName.ForeColor = System.Drawing.Color.Green;
            this.tbxCompanyManagerName.Location = new System.Drawing.Point(20, 275);
            this.tbxCompanyManagerName.MaxLength = 25;
            this.tbxCompanyManagerName.Name = "tbxCompanyManagerName";
            this.tbxCompanyManagerName.Size = new System.Drawing.Size(242, 26);
            this.tbxCompanyManagerName.TabIndex = 9;
            // 
            // lblCompanyManagerName
            // 
            this.lblCompanyManagerName.AutoSize = true;
            this.lblCompanyManagerName.ForeColor = System.Drawing.Color.Green;
            this.lblCompanyManagerName.Location = new System.Drawing.Point(176, 225);
            this.lblCompanyManagerName.Name = "lblCompanyManagerName";
            this.lblCompanyManagerName.Size = new System.Drawing.Size(86, 19);
            this.lblCompanyManagerName.TabIndex = 8;
            this.lblCompanyManagerName.Text = "Müdür Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Şirket Müdürü Adı:";
            // 
            // tbxCompanyLawyerTCIN
            // 
            this.tbxCompanyLawyerTCIN.ForeColor = System.Drawing.Color.Green;
            this.tbxCompanyLawyerTCIN.Location = new System.Drawing.Point(20, 175);
            this.tbxCompanyLawyerTCIN.MaxLength = 11;
            this.tbxCompanyLawyerTCIN.Name = "tbxCompanyLawyerTCIN";
            this.tbxCompanyLawyerTCIN.Size = new System.Drawing.Size(229, 26);
            this.tbxCompanyLawyerTCIN.TabIndex = 6;
            // 
            // lblCompanyLawyerTCIN
            // 
            this.lblCompanyLawyerTCIN.AutoSize = true;
            this.lblCompanyLawyerTCIN.ForeColor = System.Drawing.Color.Green;
            this.lblCompanyLawyerTCIN.Location = new System.Drawing.Point(194, 125);
            this.lblCompanyLawyerTCIN.Name = "lblCompanyLawyerTCIN";
            this.lblCompanyLawyerTCIN.Size = new System.Drawing.Size(55, 19);
            this.lblCompanyLawyerTCIN.TabIndex = 5;
            this.lblCompanyLawyerTCIN.Text = "TCKN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şirket Avukatı TCKN:";
            // 
            // tbxCompanyManagerTCIN
            // 
            this.tbxCompanyManagerTCIN.ForeColor = System.Drawing.Color.Green;
            this.tbxCompanyManagerTCIN.Location = new System.Drawing.Point(20, 75);
            this.tbxCompanyManagerTCIN.MaxLength = 11;
            this.tbxCompanyManagerTCIN.Name = "tbxCompanyManagerTCIN";
            this.tbxCompanyManagerTCIN.Size = new System.Drawing.Size(233, 26);
            this.tbxCompanyManagerTCIN.TabIndex = 3;
            // 
            // lblCompanyManagerTCIN
            // 
            this.lblCompanyManagerTCIN.AutoSize = true;
            this.lblCompanyManagerTCIN.ForeColor = System.Drawing.Color.Green;
            this.lblCompanyManagerTCIN.Location = new System.Drawing.Point(198, 25);
            this.lblCompanyManagerTCIN.Name = "lblCompanyManagerTCIN";
            this.lblCompanyManagerTCIN.Size = new System.Drawing.Size(55, 19);
            this.lblCompanyManagerTCIN.TabIndex = 2;
            this.lblCompanyManagerTCIN.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şirket Müdürü TCKN:";
            // 
            // FormCreateManagementBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.tabController);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreateManagementBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Şubesi Oluşturma";
            this.tabBranchName.ResumeLayout(false);
            this.tabBranchName.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.tabCompanyManagers.ResumeLayout(false);
            this.tabCompanyManagers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabBranchName;
        private TextBox tbxManagementBranchName;
        private Button btnConfirmManagementBranchNameAndID;
        private Label label1;
        private Label lblManagementBranchName;
        private TabControl tabController;
        private TabPage tabCompanyManagers;
        private Label label2;
        private Label lblCompanyManagerTCIN;
        private TextBox tbxCompanyManagerTCIN;
        private TextBox tbxCompanyLawyerTCIN;
        private Label lblCompanyLawyerTCIN;
        private Label label4;
        private TextBox tbxManagementBranchID;
        private Label label3;
        private Label lblManagementBranchID;
        private TextBox tbxCompanyLawyerName;
        private Label lblCompanyLawyerName;
        private Label label6;
        private TextBox tbxCompanyManagerName;
        private Label lblCompanyManagerName;
        private Label label8;
        private TextBox tbxCompanyLawyerSurname;
        private Label lblCompanyLawyerSurname;
        private Label label7;
        private TextBox tbxCompanyManagerSurname;
        private Label lblCompanyManagerSurname;
        private Label label10;
    }
}