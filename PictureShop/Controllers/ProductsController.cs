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
    public class ProductsController : ControllerBase
    {
        ProductsBLL _Pbll = new ProductsBLL();


        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
           
            return Ok(_Pbll.GetAllProducts());
        }

        [HttpGet]
        public IActionResult GetProduct(int code)
        {

            return Ok(_Pbll.GetProduct(code));
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductDTO p)
        {

            return Ok(_Pbll.AddProduct(p));
        }
        [HttpPut("UppdateProduct/{id}")]
        public IActionResult UppdateProduct([FromBody] ProductDTO pro, int id)
        {

            return Ok(_Pbll.UppdateProduct(pro, id));
        }

        [HttpDelete("RemoveProduct/{id}")]
        public IActionResult RemoveProduct(int id)
        {
            return Ok(_Pbll.RemoveProduct(id));
        }

        [HttpGet("GetAllProductsInCategory/{codeCategory}")]
        public IActionResult GetAllProductsInCategory(int codeCategory)
        {
            return Ok(_Pbll.GetAllProductsInCategory(codeCategory));
        }

    }
}
