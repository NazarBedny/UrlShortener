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
        public async Task<Response<UrlModel>> MakeUrlShorter(string originalURL)
        {
            var response = new Response<UrlModel>();
            //validating input URL
            if (!Uri.TryCreate(originalURL, UriKind.Absolute, out var inputUrl))
            {
                response.Errors.Add("URL has been provided");
                return response;
            }
            if (string.IsNullOrWhiteSpace(originalURL))
            {
                response.Errors.Add("Your URL is wrong");
                return response;
            }

            //Generate shortened URL
            var random = new Random();
            const string chars = " AEIOUYBCDFGHJKLMNPQRSTVWXZ123456789ab";

            var randomStr = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            var sUrl = new UrlModel
            {
                Id = Guid.NewGuid(),
                OriginalURL = originalURL,
                ShortenedURL = randomStr
            };
            var baseUrl = _configuration["BaseUrl"]; // Get the base URL from app settings
            var shortenedUrlWithBase = $"{baseUrl}/{randomStr}".Trim();
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
                if (urls.Count > 0)
                {
                    response.Success = false;
                    response.Errors.Add("No URLs found");
                    response.ResponseСode = System.Net.HttpStatusCode.NotFound;
                    return response;
                }
                response.Success = true;
                response.Data = urls;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
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
                response.ResponseСode = System.Net.HttpStatusCode.NoContent;
                _context.UrlModels.Remove(urlToDelete);
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Errors.Add("Error while fetching URLs: " + ex.Message);
                return response;
            }
        }
    }
}
