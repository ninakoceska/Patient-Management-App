using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace DentistApplication
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PatientService> PatientServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DentDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
