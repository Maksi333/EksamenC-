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
    }
}
