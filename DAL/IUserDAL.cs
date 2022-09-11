using DAL.models;
using System.Collections.Generic;

namespace DAL
{
    public interface IUserDAL
    {
        List<User> AddUser(User user);
        List<User> GetAllUsers();
        User GetUser(string name, string password);
        List<User> RemoveUser(int id);
        List<User> UppdateUser(User user, int id);
    }
}