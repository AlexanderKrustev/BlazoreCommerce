namespace BlazoreCommerce.Server.Services.Products
{
    public interface IProductService
    {

        Task<ServiceResponse<List<Product>>> GetProducts();

        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string category);
    }
}
