namespace POTZProjektZaliczeniowy.Form
{
    partial class EditEmployeForm
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
            this.EmployeID = new System.Windows.Forms.Label();
            this.EmployeFirstName = new System.Windows.Forms.Label();
            this.EmployeLastName = new System.Windows.Forms.Label();
            this.EmployeEmail = new System.Windows.Forms.Label();
            this.EmployeCompany = new System.Windows.Forms.Label();
            this.txtBoxEmployeId = new System.Windows.Forms.TextBox();
            this.txtBoxEmployeFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxEmployeLastName = new System.Windows.Forms.TextBox();
            this.comboBoxEmployeCompany = new System.Windows.Forms.ComboBox();
            this.txtBoxEmployeEmail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeID
            // 
            this.EmployeID.AutoSize = true;
            this.EmployeID.Location = new System.Drawing.Point(62, 17);
            this.EmployeID.Name = "EmployeID";
            this.EmployeID.Size = new System.Drawing.Size(64, 15);
            this.EmployeID.TabIndex = 0;
            this.EmployeID.Text = "EmployeID";
            this.EmployeID.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeFirstName
            // 
            this.EmployeFirstName.AutoSize = true;
            this.EmployeFirstName.Location = new System.Drawing.Point(19, 46);
            this.EmployeFirstName.Name = "EmployeFirstName";
            this.EmployeFirstName.Size = new System.Drawing.Size(107, 15);
            this.EmployeFirstName.TabIndex = 1;
            this.EmployeFirstName.Text = "EmployeFirstName";
            // 
            // EmployeLastName
            // 
            this.EmployeLastName.AutoSize = true;
            this.EmployeLastName.Location = new System.Drawing.Point(20, 75);
            this.EmployeLastName.Name = "EmployeLastName";
            this.EmployeLastName.Size = new System.Drawing.Size(106, 15);
            this.EmployeLastName.TabIndex = 2;
            this.EmployeLastName.Text = "EmployeLastName";
            // 
            // EmployeEmail
            // 
            this.EmployeEmail.AutoSize = true;
            this.EmployeEmail.Location = new System.Drawing.Point(44, 104);
            this.EmployeEmail.Name = "EmployeEmail";
            this.EmployeEmail.Size = new System.Drawing.Size(82, 15);
            this.EmployeEmail.TabIndex = 3;
            this.EmployeEmail.Text = "EmployeEmail";
            // 
            // EmployeCompany
            // 
            this.EmployeCompany.AutoSize = true;
            this.EmployeCompany.Location = new System.Drawing.Point(21, 133);
            this.EmployeCompany.Name = "EmployeCompany";
            this.EmployeCompany.Size = new System.Drawing.Size(105, 15);
            this.EmployeCompany.TabIndex = 4;
            this.EmployeCompany.Text = "EmployeCompany";
            // 
            // txtBoxEmployeId
            // 
            this.txtBoxEmployeId.Location = new System.Drawing.Point(144, 14);
            this.txtBoxEmployeId.Name = "txtBoxEmployeId";
            this.txtBoxEmployeId.ReadOnly = true;
            this.txtBoxEmployeId.Size = new System.Drawing.Size(192, 23);
            this.txtBoxEmployeId.TabIndex = 5;
            // 
            // txtBoxEmployeFirstName
            // 
            this.txtBoxEmployeFirstName.Location = new System.Drawing.Point(144, 43);
            this.txtBoxEmployeFirstName.Name = "txtBoxEmployeFirstName";
            this.txtBoxEmployeFirstName.Size = new System.Drawing.Size(192, 23);
            this.txtBoxEmployeFirstName.TabIndex = 6;
            // 
            // txtBoxEmployeLastName
            // 
            this.txtBoxEmployeLastName.Location = new System.Drawing.Point(144, 72);
            this.txtBoxEmployeLastName.Name = "txtBoxEmployeLastName";
            this.txtBoxEmployeLastName.Size = new System.Drawing.Size(192, 23);
            this.txtBoxEmployeLastName.TabIndex = 7;
            // 
            // comboBoxEmployeCompany
            // 
            this.comboBoxEmployeCompany.FormattingEnabled = true;
            this.comboBoxEmployeCompany.Location = new System.Drawing.Point(144, 130);
            this.comboBoxEmployeCompany.Name = "comboBoxEmployeCompany";
            this.comboBoxEmployeCompany.Size = new System.Drawing.Size(192, 23);
            this.comboBoxEmployeCompany.TabIndex = 8;
            // 
            // txtBoxEmployeEmail
            // 
            this.txtBoxEmployeEmail.Location = new System.Drawing.Point(144, 101);
            this.txtBoxEmployeEmail.Name = "txtBoxEmployeEmail";
            this.txtBoxEmployeEmail.Size = new System.Drawing.Size(192, 23);
            this.txtBoxEmployeEmail.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(102, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditEmployeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 217);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxEmployeEmail);
            this.Controls.Add(this.comboBoxEmployeCompany);
            this.Controls.Add(this.txtBoxEmployeLastName);
            this.Controls.Add(this.txtBoxEmployeFirstName);
            this.Controls.Add(this.txtBoxEmployeId);
            this.Controls.Add(this.EmployeCompany);
            this.Controls.Add(this.EmployeEmail);
            this.Controls.Add(this.EmployeLastName);
            this.Controls.Add(this.EmployeFirstName);
            this.Controls.Add(this.EmployeID);
            this.Name = "EditEmployeForm";
            this.Text = "EditEmployeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeID;
        private System.Windows.Forms.Label EmployeFirstName;
        private System.Windows.Forms.Label EmployeLastName;
        private System.Windows.Forms.Label EmployeEmail;
        private System.Windows.Forms.Label EmployeCompany;
        private System.Windows.Forms.TextBox txtBoxEmployeId;
        private System.Windows.Forms.TextBox txtBoxEmployeFirstName;
        private System.Windows.Forms.TextBox txtBoxEmployeLastName;
        private System.Windows.Forms.ComboBox comboBoxEmployeCompany;
        private System.Windows.Forms.TextBox txtBoxEmployeEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}