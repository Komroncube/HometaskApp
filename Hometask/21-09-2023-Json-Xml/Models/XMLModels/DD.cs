using Hometask._21_09_2023_Json_Xml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._21_09_2023_Json_Xml.XML_files
{
    public class DD
    {
        public Guid siteKey { get; set; }
        public string id { get; set; }
        public SMT SMT { get; set; }
        public DDStatus DDStatus { get; set; }
        public Address[] Address { get; set; }
    }
}
