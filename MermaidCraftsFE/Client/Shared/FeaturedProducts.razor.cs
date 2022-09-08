using MermaidCraftsFE.Client.Services.ProductService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Shared
{
    public class FeaturedProductsBase : ComponentBase, IDisposable
    {
        [Inject] protected IProductService? productService { get; set; }
        protected override void OnInitialized()
        {
            productService.ProductsChanged += StateHasChanged;
        }

        public void Dispose()
        {
            productService.ProductsChanged -= StateHasChanged;
        }
    }
}
