using BLL.Dtos;
using BLL.Services.Registration.Interfaces;
using BLL.Validators.Authorization;
using DAL;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Services.Registration.Classes
{
    public class RegistrationService : IRegistrationService
    {
        private readonly UrlShortenerContext _context;

        public RegistrationService(UrlShortenerContext context)
        {
            _context = context;
        }

        public async Task<Response<Guid>> Register(RegistrationUserDto registrationFormDto, string role)
        {
            var response = new Response<Guid>();
            var validator = new RegistrationDtoValidator();
            var validationResult = validator.Validate(registrationFormDto);
            //data validation
            if (!validationResult.IsValid)
            {
                response.ResponseСode = System.Net.HttpStatusCode.BadRequest;
                foreach (var error in validationResult.Errors)
                {
                    response.Errors.Add(error.ErrorMessage);
                }
                response.Success = false;
                return response;
            }
            //checking whether the user already exists
            var exist = await _context.Users.AnyAsync(x => x.Email == registrationFormDto.Email);
            if (exist)
            {
                response.ResponseСode = System.Net.HttpStatusCode.BadRequest;
                response.Errors.Add("User alredy exists");
                response.Success = false;
                return response;
            }
            
            CreatePasswordHash(registrationFormDto.Password, out byte[] passwordHash, out byte[] passwordSalt);
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Name = registrationFormDto.Name,
                Surname = registrationFormDto.Surname,
                Email = registrationFormDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == role)
            };
            //adding User in database
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();  

            response.ResponseСode = System.Net.HttpStatusCode.Created;
            response.Data = user.Id;
            return response;
        }
        //method for password hashing
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
