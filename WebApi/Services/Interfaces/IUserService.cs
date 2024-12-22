using DTOs.Login;
using Microsoft.AspNetCore.Identity;

namespace WebApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterAsync(UserDto userDto);
        Task<string> AuthenticateAsync(LoginDto loginDto);
    }
}
