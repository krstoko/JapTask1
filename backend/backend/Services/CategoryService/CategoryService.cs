using backend.Models;
using System.Collections.Generic;

namespace backend.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private static List<Category> categories = new List<Category>
        {
            new Category(),
            new Category{ Id = 1, CategoryName = "Oil" }
        };
        public List<Category> GetAllCategories()
        {
            return categories;
        }
    }
}
