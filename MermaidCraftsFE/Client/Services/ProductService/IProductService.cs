using MermaidCraftsFE.Client.Models;

namespace MermaidCraftsFE.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action? ProductsChanged;
        List<Product> Products { get; set; }
        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        Task GetProductsAsync(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductAsync(int id);
        Task SearchProducts(string searchText, int page);
        Task<List<string>> getProductSearchSuggestions(string searchText);
    }
}
