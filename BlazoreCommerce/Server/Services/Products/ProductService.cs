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
            var reponse = new ServiceResponse<List<Product>>()
            {

                Data = await _context.Products.ToListAsync()

            };

            if (reponse != null && reponse.Data != null && reponse.Success)
            {

                return reponse;
            }

            else
            {

                throw new ArgumentNullException(nameof(reponse));
            }

        }
    }
}

