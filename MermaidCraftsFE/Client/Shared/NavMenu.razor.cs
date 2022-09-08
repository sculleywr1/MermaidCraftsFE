using MermaidCraftsFE.Client.Services.CategoryService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Shared
{
    public class NavMenuBase : ComponentBase
    {
        [Inject] protected ICategoryService? categoryService { get; set; }
        protected bool collapseNavMenu = true;

        protected string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        protected void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        protected override async Task OnInitializedAsync()
        {
            await categoryService.GetCategoriesAsync();
        }
    }
}
