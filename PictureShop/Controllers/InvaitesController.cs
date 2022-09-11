using BLL;
using DAL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.models;

namespace PictureShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvaitesController : ControllerBase
    {
        InvaitesBLL _Ibll = new InvaitesBLL();
        //מה עושים בפעולה בונה של קנייה ופרטי קנייה עם הקשרי גומלין?????????
        ////??????איזה סוג הוספה לסל?
        //[HttpGet]
        //public IActionResult AddProductToBasket([FromBody] ProductsInBasketDTO p)
        //{
        //    List<ProductsInBasketDTO> L = new List<ProductsInBasketDTO>();
        //    return Ok(_Ibll.AddProductToBasket(p,L));
        //}
        [HttpPost]
        public IActionResult DoInviteByBascet(int idUser, List<ProductsInBasketDTO> L)
        {
            //List<ProductsInBasketDTO> L = new List<ProductsInBasketDTO>();
            return Ok(_Ibll.DoInviteByBascet(idUser,L));
        }

    }
}
