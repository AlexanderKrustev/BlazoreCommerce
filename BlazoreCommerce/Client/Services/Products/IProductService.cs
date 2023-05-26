namespace BlazoreCommerce.Client.Services.Products

{
    public interface IProductService
    {
        Task GetProducts();

        List<Product> Products { get; set; }
    }
}
