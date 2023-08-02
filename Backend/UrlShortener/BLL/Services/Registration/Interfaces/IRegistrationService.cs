using BLL.Dtos;

namespace BLL.Services.Registration.Interfaces
{
    public interface IRegistrationService
    {
        Task<Response<Guid>> Register(RegistrationUserDto registrationFormDto, string role);

    }
}
