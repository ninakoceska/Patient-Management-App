using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistApplication.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DentistApplication
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PatientService> PatientServices { get; set; }

        public string dbPath;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var dbFilePath = Path.Combine(AppContext.BaseDirectory, "DentistAppDb.db");
            //string dbFilePath = Path.Combine(Application.StartupPath, "DentistAppDb.db");
            //optionsBuilder.UseSqlite($"Data Source=DentistAppDb.db");

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Directory.SetCurrentDirectory(baseDirectory);
            dbPath = Path.Combine(baseDirectory, "DentistAppDb.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");


            // Build absolute path


            base.OnConfiguring(optionsBuilder);


        }

        
     }
}
