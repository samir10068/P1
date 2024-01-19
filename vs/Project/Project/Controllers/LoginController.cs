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
    public class LoginController : ApiController
    {
       LoginBL loginbl = new LoginBL();

        //// POST: api/Login
        public bool Post(User log)
        {
            return loginbl.logincheck(log);
        }
       
    }
}
