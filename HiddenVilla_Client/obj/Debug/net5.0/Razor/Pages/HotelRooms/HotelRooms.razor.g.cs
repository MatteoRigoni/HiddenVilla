#pragma checksum "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "751c0a35aeadd73b0e0e993e5c062cfe2d82ce8a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel/rooms")]
    public partial class HotelRooms : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
 if (Rooms != null && Rooms.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                     HomeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                               SaveBookingInfo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "bg-light");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "pt-3 pb-2 px-5 mx-1 mx-md-0 bg-secondary");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row px-3 mx-3 justify-content-center");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-4 col-md-3");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label class=\"text-warning\">Check in Date</label>\r\n                        ");
                __Blazor.HiddenVilla_Client.Pages.HotelRooms.HotelRooms.TypeInference.CreateInputDate_0(__builder2, 16, 17, "form-control", 18, 
#nullable restore
#line 16 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                HomeModel.StartDate

#line default
#line hidden
#nullable disable
                , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeModel.StartDate = __value, HomeModel.StartDate)), 20, () => HomeModel.StartDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-4 col-md-3");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label class=\"text-warning\">Check Out Date</label>\r\n                        ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "disabled", "disabled");
                __builder2.AddAttribute(29, "readonly", "readonly");
                __builder2.AddAttribute(30, "type", "date");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                      HomeModel.EndDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.EndDate = __value, HomeModel.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", " col-5 col-md-3");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "<label class=\"text-warning\">No. of nights</label>\r\n                        ");
                __builder2.OpenElement(40, "select");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                            HomeModel.NoOfNights

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.NoOfNights = __value, HomeModel.NoOfNights));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(44, "option");
                __builder2.AddAttribute(45, "value", "Select");
                __builder2.AddAttribute(46, "selected");
                __builder2.AddAttribute(47, "disabled", "disabled");
                __builder2.AddContent(48, "(Select No. Of Nights)");
                __builder2.CloseElement();
#nullable restore
#line 30 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                             for (var i = 1; i <= 10; i++)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(49, "option");
                __builder2.AddAttribute(50, "value", 
#nullable restore
#line 32 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                i

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(51, 
#nullable restore
#line 32 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                    i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 33 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n                ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-8 col-md-2");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddAttribute(57, "style", "margin-top: 1.5rem !important;");
#nullable restore
#line 40 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                         if (IsProcessing)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, "<button class=\"btn btn-success btn-block form-control d-block\"><i class=\"fa fa-spin fa-spinner\">Processing...</i></button>");
#nullable restore
#line 45 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(59, "<input type=\"submit\" value=\"Update\" class=\"btn btn-success btn-block form-control d-block\" style=\"width: 100%\">");
#nullable restore
#line 49 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "mt-4 mx-4 px-0 px-md-5 mx-md-5");
#nullable restore
#line 58 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
         foreach (var room in Rooms)
        {




#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row p-2 my-3 ");
            __builder.AddAttribute(64, "style", "border-radius:20px; border: 1px solid #ffffff");
            __builder.AddMarkupContent(65, @"<div class=""col-12 col-lg-3 col-md-4""><div id=""carouselExampleIndicators"" class=""carousel slide mb-4 m-md-3 m-0 pt-3 pt-md-0"" data-ride=""carousel""><ol class=""carousel-indicators""><li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li></ol>
                        <div class=""carousel-inner""><div class=""carousel-item active""><img class=""d-block w-100"" src=""images/slide1.jpg"" alt=""First slide""></div>
                            <div class=""carousel-item""><img class=""d-block w-100"" src=""images/slide2.jpg"" alt=""Second slide""></div></div>
                        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Previous</span></a>
                        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Next</span></a></div></div>
                ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-12 col-lg-9 col-md-8");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "row pt-3");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-12 col-lg-8");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "class", "card-title text-warning");
            __builder.AddAttribute(74, "style", "font-size:xx-large");
            __builder.AddContent(75, 
#nullable restore
#line 91 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                           room.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "class", "card-text");
            __builder.AddContent(79, 
#nullable restore
#line 93 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                  (MarkupString)room.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col-12 col-lg-4 justify-content-end");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "row pb-3 pt-2");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "col-12 col-lg-11 offset-lg-1");
#nullable restore
#line 100 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                     if (room.IsBooked)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, "<button disabled class=\"btn btn-secondary btn-block\">Sold out</button>");
#nullable restore
#line 103 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "a");
            __builder.AddAttribute(89, "href", 
#nullable restore
#line 106 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                   $"hotel/room-details/{room.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(90, "class", "btn btn-success btn-block d-block");
            __builder.AddAttribute(91, "style", "width: 100%");
            __builder.AddContent(92, "Book");
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "row justify-content-end");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col-12 pb-5 text-end");
            __builder.AddAttribute(98, "style", "width: 100%");
            __builder.OpenElement(99, "span");
            __builder.AddAttribute(100, "class", "float-right");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "float-right");
            __builder.AddContent(103, "Max Occupancy : ");
            __builder.AddContent(104, 
#nullable restore
#line 114 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                   room.Occupancy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "<br>\r\n                                        ");
            __builder.OpenElement(106, "span");
            __builder.AddAttribute(107, "class", "float-right pt-1");
            __builder.AddContent(108, "Villa Size : ");
            __builder.AddContent(109, 
#nullable restore
#line 115 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                     room.SqFt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "<br>\r\n                                        ");
            __builder.OpenElement(111, "h4");
            __builder.AddAttribute(112, "class", "text-warning font-weight-bold pt-4");
            __builder.AddMarkupContent(113, "\r\n                                            USD\r\n                                            ");
            __builder.OpenElement(114, "span");
            __builder.AddAttribute(115, "style", "border-bottom:1px solid #ff6a00");
            __builder.AddContent(116, 
#nullable restore
#line 118 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                                           room.TotalAmount.ToString("#.#,00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                        ");
            __builder.OpenElement(118, "span");
            __builder.AddAttribute(119, "class", "float-right");
            __builder.AddContent(120, "Cost for ");
            __builder.AddContent(121, 
#nullable restore
#line 120 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                                            room.TotalDays

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(122, " nights");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 129 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 132 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(123, "<div style=\"position:fixed;top:50%;left:50%;margin-top:-50px;margin-left:-100px\"><img src=\"images/ajax-loader.gif\"></div>");
#nullable restore
#line 138 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
       
    private HomeVM HomeModel { get; set; } = new HomeVM();
    public IEnumerable<HotelRoomDto> Rooms { get; set; } = new List<HotelRoomDto>();
    public bool IsProcessing { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            if (await LocalStorage.GetItemAsync<HomeVM>(SD.LOCAL_INITIAL_BOOKING) != null)
            {
                HomeModel = await LocalStorage.GetItemAsync<HomeVM>(SD.LOCAL_INITIAL_BOOKING);
            }
            else
            {
                HomeModel.NoOfNights = 1;
            }

            await LoadRooms();
        }
        catch (Exception ex)
        {
            await JSRuntime.ToastrError(ex.Message);
        }
    }

    private async Task LoadRooms()
    {
        Rooms = await HotelRoomService.GetHotelRooms(HomeModel.StartDate.ToString("MM/dd/yyyy"), HomeModel.EndDate.ToString("MM/dd/yyyy"));
        foreach (var room in Rooms)
        {
            room.TotalAmount = room.RegularRate * HomeModel.NoOfNights;
            room.TotalDays = HomeModel.NoOfNights;
        }
    }

    private async Task SaveBookingInfo()
    {
        IsProcessing = true;
        HomeModel.EndDate = HomeModel.StartDate.AddDays(HomeModel.NoOfNights);
        await LocalStorage.SetItemAsync(SD.LOCAL_INITIAL_BOOKING, HomeModel);
        await LoadRooms();
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomService HotelRoomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Client.Pages.HotelRooms.HotelRooms
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
