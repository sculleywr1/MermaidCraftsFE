using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.CartService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Pages
{
    public class CartBase : ComponentBase
    {
        public List<CartProductResponse> cartProducts = null;
        public string message = "Loading cart...";
        [Inject] ICartService? CartService { get; set; }
        

        protected override async Task OnInitializedAsync()
        {
            await LoadCart();
        }

        public async Task RemoveProductFromCart(int productId, int productTypeId)
        {
            await CartService.RemoveProductFromCart(productId, productTypeId);
            await LoadCart();
        }

        public async Task LoadCart()
        {
            if ((await CartService.GetCartItems()).Count == 0)
            {
                message = "Your cart is empty.";
                cartProducts = new List<CartProductResponse>();
            }
            else
            {
                cartProducts = await CartService.GetCartProducts();
            }
        }

        public async Task UpdateQuantity(ChangeEventArgs e, CartProductResponse product)
        {
            product.Quantity = int.Parse(e.Value.ToString());
            if (product.Quantity < 1)
            {
                product.Quantity = 1;
            }
            await CartService.UpdateQuantity(product);
        }

    }
}
