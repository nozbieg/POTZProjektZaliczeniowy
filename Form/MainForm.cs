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
        }

        public void RefreshCompanyGridView()
        {
            
            using (CompanyContext dbContext = new CompanyContext())
            {
                BindingSource source = new BindingSource();
                var query = from c in dbContext.Companies 
                            select new Company{ 
                                CompanyID = c.CompanyID,
                                CompanyName = c.CompanyName,
                                NIP = c.NIP };
                source.DataSource = query.ToList();
                companiesGridView.DataSource = source;
                companiesGridView.Refresh();
                companiesGridView.Columns[0].HeaderText = "CompanyID";
                companiesGridView.Columns[1].HeaderText = "CompanyName";
                companiesGridView.Columns[2].HeaderText = "NIP";
            }
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
               
                var selectedCompany = (Company)this.companiesGridView.CurrentRow.DataBoundItem;
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
                using (CompanyContext dbContext = new CompanyContext())
                {
                 var selectedCompany = (Company)this.companiesGridView.CurrentRow.DataBoundItem;
                 dbContext.Companies.Remove(selectedCompany);
                 dbContext.SaveChanges();
                 RefreshCompanyGridView();
                }
            }
            else if (mainTabControl.SelectedTab.Name == "EmployesPage")
            {
                using (CompanyContext dbContext = new CompanyContext())
                {
                    var selectedEmploye = (Employe)this.employesGridView.CurrentRow.DataBoundItem;
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
            BindingSource source = new BindingSource();
            string searchValue = txtBoxSearchField.Text;
            using (CompanyContext dbContext = new CompanyContext())
            {
                var query = from emp in dbContext.Employes
                            where emp.FristName.Contains(searchValue) 
                                || emp.LastName.Contains(searchValue)
                                || emp.Email.Contains(searchValue)
                                || emp.Company.CompanyName.Contains(searchValue)
                                || emp.Company.NIP.Contains(searchValue)
                            select new
                            {
                                emp.FristName,
                                emp.LastName,
                                emp.Email,
                                emp.Company.CompanyName,
                                emp.Company.NIP
                            };
                source.DataSource = query.ToList();
                employesGridView.DataSource = source;
                employesGridView.Refresh();
                
            }
        }
    } 
}

