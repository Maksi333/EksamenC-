using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repositories;
using System.Security.Cryptography;

namespace BLL.BLL
{
    public class TimeRegBll
    {
        public static void UpdateTimeReg(DTO.Model.TimeRegistration timeReg, DateTime start, DateTime end)
        {
            TimeRegRepo.UpdateTimeReg(timeReg, start, end);
        }
        public static void CreateTimeReg(DateTime start, DateTime end, string empInitials, int taskId)
        {
            List<DTO.Model.TimeRegistration> registrations = TimeRegRepo.getAllTimeRegs();
            int regID = registrations.Count;
            TimeRegistration timeRegistration = new TimeRegistration(start, end, empInitials, taskId, regID);
            TimeRegRepo.AddTimeReg(timeRegistration);
        }
    }
}
