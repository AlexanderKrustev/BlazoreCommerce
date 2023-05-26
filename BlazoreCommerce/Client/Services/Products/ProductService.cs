namespace BlazoreCommerce.Client.Services.Products
{
    using BlazoreCommerce.Shared;

    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task GetProducts()
        {
            var results = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products");
            if(results != null && results.Data != null)
            {
                Products = results.Data;
            }
           
        }

        public List<Product> Products { get; set; } = new List<Product>();

    }
}
