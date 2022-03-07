using backend.Dtos.Category;
using backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<GetCategoryDto>>> GetLoadMoreCategories(int pageNumber, int pageSize);
        Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategories();

    }
}
