using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class MixedDataBL
    {
        ProjectEntities db = new ProjectEntities();

        public List<MixedData> GetMixedDatas()
        {
            List<MixedData> Mixed = new List<MixedData>();
            foreach (var n in db.Employee)
            {
                MixedData mixed = new MixedData();
                mixed.ID = n.ID;
                mixed.FirstName = n.FirstName;
                mixed.LastName = n.LastName;
                mixed.StartWorkYear = n.StartWorkYear;
                mixed.DepartmentID = (int)n.DepartmentID;
                foreach (var noa in db.User.Where(x => x.ID == mixed.ID))
                {
                    mixed.NumOfActions = noa.NumOfActions;

                }

                foreach (var dep in db.Department.Where(x => x.ID == mixed.DepartmentID))
                {

                    mixed.DepartmentName = dep.Name;
                    mixed.Manger = dep.Manger;
                }

                foreach (var S in db.Shifts.Where(x => x.ID == mixed.ID))
                {
                    mixed.ShiftsID = S.ID;
                    mixed.Date = (DateTime)S.Date;
                    mixed.StartTime = (int)S.StartTime;
                    mixed.EndTime = (int)S.EndTime;
                }
                foreach (var ES in db.EmployeeShift.Where(x => x.ID == mixed.ShiftsID))
                {
                    mixed.StartTime = mixed.StartTime;
                    mixed.EndTime = mixed.EndTime;
                }


                Mixed.Add(mixed);

            }
            return Mixed;
        }
    }
}