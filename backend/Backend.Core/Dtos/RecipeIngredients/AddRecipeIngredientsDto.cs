using backend.Core.Common;

namespace backend.Dtos.RecipeIngredients
{
    public class AddRecipeIngredientsDto
    {
        public int IngredientId { get; set; }
        public int RecipeMeasureQuantity { get; set; }
        public MeasureUnit RecipeMeasureUnit { get; set; }
    }
}
