using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    public class HtmlResponse
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
        public Preview Preview { get; set; }
        public List<Thumbnail> Thumbnails { get; set; }
        public OriginalFile Original_file { get; set; }
        public string User_data { get; set; }

    }
}
