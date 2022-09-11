using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductsDAL
    {
        ProductDTO _Pdto = new ProductDTO();
        DBContext DB = new DBContext();

        public Product GetProduct(int code)
        {
            Product currentProduct = DB.Products.Where(x => x.CodePicture == code).FirstOrDefault();
            return currentProduct;
        }

        public List<Product> GetAllProducts()
        {
            
            return DB.Products.ToList();
        }
        public List<Product> AddProduct(Product p)
        {
            try
            {
                DB.Products.Add(p);
                DB.SaveChanges();
                return DB.Products.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> UppdateProduct(Product pro, int id)
        {
            try
            {
                Product p = DB.Products.FirstOrDefault(x => x.CodePicture == id);
                if (p != null)
                {
                    p.NamePicture = pro.NamePicture;
                    p.CodeCategory = pro.CodeCategory;
                    p.Price = pro.Price;
                    p.Image = pro.Image;
                    p.Size = pro.Size;
                    p.AcountInStore = pro.AcountInStore;

                    DB.SaveChanges(); 
                   
                }
                return DB.Products.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> RemoveProduct(int id)
        {
            try
            {
                this.DB.Remove(DB.Products.FirstOrDefault(x => x.CodePicture == id));
                this.DB.SaveChanges();
                return DB.Products.ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }



        public List<Product> GetAllProductsInCategory(int codeCategory)
        {
            List<Product> p = DB.Products.Where(x => x.CodeCategory == codeCategory).ToList();
            return p;
        }
    }
}
