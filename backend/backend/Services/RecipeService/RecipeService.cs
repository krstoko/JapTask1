using AutoMapper;
using backend.Data;
using backend.Dtos.Recipe;
using backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.RecipeService
{
    public class RecipeService : IRecipeService
    {

        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public RecipeService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<GetRecipeDtocs>>> GetCategoryRecipes(int categoryId)
        {
            var response = new ServiceResponse<List<GetRecipeDtocs>>();
            return response;
        }
    }
}
