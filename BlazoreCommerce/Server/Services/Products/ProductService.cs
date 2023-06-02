using BlazoreCommerce.Server.Database;
using Microsoft.EntityFrameworkCore;

namespace BlazoreCommerce.Server.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var response = new ServiceResponse<List<Product>>();            
            response.Data = await _context.Products
               .Include(p=>p.Variants)
               .ThenInclude(v=>v.ProductType)
               .ToListAsync();
            if (response != null && response.Data != null && response.Success)
            {
                return response;
            }
            else
            {
                throw new ArgumentNullException(nameof(response));
            }
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string category)
        {
           
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await this._context.Products.
                Where(c => c.Category.Url.ToLower().Contains(category.ToLower())).ToListAsync()
            };

            return response;
        }
    }
}

