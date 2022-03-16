using backend.Data;
using backend.Services.CategoryService;
using backend.Services.RecipeService;
using backend.Services.IngredientService;
using Microsoft.Extensions.DependencyInjection;

namespace backend.Extensions
{
    public static class ServiceRegistration
    {
        public static void SetupServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IIngredientsService, IngredientService>();
        }
    }
}
