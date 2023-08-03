using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.UrlService.Interfaces
{
    public interface IUrlService
    {
        public Task<Response<UrlModel>> MakeUrlShorter(string url,Guid userId);
        public Task<Response<string>> DeleteUrl(Guid id); 
        public Task<Response<List<UrlModel>>> GetAllUrls();
        public Task<Response<UrlModel>> GetUrlById(Guid id);
    }
}
