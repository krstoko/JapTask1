using backend.Dtos.Recipe;
using backend.Models;
using backend.Services.RecipeService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {

        private readonly IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        [HttpGet("{categoryName}")]
        public async Task<ActionResult<ServiceResponse<List<GetRecipeDto>>>> GetCategoryRecipes(string categoryName, int displeyedRecipes, int pageSize)
        {
            var result = await _recipeService.GetCategoryRecipes(categoryName, displeyedRecipes, pageSize);
            if (result.Success == false)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
        [HttpGet("Search/{categoryName}")]
        public async Task<ActionResult<ServiceResponse<List<GetRecipeDto>>>> GetSearchRecipes(string categoryName, string searchValue, int displeyedRecipes, int pageSize)
        {
            var result = await _recipeService.GetSearchRecipes(categoryName, searchValue, displeyedRecipes, pageSize);
            if (result.Data == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
        [HttpGet("Single/{recipeId}")]
        public async Task<ActionResult<ServiceResponse<List<GetRecipeDto>>>> GetSingleRecipe(int recipeId)
        {
            var result = await _recipeService.GetSingleRecipe(recipeId);
            if (result.Data == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
