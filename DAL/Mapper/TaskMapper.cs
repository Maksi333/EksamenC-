using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;

namespace DAL.Mapper {
    internal class TaskMapper {
        public static DTO.Model.Task MapFromDalToDTO(Task task) {
            if(task != null) {
                return new DTO.Model.Task(task.TaskId, task.Title, task.Description, DepartmentMapper.MapDALToDTO(task.Department));
            }
            else {
                return null;
            }

        }
    }
}
