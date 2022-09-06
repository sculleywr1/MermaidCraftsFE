using MermaidCraftsFE.Client.Models;

namespace MermaidCraftsFE.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category>? Categories { get; set; }
        Task GetCategoriesAsync();
    }
}
