#pragma checksum "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\Stripe\SuccessPayment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "860ee291dc1f75d57cf4ccb3da633b7cd1cdea92"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Client.Pages.Stripe
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/success-payment")]
    public partial class SuccessPayment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\Stripe\SuccessPayment.razor"
 if (!IsPaymentComplete)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div style=\"position:fixed;top:50%;left:50%;margin-top:-50px;margin-left:-100px\"><img src=\"images/ajax-loader.gif\"></div>");
#nullable restore
#line 10 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\Stripe\SuccessPayment.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, @"<div class=""container""><div class=""row mt-4 pt-4""><div class=""col-10 offset-1 text-center""><h2 class=""text-warning"">Booking Confirmed</h2>
                <p>Your room has been booked successfully with order id ##</p></div>
            <div class=""col-8 offset-2""><img src=""/images/confirmation.jpg"" width=""100%"" style=""border-radius:30px;""></div></div></div>");
#nullable restore
#line 26 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\Stripe\SuccessPayment.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\Stripe\SuccessPayment.razor"
       
    private bool IsPaymentComplete { get; set; } = false;
    private int OrderId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var orderDetails = await LocalStorage.GetItemAsync<RoomOrderDetailsDto>(SD.LOCAL_ORDER_DETAILS);
        OrderId = orderDetails.Id;

        var finalRoomOrderDetails = await RoomOrderDetailsService.MarkPaymentSuccessful(orderDetails);
        if (finalRoomOrderDetails.Status == SD.STATUS_BOOKED)
        {
            await LocalStorage.RemoveItemAsync(SD.LOCAL_INITIAL_BOOKING);
            await LocalStorage.RemoveItemAsync(SD.LOCAL_ORDER_DETAILS);

            IsPaymentComplete = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomOrderDetailsService RoomOrderDetailsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591