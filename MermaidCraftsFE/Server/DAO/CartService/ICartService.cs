namespace MermaidCraftsFE.Server.DAO.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProductAsync(List<CartItem> cartItems);
    }
}
