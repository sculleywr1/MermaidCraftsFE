using MermaidCraftsFE.Shared;
using System.Net.Http.Json;

namespace MermaidCraftsFE.Client.Services.CategoryService
{
    // Gets a list of all categories.
    public class CategoryService : ICategoryService
    {
        // private readonly http client.
        private readonly HttpClient _httpClient;

        // Sets the httpClient for the CategoryService
        public CategoryService(HttpClient httpClient)
        {
            // Sets the HTTPClient.
            _httpClient = httpClient;
        }
        // Gets the value of the categories property.
        public List<Category>? Categories { get; set; }

        // Gets a list of all categories.
        public async Task GetCategoriesAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            // Sets response. Data. Categories.
            if (response != null && response.Data != null)
            {
                // Categories setter.
                Categories = response.Data;
            }
            else
            {
                // Categories setter to use if there is no response or the data is null. Returns an empty List of categories
                Categories = new List<Category>();
            }
        }
    }
}
