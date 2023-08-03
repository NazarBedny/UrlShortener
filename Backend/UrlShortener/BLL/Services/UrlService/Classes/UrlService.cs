using BLL.Services.UrlService.Interfaces;
using DAL;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Services.UrlService.Classes
{
    public class UrlService : IUrlService
    {
        private readonly UrlShortenerContext _context;
        private readonly IConfiguration _configuration;
        public UrlService(UrlShortenerContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<Response<UrlModel>> MakeUrlShorter(string originalURL,Guid userId)
        {
            var response = new Response<UrlModel>();
            //validating input URL
            if (!Uri.TryCreate(originalURL, UriKind.Absolute, out var inputUrl))
            {
                response.Errors.Add("URL has been provided");
                response.ResponseСode = System.Net.HttpStatusCode.BadRequest;
                response.Success = false;
                return response;
            }
            if (string.IsNullOrWhiteSpace(originalURL))
            {
                response.Errors.Add("Your URL is wrong");
                response.ResponseСode = System.Net.HttpStatusCode.BadRequest;
                response.Success = false;
                return response;
            }
            bool exists = _context.UrlModels.Any(x => x.OriginalURL == originalURL);
            if (exists)
            {
                response.Errors.Add("This Url is already  available");
                response.Success = false;
                response.ResponseСode = System.Net.HttpStatusCode.BadRequest;
                return response;
            }
            //Generate shortened URL
            var random = new Random();
            const string chars = "AEIOUYBCDFGHJKLMNPQRSTVWXZ123456789ab";

            var randomStr = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            var user = await _context.Users.FirstOrDefaultAsync(x=>x.Id==userId);
            if (user == null)
            {
                response.Errors.Add("User not found");
                response.Success = false;
                response.ResponseСode = System.Net.HttpStatusCode.InternalServerError;
                return response;
            }
            
            var baseUrl = _configuration["BaseUrl"]; // Get the base URL from app settings
            var shortenedUrlWithBase = $"{baseUrl}/{randomStr}".Trim();

            var sUrl = new UrlModel
            {
                Id = Guid.NewGuid(),
                OriginalURL = originalURL,
                ShortenedURL = randomStr,
                CreatedDate = DateTime.Now,
                CreatedBy = user
            };

            await _context.UrlModels.AddAsync(sUrl);
            await _context.SaveChangesAsync();
            
            response.ResponseСode = System.Net.HttpStatusCode.Created;
            response.Success = true;
            response.Data = sUrl;
            return response;
        }
        public async Task<Response<List<UrlModel>>> GetAllUrls()
        {
            var response = new Response<List<UrlModel>>();
            try
            {
                var urls = await _context.UrlModels.ToListAsync(); // Отримати всі URL-адреси з бази даних
                if (urls.Count <= 0)
                {
                    response.Success = false;
                    response.Errors.Add("No URLs found");
                    response.ResponseСode = System.Net.HttpStatusCode.NotFound;
                    return response;
                }
                response.Success = true;
                response.ResponseСode = System.Net.HttpStatusCode.OK;
                response.Data = urls;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ResponseСode = System.Net.HttpStatusCode.InternalServerError;
                response.Errors.Add("Error while fetching URLs: " + ex.Message);
                return response;
            }
        }
        public async Task<Response<string>> DeleteUrl(Guid Id)
        {
            var response = new Response<string>();
            try
            {
                var urlToDelete = await _context.UrlModels.FirstOrDefaultAsync(x=>x.Id == Id); // Отримати всі URL-адреси з бази даних
                if (urlToDelete == null)
                {
                    response.Success = false;
                    response.Errors.Add("No URLs found");
                    response.ResponseСode = System.Net.HttpStatusCode.NotFound;
                    return response;
                    
                }
                response.Success = true;
                response.ResponseСode = System.Net.HttpStatusCode.OK;
                _context.UrlModels.Remove(urlToDelete);
                await _context.SaveChangesAsync();

                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ResponseСode = System.Net.HttpStatusCode.InternalServerError;
                response.Errors.Add("Error while fetching URLs: " + ex.Message);
                return response;
            }
        }

        public async Task<Response<UrlModel>> GetUrlById(Guid id)
        {
            var response = new Response<UrlModel>();
            try
            {
                var url = await _context.UrlModels.FirstOrDefaultAsync(x=>x.Id == id); // Отримати всі URL-адреси з бази даних
                if (url == null)
                {
                    response.Success = false;
                    response.Errors.Add("No URLs found");
                    response.ResponseСode = System.Net.HttpStatusCode.NotFound;
                    return response;
                }
                response.Success = true;
                response.Data = url;
                response.ResponseСode = System.Net.HttpStatusCode.OK;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ResponseСode = System.Net.HttpStatusCode.InternalServerError;
                response.Errors.Add("Error while fetching URLs: " + ex.Message);
                return response;
            }
        }
    }
}
