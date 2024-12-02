using DAL.Mapper;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EmployeeRepo
    {
        public static DTO.Model.Employee GetEmployee(int cpr)
        {
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                Model.Employee employee = context.Employees.Find(cpr);
                var employeeDTO = Mapper.EmployeeMapper.MapFromDALToDTO(employee);
                return employeeDTO;
            }
        }
        public static List<DTO.Model.Employee> GetAllEmployees()
        {
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                List<Model.Employee> dalEmployees = new List<Model.Employee>();
                foreach (var emp in context.Employees)
                {
                    dalEmployees.Add(emp);
                }
                return EmployeeMapper.MapAllFromDalToDto(dalEmployees);
            }
        }
        public static void AddEmployee(DTO.Model.Employee employee)
        {
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                DAL.Model.Employee emp = EmployeeMapper.MapFromDTOToDAL(employee);
                context.Employees.Add(emp);
                context.SaveChanges();
            }
        }
    }
}
