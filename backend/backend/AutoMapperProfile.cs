using AutoMapper;
using backend.Dtos.Category;
using backend.Models;

namespace backend
{
    public class AutoMapperProfile : Profile

    {
        public AutoMapperProfile()
        {
            CreateMap<Category, GetCategoryDto>();
        }
    }
}
