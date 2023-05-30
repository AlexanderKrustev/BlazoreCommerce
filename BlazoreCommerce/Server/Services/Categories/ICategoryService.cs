using Microsoft.AspNetCore.Mvc;

namespace BlazoreCommerce.Server.Services.Categories
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();

    }
}
