using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApplication.Models
{
    public class PatientService
    {
        public Guid Id { get; set; }
        [MaxLength(100)]
        public String ServiceName { get; set; }
        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
        [MaxLength(500)]
        public String? ServiceDescription { get; set; }
        public DateTime Date { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public int? PricePaid { get; set; }
        public bool Euro { get; set; }
        public string IsEuroText => Euro ? "euro" : "ден";
        public bool Done { get; set; }
    }
}
