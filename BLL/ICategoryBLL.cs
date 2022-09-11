using DAL.models;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public interface ICategoryBLL
    {
        List<Category> AddCategory(CategoryDTO cat);
        List<CategoryDTO> GetAllCategories();
        CategoryDTO GetCategory(int code);
        List<Category> RemoveCategory(int id);
        List<Category> UppdateCategory(CategoryDTO cat, int id);
    }
}