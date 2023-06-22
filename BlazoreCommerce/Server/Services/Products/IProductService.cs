namespace BlazoreCommerce.Server.Services.Products
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProducts();

        Task<ServiceResponse<Product>> GetProductById(int id);

        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string category);

        Task<ServiceResponse<List<Product>>> SearchByWord(string searchtext);

        Task<ServiceResponse<List<string>>> SearchSuggestions(string searchtext);
    }
}
