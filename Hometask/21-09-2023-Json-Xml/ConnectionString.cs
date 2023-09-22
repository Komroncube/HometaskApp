using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask._21_09_2023_Json_Xml
{
    public static class ConnectionString
    {

        private static string jsonConnection = @"D:\KOMRON\Najot_ta'lim\dot_net\homework\4-oy\HometaskApp\Hometask\21-09-2023-Json-Xml";
        public static string GetJsonString (string filename)
        {
            string json;
            string path = Path.Combine(jsonConnection, filename);
            using(StreamReader sr = new StreamReader(path)) 
            {
                json = sr.ReadToEnd();
            }
            return json;
        }
        public static string GetXmlString(string filename)
        {
            string xml;
            string path = Path.Combine(jsonConnection, filename);
            using(StreamReader sr = new StreamReader (path))
            {
                xml = sr.ReadToEnd();
            }
            return xml;
        }

    }
}
