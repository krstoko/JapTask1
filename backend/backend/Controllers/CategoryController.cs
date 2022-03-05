using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private static Category category = new Category();
        [HttpGet]
        public ActionResult<Category> get()
        {
            return Ok(category);
        }

    }
}
