using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper {
    public class EmployeeMapper
    {
        public static DTO.Model.Employee MapFromDALToDTO(Employee employee)
        {
            if (employee == null)
            {
                return null;
            }
            else
            {
                return new DTO.Model.Employee(employee.Initials, employee.Cpr, employee.Name, DepartmentMapper.MapDALToDTO(employee.Department));
            }
        }

        public static List<DTO.Model.Employee> MapAllFromDalToDto(List<Employee> dalEmployees)
        {
            List<DTO.Model.Employee> employees = new List<DTO.Model.Employee>();
            if(dalEmployees != null && dalEmployees.Count > 0)
            {
                foreach(var employee in dalEmployees)
                {
                    employees.Add(new DTO.Model.Employee(employee.Initials, employee.Cpr, employee.Name, DepartmentMapper.MapDALToDTO(employee.Department)));
                }
                return employees;
            }
            else
            {
                return null;
            }
        }
    }
}
