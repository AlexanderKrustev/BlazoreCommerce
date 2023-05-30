using BlazoreCommerce.Server.Services.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazoreCommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var result = await this._categoryService.GetCategories();
            if(result !=null && result.Data != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
