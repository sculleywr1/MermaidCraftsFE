using MermaidCraftsFE.Client.Services.ProductService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MermaidCraftsFE.Client.Shared
{
    public class SearchBase : ComponentBase
    {
        [Inject] NavigationManager? NavigationManager { get; set; }
        [Inject] IProductService? productService { get; set; }
        protected string searchText = string.Empty;
        protected List<string> suggestions = new List<string>();
        protected ElementReference searchInput;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await searchInput.FocusAsync();
            }
        }

        public void SearchProducts()
        {
            NavigationManager.NavigateTo($"search/{searchText}/1");
        }

        public async Task HandleSearch(KeyboardEventArgs args)
        {
            if (args.Key == null || args.Key.Equals("Enter"))
            {
                SearchProducts();
            }
            else if (searchText.Length > 1)
            {
                suggestions = await productService.getProductSearchSuggestions(searchText);
            }
        }
    }
}
