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
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    
    public class EmployeeShiftController : ApiController
    {

        EmployeeShiftBL employeeshiftbl = new EmployeeShiftBL();

        // GET: api/Employee
        public IEnumerable<EmployeeShift> Get()
        {
            return employeeshiftbl.GetAllEmployeeShift();
        }

        // GET: api/Employee/5
        public EmployeeShift Get(int id)
        {
            return employeeshiftbl.GetEmployeeShift(id);
        }

        // POST: api/Employee
        public string Post(EmployeeShift employeeshift)
        {
          employeeshiftbl.AddEmployeeShift(employeeshift);
            return "EmployeeShift Created!";
        }

        // PUT: api/Employee/5
        public string Put(int id, EmployeeShift employeeshift)
        {
            employeeshiftbl.UpdateEmployeeShift(id, employeeshift);
            return "EmployeeShift Updated!";
        }

        // DELETE: api/Employee/5
        public string DeleteEmployeeShift(int id)
        {
            employeeshiftbl.DeleteEmployeeShift(id);
            return "EmployeeShift Deleted!";
        }
    }

}
