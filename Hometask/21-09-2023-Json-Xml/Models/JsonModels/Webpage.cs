using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._21_09_2023_Json_Xml.Models.JsonModels
{
    public class Webpage
    {
        public Oembed Oembed { get; set; }
        public List<Video> Videos { get; set; }
        public string Title { get; set; }
        public List<Image> Images { get; set; }
        public string Url { get; set; }
        public string Locale { get; set; }
        public string Description { get; set; }
    }
}
