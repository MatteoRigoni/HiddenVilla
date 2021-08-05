using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserRequestDto request);

        Task<AuthenticationResponseDto> Login(AuthenticationDto request);

        Task Logout();
    }
}
