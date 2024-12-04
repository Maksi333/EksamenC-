using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Repositories;
using DTO.Model;


namespace BLL.BLL {
    public class TaskBll {

        public static Task getTask(int id)
        {
            if(id < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return TaskRepo.GetTask(id);
            }
        }
        public static List<Task> getAllTasks()
        {
            List<Task> tasks = TaskRepo.GetAllTasks();
            return tasks;
           
        }

        public static void CreateTask(int id, string title, string description, int depID)
        {
            Task task = new Task(id, title, description, depID);
            TaskRepo.AddTask(task);
        }

        
    }
}
