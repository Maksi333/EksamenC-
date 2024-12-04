using DAL.Mapper;
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
        [Key]
        public string Name { get; set; }
        
        public int Cpr { get; set; }
        
        public Department Department { get; set; }
        //[ForeignKey("Department")]
        public int DepNumber { get; set; }

        public Employee() { }

        public Employee(string initials, int cpr, string name, int depNumber)
        {
            Initials = initials;
            Cpr = cpr;
            Name = name;
            DepNumber = depNumber;
        }
        public override string ToString()
        {
            return $"Name: ${Name}, + CPR: {Cpr}";
        }
    }
}
