﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model {
    public class TimeRegistration {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        [Key]
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Task Task { get; set; }

        public TimeRegistration() { }
        public TimeRegistration(DateTime start, DateTime end, int id, Employee employee, Task task) {
            Start = start;
            End = end;
            Id = id;
            Employee = employee;
            Task = task;
        }
    }

}
