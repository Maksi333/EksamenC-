using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model {
    internal class Task {
        
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Department Department { get; set; }

        public Task() { }
        public Task(int id, string title, string description, Department department) {
            
            TaskId = id;
            Title = title;
            Description = description;
            Department = department;
        }
    }
}
