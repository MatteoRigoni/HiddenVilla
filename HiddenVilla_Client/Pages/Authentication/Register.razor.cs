using HiddenVilla_Client.Services;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Pages.Authentication
{
    public partial class Register
    {
        private UserRequestDto UserForRegistration = new UserRequestDto();
        public bool IsProcessing { get; set; }
        public bool ShowRegistrationErrors { get; set; }
        public IEnumerable<string> Errors { get; set; }

        [Inject]
        IAuthenticationService AuthenticationService { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        private async Task RegisterUser()
        {
            ShowRegistrationErrors = false;
            IsProcessing = true;

            var result = await AuthenticationService.RegisterUser(UserForRegistration);
            if (result.IsRegistrationSuccessful)
            {
                IsProcessing = false;
                NavigationManager.NavigateTo("/login");
            }
            else
            {
                IsProcessing = false;
                Errors = result.Errors;
                ShowRegistrationErrors = true;
            }
        }
    }
}
