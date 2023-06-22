using BlazoreCommerce.Server.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace BlazoreCommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {

            var result = await _productService.GetProducts();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductById(int id)
        {

            var result = await _productService.GetProductById(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("search/{searchtext}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsbySearchText(string searchtext)
        {

            var result = await _productService.SearchByWord(searchtext);
            return Ok(result);
        }

        [HttpGet]
        [Route("suggestion/{searchtext}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetSuggestionWordsBySearch(string searchtext)
        {

            var result = await _productService.SearchSuggestions(searchtext);
            return Ok(result);
        }

        [HttpGet]
        [Route("cat/{category}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts(string category)
        {

            var result = await _productService.GetProductsByCategory(category);
            return Ok(result);
        }
    }


}
