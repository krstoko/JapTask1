using AutoMapper;
using backend.Dtos.Category;
using backend.Models;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IMapper _mapper;
        public CategoryService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategories()
        {
            var serviceResponse = new ServiceResponse<List<GetCategoryDto>>();
            serviceResponse.Data = categories.Select(c => _mapper.Map<GetCategoryDto>(c)).ToList();
            return serviceResponse;
        }
    }
}
