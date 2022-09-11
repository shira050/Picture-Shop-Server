using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UserDAL : IUserDAL
    {
        //UserDTO _Udto = new UserDTO();
        DBContext DB = new DBContext();

        public User GetUser(string name, string password)
        {
            User currentUser = DB.Users.Where(x => x.NameUser.Equals(name) && x.PasswordUser.Equals(password)).FirstOrDefault();
            return currentUser;
        }

        public List<User> GetAllUsers()
        {
            List<User> Users = DB.Users.ToList();
            return Users;
        }
        public List<User> AddUser(User user)
        {
            try
            {
                DB.Users.Add(user);
                DB.SaveChanges();
                return DB.Users.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<User> UppdateUser(User user, int id)
        {
            try
            {
                User u = DB.Users.FirstOrDefault(x => x.CodeUser == id);
                if (u != null)
                {
                    //DB.Users.Update(user);
                    u.NameUser = user.NameUser;
                    u.PasswordUser = user.PasswordUser;
                    u.EmailUser = user.EmailUser;
                    DB.SaveChanges();
                }
                return DB.Users.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<User> RemoveUser(int id)
        {
            try
            {
                this.DB.Remove(DB.Users.FirstOrDefault(x => x.CodeUser == id));
                this.DB.SaveChanges();
                return DB.Users.ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }
       


    }
}
