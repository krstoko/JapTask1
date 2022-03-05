
using backend.Models;
using backend.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private static List<Category> categories = new List<Category>
        {
            new Category(),
            new Category{ Id = 1, CategoryName = "Oil" }
        };
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public ActionResult<Category> get()
        {
            return Ok(_categoryService.GetAllCategories());
        }

    }
}
