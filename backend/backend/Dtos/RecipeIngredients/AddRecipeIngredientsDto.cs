using backend.Models;

namespace backend.Dtos.RecipeIngredients
{
    public class AddRecipeIngredientsDto
    {
        public string IngredientName { get; set; }
        public int RecipeMeasureQuantity { get; set; }
        public MeasureUnit RecipeMeasureUnit { get; set; }
    }
}
