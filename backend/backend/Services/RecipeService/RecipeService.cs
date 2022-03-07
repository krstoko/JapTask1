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

        public async Task<ServiceResponse<List<GetRecipeDto>>> GetCategoryRecipes(string categoryName, int displeyedRecipes, int pageSize)
        {
            var response = new ServiceResponse<List<GetRecipeDto>>();
            try
            {
                Category category = await _dataContext.Categories.FirstOrDefaultAsync(c => c.CategoryName == categoryName);
                if (category != null)
                {

                    var dbRecipes = await _dataContext.Recipes.Where(r => r.Category.CategoryName == categoryName).ToListAsync();
                    var allRecipes = dbRecipes.Count();
                    if (allRecipes <= displeyedRecipes + pageSize)
                    {
                        response.LoadMore = false;
                        response.Message = "Cant load more";
                    }
                    response.Data = dbRecipes.Skip(displeyedRecipes).Take(pageSize).Select(r => _mapper.Map<GetRecipeDto>(r)).ToList();
                    response.TotalDataNumber = allRecipes;
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

        public async Task<ServiceResponse<List<GetRecipeDto>>> GetSearchRecipes(string categoryName, string searchValue, int displeyedRecipes, int pageSize)
        {
            var response = new ServiceResponse<List<GetRecipeDto>>();
            try
            {
                Category category = await _dataContext.Categories.FirstOrDefaultAsync(c => c.CategoryName == categoryName);
                if (category != null)
                {
                    var dbRecipes = await _dataContext.Recipes.Where(r => r.Category.CategoryName == categoryName && r.RecipeName.Contains(searchValue)).ToListAsync();
                    var allRecipes = dbRecipes.Count();
                    if (allRecipes <= displeyedRecipes + pageSize)
                    {
                        response.LoadMore = false;
                        response.Message = "Cant load more";
                    }
                    response.Data = dbRecipes.Skip(displeyedRecipes).Take(pageSize).Select(r => _mapper.Map<GetRecipeDto>(r)).ToList();
                    response.TotalDataNumber = allRecipes;
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

        public async Task<ServiceResponse<GetRecipeDto>> GetSingleRecipe(int recipeId)
        {
            var response = new ServiceResponse<GetRecipeDto>();
            var recipe = await _dataContext.Recipes.Include(r => r.Category).FirstOrDefaultAsync(r => r.Id == recipeId);
            if (recipe == null)
            {
                response.Success = false;
                response.Message = "No recipe with that Id";
            }
            response.Data = _mapper.Map<GetRecipeDto>(recipe);
            return response;
        }
    }
}
