using POTZProjektZaliczeniowy.Data;
using POTZProjektZaliczeniowy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POTZProjektZaliczeniowy.Form
{
    public partial class DetailViewEmployesWOCompanyForm : System.Windows.Forms.Form
    {
        
        DetailViewCompanyForm detailViewCompanyForm;
        Company company;
        public DetailViewEmployesWOCompanyForm(DetailViewCompanyForm detailViewCompanyForm, Company company)
        {
            this.detailViewCompanyForm = detailViewCompanyForm;
            this.company = company;

            InitializeComponent();

            LoadListOfEmployessWOcompany();

        }

        private void LoadListOfEmployessWOcompany()
        {
            CreateColumns();

            using (CompanyContext dbContext = new CompanyContext())
            {
                List<Employe> employeList = dbContext.Employes.Where(e => e.Company == null && e.CompanyID == null)
                                                              .ToList();

                foreach (var item in employeList)
                {                 
                        if (item != null)
                        {
                            string[] row = { item.EmployeID.ToString(), item.FristName, item.LastName, item.Email };
                            var listItem = new ListViewItem(row);
                            ListViewEmployeesWOCompany.Items.Add(listItem);
                        }
                    
                }
            }
            ListViewEmployeesWOCompany.Refresh();
        }

        private void CreateColumns()
        {
            ListViewEmployeesWOCompany.Clear();
            ListViewEmployeesWOCompany.Columns.Add(new ColumnHeader()
            {
                Name = "EmployeID",
                Text = "Employe ID"
            });
            ListViewEmployeesWOCompany.Columns.Add(new ColumnHeader()
            {
                Name = "EmployeFirstName",
                Text = "Employe FirstName"
            });
            ListViewEmployeesWOCompany.Columns.Add(new ColumnHeader()
            {
                Name = "EmployeLastName",
                Text = "Employe LastName"
            });
            ListViewEmployeesWOCompany.Columns.Add(new ColumnHeader()
            {
                Name = "EmployeEmail",
                Text = "Employe Email"
            });           
            ListViewEmployeesWOCompany.View = View.Details;

            ListViewEmployeesWOCompany.Columns[0].Text = "Employe ID";                                 
            ListViewEmployeesWOCompany.Columns[1].Text = "Employe FirstName";                          
            ListViewEmployeesWOCompany.Columns[2].Text = "Employe LastName";                           
            ListViewEmployeesWOCompany.Columns[3].Text = "Employe Email";                              
            ListViewEmployeesWOCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);   
            ListViewEmployeesWOCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);      
            ListViewEmployeesWOCompany.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            if (ListViewEmployeesWOCompany.SelectedItems != null)
            {
                var selectedEmployees = ListViewEmployeesWOCompany.SelectedItems;
                foreach (ListViewItem empID in selectedEmployees)
                {
                    var id = Convert.ToInt32(empID.Text.ToString());
                    using (CompanyContext dbContext = new CompanyContext())
                    {
                        var findedEmploye = dbContext.Employes.Where(e => e.EmployeID == id)
                                                              .FirstOrDefault();
                        findedEmploye.Company = company;
                        findedEmploye.CompanyID = company.CompanyID;
                        dbContext.Employes.Update(findedEmploye);
                        dbContext.SaveChanges();
                    }

                }
            }
            LoadListOfEmployessWOcompany();
        }
    }
}
