using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class EmployeeShiftBL
    {
        ProjectEntities db = new ProjectEntities();
        public List<EmployeeShift> GetAllEmployeeShift()
        {
            return db.EmployeeShift.ToList();
        }
        public EmployeeShift GetEmployeeShift(int id)
        {
            return db.EmployeeShift.Where(x => x.ID == id).First();
        }
        public void AddEmployeeShift(EmployeeShift employeeshift)
        {
            db.EmployeeShift.Add(employeeshift);
            db.SaveChanges();
        }
        public void UpdateEmployeeShift(int id, EmployeeShift employeeshift)
        {
            var e = db.EmployeeShift.Where(x => x.ID == id).First();
               e.ShiftID = employeeshift.ShiftID;
               e.EmployeeID = employeeshift.EmployeeID;    

            db.SaveChanges();

        }
        public void DeleteEmployeeShift(int id)
        {
            var e = db.EmployeeShift.Where(x => x.ID == id).First();
            db.EmployeeShift.Remove(e);
            db.SaveChanges();
        }
    }
}
