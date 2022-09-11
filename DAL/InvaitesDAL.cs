using DAL.models;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class InvaitesDAL
    {
        //ProductsInBasketDTO _Pdto = new ProductsInBasketDTO();
        DBContext DB = new DBContext();
        // public List<ProductsInBasketDTO> L = new List<ProductsInBasketDTO>();
        public bool AddProductToBasket(ProductsInBasketDTO p, List<ProductsInBasketDTO> L)
        {

            try
            {
                L.Add(p);
                return true;
            }
            catch
            {
                return false;
            }

        }


        public bool DoInviteByBascet(int idUser, List<ProductsInBasketDTO> L)
        {
          try
            {
                int maxInvaite = DB.Invaites.Max(x => x.CodeInvite)+1;
                double sum = 0;
                foreach (ProductsInBasketDTO item in L)
                {
                    sum += item.FinalPrice;
                }
                SaveIniate(idUser, sum);
                foreach (ProductsInBasketDTO item in L)
                {
                    Product p = DB.Products.Where(x => x.CodePicture == item.CodePicture).FirstOrDefault();
                    if (p.AcountInStore == 0)
                        throw new ArgumentException($"אזל המלאי!!");
                    if (item.count > p.AcountInStore)
                        throw new ArgumentException($" תוכל להזמין רק" + p.AcountInStore + " נגמר המלאי");
                  
                    p.AcountInStore -= item.count;
                    SaveDetailsInvite(item , maxInvaite);
                  
                  
                }
                
                L = null;
                DB.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public void SaveIniate(int idUser, double sum)
        {
            Invaite i = new Invaite();
            i.CodeUser = idUser;
            i.DateInvite = DateTime.Today;
            i.PriceOfInvite = sum;
            DB.Invaites.Add(i);
            DB.SaveChanges();

        }
      

        public void SaveDetailsInvite(ProductsInBasketDTO item , int maxInvaite)
        {
            Detaile d = new Detaile();


            d.CodeProduct = item.CodePicture;
            d.CodeInvite =maxInvaite;
            d.Count = item.count;
            DB.Detailes.Add(d);
            DB.SaveChanges();

        }
    }
}
