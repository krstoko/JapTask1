using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.Configurations
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(127);
            builder.Property(x => x.PurchasePrice).IsRequired().HasMaxLength(30);
            builder.Property(x => x.MeasureUnit).IsRequired();
            builder.Property(x => x.PurchaseMeasureQuantity).IsRequired();
            builder.HasData(DbData.GetIngredient());
        }
    }
}
