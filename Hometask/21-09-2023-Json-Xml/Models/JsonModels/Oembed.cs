using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._21_09_2023_Json_Xml.Models.JsonModels
{
    public class Oembed
    {
        public string Author_name { get; set; }
        public int Version { get; set; }
        public string Title { get; set; }
        public string Author_url { get; set; }
        public int Thumbnail_width { get; set; }
        public int Thumbnail_height { get; set; }
        public long cache_age { get; set; }
        public string provider_url { get; set; }
        public string thumbnail_url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string Type { get; set; }
        public string Provider_name { get; set; }
        public string html { get; set; }

    }
}
