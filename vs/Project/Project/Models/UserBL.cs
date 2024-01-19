using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Project.Models
{
    public class UserBL
    {
        ProjectEntities db = new ProjectEntities();

        public List<User> GetAllUsers()
        {
            return db.User.ToList();
        }
        public User GetUser(int id)
        {
            return db.User.Where(x => x.ID == id).First();
        }
      public void Adduser(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
        }
        public void Updateuser (int id, User user)
        {
            var u = db.User.Where(x => x.ID == id).First();    
            u.FullName = user.FullName;
            u.UserName = user.UserName;
            u.Password = user.Password;
            u.NumOfActions = user.NumOfActions;
            db.SaveChanges();

        }
        public void Deleteuser (int id)
        {
            var u = db.User.Where(x => x.ID == id).First();
            db.User.Remove(u);
            db.SaveChanges();
        }
    }
}