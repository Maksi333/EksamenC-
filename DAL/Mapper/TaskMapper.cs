using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;

namespace DAL.Mapper {
    internal class TaskMapper {
        public static DTO.Model.Task MapFromDalToDTO(Task task) {
            if(task != null) {
                return new DTO.Model.Task(task.TaskId, task.Title, task.Description, task.DepID);
            }
            else {
                return null;
            }

        }

        public static List<DTO.Model.Task> MapDALListToDTO(List<Task> allTasks)
        {
            List<DTO.Model.Task> listDTO = new List<DTO.Model.Task>();
            if (allTasks != null && allTasks.Count > 0)
            {
                foreach (Task task in allTasks)
                {
                    listDTO.Add(new DTO.Model.Task(task.TaskId, task.Title, task.Description, task.DepID));
                }
                return listDTO;
            }
            else
            {
                return null;
            }
        }

        internal static Task FromDTOToDAL(DTO.Model.Task task)
        {
            if(task == null)
            {
                return null;
            }
            else
            {
                return new DAL.Model.Task(task.TaskId,task.Title, task.Description, task.DepID);
            }
        }
    }
}
