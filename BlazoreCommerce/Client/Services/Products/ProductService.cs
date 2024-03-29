﻿namespace BlazoreCommerce.Client.Services.Products
{
    using BlazoreCommerce.Shared;
    using System;

    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public event Action? ProductChanged;

        public ProductService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task GetProducts(string? category = null)
        {
            var result = new ServiceResponse<List<Product>>();
            if(category == null)
            {
                result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products");
                
            }
            else
            {
                result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/products/cat/{category}");
            }
            if(result != null && result.Data!=null) 
            {
                this.Products = result.Data;
                
            }
            ProductChanged.Invoke();
        }

        public async Task<Product> GetProductById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/products/{id}");
            if(result != null && result.Data != null)
            {
                return result.Data;
            }
            else
            {
                throw new ArgumentException("No Such product");
            }

        }

        public List<Product> Products { get; set; } = new List<Product>();

    }
}
