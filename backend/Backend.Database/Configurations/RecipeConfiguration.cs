using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data.Configurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(127);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1020);
            builder.Property(x => x.ImgUrl).IsRequired().HasMaxLength(1020);
            builder.Property(x => x.CategoryId).IsRequired();
        }
    }
}
