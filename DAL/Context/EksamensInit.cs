using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL.Context {
    internal class EksamensInit : CreateDatabaseIfNotExists<EksamensContext>{
        protected override void Seed(EksamensContext context) {
            Department dep1 = new DAL.Model.Department("Department!", 1);
            context.Departments.Add(dep1);
            context.Tasks.Add(new DAL.Model.Task(1, "Task1", "DescTask1", dep1));

            context.SaveChanges();
        }
        private void dummy() {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }

    }
}
