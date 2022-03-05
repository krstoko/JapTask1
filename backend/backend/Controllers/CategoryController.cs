﻿
using backend.Models;
using backend.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            return Ok(await _categoryService.GetAllCategories());
        }

    }
}
