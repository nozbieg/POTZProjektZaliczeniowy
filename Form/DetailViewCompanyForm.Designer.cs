namespace POTZProjektZaliczeniowy.Form
{
    partial class DetailViewCompanyForm
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
            this.CompanyDetails = new System.Windows.Forms.Label();
            this.Employes = new System.Windows.Forms.Label();
            this.ListViewEmployesOfCompany = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.EmployeFirstName = new System.Windows.Forms.ColumnHeader();
            this.EmployeLastName = new System.Windows.Forms.ColumnHeader();
            this.EmployeEmail = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // CompanyDetails
            // 
            this.CompanyDetails.AutoSize = true;
            this.CompanyDetails.Location = new System.Drawing.Point(12, 9);
            this.CompanyDetails.Name = "CompanyDetails";
            this.CompanyDetails.Size = new System.Drawing.Size(94, 15);
            this.CompanyDetails.TabIndex = 0;
            this.CompanyDetails.Text = "CompanyDetails";
            // 
            // Employes
            // 
            this.Employes.AutoSize = true;
            this.Employes.Location = new System.Drawing.Point(12, 41);
            this.Employes.Name = "Employes";
            this.Employes.Size = new System.Drawing.Size(76, 15);
            this.Employes.TabIndex = 1;
            this.Employes.Text = "EmployesList";
            // 
            // ListViewEmployesOfCompany
            // 
            this.ListViewEmployesOfCompany.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeFirstName,
            this.EmployeLastName,
            this.EmployeEmail});
            this.ListViewEmployesOfCompany.HideSelection = false;
            this.ListViewEmployesOfCompany.Location = new System.Drawing.Point(12, 59);
            this.ListViewEmployesOfCompany.Name = "ListViewEmployesOfCompany";
            this.ListViewEmployesOfCompany.Size = new System.Drawing.Size(378, 284);
            this.ListViewEmployesOfCompany.TabIndex = 2;
            this.ListViewEmployesOfCompany.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(315, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DetailViewCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 380);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ListViewEmployesOfCompany);
            this.Controls.Add(this.Employes);
            this.Controls.Add(this.CompanyDetails);
            this.Name = "DetailViewCompanyForm";
            this.Text = "DetailViewCompanyForm";
            this.Load += new System.EventHandler(this.DetailViewCompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyDetails;
        private System.Windows.Forms.Label Employes;
        private System.Windows.Forms.ListView ListViewEmployesOfCompany;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader EmployeFirstName;
        private System.Windows.Forms.ColumnHeader EmployeLastName;
        private System.Windows.Forms.ColumnHeader EmployeEmail;
    }
}