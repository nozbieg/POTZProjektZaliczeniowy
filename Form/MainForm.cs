using Microsoft.EntityFrameworkCore;
using POTZProjektZaliczeniowy.Data;
using POTZProjektZaliczeniowy.Form;
using POTZProjektZaliczeniowy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POTZProjektZaliczeniowy
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
            using (var dbContext = new CompanyContext())
            {
                //dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
                dbContext.Database.Migrate();

            }
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshEmployeGridView();
            RefreshCompanyGridView();


        }

        public void RefreshEmployeGridView()
        {
            using (CompanyContext dbContext = new CompanyContext())
            {
                BindingSource source = new BindingSource();
                var query = (from e in dbContext.Employes.Include("Company")

                             select new  {
                                 e.EmployeID,
                                 e.FristName,
                                 e.LastName,
                                 e.Email,                               
                                 e.Company.CompanyName,
                                 e.Company.NIP
                             });
                source.DataSource = query.ToList();
                employesGridView.DataSource = source;
                employesGridView.Refresh();
                employesGridView.Columns[0].HeaderText = "EmployeId";
                employesGridView.Columns[1].HeaderText = "FristName";
                employesGridView.Columns[2].HeaderText = "LastName";
                employesGridView.Columns[3].HeaderText = "Email";
                employesGridView.Columns[4].HeaderText = "Company";

               
                
            }
            txtBoxSearchField.Text = "";
        }

        public void RefreshCompanyGridView()
        {
            
            using (CompanyContext dbContext = new CompanyContext())
            {
                BindingSource source = new BindingSource();
                var query = from c in dbContext.Companies 
                            select new { 
                                c.CompanyID,
                                c.CompanyName,
                                c.NIP,
                                
                            };
                source.DataSource = query.ToList();
                companiesGridView.DataSource = source;
                companiesGridView.Refresh();
                companiesGridView.Columns[0].HeaderText = "CompanyID";
                companiesGridView.Columns[1].HeaderText = "CompanyName";
                companiesGridView.Columns[2].HeaderText = "NIP";
            }
            txtBoxSearchFieldCompany.Text = "";
        }
        private BindingSource SearchIn(string searchValue, string table)
        {
            BindingSource source = new BindingSource();
            using (CompanyContext dbContext = new CompanyContext())
            {
                if (table == "Employes")
                {
                    var convertedSearchValue = 0;
                    try
                    {
                        convertedSearchValue = Convert.ToInt32(searchValue);
                    }
                    catch(Exception ex)
                    {

                    }

                        var query = from emp in dbContext.Employes
                                    where emp.FristName.Contains(searchValue)
                                        || emp.LastName.Contains(searchValue)
                                        || emp.Email.Contains(searchValue)
                                        || emp.Company.CompanyName.Contains(searchValue)
                                        || emp.Company.NIP.Contains(searchValue)
                                        || emp.EmployeID == convertedSearchValue
                                    select new
                                    {
                                        emp.EmployeID,
                                        emp.FristName,
                                        emp.LastName,
                                        emp.Email,
                                        emp.Company.CompanyName,
                                        emp.Company.NIP
                                    };
                    source.DataSource = query.ToList();
                        
                }
                else if (table == "Companies")
                {
                    var query = from comp in dbContext.Companies
                                where comp.CompanyName.Contains(searchValue)
                                        || comp.NIP.Contains(searchValue)       
                                select new
                                {
                                    comp.CompanyID,
                                    comp.CompanyName,
                                    comp.NIP,
                                    
                                };
                    source.DataSource = query.ToList();
                }
            }
            return source;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            AddEmployeForm addEmployeForm = new AddEmployeForm(this);
            addEmployeForm.ShowDialog();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

       private void btnRefresh_Click(object sender, EventArgs e)
       {
            RefreshEmployeGridView();
            RefreshCompanyGridView();
       }

       private void btnAddCompany_Click(object sender, EventArgs e)
       {
           AddCompanyForm addCompanyForm = new AddCompanyForm(this);
           addCompanyForm.ShowDialog();
       }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            if(mainTabControl.SelectedTab.Name == "CompaniesPage")
            {
                Company selectedCompany;
                using (CompanyContext dbContext = new CompanyContext())
                {
                    var companyToEdit = Convert.ToInt32(this.companiesGridView.CurrentRow.Cells[0].Value);
                    selectedCompany = dbContext.Companies.Where(x => x.CompanyID == companyToEdit).SingleOrDefault();

                }
                
                EditCompanyForm editCompanyForm = new EditCompanyForm(this, selectedCompany);
                editCompanyForm.ShowDialog();
            }
            else if(mainTabControl.SelectedTab.Name == "EmployesPage")
            {
                Employe selectedEmploye;
                using (CompanyContext dbContext = new CompanyContext()) {
                    var employeToEdit = Convert.ToInt32(this.employesGridView.CurrentRow.Cells[0].Value);
                    selectedEmploye = dbContext.Employes.Where(x => x.EmployeID == employeToEdit).SingleOrDefault();
                   
                }
                EditEmployeForm editEmployeForm = new EditEmployeForm(this, selectedEmploye);
                editEmployeForm.ShowDialog();
            }
        }
      

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab.Name == "CompaniesPage")
            {
                Company selectedCompany;
                using (CompanyContext dbContext = new CompanyContext())
                {
                    var companyToEdit = Convert.ToInt32(this.companiesGridView.CurrentRow.Cells[0].Value);
                    selectedCompany = dbContext.Companies.Where(x => x.CompanyID == companyToEdit).SingleOrDefault();
                    dbContext.Companies.Remove(selectedCompany);
                 dbContext.SaveChanges();
                 RefreshCompanyGridView();
                }
            }
            else if (mainTabControl.SelectedTab.Name == "EmployesPage")
            {
                Employe selectedEmploye;
                using (CompanyContext dbContext = new CompanyContext())
                {
                    var employeToEdit = Convert.ToInt32(this.employesGridView.CurrentRow.Cells[0].Value);
                    selectedEmploye = dbContext.Employes.Where(x => x.EmployeID == employeToEdit).SingleOrDefault();
                    dbContext.Employes.Remove(selectedEmploye);
                    dbContext.SaveChanges();
                }
                RefreshEmployeGridView();
            }
        }

        private void mainTabControl_Click(object sender, EventArgs e)
        {
            RefreshEmployeGridView();
            RefreshCompanyGridView();
        }

        private void mainTabControl_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSearchField_TextChanged(object sender, EventArgs e)
        {
            
            string searchValue = txtBoxSearchField.Text;
            BindingSource source = SearchIn(searchValue, "Employes");
            employesGridView.DataSource = source;
            employesGridView.Refresh();
        }
       

        private void txtBoxSearchFieldCompany_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtBoxSearchFieldCompany.Text;
            BindingSource source = SearchIn(searchValue, "Companies");
            companiesGridView.DataSource = source;
            companiesGridView.Refresh(); 
        }

        private void companiesGridView_DoubleClick(object sender, EventArgs e)
        {
            Company selectedCompany;
            using (CompanyContext dbContext = new CompanyContext())
            {
                var companyToEdit = Convert.ToInt32(this.companiesGridView.CurrentRow.Cells[0].Value);
                selectedCompany = dbContext.Companies.Where(x => x.CompanyID == companyToEdit).SingleOrDefault();
            }   
                DetailViewCompanyForm detailViewCompanyForm = new DetailViewCompanyForm(this, selectedCompany);
            detailViewCompanyForm.ShowDialog();
        }
    } 
}

