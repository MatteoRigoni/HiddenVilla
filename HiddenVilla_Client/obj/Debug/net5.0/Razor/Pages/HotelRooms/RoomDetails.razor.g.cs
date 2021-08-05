#pragma checksum "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65689204e0d1746c57ee659dd747caf8ecb39f0a"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Client.Pages.HotelRooms
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
#nullable restore
#line 7 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
           [Authorize(Roles =SD.ROLE_CUSTOMER)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel/room-details/{Id:int}")]
    public partial class RoomDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
 if (HotelBooking?.OrderDetails?.HotelRoomDto?.HotelRoomImages == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 13 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mt-4 mx-4 px-0 px-md-5 mx-md-5");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row p-2 my-3 ");
            __builder.AddAttribute(5, "style", "border-radius:20px; ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 col-lg-7 p-4");
            __builder.AddAttribute(8, "style", "border: 1px solid #fff");
            __builder.AddMarkupContent(9, @"<div class=""row px-2 text-success border-bottom""><div class=""col-8 py-1""><p style=""font-size:x-large;margin:0px;"">Selected Room</p></div>
                    <div class=""col-4 p-0 text-end""><a href=""hotel/rooms"" class=""btn btn-secondary btn-block"">Back to Room's</a></div></div>

                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, @"<div class=""col-6""><div id class=""carousel slide mb-4 m-md-3 m-0 pt-3 pt-md-0"" data-ride=""carousel""><div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel""><ol class=""carousel-indicators""><li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li></ol>
                                <div class=""carousel-inner""><div class=""carousel-item active""><img class=""d-block w-100"" src=""images/slide1.jpg"" alt=""First slide""></div></div>
                                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                    <span class=""sr-only"">Previous</span></a>
                                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                    <span class=""sr-only"">Next</span></a></div></div></div>
                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-6");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "float-right pt-4 text-end");
            __builder.AddAttribute(17, "style", "width:100%;float:right");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "float-right");
            __builder.AddContent(20, "Max Occupancy : ");
            __builder.AddContent(21, 
#nullable restore
#line 51 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                                       HotelBooking.OrderDetails.HotelRoomDto.Occupancy

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " adults ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<br>\r\n                            ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "float-right pt-1");
            __builder.AddContent(26, "Villa Size : ");
            __builder.AddContent(27, 
#nullable restore
#line 52 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                                         HotelBooking.OrderDetails.HotelRoomDto.SqFt

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, " sqft");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "<br>\r\n                            ");
            __builder.OpenElement(30, "h4");
            __builder.AddAttribute(31, "class", "text-warning font-weight-bold pt-5 pl-5");
            __builder.AddMarkupContent(32, "\r\n                                USD\r\n                                ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "style", "border-bottom:1px solid #ff6a00");
            __builder.AddContent(35, 
#nullable restore
#line 56 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                     HotelBooking.OrderDetails.HotelRoomDto.TotalAmount.ToString("#.#,00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "span");
            __builder.AddAttribute(38, "class", "float-right");
            __builder.AddContent(39, "Cost for ");
            __builder.AddContent(40, 
#nullable restore
#line 59 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                                HotelBooking.OrderDetails.HotelRoomDto.TotalDays

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, " nights");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row p-2");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-12");
            __builder.OpenElement(47, "p");
            __builder.AddAttribute(48, "class", "card-title text-warning");
            __builder.AddAttribute(49, "style", "font-size:xx-large");
            __builder.AddContent(50, 
#nullable restore
#line 65 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                                                       HotelBooking.OrderDetails.HotelRoomDto.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "p");
            __builder.AddAttribute(53, "class", "card-text");
            __builder.AddAttribute(54, "style", "font-size:large");
            __builder.AddContent(55, 
#nullable restore
#line 67 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                              (MarkupString)HotelBooking.OrderDetails.HotelRoomDto.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-12 col-lg-5 p-4 2 mt-4 mt-md-0 ");
            __builder.AddAttribute(59, "style", "border: 1px solid #fff");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(60);
            __builder.AddAttribute(61, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 75 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                 HotelBooking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "class", "container");
            __builder.AddAttribute(63, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 75 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                                                HandleCheckout

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(65, "<div class=\"row px-2 text-success border-bottom  justify-content-end\"><div class=\"col-7 py-1\"><p style=\"font-size:x-large;margin:0px;text-align:right\">Enter Details</p></div></div>\r\n\r\n                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group pt-2");
                __builder2.AddMarkupContent(68, "<label class=\"text-warning\">Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(69);
                __builder2.AddAttribute(70, "type", "text");
                __builder2.AddAttribute(71, "class", "form-control");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                HotelBooking.OrderDetails.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelBooking.OrderDetails.Name = __value, HotelBooking.OrderDetails.Name))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelBooking.OrderDetails.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group pt-2");
                __builder2.AddMarkupContent(78, "<label class=\"text-warning\">Phone</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "type", "text");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                HotelBooking.OrderDetails.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelBooking.OrderDetails.Phone = __value, HotelBooking.OrderDetails.Phone))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelBooking.OrderDetails.Phone));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "<label class=\"text-warning\">Email</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(89);
                __builder2.AddAttribute(90, "type", "text");
                __builder2.AddAttribute(91, "class", "form-control");
                __builder2.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 89 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                HotelBooking.OrderDetails.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelBooking.OrderDetails.Email = __value, HotelBooking.OrderDetails.Email))));
                __builder2.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelBooking.OrderDetails.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                    ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group");
                __builder2.AddMarkupContent(98, "<label class=\"text-warning\">Check in Date</label>\r\n                        ");
                __Blazor.HiddenVilla_Client.Pages.HotelRooms.RoomDetails.TypeInference.CreateInputDate_0(__builder2, 99, 100, "date", 101, "form-control", 102, 
#nullable restore
#line 93 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                HotelBooking.OrderDetails.CheckinDate

#line default
#line hidden
#nullable disable
                , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelBooking.OrderDetails.CheckinDate = __value, HotelBooking.OrderDetails.CheckinDate)), 104, () => HotelBooking.OrderDetails.CheckinDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group");
                __builder2.AddMarkupContent(108, "<label class=\"text-warning\">Check Out Date</label>\r\n                        ");
                __Blazor.HiddenVilla_Client.Pages.HotelRooms.RoomDetails.TypeInference.CreateInputDate_1(__builder2, 109, 110, "date", 111, "form-control", 112, 
#nullable restore
#line 97 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                HotelBooking.OrderDetails.CheckoutDate

#line default
#line hidden
#nullable disable
                , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelBooking.OrderDetails.CheckoutDate = __value, HotelBooking.OrderDetails.CheckoutDate)), 114, () => HotelBooking.OrderDetails.CheckoutDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "form-group");
                __builder2.AddMarkupContent(118, "<label class=\"text-warning\">No. of nights</label>\r\n                        ");
                __builder2.OpenElement(119, "select");
                __builder2.AddAttribute(120, "class", "form-control");
                __builder2.AddAttribute(121, "value", 
#nullable restore
#line 101 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                             NoOfNights

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 103 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                             for (var i = 1; i <= 10; i++)
                            {
                                if (i == NoOfNights)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(122, "option");
                __builder2.AddAttribute(123, "value", 
#nullable restore
#line 107 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                    i

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(124, "selected", "selected");
                __builder2.AddContent(125, 
#nullable restore
#line 107 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                                            i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 108 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(126, "option");
                __builder2.AddAttribute(127, "value", 
#nullable restore
#line 111 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                    i

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(128, 
#nullable restore
#line 111 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                                        i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 112 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
                                }
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                    <br>\r\n                    ");
                __builder2.AddMarkupContent(130, "<div class=\"form-group\"><button type=\"submit\" class=\"btn btn-success form-control\">Checkout Now</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 124 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\RoomDetails.razor"
       
    [Parameter]
    public int? Id { get; set; }

    public HotelRoomBookingViewModel HotelBooking { get; set; } = new HotelRoomBookingViewModel();
    private int NoOfNights { get; set; } = 1;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await Task.Delay(5000);
            HotelBooking.OrderDetails = new RoomOrderDetailsDto();
            if (Id != null)
            {
                if (await LocalStorage.GetItemAsync<HomeVM>(SD.LOCAL_INITIAL_BOOKING) != null)
                {
                    var roomInitialInfo = await LocalStorage.GetItemAsync<HomeVM>(SD.LOCAL_INITIAL_BOOKING);
                    HotelBooking.OrderDetails.HotelRoomDto = await HotelRoomService.GetHotelRoomDetail(Id.Value,
                        roomInitialInfo.StartDate.ToString("MM/dd/yyyy"), roomInitialInfo.EndDate.ToString("MM/dd/yyyy"));
                    NoOfNights = roomInitialInfo.NoOfNights;
                    HotelBooking.OrderDetails.CheckinDate = roomInitialInfo.StartDate;
                    HotelBooking.OrderDetails.CheckoutDate = roomInitialInfo.EndDate;
                    HotelBooking.OrderDetails.HotelRoomDto.TotalDays = roomInitialInfo.NoOfNights;
                    HotelBooking.OrderDetails.HotelRoomDto.TotalAmount =
                        roomInitialInfo.NoOfNights * HotelBooking.OrderDetails.HotelRoomDto.RegularRate;
                }
                else
                {
                    HotelBooking.OrderDetails.HotelRoomDto = await HotelRoomService.GetHotelRoomDetail(Id.Value,
                        DateTime.UtcNow.ToString("MM/dd/yyyy"), DateTime.UtcNow.AddDays(1).ToString("MM/dd/yyyy"));
                    NoOfNights = 1;
                    HotelBooking.OrderDetails.CheckinDate = DateTime.UtcNow;
                    HotelBooking.OrderDetails.CheckoutDate = DateTime.UtcNow.AddDays(1);
                    HotelBooking.OrderDetails.HotelRoomDto.TotalDays = 1;
                    HotelBooking.OrderDetails.HotelRoomDto.TotalAmount = HotelBooking.OrderDetails.HotelRoomDto.RegularRate;
                }
            }
        }
        catch (Exception ex)
        {
            await JSRuntime.ToastrError(ex.Message);
        }
    }

    private async Task HandleNoOfNightsChange(ChangedEventArgs e)
    {
        NoOfNights = Convert.ToInt32(e.NewValue.ToString());
        HotelBooking.OrderDetails.HotelRoomDto = await HotelRoomService.GetHotelRoomDetail(Id.Value,
            HotelBooking.OrderDetails.CheckinDate.ToString("MM/dd/yyyy"),
            HotelBooking.OrderDetails.CheckinDate.AddDays(NoOfNights).ToString("MM/dd/yyyy"));

        HotelBooking.OrderDetails.CheckoutDate = HotelBooking.OrderDetails.CheckinDate.AddDays(NoOfNights);
        HotelBooking.OrderDetails.HotelRoomDto.TotalDays = NoOfNights;
        HotelBooking.OrderDetails.HotelRoomDto.TotalAmount = NoOfNights * HotelBooking.OrderDetails.HotelRoomDto.RegularRate;
    }

    private async Task HandleCheckout()
    {
        if (!await HandleValidation())
        {
            return;
        }

        try
        {
            var paymentDto = new StripePaymentDTO()
            {
                Amount = Convert.ToInt32(HotelBooking.OrderDetails.HotelRoomDto.TotalAmount),
                ProductName = HotelBooking.OrderDetails.HotelRoomDto.Name,
                ReturnUrl = "https://localhost:44372/hotel/room-details/" + Id
            };

            var result = await StripePaymentService.Checkout(paymentDto);

            HotelBooking.OrderDetails.StripeSessionId = result.Data.ToString();
            HotelBooking.OrderDetails.RoomId = HotelBooking.OrderDetails.HotelRoomDto.Id;
            HotelBooking.OrderDetails.TotalCost = HotelBooking.OrderDetails.HotelRoomDto.TotalAmount;

            var rooOrderDetailsSaved = await RoomOrderDetailsService.SaveRoomOrderDetails(HotelBooking.OrderDetails);
            await LocalStorage.SetItemAsync(SD.LOCAL_ORDER_DETAILS, rooOrderDetailsSaved);

            await JSRuntime.InvokeVoidAsync("redirectToCheckout", result.Data.ToString());
        }
        catch (Exception e)
        {
            await JSRuntime.ToastrError(e.Message);
        }
    }

    private async Task<bool> HandleValidation()
    {
        if (string.IsNullOrEmpty(HotelBooking.OrderDetails.Name))
        {
            await JSRuntime.ToastrError("Name cannot be empty");
            return false;
        }
        if (string.IsNullOrEmpty(HotelBooking.OrderDetails.Phone))
        {
            await JSRuntime.ToastrError("Phone cannot be empty");
            return false;
        }
        if (string.IsNullOrEmpty(HotelBooking.OrderDetails.Email))
        {
            await JSRuntime.ToastrError("Email cannot be empty");
            return false;
        }

        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStripePaymentService StripePaymentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomOrderDetailsService RoomOrderDetailsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomService HotelRoomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Client.Pages.HotelRooms.RoomDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
