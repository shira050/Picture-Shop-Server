using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBLL : ICategoryBLL
    {
        //CategoryDAL _Cdal = new CategoryDAL();
        ICategoryDAL _Cdal;
        public CategoryBLL(ICategoryDAL Cdal)
        {
            _Cdal = Cdal;
        }

        public CategoryDTO GetCategory(int code)
        {
            Category c = _Cdal.GetCategory(code);
            if (c == null)
                return null;
            CategoryDTO currentCategory = ConvertCategoryToCategoryDTO(c);
           
            return currentCategory;
        }


        public List<CategoryDTO> GetAllCategories()
        {
            List<Category> cats = _Cdal.GetAllCategory();
            List<CategoryDTO> categoryDTO = new List<CategoryDTO>();
            foreach (var item in cats)
            {
                var c = ConvertCategoryToCategoryDTO(item);
                categoryDTO.Add(c);
            }
            return categoryDTO;
        }

        private CategoryDTO ConvertCategoryToCategoryDTO(Category cat)
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.CodeCategory = cat.CodeCategory;
            categoryDTO.NameCategory = cat.NameCategory;
            return categoryDTO;
        }

        private Category ConvertCategoryToCategoryDetail(CategoryDTO cat)
        {
            Category categoryDetail = new Category();
            categoryDetail.CodeCategory = cat.CodeCategory;
            categoryDetail.NameCategory = cat.NameCategory;

            return categoryDetail;
        }
        public List<Category> AddCategory(CategoryDTO cat)
        {
            Category currentCategory = ConvertCategoryToCategoryDetail(cat);

            return _Cdal.AddCategory(currentCategory);
        }

        public List<Category> UppdateCategory(CategoryDTO cat, int id)
        {
            Category currentCategory = ConvertCategoryToCategoryDetail(cat);


            return _Cdal.UppdateCategory(currentCategory, id);
        }

        public List<Category> RemoveCategory(int id)
        {
            //try
            //{
                return _Cdal.RemoveCategory(id);

            //}
            //catch
            //{
            //    throw new Exception();
            //}

        }
        //public List<Product> GetAllProductsInCategory(int codeCategory)
        //{
        //    return _Cdal.GetAllProductsInCategory(codeCategory);
        //}
    }
}
