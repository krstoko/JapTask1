
using AutoMapper;
using backend.Dtos.Category;
using backend.Dtos.Ingredient;
using backend.Dtos.Recipe;
using backend.Dtos.RecipeIngredients;
using backend.Models;
using Backend.Mapper;
using System;
using System.Linq;

namespace backend.Mapper
{
    public class AutoMapperProfile : Profile

    {
        public AutoMapperProfile()
        {
            CreateMap<Category, GetCategoryDto>();
            CreateMap<Recipe, GetRecipeDto>()
                .ForMember(x => x.Price, opt => opt.MapFrom((recipe, recipeDto) => recipeDto.RecipesIngredients.Sum(ri => ri.RealIngredientPrice)));

            CreateMap<AddRecipeDto, Recipe>();
            CreateMap<Ingredient, GetIngredientDto>();
            CreateMap<Ingredient, GetRecipeIngredientsDto>();
            CreateMap<RecipesIngredients, GetRecipeIngredientsDto>()
                .ForMember(x => x.RealIngredientPrice, opt => opt.MapFrom(src => RecipeBusinessLogic.CalculatePrice(src)));
        }


    }
}
