namespace POTZProjektZaliczeniowy.Form
{
    partial class EditCompanyForm
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
            this.CompanyIndex = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.CompanyNIP = new System.Windows.Forms.Label();
            this.txtBoxCompanyId = new System.Windows.Forms.TextBox();
            this.txtBoxCompanyName = new System.Windows.Forms.TextBox();
            this.txtBoxCompanyNIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyIndex
            // 
            this.CompanyIndex.AutoSize = true;
            this.CompanyIndex.Location = new System.Drawing.Point(15, 14);
            this.CompanyIndex.Name = "CompanyIndex";
            this.CompanyIndex.Size = new System.Drawing.Size(88, 15);
            this.CompanyIndex.TabIndex = 0;
            this.CompanyIndex.Text = "CompanyIndex";
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(15, 41);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(91, 15);
            this.CompanyName.TabIndex = 1;
            this.CompanyName.Text = "CompanyName";
            // 
            // CompanyNIP
            // 
            this.CompanyNIP.AutoSize = true;
            this.CompanyNIP.Location = new System.Drawing.Point(15, 70);
            this.CompanyNIP.Name = "CompanyNIP";
            this.CompanyNIP.Size = new System.Drawing.Size(78, 15);
            this.CompanyNIP.TabIndex = 2;
            this.CompanyNIP.Text = "CompanyNIP";
            // 
            // txtBoxCompanyId
            // 
            this.txtBoxCompanyId.Location = new System.Drawing.Point(114, 11);
            this.txtBoxCompanyId.Name = "txtBoxCompanyId";
            this.txtBoxCompanyId.ReadOnly = true;
            this.txtBoxCompanyId.Size = new System.Drawing.Size(141, 23);
            this.txtBoxCompanyId.TabIndex = 3;
            // 
            // txtBoxCompanyName
            // 
            this.txtBoxCompanyName.Location = new System.Drawing.Point(114, 38);
            this.txtBoxCompanyName.Name = "txtBoxCompanyName";
            this.txtBoxCompanyName.Size = new System.Drawing.Size(141, 23);
            this.txtBoxCompanyName.TabIndex = 3;
            // 
            // txtBoxCompanyNIP
            // 
            this.txtBoxCompanyNIP.Location = new System.Drawing.Point(114, 67);
            this.txtBoxCompanyNIP.Name = "txtBoxCompanyNIP";
            this.txtBoxCompanyNIP.Size = new System.Drawing.Size(141, 23);
            this.txtBoxCompanyNIP.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(99, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EditCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 148);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxCompanyNIP);
            this.Controls.Add(this.txtBoxCompanyName);
            this.Controls.Add(this.txtBoxCompanyId);
            this.Controls.Add(this.CompanyNIP);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.CompanyIndex);
            this.Name = "EditCompanyForm";
            this.Text = "EditCompanyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyIndex;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Label CompanyNIP;
        private System.Windows.Forms.TextBox txtBoxCompanyId;
        private System.Windows.Forms.TextBox txtBoxCompanyName;
        private System.Windows.Forms.TextBox txtBoxCompanyNIP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}