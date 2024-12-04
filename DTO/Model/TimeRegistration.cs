using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model {
    public class TimeRegistration {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string EmpInitials { get; set; }
        public Employee Employee { get; set; }
        public int TaskId { get; set; }
        public int RegId { get; set; }

        public TimeRegistration() { }
        public TimeRegistration(DateTime start, DateTime end, string empInitials, int taskId, int regId)
        {
            Start = start;
            End = end;
            EmpInitials = empInitials;
            TaskId = taskId;
            RegId = regId;
        }
    }
}
