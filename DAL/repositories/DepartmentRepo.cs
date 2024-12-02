using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Mapper;

namespace DAL.Repositories
{
    public class DepartmentRepo
    {
        public static List<DTO.Model.Department> getAllDepartments()
        {
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                List<Model.Department> dalDepartments = new List<Model.Department>();
                foreach (var dep in context.Departments)
                {
                    dalDepartments.Add(dep);
                }
                return DepartmentMapper.MapList(dalDepartments);
            }
        }
    }
}
