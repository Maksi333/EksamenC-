using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Model {
    public class TimeRegistration {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        [ForeignKey("Employee")]
        public string EmpInitials { get; set; }
        public Employee Employee { get; set; }
        public int TaskId { get; set; }
        [Key]
        public int RegID { get; set; }

        public TimeRegistration() { }
        public TimeRegistration(DateTime start, DateTime end, string empInitials, int taskId, int regID) {
            Start = start;
            End = end;
            EmpInitials = empInitials;
            TaskId = taskId;
            RegID = regID;
        }
        public override string ToString()
        {
            return $"TaskID: {TaskId} TimeReg: {RegID}";
        }
    }

}
