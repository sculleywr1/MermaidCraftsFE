using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.OrderService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Pages
{
    public class OrderDetailsBase: ComponentBase
    {
        //parameters
        [Parameter]
        public int OrderId { get; set; }
        //Injection
        [Inject] protected IOrderService OrderService { get; set; }

        protected OrderDetailsResponse order = null;

        protected override async Task OnInitializedAsync()
        {
            order = await OrderService.GetOrderDetails(OrderId);
        }

        
    }
}
