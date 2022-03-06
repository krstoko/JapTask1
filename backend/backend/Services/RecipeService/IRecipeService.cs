using backend.Dtos.Recipe;
using backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<ServiceResponse<List<GetRecipeDto>>> GetCategoryRecipes(string categoryName);
    }
}
