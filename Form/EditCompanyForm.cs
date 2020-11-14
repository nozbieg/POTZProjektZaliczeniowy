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
    public partial class EditCompanyForm : System.Windows.Forms.Form
    {
        MainForm mainForm;
        Company editedCompany;
        
        public EditCompanyForm(MainForm mainForm, Company company)
        {
            this.mainForm = mainForm;
            this.editedCompany = company;
            InitializeComponent();
            FillCompanyData(company);
        }
        void EditCompany(Company company)
        {
            using (CompanyContext dbcontext = new CompanyContext())
            {
                company.CompanyName = txtBoxCompanyName.Text;
                company.NIP = txtBoxCompanyNIP.Text;
                dbcontext.Companies.Update(company);
                dbcontext.SaveChanges();
            }
        }
        private void FillCompanyData(Company company)
        {
            txtBoxCompanyId.Text = company.CompanyID.ToString();
            txtBoxCompanyName.Text = company.CompanyName;
            txtBoxCompanyNIP.Text = company.NIP.ToString();
        }
        private void DeleteCompany(Company company)
        {
            using (CompanyContext dbcontext = new CompanyContext())
            {
               
                dbcontext.Companies.Remove(company);
                dbcontext.SaveChanges();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            EditCompany(editedCompany);
            mainForm.RefreshCompanyGridView();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCompany(editedCompany);
            mainForm.RefreshCompanyGridView();
            this.Close();
        }
    }
}
