using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repositories;

namespace BLL.BLL
{
    public class TimeRegBll
    {
        public static void UpdateTimeReg(DTO.Model.TimeRegistration timeReg, DateTime start, DateTime end)
        {
            TimeRegRepo.UpdateTimeReg(timeReg, start, end);
        }
        
    }
}
