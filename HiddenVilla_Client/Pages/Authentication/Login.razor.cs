using HiddenVilla_Client.Services;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HiddenVilla_Client.Pages.Authentication
{
    public partial class Login
    {
        private AuthenticationDto UserForAuthentication = new AuthenticationDto();
        public bool IsProcessing { get; set; }
        public bool ShowAuthenticationErrors { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public string ReturnUrl { get; set; }

        [Inject]
        IAuthenticationService AuthenticationService { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        private async Task LoginUser()
        {
            ShowAuthenticationErrors = false;
            IsProcessing = true;

            var result = await AuthenticationService.Login(UserForAuthentication);
            if (result.IsAuthSuccessful)
            {
                IsProcessing = false;

                var absoluteUri = new Uri(NavigationManager.Uri);
                var queryParam = HttpUtility.ParseQueryString(absoluteUri.Query);
                ReturnUrl = queryParam["returnUrl"];
                if (string.IsNullOrEmpty(ReturnUrl))
                {
                    NavigationManager.NavigateTo("/");
                }
                else
                {
                    NavigationManager.NavigateTo("/" + queryParam);
                }
            }
            else
            {
                IsProcessing = false;
                Errors = new List<string>() { result.ErrorMessage };
                ShowAuthenticationErrors = true;
            }
        }
    }
}
