global using Hometask._21_09_2023_Json_Xml.Models.JsonModels;

namespace Hometask
{
    public class OriginalFile
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Encoding { get; set; }
        public Metadata Metadata { get; set; }
        public string Mimetype { get; set; }
        public string Type { get; set; }
        public int Total_pages { get; set; }
        public string Extension { get; set; }
    }
}
