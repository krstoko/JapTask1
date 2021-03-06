// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;
using backend.Infrastructure.DataContext;

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220305222445_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backend.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryImgUrl = "https://media.istockphoto.com/photos/grilled-striploin-steak-picture-id535786572?k=20&m=535786572&s=612x612&w=0&h=WAOuIsIUQB7zVW23C6MX9y5QCyl6KLPL2eYcOcc_Qdk=",
                            CategoryName = "Beef"
                        },
                        new
                        {
                            Id = 2,
                            CategoryImgUrl = "",
                            CategoryName = "Bread"
                        },
                        new
                        {
                            Id = 3,
                            CategoryImgUrl = "",
                            CategoryName = "Breakfast"
                        },
                        new
                        {
                            Id = 4,
                            CategoryImgUrl = "",
                            CategoryName = "Cake"
                        },
                        new
                        {
                            Id = 5,
                            CategoryImgUrl = "",
                            CategoryName = "Candy"
                        },
                        new
                        {
                            Id = 6,
                            CategoryImgUrl = "",
                            CategoryName = "Chicken"
                        },
                        new
                        {
                            Id = 7,
                            CategoryImgUrl = "",
                            CategoryName = "Italian"
                        },
                        new
                        {
                            Id = 8,
                            CategoryImgUrl = "",
                            CategoryName = "Salad"
                        },
                        new
                        {
                            Id = 9,
                            CategoryImgUrl = "",
                            CategoryName = "Pie"
                        },
                        new
                        {
                            Id = 10,
                            CategoryImgUrl = "",
                            CategoryName = "French"
                        },
                        new
                        {
                            Id = 11,
                            CategoryImgUrl = "",
                            CategoryName = "Fruit"
                        },
                        new
                        {
                            Id = 12,
                            CategoryImgUrl = "",
                            CategoryName = "Rice"
                        },
                        new
                        {
                            Id = 13,
                            CategoryImgUrl = "",
                            CategoryName = "Thai"
                        },
                        new
                        {
                            Id = 14,
                            CategoryImgUrl = "",
                            CategoryName = "Vegetarian"
                        },
                        new
                        {
                            Id = 15,
                            CategoryImgUrl = "",
                            CategoryName = "Soup"
                        },
                        new
                        {
                            Id = 16,
                            CategoryImgUrl = "",
                            CategoryName = "Seafood"
                        },
                        new
                        {
                            Id = 17,
                            CategoryImgUrl = "",
                            CategoryName = "Sandwich"
                        },
                        new
                        {
                            Id = 18,
                            CategoryImgUrl = "",
                            CategoryName = "Lunch"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
