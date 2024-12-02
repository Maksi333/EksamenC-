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
    }
}
