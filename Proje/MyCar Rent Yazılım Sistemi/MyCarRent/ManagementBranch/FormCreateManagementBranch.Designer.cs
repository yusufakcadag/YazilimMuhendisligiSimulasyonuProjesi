namespace ManagementBranch
{
    partial class FormCreateManagementBranch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblManagementBranchName = new System.Windows.Forms.Label();
            this.tbxManagementBranchName = new System.Windows.Forms.TextBox();
            this.btnNameConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManagementBranchName
            // 
            this.lblManagementBranchName.AutoSize = true;
            this.lblManagementBranchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblManagementBranchName.ForeColor = System.Drawing.Color.Black;
            this.lblManagementBranchName.Location = new System.Drawing.Point(12, 9);
            this.lblManagementBranchName.Name = "lblManagementBranchName";
            this.lblManagementBranchName.Size = new System.Drawing.Size(186, 19);
            this.lblManagementBranchName.TabIndex = 0;
            this.lblManagementBranchName.Text = "Yönetim Şubesinin Adı:";
            // 
            // tbxManagementBranchName
            // 
            this.tbxManagementBranchName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxManagementBranchName.Location = new System.Drawing.Point(12, 49);
            this.tbxManagementBranchName.Name = "tbxManagementBranchName";
            this.tbxManagementBranchName.Size = new System.Drawing.Size(372, 26);
            this.tbxManagementBranchName.TabIndex = 1;
            this.tbxManagementBranchName.TextChanged += new System.EventHandler(this.tbxManagementBranchName_TextChanged);
            // 
            // btnNameConfirm
            // 
            this.btnNameConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNameConfirm.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNameConfirm.Location = new System.Drawing.Point(12, 96);
            this.btnNameConfirm.Name = "btnNameConfirm";
            this.btnNameConfirm.Size = new System.Drawing.Size(102, 44);
            this.btnNameConfirm.TabIndex = 2;
            this.btnNameConfirm.Text = "Onayla";
            this.btnNameConfirm.UseVisualStyleBackColor = true;
            this.btnNameConfirm.Click += new System.EventHandler(this.btnNameConfirm_Click);
            // 
            // FormCreateManagementBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.btnNameConfirm);
            this.Controls.Add(this.tbxManagementBranchName);
            this.Controls.Add(this.lblManagementBranchName);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormCreateManagementBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Şubesi Oluşturma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblManagementBranchName;
        private TextBox tbxManagementBranchName;
        private Button btnNameConfirm;
    }
}