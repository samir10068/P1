using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
  
    public class DepartmentBL
    {
        ProjectEntities db = new ProjectEntities();
        public List<Department> GetAllDepartment()
        {
            return db.Department.ToList();
        }
        public Department GetDepartment(int id)
        {
            return db.Department.Where(x => x.ID == id).First();
        }
        public void AddDepartment(Department department)
        {
            db.Department.Add(department);
            db.SaveChanges();
        }
        public void UpdateDepartment(int id, Department department)
        {
            var d = db.Department.Where(x => x.ID == id).First();
            d.Name = department.Name;
            d.Manger = department.Manger;
            
            
            db.SaveChanges();

        }
        public void DeleteDepartment(int id)
        {
            var d = db.Department.Where(x => x.ID == id).First();
            db.Department.Remove(d);
            db.SaveChanges();
        }
    }
}
