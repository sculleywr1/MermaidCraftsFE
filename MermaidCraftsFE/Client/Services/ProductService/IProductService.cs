﻿using MermaidCraftsFE.Shared;

namespace MermaidCraftsFE.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProductsAsync(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductAsync(int id);
    }
}
