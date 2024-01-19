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
    public class UserController : ApiController
    {
        UserBL userbl = new UserBL();
        // GET: api/User
        public IEnumerable<User> Get()
        {
            return userbl.GetAllUsers();
        }

        // GET: api/User/5
        public User Get(int id)
        {
            return userbl.GetUser(id);
        }

        // POST: api/User
        public string Post(User user)
        {
            userbl.Adduser(user);
                return "User Created!";
        }

        // PUT: api/User/5
        public string Put(int id,User user)
        {
            userbl.Updateuser(id,user);
            return "User Updated";
        }

        // DELETE: api/User/5
        public string Deleteuser(int id)
        {
            userbl.Deleteuser(id);
            return "User Deleted!";
        }
    }
}
