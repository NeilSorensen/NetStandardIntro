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
            var client = new HttpClient();
            using (var response = client.GetAsync(url).Result)
            {
                var stringContent = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<T>(stringContent);
            }
        }
    }
}
