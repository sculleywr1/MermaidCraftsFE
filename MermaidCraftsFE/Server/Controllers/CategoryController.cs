using MermaidCraftsFE.Server.DAO.CategoryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MermaidCraftsFE.Server.Controllers
{
    // Gets all categories.
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // Private method for _categoryService.
        private readonly ICategoryService _categoryService;

        // Sets the category controller.
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // Gets all categories.
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return Ok(result);
        }
    }
}
