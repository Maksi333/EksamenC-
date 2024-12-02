using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model {
    internal class Employee {
        public string Initials { get; set; }
        public string Name { get; set; }
        [Key]
        public int Cpr { get; set; }
        public Department Department { get; set; }

        public Employee() { }

        public Employee(string initials, int cpr, string name, Department department) { 
            Initials = initials;
            Cpr = cpr;
            Name = name;
            Department = department;

        }
    }
}
