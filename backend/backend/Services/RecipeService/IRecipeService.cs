using backend.Dtos.Recipe;
using backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<ServiceResponse<List<GetRecipeDto>>> GetCategoryRecipes(string categoryName, int displeyedRecipes, int pageSize);
        Task<ServiceResponse<List<GetRecipeDto>>> GetSearchRecipes(string categoryName, string searchValue, int displeyedRecipes, int pageSize);
        Task<ServiceResponse<GetRecipeDto>> GetSingleRecipe(int recipeId);
        Task<ServiceResponse<GetRecipeDto>> AddRecipe(AddRecipeDto newRecipe);
    }
}
