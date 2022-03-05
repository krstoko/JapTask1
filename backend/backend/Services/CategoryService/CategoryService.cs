using backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private static List<Category> categories = new List<Category>
        {
            new Category(),
            new Category{ Id = 1, CategoryName = "Oil" }
        };
        public async Task<ServiceResponse<List<Category>>> GetAllCategories()
        {
            var serviceResponse = new ServiceResponse<List<Category>>();
            serviceResponse.Data = categories;
            return serviceResponse;
        }
    }
}
