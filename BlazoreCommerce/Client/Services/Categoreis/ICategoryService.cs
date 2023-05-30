namespace BlazoreCommerce.Client.Services.Categoreis
{
    public interface ICategoryService
    {
       List<Category> Categories { get; set;  }

        Task GetCategoreis();
    }
}
