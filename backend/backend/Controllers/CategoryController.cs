
using backend.Dtos.Category;
using backend.Models;
using backend.Services.CategoryService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ServiceResponse<List<GetCategoryDto>>>> GetLoadMoreCategories(int displeyedCategories, int pageSize)
        {
            return Ok(await _categoryService.GetLoadMoreCategories(displeyedCategories, pageSize));
        }

        [HttpGet("All")]
        public async Task<ActionResult<ServiceResponse<List<GetCategoryDto>>>> GetAllCategory()
        {
            return Ok(await _categoryService.GetAllCategories());
        }

    }
}
