using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EksamenC_.Models
{
    public class TimeRegVM
    {
        public string SelectedEmployeeInitials { get; set; }
        public List<SelectListItem> EmployeeList { get; set; }
        public string SelectedTaskName { get; set; }
        public List<SelectListItem> TaskList { get; set; }
        public DateTime SelectedStartTime { get; set; }
        public DateTime SelectedEndTime { get; set; }
    }

}