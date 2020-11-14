using POTZProjektZaliczeniowy.Data;
using POTZProjektZaliczeniowy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POTZProjektZaliczeniowy.Form
{
    public partial class AddEmployeForm : System.Windows.Forms.Form
    {
        MainForm mainForm;
        public AddEmployeForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            AddEmloyeToDatabase(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, (Company)comboBoxCompany.SelectedItem);
            mainForm.RefreshEmployeGridView();
            this.Close();
        }

        private void AddEmloyeToDatabase(string firstName, string lastName, string email, Company company)
        {
            
            using (var dbContext = new CompanyContext())
            {

                if (comboBoxCompany.SelectedItem != null)
                {

                    var asignedCompany = (from comp in dbContext.Companies where comp.CompanyID == company.CompanyID select comp).ToList();
                    Employe employe = new Employe()
                    {
                        FristName = firstName,
                        LastName = lastName,
                        Email = email,
                        Company = asignedCompany[0]
                    };
                    dbContext.Employes.Add(employe);
                }
                else
                {
                    Employe employe = new Employe()
                    {
                        FristName = firstName,
                        LastName = lastName,
                        Email = email,
                        Company = null
                    };
                    dbContext.Employes.Add(employe);
                }
                
                dbContext.SaveChanges();
            }
            
        }

        private void AddEmployeForm_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        private void FillCombobox()
        {
            using (var dbContext = new CompanyContext())
            {
                List<Company> company = dbContext.Companies.ToList();
                comboBoxCompany.DataSource = company;
                comboBoxCompany.ValueMember = "CompanyId";
                comboBoxCompany.DisplayMember = "CompanyName";
            }
        }
    }
}
