namespace POTZProjektZaliczeniowy
{
    partial class MainForm
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
            this.btnAddEmploye = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.CompaniesPage = new System.Windows.Forms.TabPage();
            this.companiesGridView = new System.Windows.Forms.DataGridView();
            this.EmployesPage = new System.Windows.Forms.TabPage();
            this.employesGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.CompaniesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesGridView)).BeginInit();
            this.EmployesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmploye
            // 
            this.btnAddEmploye.Location = new System.Drawing.Point(12, 415);
            this.btnAddEmploye.Name = "btnAddEmploye";
            this.btnAddEmploye.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmploye.TabIndex = 0;
            this.btnAddEmploye.Text = "btnAddEmploye";
            this.btnAddEmploye.UseVisualStyleBackColor = true;
            this.btnAddEmploye.Click += new System.EventHandler(this.btnAddEmploye_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(93, 415);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompany.TabIndex = 1;
            this.btnAddCompany.Text = "btnAddCompany";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.CompaniesPage);
            this.mainTabControl.Controls.Add(this.EmployesPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(597, 397);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // CompaniesPage
            // 
            this.CompaniesPage.Controls.Add(this.companiesGridView);
            this.CompaniesPage.Location = new System.Drawing.Point(4, 24);
            this.CompaniesPage.Name = "CompaniesPage";
            this.CompaniesPage.Padding = new System.Windows.Forms.Padding(3);
            this.CompaniesPage.Size = new System.Drawing.Size(589, 369);
            this.CompaniesPage.TabIndex = 0;
            this.CompaniesPage.Text = "Companies";
            this.CompaniesPage.UseVisualStyleBackColor = true;
            this.CompaniesPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // companiesGridView
            // 
            this.companiesGridView.AllowUserToAddRows = false;
            this.companiesGridView.AllowUserToDeleteRows = false;
            this.companiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companiesGridView.Location = new System.Drawing.Point(3, 3);
            this.companiesGridView.Name = "companiesGridView";
            this.companiesGridView.Size = new System.Drawing.Size(583, 363);
            this.companiesGridView.TabIndex = 0;
            this.companiesGridView.Text = "dataGridView1";
            // 
            // EmployesPage
            // 
            this.EmployesPage.Controls.Add(this.employesGridView);
            this.EmployesPage.Location = new System.Drawing.Point(4, 24);
            this.EmployesPage.Name = "EmployesPage";
            this.EmployesPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployesPage.Size = new System.Drawing.Size(589, 369);
            this.EmployesPage.TabIndex = 1;
            this.EmployesPage.Text = "EmployesPage";
            this.EmployesPage.UseVisualStyleBackColor = true;
            // 
            // employesGridView
            // 
            this.employesGridView.AllowUserToAddRows = false;
            this.employesGridView.AllowUserToDeleteRows = false;
            this.employesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employesGridView.Location = new System.Drawing.Point(3, 3);
            this.employesGridView.Name = "employesGridView";
            this.employesGridView.Size = new System.Drawing.Size(583, 363);
            this.employesGridView.TabIndex = 0;
            this.employesGridView.Text = "dataGridView1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(174, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(255, 415);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(75, 23);
            this.btnEditRecord.TabIndex = 4;
            this.btnEditRecord.Text = "btnEditRecord";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 454);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.btnAddEmploye);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.CompaniesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companiesGridView)).EndInit();
            this.EmployesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmploye;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage CompaniesPage;
        private System.Windows.Forms.TabPage EmployesPage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView companiesGridView;
        private System.Windows.Forms.DataGridView employesGridView;
        private System.Windows.Forms.Button btnEditRecord;
    }
}

