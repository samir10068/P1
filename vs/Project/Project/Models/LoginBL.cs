using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class LoginBL
    {
        ProjectEntities db = new ProjectEntities();
       

        public bool logincheck(User log)
        {
           foreach (User x in db.User) 
           {
          if (log.UserName == x.UserName && log.Password == x.Password)
                   return true;
            }
            return false;
        }
    }
}