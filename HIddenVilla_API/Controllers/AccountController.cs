using DataAccess.Data;
using HIddenVilla_API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HIddenVilla_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly APISettings apiSettings;

        public AccountController(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager,
            IOptions<APISettings> apiSettings)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.apiSettings = apiSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignUp([FromBody] UserRequestDto UserRequestDto)
        {
            if (UserRequestDto == null || !ModelState.IsValid)
            {
                return BadRequest(new RegistrationResponseDto() { Errors = ModelState.ToErrorsList() });
            }

            var user = new ApplicationUser
            {
                UserName = UserRequestDto.Email,
                Email = UserRequestDto.Email,
                Name = UserRequestDto.Name,
                PhoneNumber = UserRequestDto.PhoneNo,
                EmailConfirmed = true
            };

            var result = await this.userManager.CreateAsync(user, UserRequestDto.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new RegistrationResponseDto { Errors = errors, IsRegistrationSuccessful = false });
            }

            var roleResult = await this.userManager.AddToRoleAsync(user, Common.SD.ROLE_CUSTOMER);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new RegistrationResponseDto { Errors = errors, IsRegistrationSuccessful = false });
            }

            return StatusCode(201);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn([FromBody] AuthenticationDto authenticationDto)
        {
            if (authenticationDto == null || !ModelState.IsValid)
            {
                return BadRequest(new RegistrationResponseDto() { Errors = ModelState.ToErrorsList() });
            }

            var result = await this.signInManager.PasswordSignInAsync(authenticationDto.Username, authenticationDto.Password, false, false);
            if (result.Succeeded)
            {
                var user = await this.userManager.FindByNameAsync(authenticationDto.Username);
                if (user == null)
                {
                    return Unauthorized(new AuthenticationResponseDto
                    {
                        IsAuthSuccessful = false,
                        ErrorMessage = "User not found"
                    });
                }

                var signingCredentials = GetSigningCredentials();
                var claims = await GetClaims(user);

                var tokenOptions = new JwtSecurityToken(
                    issuer: this.apiSettings.ValidIssuer,
                    audience: this.apiSettings.ValidAudience,
                    claims: claims,
                    expires: DateTime.UtcNow.AddDays(7),
                    signingCredentials: signingCredentials);

                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                return Ok(new AuthenticationResponseDto
                {
                    IsAuthSuccessful = true,
                    Token = token,
                    UserDto = new UserDto()
                    {
                        Name = user.Name,
                        Id = user.Id,
                        Email = user.Email,
                        PhoneNo = user.PhoneNumber
                    }
                });
            }
            else
            {
                return Unauthorized(new AuthenticationResponseDto()
                {
                    IsAuthSuccessful = false,
                    ErrorMessage = "Invalid authentication"
                });
            }
        }

        private SigningCredentials GetSigningCredentials()
        {
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.apiSettings.SecretKey));
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims(ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim("Id", user.Id)
            };
            var roles = await this.userManager.GetRolesAsync(await this.userManager.FindByEmailAsync(user.Email));
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
    }
}
