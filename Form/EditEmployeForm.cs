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
    public partial class EditEmployeForm : System.Windows.Forms.Form
    {
        MainForm mainForm;
        Employe editedEmploye;
        public EditEmployeForm(MainForm mainForm, Employe employe)
        {
            this.mainForm = mainForm;
            this.editedEmploye = employe;
            InitializeComponent();
            FillComboBoxData();
            FillemployeData(editedEmploye);
            
        }
        void FillemployeData(Employe employe)
        {
            txtBoxEmployeId.Text = employe.EmployeID.ToString();
            txtBoxEmployeFirstName.Text = employe.FristName;
            txtBoxEmployeLastName.Text = employe.LastName;
            txtBoxEmployeEmail.Text = employe.Email;
            if (employe.Company != null)
            {
                comboBoxEmployeCompany.SelectedItem = employe.Company;

            }else if(employe.Company == null)
            {
                comboBoxEmployeCompany.SelectedItem = null;
            }

        }
        void FillComboBoxData()
        {
            using (var dbContext = new CompanyContext())
            {           
                List<Company> company = dbContext.Companies.ToList();
                comboBoxEmployeCompany.DataSource = company;
                comboBoxEmployeCompany.ValueMember = "CompanyID";
                comboBoxEmployeCompany.DisplayMember = "CompanyName";
            }
        }
        private void EditEmploye(Employe employe)
        {
           

            using (CompanyContext dbcontext = new CompanyContext())
            {
                employe.FristName = txtBoxEmployeFirstName.Text;
                employe.LastName = txtBoxEmployeLastName.Text;
                employe.Email = txtBoxEmployeEmail.Text;
                employe.Company = (Company)comboBoxEmployeCompany.SelectedItem;
                dbcontext.Employes.Update(employe);
                dbcontext.SaveChanges();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditEmploye(editedEmploye);
            mainForm.RefreshEmployeGridView();
            this.Close();
        }

       
    }
}
