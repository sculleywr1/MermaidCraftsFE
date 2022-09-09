using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.AuthService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace MermaidCraftsFE.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;
        private readonly NavigationManager _navigationManager;

        public OrderService(HttpClient httpClient, IAuthService authService, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _authService = authService;
            _navigationManager = navigationManager;
        }
        public async Task<OrderDetailsResponse> GetOrderDetails(int orderId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<OrderDetailsResponse>>($"api/orders/{orderId}");
            return result.Data;
        }

        public async Task<List<OrderOverviewResponse>> GetOrders()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<OrderOverviewResponse>>>("api/orders");
            return result.Data;
        }

        public async Task PlaceOrder()
        {
            if (await _authService.IsUserAuthenticated())
            {
                await _httpClient.PostAsync("api/orders", null);
            }
            else
            {
                _navigationManager.NavigateTo("login");
            }
        }
    }
}
