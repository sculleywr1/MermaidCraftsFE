using MermaidCraftsFE.Client;
using MermaidCraftsFE.Client.Services.CategoryService;
using MermaidCraftsFE.Client.Services.HeaderService;
using MermaidCraftsFE.Client.Services.ProductService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add a scoped host to the service. This injects the services into the program. It is a form of Dependency Injection.
builder.Services.AddScoped(sp => new HttpClient(new HeaderDelegatingHandler()) { BaseAddress = new Uri("https://mermaidcraftsfeserverapi.azure-api.net") });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

await builder.Build().RunAsync();
