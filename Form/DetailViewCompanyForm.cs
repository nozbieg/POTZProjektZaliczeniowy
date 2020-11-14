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
            CompanyDetails.Text = company.CompanyName +" " + company.NIP;
            ListViewEmployesOfCompany.View = View.Details;
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
                            string[] row = { employeData.FristName, employeData.LastName, employeData.Email };
                            var listItem = new ListViewItem(row);
                            ListViewEmployesOfCompany.Items.Add(listItem);
                        }
                    }
                }
            }
            
            ListViewEmployesOfCompany.Columns[0].Text = "Employe FirstName";
            ListViewEmployesOfCompany.Columns[1].Text = "Employe LastName";
            ListViewEmployesOfCompany.Columns[2].Text = "Employe Email";
            ListViewEmployesOfCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListViewEmployesOfCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            ListViewEmployesOfCompany.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
