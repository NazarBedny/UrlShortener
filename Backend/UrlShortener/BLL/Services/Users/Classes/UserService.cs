using BLL.Services.Users.Interfaces;
using DAL;
using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services.Users.Classes
{
    public class UserService : IUserService
    {
        private readonly UrlShortenerContext _context;

        public UserService(UrlShortenerContext context)
        {
            _context = context;
        }

        public async Task<Response<User>> GetInfoAboutUser(Guid id)
        {
            var response = new Response<User>();
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                response.Success = false;
                response.Errors.Add("User not found");
                response.ResponseСode = System.Net.HttpStatusCode.BadRequest;
                return response;
            }
            response.Success = true;
            response.ResponseСode = System.Net.HttpStatusCode.OK;
            response.Data = user;
            return response;
        }
    }
}
