using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RevloLib.Internal
{
    internal static class Requests
    {
        public static string APIKey { get; set; }

        private async static Task<string> generalRequest(string url, string method, object payload = null)
        {
            var request = WebRequest.CreateHttp(url);
            request.Method = method;
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers["x-api-key"] = APIKey;

            if (payload != null)
                using (var writer = new StreamWriter(await request.GetRequestStreamAsync()))
                    writer.Write(payload);

            var response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                string data = await reader.ReadToEndAsync();
                return data;
            }
        }

        public async static Task<T> GetGeneric<T>(string url)
        {
            return JsonConvert.DeserializeObject<T>(await generalRequest(url, "GET"));
        }

        public async static Task<T> PostGeneric<T>(string url, string payload)
        {
            return JsonConvert.DeserializeObject<T>(await generalRequest(url, "POST", payload));
        }

        public async static Task<T> PatchGeneric<T>(string url, string payload)
        {
            return JsonConvert.DeserializeObject<T>(await generalRequest(url, "PATCH", payload));
        }
    }
}
