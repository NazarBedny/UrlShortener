using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using System;
using DAL;
using DAL.Model;
using BLL.Services.UrlService.Interfaces;
using BLL;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("api/Url")]
    public class URLShortenerController : ControllerBase
    {

        private readonly IUrlService? _urlService;
        public URLShortenerController(IUrlService urlService)
        {
            _urlService = urlService;
        }

        // POST: Create a new shortened URL
        [HttpPost("ShortenURL")]
        public async Task<ActionResult<Response<UrlModel>>> shorteningURL(string originalURL)
        {
            var response = await _urlService.MakeUrlShorter(originalURL);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response.Data);
        }

        [HttpGet("getAllUrls")]
        public async Task<List<UrlModel>> GetAllUrls()
        {
            var result =await _urlService.GetAllUrls();
            if (result.Success == true)
            {
                return result.Data;
            }
            return result.Data;
        }
        [HttpDelete("deleteUrl")]
        public async Task<string> DeleteUrl(Guid id)
        {
            var result = await _urlService.DeleteUrl(id);
            if (result.Success == true)
            {
                return result.Data;
            }
            return result.Data;
        }

    }
}
