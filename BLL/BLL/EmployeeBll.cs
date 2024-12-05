using System;
using System.Collections.Generic;
using DAL.Repositories;
using DTO.Model;

namespace BLL.BLL {
    public class EmployeeBll {

        public static Employee GetEmplyee(string initials)
        {
            if (initials == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                return EmployeeRepo.GetEmployee(initials);
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
        
        public static double GetHoursWeek(string empInitials)
        {
            double total = 0;
            DateTime oneWeekAgo = DateTime.Now.AddDays(-7);
            List<TimeRegistration> registrations = new List<TimeRegistration>();
            registrations = TimeRegRepo.GetTimeRegsForEmp(empInitials);

            foreach(var reg in registrations)
            {
                if(reg.Start > oneWeekAgo)
                {
                    TimeSpan timeDiff = reg.End - reg.Start;
                    total += timeDiff.TotalHours;
                }
            }
            return total;
        }
        public static double GetHoursMonth(string empInitials)
        {
            double total = 0;
            DateTime oneMonthAgo = DateTime.Now.AddMonths(-1);
            List<TimeRegistration> registrations = new List<TimeRegistration>();
            registrations = TimeRegRepo.GetTimeRegsForEmp(empInitials);

            foreach (var reg in registrations)
            {
                if (reg.Start > oneMonthAgo)
                {
                    TimeSpan timeDiff = reg.End - reg.Start;
                    total += timeDiff.TotalHours;
                }
            }
            return total;
        }
        public static double GetHoursTotal(string empInitials)
        {
            double total = 0;
            List<TimeRegistration> registrations = new List<TimeRegistration>();
            registrations = TimeRegRepo.GetTimeRegsForEmp(empInitials);

            foreach (var reg in registrations)
            {
                TimeSpan timeDiff = reg.End - reg.Start;
                total += timeDiff.TotalHours;
            }
            return total;
        }
        public static List<TimeRegistration> GetTimeRegs(string empInitials)
        {
            List<TimeRegistration > registrations = new List<TimeRegistration>();
            registrations = TimeRegRepo.GetTimeRegsForEmp(empInitials);
            return registrations;
            
        }
    }
}
