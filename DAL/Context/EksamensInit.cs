using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL.Context {
    internal class EksamensInit : CreateDatabaseIfNotExists<EksamensContext>{
        protected override void Seed(EksamensContext context) {
            Department dep1 = new DAL.Model.Department("The Northern Department", 1);
            Department dep2 = new DAL.Model.Department("The Eastern Department", 2);
            Department dep3 = new DAL.Model.Department("The Southern Department", 3);
            Employee employee = new Employee("sna", 11111111, "Bob", 1);
            Employee employee2 = new Employee("bnb", 22222222, "Danny", 1);
            Employee employee3 = new Employee("msa",33333333, "Misha", 1);
            Employee employee4 = new Employee("bab", 44444444, "Baby", 3);
            TimeRegistration t1 = new TimeRegistration(new DateTime(2024, 11, 9, 9, 0, 0), new DateTime(2024, 11, 9, 16, 0, 0), "sna", 1, 1);
            TimeRegistration t2 = new TimeRegistration(new DateTime(2024, 12, 9, 9, 0, 0), new DateTime(2024, 12, 9, 16, 0, 0), "bnb", 1, 2);
            TimeRegistration t3 = new TimeRegistration(new DateTime(2024, 10, 9, 9, 0, 0), new DateTime(2024, 10, 9, 16, 0, 0), "msa", 1, 1);
            context.Employees.Add(employee);
            context.Employees.Add(employee2);
            context.Employees.Add(employee3);
            context.Employees.Add(employee4);
            context.Departments.Add(dep1);
            context.Departments.Add(dep2);
            context.Departments.Add(dep3);
            context.Tasks.Add(new DAL.Model.Task(1, "Task1", "DescTask1", 1));
            context.TimeRegistrations.Add(t1);
            context.TimeRegistrations.Add(t2);
            context.TimeRegistrations.Add(t3);
            context.SaveChanges();
        }
        private void dummy() {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }

    }
}
