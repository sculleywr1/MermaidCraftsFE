using MermaidCraftsFE.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace MermaidCraftsFE.Server.DAO.ProductService
{
    // Handles all the logic for retrieving products from the database.
    public class ProductService : IProductService
    
    {
        // Private data context readonly.
        private readonly DataContext _context;

        // Sets the context for the service.
        public ProductService(DataContext context)
        {
            _context = context;
        }

        // Gets a product by its ID.
        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.Include(p => p.Variants).ThenInclude(v => v.ProductType).FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "This product does not exist on our database :(";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        // Gets all products.
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Include(p => p.Variants).ToListAsync()
            };
            return response;
        }

        // Get a list of products by category.
        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).Include(p => p.Variants).ToListAsync()
            };

            return response;
        }
    }
}
