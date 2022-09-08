﻿using Blazored.LocalStorage;
using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.CartService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Shared
{
    public class CartCounterBase : ComponentBase, IDisposable
    {
        [Inject] ISyncLocalStorageService? LocalStorage { get; set; }
        [Inject] ICartService? CartService { get; set; }

        protected int GetCartItemsCount()
        {
            var cart = LocalStorage.GetItem<int>("cartItemsCount");
            return cart;
        }

        protected override void OnInitialized()
        {
            CartService.OnChange += StateHasChanged;
        }

        public void Dispose()
        {
            CartService.OnChange -= StateHasChanged;
        }
    }
}
