namespace POTZProjektZaliczeniowy.Form
{
    partial class AddCompanyForm
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
            this.CompanyName = new System.Windows.Forms.Label();
            this.NIP = new System.Windows.Forms.Label();
            this.txtBoxCompanyName = new System.Windows.Forms.TextBox();
            this.txtBoxNIP = new System.Windows.Forms.TextBox();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(12, 21);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(91, 15);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "CompanyName";
            // 
            // NIP
            // 
            this.NIP.AutoSize = true;
            this.NIP.Location = new System.Drawing.Point(12, 63);
            this.NIP.Name = "NIP";
            this.NIP.Size = new System.Drawing.Size(26, 15);
            this.NIP.TabIndex = 1;
            this.NIP.Text = "NIP";
            // 
            // txtBoxCompanyName
            // 
            this.txtBoxCompanyName.Location = new System.Drawing.Point(119, 18);
            this.txtBoxCompanyName.Name = "txtBoxCompanyName";
            this.txtBoxCompanyName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCompanyName.TabIndex = 2;
            // 
            // txtBoxNIP
            // 
            this.txtBoxNIP.Location = new System.Drawing.Point(119, 55);
            this.txtBoxNIP.Name = "txtBoxNIP";
            this.txtBoxNIP.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNIP.TabIndex = 3;
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(12, 106);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompany.TabIndex = 4;
            this.btnAddCompany.Text = "btnAddCompany";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(93, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 144);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.txtBoxNIP);
            this.Controls.Add(this.txtBoxCompanyName);
            this.Controls.Add(this.NIP);
            this.Controls.Add(this.CompanyName);
            this.Name = "AddCompanyForm";
            this.Text = "AddCompanyForm";
            this.Load += new System.EventHandler(this.AddCompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Label NIP;
        private System.Windows.Forms.TextBox txtBoxCompanyName;
        private System.Windows.Forms.TextBox txtBoxNIP;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnClose;
    }
}