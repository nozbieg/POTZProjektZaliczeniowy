
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
            optionsBuilder.EnableSensitiveDataLogging(true);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany<Employe>(e => e.Employes)
                .WithOne(e => e.Company)
                .OnDelete(DeleteBehavior.SetNull);

        }

        
    }
}
