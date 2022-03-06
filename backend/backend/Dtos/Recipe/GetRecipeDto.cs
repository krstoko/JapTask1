using backend.Dtos.Category;

namespace backend.Dtos.Recipe
{
    public class GetRecipeDto
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string RecipeImgUrl { get; set; }
        public GetCategoryDto Category { get; set; }
        public int Price { get; set; }
    }
}
