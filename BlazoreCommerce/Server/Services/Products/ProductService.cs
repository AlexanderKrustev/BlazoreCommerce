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

        public async Task<ServiceResponse<Product>> GetProductById(int id)
        {
            var response = new ServiceResponse<Product>()
            {
                Data = await this._context.Products
                         .Include(p => p.Variants)
                         .ThenInclude(v => v.ProductType)
                         .FirstOrDefaultAsync(c => c.Id == id)
            };

            if(response != null && response.Data != null)
            {
                return response;
            }
            else
            {
                response.Success = false;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> SearchByWord(string searchtext)
        {
            var response = new ServiceResponse<List<Product>>()
            {
               Data = await this._context.Products.
               Where
               (
                   c => c.Title.ToLower().Contains(searchtext.ToLower()) 
                   ||
                   c.Description.ToLower().Contains(searchtext.ToLower())
                       )
               .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<string>>> SearchSuggestions(string searchtext)
        {
            HashSet<string> allWords = new HashSet<string>();


            var products = await this._context.Products
             .ToListAsync();

            foreach (var product in products)
            {
                foreach (var word in product.Title.Split(new[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries))
                {

                    allWords.Add(word.Trim());
                }

                foreach (var word in product.Description.Split(new[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries))
                {

                    allWords.Add(word.Trim());
                }
            }

            var response = new ServiceResponse<List<string>>()
            {
                Data = allWords.Where(word => word.ToLower().Contains(searchtext.ToLower())).ToList()
            };

            return response;
        }
    }
}

