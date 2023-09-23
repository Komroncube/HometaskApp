using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._21_09_2023_Json_Xml.Models.RedditModels
{
    public class Body
    {
        public string after { get; set; }
        public int dist { get; set; }
        public string? modhash { get; set; }
        public string? geo_filter { get; set; }
        public List<Child> children { get; set; }
    }
}
