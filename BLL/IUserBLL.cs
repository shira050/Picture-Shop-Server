using DAL.models;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public interface IUserBLL
    {
        List<User> AddUser(UserDTO user);
        List<UserDTO> GetAllUsers();
        UserDTO GetUser(string name, string password);
        List<User> RemoveCloth(int id);
        List<User> UppdateUser(UserDTO user, int id);
    }
}