using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class UserBLL : IUserBLL
    {

        //UserDAL _Udal = new UserDAL();
        IUserDAL _Udal;
        public UserBLL(IUserDAL Udal)
        {
            _Udal = Udal;
        }

        public UserDTO GetUser(string name, string password)
        {
            User user = _Udal.GetUser(name, password);
            if (user == null)
                return null;
            UserDTO currentUser = ConvertUserToUserDTO(user);
            return currentUser;
        }


        public List<UserDTO> GetAllUsers()
        {
            List<User> users = _Udal.GetAllUsers();
            List<UserDTO> UsersDTO = new List<UserDTO>();
            foreach (var item in users)
            {
                var u = ConvertUserToUserDTO(item);
                UsersDTO.Add(u);
            }
            return UsersDTO;
        }

        private UserDTO ConvertUserToUserDTO(User user)
        {
            UserDTO userDto = new UserDTO();
            userDto.CodeUser = user.CodeUser;
            userDto.EmailUser = user.EmailUser;
            userDto.NameUser = user.NameUser;
            userDto.PasswordUser = user.PasswordUser;

            return userDto;
        }

        private User ConvertUserToUserDetail(UserDTO user)
        {
            User userDetail = new User();
            userDetail.CodeUser = user.CodeUser;
            userDetail.NameUser = user.NameUser;
            userDetail.EmailUser = user.EmailUser;
            userDetail.PasswordUser = user.PasswordUser;
            return userDetail;
        }
        public List<User> AddUser(UserDTO user)
        {
            User currentUser = ConvertUserToUserDetail(user);

            return _Udal.AddUser(currentUser);
        }

        public List<User> UppdateUser(UserDTO user, int id)
        {
            User currentUser = ConvertUserToUserDetail(user);


            return _Udal.UppdateUser(currentUser, id);
        }

        public List<User> RemoveCloth(int id)
        {
            return _Udal.RemoveUser(id);
        }

    }
}
