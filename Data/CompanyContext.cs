
using Microsoft.EntityFrameworkCore;
using POTZProjektZaliczeniowy.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;



namespace POTZProjektZaliczeniowy.Data
{
    public class CompanyContext : DbContext
    {

  
        public DbSet<Company> Companies { get; set; }

        public DbSet<Employe> Employes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Company.db");
            base.OnConfiguring(optionsBuilder);
        }

        
    
    }
}
