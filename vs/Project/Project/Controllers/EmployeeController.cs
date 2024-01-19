using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project.Models;
using System.Web.Http.Cors;


namespace Project.Controllers
{
[EnableCors(origins: "*", headers: "*", methods: "*")]



    public class EmployeeController : ApiController
    {

        EmployeeBL employeebl = new EmployeeBL();

        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return employeebl.GetAllEmployee();
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            return employeebl.GetEmployee(id);
        }

        // POST: api/Employee
        public string Post(Employee employee)
        {
            employeebl.AddEmployee(employee);
            return "Employee Created!";
        }

        // PUT: api/Employee/5
        public string Put(int id, Employee employee)
        {
            employeebl.UpdateEmployee(id, employee);
            return "Employee Updated!";
        }

        // DELETE: api/Employee/5
        public string DeleteEmployee(int id)
        {
            employeebl.DeleteEmployee(id);
            return "Employee Deleted!";
        }
    }
    
}
