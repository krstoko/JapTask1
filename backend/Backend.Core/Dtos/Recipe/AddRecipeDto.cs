using backend.Dtos.RecipeIngredients;
using System.Collections.Generic;

namespace backend.Dtos.Recipe
{
    public class AddRecipeDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }
        public List<AddRecipeIngredientsDto> RecipeIngredients { get; set; }
    }
}
