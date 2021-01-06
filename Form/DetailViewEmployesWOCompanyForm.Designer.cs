namespace POTZProjektZaliczeniowy.Form
{
    partial class DetailViewEmployesWOCompanyForm
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
            this.ListViewEmployeesWOCompany = new System.Windows.Forms.ListView();
            this.lblEmployeList = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewEmployeesWOCompany
            // 
            this.ListViewEmployeesWOCompany.HideSelection = false;
            this.ListViewEmployeesWOCompany.Location = new System.Drawing.Point(12, 42);
            this.ListViewEmployeesWOCompany.Name = "ListViewEmployeesWOCompany";
            this.ListViewEmployeesWOCompany.Size = new System.Drawing.Size(301, 221);
            this.ListViewEmployeesWOCompany.TabIndex = 0;
            this.ListViewEmployeesWOCompany.UseCompatibleStateImageBehavior = false;
            // 
            // lblEmployeList
            // 
            this.lblEmployeList.AutoSize = true;
            this.lblEmployeList.Location = new System.Drawing.Point(12, 9);
            this.lblEmployeList.Name = "lblEmployeList";
            this.lblEmployeList.Size = new System.Drawing.Size(196, 15);
            this.lblEmployeList.TabIndex = 1;
            this.lblEmployeList.Text = "List of Employees without company";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(238, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddSelected
            // 
            this.btnAddSelected.Location = new System.Drawing.Point(157, 269);
            this.btnAddSelected.Name = "btnAddSelected";
            this.btnAddSelected.Size = new System.Drawing.Size(75, 23);
            this.btnAddSelected.TabIndex = 3;
            this.btnAddSelected.Text = "Add selected employes";
            this.btnAddSelected.UseVisualStyleBackColor = true;
            this.btnAddSelected.Click += new System.EventHandler(this.btnAddSelected_Click);
            // 
            // DetailViewEmployesWOCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 299);
            this.Controls.Add(this.btnAddSelected);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEmployeList);
            this.Controls.Add(this.ListViewEmployeesWOCompany);
            this.Name = "DetailViewEmployesWOCompanyForm";
            this.Text = "DetailViewEmployesWOCompanyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewEmployeesWOCompany;
        private System.Windows.Forms.Label lblEmployeList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddSelected;
    }
}