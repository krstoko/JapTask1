﻿using AutoMapper;
using backend.Dtos.Category;
using backend.Dtos.Ingredient;
using backend.Dtos.Recipe;
using backend.Dtos.RecipeIngredients;
using backend.Models;

namespace backend
{
    public class AutoMapperProfile : Profile

    {
        public AutoMapperProfile()
        {
            CreateMap<Category, GetCategoryDto>();
            CreateMap<Recipe, GetRecipeDto>();
            CreateMap<AddRecipeDto, Recipe>();
            CreateMap<Ingredient, GetIngredientDto>();
            CreateMap<RecipesIngredients, GetRecipeIngredientsDto>();
        }
    }
}
