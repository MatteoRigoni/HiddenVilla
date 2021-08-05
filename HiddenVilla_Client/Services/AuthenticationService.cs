using Blazored.LocalStorage;
using Common;
using HiddenVilla_Client.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _locaStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthenticationService(HttpClient httpClient, ILocalStorageService locaStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _locaStorage = locaStorage;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<AuthenticationResponseDto> Login(AuthenticationDto request)
        {
            var content = JsonConvert.SerializeObject(request);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/account/signin", bodyContent);

            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<AuthenticationResponseDto>(contentTemp);

                await _locaStorage.SetItemAsync(SD.LOCAL_TOKEN, result.Token);
                await _locaStorage.SetItemAsync(SD.LOCAL_USER_DETAIL, result.UserDto);

                ((AuthStateProvider)_authenticationStateProvider).NotifyUserLoggedIn(result.Token);

                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", result.Token);

                return new AuthenticationResponseDto { IsAuthSuccessful = true };
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                return new AuthenticationResponseDto { IsAuthSuccessful = false, ErrorMessage = errorModel.ErrorMessage };
            }
        }

        public async Task Logout()
        {
            await _locaStorage.RemoveItemAsync(SD.LOCAL_TOKEN);
            await _locaStorage.RemoveItemAsync(SD.LOCAL_USER_DETAIL);

            ((AuthStateProvider)_authenticationStateProvider).NotifyUserLoggedOut();

            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegistrationResponseDto> RegisterUser(UserRequestDto request)
        {
            var content = JsonConvert.SerializeObject(request);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/account/signup", bodyContent);

            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RegistrationResponseDto>(contentTemp);

                return new RegistrationResponseDto { IsRegistrationSuccessful = true };
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorResponse = JsonConvert.DeserializeObject<RegistrationResponseDto>(contentTemp);
                return new RegistrationResponseDto { IsRegistrationSuccessful = false, Errors = errorResponse.Errors };
            }
        }

       
    }
}
