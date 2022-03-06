using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Beef", CategoryImgUrl = "https://media.istockphoto.com/photos/grilled-striploin-steak-picture-id535786572?k=20&m=535786572&s=612x612&w=0&h=WAOuIsIUQB7zVW23C6MX9y5QCyl6KLPL2eYcOcc_Qdk=", CreatedDate = new DateTime(2012, 5, 5, 1, 47, 0) },
                new Category { Id = 2, CategoryName = "Bread", CategoryImgUrl = "https://media.istockphoto.com/photos/heap-of-bread-picture-id995038782?k=20&m=995038782&s=612x612&w=0&h=40HBdtHiBgOESo870LBOgc6xUt1E3bqhOhqPCXZTNbc=", CreatedDate = new DateTime(2010, 1, 1, 7, 47, 0) },
                new Category { Id = 3, CategoryName = "Breakfast", CategoryImgUrl = "https://simply-delicious-food.com/wp-content/uploads/2018/10/breakfast-board.jpg", CreatedDate = new DateTime(2005, 2, 1, 7, 47, 0) },
                new Category { Id = 4, CategoryName = "Cake", CategoryImgUrl = "https://funcakes.com/content/uploads/2021/02/Red-Velvet-Cake-with-Fruit-960x720-c-default.jpg", CreatedDate = new DateTime(2015, 3, 1, 7, 47, 0) },
                new Category { Id = 5, CategoryName = "Candy", CategoryImgUrl = "https://images.theconversation.com/files/439369/original/file-20220104-19-12kg47e.jpg?ixlib=rb-1.1.0&q=45&auto=format&w=1200&h=900.0&fit=crop", CreatedDate = new DateTime(2018, 4, 1, 7, 47, 0) },
                new Category { Id = 6, CategoryName = "Chicken", CategoryImgUrl = "https://assets.bonappetit.com/photos/5f809c81ba63e7584fca0576/8:5/w_1800,h_1125,c_limit/Double-Garlic-Roast-Chicken-With-Onion-Gravy.jpg", CreatedDate = new DateTime(2020, 5, 1, 7, 47, 0) },
                new Category { Id = 7, CategoryName = "Italian", CategoryImgUrl = "https://static.onecms.io/wp-content/uploads/sites/23/2020/06/23/italian-food-2000.jpg", CreatedDate = new DateTime(2021, 6, 1, 7, 47, 0) },
                new Category { Id = 8, CategoryName = "Salad", CategoryImgUrl = "https://saladswithanastasia.com/wp-content/uploads/2021/12/radish-green-salad-land1.jpg", CreatedDate = new DateTime(2010, 7, 1, 7, 47, 0) },
                new Category { Id = 9, CategoryName = "Pie", CategoryImgUrl = "https://www.thespruceeats.com/thmb/MbHAC6HNO7rjkZXA_GwHvbQ46EA=/2000x1500/smart/filters:no_upscale()/basic-cherry-pie-recipe-995136-14-dfe79487adf64a848a49dd07983b6614.jpg", CreatedDate = new DateTime(2012, 8, 1, 7, 47, 0) },
                new Category { Id = 10, CategoryName = "French", CategoryImgUrl = "https://insidr.co/wp-content/uploads/2018/04/Boeuf-Bourguignon-1170x780-2.jpg", CreatedDate = new DateTime(2000, 9, 1, 7, 47, 0) },
                new Category { Id = 11, CategoryName = "Fruit", CategoryImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature.jpg?sfvrsn=64942d53_4", CreatedDate = new DateTime(2001, 10, 1, 7, 47, 0) },
                new Category { Id = 12, CategoryName = "Rice", CategoryImgUrl = "https://www.thoughtco.com/thmb/F5IEThuihsz_k-ptOUx1SP4KJoI=/2119x1192/smart/filters:no_upscale()/chopped-pork-meat-cooked-with-red-chili-paste--gochujang-sauce--over-rice-690784532-5c8bd3dc46e0fb000146acf1.jpg", CreatedDate = new DateTime(2002, 11, 1, 7, 47, 0) },
                new Category { Id = 13, CategoryName = "Thai", CategoryImgUrl = "https://www.thespruceeats.com/thmb/TTsydZkvlx25nvMQPZq0wB5o87c=/1500x1500/smart/filters:no_upscale()/GettyImages-1042998066-518ca1d7f2804eb09039e9e42e91667c.jpg", CreatedDate = new DateTime(2003, 12, 1, 7, 47, 0) },
                new Category { Id = 14, CategoryName = "Vegetarian", CategoryImgUrl = "https://post.healthline.com/wp-content/uploads/2020/09/vegetarian-diet-plan-732x549-thumbnail.jpg", CreatedDate = new DateTime(2005, 1, 1, 7, 47, 0) },
                new Category { Id = 15, CategoryName = "Soup", CategoryImgUrl = "https://food-images.files.bbci.co.uk/food/recipes/chickensoup_1918_16x9.jpg", CreatedDate = new DateTime(2016, 6, 2, 7, 47, 0) },
                new Category { Id = 16, CategoryName = "Seafood", CategoryImgUrl = "https://media.istockphoto.com/photos/seafood-platter-grilled-lobster-shrimps-scallops-langoustines-octopus-picture-id1305699663?k=20&m=1305699663&s=612x612&w=0&h=x1FHZSXT9H8ttwoD6oDtBKB19QQdDml9ZmY_sZqHuNc=", CreatedDate = new DateTime(2015, 3, 1, 7, 47, 0) },
                new Category { Id = 17, CategoryName = "Sandwich", CategoryImgUrl = "https://static.toiimg.com/thumb/83740315.cms?width=1200&height=900", CreatedDate = new DateTime(2014, 5, 1, 7, 47, 0) },
                new Category { Id = 18, CategoryName = "Lunch", CategoryImgUrl = "https://img.taste.com.au/sv9d9AM6/w720-h480-cfill-q80/taste/2016/11/pork-and-bean-burrito-bowl-109208-1.jpeg", CreatedDate = new DateTime(2000, 3, 1, 7, 47, 0) }
            );
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
