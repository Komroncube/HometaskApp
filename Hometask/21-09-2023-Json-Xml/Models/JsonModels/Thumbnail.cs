using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    public class Thumbnail
    {
        public OriginalSize original_size { get; set; }
        public int Page { get; set; }
        public Size Size { get; set; }
        public string Url { get; set; }
        public bool Resized { get; set; }
        public string Requested_size { get; set; }
    }
}
