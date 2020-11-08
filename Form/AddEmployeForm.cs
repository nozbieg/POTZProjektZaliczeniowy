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
    public partial class AddEmployeForm : System.Windows.Forms.Form
    {
        public AddEmployeForm()
        {
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
            AddEmloyeToDatabase(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text);
        }

        private void AddEmloyeToDatabase(string firstName, string lastName, string email)
        {
            using (var dbContext = new CompanyContext())
            {


                Employe employe = new Employe()
                {
                    FristName = firstName,
                    LastName = lastName,
                    Email = email
                };

                dbContext.Employes.Add(employe);

                dbContext.SaveChanges();
            }
            
            this.Close();
        }

        private void AddEmployeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
