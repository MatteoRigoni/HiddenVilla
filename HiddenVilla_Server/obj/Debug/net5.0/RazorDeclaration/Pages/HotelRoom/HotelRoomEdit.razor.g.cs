// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.HotelRoom
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomEdit.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomEdit.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomEdit.razor"
using HiddenVilla_Server.Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{Id:int}")]
    public partial class HotelRoomEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\matte\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomEdit.razor"
       
    [Parameter]
    public int? Id { get; set; }

    private HotelRoomDto HotelRoomModel { get; set; } = new HotelRoomDto();
    private HotelRoomImageDto RoomImage { get; set; } = new HotelRoomImageDto();
    private string Title { get; set; } = "Create";
    private List<string> DeletedImageNames { get; set; } = new List<string>();

    public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();

    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }

    private bool IsLoading = false;

    protected override async Task OnInitializedAsync()
    {
        var authenticationState = await AuthenticationState;
        if (!authenticationState.User.IsInRole(Common.SD.ROLE_ADMIN))
        {
            var uri = new Uri(NavigationManager.Uri);
            NavigationManager.NavigateTo($"/Identity/Account/Login?returnUrl={uri.LocalPath}", true);
        }

        if (Id.HasValue)
        {
            // update
            Title = "Update";
            HotelRoomModel = await HotelRoomRepository.GetHotelRoom(Id.Value);
            if (HotelRoomModel?.HotelRoomImages != null)
            {
                HotelRoomModel.ImageUrls = HotelRoomModel.HotelRoomImages.Select(u => u.RoomImageUrl).ToList();
            }
        }
        else
        {
            // create
            HotelRoomModel = new HotelRoomDto();
        }
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
            return;

        bool loading = true;
        while(loading)
        {
            try
            {
                if (!string.IsNullOrEmpty(HotelRoomModel.Details))
                {
                    await this.QuillHtml.LoadHTMLContent(HotelRoomModel.Details);
                }
                loading = false;
            }
            catch (Exception)
            {
                await Task.Delay(10);
                loading = true;
            }
        }
    }

    private async Task HandleHotelRoomUpsert()
    {
        try
        {
            var exists = await HotelRoomRepository.IsHotelNameAlreadyPresent(HotelRoomModel.Name, HotelRoomModel.Id);
            if (exists)
            {
                await JSRuntime.ToastrError("Room name already exists");
                return;
            }

            if (HotelRoomModel.Id != 0 && Title == "Update")
            {
                // update scenario
                HotelRoomModel.Details = await QuillHtml.GetHTML();
                var updatedRoomResult = await HotelRoomRepository.UpdateHotelRoom(HotelRoomModel.Id, HotelRoomModel);
                if ((HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Any())
                    || (DeletedImageNames != null && DeletedImageNames.Any()))
                {
                    if (DeletedImageNames != null && DeletedImageNames.Any())
                    {
                        foreach (var deletedImageName in DeletedImageNames)
                        {
                            var imageName = deletedImageName.Replace($"{NavigationManager.BaseUri}RoomImages/", "");
                            var result = FileUpload.DeleteFile(imageName);

                            await HotelImagesRepository.DeleteHotelRoomImageByImageUrl(deletedImageName);
                        }
                    }

                    await AddHOtelRoomImage(updatedRoomResult);
                }
                await JSRuntime.ToastrSuccess("Hotel room updated successfully");
            }
            else
            {
                // create scenario
                HotelRoomModel.Details = await QuillHtml.GetHTML();

                var createdResult = await HotelRoomRepository.CreateHotelRoom(HotelRoomModel);
                await AddHOtelRoomImage(createdResult);
                await JSRuntime.ToastrSuccess("Hotel room created successfully");
            }

            NavigationManager.NavigateTo("hotel-room");
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        try
        {
            IsLoading = true;

            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".png" ||
                        fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                }

                if (images.Any())
                {
                    if (HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Any())
                    {
                        HotelRoomModel.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        HotelRoomModel.ImageUrls = new List<string>();
                        HotelRoomModel.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JSRuntime.ToastrError("Please select a valid format!");
                }
            }
        }
        catch (Exception ex)
        {
            await JSRuntime.ToastrError(ex.Message);
        }

        IsLoading = false;
    }

    private async Task AddHOtelRoomImage(HotelRoomDto roomDetails)
    {
        foreach (var imageUrl in HotelRoomModel?.ImageUrls)
        {
            if (HotelRoomModel.HotelRoomImages == null ||
                HotelRoomModel.HotelRoomImages.Where(x => x.RoomImageUrl == imageUrl).Count() == 0)
            {

                RoomImage = new HotelRoomImageDto()
                {
                    RoomId = roomDetails.Id,
                    RoomImageUrl = imageUrl
                };
                await HotelImagesRepository.CreateHotelRoomImage(RoomImage);
            }
        }
    }

    private async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = HotelRoomModel.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{NavigationManager.BaseUri}RoomImages/", "");
            if (HotelRoomModel.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                // update scenario
                DeletedImageNames ??= new List<string>();
                DeletedImageNames.Add(imageUrl);
            }
            HotelRoomModel.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {
            await JSRuntime.ToastrError(ex.Message);
        }
    }

    //public async void SetHTML()
    //{
    //    if (string.IsNullOrEmpty(HotelRoomModel.Details))
    //    {
    //        await this.QuillHtml.LoadHTMLContent(HotelRoomModel.Details);
    //    }
    //    StateHasChanged();
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelImageRepository HotelImagesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591