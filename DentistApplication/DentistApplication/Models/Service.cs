using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApplication.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string ServiceName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool Euro { get; set; }
        [MaxLength(5)]
        public string? IsEuroText => Euro ? "euro" : "ден";

        public override string ToString()
        {
            return $"{ServiceName} - { Price} {IsEuroText}";
        }

    }
}
