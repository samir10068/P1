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
    public class ShiftController : ApiController
    {
        ShiftBL shiftbl = new ShiftBL();
        // GET: api/Shift
        public IEnumerable<Shifts> Get()
        {
            return shiftbl.GetAllShift();
        }

        // GET: api/Shift/5
        public Shifts Get(int id)
        {
            return shiftbl.GetShift(id);
        }

        // POST: api/Shift
        public string Post(Shifts shift)
        {
            shiftbl.AddShift(shift);
            return "Shift Created!";
        }

        // PUT: api/Shift/5
        public string Put(int id, Shifts user)
        {
            shiftbl.Updateshift(id, user);
            return "Shift Updated!";
        }

        // DELETE: api/Shift/5
        public string Deleteuser(int id)
        {
            shiftbl.DeleteShift(id);
            return "Shift Deleted!";
        }
    }
}
