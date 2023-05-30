namespace BlazoreCommerce.Client.Services.Products

{
    public interface IProductService
    {
        event Action ProductChanged;
        Task GetProducts(string? category=null);
        List<Product> Products { get; set; }
    }
}
