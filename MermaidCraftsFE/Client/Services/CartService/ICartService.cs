using MermaidCraftsFE.Client.Models;

namespace MermaidCraftsFE.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem cartItem);
        Task GetCartItemsCount();
        Task StoreCartItems(bool emptyLocalCart);
        Task<List<CartProductResponse>> GetCartProducts();
        Task RemoveProductFromCart(int productId, int productTypeId);
        Task UpdateQuantity(CartProductResponse product);
    }
}
