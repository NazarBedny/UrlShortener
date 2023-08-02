using BLL.Dtos;
using DAL.Model;

namespace BLL.Services.Authorization.Interfaces
{
    public interface ILoginService
    {
        Task<Response<LoginDto>> Login(LoginUserDto loginUserDTO);
        string CreateToken(User user);
    }
}
