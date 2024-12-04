using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DAL.Repositories;
using DTO.Model;

namespace BLL.BLL {
    public class EmployeeBll {

        public static Employee GetEmplyee(int cpr)
        {
            if (cpr > 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return EmployeeRepo.GetEmployee(cpr);
            }
            
        }
        public static List<DTO.Model.Employee> GetAllEmployees()
        {
            List<Employee> employees = EmployeeRepo.GetAllEmployees();
            return employees;
        }
        public static void CreateEmployee(string initials, int cpr, string name, int depNumber)
        {
            Employee employee = new Employee(initials, cpr, name, depNumber);
            EmployeeRepo.AddEmployee(employee);
        }

        /*
        public static double HoursWeek(Employee emp)
        {
            double hours = 0;
            DateTime oneWeekAgo = DateTime.Now.AddDays(-7);
            foreach(var t in emp.TimeRegs)
            {
                if(t.Start > oneWeekAgo)
                {
                    TimeSpan timeDiff = t.End - t.Start;
                    hours += timeDiff.Hours;
                }
            }
            return hours;
        }
        public static double HoursMonth(Employee emp)
        {
            double hours = 0;
            DateTime oneMonthAgo = DateTime.Now.AddMonths(-1);
            foreach (var t in emp.TimeRegs)
            {
                if (t.Start > oneMonthAgo)
                {
                    TimeSpan timeDiff = t.End - t.Start;
                    hours += timeDiff.Hours;
                }
            }
            return hours;
        }
        public static double HoursTotal(Employee emp)
        {
            double total = 0;
            foreach (var t in emp.TimeRegs)
            {
                TimeSpan timeDiff = t.End - t.Start;
                total += timeDiff.TotalHours;
            }
            return total;
        }
        */
    }
}
