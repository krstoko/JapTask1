using AutoMapper;
using backend.Core.Common;
using backend.Data;
using backend.Dtos.Ingredient;
using backend.Dtos.Recipe;
using backend.Dtos.RecipeIngredients;
using backend.Dtos.Requests;
using backend.Infrastructure.DataContext;
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

        public async Task<ServiceResponse<GetRecipeDto>> AddRecipe(AddRecipeDto newRecipe)
        {
            var response = new ServiceResponse<GetRecipeDto>();
            var recipe = _mapper.Map<Recipe>(newRecipe);
            var recipeCategory = await _dataContext.Categories
                .FirstOrDefaultAsync(c => c.Id == newRecipe.CategoryId);

            if (recipeCategory == null)
            {
                response.Success = false;
                response.Message = "Category not found";
                return response;
            }

            _dataContext.Recipes.Add(recipe);
            await _dataContext.SaveChangesAsync();

            var recipeIngredients = new List<RecipesIngredients>();
            foreach (var recipeIngredient in newRecipe.RecipeIngredients)
            {
                recipeIngredients.Add(new RecipesIngredients()
                {
                    IngredientId = recipeIngredient.IngredientId,
                    RecipeId = recipe.Id,
                    RecipeMeasureUnit = recipeIngredient.RecipeMeasureUnit,
                    RecipeMeasureQuantity = recipeIngredient.RecipeMeasureQuantity
                });
            }

            _dataContext.RecipeIngredients.AddRange(recipeIngredients);
            await _dataContext.SaveChangesAsync();
            response.Data = _mapper.Map<GetRecipeDto>(recipe);
            return response;
        }

        public async Task<ServiceResponse<List<GetRecipeDto>>> GetByCategory(RecipeSearch recipeSearch)
        {
            var response = new ServiceResponse<List<GetRecipeDto>>();

            var recipes = await _dataContext.Recipes
                 .Include(r => r.RecipesIngredients)
                 .ThenInclude(r => r.Ingredient)
                 .Where(r => r.CategoryId == recipeSearch.CategoryId)
                 .Select(r => _mapper.Map<GetRecipeDto>(r))
                 .ToListAsync();


            if (recipes.Count <= recipeSearch.Skip + recipeSearch.PageSize)
            {
                response.LoadMore = false;
                response.Message = "Cant load more";
            }

            response.Data = recipes
                .OrderBy(r => r.Price)
                .Skip((int)recipeSearch.Skip)
                .Take((int)recipeSearch.PageSize)
                .ToList();

            response.TotalDataNumber = recipes.Count;
            return response;
        }

        public async Task<ServiceResponse<List<GetRecipeDto>>> GetBySearch(RecipeSearch recipeSearch)
        {
            var response = new ServiceResponse<List<GetRecipeDto>>();
            var recipes = await _dataContext.Recipes
                .Include(r => r.RecipesIngredients)
                .ThenInclude(r => r.Ingredient)
                .Where(r => r.CategoryId == recipeSearch.CategoryId &&
                (r.Name.Contains(recipeSearch.SearchValue) || r.RecipesIngredients.Any(ri => ri.Ingredient.Name.Contains(recipeSearch.SearchValue))))
                .Select(r => _mapper.Map<GetRecipeDto>(r))
                .ToListAsync();


            if (recipes.Count <= recipeSearch.Skip + recipeSearch.PageSize)
            {
                response.LoadMore = false;
                response.Message = "Cant load more";
            }

            response.Data = recipes
                .OrderBy(r => r.Price)
                .Skip((int)recipeSearch.Skip)
                .Take((int)recipeSearch.PageSize)
                .ToList();

            response.TotalDataNumber = recipes.Count;
            return response;
        }

        public async Task<ServiceResponse<GetRecipeDto>> GetRecipe(int id)
        {
            var response = new ServiceResponse<GetRecipeDto>();
            var recipe = await _dataContext.Recipes
                .Include(r => r.Category)
                .Include(r => r.RecipesIngredients)
                .ThenInclude(r => r.Ingredient)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (recipe == null)
            {
                response.Success = false;
                response.Message = "No recipe with that Id";
                return response;
            }

            response.Data = _mapper.Map<GetRecipeDto>(recipe);
            return response;
        }
    }
}
