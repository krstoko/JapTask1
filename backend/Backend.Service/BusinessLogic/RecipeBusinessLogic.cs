using backend.Models;

namespace Backend.Mapper
{
    public class RecipeBusinessLogic
    {

        public static double CalculatePrice(RecipesIngredients recipesIngridients)
        {

            int unitDifference = 0;
            if (recipesIngridients.RecipeMeasureUnit.ToString() == "Kilogram" || recipesIngridients.RecipeMeasureUnit.ToString() == "Liter")
            {
                unitDifference = 1000;
            }

            else if (recipesIngridients.RecipeMeasureUnit.ToString() == "Gram" || recipesIngridients.RecipeMeasureUnit.ToString() == "Mililiter")
            {
                unitDifference = 1;
            }
            else
            {
                unitDifference = 10;
            }
            return recipesIngridients.Ingredient.LowestMeasureUnitPrice * unitDifference * recipesIngridients.RecipeMeasureQuantity;
        }
    }
}
