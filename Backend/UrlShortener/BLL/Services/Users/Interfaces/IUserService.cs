using DAL.Model;

namespace BLL.Services.Users.Interfaces
{
    public interface IUserService
    {
        public Task<Response<User>> GetInfoAboutUser(Guid Id);
    }
}
