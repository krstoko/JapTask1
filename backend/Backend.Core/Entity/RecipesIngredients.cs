using backend.Core.Common;

namespace backend.Models
{
    public class RecipesIngredients
    {
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }

        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }

        public int RecipeMeasureQuantity { get; set; }
        public MeasureUnit RecipeMeasureUnit { get; set; }
    }
}
