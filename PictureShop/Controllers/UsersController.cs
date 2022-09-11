using BLL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictureShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //UserBLL _Ubll = new UserBLL();
        IUserBLL _Ubll;
        public UsersController(IUserBLL Ubll)
        {
            _Ubll = Ubll;
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var users = _Ubll.GetAllUsers();
            return Ok(users);
        }

        [HttpGet]
        public IActionResult GetUser(string name, string password)
        {
            var carrentUser = _Ubll.GetUser(name, password);
            return Ok(carrentUser);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserDTO user)
        {

            return Ok(_Ubll.AddUser(user));
        }
        [HttpPut("UppdateUser/{id}")]
        public IActionResult UppdateUser([FromBody] UserDTO user, int id)
        {
            return Ok(_Ubll.UppdateUser(user, id));
        }

        [HttpDelete("RemoveUser/{id}")]
        public IActionResult RemoveUser(int id)
        {
            return Ok(_Ubll.RemoveCloth(id));
        }


    }
}
