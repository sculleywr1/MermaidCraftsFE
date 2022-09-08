using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.CartService;
using MermaidCraftsFE.Client.Services.ProductService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Inject] IProductService? ProductService { get; set; }
        [Inject] ICartService? CartService { get; set; }

        protected Product? product = null;
        protected string message = string.Empty;
        protected int currentTypeId = 1;

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {

            message = "Loading Product...";
            var result = await ProductService.GetProductAsync(Id);

            if (!result.Success)
            {
                message = result.Message;
            }
            else
            {
                product = result.Data;
                if (product.Variants.Count > 0)
                {
                    currentTypeId = product.Variants[0].ProductTypeId;
                }
            }
        }

        protected ProductVariant GetSelectedVariant()
        {
            var variant = product.Variants.FirstOrDefault(v => v.ProductTypeId == currentTypeId);
            return variant;
        }

        public async Task AddtoCart()
        {
            var productVariant = GetSelectedVariant();
            var cartItem = new CartItem
            {
                ProductId = productVariant.ProductId,
                ProductTypeId = productVariant.ProductTypeId
            };

            await CartService.AddToCart(cartItem);
        }
    }
}
