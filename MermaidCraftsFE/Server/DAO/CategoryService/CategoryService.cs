using MermaidCraftsFE.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace MermaidCraftsFE.Server.DAO.CategoryService
{
    public class CategoryService : ICategoryService
    {
        // Private data context readonly.
        private readonly DataContext _context;

        // Sets the context for the service.
        public CategoryService(DataContext context)
        {
            _context = context;
        }
        // Gets the list of categories.
        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}
