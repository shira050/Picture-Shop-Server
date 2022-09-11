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
    public class CategoryController : ControllerBase
    {
        //CategoryBLL _Cbll = new CategoryBLL();
        ICategoryBLL _Cbll;
        public CategoryController(ICategoryBLL Cbll)
        {
            _Cbll = Cbll;
        }


        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            return Ok(_Cbll.GetAllCategories());
        }

        [HttpGet]
        public IActionResult GetCategory(int code)
        {
           
            return Ok(_Cbll.GetCategory(code));
        }

        [HttpPost]
        public IActionResult AddCategory([FromBody] CategoryDTO c)
        {
           
            return Ok( _Cbll.AddCategory(c));
        }
        [HttpPut("UppdateCategory/{id}")]
        public IActionResult UppdateCategory([FromBody] CategoryDTO cat, int id)
        {
           
            return Ok( _Cbll.UppdateCategory(cat,id));
        }

        [HttpDelete("RemoveCategory/{id}")]
        public IActionResult RemoveCategory(int id)
        {
            return Ok(_Cbll.RemoveCategory(id));
        }

      //[HttpGet]
        //public IActionResult GetAllProductsInCategory(int codeCategory)
        //{
        //    return Ok(_Cbll.GetAllProductsInCategory(codeCategory));
        //}
    }
}
