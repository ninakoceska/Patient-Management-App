using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApplication.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EMBG { get; set; }
        public string? EmailAddress { get; set; }
        public string? HomeAddress { get; set; }
        public string? Description { get; set; }
        public virtual List<PatientService> PatientServices { get; set; } = new List<PatientService>();
    }
}
