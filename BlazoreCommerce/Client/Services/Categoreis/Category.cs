namespace BlazoreCommerce.Client.Services.Categoreis
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public List<Category> Categories { get ; set ; } = new List<Category>();

        public async Task GetCategoreis()
        {
           var result = await this._httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/categories");

           if(result != null && result.Data !=null)
            {
                Categories = result.Data;
            }          
        }
    }
}
