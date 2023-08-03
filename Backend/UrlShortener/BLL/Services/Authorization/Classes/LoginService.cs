using BLL.Dtos;
using BLL.Services.Authorization.Interfaces;
using BLL.Validators.Authorization;

using DAL;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Services.Authorization.Classes
{
    public class LoginService : ILoginService
    {
        private readonly IConfiguration _configuration;
        private readonly UrlShortenerContext _context;

        public LoginService(IConfiguration configuration, UrlShortenerContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task<Response<LoginDto>> Login(LoginUserDto loginUserDTO)
        {
            Response<LoginDto> response = new Response<LoginDto>();
            //data validation
            var validator = new LoginDtoValidator();
            var validationResult = validator.Validate(loginUserDTO);
            if (!validationResult.IsValid)
            {
                response.ResponseСode = HttpStatusCode.BadRequest;
                foreach (var error in validationResult.Errors)
                {
                    response.Errors.Add(error.ErrorMessage);
                }
                response.Success = false;
                return response;
            }
            //validation user existion
            User user = await _context.Users.Include(u=>u.Role).FirstOrDefaultAsync(x => x.Email == loginUserDTO.Email);
            if (user == null)
            {
                response.Errors.Add("User not found");
                response.Success = false;
                response.ResponseСode = HttpStatusCode.Unauthorized;
            }
            else if (!VerifyPasswordHash(loginUserDTO.Password, user.PasswordHash, user.PasswordSalt))
            {
                response.Errors.Add("Wrong password");
                response.Success = false;
                response.ResponseСode = HttpStatusCode.Unauthorized;
            }
            else
            {
                await _context.SaveChangesAsync();
                var loginDto = new LoginDto
                {
                    Id = user.Id,
                    Token = CreateToken(user)
                };
                response.Data = loginDto;
                response.ResponseСode = HttpStatusCode.OK;
            }
            return response;
        }

        //comparison to match in hashing
        private static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (HMACSHA512 hmac = new HMACSHA512(passwordSalt))
            {
                byte[] computerHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computerHash.Length; i++)
                {
                    if (passwordHash[i] != computerHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        // creation Jwt Token
        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, user.Role.Name)
            };

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            SigningCredentials creads = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creads
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
