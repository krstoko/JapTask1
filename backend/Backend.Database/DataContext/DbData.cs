using backend.Core.Common;
using backend.Models;
using System;
using System.Collections.Generic;

namespace backend.Data
{
    public class DbData
    {
        public static List<Category> GetCategories()
        {
            var categories = new List<Category>()
            {

                new Category { Id = 2, Name = "Bread", ImgUrl = "https://media.istockphoto.com/photos/heap-of-bread-picture-id995038782?k=20&m=995038782&s=612x612&w=0&h=40HBdtHiBgOESo870LBOgc6xUt1E3bqhOhqPCXZTNbc=", CreatedDate = new DateTime(2010, 1, 1, 7, 47, 0) },
                new Category { Id = 3, Name = "Breakfast", ImgUrl = "https://simply-delicious-food.com/wp-content/uploads/2018/10/breakfast-board.jpg", CreatedDate = new DateTime(2005, 2, 1, 7, 47, 0) },
                new Category { Id = 4, Name = "Cake", ImgUrl = "https://funcakes.com/content/uploads/2021/02/Red-Velvet-Cake-with-Fruit-960x720-c-default.jpg", CreatedDate = new DateTime(2015, 3, 1, 7, 47, 0) },
                new Category { Id = 5, Name = "Candy", ImgUrl = "https://images.theconversation.com/files/439369/original/file-20220104-19-12kg47e.jpg?ixlib=rb-1.1.0&q=45&auto=format&w=1200&h=900.0&fit=crop", CreatedDate = new DateTime(2018, 4, 1, 7, 47, 0) },
                new Category { Id = 6, Name = "Chicken", ImgUrl = "https://assets.bonappetit.com/photos/5f809c81ba63e7584fca0576/8:5/w_1800,h_1125,c_limit/Double-Garlic-Roast-Chicken-With-Onion-Gravy.jpg", CreatedDate = new DateTime(2020, 5, 1, 7, 47, 0) },
                new Category { Id = 7, Name = "Italian", ImgUrl = "https://static.onecms.io/wp-content/uploads/sites/23/2020/06/23/italian-food-2000.jpg", CreatedDate = new DateTime(2021, 6, 1, 7, 47, 0) },
                new Category { Id = 8, Name = "Salad", ImgUrl = "https://saladswithanastasia.com/wp-content/uploads/2021/12/radish-green-salad-land1.jpg", CreatedDate = new DateTime(2010, 7, 1, 7, 47, 0) },
                new Category { Id = 9, Name = "Pie", ImgUrl = "https://www.thespruceeats.com/thmb/MbHAC6HNO7rjkZXA_GwHvbQ46EA=/2000x1500/smart/filters:no_upscale()/basic-cherry-pie-recipe-995136-14-dfe79487adf64a848a49dd07983b6614.jpg", CreatedDate = new DateTime(2012, 8, 1, 7, 47, 0) },
                new Category { Id = 10, Name = "French", ImgUrl = "https://insidr.co/wp-content/uploads/2018/04/Boeuf-Bourguignon-1170x780-2.jpg", CreatedDate = new DateTime(2000, 9, 1, 7, 47, 0) },
                new Category { Id = 11, Name = "Fruit", ImgUrl = "https://www.healthyeating.org/images/default-source/home-0.0/nutrition-topics-2.0/general-nutrition-wellness/2-2-2-3foodgroups_fruits_detailfeature.jpg?sfvrsn=64942d53_4", CreatedDate = new DateTime(2001, 10, 1, 7, 47, 0) },
                new Category { Id = 12, Name = "Rice", ImgUrl = "https://www.thoughtco.com/thmb/F5IEThuihsz_k-ptOUx1SP4KJoI=/2119x1192/smart/filters:no_upscale()/chopped-pork-meat-cooked-with-red-chili-paste--gochujang-sauce--over-rice-690784532-5c8bd3dc46e0fb000146acf1.jpg", CreatedDate = new DateTime(2002, 11, 1, 7, 47, 0) },
                new Category { Id = 13, Name = "Thai", ImgUrl = "https://www.thespruceeats.com/thmb/TTsydZkvlx25nvMQPZq0wB5o87c=/1500x1500/smart/filters:no_upscale()/GettyImages-1042998066-518ca1d7f2804eb09039e9e42e91667c.jpg", CreatedDate = new DateTime(2003, 12, 1, 7, 47, 0) },
                new Category { Id = 14, Name = "Vegetarian", ImgUrl = "https://post.healthline.com/wp-content/uploads/2020/09/vegetarian-diet-plan-732x549-thumbnail.jpg", CreatedDate = new DateTime(2005, 1, 1, 7, 47, 0) },
                new Category { Id = 15, Name = "Soup", ImgUrl = "https://food-images.files.bbci.co.uk/food/recipes/chickensoup_1918_16x9.jpg", CreatedDate = new DateTime(2016, 6, 2, 7, 47, 0) },
                new Category { Id = 16, Name = "Seafood", ImgUrl = "https://media.istockphoto.com/photos/seafood-platter-grilled-lobster-shrimps-scallops-langoustines-octopus-picture-id1305699663?k=20&m=1305699663&s=612x612&w=0&h=x1FHZSXT9H8ttwoD6oDtBKB19QQdDml9ZmY_sZqHuNc=", CreatedDate = new DateTime(2015, 3, 1, 7, 47, 0) },
                new Category { Id = 17, Name = "Sandwich", ImgUrl = "https://static.toiimg.com/thumb/83740315.cms?width=1200&height=900", CreatedDate = new DateTime(2014, 5, 1, 7, 47, 0) },
                new Category { Id = 18, Name = "Lunch", ImgUrl = "https://img.taste.com.au/sv9d9AM6/w720-h480-cfill-q80/taste/2016/11/pork-and-bean-burrito-bowl-109208-1.jpeg", CreatedDate = new DateTime(2000, 3, 1, 7, 47, 0) }
            };
            return categories;
        }

        public static List<Ingredient> GetIngredient()
        {
            var ingredients = new List<Ingredient>()
            {
                new Ingredient { Id = 1, Name = "Ulje", MeasureUnit = MeasureUnit.Liter, PurchaseMeasureQuantity = 1, PurchasePrice = 1.5, LowestMeasureUnitPrice = 0.0015 },
                new Ingredient { Id = 2, Name = "Mlijeko", MeasureUnit = MeasureUnit.Liter, PurchaseMeasureQuantity = 1, PurchasePrice = 0.8, LowestMeasureUnitPrice = 0.0008 },
                new Ingredient { Id = 3, Name = "Voda", MeasureUnit = MeasureUnit.Liter, PurchaseMeasureQuantity = 1, PurchasePrice = 1, LowestMeasureUnitPrice = 0.0010 },
                new Ingredient { Id = 4, Name = "Brasno", MeasureUnit = MeasureUnit.Kilogram, PurchaseMeasureQuantity = 1, PurchasePrice = 2, LowestMeasureUnitPrice = 0.0020 },
                new Ingredient { Id = 5, Name = "Mljeveno meso", MeasureUnit = MeasureUnit.Kilogram, PurchaseMeasureQuantity = 1, PurchasePrice = 3, LowestMeasureUnitPrice = 0.0030 },
                new Ingredient { Id = 6, Name = "Tjestenina", MeasureUnit = MeasureUnit.Kilogram, PurchaseMeasureQuantity = 1, PurchasePrice = 2.3, LowestMeasureUnitPrice = 0.0023 }
        };
            return ingredients;
        }
    }
}
