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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CompaniesPage = new System.Windows.Forms.TabPage();
            this.EmployesPage = new System.Windows.Forms.TabPage();
            this.EmployeListView = new System.Windows.Forms.ListView();
            this.EmployeFirstName = new System.Windows.Forms.ColumnHeader();
            this.EmployeLastName = new System.Windows.Forms.ColumnHeader();
            this.EmployeEmail = new System.Windows.Forms.ColumnHeader();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.EmployesPage.SuspendLayout();
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
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CompaniesPage);
            this.tabControl1.Controls.Add(this.EmployesPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 397);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // CompaniesPage
            // 
            this.CompaniesPage.Location = new System.Drawing.Point(4, 24);
            this.CompaniesPage.Name = "CompaniesPage";
            this.CompaniesPage.Padding = new System.Windows.Forms.Padding(3);
            this.CompaniesPage.Size = new System.Drawing.Size(589, 369);
            this.CompaniesPage.TabIndex = 0;
            this.CompaniesPage.Text = "Companies";
            this.CompaniesPage.UseVisualStyleBackColor = true;
            this.CompaniesPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // EmployesPage
            // 
            this.EmployesPage.Controls.Add(this.EmployeListView);
            this.EmployesPage.Location = new System.Drawing.Point(4, 24);
            this.EmployesPage.Name = "EmployesPage";
            this.EmployesPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployesPage.Size = new System.Drawing.Size(589, 369);
            this.EmployesPage.TabIndex = 1;
            this.EmployesPage.Text = "EmployesPage";
            this.EmployesPage.UseVisualStyleBackColor = true;
            // 
            // EmployeListView
            // 
            this.EmployeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeFirstName,
            this.EmployeLastName,
            this.EmployeEmail});
            this.EmployeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeListView.FullRowSelect = true;
            this.EmployeListView.GridLines = true;
            this.EmployeListView.HideSelection = false;
            this.EmployeListView.Location = new System.Drawing.Point(3, 3);
            this.EmployeListView.Name = "EmployeListView";
            this.EmployeListView.Size = new System.Drawing.Size(583, 363);
            this.EmployeListView.TabIndex = 0;
            this.EmployeListView.UseCompatibleStateImageBehavior = false;
            // 
            // EmployeFirstName
            // 
            this.EmployeFirstName.Text = "EmployeFirstName";
            // 
            // EmployeLastName
            // 
            this.EmployeLastName.Text = "EmployeLastName";
            // 
            // EmployeEmail
            // 
            this.EmployeEmail.Text = "EmployeEmail";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.btnAddEmploye);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.EmployesPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmploye;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CompaniesPage;
        private System.Windows.Forms.TabPage EmployesPage;
        private System.Windows.Forms.ListView EmployeListView;
        private System.Windows.Forms.ColumnHeader EmployeFirstName;
        private System.Windows.Forms.ColumnHeader EmployeLastName;
        private System.Windows.Forms.ColumnHeader EmployeEmail;
        private System.Windows.Forms.Button btnRefresh;
    }
}

