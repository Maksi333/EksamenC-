using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model {
    public class Employee {
        public string Initials { get; set; }
        public string Name { get; set; }
        public int Cpr { get; set; }
        public Department Department { get; set; }

        public Employee() { }

        public Employee(string initials, int cpr, string name, Department department) {
            Initials = initials;
            Cpr = cpr;
            Name = name;
            Department = department;

        }
        public override string ToString()
        {
            return Name + Cpr;
        }
    }
}
