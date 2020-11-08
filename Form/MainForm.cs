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
            using(var dbContext = new CompanyContext())
            {
   
                dbContext.Database.EnsureCreated();
                dbContext.Database.Migrate();

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            AddEmployeForm addEmployeForm = new AddEmployeForm();
            addEmployeForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshEmploteListView();
            EmployeListView.View = View.Details;         
        }

        public void RefreshEmploteListView()
        {
            EmployeListView.Items.Clear();
            using (var dbContext = new CompanyContext())
            {
                var list = dbContext.Employes.ToList();
                foreach(Employe e in list)
                {
                    string[] row = { e.FristName, e.LastName, e.Email };
                    ListViewItem item = new ListViewItem(row);
                    EmployeListView.Items.Add(item);

                }
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshEmploteListView();
        }
    }
}
