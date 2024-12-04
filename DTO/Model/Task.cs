using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model {
    public class Task {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DepID { get; set; }


        public Task() { }
        public Task(int id, string title, string description, int depID)
        {

            TaskId = id;
            Title = title;
            Description = description;
            DepID = depID;
        }
        public override string ToString() { return Title; }
    }
}
