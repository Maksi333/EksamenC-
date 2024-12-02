using DAL.Repositories;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL {
    public class DepartmentBll {

        public static List<DTO.Model.Department> GetAllDepartents()
        {
            List<Department> departments = DepartmentRepo.getAllDepartments();
            return departments;
        }
        
    }
}
