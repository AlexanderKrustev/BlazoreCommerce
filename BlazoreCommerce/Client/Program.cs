global using BlazoreCommerce.Shared;
global using System.Net.Http.Json;
using BlazoreCommerce.Client;
using BlazoreCommerce.Client.Services.Categoreis;
using BlazoreCommerce.Client.Services.Products;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();



await builder.Build().RunAsync();
