using POTZProjektZaliczeniowy.Data;
using POTZProjektZaliczeniowy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POTZProjektZaliczeniowy.Form
{
    public partial class AddCompanyForm : System.Windows.Forms.Form
    {
        MainForm mainForm;
        public AddCompanyForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            AddCompanyToDatabase(txtBoxCompanyName.Text, txtBoxNIP.Text);
            mainForm.RefreshCompanyGridView();
            this.Close();
        }

        private void AddCompanyToDatabase(string companyName, string nIP)
        {
            using (var dbContext = new CompanyContext())
            {
                Company company = new Company()
                {
                    CompanyName = companyName,
                    NIP = nIP
                };
                dbContext.Companies.Add(company);
                dbContext.SaveChanges();
            }
        }

        private void AddCompanyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
