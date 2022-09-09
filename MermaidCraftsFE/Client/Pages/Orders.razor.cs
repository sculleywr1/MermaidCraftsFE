using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.OrderService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Pages
{
    public class OrdersBase : ComponentBase
    {
        [Inject] IOrderService? OrderService { get; set; }
        protected List<OrderOverviewResponse> orders = null;

        protected override async Task OnInitializedAsync()
        {
            orders = await OrderService.GetOrders();
        }
    }
}
