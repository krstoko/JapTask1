using backend.Dtos.Ingredient;
using backend.Models;

namespace backend.Dtos.RecipeIngredients
{
    public class GetRecipeIngredientsDto
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public GetIngredientDto Ingredient { get; set; }
        public int RecipeMeasureQuantity { get; set; }
        public MeasureUnit RecipeMeasureUnit { get; set; }
        public double RealIngredientPrice { get; set; }
    }
}
