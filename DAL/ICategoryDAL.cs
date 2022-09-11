using DAL.models;
using System.Collections.Generic;

namespace DAL
{
    public interface ICategoryDAL
    {
        List<Category> AddCategory(Category c);
        List<Category> GetAllCategory();
        Category GetCategory(int code);
        List<Category> RemoveCategory(int id);
        List<Category> UppdateCategory(Category cat, int id);
    }
}