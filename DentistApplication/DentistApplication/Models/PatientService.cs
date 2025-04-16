using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApplication.Models
{
    public class PatientService
    {
        public Guid Id { get; set; }
        public String ServiceName { get; set; }
        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
        public String? ServiceDescription { get; set; }
        public int? Price { get; set; }
        public int? PricePaid { get; set; }
        public DateTime Date { get; set; }
        public bool Done { get; set; }
    }
}
