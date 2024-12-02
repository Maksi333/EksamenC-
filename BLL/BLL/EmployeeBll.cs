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
        public static void CreateEmployee(string initials, int cpr, string name)
        {
            Employee employee = new Employee(initials, cpr, name);
            EmployeeRepo.AddEmployee(employee);
        }
    }
}
