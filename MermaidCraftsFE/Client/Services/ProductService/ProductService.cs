using MermaidCraftsFE.Shared;
using System.Net.Http.Json;

namespace MermaidCraftsFE.Client.Services.ProductService
{
    // Gets a list of products.
    public class ProductService : IProductService
    {
        // private readonly http client.
        private readonly HttpClient _httpClient;

        // Sets the HttpClient for the product service.
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        // Action Products changed.
        public event Action ProductsChanged;

        // Get a product by the specified product ID.
        public async Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{id}");
            return result;
        }
        // Gets a list of all products.
        public async Task GetProductsAsync(string? categoryUrl = null)
        {
            // Gets a list of products. Two possibilities exist for this method: either it gets all of the products, or, if the URL is for a category, it gets all products in the category from the server.
            var result = categoryUrl == null ?
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            // Invokes the ProductsChanged event.
            ProductsChanged.Invoke();
        }
    }
}
