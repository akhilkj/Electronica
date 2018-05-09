using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Repository
{
   public class UserDAL
    {
        ElectronicaContext context;
        public UserDAL()
        {
            context = new ElectronicaContext();
        }
        public void InsertUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            User userObj = new User();
            userObj = context.Users.Find(id);
            userObj.UserTypeID = 0;
            context.SaveChanges();

        }
        public void UpdateUser(User user,int id)
        {
            Electronica.Entity.User userObj = new Electronica.Entity.User();
            userObj = context.Users.Find(id);
            userObj.UserID = user.UserID;
            userObj.FirstName = user.FirstName;
            userObj.LastName = user.LastName;
            userObj.Email = user.Email;
            userObj.Mobile = user.Mobile;
            userObj.Password = user.Password;
            userObj.ProfilePhoto = user.ProfilePhoto;
            userObj.SelfDescription = user.SelfDescription;
            userObj.Education = user.Education;
            // userObj.UserTypeID = user.UserTypeID;
            context.SaveChanges();
        }
        public Electronica.Entity.User Login(string Email, string password)
        {
            List<Electronica.Entity.User> user = context.Users.Where(s => s.Email == Email).ToList<Electronica.Entity.User>();
            foreach (var item in user)
            {
                if (item.Password == password)
                {
                    return item;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public List<Electronica.Entity.User> SelectUsers()
        {
            List<Electronica.Entity.User> userList = new List<Electronica.Entity.User>();
            var users = from temp in context.Users
                        select temp;
            foreach (var item in users)
            {
                userList.Add(item);
            }
            return userList;
        }

        ///////added by admin
        public List<User> UserForSelect()
        {
            var userID = (from user in context.Users where user.UserTypeID == 2 select user).ToList();
            return userID;
        }
    }
}
