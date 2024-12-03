using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model {
    public class Employee {
        public string Initials { get; set; }
        public string Name { get; set; }
        [Key]
        public int Cpr { get; set; }
        public Department Department { get; set; }
        
        public int DepartmentID { get; set; }

        public List<TimeRegistration> TimeRegs { get; set; }

        public Employee() { }

        public Employee(string initials, int cpr, string name)
        {
            Initials = initials;
            Cpr = cpr;
            Name = name;
        }
        public override string ToString()
        {
            return Name + Cpr;
        }
        public override string ToString()
        {
            return Name + Cpr;
        }
    }
}
