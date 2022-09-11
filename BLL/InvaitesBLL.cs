using DAL;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class InvaitesBLL
    {
        InvaitesDAL _Idal = new InvaitesDAL();
     


        //private ProductsInBasketDTO ConvertInvaitesToProductsInBasketDTO(Invaite i)
        //{
        //    ProductsInBasketDTO inviteDTO = new ProductsInBasketDTO();

        //    inviteDTO.CodeUser = (int)i.CodeUser;
        //    inviteDTO.DateInvite = (DateTime)i.DateInvite;
        //    inviteDTO.PriceOfInvite = (double)i.PriceOfInvite;

        //    return inviteDTO;
        //}

        //private Invaite ConvertInvaitesToInvaitesDetail(ProductsInBasketDTO i)
        //{
        //    Invaite invaiteDetail = new Invaite();

        //    invaiteDetail.CodeUser = i.CodeUser;
        //    invaiteDetail.DateInvite = i.DateInvite;
        //    invaiteDetail.PriceOfInvite = i.PriceOfInvite;

        //    return invaiteDetail;
        //}

        public bool AddProductToBasket(ProductsInBasketDTO p, List<ProductsInBasketDTO> L)
        {
             //List<ProductsInBasketDTO> L =_Idal.DB.Users.Where(x => x.CodeUser == idUser).FirstOrDefault().Invaites.L;
           
            return _Idal.AddProductToBasket(p,L);
        }

        public bool DoInviteByBascet(int idUser, List<ProductsInBasketDTO> L)
        {
           // List<ProductsInBasketDTO> L = DB.Users.Where(x => x.CodeUser == idUser).FirstOrDefault().;

            return _Idal.DoInviteByBascet(idUser,L);
        }


    }
}
