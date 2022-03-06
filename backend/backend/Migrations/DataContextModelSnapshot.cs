﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryImgUrl = "https://media.istockphoto.com/photos/grilled-striploin-steak-picture-id535786572?k=20&m=535786572&s=612x612&w=0&h=WAOuIsIUQB7zVW23C6MX9y5QCyl6KLPL2eYcOcc_Qdk=",
                            CategoryName = "Beef",
                            CreatedDate = new DateTime(2012, 5, 5, 1, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CategoryImgUrl = "https://media.istockphoto.com/photos/heap-of-bread-picture-id995038782?k=20&m=995038782&s=612x612&w=0&h=40HBdtHiBgOESo870LBOgc6xUt1E3bqhOhqPCXZTNbc=",
                            CategoryName = "Bread",
                            CreatedDate = new DateTime(2010, 1, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CategoryImgUrl = "https://simply-delicious-food.com/wp-content/uploads/2018/10/breakfast-board.jpg",
                            CategoryName = "Breakfast",
                            CreatedDate = new DateTime(2005, 2, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CategoryImgUrl = "https://funcakes.com/content/uploads/2021/02/Red-Velvet-Cake-with-Fruit-960x720-c-default.jpg",
                            CategoryName = "Cake",
                            CreatedDate = new DateTime(2015, 3, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CategoryImgUrl = "https://images.theconversation.com/files/439369/original/file-20220104-19-12kg47e.jpg?ixlib=rb-1.1.0&q=45&auto=format&w=1200&h=900.0&fit=crop",
                            CategoryName = "Candy",
                            CreatedDate = new DateTime(2018, 4, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CategoryImgUrl = "https://assets.bonappetit.com/photos/5f809c81ba63e7584fca0576/8:5/w_1800,h_1125,c_limit/Double-Garlic-Roast-Chicken-With-Onion-Gravy.jpg",
                            CategoryName = "Chicken",
                            CreatedDate = new DateTime(2020, 5, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CategoryImgUrl = "https://static.onecms.io/wp-content/uploads/sites/23/2020/06/23/italian-food-2000.jpg",
                            CategoryName = "Italian",
                            CreatedDate = new DateTime(2021, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CategoryImgUrl = "https://saladswithanastasia.com/wp-content/uploads/2021/12/radish-green-salad-land1.jpg",
                            CategoryName = "Salad",
                            CreatedDate = new DateTime(2010, 7, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CategoryImgUrl = "https://www.thespruceeats.com/thmb/MbHAC6HNO7rjkZXA_GwHvbQ46EA=/2000x1500/smart/filters:no_upscale()/basic-cherry-pie-recipe-995136-14-dfe79487adf64a848a49dd07983b6614.jpg",
                            CategoryName = "Pie",
                            CreatedDate = new DateTime(2012, 8, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CategoryImgUrl = "https://insidr.co/wp-content/uploads/2018/04/Boeuf-Bourguignon-1170x780-2.jpg",
                            CategoryName = "French",
                            CreatedDate = new DateTime(2000, 9, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CategoryImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature.jpg?sfvrsn=64942d53_4",
                            CategoryName = "Fruit",
                            CreatedDate = new DateTime(2001, 10, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CategoryImgUrl = "https://www.thoughtco.com/thmb/F5IEThuihsz_k-ptOUx1SP4KJoI=/2119x1192/smart/filters:no_upscale()/chopped-pork-meat-cooked-with-red-chili-paste--gochujang-sauce--over-rice-690784532-5c8bd3dc46e0fb000146acf1.jpg",
                            CategoryName = "Rice",
                            CreatedDate = new DateTime(2002, 11, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            CategoryImgUrl = "https://www.thespruceeats.com/thmb/TTsydZkvlx25nvMQPZq0wB5o87c=/1500x1500/smart/filters:no_upscale()/GettyImages-1042998066-518ca1d7f2804eb09039e9e42e91667c.jpg",
                            CategoryName = "Thai",
                            CreatedDate = new DateTime(2003, 12, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            CategoryImgUrl = "https://post.healthline.com/wp-content/uploads/2020/09/vegetarian-diet-plan-732x549-thumbnail.jpg",
                            CategoryName = "Vegetarian",
                            CreatedDate = new DateTime(2005, 1, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            CategoryImgUrl = "https://food-images.files.bbci.co.uk/food/recipes/chickensoup_1918_16x9.jpg",
                            CategoryName = "Soup",
                            CreatedDate = new DateTime(2016, 6, 2, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            CategoryImgUrl = "https://media.istockphoto.com/photos/seafood-platter-grilled-lobster-shrimps-scallops-langoustines-octopus-picture-id1305699663?k=20&m=1305699663&s=612x612&w=0&h=x1FHZSXT9H8ttwoD6oDtBKB19QQdDml9ZmY_sZqHuNc=",
                            CategoryName = "Seafood",
                            CreatedDate = new DateTime(2015, 3, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            CategoryImgUrl = "https://static.toiimg.com/thumb/83740315.cms?width=1200&height=900",
                            CategoryName = "Sandwich",
                            CreatedDate = new DateTime(2014, 5, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            CategoryImgUrl = "https://img.taste.com.au/sv9d9AM6/w720-h480-cfill-q80/taste/2016/11/pork-and-bean-burrito-bowl-109208-1.jpeg",
                            CategoryName = "Lunch",
                            CreatedDate = new DateTime(2000, 3, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("backend.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHas")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("backend.Models.Recipe", b =>
                {
                    b.HasOne("backend.Models.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("backend.Models.Category", b =>
                {
                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
