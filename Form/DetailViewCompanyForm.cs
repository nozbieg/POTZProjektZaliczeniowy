using Microsoft.EntityFrameworkCore;
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
    public partial class DetailViewCompanyForm : System.Windows.Forms.Form
    {
        MainForm mainForm;
        Company company;
        public DetailViewCompanyForm(MainForm mainForm, Company company)
        {
            this.mainForm = mainForm;
            this.company = company;
            InitializeComponent();
        }

        private void DetailViewCompanyForm_Load(object sender, EventArgs e)
        {


            LoadEmployeList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListViewEmployesOfCompany.SelectedItems != null)
            {
                var selectedEmployees = ListViewEmployesOfCompany.SelectedItems;
                foreach (ListViewItem empID in selectedEmployees)
                {
                    var id = Convert.ToInt32(empID.Text.ToString());
                    using (CompanyContext dbContext = new CompanyContext())
                    {
                        var findedEmploye = dbContext.Employes.Where(e => e.EmployeID == id)
                                                              .FirstOrDefault();
                        findedEmploye.Company = null;
                        findedEmploye.CompanyID = null;
                        dbContext.Employes.Update(findedEmploye);
                        dbContext.SaveChanges();
                    }

                }
            }
            LoadEmployeList();
        }

        private void LoadEmployeList()
        {
            CreateListAndColumns();

            using (CompanyContext dbContext = new CompanyContext())
            {
                List<Company> companyList = dbContext.Companies
                                    .Include(e => e.Employes)
                                    .Where(e => e.CompanyID == company.CompanyID)
                                    .ToList();
                foreach (var item in companyList)
                {
                    foreach (var employeData in item.Employes)
                    {
                        if (item.Employes != null)
                        {
                            string[] row = { employeData.EmployeID.ToString(), employeData.FristName, employeData.LastName, employeData.Email };
                            var listItem = new ListViewItem(row);
                            ListViewEmployesOfCompany.Items.Add(listItem);
                        }
                    }
                }
            }
           
        }
        private void CreateListAndColumns()
        {
            ListViewEmployesOfCompany.Clear();
            ListViewEmployesOfCompany.Columns.Add(new ColumnHeader()
            {
                Name = "EmployeID",
                Text = "Employe ID"
            });
            ListViewEmployesOfCompany.Columns.Add(new ColumnHeader()
            {
                Name = "EmployeFirstName",
                Text = "Employe FirstName"
            });
            ListViewEmployesOfCompany.Columns.Add(new ColumnHeader()
            {
                Name = "EmployeLastName",
                Text = "Employe LastName"
            });
            ListViewEmployesOfCompany.Columns.Add(new ColumnHeader()
            {
                Name = "EmployeEmail",
                Text = "Employe Email"
            });
            CompanyDetails.Text = company.CompanyName + " " + company.NIP;
            ListViewEmployesOfCompany.View = View.Details;

            ListViewEmployesOfCompany.Columns[0].Text = "Employe ID";
            ListViewEmployesOfCompany.Columns[1].Text = "Employe FirstName";
            ListViewEmployesOfCompany.Columns[2].Text = "Employe LastName";
            ListViewEmployesOfCompany.Columns[3].Text = "Employe Email";
            ListViewEmployesOfCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListViewEmployesOfCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            ListViewEmployesOfCompany.Refresh();

        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            DetailViewEmployesWOCompanyForm addEmployeFromListForm = new DetailViewEmployesWOCompanyForm(this, company);
            addEmployeFromListForm.ShowDialog();
            LoadEmployeList();
        }
    }
}
