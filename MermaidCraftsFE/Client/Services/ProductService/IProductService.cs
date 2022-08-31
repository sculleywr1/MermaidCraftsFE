using MermaidCraftsFE.Shared;

namespace MermaidCraftsFE.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}
