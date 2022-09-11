
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL : ICategoryDAL
    {
        //CategoryDTO _Cdto = new CategoryDTO();
        DBContext DB = new DBContext();

        public Category GetCategory(int code)
        {
            Category currentCategory = DB.Categories.Where(x => x.CodeCategory == code).FirstOrDefault();
            return currentCategory;
        }

        public List<Category> GetAllCategory()
        {
            List<Category> category = DB.Categories.ToList();
            return category;
        }
        public List<Category> AddCategory(Category c)
        {
            try
            {
                DB.Categories.Add(c);
                DB.SaveChanges();
                return DB.Categories.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Category> UppdateCategory(Category cat, int id)
        {
            try
            {
                Category c = DB.Categories.FirstOrDefault(x => x.CodeCategory == id);
                if (c != null)
                {

                    c.NameCategory = cat.NameCategory;
                    DB.SaveChanges();
                }
                return DB.Categories.ToList();
            }
            catch (Exception)
            {
                throw;

            }
        }

        public List<Category> RemoveCategory(int id)
        {

            try
            {
                Category c = GetCategory(id);
                if (id == 43 || c == null)
                    throw new Exception();

                else
                {

                    this.DB.Remove(DB.Categories.FirstOrDefault(x => x.CodeCategory == id));
                    //changeCategoryToDefalt(id);
                    //this.DB.Products.ToList().ForEach(x => { if (x.CodeCategory == id) x.CodeCategory = 43; });
                    this.DB.SaveChanges();
                    return DB.Categories.ToList();


                }


            }
            catch (Exception)
            {
                throw;

            }

        }

        public void changeCategoryToDefalt(int id)
        {
            try
            {
            DB.Products.ToList().ForEach(x => { if (x.CodeCategory == id) x.CodeCategory = 43; });

            }
            catch
            {

            }

        }
        //public List<Product> GetAllProductsInCategory(int codeCategory)
        //{
        //    List<Product> p = DB.Products.Where(x => x.CodeCategory == codeCategory).ToList();
        //    return p;
        //}

    }
}
