using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApplication.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{ServiceName} - { Price}";
        }

    }
}
