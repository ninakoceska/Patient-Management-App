using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApplication.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
        [MaxLength(20)]
        public string? EMBG { get; set; }
        [MaxLength(40)]
        public string? EmailAddress { get; set; }
        [MaxLength(100)]
        public string? HomeAddress { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public virtual List<PatientService> PatientServices { get; set; } = new List<PatientService>();
    }
}
