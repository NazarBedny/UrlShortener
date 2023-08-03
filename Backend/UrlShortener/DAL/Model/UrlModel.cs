using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class UrlModel
    {
        public Guid Id { get; set; }

        public string? OriginalURL { get; set; }

        public string? ShortenedURL { get; set; }

        [JsonIgnore]
        public virtual User? CreatedBy { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedDate { get; set;}
    }
}
