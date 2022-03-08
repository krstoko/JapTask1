﻿using AutoMapper;
using backend.Data;
using backend.Dtos.Category;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {

        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        public CategoryService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategories()
        {
            var serviceResponse = new ServiceResponse<List<GetCategoryDto>>();
            var dbCategories = await _dataContext.Categories.Select(c => _mapper.Map<GetCategoryDto>(c)).ToListAsync();
            serviceResponse.Data = dbCategories;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCategoryDto>>> GetLoadMoreCategories(int displeyedCategories, int pageSize)
        {
            var serviceResponse = new ServiceResponse<List<GetCategoryDto>>();
            var dbCategories = await _dataContext.Categories.OrderByDescending(c => c.CreatedDate).Select(c => _mapper.Map<GetCategoryDto>(c)).ToListAsync();
            var piece = dbCategories.Skip(displeyedCategories).Take(pageSize).ToList();
            if (dbCategories.Count() <= displeyedCategories + pageSize)
            {
                serviceResponse.LoadMore = false;
                serviceResponse.Message = "Cant load more";
            }
            serviceResponse.Data = piece;
            return serviceResponse;
        }
    }
}
