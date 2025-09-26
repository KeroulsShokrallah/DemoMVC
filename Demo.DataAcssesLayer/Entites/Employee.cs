global using Demo.DataAcssesLayer.Entites.Enumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAcssesLayer.Entites
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string? Email { get; set; }
        public string?  PhoneNumber { get; set; }
        public DateTime HiriringDate { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }

    }
}
