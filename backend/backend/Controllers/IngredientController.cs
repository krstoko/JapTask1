using backend.Dtos.Ingredient;
using backend.Models;
using backend.Services.NewFolder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientsService _ingredientService;
        public IngredientController(IIngredientsService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet("All")]
        public async Task<ActionResult<ServiceResponse<List<GetIngredientDto>>>> GetAllIngredients()
        {
            return Ok(await _ingredientService.GetAllIngredients());
        }
    }
}
