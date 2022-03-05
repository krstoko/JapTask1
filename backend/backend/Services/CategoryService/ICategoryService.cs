using backend.Models;
using System.Collections.Generic;

namespace backend.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();

    }
}
