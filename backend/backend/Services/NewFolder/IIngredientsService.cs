using backend.Dtos.Ingredient;
using backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.NewFolder
{
    public interface IIngredientsService
    {
        Task<ServiceResponse<List<GetIngredientDto>>> GetAllIngredients();
    }
}
