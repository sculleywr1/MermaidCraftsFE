﻿using MermaidCraftsFE.Shared;
using System.Net.Http.Json;

namespace MermaidCraftsFE.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{id}");
            return result;
        }
        public async Task GetProductsAsync(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChanged.Invoke();
        }
    }
}
