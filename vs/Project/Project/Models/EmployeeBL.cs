using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class EmployeeBL
    {
        ProjectEntities db = new ProjectEntities();
    public List<Employee> GetAllEmployee()
    {
        return db.Employee.ToList();
    }
    public Employee GetEmployee(int id)
    {
        return db.Employee.Where(x => x.ID == id).First();
    }
    public void AddEmployee(Employee employee)
    {
        db.Employee.Add(employee);
        db.SaveChanges();
    }
    public void UpdateEmployee(int id, Employee employee)
    {
        var e = db.Employee.Where(x => x.ID == id).First();
              
        e.FirstName = employee.FirstName;
        e.LastName = employee.LastName;
        e.StartWorkYear = employee.StartWorkYear;
        e.DepartmentID = employee.DepartmentID;



        db.SaveChanges();

    }
    public void DeleteEmployee(int id)
    {
        var d = db.Employee.Where(x => x.ID == id).First();
        db.Employee.Remove(d);
        db.SaveChanges();
    }
}
}
