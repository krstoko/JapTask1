namespace backend.Dtos.Recipe
{
    public class AddRecipeDto
    {
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string RecipeImgUrl { get; set; }
        public string CategoryName { get; set; }
    }
}
