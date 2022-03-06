using AutoMapper;
using backend.Data;
using backend.Dtos.Recipe;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<ServiceResponse<List<GetRecipeDto>>> GetCategoryRecipes(string categoryName)
        {
            var response = new ServiceResponse<List<GetRecipeDto>>();
            try
            {
                Category category = await _dataContext.Categories.FirstOrDefaultAsync(c => c.CategoryName == categoryName);
                if (category != null)
                {
                    var dbRecipes = await _dataContext.Recipes.Where(r => r.Category.CategoryName == categoryName).ToListAsync();
                    response.Data = dbRecipes.Select(r => _mapper.Map<GetRecipeDto>(r)).ToList();
                }
                else
                {
                    response.Success = false;
                    response.Message = "Category Not Found";
                }

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
