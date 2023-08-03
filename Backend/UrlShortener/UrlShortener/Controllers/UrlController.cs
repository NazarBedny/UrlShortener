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
        public async Task<ActionResult<Response<UrlModel>>> shorteningURL(string originalURL, string userId)
        {
            var response = await _urlService.MakeUrlShorter(originalURL,Guid.Parse(userId));
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response.Data);
        }

        [HttpGet("getUrlById")]
        public async Task<ActionResult<Response<UrlModel>>> GetUrlById(Guid id)
        {
            var response = await _urlService.GetUrlById(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("getAllUrls")]
        public async Task<ActionResult<Response<List<UrlModel>>>> GetAllUrls()
        {
            var response = await _urlService.GetAllUrls();
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        [HttpDelete("deleteUrl")]
        public async Task<ActionResult<string>> DeleteUrl(Guid id)
        {
            var response = await _urlService.DeleteUrl(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}
