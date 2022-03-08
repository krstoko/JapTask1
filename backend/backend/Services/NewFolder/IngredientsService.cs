using AutoMapper;
using backend.Data;
using backend.Dtos.Ingredient;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Services.NewFolder
{
    public class IngredientsService : IIngredientsService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public IngredientsService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<GetIngredientDto>>> GetAllIngredients()
        {
            var serviceResponse = new ServiceResponse<List<GetIngredientDto>>();
            var dbIngredients = await _dataContext.Ingredients.Select(i => _mapper.Map<GetIngredientDto>(i)).ToListAsync();
            serviceResponse.Data = dbIngredients;
            return serviceResponse;
        }
    }
}
