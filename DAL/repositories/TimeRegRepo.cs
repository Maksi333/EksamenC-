using DAL.Mapper;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TimeRegRepo
    {
        //Todo repo Method that gets all timeregistrations based on what employee made that timereg
        public static List<DTO.Model.TimeRegistration> GetTimeRegsForEmp(String empID)
        {
            List<TimeRegistration> registrations = new List<TimeRegistration>();
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                foreach (var reg in context.TimeRegistrations.Where(tr => tr.EmpInitials == empID))
                {
                    registrations.Add(reg);
                }
            }
            return TimeRegMapper.MapFromDALToDTO(registrations);
        }

        public static List<DTO.Model.TimeRegistration> getAllTimeRegs()
        {
            List<TimeRegistration> registrations = new List<TimeRegistration>();
            using(Context.EksamensContext context = new Context.EksamensContext())
            {
                foreach(var reg in context.TimeRegistrations)
                {
                    registrations.Add(reg);
                }
            }
            return TimeRegMapper.MapFromDALToDTO(registrations);
        }
        public static void UpdateTimeReg(DTO.Model.TimeRegistration timeReg, DateTime start, DateTime end)
        {
            using (Context.EksamensContext context = new Context.EksamensContext())
            {
                Model.TimeRegistration timeRegData = context.TimeRegistrations.Find(timeReg.RegID);
                TimeRegMapper.UpdateTimeReg(timeReg, timeRegData, start, end);
                context.SaveChanges();
            }
        }
    }
}
