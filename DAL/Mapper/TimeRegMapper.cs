using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class TimeRegMapper
    {
        //Todo Create Mappers for both making timeregistrations and getting them.
        public static List<DTO.Model.TimeRegistration> MapFromDALToDTO(List<TimeRegistration> registrations)
        {
            List<DTO.Model.TimeRegistration> dtoList = new List<DTO.Model.TimeRegistration>();
            if (registrations != null && registrations.Count > 0)
            {
                foreach (var reg in registrations)
                {
                    dtoList.Add(new DTO.Model.TimeRegistration(reg.Start, reg.End, reg.EmpInitials, reg.TaskId, reg.RegID));
                }
            }
            return dtoList;
        }
    }
}
