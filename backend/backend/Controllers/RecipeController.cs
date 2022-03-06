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
            if (result.Data == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
