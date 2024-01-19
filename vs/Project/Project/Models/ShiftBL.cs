using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class ShiftBL
    {
        ProjectEntities db = new ProjectEntities();

        public List<Shifts> GetAllShift()
        {
            return db.Shifts.ToList();
        }
        public Shifts GetShift(int id)
        {
            return db.Shifts.Where(x => x.ID == id).First();
        }
        public void AddShift(Shifts shift)
        {
            db.Shifts.Add(shift);
            db.SaveChanges();
        }
        public void Updateshift(int id, Shifts shift)
        {
            
            var s = db.Shifts.Where(x => x.ID == id).First();
            s.StartTime = shift.StartTime;
            s.EndTime = shift.EndTime;
            s.Date = shift.Date;   
            
          
            db.SaveChanges();

        }
        public void DeleteShift(int id)
        {
            var u = db.User.Where(x => x.ID == id).First();
            db.User.Remove(u);
            db.SaveChanges();
        }
    }
}