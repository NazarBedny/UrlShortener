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
        public Task<Response<UrlModel>> MakeUrlShorter(string Url);
        public Task<Response<string>> DeleteUrl(Guid Id);
        public Task<Response<List<UrlModel>>> GetAllUrls();
    }
}
