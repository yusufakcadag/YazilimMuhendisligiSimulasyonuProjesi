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
            this.tbxManagementEMail = new System.Windows.Forms.TextBox();
            this.lblManagementEMail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnLawyer = new System.Windows.Forms.RadioButton();
            this.rbtnManager = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxManagementMobilePhone = new System.Windows.Forms.TextBox();
            this.lblManagementMobilePhone = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxManagementSurname = new System.Windows.Forms.TextBox();
            this.lblManagementSurname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxManagementName = new System.Windows.Forms.TextBox();
            this.lblManagementName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxManagementTCIN = new System.Windows.Forms.TextBox();
            this.lblManagementTCIN = new System.Windows.Forms.Label();
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
            this.tabCompanyManagers.Controls.Add(this.tbxManagementEMail);
            this.tabCompanyManagers.Controls.Add(this.lblManagementEMail);
            this.tabCompanyManagers.Controls.Add(this.label5);
            this.tabCompanyManagers.Controls.Add(this.rbtnLawyer);
            this.tabCompanyManagers.Controls.Add(this.rbtnManager);
            this.tabCompanyManagers.Controls.Add(this.label4);
            this.tabCompanyManagers.Controls.Add(this.tbxManagementMobilePhone);
            this.tabCompanyManagers.Controls.Add(this.lblManagementMobilePhone);
            this.tabCompanyManagers.Controls.Add(this.label12);
            this.tabCompanyManagers.Controls.Add(this.tbxManagementSurname);
            this.tabCompanyManagers.Controls.Add(this.lblManagementSurname);
            this.tabCompanyManagers.Controls.Add(this.label10);
            this.tabCompanyManagers.Controls.Add(this.tbxManagementName);
            this.tabCompanyManagers.Controls.Add(this.lblManagementName);
            this.tabCompanyManagers.Controls.Add(this.label8);
            this.tabCompanyManagers.Controls.Add(this.tbxManagementTCIN);
            this.tabCompanyManagers.Controls.Add(this.lblManagementTCIN);
            this.tabCompanyManagers.Controls.Add(this.label2);
            this.tabCompanyManagers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabCompanyManagers.Location = new System.Drawing.Point(4, 24);
            this.tabCompanyManagers.Name = "tabCompanyManagers";
            this.tabCompanyManagers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompanyManagers.Size = new System.Drawing.Size(1152, 909);
            this.tabCompanyManagers.TabIndex = 1;
            this.tabCompanyManagers.Text = "Şirket Yönetimi";
            // 
            // tbxManagementEMail
            // 
            this.tbxManagementEMail.ForeColor = System.Drawing.Color.Green;
            this.tbxManagementEMail.Location = new System.Drawing.Point(20, 575);
            this.tbxManagementEMail.MaxLength = 40;
            this.tbxManagementEMail.Name = "tbxManagementEMail";
            this.tbxManagementEMail.Size = new System.Drawing.Size(244, 26);
            this.tbxManagementEMail.TabIndex = 27;
            // 
            // lblManagementEMail
            // 
            this.lblManagementEMail.AutoSize = true;
            this.lblManagementEMail.ForeColor = System.Drawing.Color.Green;
            this.lblManagementEMail.Location = new System.Drawing.Point(101, 525);
            this.lblManagementEMail.Name = "lblManagementEMail";
            this.lblManagementEMail.Size = new System.Drawing.Size(69, 19);
            this.lblManagementEMail.TabIndex = 26;
            this.lblManagementEMail.Text = "E-Posta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "E-Posta:";
            // 
            // rbtnLawyer
            // 
            this.rbtnLawyer.AutoSize = true;
            this.rbtnLawyer.ForeColor = System.Drawing.Color.Blue;
            this.rbtnLawyer.Location = new System.Drawing.Point(199, 75);
            this.rbtnLawyer.Name = "rbtnLawyer";
            this.rbtnLawyer.Size = new System.Drawing.Size(130, 23);
            this.rbtnLawyer.TabIndex = 24;
            this.rbtnLawyer.TabStop = true;
            this.rbtnLawyer.Text = "Şirket Avukatı";
            this.rbtnLawyer.UseVisualStyleBackColor = true;
            // 
            // rbtnManager
            // 
            this.rbtnManager.AutoSize = true;
            this.rbtnManager.ForeColor = System.Drawing.Color.Blue;
            this.rbtnManager.Location = new System.Drawing.Point(20, 75);
            this.rbtnManager.Name = "rbtnManager";
            this.rbtnManager.Size = new System.Drawing.Size(134, 23);
            this.rbtnManager.TabIndex = 23;
            this.rbtnManager.TabStop = true;
            this.rbtnManager.Text = "Şirket Müdürü";
            this.rbtnManager.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Eklemek İstediğiniz Pozisyonu Seçiniz!\r\n";
            // 
            // tbxManagementMobilePhone
            // 
            this.tbxManagementMobilePhone.ForeColor = System.Drawing.Color.Green;
            this.tbxManagementMobilePhone.Location = new System.Drawing.Point(20, 475);
            this.tbxManagementMobilePhone.MaxLength = 11;
            this.tbxManagementMobilePhone.Name = "tbxManagementMobilePhone";
            this.tbxManagementMobilePhone.Size = new System.Drawing.Size(244, 26);
            this.tbxManagementMobilePhone.TabIndex = 21;
            // 
            // lblManagementMobilePhone
            // 
            this.lblManagementMobilePhone.AutoSize = true;
            this.lblManagementMobilePhone.ForeColor = System.Drawing.Color.Green;
            this.lblManagementMobilePhone.Location = new System.Drawing.Point(142, 425);
            this.lblManagementMobilePhone.Name = "lblManagementMobilePhone";
            this.lblManagementMobilePhone.Size = new System.Drawing.Size(110, 19);
            this.lblManagementMobilePhone.TabIndex = 20;
            this.lblManagementMobilePhone.Text = "Cep Telefonu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cep Telefonu:";
            // 
            // tbxManagementSurname
            // 
            this.tbxManagementSurname.ForeColor = System.Drawing.Color.Green;
            this.tbxManagementSurname.Location = new System.Drawing.Point(20, 375);
            this.tbxManagementSurname.MaxLength = 15;
            this.tbxManagementSurname.Name = "tbxManagementSurname";
            this.tbxManagementSurname.Size = new System.Drawing.Size(244, 26);
            this.tbxManagementSurname.TabIndex = 15;
            // 
            // lblManagementSurname
            // 
            this.lblManagementSurname.AutoSize = true;
            this.lblManagementSurname.ForeColor = System.Drawing.Color.Green;
            this.lblManagementSurname.Location = new System.Drawing.Point(94, 325);
            this.lblManagementSurname.Name = "lblManagementSurname";
            this.lblManagementSurname.Size = new System.Drawing.Size(58, 19);
            this.lblManagementSurname.TabIndex = 14;
            this.lblManagementSurname.Text = "Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Soyadı:";
            // 
            // tbxManagementName
            // 
            this.tbxManagementName.ForeColor = System.Drawing.Color.Green;
            this.tbxManagementName.Location = new System.Drawing.Point(20, 275);
            this.tbxManagementName.MaxLength = 25;
            this.tbxManagementName.Name = "tbxManagementName";
            this.tbxManagementName.Size = new System.Drawing.Size(244, 26);
            this.tbxManagementName.TabIndex = 9;
            // 
            // lblManagementName
            // 
            this.lblManagementName.AutoSize = true;
            this.lblManagementName.ForeColor = System.Drawing.Color.Green;
            this.lblManagementName.Location = new System.Drawing.Point(66, 225);
            this.lblManagementName.Name = "lblManagementName";
            this.lblManagementName.Size = new System.Drawing.Size(30, 19);
            this.lblManagementName.TabIndex = 8;
            this.lblManagementName.Text = "Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adı:";
            // 
            // tbxManagementTCIN
            // 
            this.tbxManagementTCIN.ForeColor = System.Drawing.Color.Green;
            this.tbxManagementTCIN.Location = new System.Drawing.Point(20, 175);
            this.tbxManagementTCIN.MaxLength = 11;
            this.tbxManagementTCIN.Name = "tbxManagementTCIN";
            this.tbxManagementTCIN.Size = new System.Drawing.Size(244, 26);
            this.tbxManagementTCIN.TabIndex = 3;
            // 
            // lblManagementTCIN
            // 
            this.lblManagementTCIN.AutoSize = true;
            this.lblManagementTCIN.ForeColor = System.Drawing.Color.Green;
            this.lblManagementTCIN.Location = new System.Drawing.Point(87, 125);
            this.lblManagementTCIN.Name = "lblManagementTCIN";
            this.lblManagementTCIN.Size = new System.Drawing.Size(55, 19);
            this.lblManagementTCIN.TabIndex = 2;
            this.lblManagementTCIN.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TCKN:";
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
        private Label lblManagementTCIN;
        private TextBox tbxManagementTCIN;
        private TextBox tbxManagementBranchID;
        private Label label3;
        private Label lblManagementBranchID;
        private TextBox tbxManagementName;
        private Label lblManagementName;
        private Label label8;
        private TextBox tbxManagementSurname;
        private Label lblManagementSurname;
        private Label label10;
        private TextBox tbxManagementMobilePhone;
        private Label lblManagementMobilePhone;
        private Label label12;
        private Label label4;
        private RadioButton rbtnLawyer;
        private RadioButton rbtnManager;
        private TextBox tbxManagementEMail;
        private Label lblManagementEMail;
        private Label label5;
    }
}