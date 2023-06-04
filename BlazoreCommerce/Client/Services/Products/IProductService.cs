namespace BlazoreCommerce.Client.Services.Products

{
    public interface IProductService
    {
        event Action ProductChanged;

        Task GetProducts(string? category=null);

        Task<Product> GetProductById(int id);

        List<Product> Products { get; set; }
    }
}
