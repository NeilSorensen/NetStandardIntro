using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StarWars
{
    public class JsonApiWrapper
    {
        public T Get<T>(string url)
        {
            var webRequest = WebRequest.Create(url);
            webRequest.Method = "GET";
            using (var response = webRequest.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
                }
            }
        }
    }
}
