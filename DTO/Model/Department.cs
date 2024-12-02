﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO.Model {
    public class Department {
        public string Name { get; set; }
        public int DepNumber { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Task> Tasks { get; set; } = new List<Task> { };

        public Department() { }
        public Department(string name, int depNumber) {
            Name = name;
            DepNumber = depNumber;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
