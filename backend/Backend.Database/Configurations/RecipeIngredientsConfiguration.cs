using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.Configurations
{
    public class RecipeIngredientsConfiguration : IEntityTypeConfiguration<RecipesIngredients>
    {
        public void Configure(EntityTypeBuilder<RecipesIngredients> builder)
        {
            builder.Property(x => x.RecipeId).IsRequired();
            builder.Property(x => x.IngredientId).IsRequired();
            builder.Property(x => x.RecipeMeasureQuantity).IsRequired();
            builder.Property(x => x.RecipeMeasureUnit).IsRequired();
            builder.HasKey(ri => new { ri.IngredientId, ri.RecipeId });


        }
    }
}
