using DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repositories
{

    public class TaskRepo
    {
        public static DTO.Model.Task GetTask(int id)
        {
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                Model.Task taskDAL = context.Tasks.Find(id);
                var taskDTO = Mapper.TaskMapper.MapFromDalToDTO(taskDAL);
                return taskDTO;
            }
        }
        public static List<DTO.Model.Task> GetAllTasks()
        {
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                List<DAL.Model.Task> allTasks = context.Tasks.ToList();
                var taskListDTO = Mapper.TaskMapper.MapDALListToDTO(allTasks);
                return taskListDTO;
            }
        }

        public static void AddTask(DTO.Model.Task task)
        {
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                DAL.Model.Task dalTask = TaskMapper.FromDTOToDAL(task);
                context.Tasks.Add(dalTask);
                context.SaveChanges();
            }
            
            
        }
    }
}