using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper {
    internal class DepartmentMapper {
        public static DTO.Model.Department MapDALToDTO(Department department) {
            if(department != null) {
                return new DTO.Model.Department(department.Name, department.DepNumber);
            }
            else {
                return null;
            }
        }
        public static List<DTO.Model.Department> MapList(List<Department> departmentList)
        {
            List<DTO.Model.Department> departments = new List<DTO.Model.Department>();

            if(departmentList != null && departmentList.Count > 0)
            {
                foreach (var dep in departmentList)
                {
                    departments.Add(new DTO.Model.Department(dep.Name, dep.DepNumber));
                }
                return departments;
            }
            else
            {
                return null;
            }
        }
        public static DAL.Model.Department MapDTOToDAL(DTO.Model.Department department)
        {
            if (department != null)
            {
                return new Department(department.Name, department.DepNumber);
            }
            else
            {
                return null;
            }
        }
    }
}
