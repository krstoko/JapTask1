using AutoMapper;
using backend.Data;
using backend.Dtos.Ingredient;
using backend.Dtos.Recipe;
using backend.Dtos.RecipeIngredients;
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
            try
            {
                Recipe recipe = _mapper.Map<Recipe>(newRecipe);
                var recipeCategory = await _dataContext.Categories.FirstOrDefaultAsync(c => c.CategoryName == newRecipe.CategoryName);
                if (recipeCategory == null)
                {
                    response.Success = false;
                    response.Message = "Category not found";
                    return response;
                }
                else
                {
                    recipe.Category = recipeCategory;
                    _dataContext.Recipes.Add(recipe);
                    await _dataContext.SaveChangesAsync();

                }
                for (int i = 0; i < newRecipe.RecipeIngredients.Count; i++)
                {
                    Ingredient ingredient = await _dataContext.Ingredients.FirstOrDefaultAsync(ingredient => ingredient.IngredientName == newRecipe.RecipeIngredients[i].IngredientName);
                    if (ingredient == null)
                    {
                        response.Success = false;
                        response.Message = "Ingredient not found";
                        return response;
                    }
                    else
                    {
                        RecipesIngredients recipeIngredient = new()
                        {
                            IngredientId = ingredient.Id,
                            RecipeId = recipe.Id,
                            RecipeMeasureUnit = newRecipe.RecipeIngredients[i].RecipeMeasureUnit,
                            RecipeMeasureQuantity = newRecipe.RecipeIngredients[i].RecipeMeasureQuantity
                        };
                        _dataContext.RecipeIngredients.Add(recipeIngredient);
                        await _dataContext.SaveChangesAsync();
                    }
                }
                response.Data = _mapper.Map<GetRecipeDto>(recipe);

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetRecipeDto>>> GetCategoryRecipes(string categoryName, int displeyedRecipes, int pageSize)
        {
            var response = new ServiceResponse<List<GetRecipeDto>>();
            try
            {
                Category category = await _dataContext.Categories.FirstOrDefaultAsync(c => c.CategoryName == categoryName);
                if (category != null)
                {

                    var dbRecipes = await _dataContext.Recipes.Include(r => r.RecipesIngredients).Where(r => r.Category.CategoryName == categoryName).ToListAsync();
                    var recipesDto = dbRecipes.Select(r => _mapper.Map<GetRecipeDto>(r)).ToList();
                    var allRecipes = recipesDto.Count;
                    for (int i = 0; i < allRecipes; i++)
                    {
                        await AddingIngredientAndPricing(recipesDto[i]);
                    }

                    if (allRecipes <= displeyedRecipes + pageSize)
                    {
                        response.LoadMore = false;
                        response.Message = "Cant load more";
                    }
                    response.Data = recipesDto.OrderBy(r => r.Price).Skip(displeyedRecipes).Take(pageSize).ToList();
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

        private async Task AddingIngredientAndPricing(GetRecipeDto recipeDto)
        {
            for (int i = 0; i < recipeDto.RecipesIngredients.Count; i++)
            {
                var ingredient = await _dataContext.Ingredients.FirstOrDefaultAsync(ingredient => ingredient.Id == recipeDto.RecipesIngredients[i].IngredientId);
                var ingridientDto = _mapper.Map<GetIngredientDto>(ingredient);
                recipeDto.RecipesIngredients[i].Ingredient = ingridientDto;
                recipeDto.RecipesIngredients[i].RealIngredientPrice = CalculatePrice(ingridientDto, recipeDto.RecipesIngredients[i].RecipeMeasureUnit.ToString(), recipeDto.RecipesIngredients[i].RecipeMeasureQuantity);
            }
            recipeDto.Price = recipeDto.RecipesIngredients.Sum(ri => ri.RealIngredientPrice);
        }

        public async Task<ServiceResponse<List<GetRecipeDto>>> GetSearchRecipes(string categoryName, string searchValue, int displeyedRecipes, int pageSize)
        {
            var response = new ServiceResponse<List<GetRecipeDto>>();
            try
            {
                Category category = await _dataContext.Categories.FirstOrDefaultAsync(c => c.CategoryName == categoryName);
                if (category != null)
                {
                    var dbRecipes = await _dataContext.Recipes.Include(r => r.RecipesIngredients).Where(r => r.Category.CategoryName == categoryName && r.RecipeName.Contains(searchValue)).ToListAsync();
                    var recipesDto = dbRecipes.Select(r => _mapper.Map<GetRecipeDto>(r)).ToList();
                    var allRecipes = recipesDto.Count;
                    for (int i = 0; i < allRecipes; i++)
                    {
                        await AddingIngredientAndPricing(recipesDto[i]);
                    }

                    if (allRecipes <= displeyedRecipes + pageSize)
                    {
                        response.LoadMore = false;
                        response.Message = "Cant load more";
                    }
                    response.Data = recipesDto.OrderBy(r => r.Price).Skip(displeyedRecipes).Take(pageSize).ToList();
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

            var recipe = await _dataContext.Recipes.Include(r => r.Category).Include(r => r.RecipesIngredients).FirstOrDefaultAsync(r => r.Id == recipeId);
            var recipeDto = _mapper.Map<GetRecipeDto>(recipe);
            await AddingIngredientAndPricing(recipeDto);
            if (recipe == null)
            {
                response.Success = false;
                response.Message = "No recipe with that Id";
            }

            response.Data = recipeDto;
            return response;
        }

        private static double CalculatePrice(GetIngredientDto ingredient, string recipeMeasureUnit, int recipeMeasureQuantity)
        {
            int unitDifference;
            if (recipeMeasureUnit == "Kilogram" || recipeMeasureUnit == "Liter")
            {
                unitDifference = 1000;
            }
            else if (recipeMeasureUnit == "Gram" || recipeMeasureUnit == "Mililiter")
            {
                unitDifference = 1;
            }
            else
            {
                unitDifference = 10;

            }
            double price = ingredient.LowestMeasureUnitPrice * unitDifference * recipeMeasureQuantity;
            return Math.Round(price, 2);
        }
    }
}
