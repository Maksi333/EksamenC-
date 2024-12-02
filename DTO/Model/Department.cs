using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO.Model {
    public class Department {
        public string Name { get; set; }
        public int DepNumber { get; set; }

        public Department() { }
        public Department(string name, int depNumber) {
            Name = name;
            DepNumber = depNumber;
        }
    }
}
