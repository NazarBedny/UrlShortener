using System.Collections.Generic;
using System.Net;

namespace BLL
{
    public class Response<T> : ResponseBase
    {
        public T Data { get; set; }
    }

    public class ResponseBase
    {
        public HttpStatusCode ResponseСode { get; set; }

        public bool Success { get; set; }

        public List<string> Errors { get; set; }

        public ResponseBase()
        {
            Errors = new List<string>();
            Success = true;
        }
    }
}
