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
    public class DepartmentController : ApiController
    {
       DepartmentBL departmentbl = new DepartmentBL();
        // GET: api/Department
        public IEnumerable<Department> Get()
        {
            return departmentbl.GetAllDepartment();
        }

        // GET: api/Department/5
        public Department Get(int id)
        {
            return departmentbl.GetDepartment(id);
        }

        // POST: api/Department
        public string Post(Department department)
        {
            departmentbl.AddDepartment(department);
            return "Department Created!";
        }

        // PUT: api/Department/5
        public string Put(int id, Department department)
        {
            departmentbl.UpdateDepartment(id, department);
            return "Department Updated!";
        }

        // DELETE: api/Department/5
        public string DeleteDepartment(int id)
        {
            departmentbl.DeleteDepartment(id);
            return "Department Deleted!";
        }
    }
}
