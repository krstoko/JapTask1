using backend.Entity;
using System.Collections.Generic;

namespace backend.Models
{
    public class Recipe : EntityBase
    {
        public string Description { get; set; }
        public string ImgUrl { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<RecipesIngredients> RecipesIngredients { get; set; }
    }
}
