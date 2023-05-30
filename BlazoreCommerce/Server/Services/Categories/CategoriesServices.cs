using BlazoreCommerce.Server.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazoreCommerce.Server.Services.Categories;
public class CategoryService : ICategoryService
{
    private readonly DataContext _dataContext;

    public CategoryService(DataContext dataContext)
    {
        this._dataContext = dataContext;
    }

    public async Task<ServiceResponse<List<Category>>> GetCategories()
    {
        
        var result = await this._dataContext.Categories.ToListAsync();
        var resopnse = new ServiceResponse<List<Category>>()
        {
            Data = result
        };
        if (result==null || resopnse.Data == null)
        {
            resopnse.Success = false;
        }
        return resopnse;
    }
}

