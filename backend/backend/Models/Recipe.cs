using System.Collections.Generic;

namespace backend.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string RecipeImgUrl { get; set; }
        public Category Category { get; set; }
        public List<RecipesIngredients> RecipesIngredients { get; set; }
    }
}
